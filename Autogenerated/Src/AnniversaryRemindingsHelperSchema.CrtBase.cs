namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnniversaryRemindingsHelperSchema

	/// <exclude/>
	public class AnniversaryRemindingsHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnniversaryRemindingsHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnniversaryRemindingsHelperSchema(AnniversaryRemindingsHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3683174-bd15-44f4-9f35-a742936c5d37");
			Name = "AnniversaryRemindingsHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,209,74,195,64,16,69,159,83,232,63,12,121,74,49,108,62,192,26,208,42,88,31,20,218,254,192,54,157,182,43,201,36,206,238,42,69,252,119,39,155,218,166,16,11,217,108,184,51,231,50,119,55,164,43,180,141,46,16,86,200,172,109,189,117,106,86,211,214,236,60,107,103,106,26,143,190,199,163,200,91,67,187,139,22,70,245,248,112,59,30,73,177,241,235,210,20,96,157,0,5,20,165,182,22,238,137,204,39,178,213,124,88,96,101,104,35,188,125,198,178,65,22,162,181,140,218,149,101,25,76,173,175,42,233,203,255,132,5,58,207,100,193,98,137,133,131,47,227,246,240,94,27,130,70,179,140,235,196,86,157,224,160,1,137,126,23,119,64,156,47,195,174,166,89,40,230,195,189,197,30,43,253,42,223,113,62,243,204,72,14,58,45,52,92,135,245,57,221,178,231,211,11,125,221,43,235,71,190,60,190,101,23,250,69,242,174,244,186,196,228,40,116,217,82,105,227,246,42,206,227,159,164,193,161,38,16,206,58,234,112,213,218,38,193,251,208,160,154,19,33,167,255,128,1,139,212,27,37,131,245,20,226,249,38,158,168,185,125,250,240,186,76,250,3,13,2,112,211,17,242,207,136,47,135,59,62,166,10,210,143,188,100,201,243,11,186,237,108,212,148,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3683174-bd15-44f4-9f35-a742936c5d37"));
		}

		#endregion

	}

	#endregion

}

