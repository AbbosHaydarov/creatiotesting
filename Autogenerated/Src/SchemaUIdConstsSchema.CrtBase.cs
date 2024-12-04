namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SchemaUIdConstsSchema

	/// <exclude/>
	public class SchemaUIdConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SchemaUIdConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SchemaUIdConstsSchema(SchemaUIdConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5dcd2477-a927-4f24-b4d0-93f8657dbaa4");
			Name = "SchemaUIdConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,206,65,107,194,48,24,6,224,179,133,254,135,15,119,209,67,166,213,70,19,100,135,52,77,198,14,133,49,231,238,89,27,93,160,77,165,105,17,25,254,247,197,186,195,122,114,57,124,144,55,111,248,158,206,25,123,128,237,217,181,186,218,132,65,24,88,85,105,119,84,185,134,119,221,52,202,213,251,246,145,215,118,111,14,93,163,90,83,219,48,248,14,131,209,177,251,44,77,14,174,245,89,14,121,169,156,131,109,254,165,43,181,123,41,124,223,181,206,183,174,205,209,108,6,15,127,207,237,6,104,144,206,250,108,50,40,78,175,191,135,139,26,173,138,218,150,103,120,238,76,1,31,39,15,103,69,101,236,206,154,22,158,192,234,83,255,50,25,167,56,157,71,146,167,104,149,18,142,226,100,65,17,21,152,32,206,217,82,74,177,90,44,87,241,120,186,249,143,15,250,121,207,226,37,89,93,116,165,150,117,89,232,102,128,33,68,50,66,9,70,56,73,82,20,211,53,70,20,39,17,194,17,103,130,71,115,74,214,236,30,38,121,205,252,50,99,53,240,183,236,30,38,83,198,102,218,118,3,5,22,88,82,70,5,98,108,237,21,115,63,168,136,4,138,248,34,230,75,73,19,76,127,21,151,48,184,252,0,205,28,21,2,25,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5dcd2477-a927-4f24-b4d0-93f8657dbaa4"));
		}

		#endregion

	}

	#endregion

}

