﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderValidatorSchema

	/// <exclude/>
	public class SenderValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderValidatorSchema(SenderValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86811e5f-e4f7-4c68-bd63-b614d02090b3");
			Name = "SenderValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,87,91,111,219,54,20,126,118,129,254,7,214,29,80,121,53,148,116,79,67,19,123,203,197,105,189,213,77,214,164,235,67,221,2,180,116,108,19,149,73,149,164,82,59,129,255,251,14,69,74,150,100,201,118,95,6,4,70,68,158,203,119,238,135,156,46,64,197,52,0,114,7,82,82,37,166,218,191,16,124,202,102,137,164,154,9,254,244,201,227,211,39,173,68,49,62,35,183,43,165,97,129,247,81,4,129,185,84,254,27,224,32,89,112,82,165,121,199,248,247,173,195,59,88,106,255,3,204,146,136,202,193,50,150,160,148,17,178,161,107,192,224,95,12,110,15,34,26,137,16,162,3,228,141,168,252,6,26,41,252,143,154,69,76,51,104,96,146,224,95,209,64,11,105,41,144,230,185,132,25,138,32,23,17,85,234,53,185,5,30,130,252,151,70,44,164,72,134,4,71,71,71,228,84,37,139,5,149,171,190,251,30,81,78,103,160,200,189,165,51,252,98,74,38,73,244,141,192,130,178,136,96,16,84,74,161,82,121,202,207,4,29,21,36,125,190,132,41,77,34,125,206,120,136,64,61,189,138,65,76,189,115,170,96,100,249,115,28,157,46,121,143,145,37,61,210,174,32,108,119,190,160,168,56,153,68,44,32,129,49,162,106,3,121,77,234,68,34,23,102,2,254,110,92,128,177,211,148,107,116,195,141,100,247,84,131,189,143,237,7,9,204,61,81,90,26,175,142,104,32,5,198,30,150,55,84,107,144,220,96,251,234,141,199,159,199,227,231,254,75,252,25,143,191,116,126,105,91,47,183,158,35,38,171,166,172,243,70,138,24,164,9,152,81,42,52,230,33,132,150,164,234,248,244,224,13,104,69,244,28,72,44,48,217,38,38,216,43,162,5,97,28,49,200,36,214,36,152,83,150,134,195,5,71,88,239,111,187,31,237,114,250,136,184,71,102,22,2,153,8,17,145,161,58,155,8,169,175,185,243,149,193,217,235,147,41,141,20,156,236,192,86,32,15,48,113,15,86,234,60,186,97,191,64,110,163,113,132,169,132,55,229,11,229,219,248,158,28,228,37,201,48,215,209,69,232,15,243,157,251,164,201,37,54,143,114,104,232,86,147,11,86,6,34,250,253,120,151,218,59,76,96,101,84,217,34,192,176,56,125,112,160,58,99,25,26,108,228,124,254,82,252,82,119,194,121,33,117,12,135,31,120,255,88,164,240,207,177,250,6,70,111,183,116,124,39,217,108,6,178,238,6,148,78,143,201,122,79,146,142,64,207,69,216,84,22,46,124,232,243,75,129,226,10,89,51,88,6,16,155,127,92,237,121,195,1,79,22,32,233,36,130,83,203,214,39,97,202,164,186,153,156,40,120,112,21,213,33,166,85,183,90,247,84,90,143,42,172,49,75,229,255,37,24,247,218,93,130,127,78,64,231,36,39,118,221,7,169,221,29,118,190,132,107,175,67,122,61,242,138,252,97,176,190,11,30,110,83,81,8,55,1,207,137,189,18,114,65,181,183,193,128,26,110,241,194,116,248,118,167,147,106,104,189,254,57,254,155,8,219,116,132,220,22,160,4,157,96,183,40,51,56,196,93,103,167,37,93,151,253,92,231,60,4,242,145,179,239,9,88,215,171,43,41,22,105,76,85,173,175,173,244,119,76,233,204,183,14,205,230,2,171,203,12,67,207,166,176,205,53,146,246,57,175,253,213,255,245,207,118,7,39,94,28,225,132,181,36,104,32,154,230,95,34,43,227,200,87,11,221,8,62,45,181,101,76,138,33,159,138,126,86,245,96,110,209,25,3,26,204,177,15,222,99,53,72,47,69,88,180,35,187,177,162,82,67,251,110,196,88,171,63,49,157,179,171,98,254,108,38,213,7,80,56,115,76,42,25,203,154,145,57,75,90,83,28,154,8,138,120,70,76,188,13,64,97,147,216,143,33,5,33,1,35,133,35,196,170,46,90,14,242,131,187,115,228,173,84,150,65,135,212,117,90,93,23,180,31,93,199,116,22,179,191,1,27,21,214,185,188,103,1,224,183,111,207,50,138,12,152,155,166,181,146,139,52,150,205,52,136,86,131,39,73,207,137,206,87,15,76,16,45,87,215,252,10,165,37,18,60,83,119,253,34,164,178,229,24,245,60,226,206,67,56,238,127,59,238,146,87,199,157,92,113,37,124,254,89,24,122,213,83,71,189,46,102,246,22,103,93,126,150,39,144,195,229,229,29,21,23,3,141,171,158,173,18,247,81,106,78,149,62,183,105,83,131,69,172,87,155,198,52,201,36,254,147,128,92,189,133,8,103,191,203,134,243,154,171,44,5,13,107,99,134,33,127,157,88,220,100,245,109,3,143,9,172,242,138,214,248,14,249,48,204,114,233,163,2,137,151,220,46,198,5,32,232,208,196,20,99,169,4,122,205,248,178,134,178,204,154,73,77,17,103,89,95,201,206,101,41,21,29,176,138,222,101,169,16,252,79,115,192,140,75,103,245,179,180,107,249,67,53,162,58,152,123,171,238,246,206,134,141,235,78,152,34,243,108,107,95,119,156,128,7,35,224,161,44,250,140,175,188,172,137,179,41,241,158,213,121,194,81,101,6,101,237,181,146,32,197,60,181,141,193,164,166,171,246,93,29,177,78,101,17,210,70,80,10,36,245,249,50,175,183,208,50,228,215,157,159,6,234,230,41,162,220,49,121,10,32,108,236,241,185,176,11,75,230,212,173,50,122,217,59,104,171,200,55,8,247,54,72,37,111,232,31,143,215,159,168,228,88,142,237,29,138,94,140,249,139,210,128,174,117,197,250,224,69,105,255,42,159,121,34,123,36,153,57,82,243,132,106,88,29,211,147,152,74,186,32,28,139,163,215,46,150,115,187,127,137,203,231,15,44,67,172,184,192,8,146,171,162,108,134,3,238,244,40,229,222,8,179,118,171,126,97,141,207,22,41,204,45,46,240,233,147,4,1,64,232,159,30,101,180,7,109,244,112,88,39,117,126,175,52,225,18,101,49,6,123,124,186,237,201,255,219,143,233,227,189,75,126,204,25,110,15,248,118,212,105,229,24,22,179,242,25,247,210,137,72,116,97,66,237,245,235,214,131,200,141,224,204,236,161,121,5,114,26,29,62,186,22,13,18,237,80,106,208,87,156,75,219,235,192,254,8,218,94,165,116,58,34,135,234,125,18,69,215,88,181,56,42,183,71,122,222,161,26,144,102,13,165,52,125,171,82,220,22,177,95,132,125,121,86,158,162,53,91,69,131,164,29,61,194,158,150,15,215,255,1,6,113,215,118,174,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86811e5f-e4f7-4c68-bd63-b614d02090b3"));
		}

		#endregion

	}

	#endregion

}

