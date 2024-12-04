namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateSchema

	/// <exclude/>
	public class EmailStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateSchema(EmailStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3683c63-c39e-be9c-9916-00ffa0f49f4f");
			Name = "EmailState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,203,10,194,48,16,69,215,45,244,31,6,220,138,245,181,18,43,72,237,7,136,254,192,88,167,26,72,210,146,135,40,226,191,155,166,86,20,181,46,239,228,112,238,132,145,40,72,87,152,19,108,73,41,212,101,97,6,105,41,11,118,176,10,13,43,101,20,94,163,48,10,131,158,162,131,139,144,73,43,102,144,9,100,124,99,208,144,127,140,227,24,230,218,10,129,234,178,120,100,143,128,174,25,61,104,153,248,5,170,236,142,179,28,200,9,223,124,129,43,12,62,148,126,176,162,2,45,55,141,181,150,126,90,131,181,37,75,123,72,96,216,247,187,125,55,45,85,126,100,39,228,64,117,243,15,213,19,74,96,212,37,75,75,81,113,50,174,213,255,227,187,172,133,156,108,220,37,203,206,21,83,221,170,22,73,96,210,185,22,202,156,248,159,173,90,38,129,169,203,183,230,214,36,247,205,185,235,232,102,119,125,87,127,41,38,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3683c63-c39e-be9c-9916-00ffa0f49f4f"));
		}

		#endregion

	}

	#endregion

}

