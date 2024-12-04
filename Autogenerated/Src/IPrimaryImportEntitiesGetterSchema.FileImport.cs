namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPrimaryImportEntitiesGetterSchema

	/// <exclude/>
	public class IPrimaryImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPrimaryImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPrimaryImportEntitiesGetterSchema(IPrimaryImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6f63fcc-5fd6-4ac9-8d4c-acfa8b8d627e");
			Name = "IPrimaryImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,145,77,106,195,48,16,133,215,49,248,14,67,86,45,20,233,0,117,189,41,105,48,217,4,218,11,40,102,28,68,165,177,25,73,11,19,114,247,74,86,252,67,219,157,102,244,61,189,247,16,41,139,110,80,45,194,23,50,43,215,119,94,188,247,212,233,107,96,229,117,79,226,67,27,108,236,208,179,47,139,91,89,236,130,211,116,133,207,209,121,180,17,53,6,219,196,57,113,68,66,214,237,235,194,108,95,100,20,7,242,218,107,116,17,136,200,16,46,70,183,160,201,35,119,201,191,57,179,182,138,199,236,53,195,71,244,17,136,124,178,222,73,41,161,114,193,38,174,158,23,17,113,48,100,49,224,67,39,22,92,254,230,171,65,177,178,64,177,249,219,126,58,99,180,112,251,58,59,195,186,18,149,156,134,255,165,223,56,198,250,193,82,148,158,112,132,54,15,127,69,140,62,48,185,250,81,112,205,88,201,249,42,177,205,129,130,69,86,23,131,213,84,127,172,83,183,167,28,235,188,164,218,4,124,129,173,40,131,57,83,13,107,188,231,244,37,247,178,184,255,0,195,137,209,221,237,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6f63fcc-5fd6-4ac9-8d4c-acfa8b8d627e"));
		}

		#endregion

	}

	#endregion

}

