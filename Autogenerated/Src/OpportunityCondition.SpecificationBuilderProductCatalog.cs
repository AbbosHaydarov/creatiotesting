namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess

	public partial class OpportunityCondition_SpecificationBuilderProductCatalogEventsProcess<TEntity>
	{
		#region Properties: Private
		
		private string SpecInConditionSchemaName => "SpecInCondition";
		private Guid PrimaryColumnValue => Entity.PrimaryColumnValue;
		private string OpportunityConditionColumnName => "OpportunityCondition";
		
		#endregion

		#region Methods: Private

		private void DeleteEntityInCollection(EntityCollection entities) {
			while (entities.Any()) {
				entities.First().Delete();
			}
		}
		
		#endregion
		
		#region Methods: Protected

		/// <summary>
		/// Get related SpecInCondition schema items.
		/// </summary>
		/// <returns><see cref="EntityCollection"/>.</returns>
		protected virtual EntityCollection GetSpecInConditionItems() {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, SpecInConditionSchemaName);
			esq.AddAllSchemaColumns();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				OpportunityConditionColumnName,
				PrimaryColumnValue));
			return esq.GetEntityCollection(UserConnection);
		}

		protected virtual void DeleteSpecInConditionItems() {
			var specInConditionCollection = GetSpecInConditionItems();
			DeleteEntityInCollection(specInConditionCollection);
		}

		protected virtual void DeleteSpecificationsInOpportunityCondition() {
			Select unionSelect = new Select(UserConnection).Distinct()
					.Column("SpecTableValueXId").As("TableValueId")
				.From("SpecInCondition")
				.Where("OpportunityConditionId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue))
				.And("SpecTableValueXId").Not().IsNull() as Select;

			Select selectTableValueIds = new Select(UserConnection).Distinct()
					.Column("SpecTableValueYId").As("TableValueId")
				.From("SpecInCondition")
				.Where("OpportunityConditionId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue))
					.And("SpecTableValueYId").Not().IsNull()
				.Union(unionSelect) as Select;

			List<Guid> tableValueIds = new List<Guid>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = selectTableValueIds.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						tableValueIds.Add(dataReader.GetColumnValue<Guid>("TableValueId"));
					}
				}
			}

			Delete deleteSpecifications = new Delete(UserConnection)
				.From("SpecInCondition")
				.Where("OpportunityConditionId").IsEqual(Column.Parameter(Entity.PrimaryColumnValue)) as Delete;

			deleteSpecifications.Execute();

			if (tableValueIds.Count == 0) {
				return;
			}

			Delete deleteTableValues = new Delete(UserConnection)
				.From("SpecTableValue")
				.Where("Id").In(Column.Parameters(tableValueIds)) as Delete;

			deleteTableValues.Execute();
		}

		#endregion

		#region Methods: Public

		public virtual void DeleteRelatedEntities() {
			DeleteSpecificationsInOpportunityCondition();
		}

		#endregion

	}

	#endregion

}

