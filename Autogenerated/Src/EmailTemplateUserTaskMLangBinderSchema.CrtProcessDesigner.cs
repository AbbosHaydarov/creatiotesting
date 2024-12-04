namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskMLangBinderSchema

	/// <exclude/>
	public class EmailTemplateUserTaskMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskMLangBinderSchema(EmailTemplateUserTaskMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b12cd08-0384-44fd-b87b-86ac638b898a");
			Name = "EmailTemplateUserTaskMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,145,65,107,194,64,16,133,207,17,252,15,131,189,88,40,201,221,138,80,197,130,160,180,80,75,207,147,100,76,151,102,119,195,238,172,84,138,255,189,147,77,44,90,114,73,216,157,55,223,204,123,107,80,147,111,176,32,216,147,115,232,237,129,211,149,53,7,85,5,135,172,172,25,143,126,198,163,36,120,101,170,27,137,163,244,25,11,182,78,145,127,28,80,124,80,46,42,173,173,145,170,212,239,28,85,130,131,85,141,222,207,96,173,81,213,239,158,220,30,253,215,110,139,166,90,42,83,146,139,218,44,203,96,238,131,214,232,78,139,254,28,27,128,73,55,53,50,65,144,86,96,233,5,29,106,86,181,0,2,86,4,69,139,135,60,178,210,11,42,187,98,53,33,175,85,209,235,34,116,223,51,7,182,153,193,83,211,172,143,100,120,171,60,147,33,183,68,79,66,145,76,228,251,103,106,71,252,105,75,177,245,26,233,93,177,159,100,143,146,137,42,9,142,86,149,240,98,132,248,198,232,120,122,65,75,220,76,223,12,69,247,191,135,54,240,36,201,101,82,122,37,191,148,219,176,147,36,198,216,61,192,41,109,151,157,111,218,181,219,12,54,76,242,116,214,61,12,219,251,47,91,76,39,131,186,73,55,233,220,59,37,83,118,102,227,185,187,189,189,60,255,2,51,32,109,228,76,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b12cd08-0384-44fd-b87b-86ac638b898a"));
		}

		#endregion

	}

	#endregion

}

