namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float2ColumnProcessorSchema

	/// <exclude/>
	public class Float2ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float2ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float2ColumnProcessorSchema(Float2ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66ad8406-fee7-4774-941e-8dbeb16b8a1a");
			Name = "Float2ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,193,106,227,48,16,134,207,41,244,29,134,244,146,64,177,161,199,221,38,208,164,164,228,178,20,182,217,75,217,131,34,143,19,129,45,185,51,82,33,44,125,247,142,165,164,141,157,116,161,23,91,26,254,249,71,243,105,100,85,141,220,40,141,240,132,68,138,93,233,179,185,179,165,217,4,82,222,56,155,45,76,133,203,186,113,228,47,47,254,93,94,12,2,27,187,129,223,59,246,88,255,252,216,31,103,19,126,21,207,22,74,123,71,6,89,20,162,185,34,220,72,13,152,87,138,249,7,44,42,167,252,205,220,85,161,182,143,228,52,50,59,138,194,60,207,225,214,216,45,146,241,133,211,160,9,203,201,48,234,123,242,97,62,61,232,57,212,181,162,221,97,127,103,193,88,246,202,74,179,174,4,191,53,12,186,45,12,178,32,161,224,44,155,117,133,80,58,130,38,249,181,45,164,83,129,142,117,224,85,85,1,57,59,212,200,143,138,60,223,99,169,66,229,103,198,22,146,56,242,187,6,93,57,90,246,78,56,190,134,95,66,29,38,96,229,39,130,179,109,143,199,127,197,178,9,235,202,232,253,49,207,234,96,143,237,132,218,64,46,75,190,159,140,165,61,79,161,229,47,168,31,163,113,82,124,23,238,9,221,24,152,19,42,143,220,101,44,4,68,137,120,236,121,115,106,218,226,60,229,153,34,141,34,85,71,84,147,97,96,36,233,195,162,110,71,115,56,93,201,94,46,230,16,200,110,243,168,142,201,123,116,103,75,142,86,29,35,232,250,142,133,233,90,49,142,250,225,118,252,7,111,123,172,104,139,68,182,139,89,106,52,72,94,70,92,32,147,243,146,139,197,255,56,207,164,210,55,48,223,43,175,210,16,38,186,193,154,23,89,155,2,173,55,165,65,250,130,165,12,116,58,11,184,87,121,147,162,135,135,96,138,232,247,167,181,123,18,183,213,178,128,201,180,27,203,18,193,190,46,61,224,62,134,4,167,27,124,123,7,186,103,255,18,100,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66ad8406-fee7-4774-941e-8dbeb16b8a1a"));
		}

		#endregion

	}

	#endregion

}

