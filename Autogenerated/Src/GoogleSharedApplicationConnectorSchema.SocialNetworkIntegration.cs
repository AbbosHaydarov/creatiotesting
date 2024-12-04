namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSharedApplicationConnectorSchema

	/// <exclude/>
	public class GoogleSharedApplicationConnectorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSharedApplicationConnectorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSharedApplicationConnectorSchema(GoogleSharedApplicationConnectorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("052166b4-a428-48fe-9cd6-6ad37cc6b8ec");
			Name = "GoogleSharedApplicationConnector";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,203,106,195,48,16,60,199,224,127,88,232,37,185,216,247,212,13,180,61,132,30,10,165,233,15,108,236,181,35,176,37,179,146,82,74,201,191,119,35,217,110,226,20,122,17,104,231,177,163,145,198,142,108,143,37,193,7,49,163,53,181,203,158,141,174,85,227,25,157,50,58,219,153,82,97,155,38,223,105,178,240,86,233,230,130,185,53,166,105,105,71,124,36,22,149,166,210,25,190,79,19,161,222,49,53,34,135,178,69,107,215,48,48,15,200,84,61,246,125,171,202,224,62,137,130,166,247,123,1,162,228,95,5,172,225,9,237,124,185,184,72,80,57,167,0,175,228,14,166,146,8,111,193,61,130,121,158,67,97,125,215,33,127,109,198,193,59,57,207,218,66,105,180,64,196,160,116,109,184,11,107,1,247,198,59,104,66,40,176,33,21,224,111,172,108,114,205,231,182,5,71,223,141,132,188,241,205,138,124,132,207,252,161,129,248,246,145,255,34,116,216,146,187,188,47,87,112,254,144,197,226,136,60,164,154,53,1,15,160,233,115,172,241,26,91,174,228,147,68,28,87,255,173,207,110,54,6,205,105,104,151,116,21,11,14,247,56,189,30,158,126,0,202,180,60,157,92,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("052166b4-a428-48fe-9cd6-6ad37cc6b8ec"));
		}

		#endregion

	}

	#endregion

}

