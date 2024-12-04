namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichSaveEntityDataSchema

	/// <exclude/>
	public class EnrichSaveEntityDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichSaveEntityDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichSaveEntityDataSchema(EnrichSaveEntityDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a0b8b3a-216a-4b0e-a0df-953fd0dac922");
			Name = "EnrichSaveEntityData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,77,111,194,48,12,134,207,69,226,63,88,112,217,164,137,222,25,112,1,52,77,211,54,52,166,93,16,135,144,186,16,173,73,80,146,34,186,105,255,125,78,82,208,96,95,130,75,21,219,175,157,199,118,170,152,68,187,102,28,225,25,141,97,86,231,174,51,212,42,23,203,210,48,39,180,106,54,222,155,141,164,180,66,45,97,90,89,135,146,226,69,129,220,7,109,231,6,21,26,193,175,143,53,79,165,114,66,98,103,74,81,86,136,183,80,139,84,164,107,27,92,146,1,195,130,89,219,133,177,162,252,213,148,109,112,76,41,174,26,49,199,130,46,77,83,232,217,82,74,102,170,65,109,79,140,222,136,12,45,100,164,2,174,149,99,220,193,218,232,53,221,227,200,191,16,42,243,24,185,54,128,161,50,102,116,160,194,130,162,150,109,40,216,217,21,79,191,84,159,249,123,169,115,103,168,226,156,28,235,114,81,8,14,220,83,254,2,153,208,104,232,187,239,104,18,56,252,77,93,152,132,244,24,63,238,164,118,32,2,55,152,247,91,177,230,148,88,37,27,111,29,42,75,213,162,217,74,7,160,104,71,158,249,59,116,164,190,71,185,64,115,241,64,50,232,67,43,116,91,121,171,117,233,27,217,117,98,157,241,147,137,151,5,177,223,108,146,44,209,249,245,37,137,173,15,31,127,80,223,210,114,235,49,130,54,25,154,19,192,130,254,144,73,40,7,143,222,125,54,11,215,69,41,21,108,88,81,162,61,1,38,38,28,210,140,68,120,213,148,214,139,195,186,170,135,54,128,151,32,63,135,114,188,21,214,249,113,209,251,148,244,4,145,25,190,170,177,79,1,126,197,138,126,60,159,244,211,90,103,115,184,219,11,254,193,108,163,202,226,139,13,118,244,30,58,201,247,9,101,139,56,104,26,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a0b8b3a-216a-4b0e-a0df-953fd0dac922"));
		}

		#endregion

	}

	#endregion

}

