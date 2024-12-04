namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportPrimaryEntityLoaderSchema

	/// <exclude/>
	public class IFileImportPrimaryEntityLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportPrimaryEntityLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportPrimaryEntityLoaderSchema(IFileImportPrimaryEntityLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67c9c358-07c2-4936-bf83-ed9335453799");
			Name = "IFileImportPrimaryEntityLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,203,106,195,48,16,69,215,49,248,31,134,116,211,110,172,125,154,102,83,90,48,36,144,69,127,96,106,141,19,129,245,96,36,5,66,233,191,87,150,156,196,125,64,119,154,123,231,106,206,72,6,53,121,135,29,193,27,49,163,183,125,104,158,173,233,213,33,50,6,101,77,243,170,6,106,181,179,28,234,234,163,174,234,106,113,199,116,72,14,180,38,16,247,41,187,130,246,214,181,103,165,145,207,47,38,168,112,222,90,148,196,57,37,132,128,181,143,122,52,55,83,61,218,30,36,6,132,222,50,184,18,5,26,179,138,124,115,137,137,89,206,197,247,65,117,160,46,195,255,157,189,40,212,87,236,29,133,163,149,126,5,251,124,83,49,127,210,205,240,58,59,68,109,224,132,67,36,159,57,195,145,254,100,253,13,91,20,135,140,26,76,122,234,167,101,62,83,98,247,203,77,129,134,155,212,172,69,46,114,244,100,149,204,8,121,157,52,226,126,90,242,218,62,75,62,60,78,75,146,145,101,207,92,127,150,15,251,38,102,237,11,139,75,233,152,248,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67c9c358-07c2-4936-bf83-ed9335453799"));
		}

		#endregion

	}

	#endregion

}

