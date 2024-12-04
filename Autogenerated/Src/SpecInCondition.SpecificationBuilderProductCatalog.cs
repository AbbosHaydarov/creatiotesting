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

	#region Class: SpecInCondition_SpecificationBuilderProductCatalogEventsProcess

	public partial class SpecInCondition_SpecificationBuilderProductCatalogEventsProcess<TEntity>
	{
		#region Properties: Private

		private string SpecTableValueSchemaName => "SpecTableValue";

		#endregion

		#region Methods: Private

		private void DeleteEntityInCollection(EntityCollection entities) {
			while (entities.Any()) {
				entities.First().Delete();
			}
		}

		private object[] GetSpecTableValueIds() {
			var resultSpecTableValueIds = new object[2] {
				Entity.GetTypedColumnValue<Guid>("SpecTableValueXId"),
				Entity.GetTypedColumnValue<Guid>("SpecTableValueYId")
			};
			return resultSpecTableValueIds.Where(e => !e.Equals(Guid.Empty)).ToArray();
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Get related SpecTableValue schema items.
		/// </summary>
		/// <returns><see cref="EntityCollection"/>.</returns>
		protected virtual EntityCollection GetSpecTableValueItems(object[] filtersValue) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, SpecTableValueSchemaName);
			esq.UseAdminRights = false;
			esq.AddAllSchemaColumns();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", filtersValue));
			return esq.GetEntityCollection(UserConnection);
		}

		/// <summary>
		/// Delete related opportunity condition.
		/// </summary>
		protected virtual void DeleteSpecTableValue() {
			var specTableValues = GetSpecTableValueIds();
			if (!specTableValues.Any()) {
				return;
			}

			var specTableValueCollection = GetSpecTableValueItems(specTableValues);
			DeleteEntityInCollection(specTableValueCollection);
		}

		#endregion
		
		#region Methods: Public

		/// <summary>
		/// Delete related entities.
		/// </summary>
		public virtual void DeleteRelatedEntityItems() {
			//DeleteSpecTableValue();
		}

		#endregion

	}

	#endregion

}

