namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float8ColumnProcessorSchema

	/// <exclude/>
	public class Float8ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float8ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float8ColumnProcessorSchema(Float8ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("841cbf68-2096-4585-a283-015e96ff338e");
			Name = "Float8ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,193,106,227,48,16,134,207,41,244,29,134,244,146,64,177,175,101,183,9,52,41,41,185,44,133,109,246,82,246,160,200,227,68,96,75,238,140,84,8,75,223,189,99,41,105,99,39,93,232,197,150,134,127,254,209,124,26,89,85,35,55,74,35,60,33,145,98,87,250,108,238,108,105,54,129,148,55,206,102,11,83,225,178,110,28,249,203,139,127,151,23,131,192,198,110,224,247,142,61,214,63,63,246,199,217,132,95,197,179,133,210,222,145,65,22,133,104,174,8,55,82,3,230,149,98,254,1,139,202,41,127,51,119,85,168,237,35,57,141,204,142,162,48,207,115,184,53,118,139,100,124,225,52,104,194,114,50,140,250,158,124,152,79,15,122,14,117,173,104,119,216,223,89,48,150,189,178,210,172,43,193,111,13,131,110,11,131,44,72,40,56,203,102,93,33,148,142,160,73,126,109,11,233,84,160,99,29,120,85,85,64,206,14,53,242,163,34,207,247,88,170,80,249,153,177,133,36,142,252,174,65,87,142,150,189,19,142,175,225,151,80,135,9,88,249,137,224,108,219,227,241,95,177,108,194,186,50,122,127,204,179,58,216,99,59,161,54,144,203,146,239,39,99,105,207,83,104,249,11,234,199,104,156,20,223,133,123,66,55,6,230,132,202,35,119,25,11,1,81,34,30,123,222,156,154,182,56,79,121,166,72,163,72,213,17,213,100,24,24,73,250,176,168,219,209,28,78,87,178,151,139,57,4,178,219,60,170,99,242,30,221,217,146,163,85,199,8,186,190,99,97,186,86,140,163,126,184,29,255,193,219,30,43,218,34,145,237,98,150,26,13,146,151,17,23,200,228,188,228,98,241,63,206,51,169,244,13,204,247,202,171,52,132,137,110,176,230,69,214,166,64,235,77,105,144,190,96,41,3,157,206,2,238,85,222,164,232,225,33,152,34,250,253,105,237,158,196,109,181,44,96,50,237,198,178,68,176,175,75,15,184,143,33,193,233,6,223,222,1,117,95,2,0,100,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("841cbf68-2096-4585-a283-015e96ff338e"));
		}

		#endregion

	}

	#endregion

}

