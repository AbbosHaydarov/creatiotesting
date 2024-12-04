namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SmtpExceptionSchema

	/// <exclude/>
	public class SmtpExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SmtpExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SmtpExceptionSchema(SmtpExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9b38078-c13e-40e2-9656-40242891b8a4");
			Name = "SmtpException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,81,205,106,195,48,12,62,39,144,119,16,244,210,65,232,3,36,236,48,182,30,11,133,236,5,92,79,11,134,196,54,146,50,86,70,223,125,182,147,172,75,40,99,140,29,12,214,39,233,251,65,86,245,200,94,105,132,103,36,82,236,94,101,119,80,166,43,242,143,34,207,6,54,182,133,230,204,130,125,93,228,1,217,16,182,198,89,120,236,20,115,5,77,47,126,255,174,209,75,0,211,128,31,78,157,209,160,99,127,217,134,10,30,188,15,77,21,171,43,28,133,178,248,102,238,35,57,143,36,6,131,192,113,136,27,137,121,166,102,161,232,106,223,7,155,13,218,151,70,148,12,60,210,100,45,74,157,62,158,204,155,18,4,158,128,203,200,177,9,11,163,204,84,207,121,156,13,188,131,22,71,183,85,23,81,182,147,7,92,122,40,225,54,254,132,172,201,164,205,187,100,174,130,147,98,220,254,48,54,197,89,135,188,95,83,215,223,178,253,175,211,18,174,39,50,214,34,125,149,191,204,80,174,215,254,146,105,117,175,17,93,130,151,79,178,113,135,152,196,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9b38078-c13e-40e2-9656-40242891b8a4"));
		}

		#endregion

	}

	#endregion

}

