namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebTextColumnProcessorSchema

	/// <exclude/>
	public class WebTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebTextColumnProcessorSchema(WebTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("12ec7f7e-14ab-4185-85fd-238e9d07bc1e");
			Name = "WebTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,209,107,219,48,16,198,159,83,232,255,112,100,47,9,12,251,189,109,2,107,74,71,96,148,66,147,237,97,236,65,145,207,233,129,45,121,167,83,105,24,251,223,119,182,156,173,78,221,65,95,108,233,248,244,125,186,159,36,103,106,12,141,177,8,27,100,54,193,151,146,173,188,43,105,31,217,8,121,151,221,82,133,235,186,241,44,231,103,191,206,207,38,49,144,219,195,195,33,8,214,151,127,231,47,87,51,190,85,207,110,141,21,207,132,65,21,170,249,192,184,215,12,88,85,38,132,11,248,134,187,13,62,203,202,87,177,118,247,236,45,134,224,185,83,230,121,14,87,228,30,145,73,10,111,193,50,150,139,233,136,122,154,47,143,242,16,235,218,240,225,56,255,228,128,92,16,227,180,89,95,130,60,82,0,219,6,131,14,88,41,120,23,104,87,33,148,158,161,73,126,109,11,95,188,219,183,65,96,187,36,120,50,85,196,144,29,83,242,23,49,223,111,176,52,177,146,107,114,133,46,157,201,161,65,95,206,214,39,123,156,127,132,59,229,14,11,112,250,83,193,120,227,243,249,15,245,108,226,174,34,219,239,116,92,8,23,48,202,109,162,231,165,223,127,152,181,67,225,216,30,129,210,190,239,140,147,226,157,120,95,241,237,10,43,70,35,24,134,148,149,128,42,17,123,203,241,6,212,181,229,249,26,104,170,52,134,77,221,177,90,76,99,64,214,62,28,218,246,118,78,151,91,157,235,201,28,11,217,85,222,169,187,197,61,186,241,204,217,118,224,4,67,227,185,50,221,153,128,179,211,114,251,4,38,191,123,174,232,138,132,118,200,89,51,26,100,209,107,174,148,217,139,174,197,226,127,160,175,53,233,29,160,111,140,152,116,13,19,223,232,232,167,142,169,64,39,84,18,242,27,48,245,82,167,189,128,127,210,119,169,122,248,28,169,232,252,190,182,118,27,117,219,174,11,88,44,135,181,172,71,120,42,76,175,248,148,67,162,51,44,106,237,15,219,188,221,195,107,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12ec7f7e-14ab-4185-85fd-238e9d07bc1e"));
		}

		#endregion

	}

	#endregion

}

