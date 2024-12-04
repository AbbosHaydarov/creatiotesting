﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailAudienceHelperSchema

	/// <exclude/>
	public class BulkEmailAudienceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailAudienceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailAudienceHelperSchema(BulkEmailAudienceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f044a257-08b3-450e-953b-a6073e1ccc6d");
			Name = "BulkEmailAudienceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,28,107,111,220,54,242,243,22,232,127,96,183,184,158,92,239,201,238,245,80,28,210,56,128,159,169,15,113,146,243,110,46,31,130,32,208,74,180,173,88,43,109,36,202,143,22,254,239,55,195,55,41,74,187,118,124,185,246,112,69,91,239,146,195,225,204,112,94,28,146,91,38,11,218,44,147,148,146,25,173,235,164,169,206,88,188,95,149,103,249,121,91,39,44,175,202,248,36,41,179,58,47,138,41,173,175,242,148,126,253,213,111,95,127,53,106,155,188,60,39,211,219,134,209,197,207,222,119,24,95,20,52,197,193,77,252,156,150,180,206,211,14,204,65,194,146,78,227,243,162,154,39,69,254,43,159,184,211,251,34,47,63,117,26,103,23,53,77,50,104,232,239,137,103,73,115,217,152,126,155,209,154,246,181,199,7,123,189,93,135,37,203,89,78,123,113,198,175,235,42,165,77,79,255,98,97,51,103,122,222,210,121,252,11,99,203,120,119,222,176,58,17,2,4,64,0,93,182,243,34,79,73,90,36,77,67,222,44,179,132,209,89,82,159,83,182,219,102,57,45,83,138,226,4,56,92,26,5,220,7,22,189,105,104,13,75,92,138,37,34,173,243,117,66,96,110,164,171,73,47,232,34,121,9,234,49,33,207,219,60,35,53,77,171,58,59,206,38,100,94,85,5,201,155,41,101,251,201,98,153,228,231,229,81,94,55,108,202,232,146,236,144,179,164,104,232,6,225,164,140,78,229,32,104,87,227,145,245,209,104,170,209,67,151,153,75,116,122,20,238,120,52,10,160,227,62,2,194,148,241,65,119,92,154,90,66,238,52,222,87,193,0,8,79,76,215,200,15,46,10,46,25,205,164,55,100,89,231,87,176,4,36,60,84,202,217,18,196,189,134,243,69,232,145,193,90,136,196,255,191,173,233,57,114,187,143,170,245,132,236,181,197,229,225,34,201,11,165,49,191,208,98,73,235,174,18,246,0,226,212,56,133,66,123,148,211,34,3,188,175,5,9,146,3,73,143,39,240,15,157,85,182,129,27,6,94,65,178,253,33,111,118,203,170,188,93,84,109,179,219,178,11,10,246,152,114,167,161,244,79,14,254,150,130,239,226,148,184,100,129,125,2,177,104,194,64,26,103,235,33,138,33,63,141,242,51,18,121,196,147,111,118,72,217,22,133,178,131,209,168,166,172,173,67,76,98,39,172,5,254,241,145,236,16,244,7,208,192,232,13,120,142,182,174,129,211,120,10,158,5,122,223,141,93,186,198,239,73,2,206,33,132,254,209,8,228,136,122,133,111,112,93,37,53,73,150,75,135,149,104,215,110,216,8,113,6,16,133,196,245,110,236,128,143,223,75,66,2,50,114,38,138,133,247,127,51,192,196,16,163,2,4,12,69,177,210,157,238,42,41,90,106,65,223,13,171,218,9,101,23,149,99,2,70,167,175,42,240,30,251,16,166,24,61,165,139,188,196,104,21,241,224,114,75,80,172,236,86,187,227,34,253,117,202,63,9,143,188,76,234,100,209,144,106,254,17,232,122,247,94,124,167,140,214,141,90,4,31,173,194,231,33,122,78,217,11,213,242,47,228,44,26,235,49,39,205,249,126,178,228,226,223,152,216,83,40,47,50,26,61,14,55,178,53,21,147,77,136,16,253,106,30,229,184,140,54,105,157,243,177,24,76,120,99,124,184,88,178,91,177,76,168,181,102,112,188,91,222,70,27,90,87,131,131,143,170,122,145,176,168,43,28,135,240,128,80,70,119,132,130,251,9,35,95,133,206,86,65,149,117,189,97,121,193,115,141,216,151,172,171,226,19,45,98,107,206,137,18,169,183,98,87,121,205,218,164,32,203,186,98,48,156,102,98,237,14,111,104,218,50,42,18,135,41,250,219,6,76,59,226,49,46,135,184,63,152,56,40,129,174,21,187,101,126,36,98,159,12,255,0,42,132,230,98,136,29,88,16,75,114,78,107,72,43,217,113,9,33,1,2,207,222,45,10,47,26,11,178,117,92,210,244,203,241,99,41,94,249,21,121,231,127,85,246,33,229,43,187,61,233,202,177,114,12,120,96,38,35,200,173,180,25,61,237,113,54,158,128,176,188,1,82,178,65,172,210,127,116,215,68,106,55,176,58,171,147,178,57,163,245,44,153,23,148,115,107,216,4,143,201,200,220,249,42,19,54,160,66,174,9,186,99,230,227,0,206,221,97,113,103,26,99,62,210,46,142,155,151,16,51,94,213,220,184,162,14,74,99,85,161,217,92,219,26,79,103,31,126,219,190,227,210,138,103,213,94,210,208,31,127,2,187,148,190,26,73,110,48,155,43,233,53,153,50,72,170,51,190,52,89,91,251,98,156,144,49,107,150,31,196,250,113,78,102,180,97,34,241,157,205,11,181,240,163,102,25,191,205,217,197,107,101,178,209,152,41,234,128,138,46,51,102,152,90,62,213,180,74,110,64,118,7,93,120,232,52,185,210,104,133,225,203,232,20,30,63,96,193,47,64,217,159,230,37,123,134,10,227,73,225,244,56,195,238,251,105,205,214,22,32,130,53,64,72,6,168,8,227,184,26,146,86,109,201,16,194,76,169,186,196,114,233,118,201,25,87,63,1,49,165,184,51,84,203,202,191,248,70,33,228,132,155,200,118,81,66,52,2,139,82,109,71,117,181,176,108,77,183,191,189,160,160,21,99,205,53,14,1,93,61,252,4,34,138,4,162,216,44,59,112,184,129,169,146,152,94,200,94,236,197,162,131,61,177,212,85,77,178,185,254,184,227,121,62,216,255,53,160,134,7,123,166,201,10,40,18,213,49,238,181,78,97,7,10,73,49,110,68,225,207,142,43,5,165,86,2,40,50,19,26,92,163,235,139,188,160,36,18,8,98,132,180,102,2,211,44,173,85,60,149,219,44,14,202,29,36,251,241,175,209,182,82,90,48,74,49,123,188,155,101,145,61,74,67,200,4,233,46,160,142,98,232,42,37,44,42,225,176,78,146,155,227,12,87,203,49,13,233,69,0,153,50,49,201,9,31,182,72,110,28,104,206,205,182,32,13,53,8,250,239,173,61,71,109,153,66,1,227,38,26,163,74,56,106,100,136,248,162,26,160,185,88,103,245,209,243,58,75,79,190,251,78,162,122,183,253,30,83,248,131,61,116,200,49,143,66,150,94,4,101,233,104,198,79,127,179,52,163,127,221,187,136,214,202,36,32,248,214,44,84,128,48,201,132,212,133,186,170,152,217,2,15,214,22,38,210,31,75,37,234,248,107,201,254,96,110,241,121,201,133,203,203,23,73,44,78,181,124,84,149,193,206,47,242,179,232,155,169,27,154,223,94,228,24,5,161,162,23,185,178,53,122,181,206,108,50,42,122,40,126,94,133,32,92,144,64,146,131,29,193,164,249,30,228,153,88,192,125,191,14,245,235,203,19,195,203,132,252,176,122,160,88,123,49,116,79,164,224,194,201,240,254,48,61,232,116,238,133,120,85,46,210,143,101,74,207,23,176,3,24,146,142,4,81,36,221,221,55,67,245,108,28,76,4,230,7,41,230,75,48,7,214,128,83,169,244,132,77,132,161,9,220,180,233,223,199,180,1,20,1,218,107,221,248,154,214,28,94,237,249,176,55,47,97,195,147,20,47,170,235,61,24,2,174,2,27,101,0,146,72,58,153,135,246,39,189,110,65,58,101,140,36,15,118,236,102,32,47,227,194,22,109,150,47,104,213,98,72,250,225,239,219,50,88,113,38,192,113,158,86,215,32,148,127,182,180,190,197,254,109,252,199,130,152,39,12,22,75,112,36,202,163,158,76,200,150,135,197,170,230,4,160,255,228,207,249,140,108,155,144,96,207,182,185,233,22,68,206,64,16,124,189,114,30,113,225,207,83,71,222,208,178,185,105,69,165,110,210,33,161,223,229,186,76,131,64,137,116,148,138,69,197,61,164,150,123,72,142,200,36,177,186,168,135,20,114,209,177,140,75,190,15,8,197,198,127,145,159,95,40,104,53,80,245,107,158,62,10,158,62,2,79,182,12,160,197,230,169,79,168,79,73,228,73,245,123,18,125,36,155,224,49,236,60,108,100,72,217,12,46,229,95,2,120,62,154,204,204,117,128,62,190,160,22,232,213,227,226,108,243,2,194,42,183,72,145,94,168,62,212,247,28,84,185,94,59,119,194,12,105,86,45,3,210,176,0,84,118,110,239,123,55,226,221,198,107,233,14,16,53,227,12,74,101,24,57,249,8,183,169,59,4,171,132,112,26,162,103,176,190,175,6,134,67,163,75,154,137,42,84,112,68,103,123,112,2,212,112,231,14,41,64,19,107,118,78,225,152,12,154,120,190,118,59,171,166,80,238,131,204,217,227,89,1,185,51,241,124,115,13,177,27,46,230,220,125,175,144,169,1,103,12,193,215,23,173,25,153,142,39,227,65,193,106,80,164,255,45,196,189,234,154,107,33,102,214,220,59,26,200,17,130,128,162,190,108,23,115,90,187,80,27,19,27,14,18,149,137,55,142,131,139,169,14,111,150,72,47,14,27,191,170,33,101,133,204,93,16,40,144,59,212,137,92,222,119,250,88,18,96,14,220,49,218,192,63,170,220,214,89,201,54,8,123,35,126,165,165,126,58,188,123,116,54,78,61,51,72,65,74,252,169,68,159,118,177,203,149,147,240,214,86,215,222,214,10,24,57,238,57,79,38,235,192,174,214,141,154,22,105,130,138,69,158,101,5,21,26,104,43,167,156,68,137,22,166,216,163,236,154,210,128,101,104,231,204,221,159,65,177,91,102,93,96,237,193,116,73,7,142,236,44,7,229,120,43,233,150,236,254,126,231,132,137,134,181,138,34,127,178,89,130,236,200,175,200,185,150,96,68,46,58,61,39,97,103,78,33,139,230,74,39,169,180,124,171,225,115,107,235,160,34,185,246,193,86,80,211,82,209,176,110,144,4,111,111,203,69,167,101,214,246,208,219,180,193,100,98,115,98,142,228,240,64,82,184,110,178,239,68,88,12,6,173,0,22,2,23,35,187,245,180,78,137,69,73,245,164,202,242,179,156,102,175,74,144,82,103,205,97,195,75,49,35,138,223,176,244,101,117,189,225,13,214,100,113,170,0,65,208,232,121,121,66,47,230,128,111,240,208,89,46,166,67,152,35,228,13,159,46,153,24,55,88,50,110,27,174,0,129,168,80,95,82,102,226,130,202,183,249,16,33,70,30,15,52,102,101,87,15,241,38,3,203,110,237,209,123,11,199,129,98,190,170,140,117,247,225,143,87,212,223,218,218,191,160,233,37,73,197,105,30,28,55,11,177,242,163,91,74,32,91,198,19,104,176,11,194,42,112,132,244,83,155,195,90,114,2,65,174,99,114,13,71,137,160,149,52,227,216,120,33,64,40,235,113,169,246,214,59,120,226,205,183,56,138,145,55,46,68,228,239,8,157,205,50,137,60,132,58,133,3,61,16,120,157,117,29,194,38,43,36,129,189,20,47,126,60,145,34,193,116,193,46,162,138,83,26,93,212,114,75,176,210,42,221,73,195,21,3,100,230,27,175,152,124,68,33,191,69,223,116,176,39,138,156,146,185,238,89,210,139,10,14,200,234,186,170,101,49,94,42,222,248,157,119,217,39,30,214,162,247,79,200,17,204,14,42,7,43,122,134,179,123,180,147,51,160,6,138,84,241,152,108,170,57,142,179,39,68,21,254,251,101,185,186,250,44,10,80,225,34,52,36,24,2,25,131,76,91,29,73,232,238,254,2,185,95,17,215,20,222,193,73,26,178,23,29,222,164,84,156,231,209,47,44,95,44,223,17,202,253,59,151,170,43,233,62,9,195,185,224,144,144,133,197,118,101,235,111,185,205,30,47,22,219,39,173,132,14,212,83,216,231,106,177,116,231,83,147,242,28,102,70,23,75,158,176,241,214,190,237,123,240,64,215,90,213,224,136,224,145,217,195,214,118,253,197,125,200,234,14,148,21,137,89,208,209,152,75,12,9,171,206,192,26,22,75,81,66,135,171,46,168,28,177,175,10,61,235,223,183,32,188,250,238,165,143,66,136,61,101,252,190,242,148,163,83,80,156,74,193,217,241,182,172,130,123,53,84,53,1,110,112,103,87,144,228,192,62,243,128,119,121,139,19,235,208,254,90,12,177,156,158,66,2,170,102,202,27,93,206,108,208,103,88,124,49,213,79,77,5,180,58,67,76,237,201,77,45,186,39,165,110,191,10,127,71,176,244,246,242,92,195,105,163,46,130,248,138,219,95,34,199,69,27,195,226,241,139,76,253,197,192,255,154,75,26,82,90,169,145,150,51,90,79,55,157,5,212,154,52,16,60,255,31,56,251,20,63,88,119,93,165,194,80,160,10,170,190,155,217,37,89,6,177,200,20,134,236,128,1,246,22,152,214,177,82,255,6,139,239,145,199,61,58,55,109,83,84,174,19,248,15,206,103,64,117,164,110,249,103,233,242,184,69,92,121,1,223,34,78,70,160,246,64,182,225,223,161,48,152,38,69,106,243,133,55,25,69,168,117,67,98,160,178,103,59,51,113,226,122,146,176,139,248,168,168,170,90,26,89,199,219,117,5,181,1,197,222,14,152,29,90,17,0,252,85,188,13,133,67,219,181,170,221,181,90,162,222,197,9,21,55,237,197,217,218,130,100,28,239,89,216,40,10,72,138,68,55,230,165,7,176,39,237,30,17,244,148,96,212,102,70,109,132,214,172,95,184,234,167,183,68,157,43,24,134,92,88,124,174,45,98,155,97,168,93,185,183,149,71,70,106,134,207,216,223,254,199,182,145,61,251,230,251,10,207,93,130,85,91,81,229,168,251,133,255,123,53,100,43,188,110,109,137,98,146,173,205,144,68,11,147,50,9,147,0,94,113,148,21,58,198,10,28,97,169,108,45,184,24,19,239,4,75,159,91,245,158,245,253,14,182,28,13,20,91,32,2,243,216,171,242,24,50,199,242,96,2,196,32,211,15,218,118,160,59,82,251,120,215,104,184,106,134,183,221,19,50,104,59,126,57,1,213,87,9,235,188,2,94,236,205,185,77,204,99,156,11,254,111,185,27,84,135,142,203,89,125,124,225,220,185,153,182,139,110,129,206,45,160,6,46,114,117,202,102,221,34,116,163,162,162,198,246,232,94,174,83,116,51,137,85,42,170,198,13,148,40,193,66,130,39,125,223,187,71,167,124,232,35,251,203,245,221,165,67,47,95,68,63,239,24,190,130,170,30,153,244,155,234,234,215,66,252,107,35,149,84,153,140,44,251,195,168,244,82,224,83,231,228,145,44,166,175,125,65,208,191,31,104,72,241,174,7,14,43,134,34,88,223,18,195,83,141,174,145,13,96,208,60,126,217,27,101,190,12,215,185,88,38,111,119,57,119,203,238,81,96,118,212,162,175,18,187,74,51,20,53,146,150,97,45,179,144,24,205,90,237,221,68,32,24,214,113,113,97,45,92,255,93,151,135,129,0,208,81,199,94,247,173,124,224,253,188,120,40,240,61,90,140,81,99,247,196,177,216,74,202,116,90,2,66,176,9,121,144,5,250,121,231,61,206,59,188,138,74,223,83,72,2,205,73,239,25,7,118,198,161,135,68,29,173,80,192,230,246,149,0,116,116,69,1,169,123,124,2,100,248,45,37,31,16,190,83,247,243,231,156,146,132,236,233,225,167,36,3,216,220,139,45,253,53,47,99,212,54,178,158,123,160,80,29,179,35,51,215,139,245,158,96,201,167,126,184,61,216,34,79,155,22,238,112,213,183,207,84,131,8,211,13,17,183,70,179,182,0,255,154,195,221,231,11,170,27,8,222,43,226,226,225,213,106,232,145,59,10,149,30,199,26,251,22,241,241,63,229,175,133,72,41,52,102,108,56,29,63,35,51,57,9,220,85,197,254,24,199,115,211,232,27,173,36,38,199,182,101,254,169,165,144,39,99,141,12,76,182,230,165,98,232,128,239,16,87,45,54,32,85,112,145,107,131,18,143,31,185,53,245,29,27,174,120,59,28,116,142,251,109,1,30,30,212,233,172,130,179,65,254,25,24,16,207,179,213,211,63,247,155,28,33,214,24,95,111,199,71,144,197,84,16,219,184,6,189,164,215,17,220,133,222,121,166,244,106,13,92,24,40,109,172,163,21,231,163,70,33,189,19,81,169,120,97,151,180,142,4,251,124,145,124,74,102,94,183,173,160,80,195,107,143,162,159,163,65,219,192,61,206,21,186,207,64,222,190,218,215,127,110,140,9,192,102,74,94,34,248,35,232,191,128,27,52,128,0,246,176,231,129,185,118,73,3,45,128,43,97,228,182,106,201,117,130,39,101,176,85,6,25,224,4,103,8,11,233,46,184,111,116,21,216,148,74,52,70,70,235,218,159,31,198,190,224,195,253,63,128,209,122,210,49,57,88,224,55,15,58,178,10,38,148,61,151,212,239,105,243,235,38,31,221,247,172,67,236,5,158,223,246,26,51,23,120,195,149,79,189,70,0,107,208,97,171,81,79,35,27,173,163,42,113,35,25,116,212,249,188,229,123,146,245,109,57,247,236,48,136,143,28,31,172,31,122,244,243,211,117,66,142,121,234,248,153,122,27,254,237,144,248,139,196,32,205,113,190,94,212,113,127,29,65,189,21,245,94,24,155,7,215,246,101,120,213,90,165,252,231,86,160,242,104,158,33,119,95,106,190,240,193,154,24,234,124,226,209,17,236,10,20,110,243,84,171,131,87,61,12,244,219,101,149,210,219,10,191,173,234,75,254,155,52,16,217,154,170,133,195,14,124,0,10,21,16,200,252,188,106,230,24,166,15,49,33,137,145,124,242,39,251,252,146,184,7,42,120,48,137,175,4,244,126,26,161,127,56,200,91,174,173,144,54,255,181,27,44,253,58,100,199,7,244,76,130,201,83,221,208,139,79,243,187,2,129,95,20,80,191,214,225,100,184,119,255,6,95,165,119,234,189,71,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f044a257-08b3-450e-953b-a6073e1ccc6d"));
		}

		#endregion

	}

	#endregion

}

