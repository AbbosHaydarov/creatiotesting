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

	#region Class: FinIndicator_FinancialIndicatorEventsProcess

	public partial class FinIndicator_FinancialIndicatorEventsProcess<TEntity>
	{

		#region Methods: Private

		/// <summary>
		/// Returns finIndicator type name by finIndicator type id.
		/// <param name="typeId">FinIndicator type id.</param>
		/// </summary>
		/// <returns>string</returns>
		private string GetTypeNameById(Guid typeId) {
			if (typeId.IsEmpty()) {
				return string.Empty;
			}
			Select select = new Select(UserConnection).Column("Name").From("FinIndicatorType")
				.Where("Id").IsEqual(Column.Parameter(typeId)) as Select;
			return select.ExecuteScalar<string>();
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Checks need to update primary display column value.
		/// </summary>
		/// <returns>boolean</returns>
		protected bool IsNeedUpdatePrimaryDisplayColumnValue() {
			return Entity.Schema.PrimaryDisplayColumn != null && Entity.GetChangedColumnValues().Any(cc => cc.Name.Equals("TypeId"));
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Update primary display column value.
		/// </summary>
		public void UpdatePrimaryDisplayColumnValue() {
			if (IsNeedUpdatePrimaryDisplayColumnValue()) {
				string typeName = GetTypeNameById(Entity.GetTypedColumnValue<Guid>("TypeId"));
				Entity.PrimaryDisplayColumnValue = typeName;
			}
		}

		#endregion

	}

	#endregion

}
