namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesRuleCheckerSchema

	/// <exclude/>
	public class IDuplicatesRuleCheckerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesRuleCheckerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesRuleCheckerSchema(IDuplicatesRuleCheckerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53ff3e32-a9b5-4c01-b749-bb3b0594295a");
			Name = "IDuplicatesRuleChecker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,83,205,106,194,64,16,62,43,248,14,131,94,90,40,201,93,109,160,104,17,15,45,210,250,2,107,50,49,67,147,108,152,217,213,74,233,187,119,55,81,35,85,161,20,188,132,204,236,204,247,151,108,169,10,148,74,197,8,75,100,86,162,83,19,76,116,153,210,218,178,50,164,203,96,138,137,173,114,138,235,170,215,253,234,117,59,86,168,92,195,251,78,12,22,163,94,215,117,6,140,107,119,12,243,210,32,167,14,110,8,243,233,126,13,229,205,230,56,201,48,254,64,174,167,195,48,132,177,216,162,80,188,139,246,245,130,245,134,18,20,80,32,104,64,167,80,160,201,116,34,96,52,196,126,25,76,134,160,54,138,114,181,162,156,204,206,15,37,167,234,128,29,145,4,7,134,240,132,162,178,43,55,5,116,208,119,85,94,199,25,116,207,163,163,151,70,197,16,22,53,66,115,248,219,64,221,168,33,228,162,74,117,65,39,172,118,222,107,133,49,165,132,9,80,226,133,159,43,111,58,149,98,85,64,233,190,214,99,159,146,126,180,116,44,243,233,49,155,96,28,214,19,237,2,163,177,92,74,180,100,139,64,87,36,108,201,100,123,108,198,180,133,15,35,192,79,18,35,15,160,157,31,222,146,32,164,42,23,116,68,7,100,79,181,210,58,135,25,154,185,76,91,108,159,231,179,95,191,155,89,242,198,238,71,183,139,77,80,113,156,129,184,24,10,85,59,248,107,140,205,202,171,123,111,226,60,71,186,73,188,39,180,255,136,249,41,54,180,193,139,97,139,97,127,45,91,252,67,236,3,44,147,230,111,174,235,239,230,198,158,52,93,231,7,37,174,89,233,8,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53ff3e32-a9b5-4c01-b749-bb3b0594295a"));
		}

		#endregion

	}

	#endregion

}

