﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookAccountProviderSchema

	/// <exclude/>
	public class WebhookAccountProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookAccountProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookAccountProviderSchema(WebhookAccountProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aff03d4b-8452-40b2-88a8-6431e75b910a");
			Name = "WebhookAccountProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8e07ad5d-ca48-4dfc-8107-c7bee2abec1b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,87,223,111,219,56,12,126,78,129,254,15,66,246,226,0,133,179,123,93,243,3,109,182,30,130,235,181,195,210,221,61,12,195,160,216,116,34,204,150,60,73,78,234,27,250,191,31,101,201,137,173,196,73,135,195,61,180,176,40,146,162,62,126,36,21,78,51,80,57,141,128,60,129,148,84,137,68,135,51,193,19,182,42,36,213,76,240,240,158,242,152,241,21,155,115,13,43,43,187,188,248,121,121,209,43,20,138,201,162,84,26,178,107,111,141,62,210,20,34,163,172,194,223,129,131,100,209,129,206,61,227,63,246,194,230,249,89,38,248,241,29,9,93,242,240,142,70,90,72,6,106,175,97,228,246,54,100,236,171,183,110,137,38,104,244,70,194,10,23,100,150,82,165,222,145,191,97,185,22,226,251,77,20,137,130,235,143,82,108,88,12,178,210,28,14,135,100,196,248,26,239,165,99,17,145,72,66,50,238,207,143,91,244,135,19,52,249,242,30,18,90,164,250,150,85,120,6,186,204,65,36,65,135,205,96,240,21,109,242,98,153,50,244,110,226,233,8,135,188,35,29,46,208,30,211,132,255,247,247,194,108,104,202,53,222,237,163,100,27,170,193,238,231,118,65,34,179,79,148,150,6,187,121,12,92,51,93,206,82,134,31,152,178,153,136,1,97,236,215,27,11,144,27,144,118,123,30,247,175,15,61,49,174,201,39,92,222,179,140,105,52,253,237,237,91,11,116,239,13,240,216,6,213,142,240,142,65,26,119,133,39,129,198,130,167,37,249,172,240,92,193,185,37,24,249,86,180,214,173,64,60,108,76,204,44,130,155,156,145,111,219,142,157,51,33,86,32,202,194,112,205,4,90,101,200,106,84,164,80,69,150,81,89,78,106,193,156,51,205,104,202,254,1,69,40,225,176,69,84,76,18,176,226,68,66,244,26,208,4,192,17,168,147,63,150,2,225,238,148,161,127,204,40,167,146,102,132,99,57,143,251,109,60,250,147,39,60,197,200,76,90,156,48,28,13,43,139,202,129,163,217,241,211,3,15,237,182,243,1,49,173,160,215,243,114,128,201,62,146,148,151,211,200,226,137,57,72,141,21,220,65,0,143,153,109,2,146,113,117,151,222,190,230,67,36,237,2,180,70,27,211,132,244,95,52,45,32,240,34,189,58,78,244,43,210,239,15,174,127,33,222,115,60,48,57,112,140,67,34,88,136,137,178,164,35,52,103,29,185,117,169,233,166,113,231,134,205,203,10,116,13,76,175,147,241,100,58,181,26,65,183,202,184,226,110,215,105,62,170,3,131,29,58,84,213,241,228,148,219,141,201,74,147,30,191,212,91,67,39,94,136,66,70,160,108,171,221,161,246,129,23,25,72,186,76,97,100,185,51,33,109,125,19,220,94,41,252,144,229,186,172,85,131,115,249,255,19,244,90,196,103,200,58,195,174,165,225,1,182,120,219,239,80,6,78,188,109,134,129,28,220,15,215,57,79,132,233,156,205,117,93,101,27,138,53,92,57,252,4,63,10,192,22,123,44,45,245,158,181,233,217,8,226,219,18,149,189,52,133,179,66,74,36,189,41,241,240,1,123,199,85,203,228,209,212,241,123,252,122,98,25,132,159,117,244,32,182,78,99,174,110,208,195,198,12,4,108,134,181,93,179,217,239,190,221,94,11,120,220,111,35,224,188,182,74,209,212,116,71,177,55,227,100,162,161,238,1,23,158,50,88,0,98,169,59,141,236,182,53,124,177,116,190,165,10,124,172,85,142,3,161,106,224,6,178,69,177,116,59,232,183,171,90,66,139,175,147,7,173,140,186,194,193,147,11,201,15,189,134,104,254,7,148,175,105,167,123,122,250,189,233,213,197,133,77,243,81,218,96,235,244,237,46,129,81,180,171,205,49,251,140,205,127,43,128,218,227,14,15,181,75,192,246,96,235,84,6,48,202,134,102,80,183,43,27,27,173,34,189,45,15,184,186,183,152,134,141,133,229,214,52,188,99,82,225,229,221,67,47,120,54,221,229,185,221,161,200,216,99,254,96,218,76,105,143,37,36,104,31,31,206,213,67,145,166,143,178,106,78,193,160,134,162,119,16,165,223,106,60,136,125,72,237,129,47,77,186,181,93,158,32,153,149,122,66,127,238,153,181,163,146,121,251,72,33,244,110,242,37,82,100,213,235,7,158,53,72,78,83,127,38,154,121,120,48,14,29,211,204,77,100,98,126,180,156,124,250,118,76,98,76,189,34,162,110,164,85,16,14,169,221,60,86,197,210,133,243,218,39,87,11,107,251,226,218,77,123,101,243,216,124,113,29,216,123,201,233,79,14,180,109,138,84,229,26,179,75,180,56,8,219,60,35,70,195,90,209,88,254,175,53,233,198,99,55,200,6,218,69,145,231,66,98,15,219,71,235,70,239,18,239,176,102,138,228,117,183,57,14,245,43,134,248,79,130,207,156,107,98,168,140,127,47,151,23,255,2,43,40,39,48,214,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aff03d4b-8452-40b2-88a8-6431e75b910a"));
		}

		#endregion

	}

	#endregion

}

