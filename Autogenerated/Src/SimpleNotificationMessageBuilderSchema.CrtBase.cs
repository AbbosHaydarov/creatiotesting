namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SimpleNotificationMessageBuilderSchema

	/// <exclude/>
	public class SimpleNotificationMessageBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SimpleNotificationMessageBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SimpleNotificationMessageBuilderSchema(SimpleNotificationMessageBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("314059c6-f688-44bf-b84c-c7c747f99b73");
			Name = "SimpleNotificationMessageBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,81,107,219,48,16,126,118,161,255,225,72,95,18,40,201,246,154,46,131,181,208,206,15,233,10,233,222,2,67,181,46,142,192,146,140,36,175,132,144,255,222,147,37,219,113,199,18,151,237,37,145,238,238,211,125,247,221,157,21,147,104,75,150,33,60,163,49,204,234,141,155,222,105,181,17,121,101,152,19,90,93,94,236,47,47,146,202,10,149,195,106,103,29,202,155,246,222,65,150,104,45,203,201,70,96,41,181,162,24,138,186,50,152,211,19,112,87,48,107,231,176,18,178,44,240,81,59,177,17,89,253,120,128,225,109,37,10,142,166,198,148,213,75,33,50,200,60,228,44,2,230,144,158,122,47,33,238,244,219,18,185,23,88,112,98,242,100,196,111,230,48,56,203,112,1,131,140,107,85,236,98,214,248,22,252,146,241,176,0,133,175,125,231,120,18,10,77,174,80,241,144,163,159,240,201,232,18,141,19,232,147,214,149,5,255,108,54,131,47,182,146,146,153,221,215,198,240,128,206,130,54,96,253,191,224,168,168,48,170,81,111,192,109,17,252,213,237,166,45,122,118,12,143,170,61,84,130,67,202,193,183,44,73,114,116,190,87,73,98,227,225,240,193,228,162,203,206,184,20,10,42,37,220,0,6,52,39,223,124,252,79,10,255,15,108,20,205,104,195,195,203,89,183,26,156,6,229,91,127,70,18,235,140,31,213,31,45,238,95,217,88,106,117,167,75,28,142,65,28,86,1,121,154,192,223,38,105,137,110,171,249,144,49,170,167,223,2,107,184,29,117,115,64,239,106,116,202,199,147,200,211,160,171,140,122,215,210,179,138,253,193,97,75,203,117,46,127,186,180,249,247,58,46,224,195,185,101,114,228,14,175,209,70,54,203,57,13,142,160,104,204,21,229,94,68,221,111,142,203,9,33,31,47,227,69,243,97,243,86,35,111,41,250,189,144,193,63,189,215,70,50,55,30,237,247,176,30,25,204,180,33,209,215,163,57,221,246,159,14,235,209,53,29,218,89,39,59,153,63,147,249,112,32,79,202,175,187,121,158,12,47,162,94,151,248,165,28,54,184,94,242,128,111,203,104,21,167,197,94,116,211,18,212,109,157,190,242,198,29,84,8,1,189,190,246,58,210,64,79,236,66,176,246,141,100,123,3,191,59,227,112,195,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("314059c6-f688-44bf-b84c-c7c747f99b73"));
		}

		#endregion

	}

	#endregion

}

