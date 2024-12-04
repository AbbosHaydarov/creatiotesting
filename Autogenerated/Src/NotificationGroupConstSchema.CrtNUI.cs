namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationGroupConstSchema

	/// <exclude/>
	public class NotificationGroupConstSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationGroupConstSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationGroupConstSchema(NotificationGroupConstSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b4de5f4-8161-4ca8-921e-9f19f6876f8d");
			Name = "NotificationGroupConst";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,65,107,195,48,12,133,207,13,228,63,136,238,222,220,219,109,48,202,216,45,140,182,244,238,37,78,16,56,114,144,156,65,41,251,239,147,189,117,51,129,177,156,236,39,191,239,73,22,153,193,202,104,26,11,39,203,108,196,119,97,179,247,212,97,63,177,9,232,169,44,174,101,177,186,99,219,171,128,189,51,34,91,168,125,192,14,155,100,120,97,63,141,138,72,40,11,117,86,85,5,247,50,13,131,225,203,227,183,78,175,134,130,128,239,160,143,126,1,202,34,54,55,174,202,192,113,122,115,216,128,130,65,143,38,54,254,179,239,42,206,248,59,228,173,221,22,94,83,72,26,108,22,200,214,180,158,220,69,53,35,245,112,70,49,240,0,235,120,174,119,255,251,15,118,64,106,227,77,161,31,177,132,172,179,79,68,56,215,75,248,231,99,61,143,152,149,150,164,60,17,225,187,101,209,109,199,132,76,46,162,157,75,148,115,209,157,150,111,169,253,218,191,170,143,84,203,75,90,249,4,91,144,31,62,107,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b4de5f4-8161-4ca8-921e-9f19f6876f8d"));
		}

		#endregion

	}

	#endregion

}

