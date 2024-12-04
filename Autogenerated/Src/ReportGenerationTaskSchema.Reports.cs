namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationTaskSchema

	/// <exclude/>
	public class ReportGenerationTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationTaskSchema(ReportGenerationTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("68544e27-681d-4cfb-9b4f-a820834261f0");
			Name = "ReportGenerationTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,80,177,106,195,48,20,156,109,240,63,60,200,210,66,137,247,186,237,146,193,100,41,33,201,86,58,40,214,179,17,181,37,243,36,13,105,232,191,247,201,86,18,39,164,45,93,36,113,186,119,247,238,180,232,208,246,162,66,216,34,145,176,166,118,243,133,209,181,106,60,9,167,140,206,210,67,150,38,222,42,221,192,102,111,29,118,69,150,50,50,35,108,248,27,22,173,176,246,17,214,216,27,114,37,106,28,199,182,194,126,12,188,183,13,146,18,173,250,20,187,22,223,25,232,253,174,85,21,84,97,238,135,177,132,45,249,60,123,24,109,29,249,202,25,98,171,213,32,48,50,162,216,45,153,187,123,8,155,39,95,127,51,75,175,36,56,126,45,229,3,176,83,200,74,3,241,149,235,137,58,73,160,46,37,60,71,102,49,128,235,19,141,63,206,51,197,196,121,134,90,142,65,46,83,173,200,244,72,78,225,85,166,60,207,225,201,250,174,19,180,127,57,2,37,58,11,134,192,134,91,64,51,6,192,104,9,61,153,10,185,207,176,26,40,137,218,169,90,33,205,79,122,249,84,48,118,49,196,142,169,14,44,233,138,32,95,64,220,251,63,123,200,227,34,154,195,255,238,26,251,157,20,119,195,251,170,179,17,189,4,25,251,6,179,253,108,181,189,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68544e27-681d-4cfb-9b4f-a820834261f0"));
		}

		#endregion

	}

	#endregion

}

