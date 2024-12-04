﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysCultureUtilitiesSchema

	/// <exclude/>
	public class SysCultureUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysCultureUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysCultureUtilitiesSchema(SysCultureUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35f8ebef-8b39-4002-b651-4d41d56d3661");
			Name = "SysCultureUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,85,75,79,219,64,16,62,27,137,255,176,50,23,71,66,54,231,146,68,170,82,64,72,165,162,5,218,67,85,85,91,123,28,86,178,119,147,125,80,185,21,255,189,179,15,63,9,129,30,170,114,98,39,223,124,51,243,205,195,156,214,160,54,52,7,114,11,82,82,37,74,157,174,4,47,217,218,72,170,153,224,135,7,191,15,15,34,163,24,95,147,155,70,105,168,79,39,111,196,87,21,228,22,172,210,11,224,32,89,254,4,243,158,241,109,111,28,198,146,240,156,61,61,227,154,105,6,10,1,8,57,146,176,198,24,100,85,81,165,222,88,226,149,169,180,145,112,167,89,229,112,14,182,49,63,42,150,147,220,162,118,131,34,91,81,71,119,206,160,42,144,239,90,10,141,85,64,225,88,162,44,203,200,92,153,186,166,178,89,246,6,0,146,75,40,23,241,157,2,137,66,113,95,120,156,45,9,227,74,83,158,67,218,161,179,161,255,166,229,39,18,104,33,120,213,144,49,7,249,110,70,111,95,117,116,4,188,240,169,134,119,43,3,202,173,165,201,181,144,54,123,87,245,158,212,47,57,86,79,43,243,11,8,135,159,36,247,170,16,227,100,105,130,92,47,148,224,44,27,42,105,77,56,206,205,34,30,39,28,47,93,69,36,239,44,233,60,115,240,222,91,2,134,229,106,57,207,218,255,156,54,190,103,59,186,149,76,52,26,71,156,17,215,202,104,162,28,89,76,112,118,194,162,199,253,122,94,129,190,23,126,16,216,3,213,176,71,203,11,208,164,128,146,98,174,157,144,165,20,117,251,80,251,244,107,235,126,55,33,48,156,109,13,176,2,112,232,75,6,50,157,72,228,179,34,23,134,21,54,129,224,30,244,58,199,232,189,122,73,171,139,3,75,200,133,44,46,11,84,197,190,211,179,122,163,27,167,72,244,64,37,81,157,219,153,218,34,198,78,135,91,188,230,38,191,135,154,126,52,32,155,100,162,112,58,68,92,81,78,215,32,143,73,220,167,16,207,250,8,172,192,11,97,106,219,150,81,176,244,109,17,126,73,198,246,79,66,104,79,141,247,68,99,63,172,130,30,249,1,231,46,153,205,78,137,99,31,187,157,179,74,131,180,11,142,127,150,124,66,187,194,197,211,224,81,95,152,190,191,182,163,9,214,37,241,198,149,168,113,92,153,18,252,182,217,224,249,217,26,90,97,85,65,234,248,152,224,190,1,6,223,165,93,56,85,79,106,196,2,188,86,253,149,156,138,25,8,89,73,146,167,132,120,9,13,215,100,73,78,218,166,186,200,37,147,42,16,143,67,6,183,175,39,223,60,107,52,104,255,192,201,230,101,139,12,13,248,140,151,1,230,118,60,150,73,219,174,212,106,29,114,195,221,113,84,118,30,187,129,26,110,213,223,237,137,114,31,5,162,64,107,60,251,255,109,93,110,66,252,110,95,66,129,137,245,154,77,62,70,163,175,98,58,240,182,82,58,253,166,125,197,209,105,103,119,180,20,175,62,68,47,221,244,29,250,254,11,41,141,59,206,187,149,124,254,212,188,116,162,250,161,239,189,134,23,170,27,247,87,144,246,141,124,229,184,78,180,247,214,177,241,241,15,203,157,70,248,27,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35f8ebef-8b39-4002-b651-4d41d56d3661"));
		}

		#endregion

	}

	#endregion

}

