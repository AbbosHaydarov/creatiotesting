﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingsValidatorSchema

	/// <exclude/>
	public class SysSettingsValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingsValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingsValidatorSchema(SysSettingsValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c5f12de6-c011-455f-b612-d9d478a7f08c");
			Name = "SysSettingsValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,87,223,111,219,54,16,126,118,129,254,15,156,183,7,25,48,228,97,143,141,227,34,112,211,192,91,151,4,176,211,62,22,140,124,114,184,81,164,74,82,217,180,212,255,251,142,164,104,75,178,101,123,155,11,44,72,132,240,116,252,120,63,191,163,4,205,64,231,52,1,50,85,102,202,101,177,156,9,3,43,69,13,147,34,126,48,140,51,195,64,191,126,245,242,250,85,175,208,76,172,200,84,102,25,190,251,32,87,43,92,94,108,229,135,0,226,107,165,164,210,91,237,121,169,13,100,237,117,60,149,156,67,98,247,234,248,6,4,40,150,236,232,124,96,226,203,86,184,0,165,168,150,169,193,189,10,186,228,248,16,41,91,21,222,46,212,66,189,239,21,172,112,65,166,156,106,253,198,162,207,193,24,220,171,63,82,206,150,212,72,229,244,70,163,17,25,235,34,203,168,42,39,213,122,150,229,28,50,16,70,19,243,4,228,57,108,32,41,254,89,9,203,114,169,12,21,134,232,82,19,93,1,199,1,110,84,195,203,139,71,206,18,146,88,51,58,172,232,97,248,241,185,53,25,227,99,193,209,236,123,197,158,169,1,255,62,247,11,146,216,247,68,27,101,35,49,91,162,157,204,148,115,80,207,160,110,148,44,242,91,76,59,185,36,253,230,171,254,69,39,198,221,85,97,158,26,91,157,228,192,142,185,76,24,229,247,156,26,12,73,102,15,96,9,52,16,246,106,88,68,231,41,136,165,119,182,233,249,123,6,124,217,229,182,2,186,148,130,151,100,134,213,73,62,115,44,81,80,23,29,58,239,152,171,51,76,194,216,155,60,68,80,88,178,4,181,198,242,241,55,44,195,201,132,124,102,141,16,133,220,44,100,149,29,244,196,162,247,4,252,113,34,162,237,36,252,121,105,71,255,65,241,254,208,86,82,129,152,147,42,140,241,76,223,22,156,223,169,79,79,204,192,220,118,106,228,84,222,198,11,57,119,42,209,96,64,214,195,14,208,41,103,184,156,45,191,21,242,28,18,5,230,223,163,59,240,245,127,76,145,180,165,120,214,204,184,226,254,233,199,111,146,160,189,216,231,204,211,129,3,254,23,233,210,251,250,254,172,233,243,204,114,149,36,178,176,62,187,3,206,148,189,189,164,117,6,236,245,17,222,115,140,175,138,4,199,129,101,63,55,50,188,70,123,60,249,249,36,112,236,98,32,255,2,77,40,177,49,100,110,98,224,160,151,169,27,80,99,13,200,216,10,210,203,254,190,153,211,31,77,252,68,178,35,107,119,102,121,73,78,21,205,136,64,62,191,236,123,178,237,79,22,136,237,255,143,199,35,167,224,244,171,33,183,239,168,200,177,181,223,51,168,178,88,113,55,142,137,13,137,99,140,14,135,232,87,48,79,178,115,54,204,174,69,145,129,162,143,28,170,34,154,144,27,48,215,89,142,45,178,181,42,122,208,216,44,82,8,127,11,33,69,99,233,115,117,90,57,134,153,31,92,194,122,1,154,60,17,44,2,21,94,98,86,118,244,122,44,37,209,119,53,147,226,133,42,209,82,140,87,1,81,203,158,176,59,254,5,202,33,145,133,33,14,125,179,217,109,26,144,175,95,61,116,47,168,59,121,60,19,207,242,119,136,218,234,27,75,122,165,157,182,216,224,166,80,162,126,148,75,135,75,72,120,174,187,163,61,115,119,191,9,214,164,1,37,40,15,13,126,254,80,111,201,99,24,174,33,171,112,227,8,78,217,248,64,43,233,88,102,251,74,161,35,214,181,99,6,62,16,54,99,109,204,248,74,148,209,54,148,85,65,199,159,168,18,81,21,221,31,42,54,113,132,125,175,228,159,101,197,39,49,185,149,134,164,12,239,194,54,250,95,10,134,62,219,172,226,245,119,99,197,27,242,82,17,205,207,146,137,8,9,8,127,219,86,12,214,253,202,198,102,46,45,35,108,213,92,130,118,61,120,207,148,54,119,234,29,164,180,224,38,26,12,107,209,188,216,73,253,241,182,60,70,90,33,170,254,78,157,163,207,144,50,225,61,223,184,141,101,98,243,170,115,72,88,202,240,101,51,75,27,158,59,149,183,154,219,61,127,89,153,189,205,86,194,6,145,57,0,31,69,61,169,145,232,158,138,183,28,138,108,91,125,28,88,227,240,155,4,249,27,241,2,64,141,26,247,181,204,105,173,82,47,109,73,177,150,252,199,22,86,245,78,203,181,75,186,235,238,52,108,221,248,171,124,59,114,113,53,251,15,142,56,113,222,87,51,246,240,119,67,205,142,112,49,15,150,248,237,199,205,97,203,195,23,250,97,215,7,83,237,108,5,26,59,2,189,175,133,219,126,98,34,45,69,245,248,12,130,48,28,90,137,61,82,99,34,184,210,176,243,192,99,111,136,163,209,182,78,233,104,235,121,105,83,184,254,27,213,146,146,165,234,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c5f12de6-c011-455f-b612-d9d478a7f08c"));
		}

		#endregion

	}

	#endregion

}

