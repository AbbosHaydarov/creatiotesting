namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactMLangBinderSchema

	/// <exclude/>
	public class ContactMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactMLangBinderSchema(ContactMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28c6993a-5103-498a-bc0d-ef34c1059002");
			Name = "ContactMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,223,107,194,48,16,126,174,224,255,112,184,23,7,210,190,59,17,166,56,16,148,13,54,216,115,218,158,93,160,73,74,114,41,147,225,255,190,75,147,14,221,246,146,144,251,126,220,125,23,45,20,186,78,84,8,111,104,173,112,230,68,249,214,232,147,108,188,21,36,141,158,78,190,166,147,204,59,169,155,27,138,197,252,73,84,100,172,68,247,240,15,227,29,75,102,41,101,52,163,140,223,89,108,216,14,182,173,112,110,9,220,131,88,126,60,8,221,108,164,174,209,14,172,162,40,96,229,188,82,194,158,215,233,157,168,160,124,75,178,101,190,23,13,66,21,124,160,28,164,249,168,44,174,164,157,47,91,89,37,222,223,118,176,132,199,174,219,245,168,233,32,29,161,70,187,17,14,89,200,121,249,252,25,248,136,244,97,106,30,249,101,48,140,96,50,55,61,231,149,53,66,111,100,13,207,154,29,95,73,88,154,143,214,161,47,126,18,84,241,190,135,176,204,44,43,185,83,126,69,31,225,176,200,44,27,86,20,151,123,206,195,180,171,125,152,59,196,222,19,242,183,24,187,24,19,253,6,214,243,89,66,102,209,237,146,210,160,174,99,160,225,29,171,183,197,203,55,163,43,50,144,12,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28c6993a-5103-498a-bc0d-ef34c1059002"));
		}

		#endregion

	}

	#endregion

}

