namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendingTypeSchema

	/// <exclude/>
	public class SendingTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendingTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendingTypeSchema(SendingTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4472626f-9052-4c84-abc4-841d06155fc2");
			Name = "SendingType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,85,142,203,10,194,48,16,69,215,9,228,31,2,110,165,217,139,184,80,186,117,99,127,32,214,105,8,38,147,48,73,22,69,250,239,166,15,161,238,230,204,28,238,92,212,30,82,212,61,200,14,136,116,10,67,110,110,1,7,107,10,233,108,3,10,254,17,92,112,118,32,48,21,101,139,197,159,228,3,240,101,209,116,99,132,229,170,148,146,231,84,188,215,52,94,54,222,28,153,171,212,252,28,181,147,98,121,58,219,75,168,137,255,129,172,190,100,236,30,16,142,243,112,45,238,221,122,109,221,66,29,89,99,128,118,11,72,121,161,10,211,218,181,134,173,117,103,156,4,255,2,249,56,45,97,230,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4472626f-9052-4c84-abc4-841d06155fc2"));
		}

		#endregion

	}

	#endregion

}

