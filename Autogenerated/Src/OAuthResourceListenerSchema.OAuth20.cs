namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthResourceListenerSchema

	/// <exclude/>
	public class OAuthResourceListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthResourceListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthResourceListenerSchema(OAuthResourceListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2");
			Name = "OAuthResourceListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,86,221,143,218,70,16,127,38,82,254,135,145,251,98,164,147,169,250,120,7,72,132,163,41,82,174,23,5,46,121,168,250,176,103,15,176,173,189,107,237,174,201,209,136,255,189,179,31,54,54,129,222,209,42,82,164,190,96,188,158,207,223,252,102,118,4,43,80,151,44,69,88,162,82,76,203,149,73,166,82,172,248,186,82,204,112,41,146,251,73,101,54,63,253,248,250,213,151,215,175,122,149,230,98,13,139,157,54,88,220,28,189,147,94,158,99,106,149,116,242,22,5,42,158,30,100,218,230,139,66,138,211,95,20,38,51,97,184,225,168,159,21,72,102,91,20,230,164,156,139,121,46,12,174,67,18,183,203,251,23,201,205,158,82,44,237,63,146,38,249,31,20,174,233,5,166,57,211,250,26,156,248,7,212,178,82,41,190,227,148,52,37,233,4,127,115,65,237,92,68,245,135,120,145,110,176,96,191,18,194,48,130,168,163,28,245,127,39,173,178,122,204,121,10,169,181,126,218,56,92,195,27,166,209,125,155,148,124,202,8,97,242,216,163,90,208,239,33,62,130,220,168,42,53,82,81,152,239,157,89,47,17,92,156,52,30,247,201,252,35,153,143,5,126,134,91,238,74,199,212,110,184,220,149,120,5,100,145,208,26,147,148,173,124,175,247,5,12,157,203,85,76,129,44,80,109,81,53,104,245,175,32,122,39,83,150,243,191,216,99,142,11,167,169,147,218,225,7,138,146,92,218,195,153,82,82,221,161,214,108,141,201,71,150,87,24,193,254,234,140,125,74,75,88,66,109,45,180,207,248,170,101,165,56,233,194,122,216,83,38,251,0,28,138,204,99,215,5,242,14,205,70,102,22,67,197,183,204,96,0,209,191,0,5,86,167,52,23,43,9,111,209,180,142,126,86,178,240,52,136,253,3,208,61,106,252,182,76,129,10,178,129,20,94,128,154,197,88,200,51,106,160,170,16,46,228,97,141,126,100,69,163,254,205,87,38,110,185,46,115,182,187,192,82,75,163,109,144,29,82,32,67,150,10,199,121,250,248,123,193,85,59,7,95,185,94,55,150,19,17,6,185,247,74,150,168,108,243,6,79,45,210,249,48,27,218,213,78,137,22,145,77,41,162,178,79,202,146,200,236,58,117,146,166,84,225,80,88,42,173,123,236,125,82,10,77,165,68,59,47,119,254,242,210,75,67,76,194,172,46,126,120,5,73,148,84,60,67,216,74,158,193,114,163,228,231,134,149,177,15,27,208,145,79,175,251,48,26,131,177,34,46,207,78,255,29,148,26,233,155,151,198,214,106,237,193,96,0,67,93,21,5,161,55,174,15,126,97,34,203,9,94,207,7,88,176,45,5,142,118,44,37,141,206,224,88,105,88,50,197,10,16,84,168,81,164,41,6,84,209,216,205,50,240,111,201,112,224,68,78,107,96,52,94,110,144,98,65,132,84,225,106,20,45,175,207,206,108,23,215,100,69,211,192,57,152,168,53,85,113,48,6,78,19,140,9,162,96,42,133,97,92,88,48,205,6,107,135,46,5,200,152,97,157,88,194,120,235,86,230,94,204,133,182,52,19,235,88,62,254,65,197,11,105,92,129,119,255,6,87,20,84,227,31,176,110,209,233,6,211,63,167,76,220,49,65,195,99,65,77,228,107,235,180,67,203,216,129,153,180,93,212,182,177,213,83,1,254,17,132,81,208,247,66,94,224,184,189,186,13,120,118,168,132,105,226,109,204,158,48,173,12,134,59,33,142,29,223,230,153,151,177,211,147,167,248,73,177,146,218,45,153,100,89,109,46,110,249,162,65,26,166,198,3,165,114,152,159,77,38,251,139,120,230,216,255,189,17,237,168,210,255,129,105,46,24,172,59,55,184,247,139,207,61,129,236,134,18,33,75,83,192,206,138,166,197,163,241,180,82,202,90,172,8,100,202,82,107,171,206,181,181,64,119,74,70,231,14,185,39,234,8,193,114,96,110,176,181,48,108,124,254,19,225,61,254,223,142,237,193,254,17,213,47,32,200,45,230,104,254,143,20,153,139,45,173,42,89,195,145,22,51,26,76,152,240,23,68,115,115,90,126,8,105,128,148,10,110,136,37,151,242,161,54,125,33,35,158,29,93,237,5,100,65,219,38,241,230,176,124,116,199,72,179,253,5,57,111,32,92,147,133,95,207,194,22,240,213,58,23,31,249,160,187,255,228,6,107,151,130,250,172,78,185,189,254,213,107,206,225,34,62,91,142,56,132,212,97,246,25,116,31,74,170,253,55,237,183,198,195,119,127,185,60,216,72,105,195,255,247,247,203,209,210,227,79,187,135,251,191,1,11,105,31,119,167,14,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateConnectionErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceRegisteringErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceModifyingErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceDeletingErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateConnectionErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e03aaebb-193b-8726-710a-929627d6b105"),
				Name = "ConnectionErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceRegisteringErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("21597b70-844d-8f8f-62df-ff422643519c"),
				Name = "ResourceRegisteringErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceModifyingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("592cb685-553c-4598-8deb-f17e38c2101e"),
				Name = "ResourceModifyingErrorMessage",
				CreatedInPackageId = new Guid("1cbe3766-af85-4075-b77c-3de2d413d0be"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceDeletingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("12e7cc28-c036-6369-e37b-184500b360e6"),
				Name = "ResourceDeletingErrorMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"));
		}

		#endregion

	}

	#endregion

}

