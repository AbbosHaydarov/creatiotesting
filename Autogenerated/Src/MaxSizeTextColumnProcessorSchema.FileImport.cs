namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MaxSizeTextColumnProcessorSchema

	/// <exclude/>
	public class MaxSizeTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MaxSizeTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MaxSizeTextColumnProcessorSchema(MaxSizeTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf2e8673-fb8d-4ba0-9c62-446b24f54ef1");
			Name = "MaxSizeTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,193,110,219,48,12,134,207,41,208,119,32,210,75,2,12,246,189,109,2,180,41,58,228,176,161,64,147,93,134,29,20,153,78,9,216,146,71,74,69,179,161,239,62,218,74,214,56,173,15,189,216,18,241,243,39,249,73,114,166,70,105,140,69,88,33,179,17,95,134,108,225,93,73,219,200,38,144,119,217,61,85,184,172,27,207,225,252,236,239,249,217,40,10,185,45,60,238,36,96,125,245,127,127,156,205,56,20,207,238,141,13,158,9,69,21,170,185,96,220,106,13,88,84,70,228,18,190,153,151,71,250,131,43,124,9,11,95,197,218,61,176,183,40,226,185,83,231,121,14,215,228,158,144,41,20,222,130,101,44,103,227,15,212,227,124,126,144,75,172,107,195,187,195,254,198,1,57,9,198,233,192,190,132,240,68,2,182,45,14,186,96,37,225,157,208,166,66,40,61,67,147,252,218,49,142,58,3,219,21,131,103,83,69,148,236,80,40,63,170,244,243,14,75,19,171,112,75,174,208,236,73,216,53,232,203,201,242,164,205,233,23,248,174,248,97,6,78,127,42,24,158,127,58,253,165,190,77,220,84,100,247,13,15,139,225,18,62,68,56,210,227,211,239,27,117,29,54,112,108,79,68,225,63,116,230,73,241,73,210,239,80,119,129,5,163,9,40,125,224,74,66,149,136,123,203,225,33,212,185,101,251,30,110,138,52,134,77,221,113,155,141,163,32,235,44,14,109,123,97,199,243,181,238,245,148,14,129,236,58,239,212,93,242,30,225,112,221,201,186,231,6,125,243,169,178,221,24,193,201,105,184,125,25,163,215,61,95,116,69,66,220,231,173,53,26,228,160,183,95,105,179,15,154,139,69,43,24,70,126,171,181,62,129,252,206,4,147,46,102,34,29,29,253,214,53,21,232,2,149,132,60,128,84,111,122,234,6,252,179,62,88,213,195,215,72,69,231,247,163,181,91,169,219,122,89,192,108,222,143,101,71,32,79,197,233,137,159,210,72,140,250,193,215,127,128,200,217,220,134,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf2e8673-fb8d-4ba0-9c62-446b24f54ef1"));
		}

		#endregion

	}

	#endregion

}

