namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactConstsSchema

	/// <exclude/>
	public class ContactConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactConstsSchema(ContactConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42db62ea-f92c-4df6-b6a2-c994e9708c0b");
			Name = "ContactConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,203,106,195,48,16,69,215,54,248,31,132,87,237,66,177,20,165,170,66,31,96,59,114,200,162,80,104,126,64,181,39,198,224,23,146,188,48,37,255,94,41,161,161,93,180,161,155,145,24,206,101,206,204,100,154,190,70,111,179,177,208,61,68,97,20,246,170,3,51,170,18,208,30,180,86,102,56,216,69,62,244,135,166,158,180,178,205,208,71,225,71,20,6,227,244,222,54,37,50,214,245,74,84,182,202,24,228,48,171,74,235,30,99,141,99,60,23,36,73,130,30,205,212,117,74,207,207,95,141,253,60,2,194,72,118,99,59,204,0,23,46,249,14,254,28,177,157,154,234,18,240,249,93,229,161,211,140,160,6,139,206,191,64,131,157,116,127,194,23,175,74,27,184,137,57,185,103,76,22,57,46,24,207,48,93,81,130,83,33,24,166,124,35,88,158,102,100,45,72,124,235,182,119,241,163,175,174,252,170,190,133,190,2,237,228,95,84,11,139,63,205,75,127,8,231,175,253,137,61,190,171,208,19,138,165,76,243,213,82,74,204,239,50,142,55,5,165,88,48,154,98,66,232,134,19,185,102,34,231,241,201,230,186,68,1,221,255,52,206,129,179,72,145,47,87,130,21,226,170,136,187,199,241,19,79,36,106,12,41,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42db62ea-f92c-4df6-b6a2-c994e9708c0b"));
		}

		#endregion

	}

	#endregion

}

