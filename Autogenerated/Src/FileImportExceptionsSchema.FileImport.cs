namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportExceptionsSchema

	/// <exclude/>
	public class FileImportExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportExceptionsSchema(FileImportExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065");
			Name = "FileImportExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,82,77,107,194,64,16,61,43,248,31,134,244,162,80,146,187,85,47,106,169,208,47,218,210,251,24,39,186,144,221,13,59,27,172,45,254,247,78,62,180,90,115,40,20,241,146,176,179,239,189,121,51,251,12,106,226,12,99,130,55,114,14,217,38,62,28,91,147,168,101,238,208,43,107,194,91,149,210,76,103,214,249,78,251,171,211,110,229,172,204,18,94,55,236,73,223,236,207,135,108,173,173,145,27,185,187,114,180,20,13,24,167,200,220,135,169,206,252,230,142,112,65,110,250,17,83,86,232,151,184,40,138,96,192,185,214,232,54,163,250,252,182,34,160,29,10,252,10,61,40,150,191,179,107,3,235,21,25,72,196,25,44,44,49,24,235,33,182,198,163,50,128,176,42,59,132,59,221,232,64,56,203,231,169,138,33,46,252,52,218,129,62,60,230,105,250,228,202,203,3,151,45,153,93,190,63,35,89,195,222,229,177,183,78,38,123,46,117,43,196,239,97,202,194,216,17,122,113,170,132,133,70,214,109,19,240,155,140,4,73,4,177,163,100,24,52,249,9,162,81,49,200,233,36,85,37,67,135,26,140,60,226,48,96,177,130,75,10,70,47,196,54,119,210,163,174,132,131,168,196,149,180,122,3,77,189,186,179,29,243,181,34,238,4,122,5,177,213,135,57,50,117,13,173,225,222,198,152,170,79,156,167,2,117,242,254,221,26,121,13,193,79,94,246,194,28,72,253,132,195,97,147,137,7,98,46,60,191,99,154,83,208,235,65,145,185,214,182,94,62,153,69,181,255,242,92,85,127,21,155,50,55,65,143,231,75,220,66,212,255,152,182,35,35,23,207,218,145,155,179,38,109,114,216,233,50,57,59,178,240,223,148,109,191,1,54,101,250,130,56,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptyHeaderExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateEmptyDataExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptyHeaderExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e8ba9ed7-7f74-43c3-9ac9-e0f6b8e886fc"),
				Name = "EmptyHeaderExceptionMessage",
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065"),
				ModifiedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyDataExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1d2b6f72-8681-4848-a93e-39afafa9f2f2"),
				Name = "EmptyDataExceptionMessage",
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065"),
				ModifiedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8637c44-884d-415b-8ad0-91caafbca065"));
		}

		#endregion

	}

	#endregion

}

