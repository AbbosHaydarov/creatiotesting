namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateSsoContactBackgroundTaskSchema

	/// <exclude/>
	public class UpdateSsoContactBackgroundTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateSsoContactBackgroundTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateSsoContactBackgroundTaskSchema(UpdateSsoContactBackgroundTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fc80e659-5c97-4b8f-a38f-24e4568bb179");
			Name = "UpdateSsoContactBackgroundTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,77,107,227,48,16,61,187,208,255,48,184,23,7,138,125,239,38,129,110,33,37,176,133,165,105,207,139,106,79,92,81,91,114,103,164,44,101,233,127,223,145,148,46,85,218,116,47,54,154,143,55,239,189,25,163,70,228,73,181,8,119,72,164,216,110,93,125,101,205,86,247,158,148,211,214,192,233,201,159,211,147,194,179,54,253,177,154,122,165,7,92,143,147,37,247,237,211,90,194,99,241,122,165,90,103,73,35,31,173,184,83,252,20,178,146,63,35,236,3,167,171,65,49,95,192,253,212,41,135,27,182,194,198,9,206,119,213,62,245,100,189,233,66,79,236,104,154,6,230,236,199,81,209,203,114,255,142,221,224,99,51,3,179,133,54,245,67,154,191,185,188,249,1,36,182,88,195,8,91,178,35,176,112,84,61,214,111,136,205,59,200,201,63,12,186,133,54,162,126,77,9,46,96,157,71,230,15,214,14,203,115,88,223,51,146,244,24,108,131,163,183,248,236,53,97,39,240,226,190,124,255,73,95,105,28,58,209,254,147,244,78,38,165,228,148,30,144,131,192,47,223,38,223,138,51,52,93,2,200,209,110,208,61,218,8,23,69,164,100,84,168,205,35,146,118,157,21,101,132,219,69,185,40,15,168,215,183,222,148,205,114,207,32,153,176,179,186,3,137,87,65,22,76,138,228,188,28,18,207,32,28,81,81,236,20,5,195,247,230,36,179,8,22,105,37,233,20,94,234,107,116,243,245,230,176,106,89,25,252,13,18,99,71,62,20,94,82,239,71,52,174,42,125,38,187,60,15,194,103,179,112,80,69,241,97,90,157,254,251,96,53,139,101,175,255,81,254,249,118,234,13,186,60,19,253,200,221,248,80,83,29,108,41,103,255,230,148,72,16,95,242,220,123,170,7,27,77,209,60,248,250,23,211,185,88,125,221,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fc80e659-5c97-4b8f-a38f-24e4568bb179"));
		}

		#endregion

	}

	#endregion

}

