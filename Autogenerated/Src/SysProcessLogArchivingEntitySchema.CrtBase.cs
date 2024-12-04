﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessLogArchivingEntitySchema

	/// <exclude/>
	public class SysProcessLogArchivingEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessLogArchivingEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessLogArchivingEntitySchema(SysProcessLogArchivingEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95b7debc-5363-4d36-85a8-7e53ba735878");
			Name = "SysProcessLogArchivingEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,88,91,111,219,54,20,126,118,129,254,7,194,123,145,129,68,73,90,52,189,164,46,16,219,73,107,32,109,179,58,93,31,134,97,96,36,38,38,38,139,14,73,185,245,182,252,247,29,146,71,18,117,117,155,97,15,123,177,37,242,92,191,115,163,152,210,21,83,107,26,49,114,197,164,164,74,220,232,112,42,210,27,126,155,73,170,185,72,31,63,250,235,241,163,199,143,6,153,226,233,45,89,108,149,102,171,147,218,59,112,36,9,139,12,185,10,223,178,148,73,30,149,52,190,96,201,186,214,195,179,84,115,205,153,234,36,152,77,26,122,47,120,122,215,73,127,41,69,196,148,170,186,3,212,64,255,235,199,107,37,18,166,89,48,124,30,30,61,9,159,144,191,201,52,161,74,17,174,136,192,61,66,211,152,124,229,73,66,174,25,145,108,37,54,44,38,60,37,217,58,18,43,163,79,178,132,81,197,212,112,244,27,200,252,73,178,91,80,224,228,188,50,22,162,1,23,226,246,84,70,75,190,1,30,235,228,214,218,176,206,174,19,30,145,200,170,237,163,38,175,200,188,33,96,224,162,82,106,5,232,53,77,53,104,190,148,124,67,53,115,251,107,247,66,34,179,79,148,150,198,240,119,92,105,33,183,151,16,39,17,131,234,5,211,26,214,167,34,102,100,76,134,45,150,56,210,225,73,83,36,79,53,153,177,27,154,37,186,34,118,70,183,10,132,61,61,60,233,52,163,69,207,39,22,9,25,171,169,200,64,108,187,41,62,201,14,131,186,196,62,59,52,86,89,248,88,26,59,4,171,112,158,115,150,196,93,88,206,47,192,209,215,206,137,55,228,247,72,36,217,42,253,96,10,105,135,84,27,36,153,69,128,146,145,109,19,0,69,187,100,232,75,131,224,179,98,18,36,164,174,208,72,86,121,221,51,82,6,3,68,86,69,75,182,162,198,164,189,28,236,165,11,206,162,216,25,17,72,33,96,169,137,29,215,4,91,132,7,37,27,16,148,210,221,38,198,189,66,211,80,103,73,239,119,224,147,1,211,170,153,238,228,61,91,93,51,169,28,245,193,193,1,121,173,178,213,138,202,237,155,124,193,120,97,18,0,173,14,11,194,3,159,18,97,174,185,92,123,117,176,220,50,237,188,83,248,112,223,163,221,185,73,82,240,179,95,51,6,195,131,234,1,218,16,111,140,195,247,107,109,198,233,1,202,167,54,219,173,82,213,175,181,90,38,211,178,74,74,181,248,52,224,55,36,240,235,136,140,199,36,205,146,36,207,209,193,96,67,101,238,239,152,188,101,218,37,134,115,37,24,57,243,7,131,170,12,100,48,211,9,22,85,184,128,126,29,233,0,104,200,248,13,36,75,130,59,191,208,36,99,182,36,194,43,97,140,46,4,2,16,230,79,50,157,201,180,94,233,197,62,192,150,219,89,51,96,99,36,123,164,125,192,206,83,72,67,77,104,158,250,36,166,154,130,149,64,149,198,59,144,158,77,166,142,14,165,56,79,243,181,6,220,232,15,192,88,20,154,207,247,115,198,228,54,199,96,167,221,51,230,134,229,191,179,219,73,249,17,139,29,199,143,217,58,79,99,30,65,11,87,68,67,131,202,19,10,158,36,187,97,146,165,17,76,120,76,154,94,195,55,92,234,140,194,193,64,64,46,129,81,115,245,169,16,144,231,36,154,142,150,67,219,255,174,22,248,158,233,165,232,156,60,46,62,70,163,123,58,151,98,133,8,160,58,91,39,142,10,74,136,125,69,150,218,240,24,133,95,184,94,190,131,81,169,2,251,27,126,16,23,34,250,3,113,188,129,227,19,141,150,36,192,198,225,146,218,156,125,188,42,46,106,211,169,195,90,10,202,238,178,135,124,126,112,114,98,99,184,71,58,10,79,149,255,122,226,67,231,88,124,240,114,56,172,235,101,82,176,24,231,124,19,146,59,75,217,135,136,243,165,11,23,220,109,241,113,56,143,135,249,118,221,43,231,198,105,28,187,92,45,82,215,218,119,206,19,13,51,45,176,166,85,61,182,75,109,14,207,224,231,138,67,227,46,124,182,135,218,133,166,82,155,189,194,103,115,8,178,21,201,28,133,59,147,185,214,217,121,188,11,170,86,228,202,194,207,58,250,32,190,134,198,15,56,212,5,251,77,193,163,54,99,253,150,98,139,196,190,95,9,23,29,92,119,193,181,75,126,188,184,207,235,194,230,139,235,8,222,60,213,2,226,86,63,232,224,46,156,114,3,63,127,189,160,161,84,223,24,7,133,111,7,136,135,15,20,154,240,63,217,37,149,32,194,134,175,141,112,146,241,36,46,105,78,149,157,48,224,71,209,5,114,140,125,182,31,108,15,66,3,15,139,115,204,241,181,129,122,95,135,71,192,155,161,112,137,210,232,49,69,62,183,103,114,19,190,178,109,87,131,223,160,188,175,187,129,83,165,179,225,123,185,18,151,235,152,42,142,178,209,243,218,203,211,99,15,191,44,161,137,55,203,27,34,31,116,118,153,170,171,158,180,118,199,54,130,199,4,32,156,192,151,99,59,140,206,19,219,3,138,211,123,121,228,174,52,250,188,238,209,111,203,89,228,93,208,217,36,208,100,20,161,51,53,143,219,37,152,165,183,25,143,131,225,139,163,103,211,151,207,94,28,239,79,142,207,158,236,207,206,143,142,246,95,62,63,154,236,31,30,30,205,142,15,207,94,62,125,49,61,30,230,130,239,60,48,253,79,145,225,2,181,25,72,213,217,29,140,80,24,49,110,41,47,199,211,52,174,242,192,153,96,109,48,53,166,91,190,11,104,94,31,101,193,237,156,26,245,163,221,215,128,61,188,255,111,224,46,30,0,238,226,1,224,122,236,163,240,236,27,116,88,21,224,145,123,215,68,45,167,166,55,41,139,97,57,180,95,188,17,246,108,24,73,62,133,243,177,73,82,84,37,122,217,168,87,66,21,218,212,149,22,120,126,203,211,163,61,49,176,47,86,50,163,183,114,177,102,27,45,198,133,236,74,172,131,246,241,107,239,37,242,204,233,52,214,204,244,254,241,93,61,114,214,174,195,42,215,96,97,121,235,3,95,213,22,109,16,109,199,84,45,140,123,125,183,69,123,157,87,63,15,246,5,177,248,111,92,217,113,157,84,184,211,186,187,195,165,51,239,139,180,249,133,138,254,248,139,239,105,74,111,225,214,2,190,120,236,255,184,118,17,17,158,174,215,222,155,187,242,172,145,180,200,171,140,35,148,109,16,129,9,12,23,132,17,155,108,77,102,54,230,96,251,193,195,173,86,23,239,255,1,156,251,172,167,52,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95b7debc-5363-4d36-85a8-7e53ba735878"));
		}

		#endregion

	}

	#endregion

}

