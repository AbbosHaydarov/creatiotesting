﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoSchema

	/// <exclude/>
	public class AccountInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoSchema(AccountInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("664e29f1-8562-4e4b-9032-ee822c76c25c");
			Name = "AccountInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,87,75,111,219,48,12,62,183,64,255,131,144,94,54,96,104,238,75,81,32,200,134,45,27,90,4,104,183,29,138,30,20,155,78,132,58,146,39,201,9,130,98,255,125,212,35,137,223,177,61,239,146,216,226,67,223,71,74,36,205,233,6,84,66,3,32,79,32,37,85,34,210,55,51,193,35,182,74,37,213,76,240,155,217,231,199,123,17,66,172,174,46,223,174,46,47,82,197,248,138,60,192,78,11,110,181,191,41,193,39,87,151,40,186,150,176,66,11,50,139,169,82,31,201,52,8,68,202,245,156,71,194,138,199,227,49,185,85,233,102,67,229,254,206,191,91,85,18,9,73,24,170,201,141,221,146,208,165,72,53,161,206,158,40,77,117,170,8,229,33,97,90,17,5,114,203,2,80,55,7,151,227,140,207,36,93,198,44,32,129,117,155,3,112,129,224,241,247,8,114,33,69,2,82,51,64,164,11,107,229,228,69,148,118,225,11,224,198,8,82,153,127,189,6,50,93,204,201,43,236,13,134,50,8,183,178,165,113,10,199,215,167,74,163,147,206,179,9,163,199,180,127,55,154,38,236,59,236,71,239,95,140,204,147,82,90,154,208,59,17,121,35,43,208,19,131,104,66,254,116,129,206,49,227,68,68,246,217,135,184,27,141,102,7,245,148,156,234,3,90,87,243,58,201,251,147,219,193,146,172,133,120,37,52,73,208,183,59,78,161,216,80,198,187,145,108,231,168,150,236,47,88,126,69,235,105,146,124,178,54,149,140,139,74,253,105,83,188,186,123,147,147,236,229,104,79,182,194,170,150,217,163,215,205,51,242,171,207,47,135,39,213,159,140,196,130,132,181,5,252,197,111,79,101,36,94,71,132,69,232,224,119,10,10,11,71,26,4,0,225,132,8,116,43,119,12,93,142,176,200,9,57,106,195,211,110,94,153,55,39,26,128,96,128,117,181,91,166,10,22,181,232,103,168,151,199,206,176,146,154,213,1,96,99,199,80,116,213,17,121,217,168,22,252,189,83,173,140,189,151,245,103,129,113,128,149,107,109,157,15,216,211,57,251,90,74,243,147,85,213,193,154,243,188,212,180,44,82,178,169,34,125,13,60,116,29,205,190,187,213,194,98,161,47,87,109,214,170,65,135,182,14,98,18,124,71,198,122,147,137,198,249,126,92,189,241,112,141,153,18,27,255,44,210,221,26,204,221,63,206,18,107,234,213,88,72,104,138,34,174,15,197,189,83,59,191,13,238,180,76,225,118,28,220,153,138,163,215,76,181,220,35,83,141,62,24,55,17,141,149,245,211,234,24,169,159,198,237,20,189,150,198,131,165,16,49,201,43,244,187,37,13,97,172,229,57,72,223,61,31,212,243,187,13,17,222,230,230,157,141,115,155,14,222,227,134,250,30,218,107,106,246,189,220,64,48,169,115,115,243,169,80,53,223,208,227,198,195,78,203,217,137,209,227,235,63,114,150,29,156,155,85,106,71,206,140,252,255,92,21,198,49,242,28,179,97,79,178,102,219,246,188,47,170,110,195,33,185,71,119,255,120,220,167,214,73,229,249,118,162,254,125,182,120,14,187,78,164,37,171,134,44,59,221,226,68,234,207,255,241,161,55,149,20,185,244,228,81,103,90,75,230,7,26,84,19,202,74,242,47,67,21,29,231,174,69,213,73,36,132,16,49,14,225,233,35,61,195,241,92,141,57,236,51,108,145,1,44,192,49,66,19,91,22,98,208,77,201,232,150,171,58,211,218,92,45,188,65,101,109,57,8,7,202,78,54,225,45,50,84,58,119,205,57,201,123,31,54,47,59,223,172,21,73,101,220,239,35,188,104,218,244,217,109,245,235,62,183,157,179,126,25,193,44,253,5,33,64,168,218,45,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("664e29f1-8562-4e4b-9032-ee822c76c25c"));
		}

		#endregion

	}

	#endregion

}

