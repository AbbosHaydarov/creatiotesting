namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordUnlinkerSchema

	/// <exclude/>
	public class RecordUnlinkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordUnlinkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordUnlinkerSchema(RecordUnlinkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66bb5f4d-9a35-4ffa-80c6-0587b0525470");
			Name = "RecordUnlinker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,81,209,110,26,49,16,124,62,36,254,97,149,190,16,41,186,15,32,109,31,2,164,170,212,180,21,148,15,48,246,112,184,49,246,117,237,59,5,85,249,247,174,207,52,1,36,164,123,56,239,204,206,238,204,122,181,71,108,149,6,253,2,179,138,97,155,234,89,240,91,219,116,172,146,13,158,254,142,71,85,23,173,111,104,117,136,9,251,251,139,183,208,157,131,206,220,88,127,129,7,91,253,206,57,85,101,92,171,215,11,159,108,178,136,87,9,243,135,12,201,247,129,209,228,181,102,78,197,56,165,37,116,96,179,246,206,250,103,240,120,36,140,182,219,56,171,73,103,194,5,78,83,122,80,17,165,184,120,129,238,82,224,236,80,218,222,149,197,72,226,78,11,36,3,126,14,106,133,113,84,62,215,156,172,35,88,122,124,201,128,186,179,231,29,125,157,219,225,79,241,225,163,232,138,183,59,10,155,223,2,127,166,86,177,228,159,192,241,54,235,87,213,148,54,178,223,228,82,227,132,55,220,163,170,202,14,75,219,236,210,143,22,199,83,125,162,149,222,97,175,78,192,111,232,225,98,61,83,126,97,108,186,47,189,86,128,197,139,70,155,187,158,16,163,106,32,205,55,195,21,14,69,163,126,35,212,223,195,208,241,24,184,94,183,70,37,220,12,58,175,199,216,224,77,73,238,60,198,39,164,93,48,39,9,86,249,124,85,203,33,137,45,24,10,189,156,216,26,80,31,172,161,57,156,24,124,243,50,249,111,180,236,84,175,84,143,73,175,156,205,243,151,248,211,89,134,153,210,86,185,136,219,107,235,12,19,75,253,172,60,30,189,254,3,118,83,20,7,248,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66bb5f4d-9a35-4ffa-80c6-0587b0525470"));
		}

		#endregion

	}

	#endregion

}

