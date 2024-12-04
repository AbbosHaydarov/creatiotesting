namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebSocketDtoSchema

	/// <exclude/>
	public class WebSocketDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebSocketDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebSocketDtoSchema(WebSocketDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("43107381-18a7-4acf-937d-84d2939c6d9e");
			Name = "WebSocketDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,145,177,106,195,48,16,64,231,24,252,15,34,89,218,37,31,208,140,78,7,119,40,6,15,29,66,7,89,190,24,81,89,103,238,206,132,16,242,239,149,236,164,37,65,131,151,3,221,187,123,146,238,188,238,129,7,109,64,21,36,133,195,177,45,189,64,71,90,44,250,237,94,48,207,46,121,182,26,217,250,78,125,194,73,208,51,30,101,251,193,232,119,121,22,208,134,160,11,181,170,112,154,249,77,125,65,83,163,249,1,153,122,3,31,198,198,89,163,76,196,79,116,21,212,33,254,41,42,194,1,72,44,4,79,53,181,205,252,16,111,187,193,243,203,218,96,223,107,223,174,95,191,35,188,249,89,40,62,177,152,153,186,168,14,100,167,56,134,107,210,210,2,27,178,67,252,103,210,180,255,231,11,108,64,132,84,96,11,73,215,251,157,46,48,13,78,203,17,169,79,138,42,55,195,5,30,203,245,104,12,48,63,138,26,68,167,202,59,91,224,57,65,195,211,202,234,80,31,134,81,166,7,31,54,251,84,150,114,111,192,183,243,178,167,243,156,125,76,94,127,1,249,237,225,244,147,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43107381-18a7-4acf-937d-84d2939c6d9e"));
		}

		#endregion

	}

	#endregion

}

