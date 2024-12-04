namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StartFlowRequestSchema

	/// <exclude/>
	public class StartFlowRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StartFlowRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StartFlowRequestSchema(StartFlowRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e75e9ef-b097-4f1c-a537-00209c3c90e6");
			Name = "StartFlowRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,193,106,195,48,12,134,207,13,228,29,4,187,39,247,182,236,176,192,70,15,133,210,118,15,224,197,106,102,112,236,76,146,25,165,244,221,39,39,105,217,214,203,15,250,45,253,250,228,96,122,228,193,180,8,13,73,227,99,178,155,32,216,145,17,23,67,181,141,22,61,87,123,252,74,200,194,101,113,41,139,69,98,23,58,56,156,89,176,95,149,133,58,79,132,157,182,67,227,13,243,18,14,98,72,94,125,252,158,231,198,158,186,174,97,205,169,239,13,157,159,231,122,143,3,33,99,16,6,3,52,53,131,68,224,28,0,242,137,96,146,106,16,215,142,60,112,210,208,234,22,86,255,74,27,210,135,119,45,180,25,224,97,63,44,225,197,48,222,105,22,122,133,234,29,123,71,113,64,18,135,202,190,27,131,166,247,255,200,163,113,84,42,12,22,18,35,129,179,25,238,228,144,50,213,35,214,141,235,45,57,171,31,140,249,138,119,29,220,88,184,64,135,178,2,206,114,157,121,52,119,66,26,235,201,253,107,94,127,0,22,56,19,156,176,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e75e9ef-b097-4f1c-a537-00209c3c90e6"));
		}

		#endregion

	}

	#endregion

}

