namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleByUITypeQueryExecutorSchema

	/// <exclude/>
	public class SysModuleByUITypeQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleByUITypeQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleByUITypeQueryExecutorSchema(SysModuleByUITypeQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e88b6f57-1ea7-4702-9070-27b0be3cceac");
			Name = "SysModuleByUITypeQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,146,193,106,195,48,12,134,207,45,244,29,76,119,73,161,244,1,58,182,67,179,22,114,216,200,104,195,14,99,7,55,81,82,179,196,14,178,93,22,74,223,125,114,220,49,82,154,244,98,176,253,235,147,126,73,146,87,160,107,158,2,219,1,34,215,42,55,139,80,201,92,20,22,185,17,74,78,198,167,201,120,100,181,144,69,71,130,240,216,243,190,88,75,35,140,0,221,43,216,240,212,40,244,10,210,60,32,20,148,137,133,37,215,122,201,182,141,126,85,153,45,97,213,36,209,174,169,225,221,2,54,235,31,72,45,69,181,17,159,47,144,115,91,154,149,144,25,241,3,67,42,149,7,81,155,185,233,232,103,115,246,70,30,217,19,155,14,131,167,179,47,34,215,118,95,138,148,165,174,148,59,149,176,37,91,113,13,31,10,191,235,146,58,184,77,15,80,241,158,162,71,212,69,58,255,189,42,169,13,90,215,7,178,28,183,89,189,226,82,193,112,238,32,209,128,196,144,144,186,33,49,219,185,206,29,103,20,109,16,32,83,85,18,133,165,0,105,18,41,140,175,49,70,117,20,25,32,217,188,253,49,107,1,75,182,39,127,193,21,187,63,136,157,216,249,226,18,100,230,141,118,93,147,180,6,116,187,65,158,81,25,66,66,118,177,253,119,101,234,72,219,66,64,70,13,106,151,135,99,1,198,143,214,103,244,3,125,190,49,209,169,219,185,1,86,204,145,106,31,102,221,99,108,125,35,124,120,18,101,161,42,109,37,99,110,14,158,115,245,237,112,55,122,226,59,213,125,60,79,198,191,199,58,161,148,144,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e88b6f57-1ea7-4702-9070-27b0be3cceac"));
		}

		#endregion

	}

	#endregion

}

