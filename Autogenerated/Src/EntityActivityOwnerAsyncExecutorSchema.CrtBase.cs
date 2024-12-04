namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityActivityOwnerAsyncExecutorSchema

	/// <exclude/>
	public class EntityActivityOwnerAsyncExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityActivityOwnerAsyncExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityActivityOwnerAsyncExecutorSchema(EntityActivityOwnerAsyncExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ac041bc6-71d1-475e-a18c-3ab49a0d8e36");
			Name = "EntityActivityOwnerAsyncExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,203,106,219,64,20,93,59,144,127,184,164,27,9,130,180,79,28,131,49,38,120,209,184,144,180,251,201,232,74,26,42,205,152,121,216,21,197,255,222,153,59,242,99,146,106,81,232,198,230,62,206,57,247,53,146,172,71,179,99,28,225,13,181,102,70,213,182,88,41,89,139,198,105,102,133,146,183,55,191,111,111,102,206,8,217,192,235,96,44,246,143,103,251,26,210,247,74,254,61,162,113,202,95,172,165,21,86,160,41,150,102,144,124,187,195,168,105,254,25,80,108,164,69,93,251,62,2,214,163,191,104,108,124,0,86,29,51,230,1,8,55,44,185,21,251,240,79,224,131,68,77,185,101,89,194,220,184,190,103,122,88,140,54,225,224,32,120,11,248,11,185,179,104,64,157,228,160,86,26,120,203,100,19,74,84,129,8,84,13,72,34,192,162,74,168,18,78,236,229,21,253,206,189,119,130,3,39,133,180,48,170,137,170,91,147,168,151,121,128,77,204,89,239,61,127,218,182,39,243,203,241,191,231,118,191,162,109,85,229,27,254,70,34,49,248,177,191,209,129,8,92,99,253,116,55,45,80,196,50,240,174,188,224,52,122,158,159,102,177,254,60,150,247,1,172,102,210,212,168,195,96,46,131,184,154,78,156,150,85,96,91,4,137,135,196,95,204,203,19,253,89,239,122,116,167,217,237,149,168,96,44,32,251,110,80,251,147,149,200,169,8,151,152,247,48,217,220,82,55,6,152,110,92,239,67,38,135,112,231,179,217,158,249,93,38,41,79,144,69,14,218,206,4,81,126,38,122,188,208,80,62,65,55,178,86,158,40,244,155,108,220,207,134,88,41,30,11,152,141,136,202,231,39,133,20,167,192,125,204,123,193,67,196,78,101,174,84,231,122,249,131,117,206,159,226,51,218,183,97,135,21,153,243,103,39,170,69,150,130,136,44,98,94,252,87,33,31,101,182,93,53,37,179,237,170,255,169,20,185,94,121,235,79,32,248,39,218,186,36,16,236,24,7,62,57,218,44,61,136,188,88,133,135,139,217,135,237,228,68,115,28,159,19,202,42,190,40,178,163,55,117,30,255,0,12,107,93,108,58,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac041bc6-71d1-475e-a18c-3ab49a0d8e36"));
		}

		#endregion

	}

	#endregion

}

