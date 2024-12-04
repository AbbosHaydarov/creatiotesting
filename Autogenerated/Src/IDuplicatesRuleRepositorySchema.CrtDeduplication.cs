namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesRuleRepositorySchema

	/// <exclude/>
	public class IDuplicatesRuleRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesRuleRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesRuleRepositorySchema(IDuplicatesRuleRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("724d927b-4ab0-492e-878f-0d68376bae8a");
			Name = "IDuplicatesRuleRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,77,79,194,64,16,61,75,226,127,152,224,5,19,211,222,1,123,161,134,144,104,52,32,63,96,105,167,176,73,187,91,247,195,164,49,252,119,103,119,249,106,17,244,226,165,233,188,157,121,243,230,205,182,130,85,168,107,150,33,188,163,82,76,203,194,68,19,41,10,190,182,138,25,46,69,148,98,110,235,146,103,62,186,237,125,221,246,110,172,230,98,13,139,70,27,172,70,157,152,170,203,18,51,151,172,163,41,10,84,60,59,230,156,54,81,120,9,143,22,38,156,210,249,157,194,53,113,193,76,24,84,5,9,29,194,44,221,9,66,61,199,90,106,78,217,141,79,142,227,24,198,218,86,21,83,77,178,139,143,201,160,108,137,128,194,112,211,128,58,84,2,223,83,71,123,138,248,132,163,182,43,170,63,38,181,218,19,225,169,132,27,114,135,158,7,209,47,104,54,50,215,67,120,243,36,225,176,43,210,3,115,52,86,9,13,37,215,6,100,1,121,91,181,118,210,206,181,5,164,102,138,85,32,104,147,143,125,171,81,209,254,68,216,64,63,89,82,12,217,1,128,66,42,26,253,195,162,54,209,56,246,149,63,19,101,44,219,160,223,67,63,153,135,2,240,24,104,7,158,23,171,48,65,242,220,153,192,117,245,35,64,110,36,149,237,243,92,225,236,73,216,10,21,91,149,56,110,187,154,190,191,38,48,69,211,70,245,96,217,154,15,218,227,62,56,78,98,157,28,180,7,201,254,245,126,244,7,251,221,101,164,59,210,113,31,86,13,88,158,255,195,14,174,174,128,231,100,189,107,79,173,47,218,221,185,222,29,131,211,174,169,206,211,95,76,132,41,205,74,61,175,26,182,96,159,212,241,143,134,208,226,251,201,197,9,218,138,87,82,150,176,172,115,210,60,56,87,79,76,123,89,119,40,242,240,153,249,120,27,254,22,45,112,251,13,193,163,249,52,222,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("724d927b-4ab0-492e-878f-0d68376bae8a"));
		}

		#endregion

	}

	#endregion

}

