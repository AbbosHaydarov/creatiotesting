﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MobileSyncSettingsQueryExecutorSchema

	/// <exclude/>
	public class MobileSyncSettingsQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MobileSyncSettingsQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MobileSyncSettingsQueryExecutorSchema(MobileSyncSettingsQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d122f4a8-0c42-4b2c-bcb7-dad15f1c93e0");
			Name = "MobileSyncSettingsQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7f59f1d3-d5d6-45c4-8743-c7152da9862d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,26,93,115,219,198,241,89,157,233,127,56,51,157,4,156,50,112,242,208,23,201,164,199,150,165,132,174,101,171,150,210,60,120,60,30,8,56,82,168,65,128,6,64,73,172,163,255,222,189,219,251,216,59,28,64,218,74,58,211,105,102,34,131,135,221,189,221,189,253,62,148,201,138,55,235,36,229,236,146,215,117,210,84,139,54,62,171,174,242,130,95,108,203,244,130,183,109,94,46,27,246,249,207,127,58,216,52,240,200,46,182,77,203,87,71,222,239,248,184,42,10,158,182,121,85,54,241,79,188,228,117,158,118,96,94,229,229,167,224,98,124,114,183,174,121,211,8,236,14,192,91,190,80,148,237,171,215,252,182,5,88,193,236,203,102,224,133,183,165,21,241,184,90,173,40,222,178,168,174,146,226,240,16,215,227,87,213,114,9,203,97,204,114,145,47,55,117,34,56,138,47,64,208,164,200,255,205,179,147,230,211,105,94,180,188,6,128,27,94,183,242,125,152,64,205,251,214,227,147,178,205,219,156,55,189,0,167,73,218,86,53,66,4,96,240,232,240,221,55,53,95,2,15,236,184,72,154,230,144,117,79,245,31,27,94,111,79,238,120,186,1,146,18,229,221,11,190,72,54,69,251,60,47,51,128,136,218,237,154,87,139,104,46,217,218,58,240,227,9,123,13,182,195,166,108,228,82,118,160,70,227,247,64,118,189,185,42,242,148,165,130,145,93,124,176,67,22,218,78,88,32,80,242,133,66,149,55,243,114,81,225,251,117,157,223,36,45,87,123,145,215,210,132,15,14,228,31,13,244,42,111,218,39,77,91,3,19,51,5,11,118,188,89,149,96,240,108,201,219,35,118,15,242,149,252,214,129,140,198,71,61,164,144,239,139,244,154,175,18,201,61,210,156,177,57,24,178,226,37,72,185,15,209,217,74,139,126,94,87,107,48,48,176,129,67,118,46,53,139,162,107,53,35,155,236,215,170,254,184,46,192,179,143,171,140,235,93,27,189,245,72,157,180,129,26,29,5,169,156,215,249,42,169,183,255,76,138,141,71,68,129,127,195,203,12,25,211,248,74,35,87,85,85,176,85,210,166,215,18,57,210,250,93,173,147,58,7,223,188,4,219,98,169,243,115,194,170,171,127,129,175,51,88,75,86,18,205,46,161,212,200,201,88,157,230,65,190,96,209,163,200,130,179,188,209,156,47,228,126,151,252,174,85,40,191,253,198,0,148,146,33,208,173,129,51,180,15,106,222,110,234,146,181,245,70,58,44,252,7,66,139,127,164,104,16,176,64,127,160,74,242,190,185,205,65,94,22,185,98,89,138,105,210,112,99,104,20,36,62,249,180,129,248,179,19,236,117,213,58,144,7,150,11,45,0,146,106,34,79,254,137,198,56,184,144,18,91,194,241,155,26,156,61,41,230,203,18,34,204,49,236,173,172,78,72,90,243,228,227,209,78,182,32,230,181,73,94,238,197,191,7,27,146,96,94,102,252,238,205,226,65,34,176,25,251,254,199,47,149,227,162,77,234,246,215,188,189,222,75,146,14,116,72,22,9,212,8,168,255,234,137,156,148,217,222,114,120,176,65,155,42,179,63,72,134,251,135,122,142,239,18,95,98,124,95,118,188,95,167,196,71,248,52,36,188,10,52,20,240,222,141,198,55,85,158,177,103,89,134,187,71,61,249,66,197,60,163,53,146,118,98,64,86,135,167,207,193,73,120,228,125,252,138,47,90,91,145,197,231,73,123,61,14,114,37,227,224,207,73,131,52,34,21,74,83,249,75,20,7,134,17,37,160,187,163,58,139,38,34,8,253,219,156,137,76,18,157,65,46,43,94,240,38,173,243,181,168,10,50,243,232,164,4,39,107,61,130,68,187,41,138,78,92,183,184,88,118,109,5,7,58,122,82,10,99,247,180,22,96,207,137,176,213,225,83,96,121,73,243,190,221,94,169,73,103,34,85,69,245,235,94,91,142,202,251,91,89,205,104,108,249,3,60,21,11,53,79,61,99,40,197,91,141,102,82,31,81,52,106,203,161,213,209,214,65,71,76,203,31,38,106,203,253,219,124,121,77,216,111,226,83,40,36,35,110,225,167,51,19,48,236,42,41,255,101,81,48,157,178,129,61,165,195,157,139,125,185,208,242,183,223,134,40,154,247,174,9,24,39,148,98,75,222,187,242,30,168,138,227,70,162,78,29,85,11,133,98,57,67,44,207,80,197,114,132,212,60,74,45,110,180,152,160,214,60,30,39,184,31,41,63,172,165,46,192,34,117,137,97,237,208,62,220,135,162,137,45,75,228,186,242,41,90,174,97,93,217,105,19,28,19,10,85,213,190,19,126,14,86,142,214,167,130,117,99,8,248,56,89,139,174,105,8,94,198,130,121,115,82,38,87,5,207,134,32,243,178,101,199,213,6,254,238,0,186,172,218,164,216,9,169,24,69,111,126,145,180,73,8,56,160,100,170,226,211,156,23,153,168,218,81,157,174,110,33,168,100,85,89,108,29,219,103,31,56,249,117,20,132,255,165,145,77,103,137,77,50,251,176,113,126,59,56,23,85,221,242,236,69,46,223,64,120,83,45,205,68,73,55,99,31,110,117,63,32,172,253,104,88,28,216,4,240,54,162,33,245,90,17,165,179,29,173,94,228,113,238,50,174,29,193,147,7,28,50,32,224,129,163,167,14,140,10,240,248,246,44,41,147,37,120,37,184,242,28,4,72,202,148,63,151,118,26,121,157,236,8,61,123,199,161,58,237,88,93,181,176,35,207,16,228,241,227,199,236,73,179,89,137,76,50,211,11,39,117,13,62,83,192,132,1,120,48,80,143,41,152,62,174,57,204,33,216,7,0,85,135,168,136,227,186,248,127,58,147,175,217,211,167,44,146,15,83,177,76,4,20,131,12,168,23,70,221,147,24,141,133,116,67,130,157,241,246,186,234,53,87,229,15,50,193,216,84,105,107,128,12,34,154,250,129,71,67,11,2,91,15,240,95,218,188,144,35,15,193,238,217,139,191,65,57,113,125,90,87,43,172,39,161,54,128,230,245,175,108,244,97,4,127,9,33,122,50,154,37,89,36,137,83,133,172,251,124,43,8,105,118,174,225,25,58,201,77,203,28,254,200,66,151,199,128,201,64,59,139,255,78,125,47,11,25,24,26,38,225,0,69,2,100,241,3,230,90,210,207,162,209,247,163,9,27,141,198,241,101,245,170,186,133,195,82,249,100,167,175,10,25,26,160,6,18,155,46,94,142,58,52,5,83,168,204,29,190,132,122,156,137,195,140,229,176,36,234,149,21,113,13,88,106,34,155,142,12,49,37,208,173,51,94,0,92,201,78,252,119,190,37,165,142,200,135,86,114,93,91,249,54,227,144,154,72,102,98,121,18,52,25,74,67,152,186,219,154,148,104,79,15,64,12,190,121,141,230,118,20,202,150,248,87,17,23,133,0,66,57,4,205,178,103,111,189,39,4,173,15,228,136,188,70,219,152,137,19,18,176,240,78,30,79,167,184,97,159,196,95,45,236,77,34,12,109,173,230,67,251,110,162,15,93,146,138,117,141,253,235,53,175,121,148,138,64,145,198,46,134,168,124,220,21,104,99,74,62,70,176,231,91,7,235,188,106,114,25,148,81,119,48,247,20,51,89,4,137,82,89,166,78,58,59,140,199,241,105,85,159,128,213,68,210,192,0,22,228,146,157,134,60,35,196,146,143,62,226,17,13,19,128,244,69,234,215,14,18,112,12,165,98,97,151,110,170,19,69,167,83,7,250,175,135,15,195,27,13,30,188,124,6,19,217,45,91,201,176,107,153,0,50,24,137,69,1,225,70,62,15,50,242,2,204,4,139,64,77,223,120,227,203,203,234,35,47,173,91,72,47,246,104,89,47,114,133,146,39,161,252,121,108,222,188,27,9,215,26,189,159,176,192,43,225,17,163,247,110,67,116,79,207,170,83,64,116,142,109,46,77,94,148,111,79,188,66,82,158,152,180,4,208,177,89,109,162,33,12,97,61,141,154,66,236,237,143,141,117,70,173,155,249,91,40,167,222,64,57,21,64,183,189,199,147,211,77,153,250,76,232,17,229,108,38,98,178,240,187,203,74,55,93,103,194,143,145,59,97,63,15,35,174,79,241,51,27,205,51,72,26,182,5,17,174,21,108,103,217,253,196,34,217,229,175,70,86,21,250,110,124,93,202,83,18,166,108,31,66,183,181,61,69,181,101,247,16,46,41,206,41,178,172,237,135,240,176,248,167,40,182,39,24,194,35,157,131,78,42,232,25,115,101,197,3,134,91,33,132,147,117,252,28,187,134,0,41,28,154,216,171,155,96,101,191,25,176,185,248,178,222,154,78,85,80,193,90,71,100,22,65,203,218,28,201,176,41,140,99,242,210,31,117,139,29,12,171,126,171,108,101,32,28,190,19,251,189,23,192,94,118,121,214,164,80,105,2,148,78,203,79,209,123,77,194,241,88,211,96,135,46,152,80,34,210,241,17,52,231,140,67,164,252,253,152,84,4,226,203,107,94,14,113,233,194,237,102,179,27,60,53,171,80,206,75,145,67,225,83,116,172,112,180,210,234,180,157,216,106,101,194,84,145,41,203,0,244,7,90,87,200,101,149,204,58,101,72,180,71,81,59,233,20,225,146,46,218,32,186,194,20,119,17,217,69,13,6,85,77,2,198,221,242,103,203,37,244,23,242,118,84,196,59,241,111,68,214,196,128,68,136,144,138,251,78,160,54,81,196,84,193,40,249,68,170,170,68,164,85,15,236,104,47,100,213,168,180,147,71,169,102,168,0,176,25,202,107,4,0,53,171,96,102,46,183,125,114,227,119,63,188,247,136,0,58,33,38,136,8,153,148,42,164,71,62,129,51,156,169,169,167,20,18,69,113,106,30,73,98,224,252,109,232,233,26,193,255,195,129,255,79,157,153,108,76,79,238,218,26,46,239,213,56,88,223,169,119,166,199,162,239,82,227,84,241,56,113,238,176,23,246,153,150,178,22,92,220,104,238,121,57,48,48,98,181,186,99,118,166,218,244,143,121,85,68,19,172,16,120,149,86,33,198,254,8,83,90,74,41,126,86,20,17,39,195,96,254,144,17,48,201,97,206,213,47,142,126,167,206,198,167,121,221,180,209,216,155,189,66,34,87,227,6,103,46,222,63,146,23,252,141,156,11,246,17,105,85,201,41,197,238,45,188,214,160,220,213,244,163,152,175,246,216,17,170,62,178,141,59,233,32,132,157,193,134,215,92,135,71,30,71,251,176,30,110,189,41,134,115,237,50,37,27,120,162,6,53,101,111,183,220,107,42,211,175,127,157,154,6,248,27,137,111,30,200,14,116,76,128,75,248,121,193,94,238,69,124,38,53,143,214,52,187,180,237,116,102,40,18,232,201,12,161,105,28,216,13,40,2,114,226,68,136,238,244,95,7,36,127,130,15,166,100,127,169,91,36,168,162,231,171,53,148,46,248,197,147,92,148,236,244,134,164,223,161,13,235,152,102,119,158,227,128,232,54,131,86,209,78,16,144,205,0,125,43,142,148,214,211,250,22,18,234,234,200,107,114,228,39,35,212,126,236,85,167,15,105,175,92,201,144,141,53,122,26,189,71,158,213,51,55,53,138,238,58,167,47,48,18,143,213,2,181,172,151,111,240,2,139,84,58,90,141,196,188,172,58,40,156,127,29,230,104,145,0,218,144,9,35,30,184,241,18,250,196,249,17,229,68,36,88,218,61,201,50,36,112,125,100,243,145,58,115,82,209,210,183,86,122,71,27,10,198,182,142,74,90,179,160,0,72,127,168,35,177,248,129,12,91,125,60,162,103,142,247,206,228,182,207,191,212,182,166,165,98,6,228,60,93,84,232,47,80,196,90,107,155,69,242,2,182,115,89,117,122,187,94,67,37,253,41,73,127,206,22,110,145,216,181,167,251,61,182,233,236,96,163,175,212,98,247,242,84,75,110,90,20,218,155,88,204,113,95,70,208,248,84,20,161,46,246,180,95,32,248,100,208,130,135,167,188,206,46,122,143,31,20,172,163,54,181,136,120,157,25,129,170,19,17,38,60,9,160,188,59,229,161,5,255,138,177,24,142,227,113,74,8,17,35,95,240,166,21,227,122,249,240,71,70,100,249,125,98,135,35,220,131,103,146,45,250,37,163,15,217,185,139,216,145,92,212,45,132,20,43,14,194,26,99,235,4,23,55,139,117,242,225,196,17,143,212,172,132,72,199,160,29,65,229,192,52,112,241,111,189,34,80,103,116,125,196,249,132,43,112,27,161,111,253,221,173,27,99,32,74,167,158,1,169,70,8,155,46,252,17,184,105,224,205,167,73,39,2,163,170,194,5,163,191,74,27,204,222,108,109,99,185,13,115,176,179,185,150,56,185,3,91,105,158,111,69,201,214,205,186,208,44,16,42,38,230,123,122,12,129,60,44,209,134,114,233,48,231,52,12,27,182,47,189,208,101,56,110,65,255,38,144,250,144,187,227,53,75,69,42,130,207,142,238,82,142,242,146,239,227,224,162,55,150,55,203,209,95,70,199,73,145,110,10,232,174,197,119,173,130,164,202,71,224,131,232,99,223,125,182,228,239,191,131,155,5,8,42,89,204,12,225,67,246,153,223,171,219,111,215,52,135,213,225,107,98,167,18,116,246,35,137,185,235,46,148,84,56,175,120,52,122,147,139,67,41,120,86,59,210,140,135,211,233,80,190,230,132,246,59,27,43,29,28,142,39,239,253,100,159,163,83,241,161,174,110,133,159,208,207,37,98,39,102,248,211,18,149,195,170,91,184,244,107,201,68,36,194,75,136,159,54,121,38,218,233,134,239,186,215,37,170,28,15,80,117,110,41,58,110,208,143,97,175,38,186,145,97,72,8,114,41,225,85,98,253,72,250,102,192,26,212,0,176,115,151,224,89,208,0,154,115,229,17,182,240,16,154,59,149,152,184,225,124,31,60,165,121,55,224,59,133,12,160,239,243,97,140,253,126,164,251,101,208,77,94,183,240,45,0,243,10,26,113,17,170,158,233,151,36,116,160,185,209,183,166,166,155,16,20,204,93,106,159,249,34,231,6,25,191,141,73,50,158,153,253,240,147,16,114,203,122,239,112,236,79,21,89,104,210,24,204,183,161,15,74,240,37,124,7,8,6,142,207,208,210,64,92,213,95,235,158,219,55,206,204,85,111,78,7,186,253,147,206,137,235,231,74,23,61,181,162,162,73,222,234,218,205,27,52,16,62,67,243,134,158,26,21,95,146,232,175,95,96,80,55,199,208,59,129,210,141,165,14,178,34,135,195,119,215,167,224,70,153,9,127,126,115,102,85,230,183,165,164,22,68,14,232,23,26,228,96,212,182,59,239,160,145,8,150,233,182,46,223,81,126,18,204,192,189,55,222,109,7,208,96,98,180,89,241,58,204,141,173,79,5,101,188,58,187,248,152,175,169,80,114,225,109,117,75,99,144,139,71,129,53,160,73,145,20,244,144,254,138,47,147,143,226,194,177,139,171,54,9,85,147,157,241,12,197,15,23,26,110,176,178,253,233,195,191,153,58,240,89,147,24,239,122,173,82,221,36,120,35,189,80,129,45,58,27,162,42,195,179,53,81,217,94,56,185,152,104,2,115,128,99,81,46,39,126,200,118,6,49,97,119,8,7,112,92,117,23,97,237,63,4,248,170,127,42,58,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d122f4a8-0c42-4b2c-bcb7-dad15f1c93e0"));
		}

		#endregion

	}

	#endregion

}

