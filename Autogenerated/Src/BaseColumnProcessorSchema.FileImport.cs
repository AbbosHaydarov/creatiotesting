﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseColumnProcessorSchema

	/// <exclude/>
	public class BaseColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseColumnProcessorSchema(BaseColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039");
			Name = "BaseColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,88,75,111,27,55,16,62,43,64,254,3,171,246,32,1,194,234,30,75,91,164,178,156,10,109,220,192,142,219,99,65,237,142,100,54,251,80,72,174,82,213,240,127,239,240,177,22,185,47,173,21,163,1,122,145,118,201,225,204,240,155,247,102,52,5,177,163,17,144,143,192,57,21,249,70,6,139,60,219,176,109,193,169,100,121,22,92,177,4,86,233,46,231,242,245,171,135,215,175,6,133,96,217,150,220,30,132,132,244,162,242,142,71,147,4,34,117,78,4,239,32,3,206,162,35,141,43,33,77,243,172,121,135,67,219,122,176,204,36,147,12,4,18,32,201,247,28,182,40,136,44,18,42,196,27,242,19,21,128,226,139,52,251,192,243,8,132,200,185,38,155,78,167,100,38,138,52,165,252,16,218,119,67,71,118,37,33,89,227,97,18,41,70,65,121,100,234,156,217,21,235,132,69,132,174,133,228,52,146,134,178,73,34,121,67,86,71,192,188,205,37,231,57,159,120,219,28,168,180,28,4,74,65,116,241,247,120,47,4,81,210,76,226,221,144,133,68,88,33,54,20,187,242,149,68,138,134,160,86,26,173,195,14,238,86,49,18,239,128,203,195,53,154,150,204,201,208,46,15,47,58,142,222,192,6,56,100,17,220,70,247,144,210,6,46,117,10,197,80,235,11,89,108,84,246,245,39,87,12,146,88,107,207,246,120,209,82,119,253,82,10,254,51,170,97,244,30,31,232,22,78,112,215,232,240,34,146,57,175,3,84,181,185,49,186,134,91,16,166,97,69,143,207,55,68,34,54,72,9,104,124,14,155,249,176,193,164,195,105,168,124,162,238,20,102,101,71,57,77,73,134,40,205,135,133,0,142,122,101,38,2,134,225,29,190,43,156,237,66,48,155,106,234,208,55,68,131,204,209,157,199,137,248,140,199,100,30,146,10,197,188,66,115,2,61,107,93,140,165,158,216,121,1,67,48,44,209,215,83,99,168,22,116,142,23,180,166,94,180,89,154,168,180,50,24,108,65,218,167,1,219,144,81,187,103,144,239,230,36,43,146,100,92,146,15,56,200,130,103,221,206,164,232,30,205,223,234,6,68,94,112,244,101,244,30,197,80,216,255,121,5,214,224,143,156,127,210,233,49,168,28,177,12,59,148,68,29,225,11,249,53,143,104,194,254,161,235,4,79,42,24,70,86,214,132,52,58,219,196,222,104,48,172,157,20,42,187,54,11,11,126,167,73,1,195,177,213,170,39,28,26,141,199,14,171,95,82,73,201,94,177,54,129,82,100,236,51,62,179,24,48,17,111,24,240,147,166,127,202,152,239,10,22,107,126,90,83,155,146,200,3,65,163,95,144,46,29,170,49,116,74,98,37,46,42,175,190,192,182,232,88,238,241,130,42,50,116,218,183,121,203,148,0,80,91,134,224,103,154,197,9,240,89,221,42,122,251,45,223,138,144,184,203,39,98,242,61,200,251,60,126,102,50,51,38,238,155,160,12,181,113,150,208,198,180,177,47,203,54,57,79,105,45,77,105,22,198,159,68,104,202,86,41,115,54,45,215,125,11,184,181,207,234,105,94,70,238,142,86,194,178,210,207,58,171,169,144,241,206,219,8,95,101,49,252,141,33,229,208,219,104,208,59,54,106,110,117,132,86,200,244,175,246,244,139,222,120,146,24,132,100,153,129,163,39,182,42,38,228,193,84,199,97,168,91,149,3,17,250,181,142,104,219,65,115,167,202,241,35,224,29,92,94,210,180,222,245,251,152,249,242,72,239,89,220,89,31,45,157,107,18,247,206,214,120,238,190,213,191,142,12,246,79,207,246,33,87,185,210,157,196,47,112,64,63,121,7,114,37,176,61,81,86,189,100,98,151,208,131,117,85,79,193,6,69,198,165,203,149,221,16,114,115,169,2,92,178,36,230,128,237,163,234,156,2,181,227,145,234,171,180,211,87,136,236,209,99,69,55,247,170,221,253,72,48,106,194,213,69,241,100,180,92,177,44,110,138,149,231,149,137,154,15,59,156,158,124,216,119,197,22,239,253,216,44,182,205,117,117,49,82,119,48,50,108,53,26,181,57,141,163,130,118,48,87,165,58,151,113,23,112,104,152,70,220,98,216,208,34,145,170,193,178,70,58,39,237,124,179,236,177,232,117,163,54,115,236,25,151,5,77,200,37,211,69,26,175,58,51,45,227,132,228,235,191,144,38,60,229,208,47,155,65,12,55,149,70,58,52,42,91,207,193,67,211,220,53,169,247,58,182,247,236,140,171,75,144,192,83,150,169,41,101,99,149,247,205,72,152,64,72,117,194,34,177,201,88,207,236,1,190,65,157,42,205,62,139,66,28,217,96,54,141,194,201,25,23,108,243,159,117,158,39,29,169,188,189,240,144,94,30,83,142,25,123,202,81,185,38,17,152,113,55,52,17,182,173,182,227,206,174,129,176,33,169,235,12,242,161,133,86,39,19,59,15,181,241,11,86,226,58,151,215,56,15,253,198,151,233,78,30,70,227,167,193,168,85,221,86,102,203,207,24,137,77,21,66,151,41,171,142,113,101,59,101,52,203,208,132,93,125,253,45,118,193,194,182,211,120,61,236,240,247,24,60,42,27,152,180,35,244,136,215,183,175,133,36,121,250,64,49,12,59,221,216,78,173,62,149,147,140,114,172,13,74,57,183,115,31,89,155,122,114,38,229,96,107,57,186,126,2,229,4,96,199,192,142,25,225,41,147,44,92,230,170,137,245,132,89,162,227,116,105,165,26,131,24,187,184,252,127,12,86,217,62,255,4,35,121,207,4,118,48,165,184,241,127,108,25,183,176,60,7,241,19,89,218,128,86,59,245,195,240,161,101,68,120,244,54,110,242,47,102,117,56,105,255,46,225,65,117,122,106,115,134,197,115,147,123,68,51,178,134,242,51,11,196,47,221,4,244,206,204,86,3,229,221,42,31,231,248,136,223,33,170,25,216,140,196,101,249,214,105,120,65,75,36,71,61,147,107,89,111,171,5,179,35,21,121,164,170,211,238,236,185,124,220,27,154,175,115,81,63,187,93,253,26,180,171,40,247,106,90,77,180,232,182,215,220,191,108,74,230,13,109,176,123,242,194,205,244,222,209,210,60,85,179,157,206,47,231,125,186,248,31,141,215,205,134,109,255,108,242,181,13,140,173,29,189,50,170,167,133,141,149,185,175,142,123,202,248,71,15,31,172,48,113,63,12,156,26,181,203,210,87,151,107,225,116,152,137,224,109,124,210,131,59,210,186,89,245,23,113,237,95,227,112,194,95,38,27,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateColumnProcessErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateColumnProcessErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f5c3f411-8079-4921-aed5-e94df64178aa"),
				Name = "ColumnProcessErrorMessage",
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039"),
				ModifiedInSchemaUId = new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039"));
		}

		#endregion

	}

	#endregion

}

