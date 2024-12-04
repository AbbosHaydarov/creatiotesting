namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SaveDuplicatedEntityExceptionSchema

	/// <exclude/>
	public class SaveDuplicatedEntityExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SaveDuplicatedEntityExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SaveDuplicatedEntityExceptionSchema(SaveDuplicatedEntityExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b");
			Name = "SaveDuplicatedEntityException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,203,110,194,48,16,60,131,196,63,172,232,133,94,146,59,165,92,40,135,30,42,85,130,31,88,156,77,176,74,236,200,187,105,154,34,254,189,107,19,74,31,18,23,75,30,237,204,206,204,58,172,137,27,52,4,91,10,1,217,151,146,173,188,43,109,213,6,20,235,93,246,130,225,141,196,186,106,133,117,131,182,114,147,241,113,50,30,181,172,16,108,122,22,170,31,38,99,69,238,2,85,74,128,213,1,153,231,176,193,119,122,106,155,131,53,40,84,172,157,88,233,215,31,134,154,168,154,8,121,158,195,130,219,186,198,208,47,135,255,247,4,200,62,248,142,161,219,147,131,226,162,3,148,116,64,66,31,215,139,7,235,152,130,100,23,185,252,135,94,211,238,148,5,38,250,185,109,7,230,215,197,74,212,124,250,94,3,121,199,18,90,35,62,104,174,215,164,122,158,248,155,32,1,207,206,138,197,131,253,36,6,4,71,93,244,40,232,180,99,95,106,44,26,90,203,174,235,77,178,216,89,217,43,131,27,50,182,180,84,128,94,196,7,208,3,49,86,20,35,254,207,120,70,26,12,88,131,211,91,62,78,135,241,233,114,171,155,134,143,110,69,129,130,216,4,187,83,91,209,68,18,207,22,121,226,38,169,161,175,155,77,205,180,137,216,252,32,124,31,121,163,209,28,118,200,52,187,128,112,132,211,80,33,185,226,220,98,250,159,209,223,224,233,11,236,160,101,60,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b"));
		}

		#endregion

	}

	#endregion

}

