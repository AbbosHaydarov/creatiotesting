namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using global::Common.Logging;
	using Terrasoft.Common;

	#region Class: WebAnalyticsVisitorRepository

	/// <summary>
	/// Class to represent repository for the web page visitors' saving.
	/// </summary>
	public class WebAnalyticsVisitorRepository
	{

		#region Fields: Private

		private UserConnection _userConnection;
		private ILog _logger;
		private Guid _analitycsPlatformId;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="WebAnalyticsVisitorRepository"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="logger">The logger.</param>
		/// <param name="analitycsPlatformId">The analytics platform identifier.</param>
		public WebAnalyticsVisitorRepository(UserConnection userConnection, ILog logger, Guid analitycsPlatformId) {
			_userConnection = userConnection;
			_logger = logger;
			_analitycsPlatformId = analitycsPlatformId;
		}

		#endregion

		#region Methods: Private

		private EntitySchemaQuery GetVisitorQuery(string visitorId, Guid contactId, Guid streamId) {
			var esqResult = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "WebAnalyticsVisitor") {
				PrimaryQueryColumn = { IsVisible = true }
			};
			esqResult.AddColumn("Id");
			esqResult.AddColumn("Contact");
			esqResult.AddColumn("VisitorId");
			esqResult.AddColumn("WebAnalyticsStream");
			var filterByContactId =
				esqResult.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactId);
			esqResult.Filters.Add(filterByContactId);
			var filterByVisitorId =
				esqResult.CreateFilterWithParameters(FilterComparisonType.Equal, "VisitorId", visitorId);
			esqResult.Filters.Add(filterByVisitorId);
			var filterByStreamId =
				esqResult.CreateFilterWithParameters(FilterComparisonType.Equal, "WebAnalyticsStream", streamId);
			esqResult.Filters.Add(filterByStreamId);
			return esqResult;
		}

		private Guid SaveVisitor(WebAnalyticsVisitorModel model) {
			var entity = _userConnection.EntitySchemaManager.GetInstanceByName("WebAnalyticsVisitor")
				.CreateEntity(_userConnection);
			entity.SetDefColumnValues();
			entity.SetColumnValue("ContactId", model.ContactId);
			entity.SetColumnValue("WebAnalyticsStreamId", model.StreamId);
			entity.SetColumnValue("VisitorId", model.VisitorId);
			var result = entity.Save();
			return result ? entity.PrimaryColumnValue : Guid.Empty;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Searches for web analytics visitor.
		/// </summary>
		/// <param name="model">Web analytics visitor model.</param>
		/// <returns>Identifier of the found visitor.</returns>
		public virtual Guid FindVisitor(WebAnalyticsVisitorModel model) {
			var esq = GetVisitorQuery(model.VisitorId, model.ContactId, model.StreamId);
			return esq.GetEntityCollection(_userConnection).Any()
				? esq.GetEntityCollection(_userConnection).FirstOrDefault().PrimaryColumnValue
				: Guid.Empty;
		}

		/// <summary>
		/// Saves new Contact - Visitor mappings.
		/// </summary>
		/// <param name="model">Web analytics visitor model.</param>
		/// <returns>Identifier of the saved visitor.</returns>
		public virtual Guid Save(WebAnalyticsVisitorModel model) {
			var result = Guid.Empty;
			try {
				return SaveVisitor(model);
			} catch (Exception ex) {
				_logger.Error(
					$"Visitor {model.VisitorId} for contact {model.ContactId} is not saved (stream {model.StreamId})",
					ex);
				return result;
			}
		}

		#endregion

	}

	#endregion

}


