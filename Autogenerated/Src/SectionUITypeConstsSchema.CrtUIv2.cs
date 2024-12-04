namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionUITypeConstsSchema

	/// <exclude/>
	public class SectionUITypeConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionUITypeConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionUITypeConstsSchema(SectionUITypeConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("89ad3885-a9d9-42f8-a623-9e90d811b540");
			Name = "SectionUITypeConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,210,75,111,130,64,16,7,240,179,36,124,135,141,189,180,7,228,33,242,232,43,17,43,141,55,19,245,3,172,176,146,109,100,49,59,203,193,52,126,247,206,46,210,84,219,166,135,94,32,59,51,252,247,151,9,130,214,12,14,180,96,100,205,164,164,208,236,212,104,214,136,29,175,90,73,21,111,132,109,189,219,214,160,5,46,42,178,58,130,98,245,131,109,97,229,70,178,10,219,100,182,167,0,247,100,197,10,61,189,89,172,143,7,134,1,160,192,140,185,174,75,30,161,173,107,42,143,207,231,51,182,21,229,2,72,161,231,168,80,64,118,141,188,140,32,205,246,13,207,163,62,194,253,146,113,104,183,123,94,16,252,84,225,171,208,128,159,239,31,32,29,159,159,214,156,179,125,137,216,165,9,232,122,215,64,83,200,37,99,101,83,147,150,19,232,130,137,210,40,94,106,208,119,209,21,233,181,229,101,159,177,225,61,141,107,218,162,36,79,166,63,90,82,9,236,118,152,121,126,20,71,89,232,164,225,56,113,194,36,13,156,233,60,72,156,60,157,68,254,120,156,207,95,98,111,120,135,59,255,133,106,246,143,119,254,135,122,206,248,139,26,4,179,212,11,195,212,65,111,132,84,141,206,188,196,241,145,232,103,241,116,18,251,190,161,154,157,51,81,118,107,55,231,83,247,211,92,20,79,182,245,1,69,254,215,133,127,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("89ad3885-a9d9-42f8-a623-9e90d811b540"));
		}

		#endregion

	}

	#endregion

}

