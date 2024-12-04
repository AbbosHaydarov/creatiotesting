namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using System.Linq;

	#region Class: TouchPointRepositoryBase

	public abstract class TouchPointRepositoryBase {

		#region Class: Protected

		protected class VisitModel {
			public string VisitDuration { get; set; }
			public string LastActionDateTime { get; set; }
		}

		#endregion

		#region Fields: Protected

		protected readonly Dictionary<string, Dictionary<string, Guid>> LookupValues =
			new Dictionary<string, Dictionary<string, Guid>>();

		#endregion

		#region Properties: Public

		/// <summary>
		/// Specific code column name in the internal lookups.
		/// </summary>
		public string CodeColumnName { get; set; }

		#endregion

		#region Properties: Public

		public UserConnection UserConnection { get; set; }

		/// <summary>
		/// Instance of <see cref="ITouchSource"/> to define touch channel and source.
		/// </summary>
		private ITouchSource _sourceHelper;
		public ITouchSource SourceHelper {
			get => _sourceHelper ?? (_sourceHelper =
				ClassFactory.Get<ITouchSource>(new ConstructorArgument("userConnection", UserConnection)));
			set => _sourceHelper = value;
		}

		#endregion

		#region Methods: Protected

		protected DateTime ConvertTimestampToDateTime(int timestamp) {
			return DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
		}

		protected void AddLookupFilterCondition(Select select, string codeColumn, IEnumerable<string> codes,
				bool isUpperCase) {
			if (isUpperCase) {
				select.Where(Func.Upper(codeColumn)).In(Column.Parameters(codes));
			} else {
				select.Where(codeColumn).In(Column.Parameters(codes));
			}
		}

		protected void AddIfNotExists<K, V>(Dictionary<K, V> dictionary, K key, V value) {
			if (dictionary.ContainsKey(key)) {
				return;
			}
			dictionary.Add(key, value);
		}

		protected Dictionary<string, Guid> GetLookupIdByCode(string lookup, string codeColumn, IEnumerable<string> codes,
				bool isUpperCase = false) {
			var result = new Dictionary<string, Guid>();
			var chunks = codes.SplitOnChunks(chunkSize: 500);
			foreach (var chunk in chunks) {
				var select = new Select(UserConnection)
					.Column("Id")
					.Column(codeColumn)
					.From(lookup);
				AddLookupFilterCondition(select, codeColumn, chunk, isUpperCase);
				select.SpecifyNoLockHints();
				select.ExecuteReader(r => {
					var id = r.GetColumnValue<Guid>("Id");
					var code = r.GetColumnValue<string>(codeColumn) ?? "";
					AddIfNotExists(result, isUpperCase ? code.ToUpper() : code.ToLower(), id);
				});
			}
			return result;
		}

		protected string CleanupUrl(string url) {
			if (!Uri.TryCreate(url, UriKind.Absolute, out var uri)) {
				return url;
			}
			if (string.IsNullOrWhiteSpace(uri.Query)) {
				return uri.AbsoluteUri;
			}
			return uri.AbsoluteUri.Replace(uri.Query, "");
		}

		protected string GetWebPageCode(string title, string url) => $"{title}{url}";

		protected bool IsTouchModified(TouchModel touch, int duration, DateTime actionDate) {
			return touch.Duration != duration || touch.LastActionDateTime != actionDate;
		}

		protected void UpdateTouch(Guid id, int duration, DateTime lastActionDate) {
			var update = new Update(UserConnection, "Touch")
				.Set("Duration", Column.Parameter(duration))
				.Set("LastActionDateTime", Column.Parameter(lastActionDate))
				.Where("Id").IsEqual(Column.Parameter(id)) as Update;
			update.WithHints(new RowLockHint());
			update.Execute();
		}

		protected Dictionary<string, TouchModel> GetExistedTouchIdsForVisits(IEnumerable<string> visitIds) {
			var touchIds = new Dictionary<string, TouchModel>();
			if (!visitIds.Any()) {
				return touchIds;
			}
			var select = new Select(UserConnection)
				.Column("SessionId")
				.Column("Id")
				.Column("Duration")
				.Column("LastActionDateTime")
				.From("Touch")
				.Where("SessionId").In(Column.Parameters(visitIds)) as Select;
			select.SpecifyNoLockHints();
			select.ExecuteReader(reader => {
				var visitId = reader.GetColumnValue<string>("SessionId");
				var touchId = reader.GetColumnValue<Guid>("Id");
				var duration = reader.GetColumnValue<int>("Duration");
				var lastActionDate = reader.GetColumnValue<DateTime>("LastActionDateTime");
				touchIds.Add(visitId, new TouchModel {
					Id = touchId,
					Duration = duration,
					LastActionDateTime = lastActionDate
				});
			});
			return touchIds;
		}

		protected string GetCityCode(string countryCode, string cityName, string regionCode) =>
			$"{GetCityCode(countryCode, cityName)}{regionCode ?? ""}";

		protected string GetCityCode(string countryCode, string cityName) =>
			$"{countryCode}:{cityName}:";

		protected Dictionary<string, Guid> GetCityIds(Dictionary<string, IEnumerable<string>> countries, bool useRegion = true,
				string cityIdColumn = "Name") {
			var result = new Dictionary<string, Guid>();
			foreach (var country in countries) {
				var countryCode = country.Key;
				if (!LookupValues["Country"].TryGetValue(countryCode, out var countryId)) {
					continue;
				}
				var cityIdentifiers = country.Value.Where(x => !string.IsNullOrWhiteSpace(x)).Distinct();
				var chunks = cityIdentifiers.SplitOnChunks(chunkSize: 500);
				foreach (var chunk in chunks) {
					var citiesSelect = new Select(UserConnection)
						.Column("c", "Id").As("Id")
						.Column("c", cityIdColumn).As(cityIdColumn);
					if (useRegion) {
						citiesSelect.Column("r", "Code").As("RegionCode");
					}
					citiesSelect.From("City").As("c")
						.LeftOuterJoin("Region").As("r").On("c", "RegionId").IsEqual("r", "Id")
						.Where("c", "CountryId").IsEqual(Column.Parameter(countryId))
							.And("c", cityIdColumn).In(Column.Parameters(chunk));
					citiesSelect.SpecifyNoLockHints();
					citiesSelect.ExecuteReader(r => {
						var cityId = r.GetColumnValue<Guid>("Id");
						var cityName = r.GetColumnValue<string>(cityIdColumn);
						var regionCode = useRegion ? r.GetColumnValue<string>("RegionCode") : string.Empty;
						var cityCode = GetCityCode(countryCode, cityName, regionCode);
						AddIfNotExists(result, cityCode, cityId);
					});
				}
			}
			return result;
		}

		protected Dictionary<string, Guid> SaveNewTouchActionTypes(IEnumerable<string> newTypes) {
			var result = new Dictionary<string, Guid>();
			var insert = new Insert(UserConnection).Into("TouchActionType");
			foreach (var type in newTypes) {
				var id = Guid.NewGuid();
				insert.Values()
					.Set("Id", Column.Parameter(id))
					.Set("Name", Column.Parameter(type))
					.Set(CodeColumnName, Column.Parameter(type));
				result.Add(type, id);
			}
			if (insert.ColumnValues.IsNotEmpty()) {
				insert.Execute();
				return result;
			}
			return new Dictionary<string, Guid>();
		}

		protected Dictionary<string, Guid> SaveNewReferrerTypes(IEnumerable<(string code, string name)> newTypes) {
			var result = new Dictionary<string, Guid>();
			var insert = new Insert(UserConnection).Into("ReferrerType");
			foreach (var (code, name) in newTypes) {
				var id = Guid.NewGuid();
				insert.Values()
					.Set("Id", Column.Parameter(id))
					.Set("Name", Column.Parameter(name))
					.Set(CodeColumnName, Column.Parameter(code));
				result.Add(code, id);
			}
			if (insert.ColumnValues.IsNotEmpty()) {
				insert.Execute();
				return result;
			}
			return new Dictionary<string, Guid>();
		}

		protected Dictionary<string, Guid> ActualizeTouchActionTypes(IEnumerable<string> types) {
			var actionTypes = types
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.Distinct();
			var existingActionTypes = GetExistingLookupValues("TouchActionType");
			var newTypes = actionTypes.Where(x => !existingActionTypes.Keys.Contains(x));
			if (newTypes.Any()) {
				var result = SaveNewTouchActionTypes(newTypes);
				existingActionTypes.AddRange(result);
			}
			return existingActionTypes;
		}

		protected Dictionary<string, Guid> ActualizeCountries(IEnumerable<string> countryCodes, bool isUpperCase = false) {
			var codes = countryCodes
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.Select(x => x.ToUpper())
				.Distinct();
			if (codes.IsEmpty()) {
				return new Dictionary<string, Guid>();
			}
			var countries = GetLookupIdByCode("Country", "Alpha2Code", codes, isUpperCase);
			return countries;
		}

		protected Dictionary<string, Guid> GetExistingLookupValues(string lookupName) {
			var select = new Select(UserConnection)
				.Column("Id")
				.Column(CodeColumnName)
				.From(lookupName)
				.Where(CodeColumnName).Not().IsNull() as Select;
			select.SpecifyNoLockHints();
			var result = new Dictionary<string, Guid>();
			select.ExecuteReader(reader => {
				var code = reader.GetColumnValue<string>(CodeColumnName);
				var id = reader.GetColumnValue<Guid>("Id");
				AddIfNotExists(result, code, id);
			});
			return result;
		}

		#endregion

	}

	#endregion

}
