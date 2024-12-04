namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactSelectModelSchema

	/// <exclude/>
	public class ContactSelectModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactSelectModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactSelectModelSchema(ContactSelectModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c995aa53-261b-474b-b723-c7bbe16e4062");
			Name = "ContactSelectModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bb225b1d-9856-4e2d-8d05-b81de9745531");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,81,75,195,48,16,199,159,59,240,59,28,236,85,214,119,39,130,86,25,130,202,100,245,3,196,228,218,6,218,164,38,151,65,25,251,238,94,210,110,108,42,243,37,228,238,114,255,251,229,254,70,116,232,123,33,17,74,116,78,120,91,209,162,176,166,210,117,112,130,180,53,87,179,221,213,44,11,94,155,26,54,131,39,236,150,199,184,176,14,23,143,15,156,224,212,220,97,205,239,161,104,133,247,55,92,51,36,36,109,176,69,73,175,86,97,155,94,229,121,14,183,62,116,157,112,195,221,20,151,67,143,96,171,67,203,123,64,55,172,157,221,106,133,14,28,250,208,82,44,175,240,84,13,58,164,198,170,197,65,51,63,17,237,195,103,171,37,200,72,242,39,72,198,127,226,243,200,204,211,122,116,164,145,193,215,169,121,172,255,164,77,137,143,103,21,113,120,25,27,217,96,39,160,178,14,68,80,26,13,175,145,43,47,40,212,53,60,109,209,80,41,92,141,4,72,50,130,254,38,61,160,174,130,86,112,63,105,140,178,113,204,14,184,123,9,62,30,251,11,72,101,131,96,216,201,147,45,114,183,180,109,232,204,229,193,158,220,232,228,212,84,164,158,183,168,21,125,207,178,8,144,46,17,34,94,46,113,36,235,128,26,65,236,27,5,103,60,8,104,181,79,254,77,51,32,24,253,21,16,216,93,67,186,210,232,252,101,196,209,185,115,31,255,129,155,163,81,163,181,41,30,179,231,201,253,55,17,25,210,62,250,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c995aa53-261b-474b-b723-c7bbe16e4062"));
		}

		#endregion

	}

	#endregion

}

