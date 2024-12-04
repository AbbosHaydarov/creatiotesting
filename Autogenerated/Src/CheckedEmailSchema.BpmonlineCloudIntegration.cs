namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailSchema

	/// <exclude/>
	public class CheckedEmailSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailSchema(CheckedEmailSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29627a54-240f-4b4f-a2e5-afc88eca3ba7");
			Name = "CheckedEmail";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,49,79,195,48,16,133,231,68,202,127,56,181,11,44,201,78,128,37,84,136,161,168,106,216,16,66,110,114,77,45,98,59,186,187,12,165,226,191,227,56,45,180,133,1,198,123,247,158,239,243,179,202,32,119,170,66,120,66,34,197,110,45,105,225,236,90,55,61,41,209,206,166,197,172,156,187,26,91,78,226,93,18,39,113,212,179,182,13,148,91,22,52,233,178,183,162,13,166,37,146,86,173,126,15,153,60,248,166,132,141,31,160,104,21,243,21,20,27,172,222,176,158,25,165,219,176,207,178,12,174,185,55,70,209,246,118,63,47,177,35,100,180,194,32,27,4,28,204,160,253,33,96,81,130,233,33,150,29,229,158,239,148,40,207,44,164,42,121,241,66,215,175,90,93,65,53,220,61,59,27,141,95,248,98,91,144,235,144,68,163,7,92,132,216,184,63,103,11,194,61,122,44,71,192,120,140,55,48,253,132,138,2,213,28,205,10,233,226,209,151,12,55,48,9,254,201,229,192,120,128,100,161,161,205,128,7,59,104,80,242,225,253,28,62,254,13,242,93,209,31,113,52,191,86,99,59,167,76,43,231,90,120,224,125,115,191,81,77,209,214,99,131,97,30,213,83,209,107,159,110,36,25,198,92,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29627a54-240f-4b4f-a2e5-afc88eca3ba7"));
		}

		#endregion

	}

	#endregion

}

