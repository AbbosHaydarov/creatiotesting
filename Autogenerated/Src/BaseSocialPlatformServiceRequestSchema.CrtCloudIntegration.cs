namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseSocialPlatformServiceRequestSchema

	/// <exclude/>
	public class BaseSocialPlatformServiceRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseSocialPlatformServiceRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseSocialPlatformServiceRequestSchema(BaseSocialPlatformServiceRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c55249a-8bea-465d-85dd-98f32e454b2d");
			Name = "BaseSocialPlatformServiceRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,75,107,195,48,12,128,207,45,244,63,152,246,210,93,146,251,186,13,182,236,210,65,75,104,216,169,236,224,38,106,48,248,145,89,242,70,86,250,223,231,56,233,11,66,105,47,6,75,159,164,207,194,154,43,192,138,231,192,18,75,137,52,174,152,107,130,210,114,18,70,71,11,83,128,196,104,5,223,14,144,112,52,220,141,134,3,135,66,151,44,171,145,64,69,43,167,73,40,136,50,176,130,75,241,23,234,102,71,106,9,191,100,52,154,45,69,31,24,18,62,53,177,80,122,138,37,146,35,62,178,55,142,144,153,220,151,167,146,211,214,88,229,155,253,136,28,186,177,161,102,253,206,137,39,70,147,229,57,125,249,64,229,54,82,228,44,111,122,220,208,98,224,205,253,121,156,157,90,83,129,37,1,94,32,13,173,218,124,28,199,236,9,157,82,220,214,47,135,192,107,85,121,32,60,141,105,191,176,35,24,159,147,65,113,1,106,3,118,186,244,20,123,102,99,126,170,28,63,52,218,131,117,179,135,110,122,61,237,1,186,135,33,217,102,129,231,163,119,172,4,154,49,108,142,253,21,221,195,14,238,116,173,186,178,230,222,47,219,67,92,218,166,242,4,220,175,235,16,44,19,5,248,31,181,21,96,239,55,255,244,13,230,197,117,247,11,166,223,190,69,250,252,39,160,139,246,3,133,123,27,189,12,238,255,1,180,182,173,105,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c55249a-8bea-465d-85dd-98f32e454b2d"));
		}

		#endregion

	}

	#endregion

}

