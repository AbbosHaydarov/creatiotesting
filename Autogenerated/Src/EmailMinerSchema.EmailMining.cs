﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMinerSchema

	/// <exclude/>
	public class EmailMinerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMinerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMinerSchema(EmailMinerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6fb7ccb-c76c-4cf5-bc34-c2fac7c3b5ca");
			Name = "EmailMiner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e20436f2-80ed-4182-a2cd-94f2d77ff547");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,28,219,114,219,54,246,89,157,233,63,32,222,153,150,154,209,50,205,107,98,187,227,107,162,54,23,111,228,182,15,59,59,30,90,130,109,182,20,169,242,226,68,155,250,223,247,28,28,0,196,149,146,18,167,179,121,136,37,16,56,55,156,59,64,149,217,146,55,171,108,206,217,37,175,235,172,169,110,218,244,164,42,111,242,219,174,206,218,188,42,211,179,101,150,23,111,242,50,47,111,191,253,230,211,183,223,140,186,6,62,178,217,186,105,249,242,133,243,29,214,22,5,159,227,194,38,125,201,75,94,231,115,111,206,105,214,102,222,224,235,188,252,211,27,124,223,149,109,190,228,233,12,224,100,69,254,95,65,81,63,235,182,168,174,179,226,249,243,147,106,185,4,74,95,87,183,183,48,220,63,239,89,58,43,129,144,187,37,47,219,116,90,182,188,190,1,142,155,126,226,91,254,161,5,138,113,230,79,141,137,193,20,10,226,8,63,169,121,108,60,61,61,142,62,58,3,222,218,220,36,195,153,112,158,205,219,170,142,204,120,83,149,57,62,21,252,194,243,127,212,252,22,132,195,78,138,172,105,158,51,181,107,188,22,79,159,62,125,202,246,155,110,185,204,234,245,161,252,126,140,32,121,211,176,162,186,205,231,236,166,170,25,199,85,108,149,213,136,44,85,235,158,26,11,87,221,117,1,147,231,136,197,66,50,2,213,128,255,71,171,58,191,207,90,46,103,76,23,32,242,252,38,159,139,157,155,150,55,21,206,65,45,26,41,80,215,85,85,176,105,163,102,242,5,251,196,110,121,251,130,53,248,223,67,96,234,209,188,237,178,194,159,6,255,225,31,151,87,49,112,121,199,89,205,155,174,104,89,117,195,90,248,70,188,46,133,98,35,171,62,175,163,127,163,166,130,53,180,53,236,196,127,4,119,38,251,100,20,239,5,212,158,45,15,189,198,79,24,1,84,126,159,183,107,150,43,142,107,129,62,128,159,8,120,195,151,215,188,78,222,130,165,178,3,182,167,214,79,23,123,99,65,147,34,234,101,151,47,216,145,126,26,16,99,152,52,181,132,113,97,36,172,105,179,182,107,96,34,135,93,172,249,205,193,30,89,207,76,140,239,61,61,220,137,92,110,174,181,9,110,90,84,95,102,66,223,154,104,33,79,162,151,196,186,0,212,176,195,243,170,94,52,159,43,90,0,56,191,19,74,141,15,195,2,62,115,230,124,33,197,82,216,190,180,53,138,207,22,187,15,35,38,126,111,102,212,182,180,151,1,111,217,130,155,185,32,107,119,76,31,31,42,240,182,7,32,211,189,0,119,94,45,192,199,207,120,219,194,164,70,81,109,196,154,248,186,189,23,81,100,198,250,75,136,27,111,56,12,207,181,72,240,225,21,25,252,85,1,107,203,249,250,170,1,141,41,23,13,194,20,252,241,114,65,44,218,252,158,231,188,88,196,248,197,61,4,121,214,60,91,84,101,177,102,83,8,68,236,10,188,42,96,133,143,111,178,50,187,5,77,124,201,91,140,80,176,73,38,159,123,99,139,29,13,228,151,134,215,32,229,146,130,41,187,234,172,239,225,53,83,3,46,132,204,251,124,206,47,234,234,227,154,93,113,237,169,229,120,4,0,58,59,112,48,51,158,129,82,240,154,93,205,237,129,200,178,83,190,232,86,160,83,25,68,36,118,181,48,190,133,23,128,166,113,220,32,118,149,137,141,5,202,112,40,60,89,196,201,245,12,208,47,51,224,4,213,245,146,127,108,205,225,216,66,97,72,52,79,48,240,138,23,43,228,138,71,158,68,216,35,61,122,207,87,85,13,185,3,187,90,218,223,15,40,232,82,184,94,227,62,239,59,75,14,147,241,6,5,19,6,85,119,8,1,213,76,88,232,64,56,155,66,240,23,25,17,111,88,201,63,176,28,86,103,37,100,113,16,220,76,87,162,183,29,252,71,56,198,137,17,136,248,217,146,149,96,40,7,123,182,162,237,29,162,34,162,149,41,77,196,60,65,184,174,10,4,38,140,179,97,73,35,132,200,164,182,52,19,136,114,243,10,146,183,102,156,238,63,21,208,5,50,233,121,122,178,18,71,205,109,228,99,70,33,213,81,126,16,120,192,26,70,247,89,237,140,27,66,61,170,111,59,76,255,96,45,202,43,240,36,113,57,159,184,212,16,26,223,150,130,10,16,49,197,195,100,35,137,10,143,99,122,65,44,142,189,238,0,221,52,210,32,104,211,166,183,135,155,131,136,201,166,79,179,117,67,14,27,193,99,62,107,215,21,134,251,71,132,191,102,69,199,29,52,19,1,114,180,117,8,153,176,103,138,61,203,175,0,1,142,10,165,39,93,93,3,84,84,63,196,46,191,42,191,148,140,211,163,197,2,57,72,254,233,114,163,213,32,228,136,2,152,204,199,70,40,152,74,139,61,94,35,229,16,18,108,112,123,6,154,176,19,35,69,142,249,184,196,33,131,192,61,12,59,33,112,90,119,85,52,204,189,206,155,118,223,204,121,15,97,94,5,117,84,163,42,153,228,52,23,200,192,183,236,19,73,19,6,172,10,83,80,115,96,233,10,180,135,31,98,234,205,23,88,18,40,51,71,3,166,28,189,145,220,249,40,133,35,133,185,224,133,120,6,30,39,249,153,175,133,234,92,100,121,189,5,210,21,76,131,252,176,244,177,143,104,113,159,159,31,208,228,20,48,16,206,81,12,44,82,77,31,212,26,65,146,92,213,214,107,133,98,148,223,176,68,77,78,167,96,112,121,209,213,92,147,48,26,129,58,31,205,41,131,111,104,111,249,34,81,36,165,176,47,232,184,161,200,238,150,165,192,49,17,89,41,20,233,43,228,219,76,165,211,179,186,174,106,41,46,248,135,238,36,47,53,85,168,11,226,175,214,57,96,136,50,83,253,237,64,51,150,154,179,20,4,153,116,113,57,252,42,107,238,96,137,5,2,53,29,199,213,182,105,41,147,90,243,197,123,145,177,195,178,243,188,92,40,134,49,17,77,76,176,122,181,168,0,243,6,234,117,115,46,98,117,224,129,254,116,69,161,150,137,204,221,205,238,123,138,2,249,182,76,204,95,24,251,230,161,53,182,205,99,231,4,212,179,229,206,130,196,146,77,191,53,46,101,30,63,129,141,215,139,101,5,113,192,130,124,164,24,168,52,171,35,34,75,209,100,110,106,226,18,49,97,97,106,31,24,47,64,211,63,61,46,241,206,18,80,155,203,245,138,47,140,53,251,164,110,135,201,158,170,102,92,77,22,187,188,82,200,68,96,236,29,42,18,166,176,162,174,93,88,243,236,157,1,214,61,97,248,187,239,152,65,3,78,85,184,101,109,173,195,76,136,233,123,97,40,2,51,128,162,111,233,217,71,209,129,16,163,16,151,192,40,155,222,160,12,159,139,2,32,135,112,216,151,192,128,158,146,50,128,247,203,10,50,55,46,7,252,222,140,175,3,122,147,109,241,24,84,14,73,134,208,29,81,42,184,13,58,91,229,134,64,163,65,26,84,128,47,125,91,181,111,193,228,223,213,194,23,38,99,195,58,143,86,43,152,58,235,167,7,48,91,44,25,46,218,88,117,90,193,255,229,121,205,185,150,203,40,174,110,81,251,145,127,173,12,44,237,179,45,181,61,194,97,248,187,24,3,43,3,39,230,45,9,134,78,51,106,26,146,232,219,67,134,162,6,194,138,90,224,181,59,132,169,134,149,196,106,228,40,127,36,221,208,105,85,198,128,234,5,228,12,148,152,52,103,187,135,196,141,254,39,72,178,160,81,99,21,37,88,67,84,246,221,99,42,235,26,141,94,77,127,96,176,115,152,142,156,125,156,243,149,40,82,248,199,94,3,177,25,64,241,248,188,170,151,25,212,26,39,89,89,86,208,183,200,238,85,87,8,26,159,162,172,234,251,176,224,205,14,216,167,31,30,82,38,150,62,103,159,158,61,236,105,210,135,37,240,81,83,38,254,208,255,53,111,187,186,84,57,150,153,17,170,28,239,190,2,164,195,172,59,105,146,153,188,193,6,214,34,135,222,228,5,85,158,13,126,144,34,210,226,93,169,92,33,2,42,171,15,159,145,179,247,235,169,201,115,42,75,141,25,159,99,62,89,125,72,103,221,181,240,164,137,166,116,156,94,86,109,86,204,168,13,36,115,110,187,190,79,95,102,221,45,79,162,189,165,137,143,110,28,149,109,80,153,69,224,234,251,186,228,194,3,49,200,50,48,178,22,83,252,157,112,183,192,106,66,142,119,140,126,128,62,186,229,192,132,237,41,87,176,55,134,227,21,208,72,171,201,43,181,140,246,44,189,192,2,158,131,40,80,110,104,41,151,213,76,132,43,240,178,99,154,153,254,6,229,39,148,49,216,52,5,175,121,246,39,212,76,137,183,188,231,113,172,234,69,240,227,94,6,241,228,192,200,106,181,21,17,123,154,88,187,83,59,97,30,50,23,172,66,73,182,32,161,157,125,228,243,14,228,19,223,177,77,65,44,178,87,86,90,221,26,95,164,104,195,153,172,98,22,147,94,96,116,255,93,125,155,149,242,220,139,12,239,144,85,198,24,186,77,19,120,106,46,104,156,82,201,7,102,193,146,67,80,27,89,24,180,252,37,197,142,36,192,109,29,176,155,12,82,66,233,112,112,71,159,12,228,202,50,209,49,113,200,202,193,39,198,47,31,194,248,79,238,248,252,15,106,12,4,55,42,113,177,249,25,158,237,47,101,194,239,225,234,217,112,202,41,185,108,122,86,66,55,164,206,174,11,46,178,177,67,213,8,155,42,231,50,10,18,136,30,82,167,108,198,16,56,193,88,3,64,210,145,74,64,107,9,215,98,85,213,195,150,254,177,170,107,13,178,198,230,190,245,195,152,81,133,211,41,169,240,42,169,198,98,219,204,123,2,185,149,167,13,64,131,71,165,149,218,41,240,232,74,188,116,46,86,201,70,69,133,73,209,57,240,181,144,50,194,98,71,37,105,61,199,147,192,6,4,162,168,227,35,34,233,247,166,76,59,226,53,8,91,220,119,168,131,14,43,91,221,206,149,72,90,148,23,81,173,90,215,129,168,60,147,24,223,165,184,192,104,19,158,239,53,109,44,90,20,41,189,255,81,180,185,174,199,17,231,231,186,30,9,94,122,29,11,123,200,225,132,176,26,14,39,184,199,137,129,99,75,95,227,161,217,221,215,72,164,189,175,9,210,22,247,53,202,149,168,162,216,18,141,235,69,76,21,148,116,162,99,233,105,176,28,75,63,28,119,44,56,209,152,119,34,220,217,24,123,57,207,12,235,247,117,79,212,60,246,54,162,45,25,160,206,161,39,7,160,194,29,131,47,117,101,22,230,191,195,139,41,190,13,47,214,243,186,165,23,83,181,128,47,205,80,34,36,228,228,10,39,226,194,194,222,104,34,11,82,221,254,19,194,146,210,216,96,183,146,84,127,115,108,139,141,218,153,197,176,92,37,219,127,219,240,105,182,57,215,100,208,65,214,173,74,136,227,45,40,76,197,103,226,147,72,197,233,163,215,153,87,129,156,18,88,74,161,101,82,125,94,87,203,192,209,128,157,114,35,73,67,73,119,79,184,74,214,71,233,81,185,8,36,209,131,64,194,201,52,93,75,74,78,143,41,145,198,179,193,107,253,49,116,24,210,64,191,251,244,184,31,50,108,66,194,154,34,134,247,112,248,10,221,52,172,136,229,71,236,134,161,252,84,202,78,195,73,143,206,241,36,79,250,181,41,254,177,140,79,20,228,191,101,117,169,234,113,20,175,220,98,168,20,91,168,194,193,208,216,245,154,221,97,148,248,30,170,240,239,89,6,35,94,173,98,213,228,35,83,73,98,94,191,87,104,93,227,108,242,75,6,43,88,248,26,149,52,197,87,161,51,166,231,217,137,119,225,84,216,18,130,51,92,140,202,74,246,76,120,122,221,215,255,74,82,80,188,90,118,169,187,242,241,132,43,30,211,220,240,53,144,101,108,174,207,66,137,22,198,183,161,168,107,250,51,39,30,53,66,200,211,242,117,214,80,31,87,111,72,191,28,237,197,57,244,77,233,195,241,90,172,105,18,125,40,38,251,200,112,81,199,236,24,63,236,28,115,165,244,163,66,5,2,52,248,64,20,177,104,17,93,43,227,36,194,143,96,234,0,173,73,236,92,194,13,222,146,141,157,68,67,216,141,182,194,54,252,111,100,223,96,252,97,7,154,196,153,174,205,149,176,215,199,38,15,241,236,78,157,72,135,32,4,160,50,6,40,125,153,223,243,146,58,91,246,131,25,16,3,195,143,205,132,32,71,209,242,34,166,93,171,59,104,207,110,210,174,11,49,233,49,181,75,66,36,236,143,205,185,0,30,72,82,244,217,165,227,251,252,66,18,179,149,120,149,233,23,60,27,114,151,62,213,10,64,27,172,105,160,163,40,242,9,51,67,149,49,105,43,38,226,13,54,201,132,44,212,191,148,9,11,204,32,19,146,162,93,152,136,83,191,49,123,180,195,142,72,63,72,97,47,49,212,160,101,40,246,2,168,237,148,95,12,81,61,30,152,43,117,211,186,113,45,203,104,82,196,23,241,44,150,237,144,198,242,155,57,116,101,205,254,126,100,134,111,23,118,254,27,148,69,122,212,16,0,13,117,10,148,212,63,85,121,25,72,152,105,118,11,128,211,119,37,125,18,136,141,140,87,81,227,172,53,146,113,153,110,203,197,159,157,117,203,245,143,145,124,203,132,120,182,226,115,72,123,222,86,175,171,249,31,175,224,6,150,62,29,254,255,204,206,63,220,229,5,31,206,81,245,5,209,185,82,159,193,44,120,232,60,169,55,170,96,207,35,14,84,31,213,135,20,84,195,150,229,46,220,236,130,173,43,214,150,81,133,16,234,46,139,25,7,104,181,134,233,155,51,232,134,5,25,46,223,241,225,233,242,37,137,3,67,130,135,206,117,91,246,215,95,65,202,123,192,216,152,138,3,55,246,203,109,39,244,179,53,48,149,239,63,108,236,69,56,139,67,135,50,39,5,132,231,112,231,109,231,152,39,96,237,210,190,219,62,212,245,180,134,143,37,118,14,109,33,90,31,41,162,245,180,134,137,220,28,193,216,22,193,235,20,188,4,32,91,208,31,136,44,52,64,145,133,62,71,34,203,64,48,176,29,116,200,92,233,126,72,196,189,70,13,50,112,206,73,78,124,12,110,14,114,211,38,81,202,189,57,46,26,129,79,18,32,46,209,38,152,234,105,224,241,150,79,31,193,250,169,118,64,178,66,72,72,76,67,193,205,11,79,159,17,222,30,55,194,73,160,210,209,146,190,12,159,214,10,79,188,177,49,191,179,123,216,54,221,26,76,196,183,57,14,136,122,91,195,243,127,247,29,123,178,141,71,30,240,143,219,144,178,193,45,123,52,13,144,180,205,78,61,146,115,220,97,167,226,213,198,160,55,253,90,59,21,22,192,54,164,124,229,157,162,160,32,50,136,222,109,196,58,255,86,135,31,75,112,124,159,64,220,90,49,157,142,72,131,110,240,178,28,124,144,85,15,221,220,204,240,58,143,188,231,98,93,173,175,186,122,206,89,67,127,232,102,175,14,54,162,51,73,99,74,166,146,2,240,201,61,12,121,146,238,223,216,79,213,149,88,193,89,240,214,60,122,247,126,25,94,64,57,229,55,70,166,168,211,109,123,158,127,47,75,158,181,162,88,212,1,132,15,219,152,31,188,231,50,160,147,74,130,145,11,52,195,168,46,228,98,64,161,224,88,58,38,110,92,210,22,60,177,229,189,1,48,109,31,128,165,213,102,80,53,225,15,3,17,97,124,162,245,198,7,50,188,28,223,234,70,113,1,8,252,8,59,124,207,235,86,191,87,206,223,93,255,142,177,91,237,206,118,64,69,140,156,144,6,254,248,99,191,181,250,68,106,107,40,191,242,186,161,87,142,92,32,242,73,12,22,92,31,28,184,186,52,112,219,123,155,91,75,246,69,83,185,217,219,222,38,194,115,124,251,85,0,235,106,82,239,255,92,231,226,19,101,130,13,186,19,11,180,249,70,132,165,96,195,183,15,124,122,213,129,232,46,164,74,96,97,42,37,64,61,203,34,219,177,54,131,216,229,178,43,165,191,214,36,27,99,33,194,141,199,59,146,111,172,140,49,97,78,145,89,154,181,78,241,25,227,72,222,96,87,247,72,233,155,207,133,156,198,119,98,64,66,11,147,46,33,234,89,155,8,253,169,186,150,68,254,94,93,251,4,194,227,157,104,3,32,97,186,0,144,120,26,166,199,49,108,73,81,248,253,146,205,230,107,189,172,230,188,36,254,24,111,176,105,104,170,69,210,7,99,255,141,29,15,249,150,193,216,132,52,28,142,221,153,159,19,20,108,57,110,9,91,198,134,200,203,80,49,32,189,59,215,39,1,246,148,144,171,151,18,246,94,160,50,18,164,216,238,235,201,95,103,239,177,135,204,155,63,245,171,138,61,168,127,117,188,22,54,226,80,32,23,194,34,149,62,137,153,178,94,156,54,191,230,77,14,229,172,213,1,195,201,96,218,170,171,108,191,29,132,15,223,87,31,196,93,34,88,245,172,31,61,207,11,168,60,233,242,16,126,39,213,163,209,223,242,246,78,23,167,77,66,131,224,249,32,49,202,27,117,50,136,149,172,170,148,41,11,80,251,74,156,246,63,133,3,126,85,127,4,197,7,100,120,16,234,76,138,168,59,157,37,171,73,116,41,10,187,136,63,184,167,76,253,251,110,86,77,96,172,21,231,108,198,171,137,161,203,47,129,87,163,6,110,35,14,93,1,130,45,151,16,116,243,202,138,187,246,155,51,177,107,136,170,247,131,164,191,171,193,208,179,174,208,23,211,216,129,62,125,15,157,176,27,137,177,131,203,201,95,35,247,49,250,188,215,231,69,173,177,33,235,172,222,126,73,206,46,85,156,37,238,141,195,200,109,167,187,141,85,96,40,3,244,223,124,26,110,221,133,238,149,226,11,79,244,234,147,186,159,26,120,209,110,224,66,133,121,43,194,21,151,119,47,142,184,55,229,31,74,128,12,50,207,68,27,145,222,233,247,39,170,195,46,113,185,15,183,23,34,38,254,133,219,98,244,68,213,101,254,109,70,29,140,189,45,147,19,228,1,130,112,125,22,238,254,226,128,81,166,168,119,217,61,53,149,190,76,63,23,103,194,234,68,174,95,165,55,1,207,21,140,175,36,169,94,213,29,43,50,51,65,50,170,188,108,18,91,126,67,210,247,154,191,182,172,96,181,171,192,95,120,253,237,188,43,231,242,234,167,104,105,254,61,87,225,116,241,59,176,216,86,2,253,2,11,184,99,186,122,130,65,99,6,115,181,148,204,243,176,217,60,43,178,122,31,102,235,219,208,226,134,168,191,242,208,115,237,230,126,12,109,47,70,50,103,103,105,233,22,201,169,189,110,155,212,63,108,20,193,214,77,10,110,232,244,90,189,112,132,94,76,111,195,110,63,75,176,233,103,81,222,119,101,227,92,94,131,47,248,198,23,194,233,223,172,51,130,226,150,191,138,66,27,181,119,72,38,107,196,115,4,42,127,68,140,50,28,68,186,236,154,150,93,115,86,84,112,176,184,96,31,96,127,225,216,111,194,142,171,5,176,63,109,94,181,203,130,62,147,107,158,40,156,230,75,88,114,19,244,54,77,100,210,143,71,121,115,161,156,77,232,199,85,238,243,90,156,252,5,126,174,65,181,207,189,252,132,211,221,41,117,70,179,243,175,56,24,160,176,207,38,223,148,211,63,144,146,30,227,203,145,39,112,202,104,223,210,10,144,216,255,254,131,251,219,18,14,34,59,77,14,188,210,232,104,19,141,218,131,48,246,63,193,56,146,142,0,81,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6fb7ccb-c76c-4cf5-bc34-c2fac7c3b5ca"));
		}

		#endregion

	}

	#endregion

}

