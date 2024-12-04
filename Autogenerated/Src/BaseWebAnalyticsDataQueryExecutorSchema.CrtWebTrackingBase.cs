﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseWebAnalyticsDataQueryExecutorSchema

	/// <exclude/>
	public class BaseWebAnalyticsDataQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseWebAnalyticsDataQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseWebAnalyticsDataQueryExecutorSchema(BaseWebAnalyticsDataQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93745576-afc4-4fdf-bb3e-c613b85aa0fd");
			Name = "BaseWebAnalyticsDataQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,88,91,111,219,54,20,126,118,129,254,7,214,5,10,27,8,228,247,54,118,144,139,83,4,104,155,44,206,182,199,129,150,142,98,174,178,228,144,84,83,163,237,127,223,225,77,38,41,201,118,183,2,243,131,109,82,231,250,157,11,15,85,210,53,136,13,77,129,60,0,231,84,84,185,76,46,171,50,103,143,53,167,146,85,229,203,23,223,94,190,24,212,130,149,143,100,177,21,18,214,239,162,53,210,23,5,164,138,88,36,239,161,4,206,210,22,205,7,86,62,237,54,125,93,235,117,85,118,63,225,208,183,159,92,93,244,62,154,151,146,73,6,2,9,144,228,53,135,71,52,140,92,22,84,136,183,228,130,10,248,19,150,231,37,45,182,146,165,226,138,74,250,91,13,124,59,255,10,105,45,43,174,153,38,147,9,57,21,245,122,77,249,118,102,215,138,147,164,74,10,145,21,17,27,72,89,190,37,41,7,133,18,121,134,37,161,78,40,201,80,42,201,43,78,228,10,121,170,82,210,84,90,22,6,89,226,52,76,60,21,155,122,89,176,148,208,165,144,92,81,27,77,71,152,59,192,240,224,119,227,232,53,131,34,67,79,239,56,251,66,37,152,135,27,179,32,104,109,86,149,197,150,252,46,128,99,152,75,19,54,242,87,29,172,13,116,131,215,80,102,70,106,168,2,9,209,202,58,69,253,168,200,88,110,40,98,224,244,134,71,222,128,114,42,0,145,225,144,79,135,7,125,28,78,102,10,178,54,102,102,103,67,57,93,147,18,243,120,58,12,221,24,206,110,80,51,45,49,185,171,60,86,27,34,160,116,156,78,180,40,45,217,134,227,160,109,163,8,200,208,128,49,81,181,51,24,68,240,146,105,68,167,114,121,240,99,63,232,119,188,218,0,87,137,173,98,91,73,228,132,108,15,234,63,229,122,55,188,27,167,38,78,151,104,57,157,245,36,80,167,97,186,62,183,68,164,43,88,83,29,55,85,80,143,32,117,217,28,52,165,169,16,252,81,213,111,196,45,180,180,79,74,216,55,37,235,29,57,0,231,71,144,171,170,183,78,124,161,58,222,215,172,144,192,177,184,202,236,210,212,243,77,102,246,70,61,180,187,166,72,114,189,33,92,54,124,161,220,53,5,43,118,234,72,146,219,252,97,187,129,211,30,153,179,209,56,185,102,92,200,91,126,5,57,173,11,57,50,140,42,4,70,248,160,197,58,255,186,225,32,132,50,164,128,92,122,75,167,54,249,16,236,235,108,28,12,88,78,70,49,195,148,148,117,81,56,71,6,3,14,178,230,232,32,45,132,238,213,248,65,220,189,39,145,132,100,247,87,249,169,4,238,177,87,145,36,230,9,162,89,175,75,171,117,240,230,77,228,74,64,149,220,81,14,165,196,8,83,179,125,150,232,196,64,101,67,27,188,225,145,146,26,190,155,108,56,182,60,223,191,255,63,94,221,67,14,232,87,10,191,204,41,199,55,54,161,251,97,127,85,224,195,252,124,21,197,221,6,55,32,178,50,244,55,118,121,160,233,138,140,84,170,231,113,57,176,242,200,116,223,241,96,226,55,202,149,76,134,141,134,55,197,211,85,149,177,86,235,155,118,206,231,142,93,115,190,121,52,65,98,155,111,75,164,56,253,222,125,160,125,120,24,188,7,185,0,202,211,149,121,34,142,232,34,162,170,121,10,150,254,164,167,216,9,136,167,125,125,166,11,170,64,176,197,201,58,136,102,170,35,48,52,53,52,36,84,113,162,13,248,215,152,180,149,253,34,92,44,0,145,173,7,225,179,121,138,192,149,240,124,216,133,81,227,124,87,9,168,196,15,177,118,73,167,146,210,53,242,105,104,228,46,49,213,54,43,235,168,207,118,86,152,107,236,132,138,195,70,123,133,209,18,212,170,14,87,184,231,89,54,234,140,87,44,162,51,63,92,49,246,248,228,43,49,255,93,135,242,115,211,82,117,229,218,251,154,101,81,170,243,106,125,124,74,29,113,96,247,247,28,87,66,202,136,228,129,111,241,52,18,16,54,212,179,228,158,61,174,188,6,45,226,99,125,124,166,78,49,108,212,72,253,7,45,106,56,75,30,170,133,158,120,70,227,19,82,213,146,120,86,221,100,97,217,54,219,71,21,34,185,84,151,24,152,139,167,235,138,171,9,183,141,144,205,91,36,241,49,177,35,220,52,154,7,19,159,253,35,222,138,30,113,196,192,100,113,19,233,197,86,157,64,129,18,181,97,93,80,130,49,71,250,74,110,100,148,90,98,36,84,89,114,94,20,254,9,39,70,246,113,99,117,98,31,36,232,225,28,203,114,132,241,80,27,99,111,112,82,5,240,10,60,218,249,87,38,164,184,192,0,202,149,165,199,160,200,213,152,224,1,107,215,58,54,254,65,91,47,13,96,173,81,201,154,106,132,59,245,97,222,139,103,38,85,203,176,178,111,121,6,252,138,241,240,46,129,69,163,110,162,225,195,228,92,164,56,232,98,118,188,117,67,128,239,137,74,86,139,186,149,173,1,63,51,42,46,182,200,237,32,195,207,18,211,225,243,187,61,202,174,224,63,105,83,236,63,163,238,83,85,130,83,148,153,250,120,219,197,108,15,232,176,20,208,176,99,110,87,222,117,224,240,213,234,94,139,22,174,201,238,189,232,31,115,107,69,27,135,179,240,90,244,164,147,136,217,138,9,174,166,45,246,166,218,135,179,133,83,221,24,195,50,28,133,213,22,111,11,49,16,137,217,233,196,253,235,185,106,29,238,152,166,133,216,134,216,219,104,85,52,78,76,119,14,58,215,113,145,57,244,158,193,133,37,221,153,133,119,223,38,26,4,12,194,152,86,21,207,196,79,5,103,161,27,137,147,224,199,104,15,170,187,11,183,1,98,7,151,121,219,16,128,110,222,55,124,97,92,214,180,176,128,135,179,81,188,215,13,175,223,159,213,125,122,174,91,105,171,195,239,6,21,221,200,253,169,4,201,85,53,219,213,142,104,137,165,185,35,105,13,176,209,84,104,117,91,37,118,229,132,234,147,221,147,231,153,210,228,69,235,140,245,78,240,174,137,213,187,181,220,100,201,141,248,84,201,249,122,35,183,209,205,33,56,135,149,35,157,153,107,237,61,105,29,176,157,158,132,50,187,102,21,199,213,21,198,240,240,60,233,62,246,110,55,250,245,170,243,228,190,122,22,183,121,46,240,165,137,137,214,226,51,219,224,230,101,85,151,210,206,192,119,120,238,210,101,1,110,219,82,246,80,53,237,22,201,220,222,2,148,141,187,70,124,89,115,117,177,142,56,209,246,12,95,184,86,165,62,11,221,172,124,197,52,15,150,213,169,121,81,131,67,203,242,111,20,132,87,57,191,79,119,247,101,179,27,110,254,248,7,83,223,78,121,171,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93745576-afc4-4fdf-bb3e-c613b85aa0fd"));
		}

		#endregion

	}

	#endregion

}

