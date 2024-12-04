namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidateUserLicensesOnRoleChangesSchema

	/// <exclude/>
	public class ValidateUserLicensesOnRoleChangesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidateUserLicensesOnRoleChangesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidateUserLicensesOnRoleChangesSchema(ValidateUserLicensesOnRoleChangesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("44c6c31c-f2b7-42e8-ace6-4bc0039f060b");
			Name = "ValidateUserLicensesOnRoleChanges";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,193,138,2,49,12,134,207,14,204,59,4,189,172,151,121,0,23,79,227,10,130,203,194,162,123,143,157,88,11,53,29,146,246,180,248,238,166,163,158,61,180,165,127,255,255,75,19,198,43,233,136,142,224,64,34,168,233,156,187,62,241,57,248,34,152,67,226,182,249,111,155,89,209,192,30,122,161,170,117,91,59,138,208,33,121,31,77,255,108,27,179,44,132,188,249,161,143,168,186,130,63,140,97,192,76,71,37,217,7,71,172,164,63,252,155,34,245,23,100,79,58,133,198,114,138,193,129,171,153,247,17,88,193,179,244,55,101,52,43,26,162,126,239,197,121,75,248,88,194,228,159,237,244,139,241,20,105,128,53,100,41,100,61,152,186,33,117,18,198,218,183,233,243,23,14,138,241,192,10,76,64,176,71,49,36,184,7,115,62,101,111,182,217,170,131,32,30,30,179,168,215,219,29,238,168,183,76,98,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44c6c31c-f2b7-42e8-ace6-4bc0039f060b"));
		}

		#endregion

	}

	#endregion

}

