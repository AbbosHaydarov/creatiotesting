namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ScheduleMailingStateSchema

	/// <exclude/>
	public class ScheduleMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ScheduleMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ScheduleMailingStateSchema(ScheduleMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("196c6b02-4784-4c5a-9831-b4fc6e589e4f");
			Name = "ScheduleMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,81,77,107,195,48,12,61,167,144,255,32,122,106,47,205,125,107,3,163,116,91,96,221,97,217,109,236,224,58,74,107,112,236,32,217,253,216,216,127,159,210,210,174,12,58,198,24,216,6,75,239,61,73,79,78,53,200,173,210,8,207,72,164,216,215,97,52,245,174,54,203,72,42,24,239,210,222,123,218,75,34,27,183,132,114,199,1,155,235,180,39,145,54,46,172,209,160,173,98,134,82,175,176,138,22,231,202,88,1,150,65,5,132,43,56,255,10,165,19,58,242,252,90,202,153,10,225,46,154,234,229,21,110,214,130,85,11,139,183,158,102,91,212,177,171,221,17,35,35,195,36,135,176,34,191,1,135,27,120,244,161,104,90,139,13,186,128,213,108,171,177,237,192,131,225,161,177,164,37,31,80,75,234,171,8,7,234,250,159,17,121,154,35,179,90,98,185,15,77,189,100,255,75,125,45,148,7,253,246,87,229,44,203,96,204,177,105,20,237,242,99,224,224,133,88,16,86,134,165,146,56,57,58,129,179,239,232,49,97,136,228,56,47,156,64,157,108,213,215,162,137,8,154,176,158,244,207,23,114,114,249,9,57,218,208,207,242,209,56,59,242,47,76,250,3,31,238,149,171,172,216,138,109,33,243,145,83,118,48,132,253,202,147,223,121,144,36,31,242,200,149,243,9,156,169,32,217,151,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("196c6b02-4784-4c5a-9831-b4fc6e589e4f"));
		}

		#endregion

	}

	#endregion

}

