namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillMailingResponseSchema

	/// <exclude/>
	public class MandrillMailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillMailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillMailingResponseSchema(MandrillMailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444");
			Name = "MandrillMailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa578739-72a4-4d6e-8c15-4350e99d075d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,77,75,196,64,12,134,207,21,252,15,129,189,183,247,117,241,178,130,120,40,44,91,111,226,33,157,166,117,96,62,202,76,70,92,197,255,110,250,233,42,168,120,155,100,222,55,121,242,58,180,20,123,84,4,247,20,2,70,223,114,190,247,174,213,93,10,200,218,187,188,68,215,4,109,76,69,225,89,139,238,237,242,34,75,81,187,14,170,83,100,178,87,223,234,252,152,28,107,75,185,24,52,26,253,58,142,17,149,232,54,129,58,41,96,111,48,198,45,44,163,75,212,70,6,28,133,196,187,72,163,180,40,10,216,197,100,45,134,211,181,252,36,195,224,91,224,39,90,109,16,103,36,59,249,243,93,177,24,100,192,195,13,50,202,41,28,80,241,163,52,250,84,27,173,64,13,187,127,90,61,92,39,210,21,244,16,124,79,129,53,9,237,97,244,79,255,95,232,150,198,39,229,12,4,244,66,42,141,41,174,166,115,196,137,177,36,91,83,24,8,23,196,218,123,3,85,82,138,132,116,200,59,203,58,226,33,232,44,139,243,227,253,23,144,249,40,136,140,156,226,255,118,223,38,221,64,53,26,239,154,63,150,111,72,66,28,131,146,106,234,157,183,164,243,1,244,35,18,158,95,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444"));
		}

		#endregion

	}

	#endregion

}

