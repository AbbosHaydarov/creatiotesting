namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityStageRepositorySchema

	/// <exclude/>
	public class OpportunityStageRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityStageRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityStageRepositorySchema(OpportunityStageRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55be1109-390d-43ae-b7ab-5425c01ee864");
			Name = "OpportunityStageRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,84,77,111,219,48,12,61,187,64,255,3,225,93,82,160,112,238,89,82,96,240,186,98,135,173,219,218,238,174,200,76,226,193,22,93,74,42,16,20,249,239,163,100,39,113,50,187,27,176,75,2,75,143,124,31,164,109,84,141,182,81,26,225,17,153,149,165,149,203,114,50,171,114,237,89,185,146,204,229,197,235,229,69,226,109,105,214,39,16,198,247,35,231,217,173,113,165,43,209,10,64,32,239,24,215,210,7,242,74,89,59,131,251,166,33,118,222,148,110,27,113,219,7,167,214,248,81,57,21,209,211,233,20,230,214,215,181,226,237,77,247,220,43,1,27,208,80,8,28,52,25,199,74,187,108,95,54,61,171,155,91,68,85,89,2,205,184,90,164,35,6,179,131,128,20,166,161,180,241,203,170,212,160,131,222,62,247,1,7,51,200,169,174,201,244,164,39,146,146,252,238,90,203,104,138,214,245,95,18,136,13,126,96,67,182,116,196,219,209,4,30,55,8,124,128,193,138,24,104,48,148,255,205,162,55,146,163,172,215,49,244,80,56,187,127,73,241,216,91,178,28,228,156,15,245,14,125,195,54,30,19,37,35,222,141,147,84,191,69,190,152,224,129,59,220,74,56,28,118,180,215,47,87,122,131,119,76,190,249,42,219,15,11,72,207,201,108,218,238,238,249,36,79,137,217,107,145,58,204,61,238,120,242,100,145,165,222,160,14,33,130,63,121,188,10,61,146,25,44,149,197,201,233,213,245,159,58,211,235,113,95,87,16,163,218,189,109,228,11,186,13,21,193,3,147,19,30,44,58,27,251,71,160,23,153,126,89,224,240,171,144,51,42,135,247,203,95,2,254,196,84,183,195,156,180,127,237,98,118,66,146,193,250,248,38,47,162,221,108,164,87,219,36,124,109,146,36,238,248,103,251,224,181,70,107,87,190,146,218,120,159,221,161,123,220,54,88,228,84,249,218,252,84,149,199,249,146,168,186,153,164,71,116,218,181,97,116,158,77,36,143,7,93,72,3,166,187,229,148,96,107,245,221,163,44,172,16,181,135,194,84,181,147,185,181,207,147,189,203,23,197,128,246,121,239,105,12,221,234,16,96,246,161,232,52,191,33,84,112,125,157,253,97,14,124,114,118,191,1,183,161,55,44,213,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55be1109-390d-43ae-b7ab-5425c01ee864"));
		}

		#endregion

	}

	#endregion

}

