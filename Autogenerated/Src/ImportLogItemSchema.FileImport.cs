namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportLogItemSchema

	/// <exclude/>
	public class ImportLogItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportLogItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportLogItemSchema(ImportLogItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("567fdcd5-bfe6-4534-8033-3043e6eaac3e");
			Name = "ImportLogItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,193,106,195,48,12,134,207,46,244,29,68,119,217,46,205,189,91,11,35,116,80,232,160,208,190,128,155,41,153,89,108,7,201,129,133,177,119,159,28,167,172,233,70,233,37,40,202,143,254,239,151,226,180,69,110,116,129,112,64,34,205,190,12,243,220,187,210,84,45,233,96,188,155,191,152,26,55,182,241,20,166,147,175,233,68,181,108,92,5,251,142,3,218,199,233,68,58,119,132,149,40,33,175,53,243,2,146,120,235,171,141,40,122,65,150,101,240,196,173,181,154,186,213,240,254,236,192,56,14,218,137,181,47,33,188,27,134,34,14,0,41,72,152,188,99,115,172,17,74,79,192,193,83,116,53,253,104,168,189,148,78,62,216,132,120,178,200,206,60,154,246,88,155,98,24,57,66,2,65,188,96,84,18,76,158,191,73,196,60,80,91,136,237,2,118,253,164,36,184,76,210,55,114,66,29,144,199,121,186,6,69,137,8,5,97,185,156,141,12,103,217,42,50,255,133,62,81,143,212,247,15,16,247,174,212,62,232,226,227,64,241,88,75,89,73,220,200,124,109,155,208,201,25,148,250,30,34,160,123,75,41,198,145,118,228,27,164,96,144,111,72,180,149,5,203,127,193,186,194,235,160,137,2,94,147,118,224,172,48,244,68,138,135,98,64,251,215,106,253,89,96,19,175,40,179,36,30,132,152,239,38,211,179,117,92,247,189,88,73,234,158,55,165,243,3,109,189,196,160,8,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("567fdcd5-bfe6-4534-8033-3043e6eaac3e"));
		}

		#endregion

	}

	#endregion

}

