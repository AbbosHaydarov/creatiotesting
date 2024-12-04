﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportLoggerSchema

	/// <exclude/>
	public class ImportLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportLoggerSchema(ImportLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128");
			Name = "ImportLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,88,75,111,227,54,16,62,123,129,253,15,172,246,34,3,134,220,94,179,177,131,60,156,173,129,221,34,141,179,237,161,40,2,70,30,59,234,74,162,151,162,156,184,65,254,123,135,47,137,122,88,86,218,160,237,94,108,147,156,25,206,124,243,164,83,154,64,182,161,33,144,27,224,156,102,108,37,130,115,150,174,162,117,206,169,136,88,26,92,70,49,204,147,13,227,226,237,155,167,183,111,6,121,22,165,107,178,216,101,2,146,247,181,53,178,198,49,132,146,47,11,62,64,10,60,10,27,52,23,84,208,96,241,53,62,143,35,72,69,227,248,6,30,157,205,115,150,36,44,117,215,28,170,171,224,226,172,220,88,199,236,142,198,71,71,154,45,248,200,214,107,220,46,207,93,35,145,245,146,134,130,241,8,50,164,64,154,119,28,214,168,58,33,231,49,205,178,35,162,205,150,66,128,43,130,241,120,76,142,179,60,73,40,223,77,205,250,52,37,81,154,9,154,34,134,108,69,196,125,148,145,80,242,19,252,193,17,92,196,34,186,139,129,172,24,39,177,86,136,68,74,50,50,226,102,162,113,182,226,199,142,252,223,46,96,69,243,88,156,69,233,18,217,124,177,219,0,91,249,115,87,177,225,136,252,132,78,36,19,146,226,151,60,117,15,135,191,163,152,77,126,23,71,161,209,202,61,70,19,171,54,14,164,135,75,28,46,35,136,151,8,196,21,143,182,84,128,194,160,1,130,218,152,113,142,230,97,44,101,116,13,4,253,184,137,145,65,26,213,180,106,176,209,226,72,38,184,4,227,22,157,194,248,39,205,123,99,88,165,207,6,7,174,227,236,225,111,93,117,205,30,156,107,218,200,86,24,244,18,213,218,241,199,40,19,199,37,100,115,188,124,74,110,35,187,46,116,182,244,115,220,36,183,232,116,35,231,29,164,75,141,173,89,27,160,49,227,240,230,92,6,163,68,91,185,171,3,236,115,14,40,61,171,198,29,134,6,82,2,144,144,195,106,226,185,126,245,200,120,186,7,31,181,179,161,156,38,42,124,38,94,158,1,71,117,82,157,197,222,244,51,174,73,88,108,4,199,99,69,221,206,172,145,184,146,59,32,128,103,222,84,171,65,54,197,86,69,128,9,76,87,87,255,115,69,1,82,213,103,100,104,203,43,76,42,149,27,67,162,98,120,80,147,51,169,73,82,190,26,52,164,77,26,242,20,225,243,55,224,141,23,131,57,36,147,41,57,12,83,87,224,94,113,182,1,46,176,130,246,41,18,38,24,48,31,234,149,175,35,115,91,115,174,88,74,19,202,4,36,39,39,196,119,150,88,19,225,161,85,130,63,28,182,167,254,172,165,22,153,136,90,131,48,191,6,209,10,239,105,43,91,228,59,188,51,143,99,27,133,131,1,7,145,243,180,163,200,169,232,146,95,91,202,81,11,198,101,5,157,212,28,19,252,202,248,23,213,168,131,107,200,88,206,67,88,104,82,35,163,93,27,3,0,11,105,28,253,73,177,11,45,148,149,190,185,102,68,170,145,57,50,58,123,13,142,44,104,3,38,248,133,198,57,120,18,202,126,166,42,75,213,199,62,232,157,218,220,5,187,75,214,13,121,181,216,191,46,220,174,22,175,13,181,35,187,11,230,134,121,22,226,254,105,203,4,26,13,203,195,137,235,84,241,125,57,107,100,53,203,116,99,227,137,160,99,223,147,174,202,90,175,118,135,46,173,213,178,218,178,122,97,47,104,156,70,108,170,171,9,85,57,20,171,169,171,12,81,89,136,236,216,160,235,80,177,154,52,172,63,81,99,181,37,213,66,131,89,178,17,59,227,228,172,46,113,66,182,50,8,220,110,180,207,132,79,32,238,89,191,177,237,3,8,213,184,192,150,101,172,141,228,107,14,124,215,183,67,69,110,89,45,250,189,149,213,28,23,116,240,102,211,121,235,165,199,99,123,94,25,163,52,45,42,171,127,153,219,126,150,44,206,48,44,247,76,251,54,43,213,225,100,90,106,190,90,59,28,42,164,131,121,42,152,239,205,30,67,136,11,81,158,57,91,128,240,61,137,191,55,194,33,45,206,147,52,40,156,232,91,23,14,93,226,162,236,61,138,54,158,138,122,129,33,174,8,88,8,26,126,185,225,88,122,14,243,151,180,69,59,235,23,24,135,38,204,31,105,186,140,113,166,81,37,166,111,40,100,120,45,86,182,105,231,136,8,91,124,244,157,242,53,206,134,45,195,203,150,69,75,115,185,42,130,62,187,251,3,157,69,180,104,139,7,230,104,136,200,41,138,153,149,71,10,201,182,17,200,2,159,148,238,192,20,50,137,118,169,70,15,191,173,163,141,74,49,193,57,196,241,53,172,128,3,78,117,238,129,117,155,59,67,162,75,130,211,229,210,87,209,86,137,72,219,149,12,23,170,225,40,165,75,182,150,244,220,199,33,24,166,155,142,98,248,111,56,197,24,82,247,141,123,246,15,188,226,61,125,255,124,68,158,126,120,246,92,200,53,164,11,228,67,219,231,75,247,104,86,64,242,138,126,177,237,185,204,48,60,111,187,179,36,248,214,92,105,175,175,251,81,163,52,75,69,36,118,11,186,133,87,73,51,103,76,105,186,85,223,21,32,205,28,85,120,252,63,58,183,222,166,95,234,108,231,189,99,53,249,111,220,62,71,69,246,36,176,115,212,225,238,151,35,223,40,156,125,193,67,145,246,125,223,217,137,92,43,145,71,119,142,194,139,101,162,89,19,244,127,129,190,12,220,229,221,236,17,194,28,103,244,230,27,96,150,102,57,135,139,179,114,11,95,141,214,62,201,108,6,167,201,158,201,100,63,54,46,56,245,0,183,193,89,139,206,125,5,199,226,136,143,35,165,65,160,237,1,191,180,108,216,124,24,180,194,45,147,61,147,19,89,15,152,37,45,90,229,191,38,164,43,252,75,150,134,247,90,74,101,208,65,164,75,36,203,119,94,15,31,84,199,65,131,212,65,168,204,19,113,223,83,202,236,185,91,184,243,23,182,89,23,62,75,23,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateErrorMessageTemplateLocalizableString());
			LocalizableStrings.Add(CreateErrorRowTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateErrorMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("34bc3758-0bb7-4dfe-81c4-7715e1fe3c4d"),
				Name = "ErrorMessageTemplate",
				CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c"),
				CreatedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128"),
				ModifiedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorRowTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a8dd96a0-8fc4-4545-9224-b9ae0b3ad9eb"),
				Name = "ErrorRowTemplate",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				CreatedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128"),
				ModifiedInSchemaUId = new Guid("49d90925-03e9-4c13-81c5-7b3859a39128")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49d90925-03e9-4c13-81c5-7b3859a39128"));
		}

		#endregion

	}

	#endregion

}

