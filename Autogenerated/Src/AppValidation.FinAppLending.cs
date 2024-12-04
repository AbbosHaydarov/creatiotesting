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

	#region Class: AppValidation_FinAppLendingEventsProcess

	public partial class AppValidation_FinAppLendingEventsProcess<TEntity>
	{

		#region Methods: Public
		
		public virtual void GenerateNameByValidationItem() {
			Guid validationId = Entity.GetTypedColumnValue<Guid>("ValidationItemId");
			if (validationId != Guid.Empty) {
				var appValidationItemEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "AppValidationItem");
				var appValidationItemNameColumn = appValidationItemEsq.AddColumn("Name");
				var appValidationItemEntity = appValidationItemEsq.GetEntity(UserConnection, validationId);
				if (appValidationItemEntity != null) {
					string appValidationItemName =
						appValidationItemEntity.GetTypedColumnValue<string>(appValidationItemNameColumn.Name);
					Entity.SetColumnValue("Name", appValidationItemName);
				}
			}
		}

		public virtual void FillAppValQuestionResult() {
			var newValidationItemId = Entity.GetTypedColumnValue<Guid>("ValidationItemId");
			if (OldValidationItemId != newValidationItemId) {
				ClearAppValQuestionResult();
				List<string> excludeColumnNames = new List<string>() { "AppValidationItem" };
				var dataTransfer = new DataTransfer(UserConnection);
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "AppValidationQuestion");
				esq.PrimaryQueryColumn.IsAlwaysSelect = true;
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "AppValidationItem",
					newValidationItemId));
				EntityCollection appValidationQuestionCollection = esq.GetEntityCollection(UserConnection);
				if (appValidationQuestionCollection.Count > 0) {
					foreach (Terrasoft.Core.Entities.Entity appValidationQuestion in appValidationQuestionCollection) {
						Terrasoft.Core.Entities.Entity newAppValQuestionResult = dataTransfer
							.CopyTo(appValidationQuestion.PrimaryColumnValue, "AppValidationQuestion", "AppValQuestionResult",
							null, excludeColumnNames);
						newAppValQuestionResult.SetColumnValue("AppValidationId", Entity.PrimaryColumnValue);
						newAppValQuestionResult.Save();
					}
				}
			}
		}

		public virtual void ClearAppValQuestionResult() {
			var delete = new Delete(UserConnection).From("AppValQuestionResult").Where("AppValQuestionResult", "AppValidationId")
				.IsEqual(Column.Parameter(Entity.PrimaryColumnValue)) as Delete;
			delete.Execute();
		}

		#endregion

	}

	#endregion

}

