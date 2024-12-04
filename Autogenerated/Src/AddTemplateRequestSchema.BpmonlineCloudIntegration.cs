﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddTemplateRequestSchema

	/// <exclude/>
	public class AddTemplateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddTemplateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddTemplateRequestSchema(AddTemplateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9ed8468-49e6-4d93-8ee7-ff2db809a712");
			Name = "AddTemplateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,152,77,79,219,64,16,134,207,32,241,31,70,225,210,94,146,59,95,82,9,41,226,64,133,112,78,173,144,181,177,39,201,182,107,59,221,93,167,4,212,255,222,153,181,29,154,216,113,252,113,1,121,247,125,135,121,246,107,118,137,69,132,102,37,2,132,41,106,45,76,50,183,195,113,18,207,229,34,213,194,202,36,30,142,39,222,99,18,162,50,103,167,239,103,167,39,169,145,241,2,188,141,177,24,93,238,125,147,83,41,12,216,102,134,247,24,163,150,65,73,243,156,198,86,70,56,244,168,87,40,249,230,254,10,169,72,119,174,113,65,31,48,86,194,152,11,248,18,134,83,140,86,74,88,124,198,223,41,26,235,84,163,209,8,174,76,26,69,66,111,110,242,111,231,128,121,162,65,103,74,176,9,136,48,4,155,7,24,22,198,209,158,243,202,32,10,101,18,8,52,206,175,7,71,71,97,120,43,12,82,238,107,25,20,89,13,96,196,209,126,220,9,43,200,101,181,8,236,11,53,172,210,153,146,1,4,46,183,50,12,92,64,57,22,217,104,148,233,231,118,48,158,116,178,66,109,37,210,136,60,185,136,89,255,254,48,184,134,123,180,6,104,20,12,255,182,75,220,242,67,76,19,205,131,80,30,133,172,101,45,84,138,219,207,233,178,228,248,16,56,208,71,140,102,168,63,125,35,17,92,195,128,197,131,207,76,93,96,27,171,121,214,157,224,29,22,104,47,57,171,75,248,219,52,125,131,113,136,26,48,18,82,53,207,124,194,114,158,122,141,198,52,78,127,174,147,200,119,127,169,18,226,43,117,103,129,251,144,180,155,2,175,210,212,0,227,224,84,48,69,247,233,224,213,100,210,217,79,218,223,237,214,81,217,84,15,145,235,43,17,188,172,175,59,193,210,70,10,2,218,201,237,24,170,108,245,20,44,174,68,24,83,71,247,252,105,51,203,152,118,245,107,203,73,248,240,237,155,235,49,88,92,137,49,229,80,157,49,220,86,3,25,34,213,130,185,68,221,14,166,198,93,79,227,140,190,12,119,137,238,83,25,102,231,198,67,216,29,73,73,58,210,147,57,200,72,44,208,180,3,42,121,234,49,50,249,46,196,195,36,78,35,212,98,166,240,202,245,223,192,131,147,117,39,210,184,162,200,2,130,37,6,191,72,221,142,169,198,93,79,151,27,253,194,88,185,252,158,51,209,56,215,244,135,236,186,22,107,253,205,64,247,215,227,46,98,121,77,158,156,52,199,155,241,221,139,42,33,240,157,11,168,164,180,163,171,179,215,195,21,78,159,157,62,57,119,25,85,66,132,183,185,102,74,146,73,220,99,239,237,166,105,172,208,45,143,199,250,0,109,72,157,247,8,171,199,154,238,180,116,13,149,107,212,27,48,180,69,194,84,81,139,216,180,60,113,142,198,168,103,46,236,126,97,247,217,94,185,140,239,114,169,151,43,239,72,216,131,61,229,76,233,62,251,103,137,113,94,8,162,148,78,222,25,66,32,226,0,21,182,92,226,69,196,230,69,228,117,37,179,87,1,65,219,189,34,79,122,228,41,134,201,86,197,77,125,182,240,74,203,68,75,187,225,226,226,170,84,203,202,159,219,27,243,21,134,93,48,25,91,122,138,228,153,244,160,225,219,41,147,184,235,100,64,79,155,246,143,146,67,246,35,215,74,86,31,190,28,123,220,221,243,118,76,167,28,135,162,136,52,229,139,77,231,154,210,44,208,17,220,44,134,95,196,40,85,25,158,80,47,19,121,185,166,95,169,161,75,20,79,12,47,254,183,36,70,247,26,207,179,104,135,79,167,35,37,241,95,164,14,248,89,140,236,72,230,24,135,138,236,212,233,120,199,126,39,85,215,251,95,177,42,39,222,211,1,212,234,141,150,172,9,77,31,94,148,244,246,119,138,67,235,242,156,134,55,251,55,129,251,206,90,119,27,169,237,31,241,43,237,223,228,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9ed8468-49e6-4d93-8ee7-ff2db809a712"));
		}

		#endregion

	}

	#endregion

}

