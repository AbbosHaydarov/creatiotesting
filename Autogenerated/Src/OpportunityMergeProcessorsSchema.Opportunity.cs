namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityMergeProcessorsSchema

	/// <exclude/>
	public class OpportunityMergeProcessorsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityMergeProcessorsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityMergeProcessorsSchema(OpportunityMergeProcessorsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("80a4ac9d-51e1-4221-91bf-e86e043b909e");
			Name = "OpportunityMergeProcessors";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,77,111,218,64,16,61,131,196,127,24,185,23,144,44,115,79,8,7,66,138,80,155,52,42,85,47,85,21,45,235,193,89,201,222,181,102,119,147,162,136,255,222,217,197,6,147,144,166,146,109,121,118,62,222,155,121,99,107,81,161,173,133,68,248,129,68,194,154,141,203,174,141,222,168,194,147,112,202,232,65,255,101,208,239,121,171,116,1,171,173,117,88,93,190,178,57,190,44,81,134,96,155,45,80,35,41,121,140,233,150,37,204,230,179,119,93,159,133,116,134,20,90,142,224,152,79,132,5,151,132,235,82,88,123,1,223,234,218,144,243,90,185,237,202,137,2,237,45,82,129,247,196,151,145,104,173,33,206,225,107,60,30,195,196,250,170,18,180,157,54,118,39,119,169,99,54,84,33,27,114,116,66,149,80,19,214,109,149,12,218,34,227,78,149,95,115,220,8,95,186,153,210,57,83,31,186,109,141,102,51,92,206,125,93,42,41,28,218,149,124,196,74,188,33,53,74,225,142,71,12,87,144,124,220,65,50,250,205,88,181,95,115,77,144,161,239,255,104,27,46,96,38,44,70,111,227,108,60,41,124,204,143,241,130,190,111,198,22,15,110,5,235,75,128,218,49,60,216,88,1,52,183,147,29,82,186,67,106,153,91,71,65,222,155,152,182,199,141,51,120,129,2,221,37,236,94,13,35,217,235,125,158,66,67,180,209,75,52,91,118,30,62,158,212,130,68,21,73,94,37,249,161,251,100,122,156,4,200,195,190,102,147,113,140,63,159,94,152,50,71,253,29,165,161,60,153,46,216,2,138,6,44,243,127,38,230,235,155,63,40,61,111,51,227,206,218,119,80,218,58,161,37,158,160,54,51,123,50,42,111,155,29,126,85,214,77,22,94,229,83,56,182,144,66,56,129,46,169,20,58,213,143,160,35,136,146,246,158,4,177,22,188,22,247,1,205,242,216,53,62,195,23,220,254,20,165,231,67,69,147,189,84,105,35,217,116,152,196,53,122,184,243,213,26,41,73,97,111,103,171,71,243,188,212,76,175,32,230,55,19,188,169,225,51,238,245,214,188,121,89,75,187,203,245,148,230,145,27,151,236,74,31,144,15,4,79,125,205,151,218,32,237,248,17,238,240,99,64,157,239,255,13,131,254,238,47,23,180,93,45,192,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("80a4ac9d-51e1-4221-91bf-e86e043b909e"));
		}

		#endregion

	}

	#endregion

}

