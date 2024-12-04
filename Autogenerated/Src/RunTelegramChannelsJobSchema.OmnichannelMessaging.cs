﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RunTelegramChannelsJobSchema

	/// <exclude/>
	public class RunTelegramChannelsJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RunTelegramChannelsJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RunTelegramChannelsJobSchema(RunTelegramChannelsJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6eb9a2ec-5c7e-4fa8-96cc-857d82d9e0ad");
			Name = "RunTelegramChannelsJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("adb0e53f-603b-4bff-af9c-50da9ffbd2f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,25,219,110,219,54,244,217,5,246,15,172,86,108,50,16,40,239,105,147,194,177,211,194,67,219,20,113,178,62,12,67,65,75,180,205,85,23,143,164,220,120,157,255,125,231,240,166,187,157,13,3,182,135,196,18,121,110,60,119,30,229,52,99,114,75,99,70,238,153,16,84,22,43,21,77,139,124,197,215,165,160,138,23,121,116,155,229,60,222,208,60,103,105,244,158,73,73,215,60,95,127,247,236,219,119,207,70,165,132,71,178,78,139,37,77,47,46,166,69,150,1,252,187,98,141,16,47,253,126,141,128,199,143,238,89,202,214,130,102,21,216,98,47,21,235,188,131,48,105,202,98,148,68,70,111,89,206,4,143,59,48,51,170,104,103,241,29,207,127,175,22,235,167,67,49,251,119,4,27,90,143,102,215,176,5,155,223,11,182,6,97,200,52,165,82,146,11,114,87,230,238,44,83,115,72,249,83,177,212,160,231,231,231,228,149,44,179,140,138,253,149,125,135,61,34,216,86,48,201,114,37,9,37,162,4,28,65,138,21,113,100,136,85,150,140,28,141,243,26,145,109,185,76,121,76,98,205,190,159,57,72,53,135,159,155,71,22,151,170,16,128,132,198,170,36,7,85,42,138,220,47,200,71,193,119,84,49,45,174,35,13,155,74,255,8,84,195,148,198,27,230,136,127,0,111,33,151,36,104,51,125,199,165,10,140,126,70,223,179,60,49,156,236,187,101,251,81,20,91,38,20,103,93,190,230,133,60,72,38,64,184,220,152,155,124,46,27,239,47,235,160,200,240,149,145,240,138,124,118,10,211,178,118,225,222,150,60,49,80,74,190,167,57,93,51,228,228,161,17,190,109,42,187,192,24,137,5,91,93,6,115,240,234,224,252,138,240,108,155,178,12,76,167,99,131,112,173,201,152,161,165,186,166,242,82,32,54,249,156,22,58,40,154,171,248,167,173,51,90,51,101,159,70,130,169,82,228,26,131,188,126,77,66,253,112,137,176,70,124,1,145,160,48,206,152,8,131,190,240,10,198,99,205,106,116,192,255,135,227,134,121,207,212,166,72,6,173,210,80,53,240,157,164,233,4,12,178,99,109,39,8,199,86,254,6,70,10,47,32,123,206,190,54,40,133,86,192,5,16,137,149,115,121,251,102,192,205,75,216,114,131,177,81,17,230,133,50,203,195,96,158,4,110,233,141,40,178,48,176,226,248,213,79,27,38,88,24,128,251,237,120,194,4,194,71,115,121,243,123,73,211,208,16,137,62,82,56,6,83,160,205,62,101,234,120,145,62,99,57,66,99,203,96,20,77,242,4,228,144,70,43,199,168,43,81,178,241,152,80,105,207,102,84,208,56,123,100,162,150,221,49,10,60,66,161,127,200,229,149,115,13,84,103,52,73,18,187,131,142,96,216,252,76,211,146,25,87,55,74,137,238,139,133,214,117,232,157,193,254,90,247,66,82,47,107,254,241,119,13,254,94,174,23,76,41,0,147,243,228,63,178,126,67,134,255,216,17,254,135,126,208,82,207,63,118,137,93,193,147,190,98,227,141,190,163,194,151,45,48,224,241,52,97,88,54,179,54,32,181,76,29,77,182,91,40,71,58,209,106,144,95,58,165,232,87,84,97,195,223,32,91,14,249,26,138,152,23,234,142,230,150,196,124,134,162,250,98,107,220,35,70,29,63,111,202,134,13,145,162,144,235,195,120,140,58,68,234,142,234,10,122,3,128,33,97,77,3,243,4,10,67,135,151,83,213,72,137,189,123,28,121,229,164,28,138,202,27,26,67,189,222,71,115,87,86,64,229,150,64,232,105,91,198,163,17,88,255,190,208,2,118,55,15,4,20,135,98,205,243,29,77,57,0,126,97,249,205,99,204,182,58,138,60,127,40,34,209,141,16,133,120,83,136,140,170,240,69,48,165,249,143,10,187,18,162,90,253,8,249,230,217,28,34,162,41,18,46,241,156,68,243,136,136,149,149,124,229,105,74,150,140,36,92,210,101,202,146,40,240,66,207,204,82,203,41,66,244,87,12,16,89,63,75,231,48,254,0,132,61,254,27,103,248,198,30,109,75,203,14,250,101,161,104,252,229,94,64,59,124,240,34,31,58,133,180,17,21,211,13,3,148,163,113,161,109,123,199,98,198,119,224,144,192,67,129,167,163,239,157,176,62,198,180,222,145,45,100,231,124,13,215,207,26,233,248,120,16,182,83,183,33,199,87,36,124,62,32,45,36,183,61,156,234,135,31,90,124,236,250,159,127,14,29,51,210,9,73,86,49,180,162,169,196,236,103,205,103,219,76,136,34,9,118,189,36,39,4,120,77,2,240,57,150,109,213,62,128,142,37,216,64,6,88,10,237,139,6,81,98,31,218,239,22,85,131,173,33,73,236,175,22,228,155,225,15,62,1,9,23,53,6,105,7,164,242,201,33,170,92,184,17,241,210,107,2,67,190,169,154,202,67,235,17,127,42,228,103,142,191,203,116,97,197,195,71,209,41,34,147,211,36,78,4,85,165,62,80,220,4,246,240,145,20,113,92,10,150,144,175,27,158,50,210,85,212,5,121,81,143,169,42,236,15,79,138,165,90,70,179,110,81,37,3,43,89,43,51,3,198,124,245,161,80,55,143,16,10,178,147,7,255,73,73,185,236,187,79,244,73,123,36,149,117,229,174,149,135,155,92,113,181,239,41,120,102,99,1,60,51,90,107,244,157,85,175,247,40,96,173,175,137,166,224,137,138,25,180,78,167,212,104,42,12,76,244,134,129,201,177,59,154,93,119,116,213,212,184,189,233,53,209,155,77,70,24,32,80,163,171,232,227,185,104,33,249,6,233,140,152,84,208,139,68,119,204,145,3,243,242,213,190,214,144,77,146,140,231,96,111,24,80,20,194,27,29,133,25,15,26,235,20,145,234,244,74,19,178,102,179,203,153,113,104,147,84,173,254,173,249,19,235,236,161,71,173,218,141,24,115,94,172,124,58,6,76,101,12,171,179,97,12,30,219,219,70,152,77,204,40,21,5,31,154,198,232,119,12,196,79,80,233,22,228,204,9,217,115,243,115,154,176,167,25,62,195,113,45,164,69,12,117,254,15,196,48,6,119,157,125,123,189,237,139,209,167,66,124,209,83,166,232,142,201,162,20,49,0,22,2,56,158,153,51,5,253,131,12,112,145,160,67,28,74,73,175,240,247,80,20,82,56,165,41,56,65,179,177,53,39,136,108,41,232,28,228,172,58,242,160,7,181,245,110,226,220,217,231,204,41,215,89,193,170,206,195,63,40,158,114,61,253,16,221,37,163,199,46,172,115,15,205,107,73,165,141,245,7,40,55,79,79,31,48,12,115,169,227,218,147,128,176,5,42,13,87,133,153,95,91,16,51,9,12,27,156,43,71,116,103,199,60,225,245,96,246,12,133,123,174,147,8,140,231,24,62,70,15,42,254,80,124,181,32,11,237,7,26,187,206,15,111,88,254,221,192,76,74,24,80,192,125,205,33,150,203,223,224,200,26,83,247,141,55,216,13,216,205,25,147,177,224,166,158,93,58,99,216,61,71,167,71,119,211,82,8,40,164,56,23,50,157,10,210,55,78,48,58,56,79,106,91,39,106,187,68,139,42,120,149,214,95,175,79,213,38,83,3,153,193,234,25,187,178,254,217,21,121,14,230,42,211,116,220,158,27,13,77,186,124,5,30,160,87,187,168,155,11,100,45,151,201,191,127,57,95,76,30,48,130,189,62,91,247,115,152,211,234,36,124,11,99,65,93,146,223,10,152,74,50,44,12,128,122,251,214,129,143,160,175,129,17,233,79,5,207,43,164,135,156,67,97,188,43,82,44,64,19,169,153,205,239,224,249,86,51,6,108,164,82,7,174,95,247,45,116,11,4,169,85,82,14,178,173,24,122,118,250,156,79,224,112,130,186,215,132,103,113,91,157,168,143,69,243,152,30,189,166,106,59,244,176,248,211,34,233,25,76,232,168,131,190,130,230,214,5,209,57,130,230,88,195,241,2,32,59,153,24,162,99,134,27,77,92,173,159,161,185,72,29,173,61,19,49,163,120,93,21,19,63,208,238,159,21,212,222,204,23,128,135,118,122,148,208,187,206,174,171,37,152,130,184,200,177,124,230,248,37,193,140,92,136,27,185,88,207,111,13,100,42,105,42,34,35,211,22,187,145,12,66,214,88,12,69,221,233,41,78,45,128,142,52,212,79,136,254,167,15,130,245,151,128,35,163,113,168,215,253,223,43,122,166,224,122,101,139,195,47,146,67,21,186,12,154,182,11,174,80,74,76,149,206,82,175,206,53,116,63,242,214,77,209,100,112,229,39,106,178,129,99,191,99,236,184,80,224,102,166,122,91,235,133,173,111,12,237,132,61,159,113,253,4,178,219,139,245,25,41,116,185,185,34,21,103,63,234,44,214,112,95,91,150,107,219,87,12,180,49,100,3,221,44,204,67,224,142,10,157,188,80,12,12,217,123,63,1,103,235,249,230,49,234,29,188,153,173,129,233,131,29,15,60,81,188,21,54,194,27,47,85,191,151,152,213,230,34,172,253,5,109,232,247,96,64,28,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChannelDisabledMessageTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChannelDisabledMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("71c74363-a70a-4d91-84f0-94ce61cb5e7c"),
				Name = "ChannelDisabledMessageTemplate",
				CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988"),
				CreatedInSchemaUId = new Guid("6eb9a2ec-5c7e-4fa8-96cc-857d82d9e0ad"),
				ModifiedInSchemaUId = new Guid("6eb9a2ec-5c7e-4fa8-96cc-857d82d9e0ad")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6eb9a2ec-5c7e-4fa8-96cc-857d82d9e0ad"));
		}

		#endregion

	}

	#endregion

}

