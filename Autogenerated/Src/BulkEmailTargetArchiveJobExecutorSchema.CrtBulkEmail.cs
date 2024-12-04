﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailTargetArchiveJobExecutorSchema

	/// <exclude/>
	public class BulkEmailTargetArchiveJobExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailTargetArchiveJobExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailTargetArchiveJobExecutorSchema(BulkEmailTargetArchiveJobExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4709ab3d-141d-7767-6071-db3a4e280825");
			Name = "BulkEmailTargetArchiveJobExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,87,219,110,219,70,16,125,86,128,252,195,66,9,2,10,101,136,20,137,251,224,196,46,34,75,110,85,196,137,97,169,237,67,96,24,43,114,36,111,67,145,194,114,169,88,49,244,239,157,189,145,187,188,216,70,235,7,75,123,153,219,153,51,179,163,140,110,160,216,210,24,200,2,56,167,69,190,18,209,89,158,173,216,186,228,84,176,60,123,254,236,254,249,179,65,89,176,108,77,46,243,52,221,191,175,150,243,125,33,96,211,92,163,120,154,66,44,101,139,232,55,200,128,179,184,190,227,90,225,208,183,31,77,198,245,145,220,64,213,115,16,2,151,5,57,105,94,246,252,141,156,171,181,142,117,154,47,105,122,124,124,150,111,54,120,231,83,190,94,227,54,158,227,141,23,28,214,40,72,206,82,90,20,199,100,92,166,223,166,27,202,210,5,229,107,16,31,121,124,203,118,240,71,190,156,222,65,92,138,156,43,161,109,185,76,89,76,98,41,243,184,8,57,38,51,79,195,0,65,197,255,181,109,4,75,208,76,160,253,75,206,118,84,128,62,223,234,5,137,229,57,41,4,151,193,104,253,248,109,65,151,41,124,198,12,34,38,67,218,218,29,190,239,85,49,6,113,206,120,33,60,13,227,233,194,184,174,206,84,238,20,166,15,43,154,3,238,36,61,154,244,225,83,85,249,74,124,84,31,144,156,212,64,163,92,82,173,30,16,185,66,191,120,82,44,242,75,158,199,80,20,103,121,153,9,41,205,187,14,30,80,100,226,156,200,131,42,11,106,217,37,196,208,200,21,8,190,183,246,222,122,151,144,3,2,89,197,129,38,121,150,238,201,12,137,74,110,82,252,119,66,240,235,5,205,232,26,56,86,149,144,12,6,30,12,47,16,31,116,99,56,82,122,94,64,150,104,70,249,244,58,103,144,38,125,220,234,102,47,39,55,9,21,212,174,60,55,101,20,55,43,201,145,75,172,238,60,249,92,110,150,192,191,172,38,116,95,180,47,50,97,114,63,103,63,192,59,198,126,194,226,61,185,217,170,79,239,8,11,66,192,29,74,115,141,150,90,181,117,23,138,94,143,120,241,103,1,28,53,100,186,41,145,155,210,91,235,38,208,11,221,5,136,219,188,23,59,147,176,93,206,18,242,37,83,153,13,172,235,177,254,12,149,167,42,140,153,69,34,36,211,187,24,182,202,29,176,223,70,68,118,218,193,32,48,130,95,107,90,95,19,90,144,201,216,46,71,191,70,87,216,100,151,52,254,182,224,52,43,168,10,36,208,28,24,72,190,68,127,83,158,157,231,124,67,69,160,54,7,195,175,61,121,142,38,144,130,0,179,252,4,59,72,35,50,229,28,139,233,251,45,75,129,84,141,165,201,148,136,88,47,136,168,221,136,200,144,252,164,109,190,28,54,203,236,152,220,219,232,58,43,240,250,224,74,87,141,142,8,217,24,72,134,157,193,209,208,238,131,90,156,188,28,86,72,227,117,31,250,67,52,12,29,204,21,100,7,63,169,42,155,6,143,192,102,197,197,103,78,87,16,184,237,42,108,55,212,176,183,66,76,154,186,20,54,85,180,187,107,216,207,249,71,99,169,77,153,222,85,228,37,143,193,209,109,246,133,74,175,179,47,25,92,209,64,91,182,184,92,114,216,82,14,166,169,169,196,4,45,189,77,89,67,84,93,247,145,166,53,4,136,245,201,41,81,140,94,1,119,157,110,107,108,184,56,10,53,103,188,118,209,15,200,44,99,130,209,20,251,81,197,161,42,209,198,43,236,184,186,61,69,191,211,44,73,225,67,85,177,167,193,72,27,139,116,189,215,253,60,36,65,197,172,176,85,242,134,182,42,72,219,43,170,30,209,188,92,51,212,130,229,181,81,244,174,49,22,201,71,225,47,154,150,16,52,250,91,232,60,199,120,113,230,170,193,82,248,249,13,254,89,27,61,140,37,39,58,224,255,98,178,57,75,104,237,104,248,237,47,71,214,108,31,163,255,151,221,230,228,81,25,126,119,116,212,207,140,78,58,155,106,137,111,97,67,235,130,216,42,133,170,242,12,117,118,148,27,170,219,121,64,126,44,216,6,162,69,158,208,125,244,49,81,247,131,215,142,172,193,192,37,46,10,102,240,221,190,129,193,112,217,217,185,53,61,49,32,121,119,194,20,2,148,239,63,104,119,67,146,47,255,65,88,78,141,111,131,251,142,185,49,116,130,34,7,83,67,247,221,195,81,72,26,79,249,129,84,2,206,16,20,122,8,32,196,120,225,208,143,119,119,181,187,237,105,238,192,238,245,167,250,192,226,175,103,253,160,126,40,73,61,11,34,166,13,182,68,211,172,40,57,76,198,245,86,48,178,170,252,132,120,79,241,137,163,85,39,111,224,141,74,38,123,61,207,109,80,11,155,212,15,44,73,26,220,9,236,254,200,247,197,1,251,218,104,80,116,212,185,130,196,100,207,28,37,185,141,104,80,91,142,230,8,161,232,152,29,100,118,124,53,18,55,55,186,200,62,140,237,236,52,211,226,81,161,50,224,120,33,127,141,177,110,55,252,144,187,103,5,137,17,70,62,122,210,221,215,125,0,29,244,152,19,60,93,213,41,121,67,94,189,106,233,147,251,198,255,131,67,247,199,7,203,82,254,148,52,181,161,190,235,210,176,207,98,99,124,109,182,188,217,3,165,143,173,12,243,128,69,91,181,168,70,13,32,132,173,105,24,111,117,190,143,222,216,98,150,221,49,234,93,127,19,247,254,5,211,227,112,37,108,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4709ab3d-141d-7767-6071-db3a4e280825"));
		}

		#endregion

	}

	#endregion

}

