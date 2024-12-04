﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesScheduledSearchParameterEntityListenerSchema

	/// <exclude/>
	public class DuplicatesScheduledSearchParameterEntityListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesScheduledSearchParameterEntityListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesScheduledSearchParameterEntityListenerSchema(DuplicatesScheduledSearchParameterEntityListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c4fa966-260a-42c6-97f5-2e5d7a12eadb");
			Name = "DuplicatesScheduledSearchParameterEntityListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,86,223,111,218,48,16,126,102,82,255,135,91,42,77,65,171,194,59,107,43,181,20,38,166,254,152,198,126,60,76,123,112,146,35,120,75,108,100,59,172,104,234,255,190,179,29,83,130,154,194,42,237,129,128,99,223,119,223,221,125,231,67,176,10,245,146,101,8,159,81,41,166,229,220,36,35,41,230,188,168,21,51,92,138,228,10,243,122,89,242,204,173,142,94,253,57,122,213,171,53,23,5,204,214,218,96,245,110,179,222,6,80,152,140,133,225,134,163,222,123,32,25,175,80,152,238,115,19,150,25,169,90,72,69,41,83,86,14,135,35,89,85,68,241,90,22,5,189,166,125,58,113,172,176,32,166,48,42,153,214,67,184,106,200,163,158,101,11,10,165,196,124,134,76,101,139,25,26,67,70,218,209,88,95,115,10,70,160,114,16,131,193,0,78,117,93,85,76,173,207,155,181,131,131,165,146,43,158,163,222,134,117,104,31,153,162,76,26,84,128,14,15,208,5,5,11,38,242,146,220,36,1,118,176,131,123,170,17,89,169,37,100,10,231,103,209,37,211,232,25,185,172,4,90,17,12,172,193,247,39,182,98,27,87,197,110,201,61,156,65,212,73,44,234,255,32,132,101,157,210,54,100,46,154,206,220,108,140,218,201,129,33,116,240,35,100,18,6,61,31,211,47,133,54,140,82,48,132,143,138,175,200,137,223,95,250,5,100,118,31,180,81,182,158,151,117,249,107,172,91,74,155,32,51,181,194,16,150,59,49,107,157,136,124,189,123,199,40,114,239,180,205,96,194,177,204,187,220,19,55,67,121,80,200,114,41,202,53,76,73,67,96,63,103,246,121,195,4,43,80,37,239,209,88,109,81,146,163,182,235,254,30,223,55,104,22,114,159,243,84,202,18,166,187,117,250,202,74,158,199,251,75,3,249,222,35,125,176,221,218,235,41,164,84,138,3,12,18,191,254,204,41,233,175,207,192,126,207,150,76,36,55,92,16,173,26,29,90,239,205,155,195,161,174,216,90,91,168,205,234,110,254,13,241,87,114,43,5,218,126,238,61,60,153,154,149,228,57,124,89,230,244,106,87,208,31,100,26,123,5,54,173,118,226,19,201,53,237,204,22,178,46,243,75,252,132,4,164,12,230,33,5,124,14,241,107,127,62,249,162,81,145,60,5,102,238,130,163,34,79,117,35,183,177,96,41,197,18,63,47,200,126,64,109,50,235,2,177,145,208,211,168,117,216,92,49,5,41,1,181,96,66,190,20,41,205,221,41,254,122,91,91,26,167,211,203,206,227,231,177,7,237,9,252,237,155,75,213,214,240,66,21,117,69,129,197,81,221,10,43,58,129,39,195,237,91,233,6,118,251,203,72,44,247,75,49,25,81,31,25,156,40,89,249,202,196,222,117,112,213,157,4,154,46,37,33,60,86,246,96,97,61,222,122,193,139,45,241,211,34,0,82,108,71,159,29,208,68,155,98,63,23,71,248,245,47,145,4,226,94,56,254,73,6,217,2,226,241,125,134,75,235,1,240,126,227,159,174,162,100,172,148,220,189,141,146,173,18,129,118,62,232,203,79,55,26,64,26,82,68,1,25,141,162,2,243,4,162,38,154,222,91,136,38,140,19,47,48,146,110,66,151,172,45,73,4,168,159,50,77,172,154,238,27,190,15,91,109,187,255,254,115,243,166,233,113,63,123,228,138,230,59,13,81,223,228,119,98,42,72,160,84,165,88,166,63,73,163,228,86,228,168,78,192,75,233,98,110,199,144,157,53,164,116,13,24,178,145,210,32,74,182,140,131,85,144,67,247,229,209,220,30,253,96,65,141,212,24,61,60,203,211,35,190,140,102,176,253,255,44,175,92,67,189,140,101,176,125,57,203,57,253,149,105,211,220,81,136,127,219,126,73,239,254,2,238,247,120,20,135,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c4fa966-260a-42c6-97f5-2e5d7a12eadb"));
		}

		#endregion

	}

	#endregion

}

