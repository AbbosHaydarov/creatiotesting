namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MediumTextColumnProcessorSchema

	/// <exclude/>
	public class MediumTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MediumTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MediumTextColumnProcessorSchema(MediumTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("849d8e1e-95a1-4326-a3ca-a768f4bf5d14");
			Name = "MediumTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,193,110,219,48,12,134,207,41,208,119,32,178,75,2,12,246,189,107,2,180,41,58,228,208,162,192,146,93,134,30,20,153,78,9,216,146,71,74,197,130,161,239,62,218,74,154,58,173,7,244,98,75,196,207,159,228,39,201,153,26,165,49,22,97,133,204,70,124,25,178,133,119,37,109,35,155,64,222,101,183,84,225,178,110,60,135,243,179,191,231,103,163,40,228,182,240,99,39,1,235,111,175,251,183,217,140,67,241,236,214,216,224,153,80,84,161,154,47,140,91,173,1,139,202,136,92,192,29,22,20,235,21,254,9,11,95,197,218,61,176,183,40,226,185,19,231,121,14,151,228,158,144,41,20,222,130,101,44,103,227,15,212,227,124,126,144,75,172,107,195,187,195,254,202,1,57,9,198,233,188,190,132,240,68,2,182,173,13,186,96,5,225,157,208,166,66,40,61,67,147,252,218,41,142,141,129,237,106,193,179,169,34,74,118,168,147,191,41,244,235,6,75,19,171,112,77,174,208,228,73,216,53,232,203,201,242,164,203,233,87,184,87,248,48,3,167,63,21,12,78,63,157,62,170,109,19,55,21,217,125,187,131,90,184,128,15,249,141,244,232,244,123,36,174,147,6,142,237,105,40,248,135,206,59,41,62,137,249,29,231,46,176,96,52,1,165,79,91,57,168,18,113,111,57,56,131,26,183,96,223,147,77,145,198,176,169,59,104,179,113,20,100,29,197,161,109,239,234,120,190,214,189,30,209,33,144,93,230,157,186,75,222,3,28,44,59,89,247,204,160,239,61,85,178,27,35,56,57,13,183,111,98,244,178,167,139,174,72,128,251,180,181,70,131,28,244,222,43,107,246,65,115,177,248,31,238,107,173,244,9,220,55,38,152,116,37,19,229,232,232,183,174,169,64,23,168,36,228,1,158,122,197,83,47,224,159,245,161,170,30,190,71,42,58,191,159,173,221,74,221,214,203,2,102,243,126,44,59,82,60,213,166,151,125,138,34,1,234,7,95,254,1,47,128,33,33,125,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("849d8e1e-95a1-4326-a3ca-a768f4bf5d14"));
		}

		#endregion

	}

	#endregion

}

