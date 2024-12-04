namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleInWorkplaceByUITypeQueryExecutorSchema

	/// <exclude/>
	public class SysModuleInWorkplaceByUITypeQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleInWorkplaceByUITypeQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleInWorkplaceByUITypeQueryExecutorSchema(SysModuleInWorkplaceByUITypeQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("14b6a526-3653-47da-8cbf-a2a9cf821c17");
			Name = "SysModuleInWorkplaceByUITypeQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,65,110,194,48,16,60,131,196,31,44,122,9,18,226,1,84,237,1,10,82,14,173,82,133,168,135,170,7,147,108,130,213,196,142,214,54,106,132,248,123,215,49,109,21,68,40,23,75,182,103,103,103,102,151,73,94,129,174,121,10,108,3,136,92,171,220,204,150,74,230,162,176,200,141,80,114,52,60,140,134,3,171,133,44,58,16,132,251,158,247,217,74,26,97,4,232,94,192,154,167,70,161,71,16,230,14,161,160,78,108,89,114,173,231,44,110,244,179,202,108,9,161,124,83,248,89,151,164,110,209,36,225,166,169,225,213,2,54,171,47,72,45,17,184,98,42,127,127,130,156,219,210,44,132,204,168,89,96,8,167,242,32,108,101,52,157,138,201,148,189,144,97,246,192,198,55,119,25,79,62,168,73,109,183,165,72,89,234,36,222,174,144,205,217,130,107,248,5,197,233,14,42,222,99,102,64,65,211,249,23,135,146,218,160,117,81,81,42,81,43,192,35,78,98,110,150,17,36,26,144,232,36,164,110,164,204,118,174,83,71,57,8,215,8,144,169,42,9,151,165,0,105,18,41,140,151,27,161,218,139,12,144,204,95,254,152,180,4,115,182,37,171,193,25,119,127,17,59,176,227,201,48,200,204,123,238,6,64,208,26,208,109,18,217,71,101,136,18,178,83,2,63,87,166,246,180,91,68,200,40,171,118,213,56,22,96,252,236,227,212,117,244,19,127,188,62,242,177,91,214,43,180,17,71,178,113,51,237,127,116,177,143,199,51,37,97,182,84,165,173,100,196,205,174,75,57,59,7,58,226,11,153,249,36,187,143,199,209,240,27,107,133,38,19,223,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14b6a526-3653-47da-8cbf-a2a9cf821c17"));
		}

		#endregion

	}

	#endregion

}

