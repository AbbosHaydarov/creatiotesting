namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderDomainsInfoRequestSchema

	/// <exclude/>
	public class SenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderDomainsInfoRequestSchema(SenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de4bf405-ea8f-4a2e-9f9c-d9b55688e01f");
			Name = "SenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,61,111,194,48,16,134,103,34,229,63,156,210,165,93,146,157,143,14,133,170,234,64,133,72,183,170,131,9,151,212,82,108,167,119,14,18,69,252,247,250,131,32,21,132,58,89,239,249,238,245,189,143,65,11,133,220,137,10,225,29,137,4,155,218,230,115,163,107,217,244,36,172,52,58,159,63,151,75,179,197,150,211,228,144,38,105,50,234,89,234,6,202,61,91,84,249,186,215,86,42,204,75,36,41,90,249,19,102,38,161,239,142,176,113,2,230,173,96,30,67,137,122,139,180,48,74,72,205,175,186,54,107,252,238,145,109,232,45,138,2,166,220,43,37,104,255,120,210,97,14,106,67,64,177,19,172,129,6,45,112,112,130,109,180,2,233,188,242,193,163,184,48,153,50,162,104,217,64,69,88,207,178,127,67,230,79,130,209,133,217,201,10,79,11,102,80,120,183,143,133,176,194,77,89,18,149,253,116,133,174,223,180,178,130,42,172,121,43,29,140,225,218,49,77,70,17,229,153,209,138,76,135,100,37,58,80,171,224,27,239,47,185,132,194,11,90,6,135,133,253,105,191,16,58,50,59,233,145,248,223,28,40,13,120,28,64,79,231,26,79,76,180,68,181,65,186,127,243,147,51,200,6,43,175,179,7,31,115,200,201,150,252,191,187,77,207,13,112,240,47,77,252,34,19,56,158,18,57,16,49,84,208,177,250,183,120,252,5,154,10,173,144,118,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de4bf405-ea8f-4a2e-9f9c-d9b55688e01f"));
		}

		#endregion

	}

	#endregion

}

