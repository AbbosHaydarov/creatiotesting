namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StoppedBulkEmailCampaignEventHandlerSchema

	/// <exclude/>
	public class StoppedBulkEmailCampaignEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StoppedBulkEmailCampaignEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StoppedBulkEmailCampaignEventHandlerSchema(StoppedBulkEmailCampaignEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d");
			Name = "StoppedBulkEmailCampaignEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,85,93,79,219,48,20,125,159,196,127,240,202,75,34,85,238,158,105,169,68,89,129,72,160,34,149,141,135,105,15,110,124,219,90,56,78,103,59,133,110,236,191,239,58,95,36,117,90,144,230,151,40,190,31,190,231,220,123,108,197,18,48,27,22,3,121,0,173,153,73,151,150,94,166,106,41,86,153,102,86,164,234,228,211,159,147,79,4,87,102,132,90,145,249,206,88,72,134,254,22,70,73,9,177,11,49,244,26,20,104,17,119,185,221,10,245,171,181,223,60,55,73,82,117,208,168,129,94,178,100,195,196,234,67,62,116,186,5,101,111,152,226,18,244,177,128,175,147,150,213,237,85,57,230,241,26,18,70,206,73,59,115,219,140,209,69,252,169,134,21,194,39,151,146,25,115,70,230,54,221,108,128,79,50,249,52,77,152,144,85,84,179,174,42,116,147,45,164,136,137,1,38,129,147,216,37,248,80,60,57,35,93,219,19,102,160,79,162,153,170,140,223,153,20,156,89,232,23,199,185,213,176,78,96,137,248,230,108,11,133,25,59,254,230,87,161,186,3,187,78,57,226,186,215,98,139,169,154,62,155,98,139,44,210,84,146,107,192,50,76,94,242,163,176,235,185,101,54,51,193,117,38,248,143,159,100,81,161,41,182,35,142,101,78,85,150,128,102,11,9,35,231,53,38,72,170,144,17,55,161,171,164,58,195,45,177,36,193,231,111,6,52,142,168,42,134,13,103,205,70,230,10,48,155,134,169,114,89,120,208,171,73,115,36,246,66,242,250,90,39,165,17,214,182,177,187,32,244,210,187,165,1,19,41,178,100,210,64,57,23,213,250,219,254,221,50,141,13,115,51,143,3,162,224,153,204,243,159,160,93,95,136,67,150,41,27,40,20,90,186,12,234,194,104,196,195,144,94,233,52,241,76,97,232,151,69,31,215,160,225,64,150,72,5,168,190,44,81,244,158,105,244,176,160,77,80,147,216,149,237,66,113,63,87,213,146,67,25,189,222,33,131,204,148,176,135,62,57,121,5,38,135,143,12,21,84,209,233,11,196,153,133,121,204,36,211,35,161,236,56,8,247,98,203,22,52,195,199,228,75,195,169,209,8,127,6,253,113,194,9,169,65,34,33,65,135,194,77,254,241,6,162,172,164,176,210,43,153,62,79,37,36,168,51,67,103,203,135,221,6,70,119,76,63,129,197,123,35,207,94,90,17,18,45,135,225,133,156,143,201,11,109,187,33,115,109,52,62,138,109,42,56,169,84,91,222,4,121,108,224,21,89,83,141,216,144,103,15,109,11,233,62,215,46,120,237,169,181,72,211,161,98,28,115,20,113,135,108,238,208,15,225,225,220,27,36,167,33,63,23,118,195,52,47,49,56,193,31,245,157,104,96,79,104,141,248,158,248,250,111,215,194,176,227,86,240,65,28,145,247,251,194,198,87,209,176,21,20,68,220,198,191,231,86,99,81,216,144,172,22,225,71,238,231,176,113,225,86,171,215,108,231,76,97,177,218,77,70,21,222,219,135,215,110,32,189,224,188,156,11,188,93,34,181,76,131,178,214,126,237,217,182,223,194,22,36,125,100,90,225,41,7,7,239,20,20,47,110,250,227,151,127,254,80,53,93,6,131,1,25,153,44,73,152,222,141,219,219,5,9,134,48,20,179,35,133,216,53,179,68,24,162,153,48,248,206,45,242,119,135,196,101,217,165,206,136,193,135,136,211,189,19,6,254,17,229,163,153,75,101,214,120,196,124,137,116,11,105,120,128,138,22,162,247,48,32,57,117,253,219,154,247,10,154,113,205,165,239,23,95,21,248,191,165,251,93,172,205,109,19,110,255,3,98,75,40,122,251,9,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateStoppedEmailOnStartingCampaignLocalizableString());
			LocalizableStrings.Add(CreateActiveEmailsOnStoppedCampaignMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateStoppedEmailOnStartingCampaignLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("648f590e-70c3-a25b-fff8-a0b67cd53c49"),
				Name = "StoppedEmailOnStartingCampaign",
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb"),
				CreatedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d"),
				ModifiedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateActiveEmailsOnStoppedCampaignMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa1b197a-4713-f78b-4c1e-2b5e403d60c6"),
				Name = "ActiveEmailsOnStoppedCampaignMessage",
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb"),
				CreatedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d"),
				ModifiedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d"));
		}

		#endregion

	}

	#endregion

}

