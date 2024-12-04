﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailRecipientMacroRepositorySchema

	/// <exclude/>
	public class BulkEmailRecipientMacroRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientMacroRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailRecipientMacroRepositorySchema(BulkEmailRecipientMacroRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f21e75ff-18af-4453-8d4a-578418fcde6a");
			Name = "BulkEmailRecipientMacroRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,86,77,111,219,56,16,61,171,64,255,3,225,94,100,192,144,179,216,219,214,22,176,113,178,133,187,155,214,27,39,123,45,104,105,28,115,43,145,46,63,156,184,69,254,123,135,164,36,83,150,21,167,151,196,252,152,153,55,239,205,12,197,105,9,106,75,51,32,119,32,37,85,98,173,147,153,224,107,246,96,36,213,76,240,183,111,126,188,125,19,25,197,248,3,89,238,149,134,242,253,209,26,239,23,5,100,246,178,74,62,0,7,201,178,206,157,127,24,255,118,216,156,137,178,20,60,92,75,104,175,146,171,203,195,198,39,120,212,232,220,98,251,168,156,29,30,189,147,240,128,33,201,172,160,74,253,65,46,77,241,245,186,164,172,184,133,140,109,25,112,125,67,51,41,110,97,43,20,211,66,238,157,209,120,60,38,19,101,202,146,202,125,90,173,23,82,236,88,14,138,148,160,55,34,87,68,11,34,129,230,132,242,156,40,186,3,146,83,77,201,90,200,190,32,4,127,48,189,79,234,0,227,32,194,214,172,10,150,145,204,162,124,13,200,8,233,198,191,135,244,48,113,77,185,198,20,23,146,237,168,6,127,190,245,11,146,217,115,194,184,38,95,74,250,180,160,18,5,213,32,213,76,24,174,23,32,255,53,32,247,151,84,103,27,50,37,191,93,92,92,120,246,162,119,192,115,31,162,29,239,47,6,69,222,23,204,210,34,120,177,39,247,10,36,34,227,94,118,242,197,180,214,103,66,184,148,164,201,48,97,27,200,17,228,111,28,203,227,54,230,156,105,70,11,246,29,37,162,132,195,35,102,107,41,193,154,21,107,162,55,128,38,128,68,72,88,79,7,103,25,30,140,83,47,134,85,171,43,151,223,217,90,26,9,71,42,167,131,118,106,131,244,14,3,218,61,203,124,181,153,76,198,206,194,57,168,4,63,11,36,62,226,176,29,103,72,108,219,69,209,17,179,168,97,135,234,40,122,126,153,239,27,95,215,61,154,218,210,153,209,34,51,5,174,102,27,195,191,170,216,238,149,22,174,47,163,145,187,148,137,194,148,220,239,212,240,118,84,146,186,236,20,86,155,179,71,144,55,84,111,146,63,87,42,62,91,148,227,182,95,151,79,36,65,27,201,137,197,49,116,174,102,192,10,156,4,113,0,10,45,227,92,32,217,48,236,32,24,134,180,212,137,238,4,203,177,152,144,62,47,133,114,0,64,197,31,12,30,172,106,189,230,249,200,97,136,230,215,220,148,32,41,70,152,132,191,255,134,253,127,180,48,176,160,76,78,172,237,136,96,57,35,186,52,77,43,214,42,207,33,75,153,145,18,139,224,202,34,153,18,251,239,142,149,144,220,235,236,147,120,244,89,227,132,1,138,148,196,246,254,202,177,195,248,105,143,206,37,115,185,56,46,209,165,109,12,159,93,124,84,52,195,100,206,181,136,251,122,99,80,145,222,142,239,195,90,0,14,73,19,56,10,162,38,142,7,21,215,14,90,103,75,208,241,160,137,116,63,207,7,35,236,124,43,117,210,20,68,165,103,130,148,14,251,157,120,181,94,48,119,48,94,112,208,36,126,26,68,32,125,227,4,107,231,216,213,245,19,100,70,67,157,237,243,47,117,222,185,33,183,196,119,6,95,30,156,45,106,139,156,173,25,228,56,109,43,242,106,49,236,19,212,190,98,161,19,176,216,95,59,206,130,100,253,44,59,184,32,248,10,226,67,134,142,101,107,162,117,124,52,192,188,50,135,247,223,123,236,224,206,154,11,167,38,229,142,73,109,104,225,251,211,242,208,109,72,114,197,156,57,102,229,59,206,41,16,54,101,35,177,131,52,231,107,129,205,216,139,51,108,204,109,51,157,112,122,248,6,186,21,143,216,80,191,191,63,52,175,27,139,126,236,76,59,211,178,55,76,82,77,207,211,33,170,58,58,52,91,213,227,24,161,215,163,175,74,172,106,187,142,159,200,52,117,125,223,63,146,226,39,219,92,35,98,191,155,112,34,236,48,52,90,75,255,158,126,94,253,239,220,212,13,52,76,150,219,130,233,207,28,123,67,171,56,200,186,194,122,106,122,182,116,106,15,171,112,10,159,172,122,140,163,160,174,18,143,216,126,125,5,239,249,25,141,241,53,127,109,225,239,108,142,131,116,41,140,204,142,98,118,171,221,63,64,42,253,37,36,147,113,109,22,84,247,25,51,79,65,247,32,174,216,112,168,235,114,173,158,197,80,203,43,64,69,66,53,91,79,213,169,174,192,233,110,93,190,240,225,224,119,195,205,231,159,19,173,190,135,39,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f21e75ff-18af-4453-8d4a-578418fcde6a"));
		}

		#endregion

	}

	#endregion

}

