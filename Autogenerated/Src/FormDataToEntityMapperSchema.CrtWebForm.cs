﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormDataToEntityMapperSchema

	/// <exclude/>
	public class FormDataToEntityMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormDataToEntityMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormDataToEntityMapperSchema(FormDataToEntityMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69720bdd-86d5-4fc8-98a8-0dc605a74145");
			Name = "FormDataToEntityMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,88,205,114,219,54,16,62,51,51,121,7,68,189,200,83,13,125,119,34,117,218,196,118,53,141,19,79,108,183,135,76,14,48,9,74,104,72,64,3,144,178,149,78,222,189,187,0,72,0,52,73,187,77,162,131,68,2,216,221,111,255,23,18,180,98,122,71,51,70,174,153,82,84,203,162,78,95,75,81,240,77,163,104,205,165,72,207,153,96,240,200,242,191,216,237,153,84,213,21,83,123,158,177,231,207,254,121,254,44,105,52,23,27,114,117,208,53,171,94,246,222,129,79,89,178,12,153,104,203,133,103,254,76,40,174,170,164,24,222,81,108,108,61,61,21,53,175,57,211,163,7,206,104,86,75,101,79,192,153,159,20,219,0,20,242,186,164,90,159,16,84,229,13,173,233,181,52,140,14,23,116,183,99,202,156,60,62,62,38,175,116,83,85,84,29,86,238,29,182,53,41,128,134,228,64,68,164,168,37,217,240,61,19,132,25,242,180,165,59,14,8,119,205,109,201,51,146,161,196,17,129,228,132,172,199,160,36,96,97,248,246,200,193,144,181,106,80,43,80,224,210,48,183,39,250,136,205,66,112,28,209,61,132,103,87,118,84,209,138,8,136,131,229,108,79,75,14,250,73,53,91,173,129,152,10,136,11,89,0,107,198,72,166,88,177,156,173,251,225,240,103,71,66,142,87,233,171,99,195,110,152,123,206,10,218,148,53,80,52,236,130,10,186,97,19,114,222,12,28,126,84,66,163,153,2,181,133,141,186,152,57,238,145,172,219,140,24,57,71,13,59,98,62,174,51,233,12,182,64,54,73,50,4,155,12,232,189,32,55,17,84,131,206,191,30,17,76,174,36,25,23,188,244,162,49,1,146,100,72,240,114,72,180,61,222,19,191,236,1,48,135,190,186,240,99,34,183,17,24,135,227,165,146,96,29,76,193,39,4,227,148,39,134,131,211,249,164,7,180,247,106,205,180,97,181,213,74,187,135,175,19,72,206,74,186,33,245,150,214,132,139,156,103,96,93,77,238,182,172,222,2,168,10,28,142,149,4,244,194,92,103,57,209,77,150,49,173,139,166,44,15,211,64,111,165,44,201,149,61,222,199,181,83,124,15,130,200,83,240,93,0,61,248,201,65,212,68,102,89,163,0,73,222,40,132,230,32,78,99,129,188,199,179,45,171,111,64,19,250,173,164,96,48,96,107,42,96,23,126,211,72,38,114,103,124,231,127,120,21,112,210,218,225,180,245,214,216,175,224,101,169,219,44,64,204,13,120,27,143,40,134,146,131,226,61,161,194,80,106,13,173,77,195,30,75,163,11,8,61,153,99,14,89,183,216,221,206,71,214,147,87,172,134,110,218,84,66,159,41,89,161,181,206,56,43,115,141,213,106,30,191,126,252,100,250,148,95,88,16,91,205,156,178,109,109,113,156,21,211,160,71,27,41,75,39,48,61,173,118,245,193,234,193,11,50,143,57,146,23,75,34,32,35,90,86,9,108,51,154,109,73,15,138,7,2,185,214,67,213,209,38,127,176,131,49,227,37,229,234,149,21,191,112,48,86,80,38,80,235,119,80,221,205,25,71,146,44,73,183,4,189,94,65,53,128,64,60,71,35,153,151,110,211,3,79,177,67,44,60,136,212,4,195,145,85,177,179,134,23,7,166,232,201,78,1,232,224,113,179,59,112,222,124,183,20,104,69,103,219,181,126,7,198,123,175,140,141,231,1,143,163,163,86,63,168,142,53,23,158,218,122,240,42,219,178,138,218,64,112,210,64,172,139,97,187,153,186,48,65,99,252,118,64,44,78,0,62,118,218,94,31,118,208,104,205,186,121,108,177,167,232,25,3,5,151,173,2,248,20,42,225,78,174,245,91,41,63,55,59,220,246,190,76,32,80,237,186,197,225,78,47,66,75,45,218,64,108,185,126,37,172,212,109,149,130,79,173,14,254,197,200,116,21,226,119,86,66,101,6,209,231,76,110,20,221,109,161,124,151,145,32,163,101,0,231,145,232,218,0,31,103,206,165,39,73,98,113,96,201,80,222,141,224,245,3,153,61,5,227,46,213,41,10,159,214,89,109,62,219,40,245,56,48,200,22,1,46,235,131,128,67,223,88,73,34,111,255,6,57,182,184,129,39,205,0,3,78,185,169,121,105,6,100,203,226,87,141,139,97,180,181,152,141,7,31,133,216,58,50,78,27,83,221,90,96,208,75,177,6,156,222,103,108,103,186,51,187,15,93,17,87,154,159,151,80,150,246,92,73,81,129,192,244,29,187,123,203,69,23,104,93,134,193,72,47,149,163,121,25,197,4,187,199,238,136,126,162,117,39,50,114,125,72,11,134,233,247,155,183,217,23,111,35,112,50,188,95,25,161,86,225,32,30,102,61,41,142,231,108,65,102,35,183,163,217,68,12,56,15,122,29,222,239,97,220,40,229,221,143,214,226,129,156,239,162,199,15,129,10,2,1,172,6,129,223,11,236,120,24,186,170,108,125,60,15,117,120,208,46,134,83,166,229,237,126,237,143,253,86,172,110,148,136,155,108,56,20,180,109,126,47,121,78,250,181,115,180,232,183,5,44,46,58,83,93,30,6,93,52,8,76,54,81,111,75,63,176,130,41,6,115,147,235,30,184,107,245,58,111,0,17,135,107,252,58,111,251,219,131,178,184,54,219,56,145,188,233,248,207,99,81,79,41,140,211,5,39,196,0,115,7,226,178,211,9,249,37,218,59,33,115,91,9,143,204,104,242,223,70,175,71,239,210,102,94,212,206,184,164,0,149,219,113,248,169,119,107,12,37,172,205,179,149,29,141,66,22,147,151,90,43,115,182,114,254,53,127,61,220,65,43,218,218,65,60,100,132,213,4,47,8,44,31,186,222,154,32,131,59,173,153,210,186,249,108,98,68,52,49,112,103,189,190,206,253,52,248,194,56,225,90,29,46,169,210,118,198,66,46,41,62,172,243,5,145,77,237,201,124,59,126,90,101,112,201,52,80,32,102,55,226,179,144,119,194,17,173,115,68,91,112,166,190,161,52,180,23,182,37,41,40,84,51,183,106,211,246,101,144,200,143,204,216,72,31,90,193,239,88,38,123,170,204,1,204,24,119,207,1,16,31,76,89,24,176,71,119,21,74,221,19,155,123,123,6,126,24,99,153,90,181,6,44,63,74,17,247,216,167,154,197,167,46,92,136,130,236,213,115,7,211,23,134,110,248,178,89,186,138,254,155,64,73,3,87,42,12,2,199,175,211,127,196,147,69,123,5,121,56,201,195,221,35,146,133,51,150,183,205,84,245,177,21,44,34,254,232,119,62,57,209,214,20,65,71,153,188,173,1,208,232,114,22,13,195,222,238,240,207,93,212,41,194,26,230,214,194,37,88,249,23,64,211,33,219,203,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69720bdd-86d5-4fc8-98a8-0dc605a74145"));
		}

		#endregion

	}

	#endregion

}

