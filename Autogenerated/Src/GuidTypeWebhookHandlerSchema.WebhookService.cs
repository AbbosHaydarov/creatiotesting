namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GuidTypeWebhookHandlerSchema

	/// <exclude/>
	public class GuidTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GuidTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GuidTypeWebhookHandlerSchema(GuidTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78e0af57-7792-438f-8a76-624a4fc1bae5");
			Name = "GuidTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,77,111,219,48,12,134,207,46,208,255,64,184,151,24,40,236,123,154,4,88,83,244,227,176,33,64,3,236,48,244,160,216,116,170,205,150,12,74,202,96,12,251,239,163,100,57,75,187,184,216,69,176,41,242,125,201,71,146,18,45,154,78,148,8,91,36,18,70,215,54,95,107,85,203,189,35,97,165,86,151,23,191,46,47,18,103,164,218,195,115,111,44,182,55,199,255,211,18,194,252,94,148,86,147,68,195,25,156,115,69,184,103,1,88,55,194,152,57,60,56,89,109,251,14,191,226,238,85,235,31,143,66,85,13,82,200,44,138,2,22,198,181,173,160,126,21,255,99,26,196,60,168,53,193,158,37,192,178,198,88,83,188,43,90,24,68,209,24,13,37,97,189,76,39,70,202,159,214,206,88,221,254,219,77,10,133,151,250,118,135,181,112,141,189,149,170,226,57,103,222,82,215,179,201,178,236,26,190,48,71,88,66,122,126,202,52,123,97,217,206,237,26,89,66,233,121,76,224,128,57,76,186,176,2,31,5,175,71,178,27,210,29,146,101,226,115,216,4,241,97,255,61,207,16,224,228,131,172,216,66,113,171,249,49,237,20,225,216,161,177,228,143,119,172,24,102,91,141,71,242,172,29,149,200,68,141,21,202,154,252,147,234,111,62,240,13,221,123,57,79,241,99,95,63,243,176,176,91,132,238,57,101,81,255,10,85,53,140,254,150,195,103,180,175,186,250,31,8,199,102,126,198,235,213,9,226,233,44,99,57,136,198,77,245,23,34,33,53,208,91,166,82,117,206,166,171,8,234,224,75,65,215,103,84,253,181,29,77,243,69,17,54,254,74,18,90,71,202,172,22,197,248,117,66,67,239,190,99,105,227,3,152,69,171,96,156,129,127,147,73,34,107,8,124,242,45,245,27,65,6,103,97,251,26,180,179,225,130,1,161,225,123,156,141,5,201,96,19,195,254,33,39,201,239,176,198,13,229,154,38,132,57,122,134,248,16,125,27,228,216,31,195,116,114,226,69,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78e0af57-7792-438f-8a76-624a4fc1bae5"));
		}

		#endregion

	}

	#endregion

}

