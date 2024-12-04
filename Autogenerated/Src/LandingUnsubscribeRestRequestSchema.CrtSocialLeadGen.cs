namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingUnsubscribeRestRequestSchema

	/// <exclude/>
	public class LandingUnsubscribeRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingUnsubscribeRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingUnsubscribeRestRequestSchema(LandingUnsubscribeRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0d75d98-819a-c4f5-150a-b26f00c1ebdd");
			Name = "LandingUnsubscribeRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,143,205,106,195,48,16,132,207,49,248,29,22,122,183,239,77,233,197,165,161,16,104,72,82,122,150,173,181,179,96,73,238,174,68,9,161,239,94,89,114,74,127,14,189,172,216,217,209,240,141,85,6,101,82,29,194,17,153,149,184,222,87,141,179,61,13,129,149,39,103,171,131,235,72,141,91,84,122,131,182,44,46,101,177,10,66,118,128,195,89,60,154,117,89,68,229,134,113,136,102,104,70,37,114,11,91,101,117,180,188,88,9,173,116,76,45,238,81,252,30,223,66,124,210,135,186,174,225,78,130,49,138,207,247,203,222,140,46,104,224,236,130,135,227,51,188,147,63,1,217,222,177,73,48,160,90,23,60,140,57,190,186,230,212,223,130,166,208,142,212,65,55,131,252,199,177,138,101,226,252,162,223,177,155,144,61,97,172,176,75,57,249,254,27,54,9,75,54,144,158,57,254,130,92,73,54,129,52,52,140,115,129,87,108,31,99,151,39,13,23,24,208,175,65,230,241,177,80,160,213,25,36,237,89,253,41,70,237,19,99,122,5,196,177,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0d75d98-819a-c4f5-150a-b26f00c1ebdd"));
		}

		#endregion

	}

	#endregion

}

