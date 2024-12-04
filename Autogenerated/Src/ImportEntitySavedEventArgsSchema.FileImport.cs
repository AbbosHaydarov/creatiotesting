namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySavedEventArgsSchema

	/// <exclude/>
	public class ImportEntitySavedEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySavedEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySavedEventArgsSchema(ImportEntitySavedEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9862337-3e49-447c-a6fe-f4c905fd9341");
			Name = "ImportEntitySavedEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,193,106,195,48,12,134,207,41,244,29,12,189,231,1,218,211,8,221,200,97,80,150,237,1,188,68,113,197,98,217,88,118,183,80,246,238,83,226,82,186,110,228,34,144,252,233,211,111,210,22,216,235,22,212,43,132,160,217,245,177,172,28,245,104,82,208,17,29,149,143,56,64,109,189,11,113,189,58,175,87,69,98,36,163,154,145,35,216,221,181,191,221,14,80,238,41,98,68,96,1,4,217,4,48,162,82,213,160,153,183,42,219,102,100,108,244,9,186,253,9,40,62,4,195,51,237,211,251,128,173,106,39,120,129,85,34,162,222,61,3,179,54,112,163,40,36,165,212,235,213,67,112,30,194,148,102,171,14,179,59,191,251,124,231,41,97,119,57,211,136,75,54,234,78,157,149,129,184,83,60,149,239,191,248,139,115,177,105,143,96,245,219,34,156,115,75,2,180,58,140,151,238,14,47,138,123,123,117,76,244,177,232,77,72,81,66,124,214,212,193,215,127,220,6,168,203,223,159,251,60,253,61,148,217,15,16,73,126,79,253,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9862337-3e49-447c-a6fe-f4c905fd9341"));
		}

		#endregion

	}

	#endregion

}

