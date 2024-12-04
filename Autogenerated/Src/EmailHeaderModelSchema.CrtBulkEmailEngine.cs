namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailHeaderModelSchema

	/// <exclude/>
	public class EmailHeaderModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailHeaderModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailHeaderModelSchema(EmailHeaderModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d6eaf3b-23d3-462e-bed5-b0973014733e");
			Name = "EmailHeaderModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,146,193,78,195,48,12,134,207,171,212,119,176,180,251,122,167,136,203,64,112,97,171,96,47,144,118,110,151,145,38,149,157,28,166,105,239,142,155,80,52,193,14,27,72,85,42,59,127,252,127,250,19,171,122,228,65,53,8,27,36,82,236,90,191,88,58,219,234,46,144,242,218,217,60,59,230,217,44,176,182,29,188,31,216,99,95,74,45,223,156,176,147,125,88,26,197,124,7,79,189,210,230,5,213,22,233,213,109,209,228,153,104,138,162,128,123,14,125,175,232,240,240,85,191,225,64,200,104,61,195,227,102,13,174,133,93,60,197,208,58,2,191,67,168,131,249,0,28,231,129,216,13,70,121,92,76,195,138,179,105,67,168,141,110,160,25,1,46,248,207,4,92,214,111,208,138,220,128,228,53,10,109,21,143,166,253,159,144,177,241,140,194,39,60,60,254,133,86,198,130,149,172,70,144,223,36,19,10,123,138,57,69,253,74,228,112,132,14,125,57,142,41,225,116,163,95,140,224,6,195,24,193,223,28,189,196,158,18,231,80,239,177,241,215,217,38,237,127,45,229,61,164,39,112,149,105,53,169,47,217,206,37,136,116,221,177,78,221,243,230,233,19,123,196,52,98,241,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d6eaf3b-23d3-462e-bed5-b0973014733e"));
		}

		#endregion

	}

	#endregion

}

