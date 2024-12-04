namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportServiceSchema

	/// <exclude/>
	public class IFileImportServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportServiceSchema(IFileImportServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1053b299-f5b8-465b-9060-5fe6f2707c72");
			Name = "IFileImportService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b49a3d-3e30-4c01-a6cc-3961eeed3fd5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,149,205,110,130,64,16,199,207,152,248,14,27,189,96,98,120,0,77,47,109,98,67,19,170,17,19,15,166,135,21,6,186,45,236,210,157,133,196,52,125,247,14,44,88,141,198,75,79,234,137,236,236,127,62,126,51,192,72,158,3,22,60,2,182,2,173,57,170,196,120,79,74,38,34,45,53,55,66,73,111,38,50,240,243,66,105,211,239,125,247,123,78,137,66,166,44,220,161,129,220,11,65,87,34,130,64,197,144,77,47,93,122,107,216,146,128,36,67,13,41,197,101,204,151,6,116,66,169,39,204,255,75,210,58,53,210,77,123,160,130,140,230,145,113,95,169,90,246,192,6,39,242,193,232,141,244,69,185,205,68,196,68,23,248,108,92,167,134,216,87,17,128,121,87,49,78,216,162,241,109,210,58,155,121,1,150,190,203,92,71,119,54,196,224,203,74,125,130,107,221,234,82,22,243,112,53,24,179,37,124,149,128,102,166,116,206,13,217,73,26,0,34,79,193,154,188,23,84,114,204,30,85,188,11,205,46,131,35,201,222,234,173,53,47,10,136,199,117,58,199,89,210,104,148,68,184,28,181,65,119,142,134,214,194,118,254,44,228,21,212,173,112,71,211,235,37,236,230,136,72,101,251,50,81,123,188,103,48,39,151,238,201,232,91,0,166,237,243,154,91,113,121,216,93,55,230,219,15,160,143,230,158,27,209,176,223,245,219,96,161,111,156,63,43,115,137,1,249,211,246,57,252,43,28,223,44,184,166,253,65,187,1,111,186,29,149,18,113,253,238,255,27,126,8,50,182,107,146,78,63,118,121,31,152,200,242,11,188,128,44,136,62,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1053b299-f5b8-465b-9060-5fe6f2707c72"));
		}

		#endregion

	}

	#endregion

}

