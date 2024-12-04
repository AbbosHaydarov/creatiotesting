namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityEmailSenderSchema

	/// <exclude/>
	public class ActivityEmailSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityEmailSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityEmailSenderSchema(ActivityEmailSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b1422ac9-6446-43b6-80b8-7d67c06e67e1");
			Name = "ActivityEmailSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("acb004d0-c421-4dff-b075-f4fdc1c90074");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,203,110,219,48,16,60,43,64,254,97,225,30,42,3,134,117,79,98,3,169,225,22,57,24,8,146,246,3,104,106,37,179,144,72,129,75,186,48,138,252,123,151,212,195,86,34,167,23,1,164,102,103,103,102,151,90,212,72,141,144,8,63,209,90,65,166,112,203,157,80,213,242,21,117,142,246,246,230,239,237,77,226,73,233,18,94,79,228,176,190,31,206,231,130,141,209,133,42,189,21,78,25,61,13,176,120,237,126,185,213,78,57,133,196,0,134,124,177,88,50,11,108,42,65,116,7,143,210,169,163,114,167,109,205,162,122,77,12,203,178,12,30,200,215,181,176,167,53,188,96,99,145,80,59,2,119,64,160,136,3,25,40,192,20,241,206,236,127,163,116,95,9,2,17,176,105,18,37,18,115,32,130,180,88,172,102,125,171,89,182,94,62,100,61,55,247,106,252,190,82,178,163,155,16,4,147,50,191,9,66,46,230,252,248,123,182,101,52,57,235,165,51,150,184,238,57,82,183,144,145,165,9,93,23,220,44,17,2,197,88,103,203,208,8,43,106,208,60,215,213,12,67,201,166,82,156,204,119,17,10,78,179,245,163,6,197,26,132,230,153,119,217,196,72,100,132,65,209,226,152,57,18,77,243,122,66,203,78,52,39,202,166,38,57,3,4,228,128,25,241,117,129,78,24,75,159,182,31,36,195,71,23,11,248,53,82,16,187,157,143,243,208,36,185,131,61,143,32,157,170,126,7,135,176,228,201,91,55,41,22,210,14,107,60,185,29,186,131,201,121,37,159,173,113,92,136,121,251,191,233,143,112,84,214,121,81,13,190,32,120,74,127,120,149,131,232,174,158,242,197,249,55,25,111,37,246,199,5,68,235,187,118,51,251,13,93,68,43,201,222,152,10,84,169,249,189,188,168,242,192,123,190,226,73,85,132,115,88,197,72,147,180,231,153,7,215,241,249,166,151,93,223,55,235,249,71,172,243,251,107,158,142,134,93,108,76,221,84,232,48,144,243,67,30,90,14,246,130,154,152,58,191,236,49,116,64,116,29,254,159,242,197,203,232,246,69,227,159,207,179,141,237,63,15,226,74,255,118,246,227,203,183,127,80,37,29,233,28,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1422ac9-6446-43b6-80b8-7d67c06e67e1"));
		}

		#endregion

	}

	#endregion

}

