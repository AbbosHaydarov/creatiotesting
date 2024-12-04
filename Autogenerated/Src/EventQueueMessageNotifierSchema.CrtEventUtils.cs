namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventQueueMessageNotifierSchema

	/// <exclude/>
	public class EventQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventQueueMessageNotifierSchema(EventQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2");
			Name = "EventQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,75,111,26,49,16,62,19,41,255,193,218,94,118,37,180,220,19,224,144,103,145,154,136,6,170,158,141,119,22,220,236,218,91,63,104,104,148,255,222,177,189,6,54,64,148,30,64,235,241,60,190,249,230,27,11,90,131,110,40,3,50,7,165,168,150,165,201,175,165,40,249,210,42,106,184,20,231,103,175,231,103,61,171,185,88,146,217,70,27,168,47,183,231,253,16,5,167,236,249,205,21,94,225,229,23,5,75,204,72,174,43,170,245,5,185,93,131,48,223,45,88,120,0,173,233,18,30,165,225,37,7,229,157,7,131,1,25,106,91,215,84,109,198,237,217,71,144,58,120,147,70,73,134,159,174,160,104,35,243,24,56,216,139,108,236,162,226,140,48,87,245,116,81,114,65,174,168,134,227,120,122,200,1,254,239,58,144,66,27,101,153,145,10,27,153,250,2,193,227,61,108,111,216,115,39,37,254,134,26,128,48,5,229,40,57,137,39,25,140,3,100,215,211,97,83,193,210,80,69,107,34,112,134,163,196,106,80,88,72,0,115,99,75,198,195,129,191,245,206,45,5,39,139,165,63,58,193,164,155,43,67,110,22,200,77,250,222,236,148,209,123,107,169,1,81,4,118,186,84,77,149,108,64,25,14,142,40,37,13,198,66,241,1,87,143,216,12,145,37,49,43,164,200,42,229,38,190,63,222,35,84,52,49,45,145,107,84,30,47,128,32,221,78,23,177,63,159,244,149,44,193,144,209,152,220,131,153,111,26,72,179,220,217,47,201,219,39,225,40,168,185,40,92,94,4,197,205,134,104,182,130,154,254,55,170,167,152,103,230,227,187,224,220,48,101,153,250,81,101,91,108,167,216,125,0,179,146,133,167,150,175,169,129,112,219,132,67,172,135,253,250,116,174,80,122,111,121,65,192,29,39,69,59,193,222,154,42,162,161,66,180,100,68,4,252,33,51,127,120,167,138,204,251,246,112,167,43,91,139,52,113,233,146,104,188,83,178,78,59,216,227,205,207,21,40,72,147,73,145,100,249,68,223,254,182,180,74,67,138,124,234,4,10,6,245,23,1,101,132,234,182,186,123,78,122,189,0,43,159,53,192,120,185,121,148,223,36,123,254,202,133,209,105,22,28,20,24,171,68,11,63,191,125,1,102,13,204,24,173,168,26,134,254,199,173,235,231,169,60,84,41,23,216,5,55,133,100,100,112,106,186,158,89,228,122,102,23,191,240,106,82,164,238,65,153,83,253,188,191,114,241,249,138,220,183,248,211,248,170,97,255,7,107,154,229,222,52,41,246,251,248,52,174,157,10,194,58,48,255,174,223,128,102,138,55,238,243,67,156,253,24,239,214,216,71,62,129,182,149,233,104,39,118,140,242,233,16,16,123,189,220,186,250,65,123,197,143,186,186,220,230,200,118,206,97,239,3,222,41,53,40,20,129,97,93,85,230,152,5,69,65,43,254,151,46,42,152,121,176,29,37,30,123,240,178,126,80,103,226,90,223,167,101,14,47,38,105,33,68,105,249,148,249,157,84,53,53,233,17,76,253,93,87,253,3,154,62,144,94,176,118,141,104,251,7,50,170,81,87,147,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBaseNotificationTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBaseNotificationTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("533eb283-d1e0-4283-97c3-990f51f39aaf"),
				Name = "BaseNotificationText",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2"),
				ModifiedInSchemaUId = new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0443272f-7961-4d10-902e-c867ff5bc1e2"));
		}

		#endregion

	}

	#endregion

}

