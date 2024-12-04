﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommandLineServiceSchema

	/// <exclude/>
	public class CommandLineServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommandLineServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommandLineServiceSchema(CommandLineServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b87ab6e-6041-4741-9e6c-3f96263f72ca");
			Name = "CommandLineService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f40d6a1a-215d-4fa4-bb06-ad44d6a4b01f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,29,107,111,219,70,242,179,10,244,63,176,42,80,72,56,129,73,218,111,78,236,131,237,56,137,239,226,56,181,156,228,131,97,4,180,180,182,121,165,72,133,164,236,232,82,255,247,155,125,207,190,72,74,86,18,23,87,160,136,172,221,217,153,217,217,217,157,199,206,170,121,50,35,213,60,153,144,232,148,148,101,82,21,151,117,188,95,228,151,233,213,162,76,234,180,200,225,219,108,150,228,211,215,105,78,198,164,188,73,39,228,199,31,190,252,248,67,111,81,165,249,85,52,94,86,53,153,197,162,231,168,152,146,236,105,83,103,252,129,92,52,3,236,78,234,244,134,145,214,112,152,183,217,44,212,83,146,80,123,252,124,47,216,117,144,215,105,157,146,42,8,48,174,13,204,156,103,103,14,251,69,150,17,96,189,200,171,248,37,201,73,153,78,28,24,144,225,39,221,248,134,220,214,0,77,233,252,171,242,207,9,132,165,103,12,253,103,66,82,176,66,117,153,76,234,115,218,182,91,205,223,144,26,192,230,32,181,139,52,75,235,229,9,249,180,72,75,50,35,121,93,13,240,23,42,226,104,59,106,25,66,161,98,209,48,29,82,34,243,197,69,150,78,162,73,150,84,85,228,106,68,180,21,237,37,149,252,54,146,243,165,236,143,73,85,129,80,198,117,82,147,248,240,132,36,211,227,60,91,226,214,8,180,9,72,244,126,46,201,21,180,69,111,203,98,78,74,186,36,91,240,55,213,5,194,1,230,252,75,196,86,108,57,158,92,147,89,242,251,130,148,203,232,227,117,154,215,236,207,167,33,64,14,195,91,112,59,23,108,239,103,146,79,57,253,6,102,152,16,120,255,163,71,143,162,103,213,2,4,81,46,119,100,3,157,93,5,205,132,68,147,146,92,110,247,57,33,173,26,253,71,59,17,95,227,106,78,38,233,101,74,166,46,56,154,24,192,199,138,218,35,76,78,44,200,139,69,62,121,230,12,27,185,34,58,158,51,213,148,61,154,165,29,209,66,121,39,101,244,37,186,34,245,211,168,162,255,220,53,139,230,136,212,215,197,180,251,34,189,36,245,193,248,247,15,105,125,205,85,90,139,118,80,213,37,21,10,65,99,222,192,193,52,164,170,209,235,245,110,146,50,34,213,39,80,220,156,220,186,152,7,239,42,82,194,150,200,249,140,98,12,112,148,228,201,21,41,71,46,110,166,41,61,64,27,31,86,207,211,170,78,243,73,13,20,234,114,65,116,215,126,2,3,160,213,162,32,212,151,245,198,116,70,175,139,73,146,209,175,48,141,65,255,253,173,216,34,244,44,19,96,125,65,176,36,245,162,204,233,116,216,247,187,14,82,59,74,38,101,81,129,236,6,207,83,134,16,148,224,25,23,217,40,226,159,59,209,164,200,22,179,156,206,172,146,98,115,145,113,33,54,44,68,159,211,146,204,82,17,192,234,82,173,99,8,246,25,17,16,216,110,118,155,44,171,49,161,74,100,8,205,161,201,135,68,115,142,69,124,219,142,252,152,57,14,52,149,120,119,58,29,244,15,167,253,145,137,33,70,75,24,34,57,73,152,206,27,36,1,29,255,62,232,83,12,114,158,14,197,125,62,22,200,26,88,48,89,103,12,197,173,134,245,251,109,220,149,4,22,124,186,183,12,241,183,47,1,90,49,113,93,219,135,67,59,132,107,91,232,35,24,147,105,195,164,105,231,200,197,215,73,216,236,67,204,63,196,198,14,252,157,50,5,206,222,38,101,194,140,166,30,213,192,23,134,26,249,104,117,97,177,90,92,252,7,212,181,51,115,99,12,255,14,116,48,196,159,3,8,187,18,55,173,192,28,239,8,46,227,81,146,230,6,115,28,190,3,115,26,112,228,163,213,133,197,153,36,78,97,59,176,216,184,193,20,152,94,86,15,254,46,108,213,203,121,23,110,182,207,192,41,1,199,102,145,17,142,105,11,190,99,156,32,155,45,91,88,231,241,169,194,222,36,100,19,106,132,120,106,60,49,142,75,48,185,28,174,203,145,161,4,116,218,48,229,35,12,212,129,97,177,233,61,184,187,8,63,173,198,215,9,56,137,33,110,14,69,63,54,40,47,210,172,38,37,103,132,217,88,118,208,29,86,111,138,250,205,34,203,120,55,154,72,127,40,6,239,206,231,217,82,29,139,199,165,68,46,70,0,46,68,133,25,221,67,240,66,233,44,128,177,190,107,146,105,239,71,97,240,214,54,206,2,237,183,177,206,130,24,19,139,50,210,171,152,92,159,77,104,208,235,53,13,111,155,105,211,230,168,179,141,107,54,44,10,225,125,141,250,55,57,251,12,71,161,229,212,251,138,7,231,95,199,111,120,200,110,195,223,94,195,70,204,243,3,180,206,142,141,84,6,186,171,33,95,197,14,137,230,245,13,209,120,153,23,249,114,246,119,152,248,176,194,196,251,89,148,51,195,226,111,137,111,242,243,60,254,171,153,156,255,195,160,183,117,13,31,178,117,91,153,249,7,24,52,175,176,135,30,154,125,92,129,245,7,16,223,62,192,184,245,190,33,247,70,227,219,111,31,220,10,159,160,147,83,113,83,164,211,168,133,11,111,204,138,179,244,151,106,142,250,134,33,148,182,183,225,232,28,71,209,235,226,42,133,92,250,49,196,188,236,18,112,12,17,244,164,142,143,75,49,125,31,5,75,212,188,155,70,208,76,196,132,174,198,128,13,238,245,228,80,184,249,42,83,184,117,163,106,19,31,124,90,36,217,72,64,32,27,36,155,172,236,255,254,162,44,225,58,129,182,210,187,210,26,46,226,14,167,28,116,216,198,37,7,219,24,175,74,255,100,11,205,196,11,86,216,71,64,47,125,252,13,131,90,1,144,153,208,176,19,82,45,178,250,53,220,151,8,101,64,235,44,108,168,221,46,88,163,99,158,25,88,104,90,196,66,58,138,186,37,81,70,17,92,230,69,5,221,204,82,253,46,225,150,22,20,63,26,176,219,34,198,3,0,133,152,146,163,152,214,26,108,8,117,53,56,29,8,49,246,196,69,85,42,14,0,177,253,16,99,103,52,103,114,46,160,95,46,64,120,240,31,28,27,140,60,92,12,215,116,17,197,232,247,73,182,32,207,40,208,206,0,99,28,226,225,48,169,236,144,162,72,167,38,15,134,199,233,99,68,250,6,231,222,113,205,76,9,145,15,28,34,150,32,18,229,87,134,249,64,190,167,100,37,189,140,6,63,113,20,49,63,24,143,203,131,217,188,94,14,124,8,135,106,177,92,178,221,166,225,197,42,120,233,105,129,8,142,94,20,229,44,169,7,253,47,143,239,162,47,79,238,180,119,63,66,132,229,240,59,83,184,202,127,244,174,8,181,89,246,114,240,27,249,46,107,97,224,182,22,194,227,254,249,57,192,94,163,195,10,234,236,202,147,151,172,197,156,225,26,129,7,17,230,207,241,171,140,173,100,227,233,178,177,194,180,45,38,149,39,209,42,68,39,30,58,15,98,234,46,201,48,121,139,79,237,123,233,96,197,199,165,229,42,157,251,176,48,213,235,247,91,119,101,136,38,218,153,8,97,135,217,6,17,154,187,202,40,224,48,86,210,189,147,247,220,250,83,22,14,243,170,78,242,9,217,91,194,226,59,218,224,87,84,229,234,182,42,170,118,138,125,138,170,122,87,80,84,15,109,201,36,158,97,32,124,51,230,39,34,201,10,44,127,62,53,230,175,136,52,109,84,99,242,22,33,176,145,160,30,209,63,249,199,150,39,116,51,17,51,75,29,150,38,246,202,149,141,144,6,30,137,170,85,81,45,58,72,63,109,84,205,75,2,196,119,28,100,82,55,35,146,85,164,9,49,107,10,216,7,158,102,80,103,172,176,44,80,109,53,207,160,10,15,31,3,220,226,64,136,18,159,66,78,203,118,65,244,14,106,212,83,51,114,51,148,212,140,60,219,212,51,64,111,136,150,4,33,252,9,238,177,96,88,204,86,37,250,229,23,103,37,41,196,19,218,193,204,26,85,168,62,79,14,65,64,164,68,107,108,127,138,93,237,125,191,158,3,247,92,205,53,39,67,144,236,37,1,119,125,34,6,75,171,79,253,62,10,6,249,210,123,213,21,245,117,216,13,153,16,25,7,242,243,16,112,175,88,62,211,122,155,7,149,74,160,40,58,127,38,201,160,152,244,172,31,253,3,73,139,237,70,104,233,111,65,2,64,171,3,91,133,243,216,130,125,235,161,130,227,233,166,92,216,148,50,162,24,163,7,131,111,12,2,55,38,225,61,178,40,101,145,162,211,238,154,69,8,99,178,143,165,77,72,71,227,55,5,33,113,227,176,74,116,169,190,246,24,175,75,148,7,113,158,149,219,137,221,220,142,138,0,225,132,176,140,156,236,224,17,161,138,9,191,242,20,224,58,223,158,133,37,95,196,114,168,248,152,21,3,179,192,13,204,120,5,121,143,44,163,72,186,76,106,243,165,123,22,110,148,127,177,2,7,84,32,75,15,133,143,16,72,216,9,66,100,123,123,78,32,205,200,216,141,122,175,211,10,1,171,215,58,170,20,106,21,20,243,1,8,51,141,141,125,116,244,233,139,45,141,152,167,30,208,232,221,249,206,42,115,243,96,119,209,218,208,222,61,220,45,58,82,88,44,98,98,34,112,200,59,134,151,110,253,129,60,18,228,89,48,236,123,134,34,175,95,160,176,253,252,22,84,78,178,131,237,55,79,174,65,175,64,143,185,142,204,146,66,181,56,253,28,12,245,166,209,147,209,51,67,189,142,171,97,52,96,64,181,12,184,209,140,5,141,64,79,131,217,161,16,231,197,18,149,6,23,94,179,233,83,162,131,216,166,207,15,12,198,158,84,24,27,196,135,75,247,104,232,87,224,210,81,116,210,61,67,58,164,129,78,100,178,133,103,93,100,251,157,82,165,59,175,11,72,157,31,229,198,64,184,81,214,23,243,126,244,231,159,145,106,44,23,112,147,163,215,117,114,15,255,79,242,32,168,218,58,181,95,44,242,122,144,194,217,20,109,239,68,244,19,10,124,40,15,233,116,24,237,68,143,17,23,169,171,92,54,141,53,116,86,36,171,148,80,157,45,167,123,58,106,168,79,65,187,233,167,71,61,109,1,75,208,206,170,217,174,153,43,41,102,23,189,244,171,165,210,74,190,88,119,43,101,111,95,148,5,43,21,240,101,101,75,157,142,229,4,216,43,131,112,98,214,243,220,96,135,62,35,0,252,158,60,109,183,4,175,240,201,195,192,82,87,67,101,116,156,254,0,23,222,225,1,200,176,2,188,97,102,105,174,188,179,137,245,167,198,13,148,35,44,80,51,137,205,5,211,86,226,33,44,163,105,253,192,215,160,170,195,3,21,38,91,198,143,12,107,56,16,23,200,134,194,27,214,45,125,33,74,231,147,116,255,115,56,107,108,170,216,231,246,94,50,218,240,192,205,238,116,150,230,39,233,213,117,77,215,255,50,129,51,214,15,123,82,220,178,115,14,160,158,0,132,23,198,117,106,109,136,141,220,192,52,120,226,129,23,71,177,242,94,245,21,141,103,237,28,215,15,179,222,77,63,25,86,51,50,71,215,81,135,21,207,153,240,128,155,115,36,174,8,69,240,38,207,21,15,119,60,169,229,195,123,246,248,188,33,141,128,116,70,57,105,12,189,160,108,80,160,201,29,136,34,56,151,224,17,134,4,234,230,185,12,52,195,45,60,33,239,181,231,116,122,88,157,38,87,162,214,118,121,90,88,123,75,204,63,197,64,42,2,237,198,22,143,101,209,120,185,17,232,2,249,16,67,134,132,178,173,76,171,126,228,230,11,216,80,111,135,144,173,67,208,233,97,201,52,132,161,152,141,190,4,20,241,218,30,125,236,6,1,23,160,153,192,7,32,148,209,154,216,0,79,155,77,23,91,151,163,228,243,123,224,29,80,115,174,195,139,163,33,215,90,27,76,202,92,28,7,241,119,95,27,155,35,115,105,244,45,240,10,146,134,147,236,67,81,254,193,94,3,55,75,250,182,40,25,212,90,82,198,100,176,148,45,164,223,89,194,38,55,166,116,45,187,169,102,3,142,118,171,208,67,143,41,217,134,41,23,147,26,232,154,47,77,197,75,79,247,209,173,90,18,227,1,231,118,196,207,88,112,46,248,147,207,33,141,3,62,117,180,26,122,148,225,148,4,89,48,71,71,11,211,4,49,238,182,234,235,180,82,188,90,3,182,173,33,152,106,251,187,83,36,165,51,85,48,130,223,70,247,206,62,144,139,195,252,166,248,131,12,248,48,122,223,245,246,120,124,10,249,152,119,101,122,74,102,16,118,193,30,128,86,253,150,131,58,106,208,191,87,76,151,227,122,153,209,94,64,115,4,7,24,248,68,170,53,254,80,38,115,176,113,92,45,232,107,105,2,110,53,203,0,25,3,120,19,123,226,61,138,192,71,156,131,116,73,51,28,123,114,45,165,238,243,208,77,94,141,189,233,68,108,194,253,243,160,145,46,244,154,238,189,122,150,202,31,173,168,175,13,142,177,140,58,60,117,31,24,225,40,122,114,63,214,244,163,28,206,155,254,190,54,115,26,197,40,250,245,126,220,233,74,109,206,157,254,190,54,119,26,197,40,250,205,124,105,236,12,192,123,108,35,219,134,26,137,135,181,103,26,98,76,196,175,124,118,46,66,116,118,198,11,184,136,218,147,83,242,185,150,91,11,193,196,251,215,100,242,199,110,121,181,160,63,150,128,111,31,115,232,45,46,229,37,43,191,128,228,107,17,48,144,221,110,177,169,245,212,215,216,204,138,98,18,141,20,92,102,37,151,129,1,67,100,146,67,56,125,183,68,50,113,171,12,182,25,74,168,52,133,182,212,193,184,52,196,25,154,40,55,245,171,221,173,161,129,58,54,93,101,138,60,96,129,82,68,176,179,123,203,221,106,34,15,80,122,238,82,169,174,229,15,225,186,125,42,116,132,168,193,7,210,51,208,240,56,235,125,231,137,217,248,105,19,204,33,104,22,204,139,220,118,22,252,229,192,154,133,203,34,3,145,25,213,191,171,72,232,133,26,142,229,228,32,237,196,170,61,202,101,184,221,19,22,5,187,173,177,9,130,11,197,150,10,228,149,56,111,92,52,234,36,226,176,23,69,145,65,168,131,142,49,88,197,49,205,57,139,32,171,65,184,60,37,9,135,246,251,91,152,162,128,239,227,64,39,140,86,137,21,152,21,77,194,15,247,76,72,47,189,112,39,67,123,93,252,44,137,196,253,22,206,187,228,34,35,207,211,82,57,136,178,141,239,104,213,3,26,82,170,4,165,132,65,121,161,95,159,88,125,112,200,242,167,10,44,29,209,144,96,44,216,209,10,222,17,159,74,40,107,232,222,207,97,63,156,31,44,226,215,88,12,159,154,137,133,118,26,99,187,37,59,3,53,174,54,47,106,173,58,47,42,131,52,153,226,165,205,105,94,253,155,44,7,162,60,196,119,42,50,113,162,162,141,158,137,230,172,109,232,185,85,44,96,221,173,88,232,120,169,119,11,74,249,107,47,141,23,134,246,185,217,114,199,131,252,130,231,73,157,224,186,57,94,78,67,123,112,165,151,224,206,173,94,106,59,98,185,134,240,156,177,208,12,125,33,120,35,74,140,56,53,125,115,69,241,181,213,153,185,197,119,49,234,102,66,144,248,132,214,11,241,139,9,83,55,11,148,226,6,78,49,250,147,93,105,146,165,255,37,199,108,183,12,56,187,90,134,92,120,157,206,105,62,95,243,206,216,42,209,10,174,244,211,123,136,108,106,146,242,48,128,74,42,184,246,241,19,207,161,16,36,177,18,141,158,150,148,75,65,145,104,45,212,114,44,92,104,141,97,149,28,226,76,133,248,44,84,215,221,134,149,226,139,7,11,39,25,159,22,244,185,7,212,97,56,23,145,107,28,42,18,189,123,75,38,125,83,19,105,248,81,76,163,197,19,243,209,64,236,128,165,242,111,114,9,4,44,191,236,8,1,54,51,19,28,27,250,129,9,161,189,37,26,23,109,59,190,18,207,159,29,124,6,107,33,128,160,104,10,59,12,226,162,3,226,22,198,1,125,103,198,155,244,95,244,101,153,190,233,193,4,133,15,18,245,231,28,25,17,211,232,135,110,243,248,96,184,157,149,49,131,129,141,13,62,248,60,7,77,163,78,88,69,47,31,36,44,199,120,24,16,3,173,222,137,18,122,225,244,46,79,133,219,165,176,75,20,237,201,196,134,84,34,187,59,219,149,20,104,228,28,126,70,164,170,129,44,142,148,184,84,187,124,203,101,242,137,83,162,22,10,55,108,194,192,88,154,93,148,174,73,185,133,222,53,74,188,50,199,75,103,117,19,210,6,37,21,76,190,78,47,176,46,154,122,249,42,225,147,56,184,1,225,211,183,140,16,32,10,25,89,204,41,225,95,227,33,188,175,223,40,85,11,81,163,96,195,158,127,32,21,65,141,170,183,248,89,1,90,49,56,246,201,27,23,231,114,99,107,194,196,69,193,71,209,202,17,246,72,207,184,81,200,151,174,108,55,146,206,122,145,126,166,118,245,129,167,130,105,22,254,93,205,126,186,51,230,245,44,188,157,101,184,236,41,168,189,41,12,159,7,7,140,194,104,216,40,95,197,131,148,244,74,34,53,30,247,254,149,82,133,14,227,86,206,80,93,250,171,196,225,68,221,58,183,109,87,167,30,148,86,140,121,33,53,206,182,236,154,155,240,161,229,93,48,131,138,32,44,58,14,173,208,83,42,4,26,40,85,181,2,151,109,163,200,159,50,175,177,225,174,46,76,111,228,113,143,197,46,197,107,191,15,95,53,226,150,2,221,216,203,131,175,251,238,96,189,87,7,110,252,245,189,222,23,172,254,186,128,223,121,173,247,152,224,97,60,37,8,87,225,119,175,193,239,86,168,212,245,9,129,218,72,158,151,228,95,141,91,251,189,64,240,181,192,186,111,5,140,105,168,109,184,129,50,123,35,43,183,66,133,189,4,223,112,113,189,182,1,223,164,188,62,112,194,50,197,80,165,177,106,158,70,130,88,216,131,0,134,205,58,118,251,25,73,74,254,156,227,193,248,30,44,4,208,140,9,55,225,236,28,42,165,225,235,46,168,185,178,157,172,216,91,181,198,175,73,126,85,95,211,213,124,220,224,236,27,138,201,70,51,85,163,191,138,224,16,96,106,3,179,94,235,217,140,194,45,149,66,34,138,33,54,135,140,253,203,178,88,204,29,168,187,205,46,48,59,118,176,15,91,61,180,149,118,57,84,142,185,199,35,103,55,183,39,80,243,82,193,97,73,166,99,241,127,23,104,242,202,131,213,69,244,119,251,183,204,154,125,163,180,199,248,97,127,241,59,24,156,49,1,192,82,220,224,216,9,101,161,63,18,207,255,162,191,20,143,84,78,128,11,103,88,150,221,175,56,202,124,23,176,234,96,56,245,86,29,130,223,18,172,51,150,109,171,213,6,226,247,6,171,141,116,30,53,172,195,177,122,191,208,113,112,10,151,106,234,169,66,199,49,76,103,196,219,133,150,33,45,250,123,144,47,102,74,125,37,27,88,141,9,0,216,252,241,114,34,90,34,206,119,183,24,78,239,6,121,131,40,154,129,134,223,2,60,208,182,187,255,1,175,47,122,223,35,101,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b87ab6e-6041-4741-9e6c-3f96263f72ca"));
		}

		#endregion

	}

	#endregion

}

