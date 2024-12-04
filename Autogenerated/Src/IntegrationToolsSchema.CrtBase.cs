namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationToolsSchema

	/// <exclude/>
	public class IntegrationToolsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationToolsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationToolsSchema(IntegrationToolsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("519fed56-3e17-4fb7-a535-2ce6cf3931cb");
			Name = "IntegrationTools";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,221,78,219,48,20,190,118,165,190,131,199,5,10,210,148,62,0,99,210,214,49,64,220,76,80,184,69,78,122,82,44,185,118,118,206,49,44,66,125,247,57,182,73,105,154,237,38,138,143,191,95,219,158,180,221,200,251,142,24,182,229,10,254,240,249,124,230,227,108,5,136,138,92,195,229,210,33,12,227,12,93,58,99,160,102,237,44,149,87,96,1,117,253,15,102,121,105,89,179,6,10,251,243,89,235,43,163,107,89,27,69,36,111,44,195,6,85,175,178,114,206,144,124,155,207,68,139,250,69,49,72,4,181,118,214,116,242,129,0,151,206,218,100,39,159,252,193,58,168,138,197,226,136,20,0,141,222,248,143,226,79,245,209,172,39,247,150,41,212,200,104,180,236,179,137,13,112,250,17,8,236,113,50,141,216,133,207,238,64,121,92,180,24,105,31,138,156,37,139,145,180,188,144,19,94,139,197,68,173,0,181,240,58,113,6,197,72,243,236,252,40,42,49,246,119,120,5,124,205,220,222,193,111,15,196,191,20,170,45,48,32,221,199,237,226,135,142,124,133,221,151,68,248,156,137,95,229,243,20,45,87,122,81,24,174,136,188,225,16,49,17,202,203,109,203,93,236,162,27,89,76,178,229,167,80,200,27,147,85,162,12,85,185,101,74,244,221,107,179,6,44,98,35,33,170,208,86,106,250,169,145,122,43,70,15,105,163,9,47,82,213,207,178,232,53,218,119,7,169,237,127,115,139,152,45,235,13,51,177,55,104,148,161,236,32,118,18,194,98,0,81,85,126,107,91,176,235,226,228,244,36,199,139,103,126,176,55,68,41,111,161,123,71,125,160,94,12,212,41,206,163,50,30,50,32,73,239,79,185,42,87,46,223,90,66,68,64,126,190,9,182,127,5,187,191,57,111,125,153,16,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("519fed56-3e17-4fb7-a535-2ce6cf3931cb"));
		}

		#endregion

	}

	#endregion

}

