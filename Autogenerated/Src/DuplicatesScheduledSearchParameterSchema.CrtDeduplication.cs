﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesScheduledSearchParameterSchema

	/// <exclude/>
	public class DuplicatesScheduledSearchParameterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesScheduledSearchParameterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesScheduledSearchParameterSchema(DuplicatesScheduledSearchParameterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfbece73-63e6-4e04-8ef0-170a9c288e91");
			Name = "DuplicatesScheduledSearchParameter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,86,77,111,218,64,16,61,59,82,254,195,200,185,128,20,65,155,86,81,68,48,85,5,77,219,67,210,168,70,205,121,99,143,193,42,222,181,246,163,17,138,248,239,157,221,181,193,144,0,110,212,3,33,251,245,222,219,153,121,179,112,86,160,42,89,130,48,69,41,153,18,153,238,141,5,207,242,153,145,76,231,130,247,38,152,154,114,145,39,110,116,122,242,124,122,18,24,149,243,25,196,75,165,177,184,94,143,155,0,18,123,95,184,206,117,142,138,54,208,150,126,191,15,67,101,138,130,201,229,168,26,199,37,38,121,70,91,64,207,17,82,182,4,145,185,127,159,16,127,247,234,67,253,198,169,210,60,146,18,64,110,10,136,145,201,100,62,97,203,31,217,3,237,135,1,24,53,23,82,211,54,171,241,5,163,155,248,206,83,123,19,162,228,66,207,73,181,165,121,201,19,220,9,142,16,193,187,115,39,254,24,214,173,224,164,126,15,148,95,36,176,139,118,96,83,131,106,63,90,181,74,112,31,219,193,61,96,202,15,1,174,215,9,242,170,165,194,185,145,135,36,86,203,4,248,254,178,29,226,141,204,247,227,249,69,66,251,208,50,130,49,211,70,238,199,171,151,9,241,178,101,16,99,115,32,193,126,209,222,246,226,138,198,43,135,120,38,113,70,126,129,241,130,41,53,128,73,101,33,84,113,50,39,67,45,48,245,245,123,207,36,57,80,163,220,235,146,159,88,74,84,200,181,2,6,101,189,29,50,33,33,169,140,106,221,87,155,148,212,170,154,2,148,227,56,100,165,196,234,107,37,207,187,202,126,234,187,221,75,81,162,180,30,31,192,189,131,59,16,204,175,72,23,32,205,202,126,123,93,214,242,106,79,80,43,121,187,38,95,143,21,60,195,12,245,181,197,187,134,85,91,98,86,83,235,188,192,195,212,83,218,17,151,140,87,156,118,248,175,156,218,147,218,150,198,41,140,182,189,173,5,216,36,21,236,176,4,165,93,106,189,0,155,153,130,221,177,215,101,156,33,79,125,90,170,113,149,163,91,212,115,145,182,73,208,88,162,171,30,6,57,87,154,113,122,18,170,118,60,84,136,144,72,204,162,240,120,161,132,253,17,60,50,69,197,71,236,116,219,170,199,167,212,180,233,61,216,231,33,55,227,138,219,69,42,10,55,229,188,131,239,158,149,101,56,154,146,48,15,233,172,208,44,127,31,224,141,85,72,186,127,202,134,125,55,185,97,148,72,173,128,171,209,231,255,120,103,119,218,241,208,233,150,183,233,143,72,91,45,102,171,0,72,120,210,194,158,85,246,110,164,40,60,100,199,162,4,129,31,192,17,254,46,56,111,7,121,6,157,35,91,33,138,128,155,197,162,62,18,120,213,110,206,254,20,8,108,255,163,191,127,152,117,220,218,56,209,49,9,61,178,204,116,89,98,58,22,11,83,240,95,108,97,112,56,161,237,246,248,168,19,110,76,24,118,61,79,77,140,79,109,226,83,169,109,120,57,218,210,23,65,77,214,187,205,61,189,63,17,124,90,119,130,221,149,129,35,175,87,59,27,184,222,55,97,228,121,3,223,158,52,26,183,166,98,164,246,157,118,207,155,194,92,99,139,160,179,211,246,186,111,9,158,255,53,68,161,179,160,225,54,79,163,151,188,45,51,190,51,217,188,56,164,169,240,71,45,98,216,245,101,224,178,244,122,119,170,158,200,198,228,234,47,186,213,78,54,136,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfbece73-63e6-4e04-8ef0-170a9c288e91"));
		}

		#endregion

	}

	#endregion

}

