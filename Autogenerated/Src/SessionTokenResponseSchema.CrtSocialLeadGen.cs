namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenResponseSchema

	/// <exclude/>
	public class SessionTokenResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenResponseSchema(SessionTokenResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f87b198-4253-acd7-9bd9-07d8390cb4bc");
			Name = "SessionTokenResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,143,203,106,195,48,16,69,215,49,248,31,6,178,183,247,109,41,148,44,186,201,34,196,201,7,76,228,177,43,106,207,152,145,148,80,66,255,189,178,28,151,52,125,208,141,208,220,121,220,115,25,123,114,3,26,130,29,169,162,147,198,23,43,225,198,182,65,209,91,225,162,18,99,177,91,19,214,207,196,121,118,206,179,60,91,44,149,218,216,132,85,135,206,221,65,69,206,197,114,39,175,196,219,120,79,216,81,154,43,203,18,30,92,232,123,212,183,199,75,61,15,192,201,250,23,176,220,136,246,201,10,240,32,193,3,26,35,129,61,56,210,163,141,96,200,117,252,39,131,98,62,89,94,221,28,194,161,179,6,204,136,242,11,201,98,162,254,196,222,168,12,164,222,82,100,223,164,245,60,245,111,113,147,240,116,195,179,223,174,71,142,239,32,51,137,243,106,185,157,247,170,105,109,175,29,156,161,37,127,31,15,197,231,253,15,199,75,8,240,99,138,127,121,93,199,254,201,102,73,92,79,217,83,61,169,95,197,168,125,0,69,50,64,255,13,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f87b198-4253-acd7-9bd9-07d8390cb4bc"));
		}

		#endregion

	}

	#endregion

}

