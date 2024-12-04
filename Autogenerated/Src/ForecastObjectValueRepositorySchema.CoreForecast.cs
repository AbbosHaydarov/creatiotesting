﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastObjectValueRepositorySchema

	/// <exclude/>
	public class ForecastObjectValueRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastObjectValueRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastObjectValueRepositorySchema(ForecastObjectValueRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("afcb727c-510c-2fb4-ea49-5a2668e75f3c");
			Name = "ForecastObjectValueRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,88,75,111,219,56,16,62,187,64,255,3,235,189,200,128,161,96,247,152,198,46,156,39,188,216,54,217,58,109,15,139,61,48,210,216,214,86,150,92,146,74,107,20,254,239,59,124,41,148,68,250,209,228,146,152,212,188,231,155,225,144,5,93,1,95,211,4,200,61,48,70,121,57,23,241,69,89,204,179,69,197,168,200,202,34,190,46,25,36,148,139,207,127,188,126,245,243,245,171,94,197,179,98,65,102,27,46,96,245,182,181,70,214,60,135,68,242,241,248,6,10,96,89,210,161,185,164,130,62,109,186,106,87,171,178,240,127,97,16,218,143,47,207,131,159,174,10,145,137,12,120,144,224,154,38,162,100,65,10,39,12,79,4,184,205,5,39,163,189,1,187,125,248,15,67,241,153,230,21,124,132,164,100,169,226,164,133,144,218,80,220,201,201,9,57,227,213,106,69,217,102,108,214,119,172,124,204,82,224,100,5,98,89,166,156,136,146,36,12,168,0,66,139,148,44,64,16,177,4,50,55,42,72,169,116,144,71,169,132,48,165,133,199,86,246,137,35,252,159,75,152,211,42,23,231,89,145,162,23,145,216,172,161,156,71,83,143,177,147,52,189,102,229,106,6,50,147,183,107,208,110,13,6,255,30,39,230,6,28,230,33,249,128,64,195,160,245,39,137,168,104,222,87,210,214,213,67,158,37,36,201,41,231,196,27,182,117,201,51,204,208,134,156,146,233,172,160,107,190,44,197,144,28,110,181,159,214,53,13,205,64,84,171,132,244,126,99,176,192,45,157,98,86,73,108,240,83,114,167,172,212,20,198,226,157,182,70,159,56,48,20,81,232,66,32,85,99,57,32,178,136,122,189,230,110,124,177,132,228,235,132,45,170,21,20,226,67,149,231,81,129,1,195,208,182,184,7,18,136,189,94,75,197,168,165,68,17,109,141,83,80,164,218,175,166,147,8,53,140,129,44,15,116,145,101,143,136,49,227,163,94,144,150,142,214,242,167,4,227,91,178,109,242,204,150,128,16,213,127,13,5,247,144,93,103,185,80,210,176,108,154,11,15,211,65,14,56,57,106,215,149,218,184,119,171,134,27,36,145,20,91,145,44,151,110,189,180,51,109,193,39,155,23,105,44,142,176,248,189,46,234,64,188,255,202,184,56,235,52,141,49,145,104,109,239,242,243,141,249,17,89,64,61,82,134,70,72,244,35,28,188,60,127,87,128,232,52,8,98,32,42,86,248,9,35,45,71,83,182,82,247,88,102,41,145,197,86,21,9,118,251,106,85,220,151,186,232,34,253,207,24,225,154,149,208,60,145,244,6,171,54,166,159,68,150,171,254,140,71,133,184,112,104,34,23,18,177,214,50,3,33,176,227,240,88,43,78,193,248,145,205,73,212,148,63,34,147,197,2,35,174,202,251,30,27,212,76,224,49,36,187,116,85,212,102,245,180,149,70,120,164,255,201,70,206,69,244,251,96,16,79,120,164,27,189,209,39,63,203,22,54,201,51,202,141,234,45,129,156,131,21,136,49,177,122,161,21,24,55,156,50,158,193,160,134,4,4,35,171,119,190,100,98,217,98,213,24,152,133,62,91,20,4,249,227,47,75,96,176,51,17,179,178,98,9,168,51,118,35,67,51,36,253,105,218,31,232,104,196,83,126,245,13,27,125,29,69,147,243,11,200,115,205,50,75,150,176,162,42,158,134,211,53,201,38,38,104,224,65,41,106,119,39,29,198,221,129,49,209,117,141,124,79,11,186,0,70,176,53,119,246,70,173,198,168,135,142,38,145,118,204,253,208,16,133,50,60,146,101,81,76,213,192,144,192,185,10,240,81,217,48,209,244,150,2,161,222,221,23,174,76,215,95,213,122,8,240,111,168,164,128,239,164,243,45,114,35,16,20,192,171,7,245,67,127,71,113,49,22,141,73,220,126,203,44,64,134,126,255,135,164,172,68,173,162,217,38,165,170,26,54,218,224,102,218,189,120,59,170,163,135,139,220,204,117,38,116,1,161,182,162,37,67,154,241,117,78,55,79,30,155,110,160,34,137,103,143,60,228,46,93,154,102,59,136,175,126,64,82,9,148,76,83,96,17,83,255,200,104,108,59,157,157,51,49,246,209,133,26,78,59,230,24,166,97,215,20,59,193,108,155,1,54,50,125,81,236,8,39,33,165,83,121,32,107,171,137,53,0,7,57,57,181,119,237,232,4,216,196,183,171,206,184,173,225,56,149,116,90,184,42,14,37,80,81,159,221,84,25,230,193,244,36,75,237,104,28,106,57,31,97,126,156,168,154,161,43,235,14,111,88,101,122,168,32,77,221,149,162,119,14,149,162,63,116,165,40,210,160,136,20,18,196,93,62,222,213,179,141,32,3,77,43,175,139,230,55,152,41,28,145,53,117,239,93,64,163,206,252,56,234,166,222,48,158,26,112,196,87,171,181,216,104,84,122,64,185,227,36,169,187,207,142,234,125,102,49,154,227,180,158,83,26,167,41,98,213,1,106,227,68,13,195,240,153,18,59,32,122,166,60,31,186,159,41,178,131,208,167,81,49,8,166,224,96,120,200,248,210,133,152,51,235,89,52,105,193,187,231,146,224,208,238,27,242,101,183,50,3,162,239,48,234,57,232,52,176,52,113,149,23,229,67,162,170,60,113,231,172,125,25,168,135,63,180,132,253,89,102,197,113,35,139,71,149,55,224,182,128,227,219,151,172,136,95,27,90,173,41,122,94,126,65,244,171,48,218,139,201,29,101,248,5,35,201,155,17,213,130,167,41,31,212,134,76,138,244,5,42,198,9,69,211,0,95,70,167,233,192,41,177,55,13,10,123,66,113,148,40,223,53,110,153,234,182,209,160,93,112,191,100,119,160,25,29,18,186,218,176,122,34,177,69,227,185,218,54,110,112,123,235,217,204,28,123,186,188,91,210,138,204,78,251,7,221,41,226,107,124,130,123,254,253,192,250,210,48,32,246,25,252,46,150,108,135,188,44,61,61,115,236,123,149,33,102,210,36,52,77,235,49,23,159,60,253,0,8,188,212,168,157,181,204,50,145,111,102,163,62,151,207,79,253,177,21,66,212,58,62,59,81,52,1,22,149,203,254,88,167,123,72,190,227,205,144,208,60,71,163,190,85,25,131,148,36,186,147,214,54,32,2,213,6,74,47,171,60,37,15,64,214,12,56,94,99,144,88,177,203,135,218,2,126,8,165,130,171,247,91,116,2,216,169,185,253,76,211,161,126,41,147,63,156,161,112,72,44,52,37,204,117,125,57,174,63,121,97,158,168,212,227,193,121,149,127,69,232,214,119,9,245,2,167,28,71,37,161,209,36,43,16,102,246,36,153,170,133,255,60,193,114,18,101,212,247,167,165,190,242,35,214,162,190,245,162,143,253,209,113,74,46,173,91,242,183,117,172,63,80,167,145,175,204,180,117,246,50,98,166,162,237,14,52,97,189,237,126,25,39,199,1,72,5,113,39,108,230,78,193,33,224,212,10,145,34,151,29,62,93,105,124,44,239,111,120,223,199,135,94,70,31,114,32,229,220,154,119,118,98,105,156,236,78,175,106,210,192,85,210,155,243,107,247,81,213,53,211,230,95,23,69,240,217,89,125,182,157,209,229,15,179,52,180,24,78,109,211,72,91,165,183,26,150,141,26,182,237,127,153,116,158,61,119,116,34,220,221,254,15,59,64,11,116,217,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("afcb727c-510c-2fb4-ea49-5a2668e75f3c"));
		}

		#endregion

	}

	#endregion

}

