namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RichTextColumnProcessorSchema

	/// <exclude/>
	public class RichTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RichTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RichTextColumnProcessorSchema(RichTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0707d032-3302-49c0-85c6-57a87aecda8d");
			Name = "RichTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,209,107,219,48,16,198,159,83,232,255,112,100,47,9,20,251,189,107,2,107,74,75,96,140,178,37,123,25,123,80,228,115,114,96,159,188,147,84,22,198,254,247,157,173,120,171,211,122,208,23,91,58,62,125,159,238,39,137,77,141,190,49,22,97,131,34,198,187,50,100,43,199,37,237,163,152,64,142,179,123,170,112,93,55,78,194,229,197,175,203,139,73,244,196,123,248,114,244,1,235,247,127,231,207,87,11,142,213,179,123,99,131,19,66,175,10,213,188,19,220,107,6,172,42,227,253,53,124,38,123,216,224,207,176,114,85,172,249,81,156,69,239,157,116,210,60,207,225,134,248,128,66,161,112,22,172,96,185,152,190,162,158,230,203,94,238,99,93,27,57,246,243,15,12,196,62,24,214,110,93,9,225,64,30,108,155,12,58,16,197,224,216,211,174,66,40,157,64,147,252,218,30,62,58,222,183,65,96,187,36,120,50,85,68,159,245,41,249,179,152,111,119,88,154,88,133,91,226,66,151,206,194,177,65,87,206,214,103,123,156,95,193,39,5,15,11,96,253,169,96,164,243,249,252,187,154,54,113,87,145,61,109,117,68,9,215,240,42,185,137,30,153,126,255,145,214,30,131,196,246,20,20,248,99,231,156,20,111,4,252,130,112,87,88,9,154,128,126,200,89,25,168,18,241,100,57,210,129,218,182,72,95,50,77,149,198,136,169,59,92,139,105,244,40,218,8,163,109,111,232,116,185,213,185,30,78,95,200,110,242,78,221,45,62,193,27,9,157,109,7,86,48,116,158,43,213,157,241,56,59,47,183,239,96,242,251,68,22,185,72,112,135,164,53,163,65,9,122,215,149,179,184,160,107,177,248,31,234,91,77,122,3,234,59,19,76,186,138,137,112,100,250,161,99,42,144,3,149,132,50,66,83,47,118,218,11,184,39,125,156,170,135,135,72,69,231,247,181,181,219,168,219,118,93,192,98,57,172,101,61,195,115,101,122,203,231,32,18,158,97,81,107,127,0,119,83,120,149,113,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0707d032-3302-49c0-85c6-57a87aecda8d"));
		}

		#endregion

	}

	#endregion

}

