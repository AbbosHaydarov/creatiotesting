namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MatchesFoundUtilitiesSchema

	/// <exclude/>
	public class MatchesFoundUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MatchesFoundUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MatchesFoundUtilitiesSchema(MatchesFoundUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e78d9172-c1ff-4b6b-b8de-32a4d56c58f1");
			Name = "MatchesFoundUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,83,193,78,195,48,12,61,167,210,254,33,210,238,124,0,59,65,209,16,18,133,73,29,39,196,33,77,220,206,82,154,84,137,123,24,136,127,39,77,202,166,129,16,233,205,121,241,243,123,118,28,35,122,240,131,144,192,247,224,156,240,182,165,171,210,154,22,187,209,9,66,107,86,197,199,170,88,21,108,244,104,58,94,31,61,65,191,137,200,218,65,23,18,120,169,133,247,215,188,18,36,15,224,183,118,52,42,222,191,214,224,80,104,124,23,141,134,183,0,12,99,163,81,114,57,229,255,72,103,73,228,84,115,231,236,0,142,16,66,225,93,164,165,251,185,196,253,136,138,63,168,64,98,140,117,64,155,24,248,57,248,188,200,189,19,4,123,236,129,151,14,66,168,158,77,22,45,74,204,148,219,99,166,150,39,55,77,233,68,123,10,211,93,102,178,178,10,91,92,230,242,155,179,212,230,153,151,237,19,13,77,111,35,193,251,71,12,171,96,192,249,191,137,140,253,22,173,173,12,75,113,35,101,120,120,202,239,49,209,42,80,40,150,53,89,159,137,217,93,54,214,106,94,3,109,173,11,127,129,132,204,51,58,43,166,125,13,83,106,81,195,139,211,203,221,254,215,225,26,140,74,31,37,158,19,122,9,6,236,11,24,83,228,51,219,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e78d9172-c1ff-4b6b-b8de-32a4d56c58f1"));
		}

		#endregion

	}

	#endregion

}

