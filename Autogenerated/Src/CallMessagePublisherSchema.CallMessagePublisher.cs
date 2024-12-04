namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CallMessagePublisherSchema

	/// <exclude/>
	public class CallMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CallMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CallMessagePublisherSchema(CallMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7614e58c-2fc5-4196-ab0f-e9195ef944f6");
			Name = "CallMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e1e897dc-76f3-4978-8d04-4d8824362a32");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,80,237,106,195,48,12,252,237,64,222,65,116,127,58,40,125,128,236,3,186,116,219,175,141,65,183,7,80,93,53,53,56,78,145,236,65,24,125,247,201,73,97,100,45,24,219,119,62,157,172,75,226,66,3,155,94,34,181,203,186,243,158,108,116,93,144,229,43,5,98,103,239,202,34,13,146,79,98,70,233,246,81,85,76,74,151,69,192,150,228,136,150,38,143,97,239,154,196,152,93,202,226,167,44,140,174,27,166,70,49,212,30,69,42,168,209,251,55,18,193,134,62,210,214,59,57,16,103,67,115,204,200,130,205,178,171,42,168,224,9,133,46,139,141,118,210,253,175,83,23,36,114,178,177,227,10,6,157,29,5,231,22,215,204,231,95,66,172,133,97,204,0,210,4,46,96,237,134,11,114,127,175,222,26,202,2,198,243,17,40,68,23,251,23,71,126,39,107,140,120,155,91,153,10,182,250,217,249,127,159,11,49,228,152,140,121,30,248,141,61,80,139,239,154,45,60,192,108,165,53,223,202,206,52,113,99,78,231,33,41,236,198,57,7,60,178,83,242,244,11,94,204,122,139,217,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7614e58c-2fc5-4196-ab0f-e9195ef944f6"));
		}

		#endregion

	}

	#endregion

}

