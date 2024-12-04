﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadMergeProcessorsSchema

	/// <exclude/>
	public class LeadMergeProcessorsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadMergeProcessorsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadMergeProcessorsSchema(LeadMergeProcessorsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("818147d6-5cf4-4315-a836-173de5230d06");
			Name = "LeadMergeProcessors";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,111,218,64,16,61,131,196,127,24,185,23,144,44,115,79,128,3,33,69,168,73,148,150,168,151,170,170,134,221,193,93,201,94,91,251,145,214,138,248,239,157,93,12,152,134,82,201,182,188,51,243,230,189,249,88,208,88,146,173,81,16,188,144,49,104,171,173,203,238,42,189,85,185,55,232,84,165,7,253,183,65,191,231,173,210,57,172,27,235,168,188,253,235,204,241,69,65,34,4,219,108,73,154,140,18,167,152,110,90,67,217,98,254,79,215,71,20,174,50,138,44,71,112,204,7,67,57,167,132,187,2,173,189,129,7,66,185,118,152,147,125,36,147,211,179,225,167,18,100,109,101,56,152,159,241,120,12,19,235,203,18,77,51,107,207,1,180,210,17,6,101,128,129,36,135,170,128,218,80,125,128,103,112,64,143,59,240,111,11,218,162,47,220,92,105,201,98,135,174,169,169,218,14,87,11,95,23,74,160,35,187,22,63,169,196,119,106,70,41,60,113,83,167,201,21,197,201,232,59,83,212,126,195,169,64,132,2,175,213,7,55,48,71,75,209,219,58,91,79,10,255,215,195,68,97,130,239,250,19,13,143,200,19,52,64,218,41,215,128,141,25,32,236,68,118,132,116,155,114,144,108,157,9,3,188,143,176,61,111,168,25,222,32,39,119,11,59,152,66,44,63,217,143,242,50,119,171,176,29,12,182,11,116,153,55,90,106,52,88,70,117,211,68,30,203,78,102,167,22,128,56,174,98,54,25,199,248,203,240,188,42,36,233,47,36,42,35,147,217,146,79,96,226,1,86,242,42,80,110,238,127,147,240,188,168,204,59,63,252,131,210,214,161,22,116,198,218,54,235,181,82,242,80,236,240,65,89,55,89,122,37,103,112,42,33,133,96,129,174,168,20,58,217,229,145,116,4,113,150,189,87,52,60,4,222,135,231,192,102,185,223,154,126,193,39,106,190,98,225,217,168,204,100,63,163,180,157,213,108,152,124,246,88,168,109,195,107,228,188,253,17,183,233,201,151,27,50,73,10,231,206,108,101,23,202,214,5,54,36,147,81,184,176,189,222,134,55,48,59,84,209,149,126,174,250,36,149,147,198,21,8,10,142,66,91,227,74,159,241,181,28,59,254,240,27,238,62,105,185,191,254,131,254,238,15,205,232,235,215,164,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("818147d6-5cf4-4315-a836-173de5230d06"));
		}

		#endregion

	}

	#endregion

}

