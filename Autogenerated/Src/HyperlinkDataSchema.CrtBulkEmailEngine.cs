namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HyperlinkDataSchema

	/// <exclude/>
	public class HyperlinkDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HyperlinkDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HyperlinkDataSchema(HyperlinkDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09dcd3e4-968e-49ba-9925-0e06455c854d");
			Name = "HyperlinkData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,193,106,194,64,16,61,43,228,31,6,188,180,32,230,94,69,40,17,236,161,7,177,245,3,38,201,24,183,221,236,134,157,93,65,196,127,239,108,82,131,164,165,180,133,144,236,188,125,111,222,203,238,24,172,137,27,44,8,94,201,57,100,187,247,179,204,154,189,170,130,67,175,172,73,198,231,100,60,10,172,76,5,47,39,246,84,207,7,181,240,181,166,34,146,121,182,38,67,78,21,145,35,207,196,81,37,48,100,26,153,31,224,233,212,144,211,202,188,175,208,99,50,22,66,154,166,176,224,80,215,232,78,203,207,122,75,141,35,38,227,25,14,87,1,148,162,0,111,129,241,72,160,140,172,34,146,35,211,236,218,38,189,233,211,132,92,171,2,138,232,59,180,29,201,15,201,187,15,183,113,86,246,189,34,73,184,105,117,221,254,48,91,11,172,73,98,89,7,28,191,254,64,176,219,62,199,4,95,35,92,51,176,119,241,172,118,78,195,25,42,242,243,168,157,195,229,47,38,65,196,5,54,241,136,127,101,150,117,220,255,27,98,89,170,216,1,197,215,234,80,27,134,82,181,87,44,50,184,235,48,48,50,60,83,56,162,14,116,255,115,174,85,47,94,116,17,167,96,243,55,25,154,37,60,246,86,50,71,173,211,55,169,39,100,202,238,186,218,186,67,111,193,203,7,178,249,159,55,201,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09dcd3e4-968e-49ba-9925-0e06455c854d"));
		}

		#endregion

	}

	#endregion

}

