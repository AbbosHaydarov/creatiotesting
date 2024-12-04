namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportExceededAvailableKeyColumnsLimitExceptionSchema

	/// <exclude/>
	public class FileImportExceededAvailableKeyColumnsLimitExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportExceededAvailableKeyColumnsLimitExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportExceededAvailableKeyColumnsLimitExceptionSchema(FileImportExceededAvailableKeyColumnsLimitExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d5da20b-35dc-492e-8f0d-9ec207d9a43d");
			Name = "FileImportExceededAvailableKeyColumnsLimitException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,75,107,194,64,16,62,71,232,127,24,210,30,20,36,185,219,82,144,80,65,42,165,212,210,251,186,153,196,165,251,98,31,213,84,252,239,221,100,163,70,122,243,148,157,157,153,239,149,149,68,160,213,132,34,124,162,49,196,170,202,101,133,146,21,171,189,33,142,41,153,45,24,199,165,208,202,56,56,220,141,238,70,137,183,76,214,176,110,172,67,241,120,174,135,235,66,40,25,58,161,119,111,176,14,32,80,112,98,237,12,46,88,47,123,138,88,98,57,255,33,140,147,13,199,87,108,10,197,189,144,118,197,4,235,250,186,229,239,96,242,60,135,39,235,133,32,166,121,238,235,243,4,48,11,110,107,212,78,194,110,139,50,156,17,4,217,51,225,5,240,22,11,84,5,228,196,3,223,216,0,141,76,237,38,246,66,160,244,166,245,81,5,137,192,162,95,165,49,134,96,179,147,136,124,160,66,251,13,103,20,104,235,237,22,107,48,131,185,214,1,162,227,24,56,78,98,208,151,244,130,2,103,60,117,202,132,16,223,59,218,56,209,75,184,129,124,188,252,64,171,188,161,184,14,176,164,70,176,241,59,13,7,195,66,18,225,247,106,78,28,190,133,39,50,109,201,18,38,93,31,93,161,188,116,147,25,108,136,197,113,156,207,22,202,8,226,198,18,119,176,82,148,112,246,219,242,175,187,102,152,137,224,29,78,122,131,222,52,174,62,164,255,176,109,118,24,74,61,102,95,132,123,76,39,211,43,173,147,246,245,38,201,177,79,22,101,25,195,237,234,120,123,125,121,252,3,64,70,145,26,27,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateErrorMessageTemplateForTypedColumnsLocalizableString());
			LocalizableStrings.Add(CreateErrorMessageTemplateForTextColumnsLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateErrorMessageTemplateForTypedColumnsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f54bb6d5-7423-9f20-9efd-02634cb9b91c"),
				Name = "ErrorMessageTemplateForTypedColumns",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("7d5da20b-35dc-492e-8f0d-9ec207d9a43d"),
				ModifiedInSchemaUId = new Guid("7d5da20b-35dc-492e-8f0d-9ec207d9a43d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorMessageTemplateForTextColumnsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fbf8a93f-3b25-7e14-f58f-689472d1727b"),
				Name = "ErrorMessageTemplateForTextColumns",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("7d5da20b-35dc-492e-8f0d-9ec207d9a43d"),
				ModifiedInSchemaUId = new Guid("7d5da20b-35dc-492e-8f0d-9ec207d9a43d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d5da20b-35dc-492e-8f0d-9ec207d9a43d"));
		}

		#endregion

	}

	#endregion

}

