namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailNotifierSchema

	/// <exclude/>
	public class BulkEmailNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailNotifierSchema(BulkEmailNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48");
			Name = "BulkEmailNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,203,110,219,48,16,60,59,64,255,129,80,47,18,96,200,247,198,246,33,207,26,104,2,55,114,209,51,45,173,108,54,18,169,242,145,198,13,242,239,93,146,162,34,89,73,144,30,108,136,203,221,229,204,236,144,156,214,160,26,154,3,217,128,148,84,137,82,167,231,130,151,108,103,36,213,76,240,79,39,79,159,78,38,70,49,190,35,217,65,105,168,79,187,117,191,68,194,91,241,244,226,12,183,112,243,179,132,29,118,36,231,21,85,234,11,57,51,213,253,101,77,89,117,43,52,43,25,72,151,52,155,205,200,92,153,186,166,242,176,108,215,54,147,128,77,37,136,86,209,29,144,70,138,28,63,237,105,188,45,79,67,245,172,87,222,152,109,197,114,146,219,35,199,39,18,68,65,21,124,55,96,224,198,119,126,1,51,65,226,248,255,2,91,112,165,165,201,181,144,136,126,237,26,251,140,99,204,46,208,75,39,37,254,230,10,128,228,18,202,69,52,194,17,205,150,30,162,229,48,38,225,35,13,149,180,38,28,7,182,136,140,2,137,7,112,200,237,140,162,229,124,230,118,93,114,75,121,116,72,252,99,80,68,134,61,18,212,98,139,90,196,199,97,59,254,201,115,43,5,240,194,171,49,148,102,45,69,3,82,51,176,194,72,161,177,22,138,119,180,185,69,18,68,148,68,239,81,18,35,37,112,61,24,227,43,18,52,161,45,17,15,104,47,86,0,65,121,237,252,3,63,215,244,137,236,64,147,197,146,92,131,222,28,26,136,147,212,198,79,201,243,7,225,72,168,25,47,108,95,4,197,244,129,168,124,143,214,251,111,84,119,161,79,230,234,135,224,236,16,69,25,119,35,74,58,124,111,41,124,3,122,47,10,39,47,123,160,26,252,110,227,23,225,76,228,252,50,117,60,34,190,54,172,32,219,16,90,21,237,52,39,15,84,18,5,21,34,39,11,194,225,15,201,220,226,200,33,137,203,157,224,37,174,76,205,227,200,182,140,66,240,74,138,58,30,241,8,187,63,247,32,33,142,86,69,148,164,43,117,249,219,208,42,246,109,210,181,53,42,104,244,99,31,88,66,168,106,81,216,119,100,50,241,240,210,172,129,156,149,135,91,241,77,228,247,95,25,215,42,78,124,130,4,109,36,111,105,164,151,143,144,27,13,89,78,43,42,231,94,143,101,155,250,113,105,7,206,125,101,182,78,79,84,57,51,219,95,184,181,42,98,251,124,108,168,186,239,63,33,225,145,10,106,183,72,227,240,118,33,211,78,177,126,93,146,118,225,85,209,71,254,182,203,16,139,183,127,238,30,235,11,80,185,100,141,253,124,23,217,52,212,219,107,235,42,239,64,153,74,15,252,17,56,162,69,6,148,3,187,211,46,181,27,164,115,249,98,236,195,174,87,175,200,223,119,143,123,77,53,26,130,99,233,208,129,41,118,194,193,211,138,253,165,219,10,50,7,122,228,186,240,0,36,83,239,190,200,82,239,203,178,129,71,29,29,217,198,181,74,175,132,172,169,142,95,193,50,29,178,154,142,164,122,199,90,62,58,12,98,236,31,119,123,98,23,108,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBaseNotificationTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBaseNotificationTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1e854a2a-8c1e-4794-9486-6d3d7913b64e"),
				Name = "BaseNotificationText",
				CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf"),
				CreatedInSchemaUId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48"),
				ModifiedInSchemaUId = new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e57633a3-e0d1-4ae8-8223-b6634131fc48"));
		}

		#endregion

	}

	#endregion

}

