﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExternalAccessRequestLogListenerSchema

	/// <exclude/>
	public class ExternalAccessRequestLogListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExternalAccessRequestLogListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExternalAccessRequestLogListenerSchema(ExternalAccessRequestLogListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e");
			Name = "ExternalAccessRequestLogListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,86,223,111,219,54,16,126,86,129,254,15,55,181,64,101,44,160,223,157,56,64,226,122,157,129,166,45,226,116,123,24,134,129,166,206,54,87,137,244,72,202,137,23,228,127,223,145,148,20,75,137,155,102,216,128,237,69,176,200,251,241,125,119,223,157,172,120,137,118,195,5,194,21,26,195,173,94,58,54,209,106,41,87,149,225,78,106,197,166,55,14,141,226,197,153,16,104,237,39,46,190,240,21,190,124,113,251,242,69,82,89,169,86,48,223,89,135,229,113,239,157,205,81,84,70,186,221,253,197,170,208,11,94,140,70,19,93,150,20,248,189,94,173,232,248,254,126,31,129,183,120,252,198,32,155,42,39,157,68,251,164,1,155,110,81,57,111,71,150,175,12,174,136,16,76,10,110,237,8,186,188,46,241,143,10,173,35,76,239,37,193,87,104,130,207,112,56,132,19,91,149,37,55,187,211,250,189,49,128,165,54,240,230,80,152,55,64,153,137,62,96,128,192,154,96,195,94,180,19,139,200,11,171,65,24,92,142,211,175,19,97,231,220,98,56,219,133,131,6,74,10,67,31,239,151,71,174,178,185,88,99,201,63,80,159,97,12,233,33,184,233,224,87,10,176,169,22,133,20,32,124,133,158,44,16,140,224,0,28,138,68,242,160,103,91,243,31,36,22,57,21,253,147,145,91,238,48,94,110,226,11,88,71,74,19,96,144,231,90,21,59,152,81,18,248,173,160,199,24,232,231,5,87,164,56,195,222,161,207,78,191,178,30,139,116,16,27,156,188,66,149,199,132,221,4,91,45,115,152,172,81,124,153,112,21,195,205,117,81,121,121,103,122,241,59,10,7,150,92,209,12,192,203,58,73,182,220,52,237,27,67,22,25,14,162,201,113,107,80,89,52,52,42,138,220,61,197,113,237,193,62,119,206,163,125,215,150,189,61,111,166,99,170,104,6,144,53,224,166,55,116,238,240,227,6,227,244,101,233,3,196,129,109,146,220,117,11,124,129,110,173,67,133,67,11,227,101,95,189,225,224,71,174,242,2,109,195,111,206,183,152,71,145,122,141,62,20,105,60,217,112,195,75,80,164,162,113,26,11,145,158,134,158,215,149,99,39,195,96,242,184,7,166,167,87,107,12,90,111,116,62,58,168,244,128,235,108,73,29,14,9,206,204,202,122,125,131,84,36,20,69,155,74,104,229,184,84,126,238,221,26,155,132,129,2,228,220,241,14,150,90,210,122,75,233,100,94,107,225,163,154,41,234,136,163,16,93,1,28,65,76,127,142,52,220,216,230,7,108,148,177,32,197,179,125,247,198,15,99,91,254,121,233,200,37,100,79,201,135,70,227,91,197,211,16,73,12,186,202,212,57,72,76,244,124,87,81,105,76,156,115,204,207,119,179,252,30,25,101,184,218,109,48,159,80,160,82,253,196,139,10,79,188,253,105,150,94,238,123,212,234,12,168,187,161,190,27,247,104,179,73,101,12,133,247,164,253,55,199,113,225,102,121,139,15,217,204,18,126,129,5,233,115,12,206,84,24,67,39,126,53,176,159,185,81,217,235,212,59,195,237,87,2,251,197,119,71,222,146,162,56,237,69,68,141,59,184,219,224,90,186,53,164,240,125,204,148,188,222,103,71,40,110,59,156,238,26,182,161,169,244,33,181,84,106,178,82,120,77,139,75,240,66,254,201,23,5,206,41,59,41,165,7,242,18,173,174,140,160,91,109,200,237,232,240,110,110,183,252,81,141,42,125,16,220,178,153,18,154,88,83,9,173,173,60,188,139,8,103,194,55,33,93,104,89,139,215,173,141,190,14,56,91,37,221,8,12,150,89,205,99,176,39,141,187,111,223,39,159,55,52,130,126,52,255,115,43,165,55,211,135,118,74,147,141,86,203,51,119,74,67,253,153,43,229,192,135,169,254,34,29,239,175,157,54,67,111,235,60,163,63,111,105,158,254,215,253,129,191,189,243,27,234,255,94,127,218,12,143,247,167,247,255,36,158,118,15,233,236,47,135,152,195,116,147,11,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIncorrectIssuedByMessageCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIncorrectIssuedByMessageCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a11562cc-42e9-443d-b91d-cd15870af6dd"),
				Name = "IncorrectIssuedByMessageCaption",
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				CreatedInSchemaUId = new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e"),
				ModifiedInSchemaUId = new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b61b3cd4-1448-48b6-904d-b7f6096e5b0e"));
		}

		#endregion

	}

	#endregion

}

