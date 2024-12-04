namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailSplitValidatorSchema

	/// <exclude/>
	public class BulkEmailSplitValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailSplitValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailSplitValidatorSchema(BulkEmailSplitValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9");
			Name = "BulkEmailSplitValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,85,75,79,219,64,16,62,27,137,255,48,13,151,32,161,228,94,18,35,129,40,202,1,181,226,209,43,218,172,199,201,138,245,58,221,71,80,132,248,239,157,245,174,29,199,177,41,135,114,48,241,60,190,121,125,51,86,172,64,179,97,28,225,9,181,102,166,204,237,228,166,84,185,88,57,205,172,40,213,233,201,251,233,73,226,140,80,43,120,220,25,139,197,101,231,157,236,165,68,238,141,205,228,14,21,106,193,247,54,109,88,141,36,39,205,153,198,21,89,195,141,100,198,124,135,107,39,95,111,11,38,228,227,70,10,251,155,73,145,49,91,234,202,116,58,157,194,204,184,162,96,122,151,198,119,255,87,185,130,93,51,11,66,109,203,87,132,109,240,243,184,218,73,36,49,24,74,5,205,164,134,153,182,112,54,110,41,5,39,11,38,49,3,94,161,13,230,145,80,11,232,217,228,253,67,160,204,40,241,95,90,108,153,197,160,220,132,23,208,200,178,82,201,29,60,83,120,106,165,10,173,129,23,119,240,126,57,224,181,120,220,32,23,185,224,77,252,107,39,100,134,122,118,231,68,150,194,203,182,35,143,64,103,168,178,144,94,4,14,5,46,110,149,43,80,179,165,196,217,34,66,146,205,3,117,40,133,107,102,240,80,102,224,29,86,104,47,225,99,24,165,147,96,244,12,233,165,16,181,152,125,14,220,80,128,72,99,181,227,84,143,111,104,21,46,88,116,39,191,31,253,222,5,108,9,156,90,71,13,20,36,100,138,120,92,230,228,134,232,229,249,124,52,48,211,209,52,245,180,56,230,69,144,108,152,102,5,40,218,141,249,232,112,108,163,244,198,105,141,202,130,151,3,223,207,183,78,96,50,155,86,238,253,104,221,233,141,210,248,3,114,42,167,195,225,3,168,56,138,129,130,198,29,182,29,102,125,241,79,90,117,243,130,57,40,39,229,57,248,237,79,146,14,121,73,123,196,102,111,213,131,114,36,186,186,2,133,111,67,117,68,171,113,39,224,121,8,208,71,216,249,241,74,76,22,74,216,74,59,142,142,131,172,28,242,174,219,213,70,249,232,223,180,154,202,247,104,215,101,246,85,22,199,68,40,133,229,14,120,228,148,31,186,249,42,49,141,111,220,19,26,187,200,70,233,179,18,127,28,109,65,70,48,190,80,237,247,160,178,0,138,65,143,178,158,68,15,65,53,90,167,149,73,31,194,127,48,142,115,164,131,168,209,56,73,7,54,7,38,37,84,78,104,81,27,96,58,222,219,9,252,180,107,212,111,194,248,19,22,188,233,224,19,149,131,47,197,170,193,91,28,94,150,165,108,26,48,246,4,132,86,49,23,80,58,11,180,226,254,243,81,129,221,211,117,102,43,172,201,216,150,69,158,134,41,211,10,33,227,107,24,119,46,93,243,65,232,225,79,13,154,80,149,227,111,213,214,53,153,157,55,202,110,204,202,238,214,203,66,228,36,9,101,66,206,164,241,95,57,47,34,190,52,207,125,106,159,157,207,38,209,33,190,126,150,109,171,133,255,49,241,168,166,131,27,180,253,75,16,164,109,225,199,95,252,96,46,249,90,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateStartTestEmailAlreadyRunMessageLocalizableString());
			LocalizableStrings.Add(CreateEmptyTemplateExistsMessageLocalizableString());
			LocalizableStrings.Add(CreatePingFailedMessageLocalizableString());
			LocalizableStrings.Add(CreateStartTestEmailDraftMessageLocalizableString());
			LocalizableStrings.Add(CreateNotEnoughActiveContactsMsgLocalizableString());
			LocalizableStrings.Add(CreateLicenseMissingMsgCodeLocalizableString());
			LocalizableStrings.Add(CreateNoRightToEditBulkEmailMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateStartTestEmailAlreadyRunMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9d2048d7-a814-47ba-a6c2-8a501b495421"),
				Name = "StartTestEmailAlreadyRunMessage",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyTemplateExistsMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ebf71544-37ed-4cfd-b943-cabcb0570e92"),
				Name = "EmptyTemplateExistsMessage",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePingFailedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4148a7e4-06eb-4663-93d8-a680071d97b7"),
				Name = "PingFailedMessage",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartTestEmailDraftMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("566936cf-99d2-4586-8ae5-d4296985935d"),
				Name = "StartTestEmailDraftMessage",
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotEnoughActiveContactsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("51ffb3e4-a062-b06b-63aa-f711ab96b0a7"),
				Name = "NotEnoughActiveContactsMsg",
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLicenseMissingMsgCodeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("67a1f8b1-b170-fddf-df53-dcf0eeadf065"),
				Name = "LicenseMissingMsgCode",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoRightToEditBulkEmailMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("90693f81-754f-2e62-f38b-ddc86be39d52"),
				Name = "NoRightToEditBulkEmailMsg",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"),
				ModifiedInSchemaUId = new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86edc02b-05eb-4bd5-83c4-35fe728e9be9"));
		}

		#endregion

	}

	#endregion

}

