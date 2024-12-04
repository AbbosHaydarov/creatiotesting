namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapExceptionSchema

	/// <exclude/>
	public class ImapExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapExceptionSchema(ImapExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("136f52d1-b451-48cb-a9cb-2a36268a593c");
			Name = "ImapException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,143,65,10,194,48,16,69,215,41,244,14,3,221,40,20,15,80,151,226,194,133,32,232,5,166,113,44,129,54,9,153,20,20,233,221,77,90,181,70,92,184,9,204,159,199,203,31,141,29,177,69,73,112,34,231,144,205,197,175,246,168,218,60,187,231,153,232,89,233,6,142,55,246,212,173,243,44,36,133,163,70,25,13,155,22,153,43,216,117,104,183,87,73,214,135,112,4,108,95,183,74,130,140,251,116,13,21,124,160,34,248,195,59,11,141,102,239,122,233,141,11,222,195,104,153,136,167,49,113,45,2,27,171,133,242,140,13,45,35,39,42,168,145,105,241,202,32,94,32,134,191,37,229,92,15,148,214,228,222,227,47,125,249,205,36,223,21,164,207,211,97,227,60,165,105,56,60,0,178,173,235,221,123,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("136f52d1-b451-48cb-a9cb-2a36268a593c"));
		}

		#endregion

	}

	#endregion

}

