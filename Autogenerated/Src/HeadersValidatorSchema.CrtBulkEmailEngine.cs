﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HeadersValidatorSchema

	/// <exclude/>
	public class HeadersValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HeadersValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HeadersValidatorSchema(HeadersValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5f463ee-10f4-4e3b-badf-28bf0d5095cd");
			Name = "HeadersValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f5a6178-e602-42c0-b4d9-e7d8824941b4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,86,77,115,219,54,16,61,203,51,254,15,168,114,161,102,52,84,14,61,217,150,50,182,35,187,154,137,226,166,82,219,131,199,7,136,92,137,104,73,128,1,64,217,106,198,255,61,11,2,164,72,74,180,169,75,47,150,1,238,190,221,125,251,129,229,52,1,149,210,0,200,18,164,164,74,172,181,127,43,248,154,109,50,73,53,19,252,252,236,199,249,217,249,89,47,83,140,111,200,98,167,52,36,151,141,51,106,196,49,4,70,92,249,247,192,65,178,224,64,230,11,227,223,247,151,85,107,18,252,41,215,76,51,80,173,2,119,52,208,66,90,9,148,249,32,97,131,214,200,109,76,149,186,32,191,1,13,65,170,191,104,204,66,138,114,40,49,26,141,200,149,202,146,132,202,221,196,157,231,148,211,13,40,178,181,114,6,64,172,9,18,160,240,154,68,22,196,47,148,71,21,237,199,207,176,166,89,172,111,24,15,209,59,79,239,82,16,107,239,134,42,152,91,245,210,246,96,72,190,34,169,100,76,250,77,183,250,131,39,196,74,179,85,204,2,18,24,215,15,60,39,23,228,24,40,170,217,52,148,145,255,46,69,10,210,112,118,97,254,215,72,63,132,86,164,25,122,126,113,15,90,17,29,1,73,133,82,108,197,98,166,119,68,11,194,184,70,166,179,84,147,32,162,44,39,196,209,35,44,23,135,100,244,210,194,30,17,91,84,102,33,144,149,16,49,153,169,235,149,144,250,129,59,191,141,159,227,9,209,50,131,203,55,92,171,72,7,34,132,206,54,149,150,166,82,246,234,183,168,109,12,206,41,134,199,55,245,15,202,119,92,95,118,98,73,50,44,55,164,8,249,48,231,146,147,54,74,108,82,75,223,144,86,76,139,195,64,151,126,253,248,150,217,37,150,147,50,166,32,65,215,77,90,156,61,232,104,110,1,121,93,26,156,199,167,234,73,45,133,163,33,103,134,195,51,126,255,81,149,240,111,178,248,223,169,177,59,172,93,47,37,219,108,64,30,251,2,74,231,215,228,213,5,245,1,191,218,186,172,23,233,28,116,36,194,188,66,217,22,93,176,95,83,123,32,179,41,207,18,144,116,21,195,149,205,229,196,36,160,244,199,229,203,187,207,88,72,86,197,237,44,28,16,236,133,94,175,183,165,146,128,250,142,157,134,97,145,124,132,236,22,65,132,28,126,203,64,238,188,63,21,72,156,101,220,78,38,191,42,96,39,129,28,18,142,173,106,26,185,64,31,12,204,8,234,245,14,208,112,196,101,9,39,42,91,253,131,120,238,52,54,246,253,235,48,180,103,175,191,132,36,141,49,182,133,21,235,191,135,134,188,57,138,219,16,23,123,145,110,104,102,248,188,13,102,36,234,88,4,242,159,25,206,105,167,132,121,176,159,26,44,14,107,137,184,44,243,80,137,196,32,148,112,159,12,146,169,26,231,3,22,99,86,102,219,59,136,223,55,190,85,97,45,143,167,64,86,19,116,0,87,198,127,178,147,123,90,171,160,18,116,38,121,217,86,149,120,134,21,99,195,50,14,211,48,189,222,107,189,15,234,115,12,58,215,63,91,19,175,114,77,198,99,98,68,253,105,146,234,93,33,84,184,136,17,126,9,254,91,228,166,242,248,188,198,243,132,201,157,74,105,30,41,27,26,58,137,127,143,245,168,123,40,145,194,99,221,122,88,31,249,219,64,227,66,226,90,194,29,195,125,1,29,46,223,220,235,56,246,94,204,128,250,197,26,241,103,234,107,22,199,15,242,239,136,97,55,153,5,197,123,41,122,211,69,116,12,241,147,35,211,114,128,143,233,169,97,191,118,30,104,239,63,185,69,66,85,158,60,55,219,221,182,209,50,215,243,155,148,74,154,228,147,105,220,207,149,176,253,52,188,232,254,228,51,190,12,207,76,71,88,112,129,193,145,187,42,52,227,107,113,53,202,181,247,96,150,44,53,169,60,178,197,194,131,245,195,133,198,218,12,2,128,208,191,26,21,178,157,222,91,216,15,77,231,159,117,195,29,138,250,115,201,106,45,238,170,142,239,214,158,89,168,30,63,62,213,18,114,50,193,255,55,191,115,92,49,176,233,159,35,22,68,184,198,112,141,203,148,202,85,100,98,105,167,43,145,233,202,238,249,46,223,7,107,204,31,160,112,7,45,195,158,153,213,141,211,184,91,34,204,252,75,90,16,237,11,218,98,207,115,109,231,210,191,61,84,62,53,185,254,29,147,74,63,72,183,84,123,69,99,155,129,214,28,0,121,35,123,77,163,131,114,188,181,132,228,239,47,156,93,244,179,137,98,173,118,128,176,139,101,99,211,172,142,73,87,229,45,72,111,76,22,123,91,191,124,61,63,251,9,201,244,87,248,151,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5f463ee-10f4-4e3b-badf-28bf0d5095cd"));
		}

		#endregion

	}

	#endregion

}

