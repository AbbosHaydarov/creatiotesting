namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorUtilityForCompatibilitySchema

	/// <exclude/>
	public class TermCalculatorUtilityForCompatibilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorUtilityForCompatibilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorUtilityForCompatibilitySchema(TermCalculatorUtilityForCompatibilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57fd03a1-ad28-4096-a432-d78f591c225b");
			Name = "TermCalculatorUtilityForCompatibility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ccef5f7c-bb3c-488e-aeef-d23f70e5d985");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,65,107,2,49,16,133,207,10,254,135,57,90,40,61,244,168,180,151,165,148,189,21,172,222,199,100,148,64,54,89,102,146,130,136,255,221,89,215,117,179,246,18,222,188,157,247,229,109,2,54,36,45,26,130,95,98,70,137,135,244,86,197,112,112,199,204,152,92,12,139,249,121,49,159,101,113,225,8,155,147,36,106,214,143,185,140,48,169,175,95,218,188,247,206,128,241,40,210,45,52,21,122,147,61,166,200,171,167,121,247,174,251,74,215,115,136,77,23,150,91,33,214,54,129,76,87,5,242,100,124,133,239,236,44,168,247,231,12,213,218,172,182,119,175,101,23,217,165,83,109,95,58,248,108,5,123,20,90,62,231,133,38,209,34,5,103,184,116,201,91,53,142,73,19,100,97,51,94,53,209,31,159,229,248,21,146,66,0,165,52,251,199,41,88,149,22,250,185,95,8,15,161,164,65,143,152,114,117,13,255,65,158,130,69,30,133,66,6,93,66,122,167,47,162,63,119,185,2,5,121,159,178,251,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57fd03a1-ad28-4096-a432-d78f591c225b"));
		}

		#endregion

	}

	#endregion

}

