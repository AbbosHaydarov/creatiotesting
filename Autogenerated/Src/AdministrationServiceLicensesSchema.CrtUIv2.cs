﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdministrationServiceLicensesSchema

	/// <exclude/>
	public class AdministrationServiceLicensesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdministrationServiceLicensesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdministrationServiceLicensesSchema(AdministrationServiceLicensesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9");
			Name = "AdministrationServiceLicenses";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ee2cfe-a059-4eed-92fa-2b7fd54ad54c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,61,219,114,219,200,177,207,74,85,254,1,203,36,46,170,138,225,94,30,109,75,46,217,146,215,76,124,139,37,31,63,184,92,167,64,98,36,33,166,0,46,0,90,86,178,254,247,211,221,211,115,159,1,65,74,222,242,38,103,31,214,20,48,211,211,211,211,211,247,25,84,249,149,104,87,249,66,100,103,162,105,242,182,62,239,166,79,234,234,188,188,88,55,121,87,214,213,31,255,240,239,63,254,97,111,221,150,213,69,118,122,211,118,226,234,129,247,55,180,95,46,197,2,27,183,211,159,69,37,154,114,209,219,230,213,252,159,240,243,69,93,136,101,208,238,56,239,242,224,225,236,85,240,232,231,101,61,207,151,229,191,8,199,224,237,243,178,250,37,120,120,38,62,119,193,195,83,209,124,42,23,34,142,140,253,114,250,78,204,131,6,240,12,26,181,45,224,112,218,229,157,48,13,108,106,94,93,217,40,250,111,166,127,107,83,175,27,1,51,89,136,10,95,152,22,79,26,129,179,158,62,133,127,214,141,56,171,47,46,150,78,3,15,4,183,75,189,79,246,59,126,156,124,117,82,117,101,87,138,214,52,120,41,174,59,88,91,108,209,59,31,155,164,192,103,93,147,47,172,69,129,217,158,221,172,68,118,224,119,115,88,114,10,212,231,150,206,138,156,138,174,131,159,78,91,0,21,7,192,141,113,10,0,227,79,141,184,192,214,79,150,121,219,222,207,222,212,75,241,178,238,158,214,235,170,56,249,188,16,43,185,19,160,225,123,152,64,73,140,55,95,138,15,240,96,181,158,47,203,69,182,192,142,241,126,217,253,236,104,181,130,70,52,182,5,110,15,119,150,2,16,237,58,126,219,138,6,80,175,228,214,201,214,206,159,147,236,231,117,89,100,13,244,156,21,251,25,2,219,187,159,205,243,86,140,219,174,129,201,77,159,214,205,85,222,141,43,113,157,61,175,23,10,237,83,122,57,118,129,77,223,213,205,71,146,4,211,55,162,173,215,205,2,218,213,77,126,33,38,4,120,111,116,84,92,149,85,9,144,105,30,188,144,146,63,69,59,154,100,163,96,136,118,26,157,213,244,127,242,229,90,140,246,39,10,245,253,12,40,129,163,124,129,255,125,145,11,34,170,66,174,73,108,125,120,212,25,236,65,122,237,44,130,243,82,210,248,251,239,191,207,30,182,235,171,171,188,185,57,84,15,184,93,6,115,254,8,211,204,102,199,83,221,246,123,187,49,67,39,98,207,10,196,21,200,113,33,136,111,247,246,90,254,33,241,238,31,170,3,150,237,31,68,237,0,250,223,45,70,82,147,170,64,190,247,143,40,89,37,123,146,75,102,221,97,204,89,85,32,115,139,54,187,190,20,221,165,104,178,60,91,50,30,101,155,229,159,242,114,137,76,145,157,215,77,214,10,214,3,253,88,205,235,122,153,157,84,216,173,184,107,156,46,243,54,155,11,81,101,139,75,177,248,40,138,1,152,60,145,45,119,193,228,229,250,106,14,195,215,231,22,33,24,147,182,127,228,178,234,178,35,213,231,9,108,161,238,118,227,175,114,96,224,225,67,191,134,230,119,48,170,26,48,43,80,118,148,243,117,183,137,226,56,56,8,190,221,7,215,74,51,147,130,108,208,6,144,74,229,148,58,244,15,26,74,168,189,80,68,69,165,165,45,172,86,121,211,129,38,97,161,21,109,14,154,99,246,70,228,197,171,106,121,99,155,25,82,172,33,66,122,80,208,189,93,94,117,48,240,235,166,252,68,109,104,138,242,143,108,129,239,245,76,1,186,104,96,178,175,165,144,120,181,18,90,89,142,102,173,255,122,36,85,164,47,146,245,216,175,155,26,0,160,57,144,24,156,172,133,27,99,1,102,255,171,119,2,15,65,134,68,106,45,1,113,205,70,136,254,170,169,139,245,162,179,5,75,87,103,176,199,179,150,172,50,210,146,168,120,82,203,158,66,235,200,199,202,176,1,255,218,107,4,152,82,177,9,100,143,30,101,227,200,227,3,228,100,91,205,2,93,159,137,37,16,12,76,229,46,24,113,188,191,47,57,238,139,197,227,134,240,105,90,171,197,120,1,194,174,46,252,183,81,202,190,161,185,24,1,137,20,84,164,35,185,13,8,127,74,17,145,158,0,11,231,87,164,98,14,70,216,115,86,140,14,113,186,168,74,31,126,79,111,77,99,73,186,246,240,12,134,25,29,17,236,81,214,150,23,21,169,133,188,202,4,88,131,55,176,249,9,17,216,141,180,37,222,86,101,151,117,72,162,137,130,84,207,187,188,172,64,24,207,111,8,223,89,1,131,41,232,246,2,147,228,158,181,136,145,28,111,76,42,92,246,33,155,3,8,125,74,250,136,213,210,172,149,13,105,18,7,114,201,209,120,146,141,60,107,108,95,190,71,215,102,125,85,141,213,156,212,227,167,77,125,53,30,217,243,208,175,222,1,185,197,120,4,228,218,159,206,218,147,95,214,249,114,44,161,76,95,35,209,68,39,26,50,207,208,54,146,125,64,101,73,36,36,123,48,31,134,88,79,79,62,139,5,136,216,83,48,197,242,230,33,146,224,112,188,191,81,98,42,171,22,56,22,169,95,147,135,54,116,233,161,245,136,150,85,118,3,8,121,151,85,66,20,0,172,6,77,11,104,50,244,34,100,11,27,208,47,235,186,19,47,225,231,232,48,212,223,117,115,65,156,89,213,48,66,141,171,152,81,251,22,89,102,37,247,197,13,1,106,211,204,167,231,89,176,48,76,176,14,8,211,206,82,13,170,215,152,103,8,255,76,36,123,105,148,21,63,73,111,100,252,41,7,83,231,26,182,63,177,15,129,121,215,148,184,174,79,214,75,116,199,102,213,121,61,157,85,208,174,4,185,205,15,165,37,188,231,130,185,166,126,12,10,157,43,116,100,25,88,123,173,123,236,253,67,161,2,77,53,90,242,221,23,211,138,16,83,243,177,161,234,73,54,204,47,164,247,212,179,169,161,129,196,103,130,68,80,13,73,90,25,174,188,70,217,38,39,253,120,93,46,11,4,57,61,171,217,239,136,72,184,40,79,146,205,149,16,79,104,194,225,131,11,96,251,74,153,24,119,38,170,236,198,0,155,133,51,118,137,248,12,105,65,215,172,65,142,158,199,16,7,233,202,56,3,25,113,118,215,37,0,61,207,151,48,137,30,89,6,84,69,156,159,229,104,169,96,111,91,160,177,55,104,227,171,86,157,214,156,204,27,236,126,10,102,239,85,254,143,181,0,105,43,151,95,106,66,235,185,39,233,166,118,131,23,121,5,192,97,253,81,182,49,200,17,175,105,0,72,74,53,48,63,192,146,227,223,7,113,84,166,71,69,161,36,41,10,70,9,208,234,56,61,149,107,202,1,130,163,139,11,80,121,100,182,224,19,144,194,208,82,118,154,5,104,60,45,151,192,178,232,17,50,177,228,131,36,46,20,98,17,178,209,187,178,187,212,82,185,29,75,78,151,175,32,128,3,107,95,182,140,2,9,114,73,23,34,202,68,169,154,1,104,1,30,122,217,190,54,114,150,105,55,113,249,229,129,102,151,115,133,67,148,63,212,8,202,116,26,71,49,157,64,208,225,2,164,248,82,27,152,40,1,64,175,28,85,5,7,21,236,213,152,68,136,192,24,197,9,33,155,180,200,57,99,137,175,195,134,25,11,129,36,33,81,72,201,38,178,131,175,223,29,85,59,86,208,190,3,154,172,151,203,253,236,145,26,0,1,33,141,153,127,41,186,241,16,156,152,195,177,205,190,82,73,28,102,63,128,85,79,59,253,193,64,1,136,242,195,152,186,85,232,88,177,201,196,118,241,80,41,40,105,194,244,70,209,161,164,155,101,99,247,202,183,215,220,6,193,41,57,103,176,131,37,7,214,3,255,166,108,219,181,40,84,111,141,180,128,104,16,89,8,145,217,77,180,178,23,87,43,92,72,169,134,181,164,76,42,109,106,38,197,227,73,211,212,176,35,72,38,6,83,117,4,227,220,209,210,90,97,201,213,7,219,84,228,139,203,108,204,60,5,170,239,10,9,30,88,238,90,195,134,35,66,204,232,128,58,70,25,5,219,31,146,161,104,247,80,2,112,15,8,59,14,160,29,164,167,4,155,133,169,165,54,93,219,55,186,108,12,227,235,61,218,234,161,247,76,156,21,215,141,5,111,18,148,105,13,224,248,151,129,133,243,248,206,224,132,1,89,52,227,219,113,204,227,220,207,238,221,51,67,30,176,111,78,114,236,181,226,171,123,247,24,242,94,18,35,218,131,35,213,3,32,144,146,0,232,135,7,3,251,114,7,67,220,189,118,62,133,104,46,120,100,179,115,8,108,158,32,127,142,49,248,169,39,106,90,140,55,83,29,38,198,115,38,179,87,121,127,218,162,146,255,200,255,43,235,106,238,155,82,125,50,4,100,99,107,172,15,101,182,220,198,96,42,11,112,212,202,243,18,108,194,94,195,201,22,230,142,104,97,28,18,112,212,102,254,84,195,54,2,236,141,145,17,49,118,236,49,66,99,135,99,57,7,25,103,64,48,59,5,206,18,71,21,31,2,76,36,202,99,136,151,23,108,79,29,171,16,21,176,40,184,77,114,13,30,57,161,161,41,216,63,160,73,229,171,251,238,171,99,113,158,131,33,47,215,208,51,161,128,37,220,40,0,219,81,168,189,176,169,178,232,220,110,202,132,112,117,35,43,79,123,150,155,57,225,24,124,69,244,150,126,183,204,32,39,176,53,63,12,93,7,9,126,219,165,216,76,119,105,174,65,56,5,204,133,249,47,100,117,131,251,42,131,24,158,206,140,133,74,177,241,226,50,175,46,4,177,73,59,205,122,214,73,187,185,155,70,178,7,208,17,225,184,86,229,0,9,37,118,225,111,249,39,36,150,158,96,158,73,17,57,99,225,52,44,100,162,99,38,79,215,213,66,90,238,74,1,178,225,76,46,64,16,73,209,222,6,191,152,1,220,230,111,117,89,197,227,44,123,211,87,254,27,134,172,163,46,222,168,108,185,99,19,55,84,3,52,226,247,174,146,246,1,89,175,24,0,216,186,254,40,42,80,148,142,253,116,224,58,238,251,16,156,89,12,133,145,185,129,163,97,140,10,209,226,2,242,187,181,12,205,61,57,58,61,145,49,157,5,185,20,28,35,106,196,66,0,10,5,6,178,229,144,196,109,149,232,229,80,91,40,44,8,229,147,207,171,70,198,182,71,135,26,123,14,28,129,125,0,81,29,24,3,180,177,12,241,46,197,57,4,235,64,92,32,23,227,3,161,187,167,45,213,39,206,124,40,235,131,194,135,76,207,5,38,37,157,89,96,27,129,52,69,123,143,167,20,223,26,236,226,42,224,146,128,238,195,177,229,6,155,153,2,37,221,7,182,242,250,197,133,42,141,211,56,84,254,147,12,163,159,105,244,70,155,42,207,129,82,214,136,7,193,152,210,180,144,202,202,29,211,103,42,202,46,140,127,84,214,9,239,117,183,207,70,246,82,2,4,25,140,88,202,172,28,229,172,11,32,180,244,99,180,63,11,182,38,47,80,42,93,21,225,41,198,135,37,148,205,93,71,214,34,111,230,44,5,254,221,179,147,151,102,71,244,171,57,51,37,24,30,34,162,213,172,66,36,100,116,212,154,47,237,166,235,114,185,68,38,23,50,98,139,168,16,34,103,56,224,188,201,171,197,229,22,163,157,128,71,185,203,104,39,207,97,41,82,163,233,13,228,174,87,239,118,0,12,244,90,227,31,128,27,200,62,25,86,74,109,134,212,154,77,88,161,196,251,37,168,61,201,6,52,55,228,10,183,30,206,192,222,117,164,232,36,235,123,59,62,216,170,81,17,144,158,31,67,213,195,162,49,8,26,167,194,144,208,216,5,62,73,77,55,128,1,149,45,56,59,51,202,56,53,243,200,118,134,199,183,218,201,41,131,99,112,238,251,46,249,78,59,233,192,128,227,104,194,135,87,4,86,46,97,223,56,36,74,177,181,37,160,93,158,211,134,131,118,135,217,116,223,220,131,61,207,141,237,143,32,26,127,9,50,173,92,104,15,30,34,165,115,42,172,178,118,208,214,35,238,233,168,235,156,77,57,135,98,251,172,12,110,193,39,5,10,98,48,105,132,19,226,95,172,155,6,124,1,167,128,100,185,132,202,34,182,133,177,77,151,55,152,147,213,121,222,108,75,215,5,229,227,236,88,89,16,218,33,66,197,127,125,89,95,101,215,96,23,52,194,24,10,148,160,212,126,210,215,146,146,207,114,116,67,55,230,40,7,178,172,211,216,179,36,149,141,27,215,243,42,241,120,75,214,119,217,133,185,202,51,40,38,153,243,224,135,1,76,165,178,214,75,174,11,8,5,11,168,186,238,82,243,79,126,69,85,36,170,123,94,129,169,7,40,138,10,34,3,37,228,224,176,64,78,89,134,62,95,125,77,143,184,108,161,100,210,206,115,66,128,204,206,190,35,97,173,148,103,154,235,84,5,30,81,36,193,115,65,169,131,93,123,224,49,29,39,54,9,63,197,128,134,103,23,158,100,181,216,48,42,116,77,70,65,242,195,208,172,186,73,171,39,28,43,211,128,229,214,244,8,98,137,175,33,22,2,41,54,17,54,11,196,89,98,247,236,75,64,111,99,48,252,201,203,166,250,207,16,53,147,92,65,1,43,67,124,212,199,143,251,245,119,180,99,179,114,154,94,225,78,27,66,208,26,39,226,68,51,20,148,251,113,87,218,14,197,170,166,230,1,122,213,155,29,98,119,10,129,75,173,5,135,241,88,161,246,91,156,149,80,175,248,178,190,198,66,112,80,50,0,238,177,232,174,161,88,15,240,130,237,217,225,99,196,9,37,217,241,90,200,63,25,240,171,6,2,247,143,111,142,218,69,130,242,220,224,88,112,11,124,165,129,120,158,178,12,88,59,187,32,220,6,82,100,135,123,128,69,185,147,254,99,137,28,103,41,217,65,210,90,254,198,61,173,130,202,95,12,66,94,52,139,2,154,28,222,228,184,38,16,234,178,190,54,49,117,18,14,48,132,140,156,232,185,72,108,36,33,123,184,13,98,220,144,187,159,193,42,127,20,97,140,225,207,163,191,252,59,89,77,246,229,47,58,158,45,39,96,167,17,81,62,243,175,160,68,42,146,109,166,137,82,137,219,66,60,190,193,229,52,188,108,68,12,200,117,8,191,58,73,75,43,71,233,135,243,52,6,12,129,75,46,142,31,203,18,26,140,2,168,31,17,20,91,160,248,241,99,243,104,28,212,110,88,39,26,166,51,252,63,150,242,129,134,0,23,1,255,129,28,142,92,2,174,216,145,111,199,106,76,43,231,32,167,53,125,94,231,197,88,118,118,235,46,156,244,128,108,108,171,81,39,136,10,206,193,179,242,226,82,180,29,20,136,213,96,59,222,240,178,113,133,235,24,235,237,30,90,37,212,135,24,55,96,18,146,186,230,223,42,135,1,218,148,224,96,77,141,97,2,157,14,67,166,141,183,192,188,142,76,164,58,181,117,54,195,232,228,27,167,180,12,159,82,153,11,213,253,244,13,78,76,177,114,231,41,3,33,170,6,249,105,217,180,221,171,134,3,247,227,85,118,0,19,154,170,90,104,192,208,29,210,78,202,249,112,57,47,140,153,43,239,213,212,43,226,133,28,176,89,92,191,173,170,52,62,200,48,128,167,210,65,54,109,236,85,247,150,248,24,178,235,128,56,88,42,148,86,156,56,233,137,67,212,250,60,140,124,210,166,244,62,114,59,91,108,129,233,32,179,14,36,85,108,215,217,217,123,253,120,40,171,0,169,232,166,102,32,255,50,52,55,147,253,250,171,193,213,227,33,123,19,48,181,16,69,187,212,1,147,162,214,76,28,213,100,218,33,59,152,191,122,242,132,182,204,70,182,249,81,233,36,229,59,209,80,8,78,254,218,42,19,172,96,157,213,71,77,147,223,216,228,115,166,132,186,151,242,145,251,195,232,177,179,69,70,203,24,154,28,169,16,120,50,126,207,193,245,30,143,36,85,14,233,196,213,29,243,67,91,122,86,89,140,67,165,32,38,254,237,10,254,235,203,18,44,108,150,249,83,108,103,13,22,242,52,64,230,166,192,93,91,148,24,104,72,58,97,26,7,227,110,98,205,6,26,10,235,41,44,199,177,209,146,154,214,202,82,106,38,220,78,127,233,68,84,103,202,93,91,230,88,18,93,31,133,88,201,236,172,47,160,184,43,242,80,123,86,195,108,202,2,33,238,226,139,132,185,36,118,23,236,172,81,172,246,151,167,174,183,110,26,219,61,15,207,71,83,140,229,191,2,86,113,44,116,185,149,146,57,46,133,251,230,84,87,44,71,229,239,241,228,190,140,228,198,93,171,207,159,204,94,176,249,119,74,108,121,33,13,7,134,253,55,74,89,62,111,166,92,157,20,96,62,245,56,245,187,79,73,197,88,82,119,155,165,139,209,214,145,119,47,193,104,112,106,98,213,78,240,64,245,111,9,218,12,179,10,149,166,242,111,205,217,64,86,237,33,218,252,2,70,194,142,207,32,104,145,131,255,124,163,102,195,102,23,137,94,2,221,158,161,122,230,26,99,191,23,20,196,57,148,151,93,70,80,238,166,103,44,159,60,8,128,179,26,28,10,184,112,128,22,46,64,57,229,173,0,226,75,3,148,255,122,208,43,57,236,176,106,175,236,216,155,162,225,82,86,208,192,60,98,121,18,35,236,196,39,72,76,192,40,17,19,3,96,154,108,74,143,83,126,60,138,67,176,42,110,162,59,37,107,238,46,87,253,85,196,228,192,169,126,171,130,147,37,102,124,22,62,215,247,16,91,29,186,253,166,229,153,107,171,216,114,77,161,182,91,197,137,103,4,73,129,52,177,247,253,230,26,149,88,103,207,98,87,65,51,142,77,70,12,97,23,136,106,241,115,83,175,87,143,161,162,208,194,39,94,194,145,80,1,134,190,255,175,6,190,146,26,176,185,17,109,101,106,103,124,47,185,146,143,226,118,106,100,167,201,246,247,227,74,92,233,239,152,234,14,180,182,109,97,162,69,79,249,43,167,4,68,5,193,73,232,88,145,98,130,200,66,5,25,218,112,174,9,174,93,230,159,64,189,218,224,228,112,180,63,78,215,87,114,163,240,254,247,134,14,243,60,12,152,169,40,139,213,14,182,221,204,67,117,87,202,66,239,81,159,158,46,233,151,72,114,4,159,142,58,44,157,64,52,45,178,195,37,9,229,83,159,54,136,104,111,137,131,195,92,190,204,25,6,138,59,61,35,110,24,251,76,209,163,118,96,209,251,142,50,18,11,196,4,220,179,188,189,132,168,165,116,98,245,46,193,131,47,245,154,182,108,187,201,251,11,194,83,14,200,113,156,21,135,110,95,171,250,34,110,253,88,75,70,193,116,229,133,84,227,52,159,91,54,163,173,184,44,27,218,83,187,90,179,88,77,212,30,179,142,18,22,243,147,91,69,54,236,104,6,232,24,245,19,207,27,226,252,221,128,134,25,44,12,105,152,206,241,176,134,100,59,0,108,53,140,7,53,20,9,98,81,8,55,255,178,83,208,129,157,10,102,59,220,1,143,111,102,69,79,146,126,205,205,148,126,216,214,62,177,243,129,119,118,134,216,143,120,89,22,153,193,245,145,119,118,88,29,82,216,239,167,139,31,167,101,251,3,230,246,34,111,91,144,149,99,119,7,75,156,76,130,0,2,226,93,221,229,75,25,27,63,80,239,237,3,125,114,176,247,31,52,194,173,213,78,167,115,157,21,210,201,190,49,29,79,130,192,43,254,187,239,199,80,121,26,16,174,91,45,149,77,170,30,194,48,136,62,63,131,162,2,204,68,24,84,53,199,98,10,47,251,241,62,47,164,2,197,162,38,188,118,231,237,118,215,238,236,120,241,14,158,44,134,117,240,23,167,253,81,93,190,163,54,5,207,18,163,146,206,157,65,106,30,19,67,244,247,63,124,208,221,230,16,34,252,248,192,34,192,79,191,19,2,252,116,59,2,216,127,253,24,39,71,33,147,73,191,19,122,220,37,57,38,246,78,254,107,246,83,140,60,142,220,181,183,152,39,96,16,73,32,192,10,12,70,17,19,51,240,14,51,118,78,208,39,25,231,74,90,2,206,40,188,159,79,215,80,114,220,162,136,193,176,132,74,131,225,113,66,60,179,143,29,193,194,157,216,213,211,183,74,100,109,206,213,224,181,24,86,66,147,5,95,194,150,97,27,218,138,254,209,79,48,104,224,31,84,13,80,228,194,17,0,94,157,104,8,16,58,36,110,84,83,10,11,230,73,172,19,228,213,81,37,63,5,18,105,88,199,107,92,163,200,236,129,85,233,36,172,194,36,25,108,75,122,183,102,134,219,249,72,119,97,19,109,52,138,188,121,12,49,143,134,216,71,183,53,144,248,208,117,27,51,145,148,141,228,218,74,196,224,134,212,198,215,197,100,247,119,169,232,177,51,208,27,60,193,52,142,90,239,145,237,234,221,43,129,195,43,88,224,96,170,99,151,97,137,132,217,186,230,132,181,121,235,236,97,172,16,209,127,107,218,190,208,210,111,144,101,163,108,25,69,52,23,109,185,133,161,86,136,44,7,115,31,160,46,57,239,71,123,48,214,244,228,73,93,32,218,35,161,134,25,41,125,97,230,4,113,70,249,155,209,124,176,117,249,8,172,228,209,114,9,82,4,138,28,193,153,212,107,46,13,98,174,221,157,132,249,127,105,250,33,11,209,218,51,128,137,231,220,201,193,237,210,17,191,135,62,54,252,119,113,51,230,225,12,27,16,18,120,66,137,12,73,191,239,123,110,255,193,46,226,160,87,253,76,133,219,68,182,211,219,36,73,6,217,110,18,153,41,207,141,35,219,202,9,201,134,20,113,56,68,34,23,248,41,104,98,218,60,102,228,129,36,31,94,178,225,142,26,156,135,215,10,6,203,112,130,101,130,229,113,171,112,160,134,155,16,238,243,192,211,100,69,248,49,162,42,168,10,128,156,209,123,108,248,1,70,82,175,183,226,243,33,228,7,237,230,145,95,77,54,149,67,4,231,5,203,216,175,69,129,127,33,25,152,56,201,164,227,171,230,34,7,35,143,228,205,100,67,219,99,129,183,201,93,33,235,109,104,169,110,111,217,208,236,76,228,87,155,218,96,188,143,40,69,180,176,237,33,214,227,138,252,187,186,194,177,98,95,185,244,137,80,253,134,196,239,102,111,58,209,63,94,85,98,175,103,232,98,15,220,143,169,221,231,108,140,223,34,130,227,46,214,29,133,114,44,43,116,136,169,226,152,41,150,48,31,214,219,101,13,19,15,242,213,128,196,7,229,131,130,222,19,32,162,187,112,2,105,43,237,131,136,20,14,196,173,19,111,9,1,197,4,208,108,128,4,122,94,86,80,36,232,13,78,165,131,108,95,129,249,157,127,210,62,225,113,87,131,196,131,32,93,171,181,43,77,44,144,99,60,177,136,124,51,137,0,241,153,130,147,23,22,14,219,233,16,231,56,203,246,98,1,4,99,106,255,163,72,242,194,228,122,211,235,119,21,3,8,75,190,127,139,125,214,222,249,254,226,83,34,195,54,137,69,60,119,167,157,107,210,13,1,99,19,90,195,113,141,185,37,177,135,106,200,58,152,205,174,8,11,57,150,157,158,146,227,247,120,16,209,160,13,225,188,215,125,149,157,135,102,150,0,179,186,23,82,218,40,129,255,250,135,129,222,169,185,42,111,202,31,80,94,89,165,105,8,86,33,253,215,47,134,120,68,196,150,247,50,218,8,18,30,239,28,117,96,8,194,157,150,187,207,79,33,77,117,86,99,121,183,189,153,21,18,54,84,131,38,131,85,141,60,184,234,113,0,88,5,75,21,192,39,116,127,5,54,213,135,3,80,107,186,17,212,68,35,36,149,66,232,172,230,9,171,216,90,236,93,140,185,244,133,82,240,75,207,56,29,203,76,161,34,175,8,81,35,162,100,241,240,73,54,248,138,72,161,115,77,57,187,26,197,212,253,193,211,80,24,90,189,188,200,101,16,181,67,228,35,186,33,84,35,120,88,57,152,175,167,11,131,78,73,167,51,49,236,38,53,25,106,91,182,104,55,117,140,225,206,172,170,221,31,89,49,107,20,32,56,65,61,221,236,253,171,197,133,220,98,32,238,30,88,110,82,81,12,149,75,14,42,122,135,2,30,54,116,18,218,70,134,186,224,29,41,228,92,212,21,146,206,17,207,102,227,27,153,26,130,150,33,159,16,212,123,213,221,132,207,195,104,211,6,12,180,72,211,8,68,198,225,70,31,12,50,46,146,58,202,228,170,135,238,178,169,175,137,240,67,190,201,160,119,177,23,179,114,150,167,172,192,191,40,59,81,60,201,171,66,6,53,97,161,66,148,205,116,144,6,97,47,185,158,230,238,180,144,12,123,201,78,27,136,16,209,58,177,189,152,150,112,59,236,170,9,221,238,205,246,130,22,134,18,15,235,141,17,142,177,93,168,182,21,16,84,129,208,228,160,35,115,3,141,13,139,136,11,120,91,86,250,244,13,83,198,108,249,129,38,200,135,77,59,53,152,88,104,40,188,17,87,245,39,75,213,62,24,180,74,81,189,248,31,180,64,125,68,239,21,154,119,180,148,187,172,100,76,216,166,151,209,228,215,193,135,179,2,207,50,126,11,238,133,191,152,234,56,94,126,126,14,130,137,47,11,75,38,217,157,86,97,170,125,64,66,124,70,235,175,70,213,89,192,45,179,229,42,149,193,21,122,46,90,36,183,90,121,70,207,152,227,223,120,62,149,22,91,90,94,197,45,146,237,3,18,237,118,49,68,148,112,137,10,136,252,163,24,255,228,155,236,191,43,186,254,230,57,252,255,94,82,127,171,229,1,234,62,116,140,116,209,74,216,225,46,188,66,137,38,241,70,44,137,30,60,153,97,17,50,38,42,228,39,179,45,197,172,243,48,21,19,115,203,170,184,80,151,208,123,117,107,7,223,128,108,34,97,189,104,208,80,133,5,147,216,96,52,243,9,132,162,156,72,159,171,93,189,30,126,170,200,2,170,244,165,223,195,246,147,22,56,152,77,11,215,13,144,161,122,124,248,146,82,158,50,166,142,191,125,235,216,26,211,156,27,181,10,7,130,254,96,108,224,102,229,201,233,253,218,75,16,99,87,59,120,59,7,32,220,234,113,102,70,106,166,171,200,77,245,119,248,122,220,139,128,181,114,145,1,182,139,204,218,234,120,40,3,39,103,229,197,56,213,233,215,195,176,150,101,192,193,85,251,240,151,90,23,197,231,219,1,64,12,61,32,82,106,39,64,232,187,154,101,101,166,149,60,254,46,50,117,199,112,213,229,151,118,65,132,215,225,189,108,52,200,108,237,233,78,230,165,36,70,128,34,173,230,102,196,164,152,182,208,129,191,93,59,53,118,213,134,185,165,128,211,188,126,244,194,248,9,54,151,217,13,111,159,31,188,77,106,111,235,211,160,110,222,51,204,252,133,83,219,180,19,236,30,114,33,55,101,201,148,120,137,137,90,171,142,31,69,109,132,105,28,113,171,93,23,40,141,45,138,94,54,12,11,121,213,66,91,99,74,41,28,115,125,85,7,133,149,231,48,81,218,165,108,128,94,82,81,217,140,228,234,0,98,82,25,218,49,218,0,233,233,16,82,235,1,124,107,110,86,119,231,107,196,119,116,232,200,6,244,227,91,14,56,91,170,240,13,100,248,242,69,190,82,42,120,193,100,210,68,85,148,33,219,68,86,53,226,73,29,252,75,25,55,182,161,66,123,151,157,115,119,132,96,223,91,16,173,16,160,99,190,234,18,48,94,59,16,14,182,205,230,189,250,16,124,239,135,176,189,39,215,223,26,110,171,130,139,224,16,115,68,3,206,78,170,245,21,172,62,88,175,204,125,9,11,226,150,55,141,57,106,166,239,189,210,34,126,27,28,194,220,56,149,148,78,222,177,191,228,73,93,58,88,100,55,13,239,180,118,14,132,4,248,153,51,69,170,149,37,53,251,135,165,169,108,57,172,59,164,34,70,120,159,118,216,167,26,15,63,81,189,105,193,54,209,123,211,204,45,6,116,15,75,239,68,120,27,154,119,55,67,132,26,166,127,172,230,196,231,122,231,58,20,117,91,215,9,198,177,212,199,128,134,16,52,90,114,147,190,183,165,255,230,150,129,92,162,65,209,161,169,237,110,125,208,7,205,249,172,245,150,135,172,61,162,253,247,145,75,93,234,182,21,209,156,27,55,98,104,218,86,21,143,16,99,225,222,91,54,204,229,179,137,70,176,50,231,28,221,120,93,55,16,77,160,94,217,206,198,154,243,33,197,157,2,13,248,208,142,152,108,21,100,80,181,247,195,234,229,33,215,244,155,7,37,84,55,21,145,144,118,3,111,16,229,190,57,209,8,229,92,68,170,13,200,22,69,247,245,8,106,93,20,85,238,178,60,112,167,211,115,61,130,86,82,210,102,253,184,144,221,66,105,69,21,149,47,50,6,75,12,95,163,236,34,30,238,66,152,70,101,233,127,18,85,118,146,153,190,180,73,238,129,109,98,45,241,253,179,201,199,140,118,29,230,108,78,134,69,70,60,159,84,29,218,8,7,77,94,83,103,98,9,166,234,137,139,246,181,148,29,42,45,194,107,119,130,147,212,113,19,223,181,236,227,39,171,3,99,214,176,99,76,152,196,201,64,53,242,81,22,177,230,220,238,16,197,139,147,236,78,195,113,222,161,162,173,34,113,94,0,14,249,36,152,112,127,180,42,104,222,19,5,243,138,59,146,93,99,129,15,83,85,33,97,70,143,249,12,136,138,221,190,114,239,174,11,246,18,97,35,10,205,251,20,210,116,239,15,255,56,113,31,58,187,211,95,253,135,215,100,14,171,105,3,4,16,166,21,170,244,98,48,186,172,64,214,81,166,27,6,101,118,95,238,4,221,176,160,206,141,172,218,165,28,62,198,189,205,82,248,58,53,69,233,188,140,189,197,6,27,153,110,64,110,199,60,210,118,145,63,83,180,228,173,87,42,236,231,23,45,197,214,218,133,25,45,0,249,253,196,231,76,96,46,208,35,68,149,175,23,157,27,116,24,193,16,45,8,195,233,151,95,225,230,255,30,109,29,222,176,21,83,180,176,64,42,82,190,149,134,245,166,54,68,181,218,151,10,239,118,77,171,218,142,187,169,216,239,204,92,29,229,42,131,227,86,213,146,106,165,79,209,109,76,75,249,125,188,27,96,61,187,144,57,206,116,74,122,221,233,61,150,208,68,147,141,220,10,163,170,221,104,113,170,254,134,136,103,142,71,103,189,133,96,227,27,154,121,196,192,166,225,136,132,222,249,62,22,70,150,25,32,161,12,140,92,103,19,129,84,169,35,60,76,232,63,137,170,104,196,5,157,231,167,191,229,31,217,11,209,93,214,69,123,63,123,189,158,195,168,61,31,98,161,15,37,227,167,125,212,151,88,88,218,169,111,122,182,252,217,156,91,125,77,165,239,251,211,16,6,42,177,164,133,62,97,233,162,80,207,255,9,251,211,255,162,229,123,173,181,113,37,240,3,73,31,232,241,59,49,135,82,152,26,106,117,228,236,241,24,245,235,87,167,103,224,69,190,109,202,51,83,172,51,242,62,155,162,238,155,135,134,143,235,226,230,180,187,161,221,9,240,184,78,79,63,157,190,107,242,213,74,240,151,91,223,72,93,41,75,103,156,14,242,209,244,111,45,6,123,212,197,20,253,237,246,105,18,43,90,46,171,108,48,134,167,186,45,131,13,106,107,7,152,43,241,237,172,173,253,25,0,59,140,3,137,178,186,41,200,216,199,182,184,61,220,139,4,204,77,242,208,100,108,154,243,45,20,228,254,217,77,161,115,223,45,25,183,248,132,175,28,36,184,196,94,27,234,254,135,112,20,174,19,254,0,142,236,191,225,94,253,149,115,169,190,132,234,93,180,239,193,53,231,193,109,122,201,8,5,244,151,164,251,245,215,108,70,158,150,124,174,97,216,157,22,121,37,143,244,114,172,4,71,119,213,42,132,69,79,65,59,225,55,6,78,170,139,178,162,107,236,161,56,156,117,150,222,19,144,168,240,97,41,5,50,248,171,15,225,224,240,242,153,88,194,24,56,234,235,104,167,212,167,214,45,141,137,71,204,93,59,137,206,172,217,183,140,211,177,138,222,155,250,55,168,215,248,55,38,54,66,77,126,202,91,233,94,168,117,11,228,177,42,195,29,244,109,1,235,251,66,12,83,237,25,136,71,0,53,33,233,125,99,190,63,0,80,229,87,107,248,19,234,59,124,187,128,71,177,121,220,185,29,222,101,247,233,89,115,163,239,130,177,87,68,70,171,201,18,148,151,191,179,158,123,196,127,243,159,125,223,208,182,22,69,190,150,165,139,210,227,236,219,249,122,40,135,255,184,161,4,53,54,183,210,107,76,184,166,145,228,19,99,0,125,200,253,91,202,127,93,188,152,18,230,139,57,91,240,75,228,27,78,150,185,22,64,54,229,12,201,15,238,184,102,156,116,90,145,0,156,56,193,94,241,160,136,105,189,1,121,6,6,216,243,175,145,103,10,178,32,99,249,172,46,52,65,161,103,190,107,98,223,113,66,199,92,88,238,89,135,95,44,0,227,80,194,1,99,143,83,220,15,50,51,177,219,14,179,31,212,165,221,123,208,74,207,217,39,145,169,20,177,145,238,27,112,172,247,91,207,208,247,238,169,193,135,124,194,73,254,224,175,155,72,96,192,53,16,99,141,251,177,168,161,181,226,214,58,91,211,211,147,142,250,3,242,123,102,213,241,151,78,190,169,207,223,120,194,80,189,55,139,163,23,74,189,242,190,116,115,144,160,136,106,254,58,47,139,173,100,161,245,125,55,5,3,40,180,29,140,183,78,119,71,202,29,248,146,134,137,109,113,235,207,203,122,158,47,143,86,43,190,27,171,197,140,152,165,205,212,103,149,102,148,24,228,89,131,33,143,226,194,240,64,66,125,134,223,16,242,90,24,41,224,46,141,231,193,225,231,71,12,239,106,195,2,192,38,216,56,41,23,2,80,252,59,140,159,233,77,48,132,191,55,24,110,214,119,202,34,72,216,2,132,17,176,62,233,196,206,39,246,113,138,112,111,191,120,108,150,49,94,3,103,154,218,201,22,152,239,238,150,98,27,63,241,101,127,208,43,241,1,45,38,156,68,210,113,14,44,74,171,139,131,75,12,117,148,83,188,116,83,69,179,241,73,173,78,238,248,153,96,246,82,181,255,230,32,68,57,56,219,83,141,58,159,111,87,120,30,138,93,25,114,192,217,245,107,239,204,205,180,27,51,112,228,169,22,191,35,222,26,215,179,208,174,193,4,191,99,219,8,250,166,236,71,113,131,31,241,164,239,138,171,15,217,234,15,131,218,223,34,181,63,64,11,229,154,224,79,87,96,237,210,55,65,245,167,187,29,40,208,130,54,115,218,47,166,235,192,178,78,124,238,228,167,236,63,47,132,32,14,118,191,200,172,8,166,207,231,193,200,224,234,146,225,93,233,175,159,195,174,177,186,129,232,197,143,145,102,115,33,42,6,44,138,59,247,178,105,113,149,194,192,155,206,190,57,255,58,192,208,245,172,85,222,54,179,249,70,237,79,235,54,199,77,142,26,109,216,237,92,53,219,85,149,72,200,75,49,41,244,165,98,91,56,45,48,180,53,23,63,76,117,58,28,59,51,176,2,145,237,156,237,13,169,39,41,24,4,161,207,224,112,58,196,186,72,247,130,166,111,66,132,200,74,161,35,235,222,103,39,116,212,157,47,175,140,135,25,24,21,237,120,249,141,149,234,192,115,29,170,135,246,157,32,184,103,92,38,46,62,53,207,104,32,206,193,59,240,157,115,242,106,0,154,162,186,12,209,130,98,165,56,152,35,4,110,78,92,3,217,136,246,42,196,101,226,67,200,187,82,168,201,244,185,168,46,186,75,247,219,129,0,117,62,5,109,6,177,60,110,182,159,190,243,4,212,152,41,169,216,60,61,255,38,72,19,68,118,38,156,156,175,204,137,109,51,98,120,9,0,204,46,54,109,85,179,229,28,64,83,227,198,15,212,141,206,128,62,121,91,159,119,83,216,228,64,50,250,154,166,172,78,5,4,213,87,70,209,30,229,169,144,73,121,194,34,142,165,130,177,26,129,240,94,252,181,255,154,71,66,88,95,191,24,73,192,4,158,103,159,246,59,234,240,184,93,7,250,165,206,46,154,28,15,247,130,140,110,87,98,129,250,165,48,91,157,191,151,110,222,252,38,159,182,54,166,41,42,75,188,110,27,245,13,190,107,29,197,3,216,205,81,163,181,107,82,34,9,117,230,105,151,225,106,228,13,104,61,54,144,236,147,144,223,150,38,137,33,25,87,38,239,63,88,238,141,243,125,213,59,187,122,24,140,213,98,5,69,209,29,88,53,18,200,116,180,241,34,226,240,122,97,87,70,71,130,135,204,1,234,148,153,53,45,235,106,217,71,210,21,186,79,226,60,4,98,57,64,142,98,130,112,1,76,156,163,72,143,5,126,160,34,118,135,215,86,182,58,131,247,64,128,20,113,3,157,74,138,128,164,165,168,173,227,250,98,16,216,16,108,226,208,96,18,199,90,91,225,191,161,104,209,151,46,147,229,9,78,162,91,7,122,13,217,56,252,18,140,177,183,161,232,20,106,156,32,60,171,249,24,17,28,40,94,100,89,205,232,80,166,208,140,120,201,102,231,108,139,94,32,119,253,85,166,146,60,100,122,101,80,120,169,240,232,240,239,240,44,187,162,135,203,27,41,56,45,97,121,247,2,72,209,50,230,174,125,51,114,200,185,1,189,7,227,45,111,90,103,222,75,95,220,174,224,164,62,169,210,199,164,100,23,75,14,221,192,157,67,249,80,146,119,116,56,211,60,72,170,170,166,59,88,255,69,70,119,190,36,135,13,75,114,248,79,170,78,25,202,54,183,246,138,210,101,229,223,40,51,165,17,222,254,166,202,175,112,105,63,49,176,37,182,52,10,175,168,44,65,214,122,181,183,185,7,255,205,38,224,222,253,247,100,97,111,198,8,34,206,95,241,99,3,3,79,23,48,69,13,226,241,4,173,18,40,86,56,205,157,141,141,83,170,242,110,145,170,200,211,5,144,137,158,150,89,80,82,77,140,123,31,4,70,179,118,170,77,12,238,86,98,94,128,149,217,1,96,242,74,45,47,219,55,172,124,239,54,12,187,243,135,27,100,252,55,66,97,118,137,183,173,60,140,112,167,242,11,201,6,197,31,220,84,93,53,148,32,188,229,145,110,127,139,226,174,247,40,198,110,246,223,234,8,145,123,72,8,255,27,76,68,153,117,117,79,2,105,159,222,185,227,230,22,247,110,222,242,154,204,45,201,19,189,202,69,145,104,248,116,157,64,134,139,128,197,37,195,191,21,225,126,44,34,122,77,151,139,151,142,172,60,248,163,27,241,232,51,240,239,236,211,22,27,190,18,145,254,76,132,95,239,110,219,119,97,221,168,87,88,38,159,186,15,191,252,31,79,142,111,144,117,182,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInvalidRoleBasedLicensesLocalizableString());
			LocalizableStrings.Add(CreateInvalidRoleBasedLicenses2LocalizableString());
			LocalizableStrings.Add(CreateInvalidRoleBasedLicenses1LocalizableString());
			LocalizableStrings.Add(CreateInvalidRoleBasedLicensesRolesChangedLocalizableString());
			LocalizableStrings.Add(CreateInvalidRoleBasedLicensesRolesChanged2LocalizableString());
			LocalizableStrings.Add(CreateInvalidRoleBasedLicensesRolesChanged1LocalizableString());
			LocalizableStrings.Add(CreateRoleNotFoundExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInvalidRoleBasedLicensesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6aef3985-32e8-8f20-0722-bf40dbeb333e"),
				Name = "InvalidRoleBasedLicenses",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidRoleBasedLicenses2LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("287feb49-c6d1-9fc4-63b4-9024e69c1040"),
				Name = "InvalidRoleBasedLicenses2",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidRoleBasedLicenses1LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6aba147a-67e3-1149-91e0-18f839a69982"),
				Name = "InvalidRoleBasedLicenses1",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidRoleBasedLicensesRolesChangedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b25ecc4d-69ed-a04e-8094-4ffe8c726577"),
				Name = "InvalidRoleBasedLicensesRolesChanged",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidRoleBasedLicensesRolesChanged2LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2b62c3b9-632e-b2c7-aab1-a9ba6133d08f"),
				Name = "InvalidRoleBasedLicensesRolesChanged2",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidRoleBasedLicensesRolesChanged1LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ea994d1b-eb12-15a6-40af-d87b0054394c"),
				Name = "InvalidRoleBasedLicensesRolesChanged1",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRoleNotFoundExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d763f696-3c66-93b3-8c49-3c09e850507b"),
				Name = "RoleNotFoundException",
				CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044"),
				CreatedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"),
				ModifiedInSchemaUId = new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca0dd386-2db5-4cf2-8964-80b3a64d7fd9"));
		}

		#endregion

	}

	#endregion

}

