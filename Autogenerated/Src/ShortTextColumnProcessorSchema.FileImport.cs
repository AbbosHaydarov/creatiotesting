namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ShortTextColumnProcessorSchema

	/// <exclude/>
	public class ShortTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ShortTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ShortTextColumnProcessorSchema(ShortTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e75194b-c61b-4a32-9829-7c88737e87a4");
			Name = "ShortTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,65,79,227,48,16,133,207,69,226,63,140,186,151,86,66,201,157,165,149,150,34,80,47,8,137,150,11,226,224,58,147,118,164,196,14,99,27,109,181,226,191,51,177,27,32,133,172,196,37,177,71,207,239,121,62,219,70,213,232,26,165,17,86,200,172,156,45,125,182,176,166,164,109,96,229,201,154,236,154,42,92,214,141,101,127,122,242,239,244,100,20,28,153,45,220,239,157,199,250,247,251,252,243,106,198,161,122,118,173,180,183,76,232,68,33,154,95,140,91,201,128,69,165,156,59,135,251,157,164,172,240,175,95,216,42,212,230,142,173,70,231,44,71,109,158,231,112,65,102,135,76,190,176,26,52,99,57,27,127,163,30,231,243,78,238,66,93,43,222,119,243,63,6,200,56,175,140,180,107,75,240,59,114,160,219,104,144,1,11,7,107,28,109,42,132,210,50,52,201,47,54,219,237,11,116,140,130,23,85,5,116,89,23,147,127,202,121,188,194,82,133,202,95,146,41,100,237,196,239,27,180,229,100,121,180,201,233,25,220,10,122,152,129,145,159,8,134,122,159,78,159,196,181,9,155,138,244,97,179,67,82,56,135,111,225,141,228,216,228,251,65,91,218,244,28,218,147,16,232,119,209,58,41,126,200,248,11,228,88,88,48,42,143,174,143,90,40,136,18,241,96,57,212,130,248,182,84,191,98,77,149,70,177,170,35,177,217,56,56,100,233,196,160,110,175,233,120,190,150,185,156,79,87,200,46,242,168,142,139,15,248,134,82,39,235,158,23,244,173,167,194,117,163,28,78,142,203,237,107,24,189,30,216,162,41,18,222,62,107,201,104,144,189,220,120,33,205,214,203,90,44,254,7,251,82,146,126,0,251,74,121,149,174,99,98,28,12,61,203,152,10,52,158,74,66,30,192,41,183,59,237,5,236,139,60,81,209,195,77,160,34,250,61,180,118,43,113,91,47,11,152,205,251,181,236,29,226,177,52,61,233,99,18,137,79,191,248,250,6,247,11,105,105,118,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e75194b-c61b-4a32-9829-7c88737e87a4"));
		}

		#endregion

	}

	#endregion

}

