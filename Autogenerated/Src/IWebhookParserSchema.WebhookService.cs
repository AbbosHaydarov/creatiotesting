namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebhookParserSchema

	/// <exclude/>
	public class IWebhookParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebhookParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebhookParserSchema(IWebhookParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df265d20-80da-4a1e-8545-4bd85da8db16");
			Name = "IWebhookParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,203,106,195,48,16,69,215,9,244,31,134,116,211,66,137,247,141,235,69,31,132,132,62,2,9,116,45,219,99,71,169,173,81,71,18,193,132,252,123,229,87,227,166,93,116,99,240,220,123,71,103,70,82,162,68,163,69,130,176,65,102,97,40,179,211,7,82,153,204,29,11,43,73,93,140,15,23,227,145,51,82,229,176,174,140,197,210,235,69,129,73,45,154,233,28,21,178,76,102,223,158,87,220,91,47,212,125,150,134,212,244,89,170,79,175,122,61,8,2,8,141,43,75,193,85,212,253,191,99,188,37,250,128,152,210,10,180,96,131,220,59,131,129,85,187,184,144,9,72,101,145,179,26,118,209,5,87,125,196,67,250,239,232,146,49,247,92,176,98,210,200,86,162,185,133,85,19,110,245,115,134,166,176,118,90,19,91,76,193,86,26,13,100,196,39,150,223,48,163,197,147,114,37,178,136,11,12,141,101,63,117,116,234,177,105,90,28,32,71,59,131,99,71,133,42,109,193,126,82,190,160,221,82,250,31,196,102,78,216,15,182,245,55,90,83,241,236,162,4,229,111,246,110,210,69,238,125,98,18,13,243,97,208,216,78,41,70,235,88,153,168,190,181,71,74,252,132,202,134,65,95,173,109,49,81,1,27,174,230,104,223,226,157,127,1,87,237,244,61,87,125,200,13,144,179,176,108,117,216,13,122,93,183,175,224,124,25,126,69,199,47,239,207,200,21,133,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df265d20-80da-4a1e-8545-4bd85da8db16"));
		}

		#endregion

	}

	#endregion

}

