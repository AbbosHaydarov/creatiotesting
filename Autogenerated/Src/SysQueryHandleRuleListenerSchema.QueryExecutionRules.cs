namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysQueryHandleRuleListenerSchema

	/// <exclude/>
	public class SysQueryHandleRuleListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysQueryHandleRuleListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysQueryHandleRuleListenerSchema(SysQueryHandleRuleListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff");
			Name = "SysQueryHandleRuleListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,89,95,111,219,54,16,127,118,129,126,7,214,5,2,27,48,148,236,181,117,12,56,118,210,25,72,218,174,73,215,135,97,24,104,137,182,185,202,164,71,82,73,188,214,223,125,71,82,148,41,137,114,156,52,237,210,135,4,17,201,251,127,252,221,29,131,24,94,18,185,194,49,65,87,68,8,44,249,76,69,35,206,102,116,158,9,172,40,103,209,111,25,17,235,211,91,18,103,250,243,67,150,18,249,252,217,151,231,207,90,153,164,108,142,46,215,82,145,229,235,202,55,240,72,83,18,107,10,25,189,33,140,8,26,215,206,156,83,246,79,109,241,18,4,9,170,214,219,13,95,177,229,146,179,240,142,32,77,235,209,248,164,113,235,148,41,170,40,145,119,30,136,78,175,9,83,205,231,206,112,172,184,216,197,41,224,71,56,11,167,95,10,50,135,21,52,74,177,148,175,208,24,43,60,145,60,53,222,119,226,207,41,56,7,188,104,8,14,15,15,81,95,102,203,37,22,235,65,254,13,49,83,130,167,18,169,5,65,179,148,223,32,62,67,177,32,192,5,84,193,44,65,75,158,208,217,58,247,180,81,230,87,88,78,137,214,36,114,92,15,43,108,251,146,16,156,74,174,89,205,142,219,187,157,19,157,96,73,204,218,218,44,56,165,219,232,80,243,251,35,176,213,185,140,23,100,137,223,66,22,162,99,212,174,107,214,238,254,9,164,171,108,154,210,24,197,218,67,1,245,29,55,244,10,53,168,0,60,32,101,225,119,225,237,11,162,22,60,1,127,191,23,244,26,43,162,247,244,207,202,126,34,202,20,250,107,73,217,7,126,51,226,25,112,226,55,68,252,142,211,76,43,250,203,209,209,209,107,228,72,94,18,150,88,174,197,74,163,16,95,196,53,167,9,68,157,96,97,236,209,150,12,87,171,148,18,49,194,224,150,206,71,9,127,113,198,236,61,66,89,233,179,139,244,29,108,181,174,177,64,98,75,9,202,153,60,178,249,184,134,187,167,250,147,42,251,65,167,171,211,180,213,242,8,35,163,72,190,177,41,43,58,229,60,69,192,105,34,135,32,251,218,248,124,156,1,89,12,187,73,167,30,16,36,107,75,78,95,195,139,230,140,64,219,250,73,173,243,213,122,69,18,192,144,108,201,140,207,251,154,108,208,105,59,13,218,185,1,116,134,58,47,28,55,39,162,37,136,202,4,67,51,200,92,131,10,198,32,248,109,19,195,166,92,64,112,190,17,212,201,238,189,246,216,4,78,157,9,190,28,79,131,12,44,125,52,210,55,50,79,208,78,64,76,57,228,185,145,77,130,244,233,97,162,115,148,206,23,74,130,92,107,49,144,20,169,17,115,150,80,3,195,176,205,200,13,26,83,195,26,238,120,95,42,1,112,208,67,124,250,55,200,27,56,239,125,65,91,55,247,144,18,144,241,155,94,177,117,177,189,18,176,187,103,244,224,50,65,240,124,210,174,207,211,37,208,152,40,80,132,139,253,25,191,201,104,2,156,171,12,38,73,89,192,68,218,234,178,63,227,34,223,114,194,174,205,160,141,141,136,22,171,57,217,168,78,146,253,243,120,171,176,163,245,83,217,103,249,226,24,233,195,209,233,114,165,214,69,106,111,227,25,13,147,196,99,100,77,115,212,57,207,13,34,144,16,251,208,178,44,77,29,145,175,78,56,241,206,136,138,23,230,239,147,206,150,107,207,230,95,23,29,28,88,129,205,153,11,120,168,203,140,231,25,109,111,192,135,245,131,213,91,174,19,212,87,188,118,249,55,33,212,93,144,248,179,185,59,239,86,196,54,58,246,18,237,15,186,201,212,181,42,167,108,78,153,198,178,242,97,232,59,202,39,60,200,170,18,235,92,25,97,102,219,3,82,232,212,105,195,226,5,102,120,78,46,193,3,122,169,221,45,28,80,99,98,172,218,205,166,40,5,210,229,221,70,179,218,233,167,9,3,187,84,192,91,79,208,89,86,87,168,253,98,173,22,128,110,158,187,154,99,94,209,219,203,166,70,159,124,92,37,176,240,115,248,196,234,250,253,125,50,38,41,249,89,124,98,117,125,76,159,148,219,71,239,246,132,155,166,157,46,233,161,123,245,84,218,250,230,246,44,64,87,216,170,125,14,61,61,23,23,68,74,128,135,188,73,56,231,49,78,233,191,120,10,141,139,105,18,42,166,71,31,136,228,153,136,97,151,11,32,235,133,90,247,162,253,207,235,112,171,93,99,43,243,134,200,234,189,213,217,0,212,68,190,23,124,65,167,20,22,34,3,253,237,110,116,197,115,133,114,239,183,212,66,192,176,163,149,46,130,127,27,147,149,9,180,111,217,158,209,242,122,148,187,66,164,39,4,111,64,240,131,225,45,163,126,195,24,177,43,6,182,51,139,206,184,88,98,213,249,63,34,162,143,127,162,106,225,249,227,28,212,187,90,64,33,161,182,16,215,163,211,107,50,245,219,98,85,157,177,194,19,150,25,17,237,102,117,64,54,11,214,13,161,241,17,93,226,107,146,32,162,7,70,61,9,215,71,97,187,178,194,2,47,145,126,49,57,110,75,208,7,28,57,48,83,38,178,95,81,255,208,28,9,83,144,246,224,10,102,115,61,81,187,105,250,85,227,60,109,6,132,225,76,17,97,4,12,197,92,234,41,26,114,78,42,204,224,181,6,186,46,133,41,211,227,60,76,252,78,160,49,1,1,218,227,146,46,249,248,204,1,237,4,77,242,116,127,151,215,74,157,75,118,2,200,205,232,33,43,254,132,204,64,169,66,62,210,25,235,143,22,117,92,129,204,13,12,131,93,203,214,198,116,231,157,10,183,209,101,18,203,230,142,190,36,8,212,249,228,105,27,122,205,185,176,255,1,99,168,27,11,182,229,39,200,249,169,1,173,167,162,135,174,185,78,143,11,178,173,26,158,86,1,244,225,195,99,46,103,87,125,189,91,152,75,11,120,49,138,252,203,224,110,129,59,176,227,133,38,148,103,155,135,97,144,105,210,116,46,62,57,24,170,224,64,19,14,57,105,250,1,242,126,56,228,76,223,31,134,158,14,6,53,207,1,65,12,50,79,50,80,67,231,46,197,245,179,76,248,30,140,252,99,230,38,200,78,8,201,204,86,126,24,152,149,185,71,67,182,238,220,162,227,1,186,141,236,35,43,188,178,86,209,171,6,140,69,46,126,43,46,106,115,177,240,58,133,92,173,70,117,63,45,136,32,37,133,225,89,0,224,108,126,169,112,252,249,74,192,63,42,0,159,44,156,116,209,0,29,213,241,183,228,143,175,95,203,192,92,88,118,112,176,75,177,39,212,32,159,194,227,74,24,181,31,25,174,243,44,240,112,246,94,73,85,194,103,63,42,117,134,229,73,235,187,86,136,205,163,215,137,2,172,238,81,38,246,124,232,125,96,229,48,163,236,143,169,28,110,253,27,43,200,189,26,217,173,61,119,22,18,231,137,159,177,144,52,63,158,4,11,73,248,121,118,63,108,126,58,224,54,54,70,255,200,166,52,191,197,70,240,119,189,197,149,129,213,174,150,23,97,237,63,157,246,175,210,128,31,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCreateActiveDuplicatedRulesIsProhibitedLocalizableString());
			LocalizableStrings.Add(CreateDeleteSystemRuleIsProhibitedMessageLocalizableString());
			LocalizableStrings.Add(CreateEditSystemRuleIsProhibitedLocalizableString());
			LocalizableStrings.Add(CreateCreateSystemRuleIsProhibitedMessageLocalizableString());
			LocalizableStrings.Add(CreateCreateRuleWithMinRowCountLessThanMinValueProhibitedLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCreateActiveDuplicatedRulesIsProhibitedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b4ab4cb4-79e2-a790-cdf9-1e29d6a4693b"),
				Name = "CreateActiveDuplicatedRulesIsProhibited",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDeleteSystemRuleIsProhibitedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fbeac549-ba21-9164-332e-1c2b6e5a086d"),
				Name = "DeleteSystemRuleIsProhibitedMessage",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEditSystemRuleIsProhibitedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("654dcd12-b490-703e-31f7-66b56cd63ec4"),
				Name = "EditSystemRuleIsProhibited",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateSystemRuleIsProhibitedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3ced39a4-9f25-4e0d-ec88-30df6d43c472"),
				Name = "CreateSystemRuleIsProhibitedMessage",
				CreatedInPackageId = new Guid("24377658-5c78-47a6-b5ee-e5beab1bcee6"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCreateRuleWithMinRowCountLessThanMinValueProhibitedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b7776b09-484f-5813-d9b7-a509e23eff9f"),
				Name = "CreateRuleWithMinRowCountLessThanMinValueProhibited",
				CreatedInPackageId = new Guid("4e6ccfb8-9251-4fde-a337-f61d1d253a58"),
				CreatedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"),
				ModifiedInSchemaUId = new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fabf0d1-6f2f-4d52-b60e-7db0f3d645ff"));
		}

		#endregion

	}

	#endregion

}

