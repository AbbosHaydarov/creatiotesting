namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTrackingResultSchema

	/// <exclude/>
	public class EventTrackingResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTrackingResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTrackingResultSchema(EventTrackingResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("994af77d-fdfe-407e-9278-b280ee07b73c");
			Name = "EventTrackingResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,221,74,3,49,16,70,175,179,176,239,16,240,86,138,255,130,224,197,106,87,40,130,5,91,31,32,102,103,183,161,155,73,152,76,132,69,250,238,206,166,130,94,244,110,230,59,135,143,97,208,120,72,209,88,208,91,32,50,41,244,188,120,14,216,187,33,147,97,23,112,209,126,1,242,150,140,221,59,28,222,33,229,145,235,234,187,174,234,74,157,17,12,162,232,22,179,127,208,39,197,186,82,49,127,142,206,106,16,233,180,163,164,77,169,245,94,63,234,139,243,121,108,162,123,133,233,45,240,75,200,216,73,124,89,226,21,246,114,33,83,182,156,9,4,47,33,142,97,130,217,184,42,198,154,119,64,45,81,32,137,174,255,117,53,35,129,233,166,143,84,228,155,223,58,27,136,192,242,83,244,77,230,157,104,194,110,11,219,76,105,3,204,114,228,42,181,62,242,76,238,10,89,6,111,28,254,165,247,18,30,142,223,0,236,142,15,153,215,195,15,59,218,177,225,90,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("994af77d-fdfe-407e-9278-b280ee07b73c"));
		}

		#endregion

	}

	#endregion

}

