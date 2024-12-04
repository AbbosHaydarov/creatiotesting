namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CompleteFileImportStageSchema

	/// <exclude/>
	public class CompleteFileImportStageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CompleteFileImportStageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CompleteFileImportStageSchema(CompleteFileImportStageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9010370-d507-4e89-b413-ae509e726a22");
			Name = "CompleteFileImportStage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,86,223,79,219,48,16,126,46,18,255,195,173,188,164,18,74,223,129,22,65,41,83,165,13,208,24,79,211,52,153,228,82,44,18,59,178,157,110,21,226,127,223,37,78,218,38,141,211,192,75,155,216,223,125,190,251,238,135,35,88,130,58,101,1,194,79,84,138,105,25,25,127,38,69,196,151,153,98,134,75,225,223,242,24,23,73,42,149,129,227,163,183,227,163,65,166,185,88,214,224,10,207,29,235,254,45,11,140,84,28,53,33,8,115,162,112,73,164,0,179,152,105,125,6,51,153,164,49,26,220,30,242,104,216,18,11,236,120,60,134,11,46,94,80,113,19,202,0,2,133,209,100,120,205,116,19,61,28,79,43,184,206,146,132,169,117,245,62,255,135,65,102,16,130,242,24,136,200,18,120,97,90,153,140,119,108,126,221,96,196,178,216,92,115,17,82,48,158,89,167,40,35,111,209,114,232,232,20,238,72,59,152,128,160,63,2,57,66,25,141,126,19,113,154,61,199,156,66,200,163,118,5,13,103,208,114,14,25,231,162,111,148,187,229,24,135,164,220,131,226,43,102,172,82,131,212,190,192,194,26,62,48,69,62,25,84,250,7,166,82,115,202,192,26,254,112,231,222,121,11,199,92,24,110,40,111,179,151,76,188,234,27,102,216,131,146,43,30,162,170,152,220,136,54,190,111,82,190,102,169,155,205,181,95,227,162,202,212,70,101,121,73,93,169,101,150,160,48,240,164,81,209,186,192,32,47,215,58,2,38,83,16,248,183,205,206,27,102,53,195,225,105,131,105,100,43,118,112,130,34,180,218,151,239,101,34,200,193,20,85,46,192,38,25,208,63,27,29,91,228,115,71,174,224,242,50,63,99,48,240,186,64,19,219,96,182,251,214,254,87,52,23,29,222,76,189,46,17,71,149,18,253,43,228,32,96,27,99,7,168,25,105,23,159,51,94,183,209,231,162,118,214,241,129,237,109,196,78,72,51,94,55,151,51,90,151,73,207,88,93,181,190,3,207,171,189,24,102,165,58,118,176,57,70,90,227,84,168,183,220,169,13,119,49,147,113,150,8,125,181,92,210,113,44,119,41,100,41,85,40,141,237,98,131,130,8,80,107,169,70,214,224,12,158,105,78,122,13,178,125,52,188,193,251,7,122,120,39,170,15,94,61,149,10,114,69,151,31,201,13,13,148,158,139,44,129,226,113,17,230,149,208,182,239,59,52,60,144,154,239,104,94,164,243,66,88,73,30,110,146,99,73,189,230,28,128,116,243,72,146,21,18,223,73,195,163,245,189,168,44,189,29,72,49,144,7,55,184,101,188,39,13,139,111,5,22,231,53,183,7,126,111,241,105,239,132,30,94,241,8,188,47,219,101,255,14,49,124,36,89,44,87,133,26,40,52,153,18,214,77,58,154,126,87,76,149,151,126,1,229,157,45,84,65,166,158,165,27,124,250,2,57,61,68,208,28,224,68,177,19,117,169,116,221,113,223,6,59,23,161,87,53,109,155,188,93,233,233,161,244,142,200,213,252,204,63,116,178,56,182,62,185,175,18,255,41,13,89,91,193,116,152,88,103,243,178,223,49,243,203,22,160,86,38,215,23,97,141,198,61,212,75,178,190,68,174,121,217,151,230,189,119,115,74,67,85,129,225,39,231,75,101,222,61,98,46,97,33,200,87,74,116,57,4,251,228,186,49,29,246,18,103,219,105,155,252,150,144,203,181,186,10,180,246,31,71,199,103,8,93,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCompleteRemindingSubjectLocalizableString());
			LocalizableStrings.Add(CreateNotImportedRowsCountMessageTemplateLocalizableString());
			LocalizableStrings.Add(CreateCompleteRemindingDescriptionTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCompleteRemindingSubjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6f65dc87-b8f6-49d8-8bf6-3ac2dbbdbbb6"),
				Name = "CompleteRemindingSubject",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22"),
				ModifiedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotImportedRowsCountMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("844066a9-4ae1-4da8-a4c2-43d603e52b7d"),
				Name = "NotImportedRowsCountMessageTemplate",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22"),
				ModifiedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCompleteRemindingDescriptionTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a5398abd-87e5-4737-9e25-5cb7b840b6bb"),
				Name = "CompleteRemindingDescriptionTemplate",
				CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab"),
				CreatedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22"),
				ModifiedInSchemaUId = new Guid("f9010370-d507-4e89-b413-ae509e726a22")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9010370-d507-4e89-b413-ae509e726a22"));
		}

		#endregion

	}

	#endregion

}

