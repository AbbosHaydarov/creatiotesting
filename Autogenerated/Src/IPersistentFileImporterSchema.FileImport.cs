namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPersistentFileImporterSchema

	/// <exclude/>
	public class IPersistentFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPersistentFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPersistentFileImporterSchema(IPersistentFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ad942417-9bd3-4771-a7af-0535dd659ac6");
			Name = "IPersistentFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,147,203,110,194,48,16,69,215,32,241,15,35,216,180,82,149,236,75,154,69,233,67,89,84,170,4,234,222,196,19,176,112,236,200,143,170,8,245,223,59,177,67,128,150,178,168,212,85,226,235,153,59,247,216,137,98,53,218,134,149,8,11,52,134,89,93,185,100,166,85,37,86,222,48,39,180,74,158,132,196,162,110,180,113,176,27,13,7,222,10,181,130,249,214,58,172,167,223,214,201,98,109,144,113,18,104,135,246,38,6,87,100,1,133,114,104,42,26,114,11,197,43,26,43,168,88,185,131,49,154,80,62,104,252,82,138,18,196,190,252,183,106,32,159,123,102,241,68,219,69,143,126,232,11,186,181,230,182,83,211,52,133,204,250,186,102,102,155,247,202,3,74,116,8,21,249,64,101,116,13,34,130,54,204,208,185,144,171,77,14,221,233,143,246,44,212,129,162,218,187,113,213,135,153,163,181,148,160,224,227,188,59,56,27,21,16,60,201,210,208,20,77,222,181,224,93,136,150,229,234,217,211,250,140,209,245,244,34,198,27,147,130,51,2,241,141,212,140,99,244,72,224,95,179,7,19,131,206,27,101,243,44,221,191,29,184,102,107,44,55,133,109,193,66,192,139,116,212,116,1,240,241,3,75,79,124,34,70,90,110,255,116,67,29,73,96,227,123,174,51,80,199,61,78,111,80,141,243,69,251,128,74,27,40,153,42,81,118,73,206,220,102,100,139,172,253,192,27,152,133,54,25,126,169,104,22,156,143,209,39,168,120,252,118,219,229,103,188,241,19,113,52,36,245,11,247,204,170,183,178,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ad942417-9bd3-4771-a7af-0535dd659ac6"));
		}

		#endregion

	}

	#endregion

}

