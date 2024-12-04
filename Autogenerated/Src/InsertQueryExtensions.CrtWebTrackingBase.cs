namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	#region Class: InsertQueryExtensions

	public static class InsertQueryExtensions
	{

		#region Methods: Public

		public static Insert SetIntColumn(this Insert query, string columnAlias, string value, int defaultValue) {
			var intValue = value == null
				? defaultValue
				: int.Parse(value);
			return query.Set(columnAlias, Column.Parameter(intValue));
		}

		public static Insert TrySetLookupValue(this Insert query, string column,
				Dictionary<string, Guid> lookupValues, string lookupKey, bool isUpper = false) {
			var existedColumn = query.ColumnValues.FirstOrDefault(x => x.SourceColumnAlias == column);
			lookupKey = isUpper ? lookupKey?.ToUpper() : lookupKey;
			if (string.IsNullOrWhiteSpace(lookupKey) || !lookupValues.TryGetValue(lookupKey, out var value)) {
				if (existedColumn == default(ModifyQueryColumnValue)) {
					var nullGuid = Column.Parameter(DBNull.Value,
						new GuidDataValueType(query.UserConnection.DataValueTypeManager));
					query.Set(column, nullGuid);
				}
				return query;
			}
			if (existedColumn != default(ModifyQueryColumnValue)) {
				query.ColumnValues.Remove(existedColumn);
			}
			query.Set(column, Column.Parameter(value));
			return query;
		}

		#endregion

	}

	#endregion

}
