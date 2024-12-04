﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysUserProfileEntityEventListenerSchema

	/// <exclude/>
	public class SysUserProfileEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysUserProfileEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysUserProfileEntityEventListenerSchema(SysUserProfileEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fcf5e758-8cd5-4642-babf-989888cb0f79");
			Name = "SysUserProfileEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("58864000-91f9-447b-9f45-be75e7e0fa19");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,90,75,111,220,54,16,62,111,129,254,7,86,61,84,6,22,242,221,137,13,196,175,116,219,216,49,178,78,3,180,232,129,150,184,187,172,37,113,75,74,118,182,133,255,123,135,47,137,148,40,105,157,7,218,230,224,172,68,114,230,155,225,188,56,98,137,11,34,182,56,37,232,150,112,142,5,91,85,201,25,43,87,116,93,115,92,81,86,126,251,205,223,223,126,51,171,5,45,215,104,185,19,21,41,94,116,158,97,126,158,147,84,78,22,201,107,82,18,78,211,209,57,111,239,254,128,159,87,44,35,121,111,222,146,164,53,167,213,174,29,56,227,68,2,73,46,225,191,154,147,91,182,94,231,240,190,157,112,77,30,43,32,43,145,255,36,88,217,14,184,18,21,197,208,8,39,67,239,125,69,12,206,58,63,29,28,186,40,43,90,81,34,38,39,36,23,15,164,172,130,243,222,47,146,15,228,14,160,84,156,229,34,121,71,4,171,121,74,126,196,101,150,19,238,44,145,4,65,139,75,82,85,240,40,208,49,234,11,145,56,19,96,37,172,253,158,147,53,12,160,179,28,11,113,36,183,225,189,32,252,134,179,21,205,137,130,183,83,216,222,80,216,31,216,91,181,232,240,240,16,189,20,117,81,96,190,59,49,207,118,2,90,49,142,126,240,233,252,128,136,162,132,136,18,51,177,36,14,29,26,191,5,152,197,203,116,67,10,124,13,70,10,226,68,62,209,232,224,119,88,182,173,239,114,154,162,84,194,159,70,143,142,208,41,22,97,185,102,96,232,240,183,213,8,24,85,133,1,238,17,186,225,244,1,87,68,143,111,245,3,74,229,56,18,21,55,230,235,112,30,133,173,245,62,251,158,148,153,230,228,179,189,34,213,134,101,67,76,239,24,203,209,45,223,189,38,149,52,9,156,86,241,235,154,102,136,147,148,241,108,145,205,145,100,5,67,165,246,54,84,123,143,115,196,234,10,105,241,165,0,146,192,1,146,30,62,155,153,71,64,12,196,245,148,211,157,148,33,142,12,171,104,222,33,119,240,194,93,153,0,235,87,89,65,203,119,116,189,169,164,1,174,112,46,148,123,205,102,156,128,247,150,150,39,120,115,149,110,46,57,43,206,79,99,139,93,83,123,26,20,24,244,168,200,191,47,233,103,72,45,28,42,86,116,247,93,72,126,151,243,144,18,232,42,246,223,39,103,53,231,96,97,18,90,210,190,190,221,109,193,42,142,21,98,249,59,89,46,111,44,14,15,200,168,58,159,92,165,122,171,246,214,172,209,71,87,88,99,208,218,97,229,155,9,229,90,236,154,136,182,252,43,92,226,53,120,155,38,226,191,59,238,172,215,49,208,159,164,101,124,192,28,9,245,26,22,5,72,65,178,169,22,202,71,83,98,192,183,168,205,174,4,54,29,136,105,170,137,74,45,38,24,116,54,207,44,15,40,56,164,74,163,51,192,115,75,11,242,43,43,201,25,100,183,211,221,34,123,150,157,250,170,68,149,161,101,30,3,118,105,185,13,219,36,138,125,42,97,243,104,236,207,200,219,89,35,229,2,75,205,32,137,215,69,249,11,206,107,242,82,139,124,34,99,67,6,161,56,100,149,106,70,114,81,108,117,58,239,42,237,129,129,102,222,111,51,248,189,84,83,29,242,139,213,217,6,151,107,146,197,70,248,186,13,160,115,107,185,21,230,107,171,145,185,221,131,173,158,164,105,41,243,53,158,165,135,245,154,118,212,74,46,109,141,229,153,98,14,154,118,73,143,138,223,163,215,154,110,73,30,45,57,7,253,40,181,30,120,103,31,191,179,250,252,179,134,48,16,91,176,243,134,207,28,89,53,22,91,204,41,148,66,201,162,4,32,20,114,216,89,157,203,226,169,221,232,179,13,73,239,77,26,204,168,17,64,7,154,62,138,185,39,128,111,194,6,225,204,211,24,148,24,142,120,61,37,181,152,93,187,25,54,143,55,140,221,215,219,127,219,60,158,177,159,210,233,135,119,115,82,40,31,121,95,123,129,13,242,21,250,57,170,12,170,173,135,193,211,90,0,143,10,123,13,168,79,116,50,173,198,1,23,147,62,209,16,251,238,184,199,236,185,38,238,161,9,219,184,100,217,88,1,176,148,248,116,124,107,152,126,158,31,204,158,16,129,20,255,169,196,234,60,111,8,237,227,87,110,89,99,34,196,152,67,133,42,39,185,165,57,216,79,13,9,121,145,237,237,26,209,155,102,141,205,29,146,146,159,196,58,212,252,61,105,23,165,26,185,226,46,203,98,251,120,186,179,76,226,22,225,64,162,156,116,14,87,246,185,42,233,27,62,144,124,93,113,230,45,160,160,51,42,207,24,192,169,198,92,176,123,149,11,170,78,34,242,120,13,26,0,139,66,75,245,208,173,104,140,77,37,90,190,56,146,170,215,239,18,89,15,168,42,215,128,106,6,62,108,8,216,132,183,91,201,66,168,20,20,107,58,201,13,230,96,125,21,28,214,90,224,144,103,176,48,48,194,27,165,241,38,23,31,225,188,15,134,152,226,28,115,99,27,126,233,213,44,26,12,108,99,126,110,2,84,234,120,201,222,42,221,96,97,43,111,173,141,78,221,122,126,106,155,21,23,229,154,150,202,220,65,55,78,157,170,161,72,80,0,226,85,158,179,71,176,164,161,147,162,9,169,112,152,10,37,255,6,76,19,105,36,68,104,18,48,126,69,132,0,173,75,165,234,10,225,146,241,2,87,50,82,161,55,12,52,75,255,194,119,192,73,13,66,205,232,117,32,34,203,54,50,81,230,226,99,74,182,74,190,107,166,56,2,181,164,21,36,58,152,123,218,28,146,166,41,11,54,156,61,26,163,52,202,178,12,98,23,253,84,33,176,196,15,94,184,2,134,91,194,101,235,228,185,17,107,239,35,214,226,29,193,217,219,50,223,157,83,181,225,208,167,48,133,26,156,39,85,11,235,196,168,66,244,227,158,19,68,132,181,104,104,140,16,156,110,80,172,156,65,77,64,180,180,52,218,51,224,35,133,18,29,197,250,125,242,51,113,178,75,10,205,11,20,73,141,151,160,228,232,200,188,158,77,150,209,158,118,252,96,214,242,129,64,38,247,206,70,100,248,119,7,136,239,95,120,204,47,10,76,243,175,192,89,211,29,101,237,132,161,46,255,64,38,27,100,60,202,195,30,169,92,30,42,44,219,51,145,206,51,77,230,111,104,73,55,53,2,181,53,137,204,200,205,230,129,55,184,52,84,180,63,112,151,52,180,116,246,110,11,44,240,31,139,203,22,79,161,179,102,75,126,159,138,189,169,199,186,164,61,15,25,61,251,57,202,106,169,134,15,43,30,19,85,248,116,222,60,227,240,50,81,220,185,176,246,83,132,31,20,58,133,150,79,174,11,252,160,191,105,1,171,58,7,27,149,203,116,104,238,219,239,72,229,177,175,255,244,88,140,154,249,117,93,220,17,254,21,225,116,24,140,130,249,64,200,253,37,229,162,58,199,59,23,140,180,36,211,246,23,54,187,202,84,150,197,145,254,225,46,244,250,220,145,103,44,95,76,168,14,208,137,189,119,106,240,142,129,65,50,139,43,46,173,94,229,155,225,67,155,156,105,154,175,251,101,188,112,79,247,127,154,231,46,33,124,170,132,244,137,217,198,72,255,236,20,167,182,248,203,51,126,77,225,131,195,52,247,43,154,193,151,157,47,207,222,161,59,145,101,191,134,240,75,40,230,39,89,223,108,88,197,62,61,28,133,57,91,162,97,206,174,147,90,111,121,158,127,66,237,97,16,64,8,198,1,231,180,102,253,223,117,52,29,77,111,216,182,222,138,86,249,82,184,107,86,209,21,77,85,80,213,227,74,72,87,186,41,181,14,233,109,128,116,95,127,250,141,197,172,62,8,17,7,176,175,171,145,118,146,92,9,69,139,39,172,211,124,112,105,234,79,212,230,56,253,55,50,105,71,125,134,112,24,63,233,197,166,72,3,75,149,31,42,228,55,104,8,217,15,16,171,161,146,128,2,6,206,95,68,211,139,251,44,58,205,15,35,132,97,236,156,172,236,134,193,230,201,79,138,231,68,220,87,108,171,40,185,122,180,199,57,169,73,152,39,33,233,141,216,175,199,18,236,126,153,14,73,59,171,243,9,90,185,139,51,220,233,59,120,21,216,164,39,217,143,211,255,75,55,58,167,66,238,239,171,236,65,126,146,202,126,161,2,170,223,139,213,10,32,117,220,74,15,201,43,16,141,192,95,194,165,2,100,247,114,167,108,4,248,115,221,107,84,9,70,178,206,85,5,89,113,235,90,123,202,22,155,110,197,40,151,249,168,64,158,13,78,127,133,87,247,11,244,160,119,237,65,91,191,176,55,27,64,253,234,179,169,188,83,144,120,23,27,244,50,56,213,224,2,201,20,120,28,9,96,74,120,116,162,46,32,32,253,4,107,212,148,240,10,18,157,220,110,8,48,39,112,239,128,147,213,113,116,123,52,120,149,68,127,34,36,210,172,21,135,87,124,45,34,116,216,80,166,230,155,169,206,151,180,84,13,126,160,174,176,171,152,225,129,49,55,44,24,68,52,78,51,99,109,111,75,45,112,172,61,206,8,97,203,208,14,115,212,248,238,29,248,73,210,172,181,139,200,96,20,52,230,123,160,103,182,179,114,115,107,67,152,72,217,94,47,122,9,139,83,232,41,233,86,148,189,221,209,116,21,221,112,96,102,74,235,51,197,245,206,156,248,130,52,164,93,53,124,13,57,213,25,112,107,251,94,15,28,110,113,72,67,112,28,165,141,167,131,109,200,61,58,223,242,108,20,184,22,225,99,153,239,125,17,194,107,43,154,58,72,55,106,167,154,1,166,161,111,78,41,78,157,213,34,180,55,85,26,186,163,184,82,166,143,48,109,116,29,105,254,77,55,121,194,71,168,80,221,232,45,233,84,117,161,232,220,77,89,129,57,253,152,221,9,56,250,173,255,242,233,31,166,114,33,160,149,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fcf5e758-8cd5-4642-babf-989888cb0f79"));
		}

		#endregion

	}

	#endregion

}

