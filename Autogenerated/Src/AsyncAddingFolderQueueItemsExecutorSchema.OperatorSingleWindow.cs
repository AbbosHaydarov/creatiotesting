namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncAddingFolderQueueItemsExecutorSchema

	/// <exclude/>
	public class AsyncAddingFolderQueueItemsExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncAddingFolderQueueItemsExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncAddingFolderQueueItemsExecutorSchema(AsyncAddingFolderQueueItemsExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3056242-aee3-4086-bba3-37eac3bd1a5c");
			Name = "AsyncAddingFolderQueueItemsExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a8569787-b88e-4075-aa85-f8031253bd51");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,77,111,218,64,16,61,59,82,254,195,200,61,212,72,200,220,91,64,66,41,137,168,218,52,109,74,47,85,15,203,122,128,141,236,93,119,63,72,172,42,255,189,179,187,216,128,67,164,92,44,207,215,155,247,102,103,36,171,208,212,140,35,252,68,173,153,81,107,155,95,41,185,22,27,167,153,21,74,94,94,252,187,188,72,156,17,114,3,247,141,177,88,125,236,217,148,95,150,200,125,178,201,111,80,162,22,252,144,115,12,91,85,74,158,143,104,124,205,159,95,51,110,149,22,104,40,131,114,222,105,220,80,39,184,42,153,49,240,1,102,166,145,124,86,20,84,121,173,202,2,245,119,135,14,23,196,203,204,159,144,59,170,13,117,163,209,8,198,198,85,21,211,205,116,111,255,192,90,163,65,105,13,48,96,30,104,171,149,84,142,204,0,8,127,61,22,8,15,6,107,165,193,160,23,138,5,108,180,114,181,129,7,181,202,91,236,209,17,120,237,86,165,224,192,3,199,55,48,36,29,139,207,106,213,153,52,114,66,233,180,126,69,187,85,133,87,123,23,128,99,180,175,40,56,34,4,122,102,160,214,111,212,225,53,188,20,17,61,53,211,172,2,73,107,50,73,157,65,77,203,33,227,99,167,211,37,217,192,59,71,62,30,133,236,243,197,225,31,45,106,147,78,239,186,255,147,154,253,216,118,66,91,199,74,216,41,81,180,130,178,229,73,111,56,165,50,132,197,39,17,254,136,251,216,88,77,162,135,160,86,15,20,158,194,161,243,192,79,54,73,18,177,134,236,224,133,201,4,164,43,203,54,154,88,90,131,71,144,248,8,51,189,113,21,45,200,45,133,191,233,121,85,219,102,254,196,177,246,173,178,35,73,192,153,124,111,97,133,1,40,29,248,109,78,146,231,240,141,116,128,80,132,109,238,249,22,43,118,75,101,48,57,34,70,119,99,127,177,210,97,150,246,243,210,33,68,132,60,180,223,67,127,17,198,142,91,129,235,176,86,11,218,144,179,152,227,227,228,105,150,118,233,4,29,116,71,200,27,71,227,14,155,178,40,94,35,183,15,83,161,207,62,97,180,99,122,79,100,105,69,41,44,93,44,161,132,51,141,39,220,120,156,113,88,126,19,15,161,75,156,102,52,236,223,127,218,249,251,201,211,227,146,108,231,11,219,71,200,250,11,56,236,173,193,32,78,125,79,168,71,38,167,19,60,92,94,214,13,97,248,226,101,134,237,20,34,16,189,98,56,70,148,69,188,199,96,71,239,169,243,249,63,107,146,180,49,78,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3056242-aee3-4086-bba3-37eac3bd1a5c"));
		}

		#endregion

	}

	#endregion

}

