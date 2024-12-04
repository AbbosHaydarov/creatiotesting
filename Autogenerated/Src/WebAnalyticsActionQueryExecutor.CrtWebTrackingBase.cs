namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: WebAnalyticsActionQueryExecutor

	[DefaultBinding(typeof(IEntityQueryExecutor), Name = "WebAnalyticsActionQueryExecutor")]
	public class WebAnalyticsActionQueryExecutor : BaseWebAnalyticsDataQueryExecutor, IEntityQueryExecutor
	{

		#region Constructors: Protected

		/// <inheritdoc/>
		public WebAnalyticsActionQueryExecutor(UserConnection userConnection) : base(userConnection) { }

		#endregion

		#region Properties: Protected

		/// <inheritdoc/>
		protected override string EntitySchemaName => "TouchAction";

		#endregion

		#region Methods: Protected

		/// <inheritdoc/>
		protected override EntitySchemaQueryFilterCollection CreateContactFilters(EntitySchemaQuery esq, Guid contactId) {
			var contactFilters = new EntitySchemaQueryFilterCollection(esq);
			contactFilters.LogicalOperation = LogicalOperationStrict.Or;
			contactFilters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[Touch:Id:TouchId].Contact", contactId));
			contactFilters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[Touch:Id:TouchId].[WebAnalyticsVisitor:Id:WebAnalyticsVisitor].Contact", contactId));
			return contactFilters;
		}

		#endregion

	}

	#endregion

}
