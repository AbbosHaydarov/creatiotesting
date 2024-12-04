﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileTimelineDataLoaderSchema

	/// <exclude/>
	public class FileTimelineDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileTimelineDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileTimelineDataLoaderSchema(FileTimelineDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e1344f7-2bc8-4e0c-97e6-e13bafa5bbce");
			Name = "FileTimelineDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0f0b57ce-3155-4876-a7bb-8a901e434b75");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,85,77,79,219,64,16,61,27,137,255,48,117,47,142,26,57,119,66,34,65,129,10,9,42,4,180,151,170,170,182,246,36,172,100,239,134,253,160,138,16,255,189,179,222,93,99,59,14,180,151,56,158,125,111,230,237,124,89,176,26,245,134,21,8,247,168,20,211,114,101,242,207,82,172,248,218,42,102,184,20,249,61,175,177,226,2,15,15,158,15,15,18,171,185,88,195,221,86,27,172,9,88,85,88,56,148,206,191,160,64,197,139,121,139,233,250,83,184,207,158,159,11,195,13,71,189,23,112,193,10,35,149,71,16,230,163,194,53,5,132,11,94,97,148,118,198,12,187,146,172,68,213,64,102,179,25,28,107,91,215,76,109,151,225,61,66,161,36,44,84,13,24,86,82,53,126,242,72,154,117,88,63,206,112,197,108,101,78,185,40,73,86,102,182,27,148,171,236,114,55,232,100,10,95,41,141,176,128,148,18,227,28,166,147,159,228,97,99,127,87,188,128,162,98,90,239,209,11,71,48,226,144,184,148,107,250,109,111,75,37,209,70,89,151,9,125,4,55,141,99,143,8,65,198,221,103,223,52,42,226,10,95,37,176,189,215,9,184,138,38,201,0,180,24,192,92,101,146,151,160,7,69,233,37,245,245,221,40,185,65,229,234,56,80,167,248,19,51,56,118,73,248,133,250,113,215,60,239,92,106,140,117,62,70,10,23,89,163,9,255,18,190,130,108,60,0,44,22,32,108,85,197,219,39,201,62,28,8,252,51,30,111,144,215,73,35,186,73,146,123,40,52,86,137,183,238,23,144,218,233,5,79,218,43,226,137,85,22,59,172,255,169,132,146,134,20,98,25,139,17,94,97,80,241,193,235,51,80,34,231,240,78,160,107,52,15,178,28,212,123,56,122,141,193,93,69,15,38,208,141,222,42,140,222,238,236,121,203,134,41,86,131,160,209,90,164,232,214,196,54,93,250,103,126,60,107,14,199,177,69,179,191,210,101,27,209,141,59,120,107,143,25,218,236,138,107,115,124,42,173,40,35,163,89,74,219,101,163,220,21,35,139,7,13,202,159,130,151,50,109,47,118,139,143,22,181,241,219,51,132,139,77,22,100,95,51,218,155,202,243,105,121,218,90,196,197,113,139,133,84,229,101,153,206,187,248,232,154,166,219,180,29,57,48,62,195,152,167,187,226,1,107,230,108,233,212,55,152,71,125,119,221,68,176,144,141,174,160,87,74,203,168,41,87,92,75,113,79,187,143,72,25,23,102,226,195,246,207,242,243,71,203,42,223,163,254,2,79,76,129,66,77,251,147,120,163,51,148,183,201,141,137,12,41,243,14,220,0,247,251,50,239,202,188,102,130,173,201,201,5,109,231,75,250,22,157,110,157,240,236,205,107,193,39,72,253,118,134,15,131,29,224,165,230,39,101,121,203,196,26,179,119,20,119,203,208,109,137,184,81,58,49,223,73,117,171,41,228,60,233,184,11,252,208,11,131,131,136,223,219,82,255,82,225,228,78,42,211,99,133,96,125,251,52,160,189,69,191,194,130,33,158,159,88,90,9,84,177,93,127,195,147,200,160,108,226,24,190,111,143,104,223,122,157,248,193,16,182,111,219,65,161,133,252,146,13,219,216,87,248,141,111,153,183,246,141,47,0,127,1,157,8,197,63,33,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e1344f7-2bc8-4e0c-97e6-e13bafa5bbce"));
		}

		#endregion

	}

	#endregion

}

