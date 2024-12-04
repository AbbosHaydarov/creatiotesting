﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleStageHistoryRepositorySchema

	/// <exclude/>
	public class SysModuleStageHistoryRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleStageHistoryRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleStageHistoryRepositorySchema(SysModuleStageHistoryRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("606c473b-83a8-403c-b3e8-30b26e3b8597");
			Name = "SysModuleStageHistoryRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,90,91,111,219,54,20,126,118,129,254,7,214,29,48,25,8,236,247,198,118,145,166,113,231,173,9,138,37,221,75,16,12,138,68,37,194,100,201,35,41,119,110,145,255,190,195,155,46,20,73,203,78,122,203,83,68,145,135,223,57,60,231,227,71,90,121,184,194,116,29,70,24,93,97,66,66,90,36,108,124,90,228,73,122,87,146,144,165,69,254,252,217,151,231,207,6,37,77,243,59,116,185,165,12,175,142,141,103,232,159,101,56,226,157,41,31,27,149,132,224,156,121,187,189,195,57,38,105,84,247,57,45,86,171,34,175,159,155,104,8,118,181,143,207,114,150,178,20,83,103,135,69,24,177,130,200,30,208,231,37,193,119,0,0,45,115,134,73,2,110,191,66,75,128,119,94,196,101,134,47,89,120,135,127,75,41,12,216,254,137,215,5,77,249,127,98,220,100,50,65,83,90,174,86,33,217,206,213,243,7,82,108,210,24,83,180,194,236,190,136,41,74,10,130,40,102,140,195,8,243,24,17,204,96,230,13,127,164,220,52,186,151,182,117,39,58,214,150,39,13,211,235,242,54,75,35,148,106,132,61,0,14,248,18,85,190,157,75,56,175,208,7,97,73,224,239,56,32,26,22,105,14,176,37,54,133,137,67,234,98,146,45,235,144,132,43,148,67,198,204,134,176,192,41,219,94,70,247,120,21,126,92,198,195,185,88,9,112,77,180,32,136,11,60,39,41,38,227,233,68,140,171,205,64,88,74,146,211,249,148,98,140,34,130,147,217,176,233,216,165,4,50,156,204,167,19,221,149,143,181,244,17,14,4,239,202,52,70,6,158,209,177,199,237,119,152,29,232,181,244,238,2,254,55,29,230,239,191,170,171,0,58,160,144,79,60,153,42,20,94,55,47,195,13,62,208,207,20,234,117,216,7,117,237,239,166,128,85,224,83,6,54,244,220,224,238,53,9,179,172,141,151,58,0,47,207,242,114,133,73,120,155,225,169,101,186,57,55,119,146,101,129,158,242,37,206,99,89,29,240,244,32,153,160,217,100,99,6,228,162,134,211,16,226,255,21,89,1,177,2,193,152,132,20,43,20,241,185,30,67,19,10,172,100,8,119,228,83,42,167,2,123,192,167,97,150,126,198,177,35,246,183,69,145,161,37,21,134,151,117,111,244,5,221,97,118,140,32,186,131,193,46,198,89,227,8,200,33,178,7,0,48,212,126,63,1,23,149,121,250,111,137,191,37,37,89,218,247,103,169,147,56,118,196,7,242,99,175,248,168,113,195,249,21,44,176,99,39,122,170,144,72,26,192,172,217,247,170,16,201,98,37,6,5,160,31,55,112,22,161,70,97,184,2,112,32,254,125,152,101,7,147,156,102,33,133,93,216,90,150,39,235,53,84,175,16,88,186,66,117,145,167,249,61,72,35,22,23,17,154,112,72,215,111,113,18,150,25,123,3,137,197,19,137,109,215,184,72,2,79,185,143,142,16,223,28,208,12,13,27,243,12,71,55,53,109,68,28,91,63,104,187,120,176,45,62,64,255,65,134,229,140,203,15,146,110,66,38,153,114,176,150,15,40,226,239,145,218,200,132,133,63,240,150,35,181,45,142,141,189,7,205,217,128,108,215,152,112,1,200,167,43,24,200,75,28,123,9,136,151,64,73,49,225,64,114,169,70,29,89,180,214,246,208,71,232,127,90,117,55,31,107,222,51,177,58,145,238,210,101,123,80,178,64,42,215,212,73,204,188,207,0,64,170,255,6,155,176,218,145,40,132,30,102,107,6,127,1,229,37,235,85,228,56,252,201,250,168,135,188,152,161,188,204,50,249,86,240,253,195,174,133,18,105,65,74,174,197,189,203,83,227,134,138,71,57,254,4,222,243,124,130,253,173,72,16,131,104,52,235,185,79,250,66,133,203,108,239,203,150,101,107,121,37,105,154,25,211,100,75,21,253,94,96,2,35,119,218,115,141,212,2,181,91,199,167,247,56,250,231,132,220,1,47,229,236,2,2,31,112,160,64,1,198,104,181,92,198,20,51,99,18,209,169,218,164,93,233,90,159,33,108,69,188,124,155,10,91,16,195,41,223,215,142,144,139,42,45,237,52,208,126,246,206,67,244,250,181,120,27,38,56,219,122,115,181,218,207,254,10,179,18,211,241,162,32,103,240,62,216,240,71,52,155,215,37,0,207,227,78,168,218,13,42,193,149,105,163,10,218,113,60,32,50,62,103,20,76,53,165,63,48,188,72,122,205,170,98,244,240,20,107,233,196,26,244,179,55,106,71,122,108,22,202,181,222,26,110,142,145,131,96,250,29,121,205,221,180,42,215,199,74,183,94,57,92,167,188,145,158,87,100,11,93,69,146,6,134,229,35,84,148,12,113,187,4,83,216,247,219,233,39,219,154,11,233,117,243,80,57,166,188,211,199,70,39,5,233,254,10,36,71,45,55,173,89,207,130,21,189,175,245,60,103,237,80,220,128,25,245,202,198,109,158,172,129,129,194,114,239,64,245,214,125,7,173,187,193,29,138,157,220,84,44,90,15,148,150,203,252,28,175,186,199,212,39,149,149,114,134,190,138,178,133,104,63,57,233,16,120,94,121,215,186,65,240,30,20,106,137,7,99,24,56,241,62,252,188,157,214,87,152,189,168,108,206,235,75,44,171,244,79,233,65,205,175,84,136,67,52,19,121,192,185,250,160,57,170,155,140,14,100,165,250,90,24,44,199,114,5,227,187,105,99,191,220,248,33,212,49,168,3,119,28,155,68,226,242,226,219,137,220,86,69,125,87,133,219,66,242,19,202,219,111,173,23,90,249,37,247,129,221,98,192,54,249,207,39,14,210,4,5,47,220,21,166,205,14,60,100,54,67,80,95,114,83,151,139,44,140,218,98,10,25,193,66,40,43,16,3,129,67,93,140,170,25,29,139,242,113,29,3,131,187,134,31,233,120,0,101,119,199,59,37,141,10,198,3,194,25,197,59,0,192,21,224,206,217,181,189,86,222,63,169,212,81,201,101,195,216,214,49,125,84,76,79,17,99,252,252,182,151,88,169,199,142,122,10,148,122,132,83,157,152,63,183,29,124,231,101,181,46,151,85,171,43,107,151,159,237,50,204,56,23,187,37,31,250,155,58,223,249,110,133,57,248,230,190,233,158,97,167,79,62,116,158,87,157,139,53,143,39,176,174,190,183,112,142,15,252,163,249,9,195,249,62,208,28,43,73,214,99,105,220,149,64,21,13,14,120,99,171,204,125,152,244,140,146,135,53,75,248,23,179,234,78,165,222,242,187,44,46,105,246,20,94,125,4,228,227,245,87,205,6,223,85,124,213,48,126,32,229,213,79,119,105,158,108,211,132,80,36,221,44,244,213,167,56,5,104,7,229,38,89,127,104,2,65,173,254,157,161,5,102,209,189,221,84,213,77,159,216,225,87,91,12,150,17,220,28,18,165,229,196,239,146,85,199,170,106,26,55,1,48,7,207,38,155,38,108,7,79,215,142,222,220,23,105,150,241,171,17,137,95,137,64,221,73,158,96,29,58,205,167,2,116,84,59,81,233,23,136,198,77,71,43,140,220,69,211,164,225,223,209,174,109,78,223,254,84,6,198,239,139,48,54,174,75,234,183,214,139,75,79,82,236,32,203,150,103,21,117,64,37,80,233,222,245,13,108,100,220,205,6,177,232,58,9,204,10,62,50,246,192,17,122,144,94,136,19,103,218,60,31,157,229,92,116,113,25,107,92,100,1,222,37,93,224,16,220,214,157,130,161,82,124,13,248,191,23,16,22,32,174,252,78,31,187,134,13,109,109,155,170,202,82,21,82,161,185,228,55,81,91,62,235,212,19,197,121,160,239,121,142,204,48,53,211,237,64,211,205,95,38,29,246,159,252,210,247,145,151,124,30,133,209,252,85,216,249,83,65,207,3,153,235,27,154,71,30,191,154,7,8,253,105,68,39,17,155,157,206,195,28,64,136,171,140,193,64,164,168,218,37,223,108,121,9,7,253,74,188,193,159,112,153,43,222,142,79,129,91,25,86,100,103,101,70,57,98,44,136,138,19,227,219,55,213,65,72,126,54,97,144,167,141,56,149,13,17,207,36,132,211,150,106,247,44,99,31,146,237,179,144,251,125,171,214,205,54,127,178,185,238,29,44,95,151,116,146,113,183,11,162,21,255,23,225,181,220,65,133,10,90,194,151,23,23,5,91,20,101,30,159,233,119,195,249,50,129,253,55,255,149,161,4,32,85,224,111,183,74,242,192,208,238,135,115,147,57,232,155,202,254,174,168,217,63,123,107,70,76,187,219,43,153,69,26,131,47,42,133,27,38,199,96,162,206,216,71,173,67,5,169,65,206,149,65,249,219,121,197,203,236,158,20,159,212,94,195,191,128,29,91,35,29,252,50,84,133,203,195,9,168,190,212,200,31,244,30,208,98,99,203,114,27,60,218,253,120,5,90,254,7,191,73,185,188,15,44,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("606c473b-83a8-403c-b3e8-30b26e3b8597"));
		}

		#endregion

	}

	#endregion

}

