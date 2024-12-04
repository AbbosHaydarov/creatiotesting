namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysLicPackageInRoleEventListenerSchema

	/// <exclude/>
	public class SysLicPackageInRoleEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysLicPackageInRoleEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysLicPackageInRoleEventListenerSchema(SysLicPackageInRoleEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13");
			Name = "SysLicPackageInRoleEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("acb004d0-c421-4dff-b075-f4fdc1c90074");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,86,75,111,219,56,16,62,43,64,254,3,235,94,20,32,144,247,220,141,3,36,174,211,6,72,91,111,221,199,97,177,88,48,210,216,102,75,145,234,144,114,235,221,230,191,239,144,148,108,73,150,211,44,154,20,185,216,32,57,143,111,102,190,25,141,226,57,152,130,167,192,222,1,34,55,122,110,147,177,86,115,177,40,145,91,161,213,225,193,191,135,7,81,105,132,90,176,217,218,88,200,127,223,156,155,42,121,174,85,255,11,194,190,251,100,162,172,176,2,204,15,5,146,201,10,148,117,114,36,249,20,97,65,200,216,88,114,99,158,57,84,87,34,157,242,244,51,95,192,165,122,171,37,120,233,43,65,104,21,160,215,25,14,135,236,196,148,121,206,113,125,90,157,95,114,149,73,64,54,215,216,103,132,145,13,97,215,12,188,235,164,54,50,236,88,57,49,0,92,26,205,82,132,249,104,112,123,0,201,57,55,224,239,214,45,140,3,54,116,246,254,236,121,138,103,233,18,114,254,154,10,197,70,108,208,3,116,112,244,23,233,22,229,181,20,41,75,93,82,126,152,19,246,140,237,65,66,150,168,224,244,187,73,243,133,0,153,81,158,167,40,86,220,66,120,44,194,129,189,55,128,196,23,5,169,35,11,251,187,108,157,67,189,162,167,160,178,96,172,109,249,21,216,165,222,107,122,165,69,198,198,75,72,63,83,40,160,12,188,91,23,16,191,40,233,214,180,194,203,142,152,227,104,20,249,140,183,216,155,132,68,56,77,70,217,241,255,35,246,2,40,92,127,152,162,182,4,21,178,184,107,210,81,50,138,196,156,197,181,222,147,17,187,213,65,50,5,52,90,113,89,195,137,140,69,199,105,234,48,67,70,201,177,130,175,236,74,167,92,138,127,248,181,132,153,127,143,59,73,75,222,130,209,37,166,244,172,145,244,142,131,177,168,175,244,109,18,29,179,193,142,117,147,188,81,114,93,67,171,50,105,38,136,26,147,15,92,150,196,158,16,106,100,151,168,191,122,136,147,111,41,20,14,74,92,65,175,68,110,220,239,205,190,42,17,188,179,44,23,234,189,18,182,85,170,205,237,182,82,43,142,12,204,151,42,37,129,134,129,231,127,148,128,235,157,148,52,37,94,113,69,144,144,130,109,122,172,195,32,171,201,89,150,141,181,44,115,21,15,46,179,61,15,93,180,173,92,56,217,11,33,45,101,205,233,196,238,60,70,160,120,195,237,71,97,151,83,142,212,146,78,36,14,151,52,3,11,142,130,242,236,217,48,249,82,114,73,32,9,193,113,55,11,247,232,230,181,182,181,167,254,144,42,250,120,234,62,63,79,186,66,137,235,224,71,5,104,6,114,62,3,92,17,85,167,26,45,151,77,132,129,8,84,68,89,77,28,168,6,44,81,201,161,165,214,238,138,116,201,212,104,237,90,153,122,186,84,150,141,70,236,183,71,216,188,94,246,1,26,246,66,227,243,178,160,241,70,215,166,175,91,143,89,223,180,173,110,197,253,55,243,238,135,237,14,61,125,95,125,74,254,189,207,135,108,214,134,175,109,172,193,99,235,227,243,48,237,232,39,17,149,237,87,180,210,233,163,235,164,45,213,127,190,151,238,176,208,84,123,69,221,123,213,145,173,4,90,170,198,237,155,68,239,130,114,219,226,131,96,75,220,217,190,18,18,125,9,178,0,116,181,36,243,149,94,101,122,119,229,97,255,43,68,191,111,134,71,191,7,11,181,4,20,54,211,105,88,102,235,141,84,175,104,37,22,89,53,121,222,168,25,95,185,114,235,235,79,4,147,25,242,227,250,63,80,237,28,104,25,15,229,60,195,133,97,80,71,120,77,219,106,178,209,173,149,234,218,4,229,122,97,31,177,56,92,28,5,185,32,211,73,142,35,185,23,242,31,192,214,202,90,141,180,246,24,216,202,83,46,93,250,170,113,228,105,116,226,138,115,234,151,10,71,199,237,128,170,236,52,211,124,87,67,77,157,65,163,209,218,176,146,75,51,201,11,187,142,143,216,247,239,93,87,219,199,77,47,6,166,52,24,29,141,123,119,183,206,12,12,10,59,203,120,255,210,236,130,78,75,68,10,243,142,225,110,35,236,249,48,117,191,73,59,159,163,141,175,96,163,159,192,225,182,125,121,115,120,240,31,97,176,216,148,0,15,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDuplicatesErrorLocalizableString());
			LocalizableStrings.Add(CreateOnlyRoleErrorLocalizableString());
			LocalizableStrings.Add(CreateOnlyPersonalLicensesErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDuplicatesErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b47699c9-0637-b858-a6e2-fc299dc18530"),
				Name = "DuplicatesError",
				CreatedInPackageId = new Guid("acb004d0-c421-4dff-b075-f4fdc1c90074"),
				CreatedInSchemaUId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13"),
				ModifiedInSchemaUId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnlyRoleErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("daf4d4b7-213c-3ef2-9a86-2ed15e9a56a1"),
				Name = "OnlyRoleError",
				CreatedInPackageId = new Guid("acb004d0-c421-4dff-b075-f4fdc1c90074"),
				CreatedInSchemaUId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13"),
				ModifiedInSchemaUId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnlyPersonalLicensesErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bfb43b91-5655-d0fd-efe1-7671146130ef"),
				Name = "OnlyPersonalLicensesError",
				CreatedInPackageId = new Guid("acb004d0-c421-4dff-b075-f4fdc1c90074"),
				CreatedInSchemaUId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13"),
				ModifiedInSchemaUId = new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f56389cb-3571-4cd8-a2dc-f7c4e393fd13"));
		}

		#endregion

	}

	#endregion

}

