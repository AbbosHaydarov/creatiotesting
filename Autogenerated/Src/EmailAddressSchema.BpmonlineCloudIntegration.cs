﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailAddressSchema

	/// <exclude/>
	public class EmailAddressSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailAddressSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailAddressSchema(EmailAddressSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f82b21b-805d-4119-96db-e57d6168ef63");
			Name = "EmailAddress";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,86,81,107,219,48,16,126,78,161,255,225,112,95,82,8,14,99,15,133,165,233,24,93,40,125,232,86,218,236,169,148,160,216,231,84,96,75,158,116,238,150,117,253,239,59,201,169,107,59,201,154,100,131,109,236,197,70,119,247,157,190,251,238,44,89,137,12,109,46,34,132,49,26,35,172,78,40,60,213,42,145,179,194,8,146,90,133,167,163,235,11,29,99,106,247,247,30,246,247,58,133,149,106,6,215,115,75,152,13,90,235,240,170,80,36,51,12,175,209,72,145,202,111,62,3,71,113,220,129,193,25,47,224,52,21,214,190,129,81,38,100,250,46,142,13,90,235,253,253,126,31,142,109,145,101,194,204,79,22,235,241,29,2,186,64,16,101,100,248,20,216,175,69,222,188,23,36,152,51,25,17,209,45,27,242,98,154,202,8,34,183,83,107,163,14,151,192,207,103,54,90,89,50,69,68,218,48,169,75,15,44,35,218,124,188,225,92,73,242,133,161,5,1,10,191,128,100,188,80,44,159,78,128,152,238,177,69,132,200,96,50,12,234,59,7,208,63,41,9,185,18,150,107,120,226,92,199,116,15,225,1,30,255,8,27,111,201,133,17,25,40,30,144,97,224,187,16,84,190,170,49,53,188,15,95,91,11,171,236,230,196,131,184,46,23,214,161,59,105,195,178,191,195,210,227,6,170,211,113,91,178,165,132,132,163,44,167,185,119,252,37,90,200,248,89,136,243,216,165,55,24,201,92,162,162,149,114,252,126,49,207,10,25,131,140,123,176,86,85,246,15,57,98,240,47,235,188,149,76,75,104,247,108,130,157,101,167,121,173,116,118,25,94,26,94,111,95,40,235,94,255,165,162,75,88,154,231,45,172,179,252,122,55,170,133,75,183,83,107,74,171,131,179,213,189,234,13,59,64,21,151,55,69,243,218,184,52,58,71,67,18,55,185,52,206,144,44,104,3,214,189,229,218,3,163,14,243,87,218,5,102,83,52,221,15,37,97,119,236,28,222,214,4,90,28,2,124,71,204,144,6,46,251,224,167,183,69,131,6,173,104,253,75,4,202,233,105,112,168,247,101,119,34,173,49,122,137,135,159,195,85,52,124,107,55,101,225,102,240,14,69,140,198,119,29,72,67,97,17,18,38,230,56,85,29,234,65,140,137,40,82,199,85,67,64,58,0,153,128,210,4,185,209,247,50,198,248,41,163,86,168,147,46,233,30,68,81,15,166,81,116,184,121,77,254,251,88,85,147,231,182,123,139,191,230,178,252,141,131,88,80,117,160,240,47,159,21,179,109,52,127,78,52,113,137,22,84,111,62,78,173,78,145,176,27,28,133,175,142,194,215,240,29,62,177,136,252,217,142,49,203,83,142,188,194,207,5,90,10,71,85,2,206,142,254,136,99,241,195,102,205,206,53,230,255,199,183,208,218,111,99,5,174,48,231,68,130,191,139,45,138,51,37,104,178,242,11,51,149,115,247,54,84,195,196,202,155,25,194,189,48,219,208,139,114,154,120,224,132,129,77,138,77,95,123,185,130,112,235,68,43,173,77,35,219,126,0,8,204,8,191,22,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f82b21b-805d-4119-96db-e57d6168ef63"));
		}

		#endregion

	}

	#endregion

}

