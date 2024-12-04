namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportFindExistsRowColumnProviderFactorySchema

	/// <exclude/>
	public class IFileImportFindExistsRowColumnProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportFindExistsRowColumnProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportFindExistsRowColumnProviderFactorySchema(IFileImportFindExistsRowColumnProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2083a9a6-213a-488c-9bd5-42f89aaaf1c3");
			Name = "IFileImportFindExistsRowColumnProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,82,193,78,195,48,12,61,175,210,254,193,26,23,184,52,247,49,42,161,137,162,30,144,166,137,31,8,173,83,34,181,78,229,164,131,9,237,223,73,147,118,48,184,140,113,140,159,253,158,223,115,72,182,104,59,89,34,60,35,179,180,70,185,116,109,72,233,186,103,233,180,161,52,215,13,22,109,103,216,205,147,143,121,50,79,102,87,140,181,71,160,32,135,172,252,236,18,138,175,174,92,83,245,240,174,173,179,91,243,182,54,77,223,210,134,205,78,87,200,185,44,157,225,125,32,17,66,192,202,246,109,43,121,159,141,239,45,118,140,22,201,89,144,160,98,51,40,195,80,50,250,101,168,6,77,214,73,42,209,130,81,126,28,113,128,212,221,226,60,253,133,200,210,73,90,124,211,238,250,151,70,151,158,124,244,243,87,59,179,152,203,49,152,39,116,175,166,178,75,216,4,226,8,254,52,60,58,118,172,113,231,253,72,58,154,187,212,91,136,170,149,36,235,33,170,50,192,64,195,129,39,185,170,231,1,82,158,16,116,96,4,211,97,60,180,29,162,249,157,77,172,48,186,158,201,102,247,255,223,50,93,137,137,109,160,63,111,14,30,209,157,86,174,111,110,199,208,145,170,152,123,120,31,226,23,61,41,30,62,1,59,110,73,44,230,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2083a9a6-213a-488c-9bd5-42f89aaaf1c3"));
		}

		#endregion

	}

	#endregion

}

