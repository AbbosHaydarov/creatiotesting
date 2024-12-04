namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessagePublisherManagerSchema

	/// <exclude/>
	public class MessagePublisherManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessagePublisherManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessagePublisherManagerSchema(MessagePublisherManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9");
			Name = "MessagePublisherManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,82,77,107,194,64,16,61,71,240,63,76,241,18,65,242,3,172,90,138,162,120,176,8,181,244,88,214,100,212,109,227,174,204,110,44,161,244,191,119,54,27,63,18,181,80,232,37,97,103,223,190,121,239,205,40,177,69,179,19,49,194,2,137,132,209,43,27,13,181,90,201,117,70,194,74,173,154,141,175,102,35,200,140,84,107,120,206,141,197,237,125,237,204,248,52,197,216,129,77,52,65,133,36,227,19,230,156,150,240,86,61,26,139,216,106,146,104,24,193,152,22,225,154,249,96,152,10,99,186,48,67,99,196,26,231,217,50,149,102,131,52,19,138,143,84,64,119,174,24,67,236,144,183,129,1,187,224,239,145,120,44,49,101,226,57,201,189,176,78,150,187,220,249,19,16,138,68,171,52,135,23,131,196,105,40,239,14,222,178,202,185,124,213,66,149,120,214,106,11,6,26,75,153,243,197,141,10,149,101,27,175,248,134,214,176,214,180,218,179,13,110,28,65,80,147,2,253,26,206,5,29,124,255,46,112,134,118,163,147,83,10,213,16,244,242,157,169,96,130,118,202,62,132,138,49,100,59,110,116,69,212,79,188,56,29,24,201,162,155,160,188,231,47,59,224,255,3,88,113,194,137,25,9,43,14,154,247,130,224,83,211,71,177,111,139,124,135,115,210,123,153,32,177,250,98,208,126,9,114,94,34,219,155,190,94,67,14,194,118,225,44,112,69,176,238,211,191,206,233,72,220,57,60,170,45,95,18,218,140,148,127,123,215,7,149,165,41,60,192,35,251,96,219,154,162,33,79,223,226,209,179,195,117,234,147,239,84,220,117,11,146,191,37,126,185,14,123,45,19,95,55,155,255,72,122,91,91,47,14,42,156,214,119,174,125,62,222,179,110,103,148,62,53,185,130,240,130,177,140,239,208,53,168,3,162,131,157,146,132,211,185,21,145,175,86,139,92,251,1,222,149,159,177,159,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9"));
		}

		#endregion

	}

	#endregion

}

