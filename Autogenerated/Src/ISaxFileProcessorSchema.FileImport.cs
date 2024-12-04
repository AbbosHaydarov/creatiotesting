namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISaxFileProcessorSchema

	/// <exclude/>
	public class ISaxFileProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISaxFileProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISaxFileProcessorSchema(ISaxFileProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c7807a8-a16e-4cad-b5b6-7f795f2cb0e0");
			Name = "ISaxFileProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,83,77,79,27,49,16,61,7,137,255,48,130,75,185,100,239,176,221,11,130,116,165,86,138,72,219,187,99,207,102,45,214,227,149,199,166,137,16,255,29,219,203,166,73,248,170,168,196,109,61,122,111,230,125,104,73,24,228,94,72,132,159,232,156,96,219,248,233,165,165,70,175,130,19,94,91,154,94,235,14,107,211,91,231,143,143,238,143,143,38,129,53,173,96,177,97,143,230,226,224,29,169,93,135,50,241,120,58,67,66,167,101,196,68,212,169,195,85,156,66,77,30,93,19,239,157,67,189,16,235,180,124,238,172,68,102,235,50,176,15,203,78,75,208,35,238,37,216,36,233,216,174,252,129,190,181,138,207,97,158,169,121,203,164,40,10,40,57,24,35,220,166,26,7,79,43,144,97,165,239,144,160,211,236,161,69,161,208,241,116,203,42,14,105,101,47,156,48,64,49,170,175,39,58,71,49,79,19,140,18,185,86,39,85,77,10,215,16,247,114,10,172,44,50,254,47,221,161,15,142,184,250,190,123,174,44,198,113,194,213,87,20,12,58,177,236,176,28,194,142,73,6,67,21,204,208,127,27,40,95,102,65,43,120,126,255,236,226,13,203,151,45,202,91,240,173,240,208,196,16,65,90,242,66,19,143,58,64,144,2,103,255,252,151,255,87,29,239,155,188,179,81,127,22,84,115,106,244,183,232,180,250,144,171,167,34,119,107,68,242,218,235,88,109,227,172,1,92,75,236,62,171,210,241,244,187,157,94,37,224,166,130,155,152,125,254,142,164,15,249,95,160,135,208,199,222,172,7,150,45,26,1,203,13,104,245,175,142,19,113,145,121,191,14,251,203,37,213,164,253,205,22,51,72,220,227,140,234,78,145,212,240,27,230,247,195,240,175,239,13,31,30,1,134,121,243,174,99,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c7807a8-a16e-4cad-b5b6-7f795f2cb0e0"));
		}

		#endregion

	}

	#endregion

}

