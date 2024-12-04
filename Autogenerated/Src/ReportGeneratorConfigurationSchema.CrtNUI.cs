namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGeneratorConfigurationSchema

	/// <exclude/>
	public class ReportGeneratorConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGeneratorConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGeneratorConfigurationSchema(ReportGeneratorConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd36e74f-9114-4b76-b9c4-17f67f21a2f8");
			Name = "ReportGeneratorConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,77,138,2,65,12,133,215,10,222,33,224,118,240,0,163,184,113,6,113,215,248,115,128,88,29,123,106,168,174,42,146,244,162,145,185,187,233,31,4,157,97,220,4,242,234,227,37,121,21,177,38,201,232,8,142,196,140,146,46,186,216,164,120,241,85,195,168,62,197,217,244,58,155,78,26,241,177,130,67,43,74,245,242,169,55,62,4,114,29,44,139,45,69,98,239,140,49,106,206,84,153,10,155,128,34,239,176,167,156,88,123,2,53,241,211,24,227,115,115,14,222,129,235,240,23,244,196,182,178,122,31,81,112,202,196,234,201,230,20,189,205,240,62,90,110,27,95,142,142,71,170,115,64,165,93,9,87,168,72,151,32,93,249,249,205,127,70,245,218,30,220,23,213,120,122,141,239,201,37,46,255,229,62,124,31,19,114,187,18,101,139,240,13,210,249,219,178,91,143,203,21,200,246,33,74,44,127,185,204,41,150,195,189,125,63,168,143,162,105,55,52,253,246,25,211,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd36e74f-9114-4b76-b9c4-17f67f21a2f8"));
		}

		#endregion

	}

	#endregion

}

