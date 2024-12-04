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

	#region Class: ContactCareer_BaseBankCustomerJourneyEventsProcess

	public partial class ContactCareer_BaseBankCustomerJourneyEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void OnContactCareerSaved(ProcessExecutingContext context) {
			var conditionMappingColumns = new System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>();
			var mappingColumns = new System.Collections.Generic.Dictionary<
			Guid, Guid>();
			var defaultValues = new System.Collections.Generic.Dictionary<
			Guid, object>();
			
			//--------------- Entity Schema Columns UId -------------------------------
			var contactCareerJobColumnUId = new Guid("bf823e82-f89d-4345-b839-c429dcb2baac");
			var contactCareerJobTitleColumnUId = new Guid("5439cefd-5021-4446-957b-f35eebe76b40");
			var contactCareerDepartmentColumnUId = new Guid("96d86ec7-b8fd-4288-8cc4-c5d6ca4fe46d");
			var contactCareerAccountColumnUId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854");
			var contactCareerPrimaryColumnUId = new Guid("131fa275-a32c-4af9-92f0-cfedcad3679c");
			var contactCareerCurrentColumnUId = new Guid("e370b11e-e44a-4ccb-90ed-9f0f2a455adb");
			var contactCareerDecisionRoleColumnUId = new Guid("6324d7f3-fd46-4046-b9c3-76844a3e88a6");
			var contactCareerEmploymentTypeColumnUId = new Guid("4247fd0d-cf93-4498-9d76-544e8ee6249d");
			
			var contactJobColumnUId = new Guid("344436e4-9d6b-4a30-936f-f8ea45f2adb4");
			var contactJobTitleColumnUId = new Guid("8b680ac7-e46c-466c-b630-e5cb4da13a55");
			var contactDepartmentColumnUId = new Guid("94cb8750-ad6f-4e80-b553-7d9e194a856e");
			var contactAccountColumnUId = new Guid("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4");
			var contactDecisionRoleColumnUId = new Guid("f70c762a-1038-49a7-a3e8-f24fb8cfdeef");
			var contactEmploymentTypeColumnUId = new Guid("ecfca042-441a-4262-80ff-c0ff233203ac");
			
			//--------------- Condition Mapping Columns ----------------
			var primaryJobCondition = new System.Collections.Generic.Dictionary<
			Guid, object>();
			primaryJobCondition.Add(contactCareerPrimaryColumnUId, true);
			primaryJobCondition.Add(contactCareerCurrentColumnUId, true);
			conditionMappingColumns.Add(contactJobColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactJobTitleColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactDepartmentColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactAccountColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactDecisionRoleColumnUId, primaryJobCondition);
			conditionMappingColumns.Add(contactEmploymentTypeColumnUId, primaryJobCondition);
			
			//--------------- Mapping Columns ----------------
			mappingColumns.Add(contactJobColumnUId, contactCareerJobColumnUId);
			mappingColumns.Add(contactJobTitleColumnUId, contactCareerJobTitleColumnUId);
			mappingColumns.Add(contactDepartmentColumnUId, contactCareerDepartmentColumnUId);
			mappingColumns.Add(contactAccountColumnUId, contactCareerAccountColumnUId);
			mappingColumns.Add(contactDecisionRoleColumnUId, contactCareerDecisionRoleColumnUId);
			mappingColumns.Add(contactEmploymentTypeColumnUId, contactCareerEmploymentTypeColumnUId);
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			SynchronizeContactData.ParentEntityColumnUId = entitySchema.Columns.GetByName("Contact").UId;
			SynchronizeContactData.ConditionMappingColumns = conditionMappingColumns;
			SynchronizeContactData.MappingColumns = mappingColumns;
			SynchronizeContactData.DefaultValues = defaultValues;
			SynchronizeContactData.DeleteChild = false;
			
			return;
		}

		public override void OnContactCareerDeleted(ProcessExecutingContext context) {
			var conditionMappingColumns = new System.Collections.Generic.Dictionary<
			Guid, System.Collections.Generic.Dictionary<
			Guid, object>>();
			var mappingColumns = new System.Collections.Generic.Dictionary<
			Guid, Guid>();
			var defaultValues = new System.Collections.Generic.Dictionary<
			Guid, object>();
			
			//--------------- Entity Schema Columns UId -------------------------------
			var contactCareerJobColumnUId = new Guid("bf823e82-f89d-4345-b839-c429dcb2baac");
			var contactCareerJobTitleColumnUId = new Guid("5439cefd-5021-4446-957b-f35eebe76b40");
			var contactCareerDepartmentColumnUId = new Guid("96d86ec7-b8fd-4288-8cc4-c5d6ca4fe46d");
			var contactCareerAccountColumnUId = new Guid("8996b0d8-c0d9-4da7-b130-7917fa48b854");
			var contactCareerPrimaryColumnUId = new Guid("131fa275-a32c-4af9-92f0-cfedcad3679c");
			var contactCareerCurrentColumnUId = new Guid("e370b11e-e44a-4ccb-90ed-9f0f2a455adb");
			var contactCareerEmploymentTypeColumnUId = new Guid("4247fd0d-cf93-4498-9d76-544e8ee6249d");
			
			var contactJobColumnUId = new Guid("344436e4-9d6b-4a30-936f-f8ea45f2adb4");
			var contactJobTitleColumnUId = new Guid("8b680ac7-e46c-466c-b630-e5cb4da13a55");
			var contactDepartmentColumnUId = new Guid("94cb8750-ad6f-4e80-b553-7d9e194a856e");
			var contactAccountColumnUId = new Guid("5c6ca10e-1180-4c1e-8a50-55a72ff9bdd4");
			var decisionRoleColumnUId = new Guid("f70c762a-1038-49a7-a3e8-f24fb8cfdeef");
			var contactEmploymentTypeColumnUId = new Guid("ecfca042-441a-4262-80ff-c0ff233203ac");
			
			//--------------- Condition Mapping Columns ----------------
			var primaryAddressCondition = new System.Collections.Generic.Dictionary<
			Guid, object>();
			primaryAddressCondition.Add(contactCareerPrimaryColumnUId, true);
			primaryAddressCondition.Add(contactCareerCurrentColumnUId, true);
			conditionMappingColumns.Add(contactJobColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactJobTitleColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactDepartmentColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactAccountColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(decisionRoleColumnUId, primaryAddressCondition);
			conditionMappingColumns.Add(contactEmploymentTypeColumnUId, primaryAddressCondition);
			
			//--------------- Mapping Columns ----------------
			mappingColumns.Add(contactJobColumnUId, contactCareerJobColumnUId);
			mappingColumns.Add(contactJobTitleColumnUId, contactCareerJobTitleColumnUId);
			mappingColumns.Add(contactDepartmentColumnUId, contactCareerDepartmentColumnUId);
			mappingColumns.Add(contactAccountColumnUId, contactCareerAccountColumnUId);
			mappingColumns.Add(decisionRoleColumnUId, Guid.Empty);
			mappingColumns.Add(contactEmploymentTypeColumnUId, contactCareerEmploymentTypeColumnUId);
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			SynchronizeContactData.ParentEntityColumnUId = new Guid("d6628cf3-ba29-472e-b0f2-9b51f693ef2a");
			SynchronizeContactData.ConditionMappingColumns = conditionMappingColumns;
			SynchronizeContactData.MappingColumns = mappingColumns;
			SynchronizeContactData.DefaultValues = defaultValues;
			SynchronizeContactData.DeleteChild = true;
			
			return;
		}

		#endregion

	}

	#endregion

}

