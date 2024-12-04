namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateAudienceBackgroundTaskSchema

	/// <exclude/>
	public class UpdateAudienceBackgroundTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateAudienceBackgroundTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateAudienceBackgroundTaskSchema(UpdateAudienceBackgroundTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe47ef50-c61a-408b-9310-9543c3f3a000");
			Name = "UpdateAudienceBackgroundTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,193,78,131,64,16,61,99,226,63,236,17,18,195,7,212,218,196,214,170,61,232,161,180,103,51,46,83,186,97,187,224,236,46,198,24,255,221,161,72,83,16,162,9,108,50,51,239,237,123,59,207,192,1,109,9,18,197,6,137,192,22,59,23,47,10,179,83,153,39,112,170,48,226,243,242,34,240,86,153,108,12,17,63,129,73,73,105,157,32,85,74,226,245,32,129,70,251,241,61,72,87,144,66,59,138,216,128,205,235,41,207,75,255,170,149,20,82,131,181,98,91,166,224,240,214,167,10,141,196,57,200,60,163,194,155,180,198,139,137,88,117,59,211,6,190,1,202,208,181,164,59,112,48,187,18,171,173,69,226,103,25,148,245,155,214,248,230,21,97,202,130,245,251,131,146,84,197,84,209,69,137,23,223,169,27,135,173,197,170,80,169,88,123,19,142,201,138,18,136,215,239,144,108,116,92,51,83,79,157,184,39,117,51,32,198,132,10,72,188,122,157,47,15,160,116,123,249,35,234,18,137,41,139,122,75,205,122,63,226,7,116,211,249,48,116,22,70,205,117,246,93,57,185,23,225,153,143,68,238,241,0,207,92,182,38,3,9,22,133,225,78,177,11,151,21,26,23,77,126,15,78,82,237,48,24,241,25,15,237,231,204,65,212,88,99,62,33,228,63,197,160,82,82,106,117,242,242,135,220,17,187,65,251,95,197,175,250,228,163,31,112,130,174,155,84,216,11,174,155,90,187,195,94,152,156,213,64,186,181,38,255,252,125,3,229,244,221,217,167,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe47ef50-c61a-408b-9310-9543c3f3a000"));
		}

		#endregion

	}

	#endregion

}

