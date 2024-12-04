namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPersistentColumnProcessSchema

	/// <exclude/>
	public class IPersistentColumnProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPersistentColumnProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPersistentColumnProcessSchema(IPersistentColumnProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8195325f-d746-484e-902f-eef26fde2768");
			Name = "IPersistentColumnProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,143,191,110,132,48,12,135,103,144,120,7,139,91,218,133,236,45,199,114,186,74,55,84,98,232,11,164,193,80,75,228,143,236,228,212,234,116,239,222,0,109,85,49,100,136,237,223,103,127,78,91,148,160,13,194,27,50,107,241,99,108,78,222,141,52,37,214,145,188,107,94,104,198,139,13,158,99,85,222,138,162,42,139,144,222,103,50,64,46,34,143,75,244,210,35,11,73,68,23,79,126,78,214,245,236,13,138,228,217,91,126,197,129,113,202,40,120,197,248,225,7,121,130,126,37,84,229,210,84,74,65,43,201,90,205,95,221,111,225,252,137,38,69,132,171,158,19,10,132,141,71,110,106,224,47,163,246,161,54,104,214,22,92,86,58,214,180,158,220,47,21,204,119,74,221,229,45,136,96,24,199,99,189,9,253,235,170,174,85,107,124,165,93,61,13,240,35,241,176,159,133,61,250,241,121,51,57,160,27,54,211,252,187,87,229,253,27,10,114,114,221,93,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8195325f-d746-484e-902f-eef26fde2768"));
		}

		#endregion

	}

	#endregion

}

