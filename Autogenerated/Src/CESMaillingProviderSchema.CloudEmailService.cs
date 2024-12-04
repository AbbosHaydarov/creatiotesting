namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMaillingProviderSchema

	/// <exclude/>
	public class CESMaillingProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMaillingProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMaillingProviderSchema(CESMaillingProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c");
			Name = "CESMaillingProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,61,107,115,27,55,146,159,181,85,251,31,198,220,171,20,181,203,26,219,217,187,219,45,203,210,157,245,112,162,58,59,246,137,74,242,33,181,231,26,145,144,52,39,114,134,59,51,180,173,36,254,239,215,221,104,0,141,199,12,41,89,78,206,174,178,201,25,160,209,104,52,250,13,176,42,150,170,93,21,51,149,157,171,166,41,218,250,178,203,143,234,234,178,188,90,55,69,87,214,213,31,255,240,203,31,255,176,179,110,203,234,42,155,222,182,157,90,238,5,223,161,253,98,161,102,216,184,205,191,81,149,106,202,89,212,230,155,69,125,81,44,202,159,9,102,244,246,85,89,253,51,122,120,174,62,118,249,153,186,90,47,138,230,228,227,170,81,109,139,67,196,237,174,27,85,204,225,129,123,35,231,178,92,202,1,123,102,153,31,157,76,95,215,115,181,104,55,55,125,93,52,55,170,131,22,249,247,93,185,40,187,82,245,116,106,84,223,243,252,248,176,247,213,203,98,214,213,141,7,20,199,193,175,248,119,231,79,141,186,2,52,178,163,69,209,182,207,50,68,188,40,23,11,104,247,182,169,223,151,115,213,80,179,199,143,31,103,207,219,245,114,89,52,183,7,252,157,186,100,151,117,147,125,168,155,155,236,67,217,93,103,179,69,189,158,103,106,9,48,178,86,53,239,203,153,202,77,247,199,162,255,106,125,177,40,103,208,28,65,36,6,205,44,42,30,38,59,192,61,240,175,195,26,86,176,43,170,14,48,127,219,148,239,139,78,233,247,43,253,37,155,225,251,172,172,58,120,173,86,133,38,249,153,154,149,171,82,65,175,195,162,155,93,79,203,159,85,182,159,125,253,4,254,236,165,186,183,93,131,100,123,13,168,50,66,231,197,21,244,24,45,225,201,187,165,126,52,26,234,122,222,148,87,87,170,81,243,19,108,205,189,59,243,240,29,145,43,13,0,81,231,65,95,23,31,207,213,114,181,128,151,140,242,191,125,253,175,95,255,253,239,6,233,63,169,106,174,201,226,211,232,101,169,22,243,62,2,125,179,46,231,153,153,195,84,239,137,211,57,192,198,23,249,201,114,213,221,6,120,93,212,245,226,63,178,119,101,123,60,59,92,47,110,104,70,208,190,90,47,22,27,16,161,197,106,214,200,143,136,14,113,128,110,17,114,23,61,56,173,96,51,224,38,87,109,86,100,149,250,0,196,192,197,6,225,82,95,102,221,181,130,46,10,232,212,168,203,253,81,130,133,70,143,15,52,127,33,3,198,28,104,88,48,209,115,188,251,12,224,151,237,24,39,181,155,161,196,218,249,244,155,98,122,26,244,95,153,109,241,1,122,102,23,196,29,36,67,212,60,187,184,205,102,5,193,67,10,235,167,217,82,117,215,245,188,103,230,244,4,119,195,50,171,64,96,239,143,214,176,85,161,111,165,197,238,232,224,104,221,52,176,63,50,124,142,67,241,139,252,249,99,234,181,137,124,223,123,224,8,138,251,106,104,235,63,157,100,191,27,173,1,91,194,72,239,56,205,159,89,87,3,92,51,18,13,129,35,0,169,237,74,232,21,200,136,32,170,83,205,151,164,117,4,68,15,174,101,251,237,232,224,252,218,113,4,137,184,236,82,191,154,12,81,231,52,16,175,71,30,208,199,7,15,177,218,147,108,112,20,198,154,191,237,226,72,59,207,178,139,162,85,17,127,248,45,61,70,233,19,56,48,228,74,53,168,81,123,164,223,225,10,180,57,32,167,142,80,109,157,84,87,240,49,123,55,115,95,246,54,182,150,159,9,167,157,43,213,241,167,157,242,50,27,75,112,217,190,22,148,140,62,252,241,223,106,149,202,115,4,227,167,123,158,26,243,96,204,157,119,144,253,133,84,125,209,92,173,151,192,75,227,144,201,38,200,228,114,15,238,210,196,136,128,248,95,163,186,117,83,197,51,215,239,239,68,229,186,131,33,212,92,55,249,233,205,69,91,47,96,119,140,71,63,178,224,106,212,178,126,15,82,171,184,132,61,147,253,45,127,250,183,252,175,163,221,127,104,58,115,103,203,51,47,214,115,208,211,51,117,92,116,197,180,94,55,51,101,248,166,255,205,47,25,44,192,30,24,31,240,207,6,204,95,147,144,236,99,14,198,1,168,214,129,233,152,29,129,89,216,41,255,225,216,105,192,11,243,201,172,45,211,20,151,40,232,228,175,197,36,238,186,51,213,150,211,139,85,9,60,225,190,76,204,91,167,166,35,213,173,151,141,86,143,22,47,96,120,51,212,235,98,214,212,111,139,6,133,14,240,153,248,58,54,88,188,47,154,108,137,207,219,111,213,2,86,56,197,158,175,197,251,31,190,62,24,51,95,201,110,121,32,31,246,3,94,220,147,212,138,249,63,129,176,225,255,94,238,151,195,3,239,203,175,187,147,13,125,129,152,55,96,167,85,93,217,221,78,103,215,96,154,125,7,18,23,160,188,75,191,225,173,244,201,167,51,201,73,65,58,67,98,254,62,38,179,11,36,90,7,83,61,157,79,180,25,102,249,224,116,30,48,81,68,150,0,254,70,138,108,146,7,155,168,98,81,133,174,246,243,198,94,98,66,208,79,78,47,73,52,54,150,97,126,175,102,63,79,233,203,15,197,98,173,198,252,98,49,251,153,40,206,180,49,79,235,25,121,130,23,11,165,251,96,27,224,50,253,58,127,89,55,203,2,112,121,21,54,107,243,95,158,124,202,105,0,64,206,192,222,179,172,31,193,69,35,23,102,26,1,98,218,251,20,205,127,4,151,136,60,97,240,57,91,18,80,83,160,77,113,165,38,153,49,75,164,85,50,73,207,131,241,225,169,190,71,100,1,141,168,169,158,134,110,139,58,135,27,6,202,166,191,59,144,252,104,189,0,86,83,154,224,228,118,23,139,0,243,252,88,93,114,179,9,24,24,139,214,160,247,73,242,42,141,34,229,207,221,213,128,102,135,211,147,10,248,168,65,52,159,19,223,188,152,131,20,111,219,3,228,16,45,19,84,11,104,157,215,99,217,244,20,158,226,99,235,229,157,86,151,245,1,12,104,156,62,230,218,112,139,74,41,225,172,22,227,113,101,29,127,232,223,171,200,52,48,249,114,238,252,75,244,163,84,247,131,247,112,236,48,17,220,6,131,182,117,85,192,148,154,43,88,132,134,187,218,175,99,31,61,135,77,48,162,191,205,52,252,126,66,90,84,228,99,61,242,89,234,213,56,66,147,135,224,181,79,194,147,91,253,126,156,240,190,6,138,107,7,222,45,107,59,54,43,141,11,12,14,143,253,60,137,196,175,71,60,189,252,134,129,176,147,142,87,240,151,123,173,253,157,73,172,145,136,24,89,204,34,151,139,218,183,250,241,98,203,169,228,224,197,236,111,94,20,67,230,87,101,219,61,215,162,134,246,152,213,189,71,240,246,10,84,15,4,46,218,33,147,7,25,185,131,54,70,82,10,120,198,50,208,138,143,225,145,5,99,161,228,102,152,211,185,147,100,178,233,190,48,164,218,174,133,200,89,219,178,249,19,161,234,150,102,7,49,202,97,218,99,63,128,99,100,87,6,81,58,240,240,54,140,229,71,112,182,26,46,10,250,164,164,37,182,254,252,13,226,49,51,122,200,242,65,239,62,145,203,166,221,196,78,182,220,151,109,179,162,229,160,132,108,163,39,148,224,8,232,28,67,204,109,67,221,111,104,151,178,248,147,54,147,99,148,55,31,64,61,161,217,228,30,57,97,215,183,121,209,124,37,19,222,188,113,0,3,19,81,3,234,208,151,48,138,19,144,99,234,106,214,246,8,110,124,185,118,125,241,191,160,253,161,137,25,51,183,1,59,253,138,101,207,206,101,83,47,117,212,207,219,0,83,240,83,84,163,81,146,45,209,231,79,52,68,3,193,180,187,238,150,62,44,51,242,97,61,191,53,141,186,166,152,221,128,147,87,206,110,112,143,130,189,166,252,87,224,200,85,225,155,146,220,207,119,179,54,122,177,92,213,13,46,49,63,103,143,114,207,209,76,72,39,15,55,88,217,243,219,149,154,67,164,127,189,172,200,228,120,142,130,225,96,60,2,75,209,248,166,177,192,247,100,188,47,18,249,213,176,108,220,97,222,176,129,246,252,85,125,149,35,56,99,37,38,226,27,136,173,195,33,39,23,138,3,220,20,241,62,157,239,131,33,153,141,152,42,127,201,70,234,163,154,173,209,141,109,215,179,25,224,117,9,70,216,237,40,137,16,163,157,179,212,236,21,186,78,212,6,29,121,221,45,195,145,143,89,117,65,171,114,9,255,182,178,221,41,173,234,41,61,207,207,107,152,55,125,54,98,122,135,100,55,104,180,43,245,14,86,242,32,187,162,132,139,180,78,60,31,15,16,215,41,25,103,176,216,161,244,38,118,89,29,51,4,138,220,0,108,254,162,186,29,239,186,232,136,193,31,69,154,134,15,173,74,212,178,22,81,219,70,131,122,103,113,38,33,124,86,84,48,169,96,148,116,240,131,225,24,173,0,202,96,118,157,141,79,62,206,212,138,252,86,235,119,164,185,232,164,105,234,134,217,136,49,27,253,148,98,167,80,60,255,227,89,70,125,179,15,215,229,2,67,141,101,103,133,13,230,86,156,116,101,118,123,150,1,191,141,204,46,84,73,41,184,211,93,55,245,135,48,134,19,217,84,83,5,214,49,89,144,142,237,234,53,112,16,172,95,104,234,96,40,17,243,17,212,156,173,8,165,168,185,161,204,127,175,85,115,171,55,181,203,176,101,224,43,174,139,5,143,243,130,251,185,247,26,95,171,111,143,47,28,93,129,171,96,32,26,34,132,10,146,34,133,9,236,178,52,134,129,166,34,76,77,124,98,53,71,57,105,94,141,189,57,7,177,26,231,240,254,151,186,37,193,245,182,40,27,54,114,38,89,77,82,30,196,24,10,232,227,53,70,167,208,185,212,200,227,222,108,59,157,83,216,221,26,82,223,52,55,80,149,60,108,207,9,11,23,222,78,120,218,21,221,58,105,215,177,189,219,82,3,103,226,132,156,17,102,139,124,229,217,167,4,140,149,231,107,10,141,140,94,18,99,37,19,149,244,163,40,118,54,178,104,143,118,65,45,130,8,215,16,40,226,192,116,127,107,66,244,99,59,19,29,105,134,63,249,143,215,96,162,105,189,147,159,182,39,255,4,162,142,163,126,94,232,2,77,33,141,13,79,32,137,124,254,35,236,214,111,97,203,64,22,9,208,63,171,63,64,224,224,6,31,128,128,27,236,120,162,213,135,149,112,66,237,51,250,20,221,208,31,133,44,21,237,86,176,129,206,85,11,49,154,236,145,92,28,39,89,61,6,192,230,204,5,73,32,19,199,2,190,232,220,164,79,141,32,76,203,48,140,209,98,162,229,151,167,159,120,128,220,215,146,209,184,95,80,44,199,59,34,16,204,109,241,30,99,48,119,16,199,142,92,182,211,201,123,80,206,128,23,248,5,136,30,193,247,5,14,138,140,243,114,169,160,26,96,246,93,253,193,192,141,131,98,142,168,146,123,104,128,209,238,36,67,103,53,238,51,45,222,43,26,244,117,123,5,173,24,120,16,186,226,140,20,62,37,123,66,7,251,134,20,203,144,116,17,204,165,165,137,228,43,95,148,24,254,54,75,26,152,224,174,29,130,96,75,220,31,40,144,15,210,212,120,228,119,207,95,42,224,164,151,96,94,31,31,142,5,78,194,250,216,150,161,182,225,40,71,5,96,171,151,240,4,204,67,96,253,75,68,34,152,67,134,54,127,118,124,152,143,178,191,216,17,44,159,73,250,89,27,72,155,48,254,222,244,68,130,147,28,161,99,27,112,17,252,219,116,216,240,171,175,204,216,1,221,182,1,229,102,75,240,222,46,138,74,205,133,143,28,193,132,248,163,243,5,60,25,190,121,136,87,197,186,130,112,60,194,127,8,10,188,4,11,172,189,246,209,69,238,107,21,218,175,164,126,153,245,166,244,36,100,57,171,89,244,140,198,47,1,187,156,186,105,45,227,26,32,243,137,109,60,138,148,146,16,193,67,218,201,227,94,3,99,7,108,233,185,160,36,246,255,174,238,122,64,108,75,17,82,126,122,222,123,130,54,51,166,138,160,145,81,99,83,136,53,23,205,115,208,123,54,6,196,145,29,221,103,63,123,226,232,252,160,124,33,208,54,227,154,64,122,135,46,68,58,79,48,61,127,23,237,51,112,144,14,33,37,253,215,127,119,170,27,132,166,21,11,199,144,0,61,39,167,196,194,141,12,71,242,144,109,103,102,80,254,47,156,52,200,232,241,111,172,240,60,241,52,164,245,180,132,234,83,125,177,108,218,74,71,208,128,253,102,168,103,119,106,139,32,178,50,145,163,238,24,177,203,105,47,72,147,71,68,243,28,79,234,1,129,81,6,247,200,11,88,230,247,202,218,99,34,170,120,151,152,229,131,162,68,84,13,49,50,32,72,141,147,20,51,233,58,203,97,227,96,71,124,95,221,84,245,135,74,88,62,38,80,74,235,239,217,108,30,190,190,52,78,184,28,194,209,208,83,250,109,185,94,176,29,112,189,8,224,176,251,161,247,129,110,240,204,77,95,219,174,151,240,137,236,213,30,7,124,75,147,47,127,88,155,175,191,103,207,196,133,49,152,125,166,25,232,187,153,91,164,228,226,212,216,157,242,120,84,188,57,156,124,11,26,179,94,45,33,52,149,237,31,176,224,192,154,95,46,42,131,124,231,10,182,18,248,216,115,202,158,142,65,107,237,50,191,201,119,249,219,26,74,133,231,134,169,252,28,88,128,69,42,209,50,152,217,76,39,222,52,178,199,37,45,13,212,150,165,201,51,201,154,217,170,115,49,176,65,114,81,12,211,196,21,188,156,141,135,147,81,69,16,139,82,5,110,74,236,107,193,98,208,2,66,46,125,227,208,64,246,29,167,21,188,206,57,132,63,68,32,64,34,37,99,237,134,14,30,44,218,60,254,19,217,216,240,170,132,153,251,4,138,176,17,137,116,175,159,210,57,29,249,40,149,206,241,187,164,214,30,131,104,176,202,9,142,59,188,229,93,118,118,58,71,206,51,133,22,240,85,46,91,99,186,128,69,194,20,210,113,55,44,154,19,25,101,52,56,104,54,208,232,169,126,156,8,177,1,174,176,41,42,24,121,94,146,240,55,49,81,55,8,22,44,104,76,64,218,141,208,138,172,64,219,129,158,210,86,235,132,135,55,16,48,178,175,245,216,196,225,192,130,169,119,67,29,97,137,34,248,68,28,207,146,161,238,135,64,250,184,6,211,23,4,217,23,192,216,3,109,37,129,67,36,63,1,181,43,162,161,28,211,114,203,22,6,54,35,219,124,91,41,36,214,94,219,225,91,184,41,198,73,145,24,239,230,47,90,140,59,70,12,106,28,20,118,92,12,125,205,83,118,90,206,82,206,138,14,125,10,134,142,28,9,222,64,26,243,126,231,33,101,74,114,162,40,192,184,189,155,54,49,91,204,138,185,100,15,215,193,23,122,86,222,161,197,199,246,19,236,20,8,245,190,105,40,242,230,4,151,47,162,156,81,231,26,36,181,81,182,145,19,15,193,203,150,233,85,105,132,62,138,172,38,210,188,104,60,80,204,251,203,99,119,90,205,106,176,39,102,90,173,165,141,210,77,131,108,33,55,29,8,247,208,55,68,123,61,146,51,40,10,133,13,213,232,228,234,113,13,120,26,91,24,216,210,102,102,123,130,83,115,106,207,91,14,64,169,143,227,209,255,228,127,254,79,216,11,103,10,18,97,51,40,99,19,233,221,108,100,243,156,162,178,55,79,226,160,65,127,121,219,56,53,120,224,14,54,220,4,105,194,51,198,28,21,169,189,216,27,20,68,139,189,193,123,22,133,245,86,6,139,147,1,241,203,158,108,86,96,181,224,177,26,91,209,211,63,80,17,63,178,231,95,88,4,68,101,185,198,179,19,177,120,187,106,73,120,189,5,206,185,174,98,48,39,68,250,171,137,97,146,225,190,18,211,244,170,95,4,31,183,26,99,53,55,245,212,3,168,80,81,72,64,39,158,49,40,198,176,245,222,192,108,195,81,121,146,22,216,103,206,22,170,119,195,5,241,172,55,218,192,179,196,82,131,96,59,61,62,138,95,236,198,179,16,139,239,157,141,202,191,45,90,109,135,125,245,85,122,144,71,65,157,102,170,17,104,147,227,35,121,222,42,24,68,216,173,158,65,218,131,103,228,174,225,169,174,236,219,162,154,47,76,137,251,180,83,43,16,179,80,239,153,78,13,218,102,168,68,72,93,211,209,58,236,0,222,188,233,171,23,133,160,151,45,10,22,45,112,176,44,130,163,224,186,120,196,76,94,235,79,211,59,159,234,10,10,75,26,99,37,68,45,228,212,17,70,122,48,81,96,159,142,62,133,117,22,26,160,102,198,51,181,44,81,160,5,113,11,131,137,48,191,56,125,143,14,140,192,20,236,196,242,178,4,233,13,116,122,53,131,200,56,74,81,84,96,140,188,171,114,38,135,222,134,39,45,0,29,73,48,126,61,246,220,19,232,153,56,131,246,232,185,244,43,137,233,196,27,195,214,206,4,181,156,61,52,78,105,206,1,4,62,155,117,18,84,129,10,77,97,217,153,130,69,211,130,118,130,229,24,92,142,10,194,222,40,113,95,113,11,92,23,191,53,219,174,31,33,42,144,61,250,24,88,110,198,176,182,150,97,128,146,222,220,160,9,163,113,44,187,125,78,48,40,145,198,147,196,176,73,60,201,40,198,52,24,234,76,223,238,22,245,233,53,157,194,13,242,25,171,30,217,225,84,139,111,166,128,100,222,106,75,121,6,249,163,164,69,110,129,10,51,87,78,4,75,251,5,250,174,249,118,230,36,149,128,28,13,238,3,46,166,39,199,98,166,63,27,84,54,86,170,37,45,56,163,53,171,57,198,163,107,180,222,40,1,135,213,34,116,42,16,108,53,180,202,242,204,230,22,93,72,49,119,57,198,68,64,83,31,139,55,236,225,127,227,121,192,182,226,89,232,46,236,196,201,117,143,36,108,138,114,201,126,27,202,142,49,126,108,131,88,178,231,79,255,48,139,139,111,216,70,100,221,32,219,141,97,43,80,56,220,218,49,87,24,21,39,214,74,181,211,78,167,40,52,53,111,221,96,3,163,76,187,122,149,122,14,113,128,18,82,22,254,43,205,103,226,100,10,152,224,122,3,120,81,187,129,253,101,131,120,164,136,139,234,22,149,59,107,70,197,25,2,125,220,203,59,242,102,42,102,131,243,107,161,146,156,67,9,7,219,118,1,100,128,64,231,68,76,57,162,7,7,51,201,13,4,48,222,160,215,20,72,61,238,224,9,1,90,98,45,0,112,173,69,149,160,15,246,232,26,139,254,52,237,168,169,77,187,89,40,161,248,193,106,70,15,70,88,131,179,35,104,78,129,192,20,24,47,189,249,168,207,152,10,146,30,17,16,153,13,133,217,223,4,57,195,20,141,163,71,191,254,106,64,164,134,224,20,190,200,132,251,60,163,95,147,244,47,43,27,13,101,113,199,142,224,56,28,147,39,79,83,247,136,133,21,157,128,144,228,218,252,197,2,66,14,168,108,155,45,113,153,222,148,43,40,24,118,196,113,249,43,217,77,211,220,101,178,254,101,244,93,157,129,255,192,188,115,13,254,202,133,82,32,7,57,53,172,19,153,92,166,107,106,144,50,227,153,111,115,248,85,28,33,125,144,147,175,36,0,117,120,21,252,22,113,83,133,194,189,128,18,133,66,195,150,137,68,112,56,8,72,172,185,134,46,27,170,158,123,13,4,107,0,63,59,144,45,66,208,197,116,167,104,70,99,8,213,139,227,145,193,238,135,253,118,97,203,192,2,235,98,183,116,196,209,196,26,169,10,194,140,162,67,137,6,13,28,140,53,166,107,194,113,69,171,0,252,0,99,98,10,178,42,144,26,27,72,84,17,225,226,66,27,161,200,166,26,198,174,134,209,131,75,127,221,32,133,60,153,96,4,129,9,219,19,40,213,135,235,226,74,67,189,166,161,116,250,188,144,80,218,146,24,100,193,100,182,180,190,220,42,69,122,182,177,148,236,179,182,14,22,79,216,3,30,3,7,185,6,204,9,18,97,242,166,21,14,149,214,141,13,154,202,183,182,208,29,138,118,215,93,70,169,23,241,58,37,178,122,83,237,22,81,36,223,53,76,37,107,241,250,9,44,144,92,2,237,179,14,84,91,246,203,215,148,115,183,245,245,242,24,72,250,170,24,227,193,104,17,46,157,39,58,24,112,144,221,249,124,0,187,64,80,118,53,187,105,215,75,87,70,35,106,128,185,13,216,73,11,48,209,169,106,213,5,201,226,184,106,226,57,206,204,169,21,123,144,167,116,81,39,51,75,42,182,5,139,20,156,15,59,135,51,61,176,165,191,64,54,104,2,38,131,126,197,140,41,81,14,155,242,255,84,20,196,231,127,13,63,139,201,36,58,138,195,61,94,123,246,243,211,205,29,5,252,72,157,63,84,242,4,81,106,144,212,9,34,201,26,78,74,156,41,80,39,111,42,12,155,128,61,63,6,21,14,218,218,221,68,128,54,144,221,102,204,222,9,126,148,17,239,16,29,126,176,225,168,84,120,176,197,128,17,220,198,143,60,47,154,125,63,98,223,137,191,252,147,96,141,253,179,232,66,248,144,152,121,154,253,106,236,120,162,30,159,252,209,226,8,10,56,251,110,245,74,216,254,121,36,177,180,147,198,70,246,241,145,243,219,182,118,23,93,184,0,173,151,166,227,97,241,65,112,133,128,89,65,233,148,10,216,198,253,148,209,193,207,22,198,38,139,7,131,242,144,152,178,100,147,17,119,142,120,131,1,74,218,246,226,59,47,21,121,55,124,96,140,14,167,24,87,71,102,129,14,14,168,55,91,152,19,154,41,131,58,47,218,155,16,188,121,102,168,148,62,195,24,224,19,30,96,212,5,105,226,54,142,176,189,141,54,179,20,67,203,205,102,233,76,41,169,64,27,34,109,88,17,106,155,24,75,20,59,206,101,162,185,183,175,159,233,22,221,215,85,187,190,104,103,77,121,1,153,194,91,164,102,47,140,239,163,166,18,80,233,37,242,122,129,248,249,62,31,19,114,234,80,255,12,131,248,62,104,40,129,204,234,229,114,93,153,208,79,185,44,187,94,48,71,81,83,143,172,107,146,3,221,38,186,122,205,36,0,35,161,128,238,47,161,183,230,209,4,132,243,160,157,132,161,165,98,171,83,110,208,224,7,200,176,93,150,204,239,41,116,166,61,29,18,64,81,214,98,11,52,93,54,193,147,109,253,53,79,28,66,74,175,186,223,208,2,193,176,126,188,251,192,250,61,68,31,23,163,106,169,208,124,92,39,184,161,120,189,70,47,113,115,17,30,138,208,123,215,224,89,153,78,131,129,227,0,134,242,226,22,11,232,182,110,124,172,112,123,145,9,120,191,83,24,67,7,247,252,121,13,29,135,27,10,119,226,81,88,139,181,54,42,177,74,144,59,110,12,79,246,156,248,249,17,60,154,86,67,133,144,139,38,134,95,64,234,230,40,15,53,124,186,199,241,189,252,193,206,239,5,188,177,253,225,61,39,201,205,177,189,64,252,111,15,202,19,236,6,90,172,19,182,7,24,75,121,3,181,71,85,220,229,204,98,164,34,232,96,102,244,244,46,216,38,148,6,225,154,120,190,61,216,88,55,24,192,61,10,230,14,11,22,43,22,92,177,248,233,246,32,67,21,98,128,38,85,208,246,96,251,148,137,1,63,168,157,238,60,76,164,143,220,8,209,171,207,63,38,155,22,127,126,105,225,134,227,139,233,0,73,108,219,226,193,46,142,43,138,106,113,147,85,65,139,148,141,65,248,254,212,22,202,248,226,202,26,147,27,244,166,13,187,126,211,212,235,85,203,178,223,63,77,179,109,142,123,147,22,248,174,118,49,160,135,208,1,80,15,1,169,82,81,123,211,163,0,30,34,38,68,249,142,120,169,182,191,18,165,187,231,157,40,222,121,69,115,27,138,15,44,244,38,146,181,95,73,215,94,148,26,200,235,126,96,152,232,238,23,57,183,232,208,140,240,231,37,113,252,219,144,82,170,153,227,236,20,207,211,89,13,121,113,145,41,156,68,134,78,95,104,244,64,129,203,228,30,244,78,47,177,231,206,88,96,40,242,33,206,103,164,12,61,93,107,4,227,109,121,26,163,154,67,84,141,42,255,238,121,2,131,253,122,145,95,131,136,107,89,161,69,101,72,24,48,135,139,190,249,87,16,65,52,127,239,1,246,26,185,233,253,71,61,188,139,187,238,80,91,23,196,49,226,6,116,77,4,63,245,171,132,239,59,147,187,31,179,240,174,106,219,226,246,177,129,200,244,221,207,192,12,95,73,151,172,183,27,172,149,244,202,36,135,239,77,103,102,212,9,31,135,23,127,223,239,89,45,7,72,55,36,115,222,132,81,5,241,113,90,120,29,91,146,8,92,76,238,238,149,73,156,247,33,237,120,120,59,94,97,236,107,37,246,16,167,98,56,81,197,175,95,150,13,228,94,118,119,33,178,235,144,136,250,78,50,253,68,8,97,123,35,166,157,247,22,89,48,11,16,146,64,148,5,11,168,199,101,248,115,136,135,234,7,70,241,154,251,106,130,251,119,44,121,28,35,6,120,77,98,154,137,52,66,250,154,30,91,159,97,246,6,236,158,166,1,11,136,75,239,85,3,73,161,229,143,69,217,137,12,229,64,114,5,175,118,206,211,189,66,187,68,87,163,130,31,166,22,197,237,105,53,85,128,253,220,94,157,71,5,231,244,11,7,65,224,245,22,152,170,195,223,83,160,251,99,180,188,237,205,123,154,195,37,222,16,134,208,92,181,104,15,146,154,179,141,61,151,214,221,227,210,56,99,228,141,31,37,134,177,154,144,139,109,166,11,165,86,227,4,69,254,156,61,125,242,228,201,3,90,77,180,180,218,175,214,234,157,237,203,123,221,179,185,49,112,139,39,154,48,130,196,109,30,232,32,134,15,148,15,224,143,19,227,239,14,158,58,120,104,91,20,57,157,100,83,20,251,94,138,184,183,95,156,238,221,177,116,191,194,48,59,172,169,8,19,30,10,219,229,121,70,210,18,248,24,188,19,48,201,217,120,17,104,57,131,149,172,34,239,13,194,182,182,9,205,212,197,6,253,42,32,97,127,246,230,46,122,11,130,182,79,80,145,133,101,50,84,18,85,105,30,167,38,105,157,108,170,52,69,155,41,152,170,180,135,101,234,207,78,214,26,84,27,2,144,253,164,13,233,49,108,73,118,90,29,147,119,215,19,134,12,90,221,59,254,56,180,234,95,244,212,182,99,223,148,125,159,246,52,161,146,199,85,41,248,222,183,96,118,157,77,119,101,208,27,56,221,194,73,110,16,143,32,27,124,140,254,241,238,112,30,60,225,117,12,123,39,247,186,252,167,135,56,73,238,151,14,137,180,87,92,163,189,135,85,81,52,45,18,100,208,158,13,85,242,73,7,37,236,111,169,202,132,200,235,245,156,125,202,146,239,28,93,20,189,147,210,201,2,203,112,248,223,109,95,66,153,202,156,126,144,70,35,228,213,6,245,94,30,210,43,100,255,223,237,38,189,136,122,25,62,235,54,173,200,99,239,83,84,9,239,253,1,12,1,93,247,184,173,41,112,15,75,224,33,54,57,221,0,73,100,59,175,237,176,214,223,223,20,200,219,214,138,164,111,96,73,246,196,171,100,97,37,132,242,84,99,156,188,83,250,210,115,184,250,180,234,106,17,6,61,47,192,49,115,231,165,169,192,82,144,62,117,97,97,34,172,38,42,9,9,130,243,35,19,253,253,203,17,28,251,121,16,52,69,117,132,124,51,16,217,218,135,99,156,170,109,80,9,113,112,146,143,229,105,26,72,79,250,215,116,58,3,63,233,22,234,178,128,201,133,113,166,23,44,170,154,188,83,117,47,255,88,153,41,139,73,254,52,149,190,59,205,26,37,252,131,75,230,126,218,45,127,30,74,172,248,232,224,141,190,80,26,202,254,186,236,186,94,128,175,87,194,115,220,222,116,177,234,5,22,28,26,248,209,239,69,105,189,219,30,112,133,53,160,227,154,154,119,247,216,157,250,135,160,108,24,32,80,131,178,238,102,227,230,148,220,205,135,248,77,215,228,61,126,84,153,41,59,153,122,76,113,103,112,252,179,59,22,53,123,247,165,187,70,115,155,11,148,140,92,103,113,105,76,28,253,244,147,20,201,214,239,177,178,102,208,253,233,187,183,96,48,102,190,147,130,159,200,112,196,129,255,7,42,19,14,181,137,139,188,11,107,91,27,3,245,108,134,202,111,46,172,245,84,40,254,247,92,178,97,237,178,140,136,40,158,112,229,129,224,241,40,206,244,40,90,44,63,134,55,48,229,109,103,236,110,185,51,191,14,101,231,108,47,101,183,63,7,149,144,117,250,169,255,240,211,255,1,38,99,105,83,199,117,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCESMassMailingFinishedMsgLocalizableString());
			LocalizableStrings.Add(CreateCESMassMailingStoppedMsgLocalizableString());
			LocalizableStrings.Add(CreateCESPingFailsMsgLocalizableString());
			LocalizableStrings.Add(CreateCESTemplateFailsMsgLocalizableString());
			LocalizableStrings.Add(CreateCESNoRecipientsMsgLocalizableString());
			LocalizableStrings.Add(CreateCESMassMailingNotAllSentMsgLocalizableString());
			LocalizableStrings.Add(CreateRemindingMsgCaptionLocalizableString());
			LocalizableStrings.Add(CreateErrorLicPackageMsgLocalizableString());
			LocalizableStrings.Add(CreateErrorCountContactsMsgLocalizableString());
			LocalizableStrings.Add(CreateRedirectHtmlPageWithSysSettingLocalizableString());
			LocalizableStrings.Add(CreateUpdateSplitTestAudienceSuccessMessageLocalizableString());
			LocalizableStrings.Add(CreateCESStoppedMailingMsgLocalizableString());
			LocalizableStrings.Add(CreateRedirectHtmlPageWithoutSysSettingTrueLocalizableString());
			LocalizableStrings.Add(CreateRedirectHtmlPageWithoutSysSettingFalseLocalizableString());
			LocalizableStrings.Add(CreateSenderEmailValidationPluralWarningLocalizableString());
			LocalizableStrings.Add(CreateSenderEmailValidationSingularWarningLocalizableString());
			LocalizableStrings.Add(CreateDefaultEmailValidationExceptionLocalizableString());
			LocalizableStrings.Add(CreateTemplateSizeValidationPluralWarningLocalizableString());
			LocalizableStrings.Add(CreateTemplateSizeValidationSingularWarningLocalizableString());
			LocalizableStrings.Add(CreateSaveErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateStateUpdateErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateActuailizeAudienceFromCampaignErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateTemplateSaveErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateBatchProcessingErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateSendToCloudErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateLicenceErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateCloudUnreachableMsgLocalizableString());
			LocalizableStrings.Add(CreateCommunicationLimitErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateSendEmailErroMsgLocalizableString());
			LocalizableStrings.Add(CreateBatchSendErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateHandleResultErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateValidateEmailErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateBulkEmailStatusUpdateEventLocalizableString());
			LocalizableStrings.Add(CreateActualizeAudienceBeforeSendEventLocalizableString());
			LocalizableStrings.Add(CreateValidateMessageEventLocalizableString());
			LocalizableStrings.Add(CreateExecuteSendMessageErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateSetBulkEmailErrorStatusErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateAddToMandrillRecipientLocalizableString());
			LocalizableStrings.Add(CreateAddToMandrillRecipientDescriptionLocalizableString());
			LocalizableStrings.Add(CreateAddToMandrillRecipientFromCampaignLocalizableString());
			LocalizableStrings.Add(CreateAddToMandrillRecipientFromCampaignDescriptionLocalizableString());
			LocalizableStrings.Add(CreateStartSendingEmailLocalizableString());
			LocalizableStrings.Add(CreateStartSendingEmailDescriptionLocalizableString());
			LocalizableStrings.Add(CreatePingCesLocalizableString());
			LocalizableStrings.Add(CreatePingCesDescriptionLocalizableString());
			LocalizableStrings.Add(CreatePrepareBatchLocalizableString());
			LocalizableStrings.Add(CreatePrepareBatchDescriptionLocalizableString());
			LocalizableStrings.Add(CreateSentBatchStatusLocalizableString());
			LocalizableStrings.Add(CreateSentBatchStatusDescriptionLocalizableString());
			LocalizableStrings.Add(CreateEmailSentLocalizableString());
			LocalizableStrings.Add(CreateEmailSentDescriptionLocalizableString());
			LocalizableStrings.Add(CreateStartSendingScheduledEmailDescriptionLocalizableString());
			LocalizableStrings.Add(CreateMailingPausedManuallyLocalizableString());
			LocalizableStrings.Add(CreateMailingPausedManuallyDescriptionLocalizableString());
			LocalizableStrings.Add(CreateBatchSendEventLocalizableString());
			LocalizableStrings.Add(CreateTemplateStatusValidationSingularErrorLocalizableString());
			LocalizableStrings.Add(CreateTemplateStatusValidationPluralErrorLocalizableString());
			LocalizableStrings.Add(CreateSenderEmailValidationDefaultESPEmailEmptyLocalizableString());
			LocalizableStrings.Add(CreateSenderEmailValidationDefaultESPEmailNotApprovedLocalizableString());
			LocalizableStrings.Add(CreateSenderEmailValidationDefaultESPEmailWrongLocalizableString());
			LocalizableStrings.Add(CreateTestEmailSendingLocalizableString());
			LocalizableStrings.Add(CreateTestEmailSendingSenderEmailEmptyLocalizableString());
			LocalizableStrings.Add(CreateTestEmailSendingSenderEmailWrongLocalizableString());
			LocalizableStrings.Add(CreateTestEmailSendingSenderNameEmptyLocalizableString());
			LocalizableStrings.Add(CreateTestEmailSendingCommonErrorLocalizableString());
			LocalizableStrings.Add(CreateAudienceSegmentationEventNameLocalizableString());
			LocalizableStrings.Add(CreateAudienceSegmentationErrorLocalizableString());
			LocalizableStrings.Add(CreateValidateBulkEmailEventNameLocalizableString());
			LocalizableStrings.Add(CreateTemplateSavedValidationErrorLocalizableString());
			LocalizableStrings.Add(CreateNotAllowedStatusExceptionTextLocalizableString());
			LocalizableStrings.Add(CreateStatusValidationFailedLocalizableString());
			LocalizableStrings.Add(CreateMailingStoppedManuallyErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateMailingStoppedManuallyDescriptionLocalizableString());
			LocalizableStrings.Add(CreateMailingStoppedManuallyLocalizableString());
			LocalizableStrings.Add(CreateExpiredMailingStateSuccessLocalizableString());
			LocalizableStrings.Add(CreateExpiredMailingStateLocalizableString());
			LocalizableStrings.Add(CreateExpiredMailingStateErrorMsgLocalizableString());
			LocalizableStrings.Add(CreateRequestFailedMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledCommunicationLimitMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledSendersNameNotValidMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledSendersDomainNotVerifiedMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledTemplateNotFoundMessageLocalizableString());
			LocalizableStrings.Add(CreateDuplicatedMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledUnsubscribedByTypeMessageLocalizableString());
			LocalizableStrings.Add(CreateUnsubMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledInvalidEmailMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledBlankEmailMessageLocalizableString());
			LocalizableStrings.Add(CreateCanceledIncorrectEmailMessageLocalizableString());
			LocalizableStrings.Add(CreateExpiredEventProgressMessageLczStringCodeLocalizableString());
			LocalizableStrings.Add(CreateExpiredEventProgressCaptionLczStringCodeLocalizableString());
			LocalizableStrings.Add(CreateStopEventProgressMessageLczStringCodeLocalizableString());
			LocalizableStrings.Add(CreateStopEventProgressCaptionLczStringCodeLocalizableString());
			LocalizableStrings.Add(CreateMailingPrepareStopManuallyDescriptionLocalizableString());
			LocalizableStrings.Add(CreateMailingPrepareStopManuallyLocalizableString());
			LocalizableStrings.Add(CreateEmailSendingLimitValidationMessageLocalizableString());
			LocalizableStrings.Add(CreateEmailSentProviderLocalizableString());
			LocalizableStrings.Add(CreateNotConnectedProviderBulkEmailMessageLocalizableString());
			LocalizableStrings.Add(CreateNotConnectedProviderTriggerEmailMessageLocalizableString());
			LocalizableStrings.Add(CreateNotConnectedProviderSplitBulkEmailMessageLocalizableString());
			LocalizableStrings.Add(CreateNoRightToEditBulkEmailMsgLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCESMassMailingFinishedMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b37f5e89-546b-459c-bf25-85cd236787ba"),
				Name = "CESMassMailingFinishedMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCESMassMailingStoppedMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8d6c1599-9b91-403f-b177-5b88775e402b"),
				Name = "CESMassMailingStoppedMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCESPingFailsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3c336255-d514-4497-9310-ca0627a50a34"),
				Name = "CESPingFailsMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCESTemplateFailsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("563e6d5d-549d-4d77-aeb5-207f851a02d0"),
				Name = "CESTemplateFailsMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCESNoRecipientsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d433a364-43b2-4590-81bd-2119ec14ef9a"),
				Name = "CESNoRecipientsMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCESMassMailingNotAllSentMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e7c4a2b1-4f83-4e16-b4c9-256126e27f0b"),
				Name = "CESMassMailingNotAllSentMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemindingMsgCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("10eb4eae-d0c7-4384-ba4c-322cc48c0726"),
				Name = "RemindingMsgCaption",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorLicPackageMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("165af10f-3163-475e-91ca-c0b04f2119b7"),
				Name = "ErrorLicPackageMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateErrorCountContactsMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7fa81679-e759-4a72-92cc-bebf2ca68445"),
				Name = "ErrorCountContactsMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedirectHtmlPageWithSysSettingLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8a664429-7e47-4804-862d-7054749b8ea6"),
				Name = "RedirectHtmlPageWithSysSetting",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUpdateSplitTestAudienceSuccessMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("53868587-de17-437a-a161-f688d7b58046"),
				Name = "UpdateSplitTestAudienceSuccessMessage",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCESStoppedMailingMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5c64c6ff-f392-4054-872b-5c89a102d9c7"),
				Name = "CESStoppedMailingMsg",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedirectHtmlPageWithoutSysSettingTrueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("80081758-9545-47ce-b3bb-26abd9f31523"),
				Name = "RedirectHtmlPageWithoutSysSettingTrue",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRedirectHtmlPageWithoutSysSettingFalseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("476be662-d7be-473c-9430-9b5c35a4be86"),
				Name = "RedirectHtmlPageWithoutSysSettingFalse",
				CreatedInPackageId = new Guid("23cc88d1-c491-40a7-95d9-cd71f8cffc46"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSenderEmailValidationPluralWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("20b8c128-532b-464d-960a-83dac0bba00c"),
				Name = "SenderEmailValidationPluralWarning",
				CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSenderEmailValidationSingularWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1d16214f-e9aa-4e34-9fae-c4dd98f6ca3f"),
				Name = "SenderEmailValidationSingularWarning",
				CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDefaultEmailValidationExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("06b848db-58d4-4f12-92af-a329ba71e0f2"),
				Name = "DefaultEmailValidationException",
				CreatedInPackageId = new Guid("d9a2808f-eb53-4099-acdd-4f36ea5703ba"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateSizeValidationPluralWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("79600903-f5cf-4f43-9841-8507d74c981e"),
				Name = "TemplateSizeValidationPluralWarning",
				CreatedInPackageId = new Guid("430debbd-c061-421c-b80b-6342c36469f6"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateSizeValidationSingularWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d66870fa-42f0-4858-94f0-40427ed7b61d"),
				Name = "TemplateSizeValidationSingularWarning",
				CreatedInPackageId = new Guid("430debbd-c061-421c-b80b-6342c36469f6"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSaveErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f153b59e-ea59-49fe-a35d-f1741b018633"),
				Name = "SaveErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStateUpdateErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("19866b08-417b-49b7-bd5c-d969e1db4a5b"),
				Name = "StateUpdateErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateActuailizeAudienceFromCampaignErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9b3f287d-3d19-480a-b509-51293b6b9e16"),
				Name = "ActuailizeAudienceFromCampaignErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateSaveErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5a38b683-06b0-4c1b-a504-4a46f0e55710"),
				Name = "TemplateSaveErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBatchProcessingErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7b8b6fc2-3e00-4878-ae14-3267275b6178"),
				Name = "BatchProcessingErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSendToCloudErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("98ce831f-71ae-45d3-995b-d71cdd65882e"),
				Name = "SendToCloudErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLicenceErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0e7ee3c5-3c2e-4d59-9e40-1f4cfb50beff"),
				Name = "LicenceErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCloudUnreachableMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("62482fec-22b2-491a-9cb6-bd84161ecae5"),
				Name = "CloudUnreachableMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCommunicationLimitErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab870fbc-f637-41f3-9232-9b5194fc64dc"),
				Name = "CommunicationLimitErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSendEmailErroMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("719f98cd-025f-424f-abdc-04f81cb0d856"),
				Name = "SendEmailErroMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBatchSendErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("44681956-dbf6-411f-b8c2-c79d3b0fdc6c"),
				Name = "BatchSendErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateHandleResultErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9335cb16-c9bb-4ec3-a0a6-e947b0a09c70"),
				Name = "HandleResultErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidateEmailErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f9cc3ef3-55e0-4a51-b753-46c5b41476f0"),
				Name = "ValidateEmailErrorMsg",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBulkEmailStatusUpdateEventLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5054eec9-9fa1-4552-80a1-a80b815ae5fa"),
				Name = "BulkEmailStatusUpdateEvent",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateActualizeAudienceBeforeSendEventLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5709331a-ccd3-4fa4-94b8-c7a42c288f06"),
				Name = "ActualizeAudienceBeforeSendEvent",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidateMessageEventLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ec17d073-7618-4750-84b8-96a861d06e5f"),
				Name = "ValidateMessageEvent",
				CreatedInPackageId = new Guid("d2391b14-d4ce-42b6-9398-2cd970d916ea"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExecuteSendMessageErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9b599781-eb43-43b3-ac7f-99a2e6a5fc1a"),
				Name = "ExecuteSendMessageErrorMsg",
				CreatedInPackageId = new Guid("d103a5f7-d621-4c18-a43f-607935b9fbd1"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSetBulkEmailErrorStatusErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("306a6678-50db-4af1-83e0-30e39347f316"),
				Name = "SetBulkEmailErrorStatusErrorMsg",
				CreatedInPackageId = new Guid("d103a5f7-d621-4c18-a43f-607935b9fbd1"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddToMandrillRecipientLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("781534f3-cc96-48a2-a09f-58f330672b7f"),
				Name = "AddToMandrillRecipient",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddToMandrillRecipientDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b27b356b-0a3f-4f39-93ca-1d18b9fa6bfc"),
				Name = "AddToMandrillRecipientDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddToMandrillRecipientFromCampaignLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("45db33a1-9896-4372-b83f-62d98e4431e6"),
				Name = "AddToMandrillRecipientFromCampaign",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAddToMandrillRecipientFromCampaignDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("003e109a-2748-4bec-9b3e-1fd9e6807099"),
				Name = "AddToMandrillRecipientFromCampaignDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartSendingEmailLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1c1b316a-8ac3-40d9-84c9-ddecdba8c077"),
				Name = "StartSendingEmail",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartSendingEmailDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cf3110e4-5cf6-4f2f-9c2d-025bc2eb189d"),
				Name = "StartSendingEmailDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePingCesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("027965c6-048c-4110-9cff-0de601c3f180"),
				Name = "PingCes",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePingCesDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9be5caaa-1bdd-4d5a-99ed-ed0654f70fcb"),
				Name = "PingCesDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePrepareBatchLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a741aed3-fcc5-48af-981c-359c6ac1e5df"),
				Name = "PrepareBatch",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePrepareBatchDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5b7f6eb2-6422-420f-8cc8-0a903ab9adc6"),
				Name = "PrepareBatchDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSentBatchStatusLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c7e3218a-ae51-4eb6-9b72-b749f341c24e"),
				Name = "SentBatchStatus",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSentBatchStatusDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("44c9c369-dd74-42b0-b791-a7ec4910d733"),
				Name = "SentBatchStatusDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailSentLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5f2b1a60-1197-4e81-95d0-ccaa4dc84436"),
				Name = "EmailSent",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailSentDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("136ab440-3268-4e35-a5ff-439172c1c231"),
				Name = "EmailSentDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartSendingScheduledEmailDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a5bd84b-e1c8-4145-b890-f2a8de559ba5"),
				Name = "StartSendingScheduledEmailDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingPausedManuallyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fb1a33f0-0ada-4ce0-be51-74725922213c"),
				Name = "MailingPausedManually",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingPausedManuallyDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e2188be6-3aa5-4c91-b7c2-ed22e42330e1"),
				Name = "MailingPausedManuallyDescription",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBatchSendEventLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("59875fa8-66a3-4350-b9ae-51e56ae4b78b"),
				Name = "BatchSendEvent",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateStatusValidationSingularErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2b6e09b1-219c-432b-b8e8-d68d71d7aece"),
				Name = "TemplateStatusValidationSingularError",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateStatusValidationPluralErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("deb31dd5-377e-4ddf-b9b6-19b36104d141"),
				Name = "TemplateStatusValidationPluralError",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSenderEmailValidationDefaultESPEmailEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9be556a6-1793-4589-b8ca-cccd00c5f760"),
				Name = "SenderEmailValidationDefaultESPEmailEmpty",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSenderEmailValidationDefaultESPEmailNotApprovedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("502ac493-8a16-4e61-b33e-65ee48e77815"),
				Name = "SenderEmailValidationDefaultESPEmailNotApproved",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSenderEmailValidationDefaultESPEmailWrongLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c5f48c30-7e5b-4e73-ad29-cba658e1a24a"),
				Name = "SenderEmailValidationDefaultESPEmailWrong",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTestEmailSendingLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6a898d92-fe17-4cc8-a08c-2c09b1019434"),
				Name = "TestEmailSending",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTestEmailSendingSenderEmailEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3a2ade88-fb54-467a-afaf-5ffc8f3897e1"),
				Name = "TestEmailSendingSenderEmailEmpty",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTestEmailSendingSenderEmailWrongLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("83dd59cc-90d3-4ce7-b0a9-392505be4c98"),
				Name = "TestEmailSendingSenderEmailWrong",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTestEmailSendingSenderNameEmptyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7d44dd0e-572e-40ab-85e0-983b340aa9ae"),
				Name = "TestEmailSendingSenderNameEmpty",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTestEmailSendingCommonErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2eac2dc6-5a4a-45f4-b71a-5f22dd2b20c7"),
				Name = "TestEmailSendingCommonError",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAudienceSegmentationEventNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6f4cef81-5d6f-4eb1-af13-98d79c3e3943"),
				Name = "AudienceSegmentationEventName",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAudienceSegmentationErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa0fd048-6859-4b62-8977-09d8081a4140"),
				Name = "AudienceSegmentationError",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateValidateBulkEmailEventNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2ab710b0-1805-4431-9132-78442c11e4e5"),
				Name = "ValidateBulkEmailEventName",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateSavedValidationErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c334e71-9c36-4c98-9b94-1338454f0bc5"),
				Name = "TemplateSavedValidationError",
				CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotAllowedStatusExceptionTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("411647ff-cb05-69d2-370b-622d77e915dd"),
				Name = "NotAllowedStatusExceptionText",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStatusValidationFailedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0e20ebba-66e7-81d1-0a7c-05c0045df28f"),
				Name = "StatusValidationFailed",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingStoppedManuallyErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6bd345dd-7642-b0c7-7046-7f53c57d81c5"),
				Name = "MailingStoppedManuallyErrorMsg",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingStoppedManuallyDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("cd1db679-1686-6db2-0e53-35b5ecd6170a"),
				Name = "MailingStoppedManuallyDescription",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingStoppedManuallyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("76bd662d-9f6e-beca-cfe8-a5cae9923a4e"),
				Name = "MailingStoppedManually",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExpiredMailingStateSuccessLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("670ea86d-de0c-0391-10fc-4fb6b6304d6b"),
				Name = "ExpiredMailingStateSuccess",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExpiredMailingStateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("75877d2f-064f-ae98-193b-e77f9ea5c3d7"),
				Name = "ExpiredMailingState",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExpiredMailingStateErrorMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1a8d472c-b47c-af2b-5ee3-2dbdd97a6c8c"),
				Name = "ExpiredMailingStateErrorMsg",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRequestFailedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f17a1aa5-098d-9d23-8b75-d95c7f870ef8"),
				Name = "RequestFailedMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledCommunicationLimitMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9d8bacf1-553d-6b8d-4352-2cdc5c5152ec"),
				Name = "CanceledCommunicationLimitMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledSendersNameNotValidMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ad2e60ae-b31f-8a1d-8633-b20c30f42726"),
				Name = "CanceledSendersNameNotValidMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledSendersDomainNotVerifiedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f210de79-5e54-5117-5249-fc69d11e3814"),
				Name = "CanceledSendersDomainNotVerifiedMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledTemplateNotFoundMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("077682cd-6ba7-a232-1334-9b028912d62a"),
				Name = "CanceledTemplateNotFoundMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDuplicatedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("560aae31-de40-338d-531f-be3c91167c67"),
				Name = "DuplicatedMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledUnsubscribedByTypeMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3d2a8ca4-f95e-3126-8e3e-55aadd01baa7"),
				Name = "CanceledUnsubscribedByTypeMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateUnsubMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("62d50305-352d-b9d6-bd6e-048a3d6122b3"),
				Name = "UnsubMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledInvalidEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6f31fc06-828c-c5db-f393-f46797681caf"),
				Name = "CanceledInvalidEmailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledBlankEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("59f56067-f31e-3124-7aba-fb9dbc3bb287"),
				Name = "CanceledBlankEmailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCanceledIncorrectEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f5466384-603e-d6d7-f8ee-4f9301df3df6"),
				Name = "CanceledIncorrectEmailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExpiredEventProgressMessageLczStringCodeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("caab86a8-035e-b8f3-29b0-4b0e21fd73f9"),
				Name = "ExpiredEventProgressMessageLczStringCode",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExpiredEventProgressCaptionLczStringCodeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("77512dd2-c681-9348-7f35-57c6fb8dcbdd"),
				Name = "ExpiredEventProgressCaptionLczStringCode",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStopEventProgressMessageLczStringCodeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9e91c439-84ec-0beb-a547-787545118028"),
				Name = "StopEventProgressMessageLczStringCode",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStopEventProgressCaptionLczStringCodeLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d832a973-d0ac-3676-8d1e-da748676a45d"),
				Name = "StopEventProgressCaptionLczStringCode",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingPrepareStopManuallyDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("be4e2f93-4753-2d2b-9563-f45697467451"),
				Name = "MailingPrepareStopManuallyDescription",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMailingPrepareStopManuallyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0981a464-b896-4925-e9c3-de3d634610de"),
				Name = "MailingPrepareStopManually",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailSendingLimitValidationMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2f95cc06-f7df-7443-290b-92853ddbc317"),
				Name = "EmailSendingLimitValidationMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmailSentProviderLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c9dc56a0-5781-6cce-f2e3-a94b70cb6506"),
				Name = "EmailSentProvider",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotConnectedProviderBulkEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e11fc70e-99f9-91ba-3391-d0ee58ba17a4"),
				Name = "NotConnectedProviderBulkEmailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotConnectedProviderTriggerEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("be5ef4aa-d2fd-c377-d7ee-96a113e48cb9"),
				Name = "NotConnectedProviderTriggerEmailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotConnectedProviderSplitBulkEmailMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a2309085-afae-c97b-db06-229b34ee223e"),
				Name = "NotConnectedProviderSplitBulkEmailMessage",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoRightToEditBulkEmailMsgLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e4982ffd-5914-aed5-5c07-f5b3bdd11d7a"),
				Name = "NoRightToEditBulkEmailMsg",
				CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323"),
				CreatedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c"),
				ModifiedInSchemaUId = new Guid("3c51df95-5307-421d-815c-9bf9908a203c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c51df95-5307-421d-815c-9bf9908a203c"));
		}

		#endregion

	}

	#endregion

}

