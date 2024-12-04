﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberInWordsSchema

	/// <exclude/>
	public class NumberInWordsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberInWordsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberInWordsSchema(NumberInWordsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09a87c67-bcd5-4ac6-b1fe-80bc8a216ea8");
			Name = "NumberInWords";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,61,107,111,28,71,114,159,105,192,255,97,110,137,195,45,207,171,37,37,219,8,44,145,2,28,157,29,8,136,157,192,82,146,15,130,16,44,201,161,180,240,114,151,216,135,100,194,32,32,83,231,115,2,25,81,98,216,206,33,144,207,246,33,72,242,145,150,69,155,162,37,234,47,204,254,163,84,245,179,170,31,243,88,46,69,242,64,218,34,103,250,81,93,85,93,93,93,93,93,221,51,26,180,187,183,146,107,155,131,97,186,126,233,213,87,70,228,181,121,61,253,104,104,210,174,167,253,126,107,208,91,27,54,175,244,250,105,243,157,238,176,61,108,167,3,183,206,149,94,167,147,174,12,219,189,238,160,249,55,105,55,237,183,87,114,138,64,214,171,175,116,91,235,233,96,163,181,146,178,54,186,107,237,91,163,126,11,139,189,250,202,199,175,190,50,179,49,90,238,180,87,146,193,16,210,86,146,149,78,107,48,72,222,31,173,47,167,253,171,221,127,234,245,87,7,80,6,203,57,5,7,195,62,182,13,0,239,164,253,225,219,235,189,81,119,120,189,247,193,104,249,218,176,95,95,77,87,218,235,173,78,210,18,201,115,137,168,127,167,213,79,6,203,201,82,210,77,239,38,215,68,245,191,30,181,59,171,105,191,62,7,8,207,204,100,223,143,239,103,207,224,191,157,102,246,237,248,94,118,144,189,200,246,198,159,140,63,175,75,56,141,36,251,34,219,201,126,25,255,219,120,27,203,124,7,197,127,200,126,201,246,26,0,87,130,232,167,195,81,191,11,175,205,235,61,217,132,132,189,133,12,41,71,194,123,173,78,122,4,52,100,255,145,237,102,63,103,255,37,82,118,225,191,253,8,85,255,139,229,129,170,131,236,209,132,116,221,233,181,87,53,85,239,182,187,173,238,74,10,178,49,90,239,14,174,247,68,143,214,135,183,219,131,68,136,218,102,146,138,63,141,228,234,59,221,209,122,218,111,45,119,210,69,201,153,203,73,87,200,129,172,252,62,138,19,71,54,89,25,245,251,105,119,101,179,129,72,188,59,234,174,168,154,128,184,130,112,43,29,74,124,45,144,178,172,92,131,241,208,90,185,157,212,177,164,139,73,210,238,250,216,205,9,192,51,171,61,96,71,170,58,14,26,144,20,194,176,25,94,223,220,72,87,101,133,127,108,117,70,233,162,44,122,185,238,130,146,24,148,144,72,195,1,211,85,51,74,172,228,31,130,241,82,136,25,177,150,21,206,215,210,33,65,183,238,194,108,112,137,208,8,44,55,175,116,210,150,230,227,86,25,57,185,218,29,202,65,95,44,41,8,168,156,176,136,1,113,146,229,37,153,186,192,152,209,91,36,48,205,236,79,80,240,57,148,120,12,191,119,198,15,179,175,178,39,217,30,60,239,141,255,144,237,156,14,121,82,130,4,124,95,237,117,59,155,10,199,27,55,49,165,35,88,172,250,203,100,8,134,215,106,66,0,102,106,64,241,46,112,231,225,120,91,167,0,79,14,200,219,246,248,129,200,255,44,123,238,215,1,78,209,124,68,75,76,124,57,98,254,187,229,206,209,136,121,37,97,62,29,226,44,96,1,223,128,154,214,10,114,78,84,81,178,161,197,185,159,174,41,73,61,233,178,26,22,138,32,113,140,129,146,70,214,67,72,49,130,148,236,14,106,56,205,144,81,27,186,0,148,43,128,7,38,212,241,117,78,194,149,248,154,78,82,70,220,123,173,225,237,230,7,144,182,170,88,156,252,58,57,223,72,222,80,228,33,180,126,171,251,33,84,88,144,41,32,38,73,253,146,76,188,156,156,123,67,62,158,59,167,133,97,166,189,150,16,80,201,18,212,52,121,51,203,32,99,31,74,64,130,87,22,163,223,46,37,231,85,19,91,150,18,201,40,159,18,218,249,64,237,219,171,171,146,97,80,178,86,83,168,3,30,138,17,128,199,2,34,114,222,32,226,214,1,21,184,11,90,20,212,162,170,61,163,25,11,185,49,123,233,107,138,110,218,25,164,249,208,65,117,124,90,1,250,35,3,93,252,149,227,23,32,231,12,225,156,233,64,114,162,210,116,0,85,204,56,147,173,67,111,228,181,142,28,23,114,177,72,186,92,192,105,190,189,177,145,130,136,213,146,154,42,203,211,41,195,76,155,186,127,161,85,202,77,163,234,111,44,36,231,132,240,221,84,32,177,125,37,48,126,143,207,48,48,175,65,175,208,222,174,208,221,90,110,105,135,251,192,105,103,87,232,109,211,221,57,93,41,73,172,212,149,80,197,242,29,94,130,253,65,210,41,57,170,128,70,12,20,158,42,36,123,48,164,17,61,232,180,18,54,227,86,178,106,51,180,58,180,86,177,92,26,98,141,249,249,249,100,113,48,90,95,111,245,55,47,235,132,89,243,163,31,229,223,196,188,235,7,72,89,220,104,245,91,235,168,107,113,225,186,84,235,167,131,81,103,88,155,191,108,193,232,167,166,105,113,158,54,201,113,229,26,219,233,51,189,184,131,23,69,138,179,178,129,190,51,47,13,7,150,196,204,204,182,26,148,81,89,32,86,66,141,191,219,233,245,250,117,219,132,98,190,80,164,217,19,129,207,15,82,66,140,66,173,147,226,48,154,44,204,185,228,183,48,132,22,204,96,140,139,163,173,211,96,84,20,138,165,34,75,34,169,22,156,217,151,2,201,29,168,131,198,214,231,102,253,250,52,219,207,246,234,156,10,222,30,7,24,156,132,243,186,40,176,94,62,235,180,188,78,83,221,134,175,122,112,83,33,249,30,24,249,163,144,11,176,176,177,159,176,59,235,92,64,190,164,189,233,182,196,251,90,40,10,42,41,178,101,163,61,78,157,66,144,38,223,52,244,129,130,84,74,29,136,26,148,49,56,200,19,194,5,151,82,63,103,214,133,209,208,60,21,191,97,206,189,240,250,27,205,55,207,55,139,149,15,209,61,82,219,128,10,210,89,150,156,191,12,69,212,111,223,105,13,211,136,108,228,55,22,224,225,196,210,194,7,236,111,146,223,56,82,193,199,9,127,22,29,205,68,132,39,152,159,102,72,55,48,252,173,5,80,91,88,168,105,211,97,126,158,213,121,183,215,95,111,13,147,122,237,227,133,139,11,11,91,53,37,104,179,179,17,245,163,168,57,65,106,169,88,49,25,154,52,59,29,166,170,7,11,40,77,147,21,208,81,75,53,201,105,93,76,79,86,26,222,28,232,173,136,150,18,41,253,20,222,63,28,112,132,232,88,119,187,213,168,76,155,97,235,146,234,164,114,64,91,186,205,46,74,182,57,120,56,205,187,207,224,137,232,116,24,80,11,35,232,113,87,138,226,49,56,114,238,169,17,166,76,202,241,253,192,44,175,199,10,174,39,136,138,194,85,141,180,149,85,95,215,172,97,10,98,1,13,252,146,253,132,98,145,100,63,128,249,15,173,36,240,182,139,254,37,209,44,136,15,200,23,46,4,63,23,218,232,105,19,23,8,147,217,116,186,130,175,89,243,237,57,221,32,146,70,224,59,66,157,252,10,22,42,78,210,199,229,72,23,195,10,61,102,247,32,97,199,48,1,88,34,10,129,97,133,229,31,143,239,143,63,69,236,246,198,191,31,223,75,64,215,29,136,1,10,153,63,195,72,124,33,188,109,154,67,100,241,161,90,199,254,47,63,196,124,157,198,197,179,226,180,206,101,202,53,240,187,57,154,217,234,96,57,197,88,181,4,138,170,179,121,165,181,49,168,59,96,17,28,211,237,129,197,247,28,148,249,79,40,35,212,26,206,113,227,7,217,110,51,251,6,58,97,123,238,240,108,58,98,166,132,144,151,82,192,146,142,144,119,126,91,39,77,182,164,133,119,38,90,213,120,114,146,37,75,73,151,43,92,108,38,118,102,96,119,229,98,173,118,50,80,61,1,19,9,233,71,173,245,13,112,187,211,22,172,229,0,238,94,221,134,78,156,187,148,64,57,97,98,212,194,149,46,228,85,138,213,201,111,201,80,162,171,47,206,59,136,23,16,242,166,236,8,206,54,204,80,197,189,198,27,138,68,245,215,62,204,214,160,251,112,155,193,32,167,234,6,81,11,250,172,140,24,73,159,85,129,34,137,46,79,89,46,73,206,179,237,196,58,86,45,98,37,214,151,99,246,157,237,16,13,23,0,138,250,49,112,181,203,185,5,212,162,89,54,200,128,39,121,109,104,19,46,103,17,206,237,60,37,14,43,233,6,70,150,40,147,248,237,254,45,216,62,235,14,223,209,233,53,198,232,48,19,204,56,34,44,53,128,39,246,243,125,166,187,31,2,29,248,18,34,251,35,232,133,103,194,66,218,21,105,15,19,120,216,203,95,182,169,137,1,226,106,96,251,101,41,100,208,26,121,171,219,182,137,95,94,214,4,187,14,109,39,101,198,14,111,247,123,119,197,144,241,24,39,203,195,112,176,192,106,65,255,129,203,81,34,190,124,217,168,56,211,180,150,181,129,156,44,46,37,184,198,133,205,168,143,196,182,152,177,54,29,238,74,223,0,229,173,228,28,91,192,111,37,194,51,31,104,162,211,235,222,42,209,6,22,43,217,136,2,241,222,38,239,187,245,205,107,122,167,213,201,170,59,254,51,99,200,175,182,239,128,121,190,224,152,253,22,255,121,180,222,133,23,196,199,25,108,113,152,133,198,247,198,255,2,239,159,130,243,64,44,111,229,2,183,174,0,55,18,248,31,241,138,128,176,149,118,20,155,105,235,231,12,126,98,21,177,48,167,153,66,32,110,29,106,33,124,212,10,176,96,157,235,233,65,76,48,56,145,85,55,136,207,239,132,233,193,215,215,199,160,50,15,173,252,44,137,196,218,40,65,43,87,142,135,80,223,174,51,96,173,211,3,119,79,208,11,169,165,66,154,125,166,183,28,51,73,188,10,40,6,93,55,219,175,224,53,196,250,33,33,94,14,205,52,83,80,98,99,124,89,224,169,250,0,13,7,139,238,249,191,138,47,166,40,245,19,56,142,255,146,39,152,147,52,61,88,29,5,253,41,202,112,89,33,185,23,152,228,52,79,196,244,34,165,229,108,118,153,226,236,82,89,217,85,24,221,82,192,166,61,184,95,194,120,58,188,168,74,210,173,164,122,198,207,153,237,115,236,210,137,27,81,211,22,206,201,69,198,17,107,22,105,134,80,76,28,138,112,183,131,219,221,4,187,208,92,196,176,153,125,39,220,214,143,68,201,159,130,162,45,136,63,110,241,204,177,201,167,110,146,11,69,233,74,209,96,153,108,136,59,182,179,209,171,17,227,222,154,118,100,218,116,27,32,122,185,96,11,139,218,208,128,86,190,145,45,1,150,40,163,154,190,140,125,204,136,132,80,70,106,152,38,224,69,106,6,252,24,206,182,154,103,115,134,183,205,57,155,248,120,137,193,2,9,240,253,207,150,179,17,83,147,198,163,86,145,213,128,99,67,108,75,227,128,145,67,158,200,105,195,29,186,232,76,11,79,70,98,212,210,189,37,225,115,227,172,241,253,14,46,143,124,54,16,38,76,182,200,158,100,32,135,185,145,188,134,33,181,36,106,217,209,163,184,253,255,214,91,111,145,184,136,156,149,183,181,184,3,0,60,94,234,160,137,50,26,69,65,1,42,76,254,248,193,141,48,73,55,237,121,1,30,154,95,89,174,252,229,204,233,17,171,9,140,235,51,169,122,25,82,229,155,209,167,70,168,74,154,193,103,114,244,82,228,200,53,120,79,143,24,149,178,86,143,67,138,114,38,183,147,58,183,205,246,211,91,232,104,141,55,85,198,156,230,230,27,117,66,88,167,98,67,215,170,157,191,240,102,98,54,37,207,171,231,217,154,117,108,2,8,140,220,12,67,103,6,103,34,183,60,99,17,8,60,50,49,52,68,40,79,195,253,90,106,41,184,175,193,228,141,21,23,62,129,202,132,71,203,5,158,244,32,113,238,172,128,62,183,183,143,18,44,130,163,188,234,56,26,230,114,128,64,188,160,8,218,122,30,175,110,235,75,79,170,93,89,202,202,128,251,141,16,196,155,108,33,27,0,254,107,9,252,87,116,93,203,168,98,112,29,114,111,186,225,177,131,229,70,132,175,13,210,53,122,37,108,188,189,206,82,50,20,162,231,74,52,113,117,59,220,8,133,94,18,169,240,88,48,199,135,33,128,145,35,49,56,44,131,206,234,151,16,131,57,59,107,130,47,175,218,241,168,64,51,49,47,14,202,60,158,96,72,235,218,247,151,121,49,31,162,31,12,105,160,208,136,192,3,18,12,41,66,0,199,159,195,244,2,113,56,123,80,96,47,1,20,68,112,12,150,123,14,17,133,16,81,99,163,34,157,38,97,28,232,77,100,215,198,158,203,193,69,68,31,82,132,66,33,138,54,216,17,162,14,145,122,148,200,109,112,12,25,100,38,10,61,156,130,100,201,13,175,211,47,88,238,58,239,68,201,85,112,225,246,18,132,202,193,228,114,98,182,92,253,128,219,66,54,216,48,91,197,139,26,24,101,6,32,60,215,74,134,211,70,245,108,80,131,151,242,36,250,123,44,174,129,2,63,212,182,113,134,15,171,89,167,153,38,224,221,115,147,93,120,93,238,199,153,216,46,50,67,129,113,117,206,196,122,85,10,205,12,207,98,165,28,225,185,5,26,98,79,38,48,64,202,26,68,147,90,66,220,4,10,91,224,78,117,60,87,203,164,179,136,56,199,191,174,14,133,222,109,15,241,190,129,48,109,102,0,172,180,192,7,127,254,162,124,41,223,224,31,49,1,94,20,200,75,4,216,133,139,228,229,117,250,242,70,229,102,36,93,188,145,213,116,173,5,142,246,9,97,49,30,109,149,119,214,159,13,177,226,33,22,55,111,116,39,69,140,212,66,200,190,231,86,90,239,229,12,88,34,247,227,7,204,99,17,140,8,207,254,71,30,156,24,63,80,203,49,117,144,66,196,60,59,246,59,78,133,144,224,210,105,32,220,176,149,189,37,131,170,74,73,104,45,203,27,44,116,152,171,130,35,142,102,171,251,41,148,222,52,37,195,65,237,49,60,105,99,110,27,154,241,48,165,63,132,208,235,127,197,147,41,168,153,178,111,161,170,132,183,147,61,75,46,146,42,184,48,37,181,240,76,132,95,195,195,189,106,147,117,26,67,131,167,138,178,159,128,42,212,150,79,27,44,235,39,1,9,179,246,156,44,0,138,226,244,4,165,192,173,245,76,170,4,161,134,183,209,192,130,119,76,49,177,235,120,157,76,147,183,139,65,60,44,225,18,41,201,208,192,146,44,129,148,228,88,225,124,195,18,40,204,40,146,2,147,88,38,237,238,233,112,95,13,85,183,161,178,28,149,168,92,76,144,168,122,20,88,188,153,188,156,162,126,52,124,80,46,25,231,158,163,96,135,70,203,6,186,52,86,54,212,169,113,28,114,186,82,212,212,90,173,196,192,75,222,75,241,70,158,1,239,127,221,210,35,38,207,31,227,149,62,240,91,105,176,128,200,95,74,182,146,173,16,160,175,153,184,7,1,113,110,197,0,125,207,70,67,8,144,195,202,24,160,71,209,193,18,38,51,202,115,217,128,228,187,51,187,232,54,123,119,32,214,174,189,154,86,84,196,206,2,68,166,194,12,33,22,24,247,197,68,135,75,188,255,6,119,214,61,113,144,18,81,181,222,162,184,18,255,6,227,20,42,43,242,60,29,93,26,162,186,212,41,201,94,80,22,112,45,202,178,80,119,177,4,174,175,98,99,196,173,50,253,238,8,224,234,179,222,113,237,26,52,45,235,110,220,36,166,128,138,186,161,185,150,235,184,72,148,58,148,151,41,57,39,67,16,206,129,212,139,232,207,22,207,207,179,29,242,124,64,158,247,32,138,246,80,77,61,65,203,77,0,196,167,93,243,100,211,96,236,28,178,17,121,170,23,1,138,167,41,0,252,76,40,201,7,168,64,4,88,241,174,252,41,7,17,224,229,7,19,176,69,156,171,197,48,168,67,131,66,255,2,234,162,233,0,251,4,10,61,155,10,40,236,217,105,130,3,143,78,246,152,113,77,93,249,199,180,45,177,228,153,123,62,124,105,33,41,115,144,237,227,8,100,149,244,40,116,74,145,145,136,185,223,10,169,120,60,126,144,61,229,37,147,58,37,251,11,76,20,210,153,91,236,79,194,139,244,153,56,164,232,21,84,67,7,220,89,226,4,187,195,216,252,170,114,144,76,86,245,19,133,249,126,133,74,90,196,201,69,143,21,90,52,66,61,89,117,37,119,19,85,166,130,59,25,0,37,170,168,74,133,149,0,26,131,202,171,187,112,99,245,227,139,183,192,118,96,221,223,188,243,156,87,206,246,82,249,181,94,92,174,47,22,225,108,38,214,35,197,217,222,107,103,54,182,98,107,243,24,104,5,41,110,43,197,71,109,156,9,209,171,81,29,244,190,129,145,252,165,30,142,206,109,169,2,144,162,143,220,123,10,195,182,161,19,213,36,142,147,55,25,213,38,91,76,183,145,76,165,11,34,153,118,242,139,128,150,151,66,68,106,171,145,27,203,22,3,43,6,216,140,188,56,81,106,18,112,10,200,238,139,153,119,199,43,133,172,155,111,132,193,223,140,75,96,158,174,41,28,136,121,181,141,5,142,172,252,89,204,43,184,82,218,101,115,160,185,41,67,153,228,185,101,209,68,207,45,192,247,60,162,54,123,17,140,147,208,201,37,216,97,15,84,56,94,124,182,111,192,46,101,53,193,71,38,2,218,30,132,135,103,21,235,108,119,48,229,161,121,181,13,35,55,94,220,96,249,233,169,71,117,221,38,149,209,136,233,101,162,45,10,238,138,182,5,3,234,207,93,236,212,212,92,106,47,131,70,123,92,108,227,145,75,163,113,191,19,211,118,76,26,177,229,121,142,182,80,156,139,167,141,233,225,164,43,147,128,167,82,99,193,201,33,6,171,202,41,97,180,146,152,40,199,49,109,35,127,254,172,111,190,102,122,34,144,15,250,161,112,55,204,83,25,122,16,58,187,54,174,55,132,94,208,189,83,139,122,87,216,166,76,30,140,189,34,24,202,79,147,3,195,135,224,13,103,47,193,129,230,230,55,185,195,202,52,144,47,254,166,43,194,29,84,173,91,66,218,17,121,174,46,175,194,123,209,148,227,199,211,141,182,201,122,137,202,190,166,143,149,84,122,62,7,11,170,229,43,137,85,97,219,147,73,90,49,73,176,39,95,44,199,17,25,44,7,29,246,176,142,68,66,153,111,54,79,66,243,119,46,197,25,22,181,121,153,200,253,250,166,188,167,133,199,51,58,155,253,42,106,0,102,165,240,214,189,171,251,11,37,31,167,5,162,5,213,196,80,162,154,179,44,15,233,67,182,210,182,227,17,150,108,207,68,180,10,196,171,0,19,159,215,74,20,131,224,220,236,73,180,160,50,176,75,64,220,87,11,250,10,197,113,71,99,187,84,113,49,51,237,203,57,178,108,241,23,37,11,163,9,25,40,26,184,192,146,6,140,240,20,30,138,194,46,38,9,205,147,84,201,154,104,154,114,59,242,244,210,5,247,234,2,35,196,4,163,202,23,54,186,164,146,3,97,156,21,129,54,60,86,208,161,230,157,77,99,111,165,110,49,80,17,95,54,0,73,14,19,161,87,172,129,186,110,178,185,77,74,210,147,43,173,206,138,1,163,47,155,183,55,165,43,29,101,106,20,250,193,21,102,180,9,29,250,194,75,56,13,75,228,108,109,125,226,231,239,123,119,235,42,54,158,232,144,230,223,166,221,91,195,219,24,24,175,109,114,125,96,8,47,201,85,73,119,111,183,33,5,217,128,209,240,200,4,120,52,87,251,226,87,17,46,80,47,137,165,21,139,99,78,81,104,193,23,48,190,94,192,64,121,6,255,126,164,55,80,202,235,208,246,163,166,159,153,71,242,172,14,103,173,83,114,88,24,97,98,163,129,134,63,50,168,52,184,145,75,34,187,173,132,163,162,150,31,85,174,111,150,38,147,71,146,99,170,186,135,146,99,129,236,98,126,22,95,92,25,44,179,93,35,51,43,185,53,165,224,46,247,122,157,164,221,29,164,253,225,53,241,53,181,165,100,173,5,75,43,123,251,146,195,221,208,41,3,255,220,46,48,66,234,84,63,254,211,29,252,44,128,219,103,147,102,132,88,251,234,107,253,213,119,88,104,84,167,76,107,94,29,188,15,171,169,191,235,191,179,190,49,220,172,15,120,84,37,141,56,19,12,35,132,115,211,208,46,40,237,53,191,124,205,233,214,7,198,13,251,35,171,14,104,175,152,207,17,48,31,100,108,139,206,126,174,128,71,209,120,159,71,139,46,83,115,135,168,244,121,238,102,63,194,178,248,62,152,24,184,9,32,236,140,109,185,21,225,56,24,196,229,131,7,232,1,192,253,12,177,123,129,123,24,224,9,80,248,78,244,133,132,146,99,164,202,181,159,213,111,10,112,163,148,156,112,36,239,38,138,35,184,247,244,88,232,158,236,170,202,232,253,148,62,163,142,254,234,211,233,74,208,164,151,28,157,114,1,154,252,110,167,51,249,153,198,53,58,167,91,124,38,191,60,232,76,122,166,112,205,205,41,23,158,73,239,246,57,137,178,3,180,164,253,46,76,197,156,100,219,172,191,67,83,137,12,63,71,134,78,239,41,63,163,8,141,171,155,47,106,230,153,139,222,218,170,224,102,104,62,215,122,243,110,240,18,104,119,83,95,249,134,61,138,75,93,85,204,79,238,4,239,7,202,23,195,64,108,1,231,155,183,162,82,171,4,137,246,63,103,95,192,14,206,87,184,13,25,34,160,48,38,160,160,45,189,154,16,223,57,196,49,209,22,238,1,248,179,136,29,40,23,245,151,146,215,94,107,91,103,197,96,249,70,251,38,20,91,185,221,234,67,23,255,3,172,45,250,87,187,119,90,253,118,171,59,172,139,220,248,110,150,166,74,12,253,35,166,42,212,174,138,184,16,223,143,56,98,158,2,39,22,114,249,180,16,218,146,230,218,203,134,81,5,6,172,148,12,233,188,85,114,162,70,90,5,32,178,35,52,16,241,86,29,8,229,170,6,69,210,232,215,180,11,135,58,113,133,251,46,61,238,39,167,46,117,122,199,128,86,11,17,173,225,65,53,80,140,135,70,62,196,239,152,39,142,64,223,221,195,191,28,228,44,28,228,23,168,24,154,204,175,168,184,174,99,99,236,189,251,65,117,21,214,57,180,90,153,195,122,7,252,139,81,165,102,195,224,7,83,228,46,141,3,14,183,178,156,36,122,146,194,253,166,11,79,224,238,192,178,27,28,225,6,171,212,119,145,40,156,40,34,238,247,168,108,229,238,232,168,126,44,129,103,238,199,190,168,19,154,111,164,185,236,97,27,90,121,116,22,146,89,121,247,170,60,173,57,95,170,138,83,202,59,146,209,25,83,112,236,19,27,223,129,147,234,7,113,202,90,69,170,210,177,133,80,68,98,1,238,245,130,45,69,140,127,190,39,27,194,80,44,242,246,144,190,1,184,167,106,179,104,194,86,217,86,59,70,135,239,147,111,175,201,120,113,154,178,199,82,96,159,75,126,188,172,52,243,240,75,111,184,119,181,67,3,238,143,136,129,234,156,184,104,12,163,94,254,47,251,247,154,147,140,40,133,51,240,160,175,202,58,20,127,189,94,197,79,82,193,86,162,232,69,245,44,249,108,222,112,207,186,26,87,191,18,190,208,131,163,230,39,134,214,96,40,126,236,249,228,51,234,207,2,129,31,197,161,188,35,29,187,219,186,33,121,64,34,242,54,93,134,193,190,48,24,95,226,128,73,240,185,26,171,200,183,153,143,152,89,136,164,248,55,85,118,88,168,19,146,253,245,148,201,118,53,237,116,200,142,67,213,100,31,177,27,59,119,39,192,251,166,160,57,103,174,51,188,51,215,228,139,176,246,68,221,203,241,200,231,249,164,143,147,146,233,116,193,132,223,3,43,77,223,116,247,83,166,210,87,199,74,114,209,242,150,93,142,20,18,92,110,46,151,114,113,169,69,98,145,225,92,46,22,178,244,226,178,72,107,73,159,97,56,202,219,38,240,19,234,218,165,162,96,243,187,2,100,205,156,44,125,145,57,93,133,186,237,225,105,126,39,137,174,66,29,4,112,29,234,36,209,123,2,24,70,22,114,180,164,14,106,52,37,233,181,39,238,234,182,144,117,124,49,27,97,97,176,80,0,207,72,17,139,160,112,217,154,67,238,69,178,198,142,184,43,144,133,181,188,251,107,226,203,57,151,74,182,160,43,223,158,19,201,26,105,205,97,215,161,218,50,113,173,249,109,105,190,179,182,60,137,40,221,42,137,113,205,111,215,10,87,60,250,90,164,37,240,99,98,57,156,70,202,58,248,172,206,247,131,156,168,2,228,90,177,230,37,213,212,163,105,53,252,185,232,170,23,22,134,34,140,124,207,163,126,81,55,142,70,93,133,249,95,113,156,232,203,146,47,251,107,148,145,29,21,87,196,42,204,51,102,203,202,191,55,39,122,227,66,153,27,54,148,49,15,17,67,210,30,70,105,13,72,172,140,242,211,123,2,252,230,141,139,1,177,214,123,2,6,109,255,90,131,105,161,205,141,19,155,225,6,161,107,179,67,141,84,77,11,191,252,227,196,210,194,143,124,68,104,225,247,143,156,88,90,24,154,49,90,226,87,160,156,88,186,162,40,123,177,127,177,165,182,119,240,130,143,52,189,83,196,82,11,54,159,60,144,92,224,53,72,150,90,21,36,151,59,13,146,165,86,5,25,239,126,195,132,88,137,186,163,201,88,92,165,171,223,42,26,104,83,51,44,60,187,66,154,17,91,83,177,3,25,112,113,125,231,100,192,3,70,223,116,65,51,27,47,15,116,168,51,125,243,170,212,93,110,80,209,104,9,241,176,134,193,192,229,174,129,19,120,230,220,63,165,108,193,156,139,165,156,18,129,27,163,156,18,5,87,65,57,60,242,133,61,144,18,184,86,48,108,122,20,25,167,196,188,35,246,159,58,248,171,87,240,202,140,194,184,110,122,255,170,191,97,237,248,58,88,51,164,101,219,162,13,74,103,91,106,186,192,57,14,216,107,159,52,165,173,191,28,215,1,21,149,73,124,3,204,161,195,113,8,89,202,174,155,135,229,240,30,144,231,173,197,117,162,14,143,104,184,62,127,163,207,5,71,229,114,142,72,10,225,171,64,233,225,8,85,148,10,212,237,47,151,118,74,186,169,78,222,42,83,30,56,195,57,21,186,171,246,48,27,77,242,143,56,123,63,27,232,249,6,235,120,231,157,190,84,224,0,59,103,90,200,1,230,146,99,184,68,26,43,121,232,52,71,223,109,253,63,38,162,29,28,229,160,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09a87c67-bcd5-4ac6-b1fe-80bc8a216ea8"));
		}

		#endregion

	}

	#endregion

}

