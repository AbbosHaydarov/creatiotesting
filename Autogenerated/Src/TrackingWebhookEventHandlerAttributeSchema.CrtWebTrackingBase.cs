namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TrackingWebhookEventHandlerAttributeSchema

	/// <exclude/>
	public class TrackingWebhookEventHandlerAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TrackingWebhookEventHandlerAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TrackingWebhookEventHandlerAttributeSchema(TrackingWebhookEventHandlerAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("142f0c01-2e8e-495c-8772-97d10fa317ad");
			Name = "TrackingWebhookEventHandlerAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,49,79,195,48,16,133,103,34,229,63,156,202,66,151,120,47,5,169,170,144,216,27,196,128,24,46,206,197,181,154,216,213,157,83,84,161,254,119,236,58,13,18,19,155,223,249,249,123,190,231,112,32,57,162,38,168,137,25,197,119,161,218,122,215,89,51,50,6,235,93,89,124,151,197,221,40,214,25,216,157,37,208,240,88,22,113,114,207,100,226,53,108,123,20,89,65,205,168,15,209,243,78,205,222,251,195,203,137,92,120,69,215,246,196,155,16,216,54,99,160,235,59,165,20,172,101,28,6,228,243,243,164,55,55,7,4,15,45,117,214,197,211,4,132,175,76,4,74,72,216,103,38,232,20,91,221,120,234,15,112,45,68,216,139,7,205,212,61,45,242,191,171,57,102,1,42,57,63,230,193,155,160,161,135,89,214,200,134,130,84,215,221,150,159,209,122,28,155,222,234,156,250,175,93,97,53,181,245,155,26,49,169,202,75,174,143,92,155,27,76,242,82,22,63,221,59,85,75,137,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("142f0c01-2e8e-495c-8772-97d10fa317ad"));
		}

		#endregion

	}

	#endregion

}

