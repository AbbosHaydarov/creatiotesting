namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SSPSysAdminUnitEntityEventListenerSchema

	/// <exclude/>
	public class SSPSysAdminUnitEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SSPSysAdminUnitEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SSPSysAdminUnitEntityEventListenerSchema(SSPSysAdminUnitEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("97f62c83-391e-4913-874c-0be2b5b5de4c");
			Name = "SSPSysAdminUnitEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,85,75,79,227,48,16,62,23,137,255,48,27,46,169,84,185,119,150,34,65,161,43,36,88,208,6,216,3,66,43,55,153,182,94,28,187,178,157,66,129,254,119,252,10,155,62,120,172,246,176,61,164,114,230,245,205,124,95,198,130,150,168,167,52,71,184,68,165,168,150,35,67,250,82,140,216,184,82,212,48,41,72,150,93,108,111,61,109,111,181,42,205,196,24,178,185,54,88,126,125,61,55,195,202,82,138,205,22,133,228,88,24,102,24,234,15,29,200,241,12,133,113,126,214,179,219,237,194,158,174,202,146,170,249,126,60,123,199,57,160,115,3,206,44,30,129,10,140,132,169,10,239,10,228,104,92,5,169,160,148,5,27,205,221,65,123,228,128,15,6,149,160,28,42,141,138,212,37,186,141,26,55,161,128,135,113,26,211,167,89,62,193,146,126,183,227,130,30,36,118,10,7,69,201,196,149,96,38,105,223,126,46,232,250,126,61,108,90,13,57,203,33,231,84,107,176,163,110,122,108,200,8,187,112,72,53,110,176,216,92,150,36,251,108,237,40,28,91,226,96,192,144,23,122,215,78,133,205,168,193,96,140,7,208,70,185,153,252,178,67,185,144,202,80,110,73,23,152,59,198,175,236,92,26,125,174,154,147,64,76,107,7,69,17,42,45,151,61,67,51,145,111,214,29,74,201,225,68,103,155,203,166,53,181,254,175,13,78,118,173,22,27,65,250,37,188,34,39,186,47,121,85,138,107,202,43,60,149,180,192,34,77,28,218,164,93,187,183,102,84,1,183,38,239,163,99,202,94,76,74,2,39,164,175,208,226,9,198,52,154,28,132,63,128,218,78,169,246,183,154,138,12,208,228,147,129,146,229,209,97,154,156,20,73,167,78,125,161,152,211,80,3,97,7,4,222,223,220,194,19,4,199,0,21,22,117,238,26,19,154,70,80,108,168,179,214,4,249,182,201,175,29,147,45,252,83,161,169,148,168,17,217,128,203,249,20,139,70,212,94,160,126,191,142,134,94,239,125,25,60,63,195,18,216,58,231,57,255,151,180,30,243,98,89,28,51,201,10,232,79,48,191,251,64,31,238,211,109,170,227,109,65,121,207,101,101,228,143,103,168,53,29,227,37,150,83,238,234,246,28,75,112,42,115,202,217,35,29,114,204,124,47,62,120,69,20,228,167,84,119,126,97,146,31,168,101,165,114,235,44,149,205,214,9,37,90,201,199,95,177,19,194,90,53,77,222,232,161,63,161,98,140,199,15,57,78,61,2,63,238,164,86,208,114,75,182,149,192,3,25,72,85,82,147,174,119,219,121,151,150,58,173,153,40,121,239,199,242,90,184,145,171,169,184,197,103,215,129,223,116,193,232,87,46,19,19,84,204,20,50,239,186,173,91,175,66,57,179,215,2,43,162,26,206,197,81,92,230,169,28,254,182,88,65,219,66,168,58,241,22,56,196,145,189,59,252,116,15,212,88,3,214,92,187,185,56,254,236,68,162,106,218,33,50,64,127,87,101,94,52,193,111,72,53,146,6,136,186,122,28,65,108,254,111,250,201,232,236,127,119,19,33,108,238,101,133,72,251,118,241,2,41,149,209,144,37,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSysPortalConnectionUserChangeExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSysPortalConnectionUserChangeExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa7b54fa-d468-e38c-65d2-008c79d90400"),
				Name = "SysPortalConnectionUserChangeException",
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("97f62c83-391e-4913-874c-0be2b5b5de4c"),
				ModifiedInSchemaUId = new Guid("97f62c83-391e-4913-874c-0be2b5b5de4c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("97f62c83-391e-4913-874c-0be2b5b5de4c"));
		}

		#endregion

	}

	#endregion

}

