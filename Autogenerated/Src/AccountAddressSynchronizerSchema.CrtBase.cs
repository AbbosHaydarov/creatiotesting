namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountAddressSynchronizerSchema

	/// <exclude/>
	public class AccountAddressSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountAddressSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountAddressSynchronizerSchema(AccountAddressSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("74191a0d-e4ee-4056-8a11-3e962a99a246");
			Name = "AccountAddressSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,83,193,110,219,48,12,61,187,64,254,129,72,47,14,16,56,247,172,43,208,101,65,176,67,139,0,222,62,64,149,153,68,128,45,121,148,148,34,27,242,239,163,108,57,113,50,55,219,14,59,138,124,124,124,143,164,180,168,208,214,66,34,124,69,34,97,205,198,101,11,163,55,106,235,73,56,101,244,232,238,231,232,46,241,86,233,45,44,181,83,238,144,31,180,220,145,209,234,71,3,248,112,74,231,7,235,176,226,242,178,68,25,82,54,91,161,70,82,242,140,233,119,33,124,47,158,53,157,20,90,6,48,228,158,112,203,116,176,40,133,181,115,120,146,210,120,237,158,138,130,208,218,179,28,164,6,61,155,205,224,193,250,170,18,116,120,140,239,53,153,189,42,208,66,133,110,103,10,11,27,67,96,79,149,65,129,104,89,65,180,180,240,166,220,174,11,102,29,237,172,199,91,251,215,82,73,144,65,212,13,77,48,135,79,194,226,160,218,36,204,246,108,143,39,230,200,75,67,108,114,221,176,55,134,186,78,239,247,72,191,89,36,46,215,237,220,193,95,60,167,113,113,157,181,246,53,129,121,224,78,94,89,92,122,93,112,129,156,194,56,182,30,79,160,81,124,108,117,221,163,46,90,237,241,29,141,60,183,67,102,19,100,28,83,98,17,125,116,79,48,123,222,55,47,4,190,156,175,229,225,234,176,56,227,43,253,44,234,154,215,243,8,43,116,183,0,54,141,218,146,65,212,194,84,181,224,139,14,107,119,196,248,229,119,47,202,94,244,35,92,69,226,201,16,223,176,203,135,74,210,73,56,223,36,217,11,130,48,196,75,57,76,24,130,217,159,101,183,44,191,51,100,188,232,84,227,27,220,170,143,158,147,220,120,146,145,224,133,255,52,183,31,175,214,249,203,120,218,230,63,163,117,74,247,234,135,64,23,227,24,28,211,40,224,142,255,85,242,242,111,36,159,64,255,40,153,208,121,210,3,235,106,210,3,103,29,99,253,208,241,23,42,40,98,108,52,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("74191a0d-e4ee-4056-8a11-3e962a99a246"));
		}

		#endregion

	}

	#endregion

}

