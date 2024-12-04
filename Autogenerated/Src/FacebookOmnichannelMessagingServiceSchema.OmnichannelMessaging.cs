﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookOmnichannelMessagingServiceSchema

	/// <exclude/>
	public class FacebookOmnichannelMessagingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookOmnichannelMessagingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookOmnichannelMessagingServiceSchema(FacebookOmnichannelMessagingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67");
			Name = "FacebookOmnichannelMessagingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,90,89,115,219,56,18,126,86,170,242,31,16,101,42,67,85,105,169,36,79,83,177,229,148,124,36,163,217,248,88,75,25,63,184,166,82,52,9,89,92,243,80,0,208,137,86,163,255,190,221,56,72,240,146,100,199,187,59,181,47,182,8,52,26,141,198,215,39,153,120,49,229,11,207,167,100,74,25,243,120,58,19,238,81,154,204,194,219,140,121,34,76,19,247,60,78,66,127,238,37,9,141,220,83,202,185,119,27,38,183,207,159,173,158,63,235,100,28,126,18,139,32,159,119,143,211,216,11,19,247,36,17,161,8,41,223,107,162,190,96,233,125,24,80,198,31,72,253,1,196,189,73,211,59,51,242,192,229,74,72,10,167,188,167,76,192,72,65,63,89,114,65,227,234,51,40,36,138,168,143,218,224,238,71,154,80,22,250,53,154,79,97,242,181,54,120,153,129,72,49,117,39,176,196,139,194,127,73,141,214,168,96,246,62,244,233,105,26,208,104,227,164,59,2,33,238,183,51,113,175,232,77,65,112,70,191,9,144,28,111,246,55,110,175,108,186,184,221,116,55,161,9,62,22,196,54,120,226,216,222,196,158,97,180,109,220,61,62,108,157,186,164,95,51,202,5,111,37,176,143,14,183,42,152,231,139,38,98,208,202,6,241,138,89,195,240,50,205,68,73,37,101,226,95,133,88,184,163,27,46,247,67,108,20,132,0,152,44,78,200,176,126,74,87,77,1,41,16,191,100,244,22,22,146,163,200,227,252,29,185,132,39,184,75,118,164,180,126,9,134,9,92,169,36,189,62,246,132,103,14,247,7,12,44,178,155,40,244,137,143,75,219,86,146,119,228,208,227,180,96,212,1,171,133,191,249,198,112,177,11,176,1,176,153,119,228,66,50,84,243,131,193,128,236,243,44,142,61,182,60,48,3,227,128,132,9,225,84,160,82,56,97,116,145,186,57,241,192,166,150,194,158,210,248,134,50,20,213,200,10,154,146,128,213,28,128,223,138,220,82,177,135,60,247,200,90,139,6,208,82,210,201,103,53,106,15,118,234,138,51,14,225,132,177,148,253,157,46,185,52,82,79,164,76,174,46,169,170,70,91,162,7,141,53,49,65,189,193,49,24,26,31,109,98,100,169,88,209,150,55,149,52,114,88,77,86,52,18,43,171,170,170,195,34,12,19,65,124,192,247,22,18,64,91,202,190,240,236,166,133,86,235,216,44,145,98,169,69,117,98,249,167,21,12,31,82,22,123,130,3,125,18,224,17,20,147,59,186,108,70,132,28,89,120,204,139,73,2,17,103,216,149,244,232,142,186,7,218,218,0,80,26,181,30,39,191,77,206,207,72,122,243,79,240,186,251,3,185,174,96,195,168,200,88,194,15,140,206,251,36,160,11,16,131,19,64,68,206,119,127,96,232,44,4,166,224,241,25,120,50,163,248,143,84,160,43,131,159,230,214,29,61,147,243,1,35,78,178,40,234,17,117,115,246,52,144,195,108,23,57,200,229,93,116,0,157,78,56,35,206,11,69,231,142,249,25,44,62,103,39,241,66,44,157,156,105,207,176,235,52,162,168,80,197,144,32,185,14,85,238,49,229,58,144,208,115,165,155,198,229,7,214,70,74,164,14,255,22,10,127,78,28,195,216,149,20,239,221,18,96,114,161,58,62,120,13,242,246,245,155,95,94,191,126,243,78,143,117,148,62,73,23,156,140,56,138,82,78,131,195,229,103,16,72,31,187,83,134,152,166,54,138,146,52,107,210,104,209,237,6,141,225,134,38,183,148,141,147,89,250,0,127,184,113,61,216,120,83,228,211,48,180,243,157,234,220,19,57,82,35,29,241,22,11,160,148,241,28,188,235,118,103,234,156,129,237,32,228,96,225,56,232,246,26,156,235,8,103,158,218,175,110,80,137,100,83,61,37,62,27,171,158,129,91,48,78,194,75,2,128,182,79,195,123,203,235,113,50,99,105,172,159,112,28,28,25,189,85,201,39,104,40,68,181,212,180,114,173,217,219,8,184,30,241,197,25,21,16,195,23,176,248,38,140,66,177,196,220,33,100,52,166,137,224,142,253,128,201,2,104,114,203,18,164,114,245,64,32,213,125,125,76,103,94,22,9,43,69,160,173,240,219,160,183,205,32,220,2,48,21,135,20,129,9,74,54,228,243,12,141,124,153,53,13,239,237,178,180,121,116,40,49,217,105,230,75,222,191,39,78,203,212,80,57,137,132,126,107,230,236,212,102,208,110,47,33,201,224,33,196,224,165,131,174,6,174,59,81,137,120,175,135,174,173,10,108,21,176,154,117,150,10,88,73,3,115,116,253,88,11,9,90,168,75,9,83,202,62,179,72,89,19,252,53,14,112,96,39,156,131,29,46,219,229,247,62,132,35,201,113,208,5,147,52,70,185,93,12,196,87,179,16,96,26,3,163,234,65,108,28,93,137,125,197,230,11,243,6,39,38,88,230,131,94,43,254,74,195,120,135,51,57,61,128,240,13,196,9,71,135,13,185,103,123,242,152,64,105,38,35,23,39,120,211,33,72,224,37,96,7,233,12,136,41,36,85,140,206,134,221,29,54,238,14,14,90,60,229,3,132,47,131,137,100,101,108,153,147,85,135,139,115,182,235,246,148,138,121,26,180,89,233,199,44,12,48,235,48,50,234,132,125,28,56,114,198,36,215,227,192,196,226,9,197,202,147,232,115,232,167,161,84,161,122,168,218,133,50,51,119,154,46,156,55,61,93,109,56,93,140,22,122,230,3,120,91,7,131,56,50,204,71,175,230,148,81,167,123,202,65,69,70,134,110,15,242,151,147,175,153,23,57,138,143,123,129,153,24,5,68,58,150,164,61,76,216,148,48,42,19,208,16,45,201,236,158,124,167,62,96,121,226,123,145,199,246,241,180,7,142,202,78,214,205,42,42,137,114,184,156,164,25,131,139,211,230,193,229,211,19,43,169,114,248,93,244,165,164,218,168,40,37,233,19,43,9,176,19,145,163,57,245,239,198,220,184,209,108,177,72,161,159,17,56,57,218,245,76,17,91,245,128,209,155,150,193,169,206,155,50,31,211,215,84,216,25,108,143,252,249,103,141,157,59,18,194,243,231,50,98,146,23,38,95,126,245,170,78,168,92,125,19,219,87,175,148,98,107,75,192,17,135,139,16,88,55,172,50,154,81,110,223,232,230,62,5,0,93,100,66,115,152,166,255,200,104,70,29,99,114,227,196,79,227,154,114,160,138,208,208,50,62,181,176,193,79,41,36,242,144,64,58,63,117,129,109,94,173,137,148,64,99,34,163,110,145,208,141,143,223,145,85,193,96,221,213,249,119,253,70,248,173,6,104,117,74,159,170,3,22,160,49,55,74,2,121,2,176,129,28,157,210,93,32,202,192,75,89,2,247,145,177,102,112,239,169,196,11,146,223,0,246,210,82,187,160,73,182,116,63,132,140,139,115,166,147,25,167,231,230,122,175,79,41,38,110,24,40,190,83,230,37,124,70,89,69,189,150,64,32,131,155,59,54,144,201,72,209,136,100,121,91,71,140,194,111,76,230,32,151,27,207,206,40,13,218,113,188,227,85,77,217,18,175,8,226,10,110,131,170,246,21,127,153,146,174,226,18,36,199,179,19,127,158,230,247,245,88,229,107,243,42,234,64,179,75,174,142,6,20,231,101,151,57,127,0,119,20,206,66,208,185,210,203,71,108,127,149,38,97,89,121,175,117,155,102,117,30,99,192,245,8,149,254,111,116,49,134,34,128,37,94,164,229,223,112,220,237,129,120,91,61,38,253,40,1,17,69,122,71,19,89,165,132,249,29,16,250,29,90,107,220,221,177,175,81,232,160,123,80,92,36,50,55,51,198,229,99,51,13,98,3,225,170,127,107,183,57,174,207,33,111,149,5,144,93,223,116,174,161,235,8,183,225,124,102,225,148,198,139,8,47,25,138,65,147,88,150,28,79,159,28,166,193,114,34,150,17,210,192,66,125,225,249,168,123,232,49,90,170,32,37,94,126,135,6,195,108,57,69,69,56,173,144,192,206,39,74,70,191,11,50,183,126,15,137,53,51,242,125,216,50,101,208,49,23,99,157,237,73,231,246,18,148,241,226,236,100,58,153,142,206,142,71,151,199,111,191,188,150,92,65,200,210,185,129,135,123,148,49,134,190,255,60,19,183,41,8,99,42,112,124,71,33,96,98,186,92,72,29,32,241,96,46,226,104,15,213,11,96,20,195,76,204,254,246,11,246,38,94,210,72,53,230,58,29,146,119,56,80,208,166,118,139,117,28,8,61,106,88,247,55,32,92,62,124,115,181,43,64,21,97,26,206,236,30,146,66,91,117,75,217,235,118,193,206,24,220,19,210,93,119,231,217,141,123,47,239,229,139,92,211,253,99,207,230,3,123,194,235,9,72,254,119,229,149,47,48,140,48,84,152,91,206,173,19,184,181,38,170,117,131,239,65,50,165,246,48,1,76,166,40,33,151,128,10,161,194,25,154,154,230,212,75,224,47,115,109,168,213,118,239,43,245,244,137,30,65,93,231,47,126,172,189,44,255,82,236,149,123,145,166,219,116,175,88,40,168,147,43,161,193,165,52,122,9,211,99,111,52,100,233,168,195,116,87,47,161,174,241,32,207,27,228,115,201,5,212,150,168,60,210,90,179,64,247,173,70,119,117,30,227,228,30,54,114,148,103,68,228,94,156,79,166,224,42,52,82,84,79,183,228,46,212,144,124,111,180,221,163,92,49,232,75,209,64,115,235,227,174,132,24,181,111,102,94,114,68,109,111,51,204,184,113,76,26,33,141,37,129,161,5,47,148,194,75,56,200,41,82,113,34,61,185,193,39,130,222,11,2,40,75,83,136,51,121,194,206,117,94,118,28,202,82,1,174,112,95,109,208,215,253,232,3,3,174,21,209,247,168,177,106,122,236,5,123,72,132,116,164,52,230,212,82,212,40,209,139,133,232,105,180,28,45,202,112,236,192,106,111,3,249,119,160,83,55,180,212,34,162,54,157,213,29,5,129,211,141,75,117,143,204,33,115,126,166,129,140,18,185,147,76,250,116,144,108,230,129,79,181,167,100,3,26,51,47,45,118,254,140,237,1,99,249,122,238,83,234,203,151,161,55,17,213,102,92,46,207,220,171,148,221,201,151,210,104,180,82,55,19,104,85,96,154,162,118,220,169,77,208,39,221,218,70,220,36,31,163,8,12,54,88,74,68,184,191,123,81,134,53,92,225,85,136,190,196,181,117,35,120,13,202,174,176,33,107,101,239,178,239,114,89,157,215,90,207,9,96,193,22,87,166,15,87,244,172,17,51,234,248,122,74,250,74,24,84,192,47,200,43,253,42,133,180,218,120,105,135,82,111,169,180,192,140,58,93,173,89,232,92,41,8,118,13,131,81,179,217,52,33,76,175,48,105,171,57,1,230,4,246,144,211,171,218,142,217,20,16,0,88,174,71,143,220,25,84,111,198,50,140,50,143,247,174,245,230,49,47,83,87,54,190,139,249,97,69,0,107,78,67,131,96,90,97,150,99,221,33,33,15,133,199,7,47,140,32,222,153,245,69,117,104,226,197,74,93,106,94,109,108,48,174,181,93,167,35,217,222,246,48,21,67,47,17,154,234,149,93,127,48,129,133,54,157,153,249,63,139,54,186,76,66,173,105,3,109,79,124,17,152,208,243,165,109,94,224,216,158,51,85,157,149,80,21,28,31,109,138,40,103,110,136,15,247,46,15,51,68,171,156,174,161,24,222,40,206,241,155,128,159,87,182,70,138,234,110,253,51,100,127,4,154,13,42,84,19,35,186,221,17,177,172,217,214,191,205,176,247,36,146,124,131,238,155,18,0,26,123,59,216,144,116,154,188,242,138,170,225,197,212,46,22,165,153,88,169,155,169,132,55,38,124,101,67,124,186,10,82,155,229,110,69,228,127,202,120,177,248,252,97,147,45,117,54,30,223,222,3,136,26,91,157,0,49,232,236,87,26,129,250,220,201,2,122,143,179,165,93,151,230,237,23,171,208,53,69,106,31,95,190,90,89,140,250,48,171,146,218,104,90,28,53,222,31,35,85,139,244,249,55,106,208,42,185,128,55,139,211,57,166,45,242,74,83,157,241,20,173,145,226,245,125,189,249,153,107,193,58,126,81,214,98,116,41,189,196,111,104,88,86,7,90,186,151,91,15,162,127,21,82,91,90,104,107,104,215,250,215,197,81,43,40,168,82,54,29,88,71,238,162,37,101,117,155,199,92,54,219,228,245,228,123,52,119,39,119,218,74,167,10,240,142,31,191,190,56,249,238,211,133,116,31,197,183,22,121,230,160,192,238,116,213,71,57,223,230,144,68,88,47,203,197,60,135,50,154,125,213,7,246,205,143,113,0,29,232,215,107,87,127,219,19,130,203,132,129,55,235,62,153,128,244,119,208,188,133,119,110,171,183,96,219,250,112,86,72,34,121,227,31,127,22,244,13,21,242,131,253,11,118,17,21,244,141,232,242,75,133,146,139,249,120,242,151,241,48,197,247,65,77,82,59,118,62,144,181,71,237,182,67,87,42,61,221,122,194,78,180,62,252,21,68,52,25,142,247,55,126,201,114,32,221,144,94,163,244,232,130,18,251,40,83,41,13,214,157,15,137,9,235,221,78,229,13,76,46,140,43,197,220,212,158,181,50,210,98,129,157,178,214,96,125,148,102,81,64,146,84,200,247,216,57,126,75,10,209,92,245,183,83,114,207,242,43,158,199,192,238,2,14,139,223,205,188,199,134,201,56,24,174,212,255,245,171,220,98,134,171,252,231,250,191,0,200,206,15,225,209,28,199,36,169,234,52,121,120,203,79,98,67,148,153,26,170,241,203,11,215,230,106,216,21,124,176,6,135,213,165,27,82,12,77,31,20,40,188,96,196,85,166,57,226,203,196,119,74,171,30,127,125,139,48,185,253,139,187,136,11,213,48,40,189,80,237,94,164,32,183,157,102,110,253,250,234,249,179,245,191,1,82,78,76,194,139,47,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateChannelAlreadyExistLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateChannelAlreadyExistLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("680c6956-b6c5-000a-f6f4-71ee1cda74aa"),
				Name = "ChannelAlreadyExist",
				CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3"),
				CreatedInSchemaUId = new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67"),
				ModifiedInSchemaUId = new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83406a83-3975-4ac6-9488-b0f07bdd8d67"));
		}

		#endregion

	}

	#endregion

}

