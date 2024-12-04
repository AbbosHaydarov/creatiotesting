﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesRuleDTOSchema

	/// <exclude/>
	public class DuplicatesRuleDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesRuleDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesRuleDTOSchema(DuplicatesRuleDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78a9c2f7-93f5-4f2a-9402-48a5e04d19cd");
			Name = "DuplicatesRuleDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,85,91,111,218,48,20,126,166,82,255,131,215,77,37,76,85,52,109,15,211,96,45,106,105,213,50,237,82,13,170,189,77,50,201,1,188,133,56,179,29,58,132,242,223,119,98,199,73,8,73,161,60,236,5,156,227,239,124,231,126,28,210,5,200,136,122,64,198,32,4,149,124,170,220,1,15,167,108,22,11,170,24,15,221,107,240,227,40,96,158,254,58,62,90,31,31,181,98,201,194,25,25,173,164,130,69,175,242,141,218,65,0,94,10,150,238,45,132,32,152,183,133,25,195,95,85,8,239,148,138,30,20,11,152,90,145,115,11,249,1,19,183,116,129,104,196,191,20,48,67,98,50,8,168,148,93,114,157,57,6,114,4,74,33,213,245,248,155,198,69,241,4,47,136,151,194,26,80,45,12,4,127,115,202,123,193,35,16,138,1,242,222,107,117,115,159,81,73,37,180,255,222,28,22,244,43,38,141,172,201,12,84,143,200,244,39,41,33,39,156,7,100,40,47,49,5,203,29,168,7,9,151,106,68,159,128,101,102,55,106,128,9,142,23,161,172,234,232,96,32,244,77,60,155,193,125,1,53,231,126,26,153,96,75,204,68,22,154,249,176,70,62,209,37,29,121,130,69,106,164,5,55,161,199,125,112,178,219,37,13,98,232,144,243,139,84,179,85,170,140,219,160,167,21,72,191,159,209,187,55,139,72,173,58,189,125,29,221,46,1,95,98,135,50,63,247,119,204,141,61,167,67,210,166,108,181,150,84,16,57,193,22,10,225,145,152,187,171,152,5,62,8,231,100,125,146,154,70,144,156,184,151,81,132,230,157,87,39,237,162,156,237,110,123,221,16,72,1,234,36,237,179,90,30,91,238,118,119,109,143,110,225,30,30,63,243,71,244,162,147,212,171,231,125,128,250,249,249,57,4,117,253,129,92,117,226,36,73,44,133,0,21,139,16,83,86,50,165,111,234,187,201,72,43,194,198,137,252,30,7,176,99,28,115,200,51,103,241,54,102,62,25,250,187,134,102,143,89,181,72,160,194,155,239,143,79,29,255,127,59,96,51,97,87,220,95,105,7,244,225,160,29,240,196,104,105,151,110,254,196,52,144,14,159,252,194,61,78,240,207,14,24,155,146,84,74,206,113,196,226,32,176,98,219,72,83,212,2,211,90,73,62,144,126,181,220,111,113,64,157,173,38,232,32,111,175,80,130,41,141,131,108,12,7,124,17,81,1,2,245,180,103,184,115,172,232,163,41,200,5,62,82,90,161,96,16,32,241,27,85,106,169,220,44,196,162,228,103,53,142,186,165,201,183,19,147,177,102,135,211,211,29,252,149,198,58,51,249,170,181,85,129,30,104,209,182,102,109,60,246,178,153,59,239,89,44,113,13,129,189,110,212,47,186,185,158,32,191,223,216,64,121,59,103,141,165,163,172,119,191,12,51,201,236,103,230,205,87,183,228,76,142,127,81,208,90,153,205,215,19,102,242,93,184,61,38,44,84,228,22,212,29,149,243,65,250,68,216,73,136,67,172,159,247,27,112,55,25,119,210,86,156,103,40,76,212,208,119,55,212,76,22,90,37,132,147,159,95,147,119,31,222,119,200,79,82,234,210,60,146,126,105,187,109,82,146,46,121,179,47,111,117,237,149,216,43,87,7,219,200,87,101,193,109,69,135,114,14,237,11,251,252,84,22,143,235,1,101,216,106,39,19,138,238,166,198,80,178,14,183,116,165,237,184,255,35,155,252,3,250,28,220,67,165,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78a9c2f7-93f5-4f2a-9402-48a5e04d19cd"));
		}

		#endregion

	}

	#endregion

}

