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
	using Terrasoft.Configuration;
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

	#region Class: ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess

	public partial class ChangeCriteriaInCondition_ProductBankCustomerJourneyEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void FillDisplayValue() {
			Guid changeCriteriaId = Entity.GetTypedColumnValue<Guid>("ChangeCriteriaId");
			EntitySchema changeCriteriaSchema = UserConnection.EntitySchemaManager.FindInstanceByName("ChangeCriteria");
			Entity changeCriteriaEntity = changeCriteriaSchema.CreateEntity(UserConnection);
			Guid specificationType = new Guid();
			var columns = new List<string>() {"Specification"};
			if (changeCriteriaEntity.FetchFromDB("Id", changeCriteriaId, columns)) {
				Guid specificationId = changeCriteriaEntity.GetTypedColumnValue<Guid>("SpecificationId");
				specificationType = GetSpecificationType(specificationId);
			}
			string value = GetSpecificationDisplayValue(specificationType);
			Entity.SetColumnValue("DisplayValue", value);
		}

		public virtual string GetSpecificationDisplayValue(Guid specificationTypeId) {
			string result = string.Empty;
			switch (specificationTypeId.ToString("D").ToLower()) {
				case SpecificationUtilities.StringType:
					result = Entity.GetTypedColumnValue<string>("StringValue");
					break;
				case SpecificationUtilities.FloatType:
					float floatValue = Entity.GetTypedColumnValue<float>("FloatValue");
					result = floatValue.ToString("f");
					break;
				case SpecificationUtilities.BooleanType:
					bool boolValue = Entity.GetTypedColumnValue<bool>("BooleanValue");
					result = boolValue ? TrueString : FalseString;
					break;
				case SpecificationUtilities.IntegerType:
					int intValue = Entity.GetTypedColumnValue<int>("IntegerValue");
					result = intValue.ToString();
					break;
				case SpecificationUtilities.LookupType:
					Entity.LoadLookupDisplayValues();
					result = Entity.GetTypedColumnValue<string>("SpecificationListItemName");
					break;
				default: 
					throw new ArgumentException(UnsupportedSpecificationType);
			};
			return result;
		}

		public virtual Guid GetSpecificationType(Guid specificationId) {
			EntitySchema specificationSchema = UserConnection.EntitySchemaManager.FindInstanceByName("Specification");
			Guid specificationType = new Guid();
			Entity specificationEntity = specificationSchema.CreateEntity(UserConnection);
			var columns = new List<string>() {"Type"};
			if (specificationEntity.FetchFromDB("Id", specificationId, columns)) {
				specificationType = specificationEntity.GetTypedColumnValue<Guid>("TypeId");
			}
			return specificationType;
		}

		#endregion

	}

	#endregion

}

