namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailContentProcessorSchema

	/// <exclude/>
	public class IEmailContentProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailContentProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailContentProcessorSchema(IEmailContentProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("819ce2ce-5952-41b4-b5b6-a1b94edb0446");
			Name = "IEmailContentProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0f0b57ce-3155-4876-a7bb-8a901e434b75");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,83,193,78,219,64,16,61,19,41,255,48,130,11,72,200,190,67,26,9,161,138,34,129,148,150,124,64,183,155,113,60,146,189,187,157,25,131,80,197,191,119,188,235,164,4,104,143,189,88,218,217,247,222,188,121,158,13,174,71,73,206,35,172,145,217,73,108,180,186,142,161,161,237,192,78,41,134,106,77,61,118,20,112,62,251,53,159,29,13,66,97,11,15,207,162,216,27,176,235,208,143,40,169,110,48,32,147,191,156,207,12,117,194,184,181,42,220,6,69,110,76,253,2,110,63,247,142,58,147,86,12,186,226,232,81,36,114,70,215,117,13,11,25,250,222,241,243,114,58,239,153,208,68,134,84,240,99,107,28,101,192,23,157,106,199,174,95,209,211,240,163,35,15,180,87,248,91,235,35,27,200,190,123,183,247,168,109,220,200,5,172,178,66,185,124,107,46,23,190,161,50,225,35,10,56,243,134,143,132,79,16,27,208,22,223,251,123,111,176,84,146,99,215,67,176,252,63,29,103,210,241,114,109,252,137,121,40,231,4,190,172,239,239,170,69,157,89,127,68,24,117,224,32,203,43,144,54,178,130,4,74,9,223,176,119,146,37,201,226,54,13,156,162,160,152,228,78,99,20,21,155,203,66,190,65,203,41,3,79,167,74,86,58,187,252,71,38,15,169,35,149,15,218,218,143,136,240,115,136,138,114,14,46,108,96,106,8,164,223,5,204,5,141,27,100,176,204,141,76,91,10,174,43,34,255,49,192,142,36,147,10,193,96,54,204,206,156,25,127,106,145,77,205,249,54,223,217,16,22,165,88,163,113,7,54,36,74,193,107,25,211,102,0,79,90,158,207,97,190,119,6,92,156,90,34,32,106,42,231,99,56,128,97,115,182,28,51,255,106,236,204,146,213,212,248,195,248,79,140,80,86,54,159,95,202,147,59,40,190,252,6,249,121,172,46,216,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("819ce2ce-5952-41b4-b5b6-a1b94edb0446"));
		}

		#endregion

	}

	#endregion

}

