﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadPostProcessSchema

	/// <exclude/>
	public class LeadPostProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadPostProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadPostProcessSchema(LeadPostProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("73bc41cd-133a-489f-9525-2cbb0f0913f0");
			Name = "LeadPostProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,86,75,115,211,48,16,62,167,51,252,135,197,92,146,161,56,7,14,48,125,49,125,164,37,211,66,51,36,133,67,167,7,213,222,36,162,182,100,36,57,37,67,249,239,172,164,216,117,30,78,3,229,146,209,174,247,219,93,237,174,190,141,96,41,234,140,69,8,3,84,138,105,57,52,225,177,20,67,62,202,21,51,92,138,240,12,5,210,17,227,111,120,123,42,85,218,71,53,225,17,190,216,250,245,98,171,145,107,46,70,208,159,106,131,233,110,41,87,93,41,172,211,135,29,97,184,225,168,107,13,230,18,33,43,178,123,165,112,68,2,28,39,76,235,29,232,76,80,152,129,98,209,29,193,123,82,155,158,146,17,106,237,108,219,237,54,236,233,60,77,153,154,30,204,228,58,0,40,204,18,22,217,36,34,235,58,44,240,237,138,131,44,191,77,120,228,13,234,61,237,64,119,177,102,149,207,31,153,136,19,84,228,141,234,71,191,229,141,62,161,25,203,152,238,212,83,124,66,88,255,53,243,2,76,36,143,161,43,12,42,193,18,235,238,40,163,78,104,77,200,110,220,188,210,168,168,88,2,35,91,41,200,231,196,109,112,133,158,66,130,44,246,199,22,216,230,53,26,19,166,64,23,94,96,191,98,65,109,55,131,105,134,241,177,76,242,84,124,101,73,142,123,103,57,143,15,154,65,53,116,208,218,45,61,221,9,121,47,102,95,190,224,143,28,181,33,159,2,239,225,124,249,75,179,2,196,106,41,47,228,136,11,194,209,80,245,209,24,210,104,155,140,203,160,185,112,51,231,161,17,116,150,240,65,43,28,200,190,81,36,215,6,234,81,23,239,165,138,159,17,171,112,177,73,184,195,140,159,227,244,25,193,188,131,77,66,209,212,29,102,217,149,74,158,17,173,244,177,34,32,31,66,83,59,77,216,213,159,243,36,185,84,157,52,51,211,230,114,35,91,240,240,0,79,219,22,133,180,230,62,155,167,49,190,30,27,6,40,175,211,42,102,191,161,208,228,202,210,10,157,127,187,223,154,34,190,222,135,160,77,69,172,78,241,135,33,61,107,102,246,191,107,41,2,239,99,197,248,135,132,58,98,154,71,135,185,25,175,168,206,246,234,137,108,173,117,56,59,122,190,104,6,189,203,254,32,88,131,40,231,110,69,241,214,197,121,100,133,146,33,234,205,59,63,49,202,13,214,213,220,1,93,141,29,227,161,136,61,233,149,154,37,14,116,76,235,41,112,145,198,157,194,82,32,68,82,222,113,4,35,193,204,66,82,174,110,59,89,250,94,230,111,175,201,152,98,41,8,90,124,251,193,252,67,8,14,230,137,52,220,107,59,227,213,216,71,178,12,14,46,232,12,232,153,179,10,186,190,188,213,50,65,170,76,240,46,124,31,190,133,7,160,16,127,187,107,195,186,93,83,212,61,104,221,184,101,225,247,147,219,21,255,109,71,212,46,157,69,15,21,104,209,239,218,246,205,242,214,96,198,8,153,237,101,230,111,100,123,72,79,11,116,134,17,31,114,140,33,161,133,105,181,25,27,253,115,91,7,20,197,234,104,98,54,236,173,15,74,251,205,97,139,28,120,108,123,76,105,169,245,112,75,14,39,204,48,143,182,18,196,36,194,80,201,20,236,131,125,163,102,15,103,173,27,63,80,69,18,94,170,203,161,218,251,226,53,62,209,114,187,206,139,171,117,227,109,176,19,119,202,49,137,181,205,253,250,198,37,110,143,51,211,34,157,234,191,135,199,166,207,86,189,125,9,11,163,81,217,26,47,43,255,48,78,209,68,227,83,170,200,201,81,179,116,189,134,157,159,59,136,85,218,33,217,107,231,149,164,251,3,214,210,204,67,17,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("73bc41cd-133a-489f-9525-2cbb0f0913f0"));
		}

		#endregion

	}

	#endregion

}

