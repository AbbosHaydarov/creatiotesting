﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountAnniversaryRemindingSchema

	/// <exclude/>
	public class AccountAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountAnniversaryRemindingSchema(AccountAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9ea5704-c35b-4cf3-994e-53f638b244ee");
			Name = "AccountAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e07b3414-0244-4600-8fa5-7c3b4f179d09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,85,201,110,219,48,16,61,59,64,254,97,160,94,100,192,144,239,137,35,32,91,3,183,72,179,56,237,157,17,199,54,1,137,84,72,42,129,80,244,223,59,34,41,91,142,45,181,57,20,5,108,1,28,190,89,222,27,114,40,89,129,166,100,25,194,19,106,205,140,90,218,228,82,201,165,88,85,154,89,161,228,241,209,207,227,163,81,101,132,92,193,162,54,22,139,211,119,107,194,231,57,102,13,216,36,55,40,81,139,108,139,233,134,45,10,37,15,239,104,236,179,39,87,23,205,22,253,62,105,92,81,14,184,204,153,49,39,112,158,101,170,146,246,92,74,241,138,218,48,93,63,98,33,36,167,16,199,71,4,47,171,231,92,100,144,53,232,33,48,156,192,5,51,120,56,206,168,33,191,201,252,89,96,206,41,245,189,11,237,178,180,105,140,37,181,50,208,200,184,146,121,77,107,221,196,14,121,239,202,70,29,56,131,40,24,162,211,63,251,82,27,44,203,58,190,193,208,248,186,170,80,114,95,88,88,183,250,80,31,172,174,50,171,244,110,169,211,233,20,102,166,42,10,226,152,182,134,14,58,217,128,74,166,89,1,146,206,198,89,84,25,212,4,146,190,195,81,250,125,103,13,130,220,153,204,48,153,77,157,215,38,240,108,218,77,21,168,14,244,33,126,23,120,55,239,248,4,158,169,75,241,59,43,184,254,140,22,217,26,11,246,141,234,221,211,120,180,80,149,206,112,206,105,103,147,203,145,54,73,0,122,115,139,115,94,191,254,139,98,221,32,130,71,233,101,165,53,74,75,39,35,83,154,195,156,255,99,145,39,112,83,9,14,130,147,218,118,45,76,143,218,143,174,28,167,168,216,145,171,239,68,222,162,93,43,119,113,180,178,20,11,249,128,188,143,104,43,45,13,24,108,134,10,188,9,187,6,150,231,176,20,185,37,54,176,84,26,178,32,12,253,133,173,15,119,193,251,71,233,194,199,105,220,86,104,109,115,179,216,86,25,210,54,72,51,220,142,151,10,117,77,229,151,168,109,29,165,15,205,18,202,176,222,169,201,231,253,64,180,228,43,82,196,78,183,2,45,48,238,84,59,151,15,68,251,193,242,10,163,244,105,141,219,250,56,146,116,196,19,13,216,186,68,80,75,234,47,146,153,26,233,166,252,126,185,218,183,33,189,85,92,44,5,242,143,244,99,54,109,189,123,206,105,123,12,64,17,101,45,56,66,232,210,149,175,8,253,50,14,86,159,122,2,36,148,99,119,207,132,158,249,41,57,9,211,50,133,29,21,218,163,42,150,16,239,137,157,92,191,84,44,55,241,102,160,142,91,248,40,52,239,139,18,50,110,62,79,164,86,50,167,11,160,39,219,249,59,246,216,81,114,39,227,205,176,161,253,123,45,26,138,1,54,231,209,56,153,27,151,107,155,138,96,205,134,31,77,116,109,232,235,181,10,36,187,215,233,128,76,175,138,238,231,92,10,251,208,33,37,208,196,45,131,102,72,38,7,1,62,229,57,231,221,157,186,75,192,43,153,92,23,37,9,216,7,223,18,217,135,247,215,125,37,220,4,33,117,54,125,27,106,102,10,55,232,25,248,215,207,108,253,55,76,95,153,6,181,221,165,97,228,94,136,100,192,211,115,234,56,37,196,47,222,121,163,39,32,241,109,176,182,94,197,122,194,239,60,227,127,19,190,71,225,16,62,156,150,78,150,129,9,236,173,93,35,89,126,3,130,219,201,11,243,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9ea5704-c35b-4cf3-994e-53f638b244ee"));
		}

		#endregion

	}

	#endregion

}

