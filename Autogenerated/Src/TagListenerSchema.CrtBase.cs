namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TagListenerSchema

	/// <exclude/>
	public class TagListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TagListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TagListenerSchema(TagListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f257232b-0e51-4712-b42a-73d1a3575eef");
			Name = "TagListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,77,111,219,48,12,61,187,64,255,3,231,29,234,0,133,114,111,147,0,109,208,143,0,93,59,44,233,46,195,14,138,204,56,26,108,201,144,228,116,217,208,255,62,74,178,91,39,77,215,139,0,81,228,227,35,249,40,197,43,180,53,23,8,11,52,134,91,189,114,108,170,213,74,22,141,225,78,106,117,124,244,247,248,40,105,172,84,5,204,183,214,97,117,190,119,103,115,20,141,145,110,251,250,208,199,170,42,173,14,191,24,100,87,202,73,39,209,126,232,192,174,54,168,220,251,126,215,92,56,109,34,18,249,124,54,88,16,121,152,150,220,218,51,88,240,226,78,18,87,133,38,60,15,135,67,24,217,166,170,184,217,78,218,123,231,0,43,109,224,132,34,78,128,50,82,89,128,33,53,235,226,134,189,192,31,129,223,54,144,235,0,178,185,88,99,197,239,169,179,48,134,148,144,210,193,79,242,173,155,101,41,5,8,79,169,207,8,206,224,146,91,60,128,68,65,190,249,47,213,124,65,183,214,57,213,243,213,200,13,119,24,106,73,234,120,129,165,214,37,204,236,180,49,134,48,30,45,154,91,110,31,106,140,115,188,49,92,57,196,44,166,105,75,27,64,192,79,228,10,178,79,209,196,40,240,34,175,164,250,38,139,181,179,157,71,98,208,53,70,129,51,13,250,33,36,201,115,56,111,26,153,131,227,197,133,16,104,237,44,167,138,91,156,27,116,139,109,141,249,84,151,77,165,190,243,178,193,145,247,158,100,190,37,157,127,58,136,104,51,178,197,140,183,88,18,103,143,185,115,31,199,89,198,57,7,244,209,126,204,36,139,84,19,133,79,64,34,182,68,214,123,95,152,162,169,136,85,150,54,212,20,122,80,40,124,75,210,211,142,235,227,142,125,208,114,234,74,222,205,194,166,92,77,13,82,199,179,94,221,239,64,177,222,52,216,44,143,192,212,185,48,85,84,121,28,108,123,127,51,229,32,152,248,184,175,216,96,184,229,42,47,209,2,5,73,69,25,156,95,140,190,104,189,102,223,138,54,90,106,110,120,5,138,84,58,78,45,81,65,147,78,130,250,32,222,216,104,24,92,14,71,96,58,89,172,145,40,33,130,48,184,26,167,81,88,151,72,235,131,1,135,218,110,211,225,196,83,115,92,209,15,35,180,114,92,42,79,210,81,108,96,8,57,119,124,39,85,187,38,122,67,11,46,115,132,141,38,133,61,168,89,87,96,166,151,191,168,185,45,203,83,56,152,23,176,19,238,134,155,174,37,99,104,213,63,136,177,231,175,218,255,112,109,80,133,192,151,117,112,107,163,159,192,11,173,251,253,174,126,11,172,125,72,70,186,35,158,236,90,155,138,187,204,251,220,105,193,75,249,135,47,75,156,135,71,218,129,157,255,139,164,216,54,144,189,224,176,123,29,116,71,56,44,86,159,14,200,45,252,39,173,66,227,14,46,233,247,96,253,14,117,173,193,255,233,45,90,119,141,207,255,0,28,36,160,150,15,6,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTagRightsExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTagRightsExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("122baa28-9059-4d1e-ed30-fc219fb1da77"),
				Name = "TagRightsException",
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				CreatedInSchemaUId = new Guid("f257232b-0e51-4712-b42a-73d1a3575eef"),
				ModifiedInSchemaUId = new Guid("f257232b-0e51-4712-b42a-73d1a3575eef")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f257232b-0e51-4712-b42a-73d1a3575eef"));
		}

		#endregion

	}

	#endregion

}

