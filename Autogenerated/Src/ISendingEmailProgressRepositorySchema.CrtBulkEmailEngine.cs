namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISendingEmailProgressRepositorySchema

	/// <exclude/>
	public class ISendingEmailProgressRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISendingEmailProgressRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISendingEmailProgressRepositorySchema(ISendingEmailProgressRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae");
			Name = "ISendingEmailProgressRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,193,106,195,48,12,134,207,13,228,29,12,189,108,48,154,251,54,118,41,101,228,48,8,105,95,192,179,149,84,16,91,65,86,10,97,236,221,39,39,43,108,12,58,48,6,89,250,63,253,146,163,13,144,70,235,192,156,128,217,38,234,100,183,167,216,97,63,177,21,164,88,22,31,101,177,153,18,198,222,28,231,36,16,158,202,66,95,170,170,50,207,105,10,193,242,252,242,29,183,48,50,36,136,146,140,156,193,28,33,122,149,29,130,197,161,97,234,53,151,180,132,18,10,241,108,28,69,97,235,100,119,165,85,63,112,227,244,62,160,51,24,5,184,203,246,234,219,52,149,168,79,189,55,91,134,94,125,155,55,144,51,249,244,104,154,5,181,38,47,132,222,212,209,49,4,181,217,48,140,150,193,183,224,112,196,236,251,238,117,210,2,200,61,106,255,144,219,27,29,105,41,58,81,118,176,167,41,202,253,186,130,63,52,114,234,233,31,156,174,39,143,113,131,163,114,192,11,248,58,162,160,29,90,253,31,138,9,126,195,174,210,173,226,214,129,151,248,179,44,244,124,1,254,215,147,53,213,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae"));
		}

		#endregion

	}

	#endregion

}

