﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StatusValidationRuleSchema

	/// <exclude/>
	public class StatusValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StatusValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StatusValidationRuleSchema(StatusValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdd50151-87d2-40cc-8e2c-6723fe839559");
			Name = "StatusValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,86,75,111,27,71,12,62,203,128,255,3,187,233,97,133,26,35,164,151,0,142,36,32,118,229,84,133,147,26,145,211,30,12,31,70,187,92,121,224,213,206,102,30,106,212,212,255,189,156,199,62,100,201,134,46,146,134,67,126,124,12,249,81,21,95,163,174,121,134,112,139,74,113,45,11,195,46,101,85,136,149,85,220,8,89,157,158,252,56,61,25,88,45,170,21,44,182,218,224,250,253,179,51,187,22,213,183,78,216,199,81,248,146,156,253,118,65,87,116,57,26,141,96,172,237,122,205,213,118,26,207,95,176,86,168,177,50,26,204,3,66,237,204,53,170,141,160,48,121,45,96,195,75,145,251,232,64,217,18,89,3,51,234,225,212,118,89,138,12,178,146,107,13,11,195,141,213,127,181,102,95,200,10,206,97,254,137,139,146,192,221,53,238,222,18,130,203,123,240,70,225,202,249,161,154,104,163,207,225,70,137,13,41,251,208,7,117,56,64,230,46,65,27,229,2,237,112,46,101,142,48,129,36,120,79,66,190,131,55,88,229,1,52,158,163,135,27,37,107,84,70,160,247,34,13,102,6,243,160,242,188,70,94,112,75,149,225,84,210,45,200,130,124,59,23,168,129,111,40,37,190,164,244,10,169,0,191,99,102,125,157,150,182,124,4,92,211,165,171,214,126,185,6,119,127,46,181,44,209,96,154,188,99,111,223,177,95,225,63,248,170,17,250,37,98,31,26,244,43,169,102,13,246,162,241,45,168,10,200,115,150,12,239,67,117,98,18,176,17,202,88,94,194,71,43,242,187,123,120,29,197,151,125,176,66,19,127,13,20,26,171,42,168,240,31,178,141,178,65,12,43,60,11,187,160,236,102,46,185,128,114,83,242,170,194,124,158,159,29,163,77,159,202,56,147,163,45,62,100,70,108,240,72,229,153,82,82,29,29,138,172,107,23,70,80,126,114,211,67,95,238,243,233,245,238,249,132,230,65,230,47,53,168,43,60,124,68,243,204,93,234,229,203,70,72,65,186,39,87,20,91,69,15,231,96,237,206,113,24,203,191,225,138,230,177,36,33,181,55,189,11,44,252,33,125,166,29,146,96,183,178,78,223,54,135,75,89,218,117,149,198,153,152,231,73,115,113,165,228,58,77,218,0,91,249,223,15,168,168,39,157,38,155,235,217,55,234,163,52,128,176,27,174,136,189,12,170,180,151,194,112,8,92,199,128,66,249,66,164,108,81,99,38,138,237,103,121,45,179,199,223,5,145,75,58,12,10,177,193,162,94,232,72,92,100,188,228,106,236,42,52,141,138,71,63,129,167,158,151,71,119,16,93,244,121,204,77,107,155,69,28,231,150,220,14,140,171,151,212,174,0,80,81,17,38,137,51,193,100,234,88,193,255,244,136,157,3,54,30,121,237,206,56,100,173,167,115,106,68,94,17,179,18,141,140,53,18,155,41,44,38,73,143,14,105,65,80,183,98,50,154,130,234,152,185,79,194,168,109,73,221,60,30,53,160,190,249,2,3,239,3,53,34,76,251,228,18,194,238,183,88,87,143,73,184,116,155,201,224,119,211,141,205,172,50,194,108,223,239,155,204,115,50,106,79,140,122,255,118,75,147,21,58,135,252,91,140,79,235,59,235,0,64,211,160,4,115,96,112,118,102,102,55,182,221,9,138,208,75,41,75,16,250,32,243,181,217,189,202,139,30,159,19,197,166,123,33,70,31,162,128,244,167,23,124,52,101,109,232,231,171,161,47,183,107,216,181,92,177,121,85,200,52,185,59,180,37,89,243,86,247,144,192,47,145,195,252,152,134,109,66,73,65,37,13,113,63,45,155,58,208,125,232,94,70,91,23,235,222,10,162,145,163,191,0,182,38,21,6,23,10,249,35,8,146,132,246,236,161,255,76,228,128,245,57,252,8,85,137,79,151,14,217,103,106,244,167,51,72,58,197,54,215,118,1,122,51,183,135,217,31,82,16,207,64,114,118,76,117,135,14,183,23,1,49,188,91,88,1,149,48,247,106,78,250,109,79,204,243,190,6,221,37,195,240,34,189,213,117,104,12,154,93,182,176,89,134,244,47,101,2,5,47,53,54,155,226,58,251,119,225,83,217,253,31,209,1,93,145,55,204,147,70,127,239,143,199,174,96,127,165,28,23,94,23,157,81,54,160,4,144,195,116,232,165,79,167,39,255,3,48,179,90,3,89,10,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateStatusValidationFailedLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateStatusValidationFailedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("85992a83-ec04-453e-82ba-ff4c8579627e"),
				Name = "StatusValidationFailed",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("cdd50151-87d2-40cc-8e2c-6723fe839559"),
				ModifiedInSchemaUId = new Guid("cdd50151-87d2-40cc-8e2c-6723fe839559")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdd50151-87d2-40cc-8e2c-6723fe839559"));
		}

		#endregion

	}

	#endregion

}

