namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INonPersistentColumnProcessSchema

	/// <exclude/>
	public class INonPersistentColumnProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INonPersistentColumnProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INonPersistentColumnProcessSchema(INonPersistentColumnProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b9b0b8a-a0c7-4250-a378-016529bb5c12");
			Name = "INonPersistentColumnProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,107,195,48,12,134,207,9,228,63,136,246,210,65,73,238,91,86,24,221,6,61,108,132,49,118,119,99,37,53,36,114,240,71,75,25,253,239,75,236,164,75,195,90,118,179,44,61,175,245,74,38,86,163,110,88,142,240,137,74,49,45,11,19,175,37,21,162,180,138,25,33,41,126,21,21,110,234,70,42,19,133,223,81,24,52,118,91,137,28,4,25,84,69,7,110,222,37,101,168,180,208,6,201,172,101,101,107,202,148,204,81,235,182,188,67,130,185,194,178,213,130,55,52,59,201,245,61,100,78,36,10,187,100,146,36,144,106,91,215,76,29,87,195,197,19,231,26,20,59,192,158,85,22,193,236,152,129,131,168,42,216,34,52,94,28,121,124,198,147,41,159,54,76,177,26,168,181,247,56,19,174,253,23,50,194,28,103,43,111,6,208,133,113,154,184,202,191,193,220,153,57,35,62,252,15,242,213,117,61,225,188,149,219,52,71,109,4,185,193,79,233,81,42,30,107,236,165,224,221,184,22,190,220,187,132,177,229,37,248,148,95,77,175,119,121,233,250,237,51,238,188,236,164,131,113,201,243,239,251,227,94,238,30,110,108,241,195,146,190,112,175,135,229,9,42,175,108,207,249,233,255,207,98,80,159,35,113,255,135,92,124,138,194,211,15,16,158,160,29,186,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b9b0b8a-a0c7-4250-a378-016529bb5c12"));
		}

		#endregion

	}

	#endregion

}

