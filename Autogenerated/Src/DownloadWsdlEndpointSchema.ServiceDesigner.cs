﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DownloadWsdlEndpointSchema

	/// <exclude/>
	public class DownloadWsdlEndpointSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DownloadWsdlEndpointSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DownloadWsdlEndpointSchema(DownloadWsdlEndpointSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654");
			Name = "DownloadWsdlEndpoint";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0cd720a-279e-436c-a704-8c755267ad15");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,88,91,79,219,72,20,126,118,165,254,135,105,186,15,70,138,172,238,107,89,168,82,8,109,86,64,81,147,46,149,16,66,142,61,36,163,142,237,116,102,12,100,43,254,251,158,51,23,123,124,11,180,187,210,242,128,236,241,185,95,190,115,38,121,156,81,185,137,19,74,22,84,136,88,22,183,42,58,42,242,91,182,42,69,172,88,145,71,115,42,238,88,66,143,169,100,171,156,138,151,47,126,188,124,241,242,69,80,74,150,175,200,124,43,21,205,246,91,239,32,129,115,154,32,187,140,62,80,224,98,73,135,230,148,229,223,59,135,231,84,69,31,149,218,116,62,88,43,206,138,148,242,157,31,163,9,232,189,211,166,239,166,187,164,203,14,193,130,62,168,238,225,90,208,56,133,131,104,17,203,111,178,243,253,107,198,91,206,248,161,204,50,223,16,255,139,160,209,73,156,168,66,48,42,7,41,124,147,33,47,74,0,71,31,49,120,83,43,131,239,175,5,93,65,8,200,17,143,165,124,75,142,139,251,156,23,113,10,182,206,147,53,205,226,233,67,66,55,24,36,77,189,41,151,156,37,36,65,226,29,180,228,45,241,248,2,83,8,181,42,200,182,18,37,122,4,26,47,180,72,67,97,197,15,11,14,129,17,253,129,90,148,241,138,238,33,83,240,150,44,99,73,67,119,70,64,93,16,60,254,154,196,113,109,56,97,57,20,100,245,218,167,107,220,166,105,232,126,77,243,212,184,172,223,205,105,235,176,21,254,202,190,139,88,72,186,35,246,3,132,255,50,240,3,82,127,53,234,207,19,247,63,135,220,149,198,165,76,249,52,79,55,5,203,149,166,187,178,45,229,186,233,26,207,38,114,3,208,3,13,180,1,228,88,50,206,212,246,51,253,94,50,65,51,154,43,25,250,47,216,139,228,128,60,193,130,84,145,61,72,247,174,135,154,204,55,15,178,252,30,66,98,237,235,201,115,171,152,78,24,167,210,102,70,32,230,209,118,21,89,138,192,73,234,100,80,19,132,179,105,94,102,84,196,75,78,255,48,73,60,36,165,224,210,38,33,8,230,42,78,190,129,207,57,189,39,250,217,145,133,154,12,1,169,202,149,211,209,160,51,111,78,220,138,170,22,139,53,255,152,233,161,17,139,173,101,196,178,80,87,215,135,228,230,22,45,53,92,174,249,7,137,181,87,228,192,113,145,119,239,72,104,31,141,15,131,172,225,30,58,211,176,233,148,73,85,185,113,179,17,69,2,21,75,83,173,163,162,53,22,53,72,47,26,148,218,154,38,179,49,171,117,102,236,243,5,213,38,245,55,67,85,30,39,140,242,20,1,192,24,222,44,12,169,160,74,19,130,179,245,136,51,40,80,114,179,174,158,247,123,40,113,230,21,57,223,146,190,226,184,97,217,166,16,234,28,106,92,158,227,6,97,236,190,186,38,63,200,200,124,27,141,225,41,79,120,153,210,17,121,108,104,72,16,175,136,69,11,83,135,167,69,162,71,246,68,193,233,178,84,20,165,130,208,145,108,124,30,245,200,193,198,57,139,31,88,86,102,70,150,60,42,74,56,59,32,191,191,121,243,28,250,57,251,155,190,223,42,237,4,176,232,191,253,221,161,62,163,106,93,252,68,172,63,80,85,191,133,174,173,216,45,228,191,206,2,121,5,65,44,57,175,186,78,80,85,138,188,147,40,172,3,203,253,74,67,130,217,34,182,209,66,108,65,81,56,234,195,150,90,61,36,166,40,27,233,223,171,52,250,214,152,74,244,205,246,181,15,216,246,216,27,137,190,18,2,75,103,186,80,104,106,210,240,5,144,196,141,144,135,76,47,59,104,155,23,171,250,52,154,201,115,136,212,39,113,185,102,138,206,113,127,133,54,105,197,173,219,72,190,3,95,143,139,4,140,2,71,31,170,167,3,82,157,70,122,182,121,42,45,179,149,93,241,68,176,23,39,80,37,49,78,9,51,216,130,232,114,77,5,13,41,215,147,64,119,126,187,95,112,199,86,49,203,165,163,138,240,56,194,58,231,250,105,81,156,22,247,84,128,87,78,232,28,40,19,229,75,117,172,85,211,132,59,154,105,175,105,28,111,211,160,192,238,161,43,201,166,13,207,99,142,254,138,121,73,155,106,155,237,140,108,205,19,76,108,161,76,110,167,217,70,109,13,250,117,10,43,150,219,60,33,184,143,251,5,245,69,48,155,45,87,72,165,96,174,44,238,98,65,50,211,247,19,206,33,184,105,221,254,144,121,96,215,209,135,183,116,174,153,195,209,217,0,249,200,22,3,138,132,13,188,16,174,227,128,203,80,13,8,156,246,18,59,113,74,108,93,9,163,228,70,47,182,16,196,48,4,120,244,25,238,111,0,108,244,204,44,82,0,220,230,29,152,226,251,152,41,79,14,220,197,212,4,35,23,98,111,64,180,96,124,51,27,96,163,83,250,33,113,146,116,177,34,251,71,152,9,84,72,247,126,74,243,149,90,91,110,108,80,143,251,112,0,99,171,38,13,212,90,20,247,186,73,135,246,73,75,104,82,25,157,20,34,139,85,56,148,194,241,128,194,177,231,211,88,215,131,21,235,220,54,112,16,84,206,78,115,89,10,58,47,19,28,203,176,182,168,18,6,74,10,248,98,233,45,2,152,216,118,66,244,25,66,52,1,54,52,217,132,218,161,14,129,10,79,214,36,28,90,241,221,174,237,34,67,125,180,178,188,195,212,122,171,121,234,54,228,98,216,95,179,38,58,99,16,237,105,238,0,186,110,171,158,218,182,95,32,32,69,41,18,3,57,94,231,113,67,142,35,192,48,64,125,253,54,58,109,159,202,232,135,47,225,209,96,136,25,251,65,173,162,228,110,62,117,36,132,95,36,21,144,141,220,252,254,0,9,49,226,230,48,34,241,158,97,130,6,14,44,182,27,72,170,198,221,113,215,188,38,220,27,149,62,16,61,189,25,120,215,176,171,79,27,152,126,104,142,127,233,8,174,224,210,62,203,239,138,111,52,52,108,184,240,92,124,154,47,96,68,67,115,46,104,182,225,24,116,56,5,123,155,59,187,173,55,160,116,253,111,114,11,196,32,213,98,129,57,138,254,148,112,159,210,26,237,158,234,161,231,144,96,39,85,227,106,47,133,205,56,236,124,254,85,1,115,253,208,32,183,137,106,93,57,188,123,3,178,120,160,133,196,79,89,85,221,75,76,151,2,23,220,127,109,110,31,59,96,122,191,6,17,122,125,240,36,70,250,70,18,153,93,241,144,188,169,129,169,26,29,28,228,246,50,93,20,155,10,14,220,102,226,83,53,87,255,122,214,131,200,122,75,129,166,134,115,150,151,182,209,43,36,114,6,224,133,197,250,93,97,121,115,200,161,188,159,49,67,187,122,208,183,45,123,86,97,58,238,69,145,175,144,171,42,170,231,142,71,45,205,13,180,103,161,124,19,154,90,154,199,125,198,34,80,65,32,219,97,235,219,50,13,246,75,220,45,29,185,87,24,16,234,250,187,113,178,103,39,245,242,80,235,36,59,16,249,103,98,56,203,147,66,8,192,170,58,113,134,254,191,140,33,134,171,198,117,175,208,106,239,27,251,25,28,224,106,246,234,153,101,93,49,185,29,19,214,61,80,61,141,147,117,83,96,21,159,160,191,173,74,233,49,212,254,63,86,143,45,54,243,127,146,166,216,9,240,123,19,196,82,255,78,59,153,31,205,102,184,236,232,13,160,145,192,202,64,187,202,46,193,172,16,238,71,123,203,61,216,185,39,240,115,106,181,114,118,245,181,2,96,21,15,45,18,14,253,250,140,222,111,238,4,125,85,84,201,169,65,238,54,230,210,161,69,189,175,224,48,159,229,183,133,197,206,250,221,133,219,109,134,7,132,70,246,217,142,65,243,195,206,2,38,146,249,90,191,90,2,11,166,141,59,159,211,172,63,61,255,7,58,160,252,7,79,61,213,77,109,24,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIncorrectSchemaFileFormatLocalizableString());
			LocalizableStrings.Add(CreateMaximumAllowedSchemaCountLocalizableString());
			LocalizableStrings.Add(CreateMaximumAllowedSchemaSizeLocalizableString());
			LocalizableStrings.Add(CreateErrorDownloadingSchemaLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIncorrectSchemaFileFormatLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c306e853-9250-8ec2-5eb8-8d20c3f1a2f2"),
				Name = "IncorrectSchemaFileFormat",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMaximumAllowedSchemaCountLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("eb94bbf5-635a-14b1-5b42-30dedea15cd5"),
				Name = "MaximumAllowedSchemaCount",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMaximumAllowedSchemaSizeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4e504b53-dee4-b7af-dc93-e1edb4c227d3"),
				Name = "MaximumAllowedSchemaSize",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorDownloadingSchemaLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("08b3439f-c526-1082-45a3-699063acba68"),
				Name = "ErrorDownloadingSchema",
				CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3"),
				CreatedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"),
				ModifiedInSchemaUId = new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7f3b888-e7fc-86c5-55d5-3818297a4654"));
		}

		#endregion

	}

	#endregion

}

