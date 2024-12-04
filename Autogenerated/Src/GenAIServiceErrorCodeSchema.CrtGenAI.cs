namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenAIServiceErrorCodeSchema

	/// <exclude/>
	public class GenAIServiceErrorCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenAIServiceErrorCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenAIServiceErrorCodeSchema(GenAIServiceErrorCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2c8ba8dd-b291-4ffb-89f1-3346066bacf9");
			Name = "GenAIServiceErrorCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e8ce15e9-1e70-4be4-81f7-3d2e4afa30e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,193,106,195,48,12,134,207,11,228,29,124,220,46,125,129,210,67,41,97,20,70,47,109,30,64,181,149,78,204,149,138,236,164,91,203,222,125,110,96,56,221,6,243,197,224,239,151,62,36,49,28,49,156,192,162,217,161,42,4,233,226,108,37,220,209,161,87,136,36,60,123,70,94,174,235,234,90,87,15,167,126,239,201,154,16,83,98,141,245,16,130,25,227,45,234,64,22,27,85,209,149,56,76,181,183,250,31,13,138,224,132,253,71,250,43,241,193,180,252,198,114,230,177,203,44,12,167,81,164,123,156,210,167,249,255,150,53,91,81,69,27,239,198,206,190,191,243,18,243,109,43,212,141,196,229,0,228,97,239,49,91,127,103,37,198,23,58,82,108,222,45,162,67,151,101,119,184,196,211,50,244,241,85,148,46,83,205,148,150,93,110,0,79,174,85,154,94,235,155,149,24,54,210,112,164,72,24,178,33,179,209,240,89,87,117,149,158,47,82,153,22,102,105,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2c8ba8dd-b291-4ffb-89f1-3346066bacf9"));
		}

		#endregion

	}

	#endregion

}

