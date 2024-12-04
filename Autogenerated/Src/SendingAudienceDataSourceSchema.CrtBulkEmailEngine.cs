﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendingAudienceDataSourceSchema

	/// <exclude/>
	public class SendingAudienceDataSourceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendingAudienceDataSourceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendingAudienceDataSourceSchema(SendingAudienceDataSourceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1cf457ba-b825-dbf1-4944-a15743480f8a");
			Name = "SendingAudienceDataSource";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,90,73,147,219,54,22,62,43,85,249,15,136,114,161,170,84,108,167,114,115,218,234,234,69,237,40,233,109,90,242,228,224,114,185,40,18,234,198,152,36,20,0,236,182,178,252,247,121,88,9,112,147,218,174,204,101,46,182,5,62,124,111,193,219,240,224,50,41,48,223,38,41,70,43,204,88,194,233,70,196,231,180,220,144,135,138,37,130,208,242,219,111,254,252,246,155,81,197,73,249,128,150,59,46,112,241,83,227,55,208,231,57,78,37,49,143,223,226,18,51,146,182,104,174,72,249,123,189,232,243,98,184,94,191,193,207,2,80,228,135,95,56,45,187,55,20,69,223,23,134,227,139,179,222,79,151,73,42,40,35,152,3,5,208,124,207,240,3,136,140,206,243,132,243,215,104,137,203,12,54,157,86,25,193,101,138,47,18,145,44,105,197,82,172,136,183,213,58,39,41,74,37,237,16,233,8,140,5,127,214,224,160,141,72,74,1,12,238,24,121,74,132,134,27,109,245,15,148,202,239,136,148,2,253,171,194,108,119,150,136,244,113,73,254,192,232,13,250,241,213,171,87,90,210,209,247,192,80,3,134,232,151,4,231,89,31,52,195,73,70,203,124,135,174,146,63,118,199,23,68,29,80,194,118,199,111,43,146,77,37,207,217,12,125,204,170,45,40,6,39,93,62,220,227,148,108,65,35,97,12,212,70,58,171,242,79,243,34,33,57,250,136,229,95,125,116,239,56,102,160,121,169,157,2,125,172,130,223,125,187,184,96,242,212,62,174,177,56,205,73,194,193,6,227,179,249,106,220,160,31,84,39,39,5,17,56,107,169,210,103,65,117,62,172,146,142,33,237,168,78,89,83,28,29,29,161,99,94,21,5,240,152,45,74,34,72,146,195,193,112,148,160,18,63,3,63,121,174,16,54,116,131,196,35,6,82,12,167,201,240,230,205,120,245,218,248,252,237,250,63,160,241,24,29,205,180,227,196,199,71,22,80,41,164,125,170,215,155,162,134,25,67,43,78,189,211,80,135,49,65,50,80,71,163,134,181,193,138,45,243,75,42,181,7,62,218,131,148,107,157,206,0,52,82,225,1,179,71,111,225,196,172,248,6,2,223,67,90,1,227,98,62,209,224,210,132,50,118,171,82,113,160,37,16,192,129,235,180,17,53,117,211,226,197,139,76,239,254,123,248,20,175,177,120,164,189,129,224,9,173,93,108,106,92,109,134,46,48,240,213,7,123,157,164,140,242,75,70,139,123,112,72,204,34,227,142,133,90,95,170,31,214,196,79,9,51,235,96,28,77,23,47,248,77,149,231,183,108,94,108,197,46,10,119,157,40,11,246,203,17,77,208,107,36,19,30,152,224,9,51,161,152,140,98,79,58,237,74,199,139,121,89,21,152,37,235,28,31,187,227,87,146,47,202,13,133,147,8,248,26,152,21,173,57,71,159,209,155,25,250,28,171,0,155,34,243,235,223,73,94,97,115,78,12,139,138,149,70,61,223,248,29,230,172,125,0,13,186,64,228,27,142,97,94,229,194,120,85,39,88,100,68,145,212,233,35,78,63,57,68,176,183,86,42,90,83,154,79,84,90,15,170,85,12,161,183,196,66,122,176,172,69,66,105,22,53,66,98,138,198,119,12,63,129,115,215,192,38,10,199,134,53,217,160,232,187,6,111,171,132,53,145,86,68,211,255,93,171,71,169,88,98,89,15,141,138,250,71,83,6,123,56,80,59,171,162,140,198,238,52,87,9,123,192,98,12,50,94,39,224,237,36,207,23,217,120,18,159,242,104,236,98,242,157,92,10,1,36,167,223,72,153,209,103,85,72,46,171,82,177,81,235,247,244,249,166,42,214,152,133,159,38,83,37,159,90,212,40,243,207,91,80,138,203,143,99,37,204,105,6,241,198,249,120,50,213,220,70,3,27,58,52,144,98,78,140,236,74,6,39,181,140,179,246,22,251,245,183,71,204,112,39,162,91,242,44,176,224,243,223,171,36,143,180,72,241,93,194,160,167,17,16,193,117,18,177,164,167,101,54,12,107,93,246,16,248,107,160,7,151,81,37,132,199,45,8,153,70,118,43,42,29,75,74,80,187,52,51,4,135,120,137,243,143,206,179,87,86,172,29,78,91,90,23,15,160,167,44,227,77,147,218,99,0,173,222,66,225,149,106,180,244,250,97,50,65,80,125,53,166,77,10,190,200,241,114,11,210,108,118,55,244,138,166,159,126,134,144,133,8,215,132,186,241,138,164,154,217,122,254,25,167,21,84,86,80,177,161,87,60,47,121,197,240,197,89,189,20,77,92,124,121,32,178,57,192,18,160,33,129,134,86,54,6,137,107,86,53,136,50,53,164,20,173,222,162,204,48,36,59,131,39,51,195,45,131,120,135,99,109,88,86,171,49,26,61,63,146,28,163,200,208,75,62,158,128,26,156,100,1,160,204,95,81,200,208,161,141,116,174,120,79,178,15,176,39,2,139,77,140,247,88,111,57,167,25,52,175,54,215,100,118,163,206,43,230,47,253,103,59,251,52,18,180,142,207,132,99,153,148,47,240,38,1,58,199,6,150,85,238,68,132,235,46,69,249,108,35,63,59,82,227,156,14,209,30,179,17,254,98,253,78,192,63,4,244,212,49,164,10,240,49,89,193,50,162,206,211,199,129,16,131,15,2,26,112,25,109,138,37,252,195,36,18,179,97,181,219,226,88,133,154,73,54,166,176,170,130,58,237,55,218,185,108,195,114,156,157,229,73,169,35,240,159,22,82,151,122,200,158,242,79,83,143,254,199,210,129,8,180,60,77,5,88,235,64,107,66,151,11,24,123,229,92,148,79,208,112,100,190,164,170,22,118,186,203,87,42,113,65,111,168,128,38,247,64,13,14,85,33,128,181,33,248,5,146,186,140,190,172,214,60,101,100,43,137,198,205,15,75,145,136,138,67,234,176,82,246,106,129,122,10,134,177,200,59,72,137,138,207,26,103,22,107,175,174,254,166,179,157,100,102,20,182,185,162,214,40,158,231,96,19,87,176,109,39,213,95,209,91,133,161,87,154,59,10,174,145,221,49,250,68,32,25,218,90,87,39,42,39,67,87,186,146,151,95,104,211,72,6,63,204,61,203,7,143,188,194,106,18,181,236,117,1,214,251,229,231,47,210,198,80,121,218,35,143,59,248,212,190,222,5,240,221,64,214,110,104,223,232,18,59,208,252,19,82,193,101,80,107,215,180,246,80,122,71,161,236,126,99,86,151,164,110,173,15,8,119,104,19,0,95,40,84,35,24,194,224,41,72,74,214,190,79,235,187,130,108,186,69,2,119,224,95,241,174,33,158,241,102,217,242,12,203,214,135,253,190,7,239,67,91,186,206,251,234,94,9,15,16,109,0,184,33,94,151,92,33,197,61,86,88,11,232,22,222,32,217,36,232,138,246,181,39,183,194,197,54,7,23,129,92,119,73,171,210,116,12,65,139,208,231,122,141,0,52,125,40,52,11,11,104,198,152,254,41,91,203,51,44,34,24,71,224,21,41,240,9,74,178,12,114,12,222,192,157,75,93,211,78,234,152,114,99,43,63,14,215,222,44,171,77,137,78,78,26,35,175,186,65,134,1,208,65,189,241,138,110,35,199,229,128,11,85,120,165,81,205,114,184,180,31,194,121,163,217,239,253,254,130,11,157,191,176,127,59,140,80,63,225,108,94,10,34,118,14,162,185,248,127,123,191,106,94,89,100,32,122,46,27,255,156,112,61,230,176,113,231,188,172,87,234,115,117,67,202,110,75,117,95,186,2,23,129,241,78,183,172,62,39,205,102,210,17,144,142,229,112,24,214,41,71,7,135,118,255,47,143,68,210,10,107,8,172,238,112,15,160,59,80,127,234,187,38,244,92,53,172,139,4,221,163,15,98,56,188,124,98,226,198,196,47,15,108,127,235,193,1,237,111,122,65,32,251,219,94,18,192,173,60,224,156,194,212,19,213,64,159,187,226,98,208,130,149,189,80,106,114,168,51,147,156,246,57,101,244,143,112,187,127,222,154,174,163,137,10,243,79,219,239,212,70,103,18,75,124,133,55,226,22,110,243,236,23,74,6,85,182,27,110,247,25,166,110,21,219,121,166,239,32,15,21,70,27,109,88,20,103,216,112,184,240,181,50,4,23,145,78,9,154,87,21,223,189,187,152,183,221,61,76,134,189,87,31,121,213,8,80,251,170,131,38,116,21,66,229,28,173,150,189,9,250,138,248,87,220,3,100,110,207,169,130,124,50,48,168,114,151,147,96,131,205,203,117,86,126,162,48,230,25,126,187,216,243,76,35,91,62,180,174,235,170,123,167,105,245,191,7,188,180,192,36,29,38,246,166,130,169,220,206,47,161,72,193,44,109,94,202,87,1,57,146,106,140,218,100,162,111,16,153,244,216,167,146,155,130,153,155,127,131,195,95,127,185,231,153,206,161,128,181,237,222,249,190,157,110,73,61,160,232,26,253,223,127,112,64,18,193,123,161,59,101,15,240,250,81,138,104,28,170,8,222,210,40,21,211,125,0,222,121,192,110,255,116,246,110,229,250,122,172,54,122,237,188,209,200,104,166,158,46,122,204,11,121,138,114,2,152,59,123,7,31,169,55,104,253,62,189,147,7,118,60,120,62,53,192,44,146,118,179,230,52,118,223,207,55,246,94,107,174,164,23,122,47,53,166,109,121,225,187,91,223,195,169,93,0,134,92,189,147,38,134,173,125,55,149,166,215,111,144,72,80,196,129,81,236,64,130,215,82,181,162,53,228,179,43,2,175,230,128,224,189,186,46,174,225,92,146,7,57,248,174,47,95,227,163,25,60,186,218,93,222,163,107,231,67,90,176,53,120,210,234,110,190,164,191,170,65,96,79,15,102,190,135,195,85,27,236,174,227,233,109,248,14,235,197,254,193,137,123,40,234,33,51,247,3,166,230,254,11,101,48,63,215,5,68,53,207,230,125,116,86,247,34,110,144,30,60,189,14,61,223,6,47,161,193,246,224,122,110,114,110,207,144,201,73,62,146,215,247,30,97,101,18,80,162,214,117,220,38,17,136,108,91,172,246,109,247,170,218,20,185,237,97,119,184,15,163,217,75,214,98,248,237,240,126,171,135,205,243,73,188,98,164,136,60,52,109,108,192,209,70,174,63,120,179,142,97,73,131,62,181,222,223,209,82,162,62,36,85,73,134,154,208,58,27,123,141,65,223,248,15,216,12,13,33,195,105,163,131,221,201,255,128,3,242,133,189,132,164,233,127,192,233,206,169,122,53,92,132,181,255,2,24,150,2,188,159,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1cf457ba-b825-dbf1-4944-a15743480f8a"));
		}

		#endregion

	}

	#endregion

}

