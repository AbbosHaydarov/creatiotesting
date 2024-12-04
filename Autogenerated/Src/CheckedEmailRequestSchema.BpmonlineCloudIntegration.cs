namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailRequestSchema

	/// <exclude/>
	public class CheckedEmailRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailRequestSchema(CheckedEmailRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("942945d7-ac66-48ca-b114-0dbc0d994415");
			Name = "CheckedEmailRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,146,63,79,195,48,16,197,103,144,248,14,167,178,192,146,236,180,48,80,42,196,0,66,45,27,98,112,157,151,98,225,216,225,206,169,4,136,239,206,57,41,255,90,36,22,91,119,126,247,236,247,147,131,105,32,173,177,160,59,48,27,137,117,42,166,49,212,110,213,177,73,46,134,98,58,91,92,199,10,94,14,246,223,14,246,247,58,113,97,69,139,23,73,104,84,233,61,108,150,73,113,137,0,118,118,188,173,153,119,33,185,6,197,66,79,141,119,175,189,171,170,84,119,200,88,105,65,83,111,68,78,104,250,8,251,132,106,214,24,231,231,120,238,32,169,151,149,101,73,19,233,154,198,240,203,217,166,158,163,101,8,66,18,226,65,74,41,146,205,14,132,108,32,185,94,130,214,122,109,237,80,145,222,211,114,92,187,10,76,162,107,241,233,92,110,89,79,4,48,94,212,141,81,159,142,254,229,82,156,27,129,166,91,59,139,205,179,71,84,102,183,251,11,147,140,78,37,54,54,61,104,163,237,150,222,89,178,57,239,95,113,233,132,118,205,116,78,193,235,250,197,235,150,99,11,78,14,10,237,182,183,28,206,203,45,80,125,227,18,202,40,106,230,188,167,71,144,119,122,81,172,127,96,234,177,101,30,187,64,134,206,218,248,14,95,229,157,154,12,195,63,102,190,37,125,234,107,52,75,240,209,141,126,47,58,165,209,32,31,29,103,8,159,20,174,102,161,107,192,102,233,49,145,196,250,101,206,168,135,33,244,70,43,164,113,126,242,152,222,55,217,17,170,33,126,95,15,221,223,77,237,125,0,4,57,173,176,207,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("942945d7-ac66-48ca-b114-0dbc0d994415"));
		}

		#endregion

	}

	#endregion

}

