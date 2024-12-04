namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookObjSchema

	/// <exclude/>
	public class WebhookObjSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookObjSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookObjSchema(WebhookObjSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03985297-1a6a-43c1-ac77-0535d189ca09");
			Name = "WebhookObj";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,147,77,79,195,48,12,134,207,155,180,255,96,105,247,245,206,16,7,118,24,156,40,251,16,231,52,113,187,140,54,41,118,162,169,154,246,223,73,155,13,33,64,208,85,92,242,225,248,245,243,70,113,140,168,144,107,33,17,54,72,36,216,230,110,182,176,38,215,133,39,225,180,53,147,241,113,50,30,121,214,166,128,117,195,14,171,249,100,28,34,73,146,192,45,251,170,18,212,220,157,247,43,172,9,25,141,99,16,112,192,108,103,237,43,216,108,143,210,65,110,9,60,35,104,3,210,42,156,93,74,36,159,106,212,62,43,181,4,89,10,102,120,137,250,167,108,31,78,130,135,48,142,166,132,69,240,4,41,217,26,201,105,228,27,72,59,81,60,255,106,170,11,44,49,248,9,116,110,103,183,67,112,77,141,96,243,110,45,173,113,193,112,107,231,187,159,139,33,118,212,94,127,17,115,55,173,252,8,5,186,121,91,115,14,167,107,224,59,20,10,137,123,1,31,98,238,112,216,155,71,106,160,22,20,94,217,245,165,62,183,162,244,67,51,156,78,24,248,236,32,179,170,233,69,94,69,193,125,200,31,78,245,160,85,120,37,157,107,164,223,169,75,175,21,108,31,213,112,214,225,220,227,108,61,201,174,167,255,188,227,185,173,215,157,226,191,200,224,169,236,69,143,216,45,149,63,145,167,104,84,252,96,221,62,68,79,239,230,155,89,219,31,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03985297-1a6a-43c1-ac77-0535d189ca09"));
		}

		#endregion

	}

	#endregion

}

