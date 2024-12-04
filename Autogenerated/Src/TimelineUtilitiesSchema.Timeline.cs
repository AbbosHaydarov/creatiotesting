namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimelineUtilitiesSchema

	/// <exclude/>
	public class TimelineUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimelineUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimelineUtilitiesSchema(TimelineUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("315c3b7a-309c-4cee-a111-cc022ffb97a1");
			Name = "TimelineUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7a90b74c-4b62-4974-bba4-023527b96ef3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,75,107,194,64,16,62,71,240,63,12,241,82,139,36,182,180,151,86,133,98,75,47,21,4,181,215,178,38,99,92,200,110,194,62,164,105,241,191,119,178,219,168,177,246,178,176,51,243,61,246,155,149,76,160,46,89,130,176,68,165,152,46,54,38,154,22,114,195,51,171,152,225,133,140,150,92,96,206,37,118,59,223,221,78,96,53,151,89,107,86,225,99,183,67,157,158,194,140,230,97,154,51,173,31,160,129,173,12,207,185,225,168,221,80,28,199,48,210,86,8,166,170,201,239,125,174,138,29,79,81,31,32,96,29,166,2,129,102,91,164,58,106,128,241,9,178,180,235,156,39,160,13,185,76,32,169,69,47,105,6,100,154,206,163,187,66,18,68,26,114,56,87,124,199,12,250,126,233,47,13,31,151,6,62,4,251,92,240,47,124,198,205,180,200,173,144,239,44,183,8,99,184,25,222,222,193,53,220,15,253,195,131,30,202,212,211,183,181,102,222,62,41,57,175,190,121,158,128,43,188,162,209,128,130,241,28,214,69,90,65,226,244,128,12,128,38,7,117,0,127,19,240,149,146,41,38,64,210,26,199,161,213,168,232,129,18,147,122,115,225,100,185,165,44,169,70,124,77,49,26,197,14,113,36,80,104,172,146,122,242,116,144,59,117,178,99,244,102,2,53,83,46,171,86,244,117,84,228,255,165,198,204,124,98,39,113,93,173,90,158,156,157,227,181,15,245,159,10,2,207,78,203,81,120,246,251,22,149,94,160,49,244,233,116,68,42,158,179,77,50,128,240,141,169,12,107,101,231,194,13,133,131,127,22,216,167,173,5,193,254,226,234,124,181,93,220,255,0,44,22,11,203,35,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("315c3b7a-309c-4cee-a111-cc022ffb97a1"));
		}

		#endregion

	}

	#endregion

}

