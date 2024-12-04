namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailLimitValidatorSchema

	/// <exclude/>
	public class IEmailLimitValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailLimitValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailLimitValidatorSchema(IEmailLimitValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45824530-29b2-4569-b8ff-91a6519d7e62");
			Name = "IEmailLimitValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,81,75,195,48,16,126,222,96,255,225,232,94,20,164,125,215,217,151,33,82,80,144,77,125,143,237,181,59,104,146,122,73,38,67,246,223,189,172,237,112,78,133,16,200,229,238,187,239,251,238,140,210,232,58,85,34,60,35,179,114,182,246,233,210,154,154,154,192,202,147,53,179,233,231,108,58,9,142,76,3,235,157,243,168,111,102,83,137,204,25,27,249,134,194,120,228,90,0,174,161,184,211,138,218,7,210,228,95,85,75,149,242,150,37,83,78,150,101,176,112,65,107,197,187,124,120,63,177,221,82,133,14,52,250,141,173,28,120,11,219,190,12,1,35,18,124,144,223,128,67,83,197,230,109,196,117,233,136,150,125,131,235,194,91,75,37,208,72,229,47,38,162,68,238,51,54,135,192,144,39,124,162,212,118,160,16,219,157,247,235,35,157,98,165,193,136,129,183,137,152,232,84,131,69,149,228,47,134,222,3,130,72,51,158,106,66,6,91,131,223,32,12,57,233,34,59,84,254,14,196,88,82,71,82,234,150,54,24,159,228,171,99,0,202,24,57,177,169,182,252,211,159,51,116,70,31,216,184,124,16,24,103,198,232,66,235,83,153,157,243,202,136,95,194,112,225,16,161,100,172,111,147,147,249,175,145,183,84,226,74,182,196,26,135,73,150,75,139,17,51,54,249,47,251,232,234,99,175,253,226,62,80,53,26,81,84,87,113,100,194,230,68,242,165,236,215,100,127,152,20,204,69,91,191,103,241,189,255,2,123,185,183,105,173,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45824530-29b2-4569-b8ff-91a6519d7e62"));
		}

		#endregion

	}

	#endregion

}

