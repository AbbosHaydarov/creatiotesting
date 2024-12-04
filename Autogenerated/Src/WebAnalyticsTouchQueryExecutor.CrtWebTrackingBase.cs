namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: WebAnalyticsTouchQueryExecutor

	[DefaultBinding(typeof(IEntityQueryExecutor), Name = "WebAnalyticsTouchQueryExecutor")]
	public class WebAnalyticsTouchQueryExecutor : BaseWebAnalyticsDataQueryExecutor, IEntityQueryExecutor
	{

		#region Constructors: Protected

		/// <inheritdoc/>
		public WebAnalyticsTouchQueryExecutor(UserConnection userConnection) : base (userConnection) { }

		#endregion

		#region Properties: Protected

		/// <inheritdoc/>
		protected override string EntitySchemaName => "Touch";

		#endregion

		#region Methods: Protected

		protected override EntitySchemaQueryFilterCollection CreateContactFilters(EntitySchemaQuery esq, Guid contactId) {
			var contactFilters = new EntitySchemaQueryFilterCollection(esq);
			contactFilters.LogicalOperation = LogicalOperationStrict.Or;
			contactFilters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"Contact", contactId));
			contactFilters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[WebAnalyticsVisitor:Id:WebAnalyticsVisitorId].Contact", contactId));
			return contactFilters;
		}

		#endregion

	}

	#endregion

}
