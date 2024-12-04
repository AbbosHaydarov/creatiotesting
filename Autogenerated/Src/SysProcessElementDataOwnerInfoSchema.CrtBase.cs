namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessElementDataOwnerInfoSchema

	/// <exclude/>
	public class SysProcessElementDataOwnerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessElementDataOwnerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessElementDataOwnerInfoSchema(SysProcessElementDataOwnerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f11982c-9819-47d8-bc8d-e74e12e283ba");
			Name = "SysProcessElementDataOwnerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,145,207,106,195,48,12,198,207,9,228,29,4,189,55,247,181,236,210,149,145,203,90,104,95,192,139,229,204,16,203,193,114,8,161,244,221,231,63,237,40,219,88,199,118,17,182,36,127,223,79,50,9,131,60,136,22,225,136,206,9,182,202,47,55,150,148,238,70,39,188,182,84,149,167,170,44,70,214,212,193,97,102,143,102,85,149,33,179,112,216,133,50,108,122,193,252,16,75,123,103,91,100,222,246,104,144,252,147,240,98,55,17,186,134,148,77,47,234,186,134,53,143,198,8,55,63,94,238,7,111,29,50,232,208,227,76,242,3,194,168,18,122,192,91,104,223,4,117,8,54,10,129,85,48,100,15,192,108,2,50,184,44,175,218,245,141,248,48,190,246,186,133,54,210,221,133,43,194,136,33,126,204,20,154,7,116,94,99,24,108,159,132,114,253,243,4,41,209,200,32,168,149,206,128,241,236,231,136,244,149,233,10,245,60,106,9,219,212,216,72,56,65,135,126,5,28,195,249,142,143,210,254,226,99,123,249,237,50,242,170,126,225,191,235,101,222,192,95,9,8,167,255,17,188,224,244,3,193,2,73,230,239,72,247,156,189,77,22,85,121,126,7,170,181,65,161,190,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f11982c-9819-47d8-bc8d-e74e12e283ba"));
		}

		#endregion

	}

	#endregion

}

