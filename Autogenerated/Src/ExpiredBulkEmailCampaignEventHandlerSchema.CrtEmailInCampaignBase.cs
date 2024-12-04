namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExpiredBulkEmailCampaignEventHandlerSchema

	/// <exclude/>
	public class ExpiredBulkEmailCampaignEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExpiredBulkEmailCampaignEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExpiredBulkEmailCampaignEventHandlerSchema(ExpiredBulkEmailCampaignEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756");
			Name = "ExpiredBulkEmailCampaignEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,85,77,79,219,64,16,189,35,241,31,182,225,98,75,104,211,51,9,145,8,24,106,41,52,173,18,202,121,98,143,147,21,235,117,216,93,7,210,194,127,239,248,179,118,156,16,164,238,37,202,206,215,155,55,111,214,10,98,52,107,8,144,205,81,107,48,73,100,249,117,162,34,177,76,53,88,145,168,211,147,63,167,39,140,78,106,132,90,178,217,214,88,140,7,221,43,138,146,18,131,44,196,240,59,84,168,69,176,207,109,34,212,115,235,190,89,55,142,19,117,208,168,145,95,67,188,6,177,252,148,15,247,54,168,236,55,80,161,68,253,81,192,205,184,101,205,238,170,28,179,96,133,49,176,75,214,206,220,54,83,116,17,127,166,113,73,237,179,107,9,198,92,48,239,117,45,52,134,227,84,62,121,49,8,89,69,53,113,85,161,235,116,33,69,192,12,130,196,144,5,89,130,79,197,179,11,182,239,122,12,6,207,153,63,85,149,241,23,72,17,130,197,243,162,92,118,26,214,49,70,212,223,12,54,88,152,105,226,255,252,170,174,238,209,174,146,144,250,250,161,197,134,82,53,125,214,197,21,91,36,137,100,119,72,48,76,137,62,71,110,28,223,83,105,140,26,22,18,135,119,169,8,71,140,136,19,210,15,141,155,85,171,242,100,71,68,204,249,242,96,80,147,12,85,33,40,210,147,245,205,45,130,77,53,122,42,203,18,58,189,185,22,203,37,234,188,194,124,165,19,107,37,205,239,103,138,41,246,92,246,246,86,151,224,190,241,226,181,221,58,110,167,88,118,52,82,90,197,34,144,6,75,37,84,231,189,253,119,3,154,70,148,169,156,36,161,240,133,205,242,63,78,27,173,75,178,74,149,117,20,173,86,18,57,245,252,184,31,186,46,191,213,73,220,49,185,110,23,22,127,92,161,198,3,89,124,229,208,190,165,177,226,63,64,147,135,69,109,156,154,210,125,217,174,84,216,205,149,15,41,95,243,27,26,95,150,215,76,208,152,169,246,158,83,144,157,18,78,230,53,23,49,242,7,27,124,79,94,136,79,48,37,9,131,46,85,57,30,147,147,65,124,21,196,81,73,12,82,139,179,0,36,232,161,80,118,228,184,59,177,229,64,154,225,35,246,181,225,244,190,79,123,93,137,145,106,234,86,137,22,103,207,102,155,252,167,35,139,18,65,97,229,183,50,121,241,36,198,180,95,134,79,163,249,118,141,195,123,208,79,104,73,111,121,246,210,74,173,240,82,18,175,236,114,196,94,121,219,141,70,119,172,139,77,34,66,86,109,107,115,135,156,14,200,154,98,234,141,248,237,116,219,234,116,151,227,44,120,181,179,165,69,146,206,238,214,178,26,236,89,212,221,28,31,108,216,241,221,162,79,145,129,37,22,56,38,193,239,153,213,68,29,177,145,214,123,240,153,71,209,109,188,114,213,233,53,81,78,21,189,117,148,185,10,238,237,182,214,230,142,95,133,97,57,18,218,20,95,69,137,83,34,61,175,61,219,246,9,110,80,242,71,208,138,170,28,156,249,25,170,176,120,92,63,126,111,243,111,67,211,165,223,239,179,161,73,227,24,244,118,212,190,46,40,48,12,104,127,50,74,152,93,129,101,194,48,13,194,208,167,101,145,63,245,44,40,97,151,18,103,134,222,254,144,239,84,232,119,75,148,223,169,92,165,211,198,119,163,171,206,253,26,30,28,160,162,213,209,177,30,136,156,26,255,166,230,189,106,205,88,208,150,31,7,95,1,252,95,232,221,41,214,230,182,137,174,255,2,87,240,240,89,110,9,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExpiredEmailOnSavingCampaignLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExpiredEmailOnSavingCampaignLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c4cf7837-443a-45c8-e95c-827f665cb8d6"),
				Name = "ExpiredEmailOnSavingCampaign",
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb"),
				CreatedInSchemaUId = new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756"),
				ModifiedInSchemaUId = new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfe2abbc-c116-4dda-8eb1-abdef10b7756"));
		}

		#endregion

	}

	#endregion

}

