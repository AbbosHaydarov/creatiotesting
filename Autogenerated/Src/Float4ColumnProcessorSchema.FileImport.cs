namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float4ColumnProcessorSchema

	/// <exclude/>
	public class Float4ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float4ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float4ColumnProcessorSchema(Float4ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e45599cf-db78-4a8d-b5e2-31927002be8f");
			Name = "Float4ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,65,107,227,48,16,133,207,9,244,63,12,233,37,129,98,31,182,167,109,19,216,166,100,201,165,20,182,233,101,217,131,34,143,147,1,91,114,71,82,33,148,254,247,142,165,164,141,157,118,161,23,91,26,158,222,147,62,141,140,170,209,53,74,35,60,32,179,114,182,244,217,220,154,146,54,129,149,39,107,178,5,85,184,172,27,203,254,108,248,114,54,28,4,71,102,3,127,118,206,99,125,245,62,63,94,205,248,85,61,91,40,237,45,19,58,81,136,230,156,113,35,25,48,175,148,115,63,97,81,89,229,127,204,109,21,106,115,207,86,163,115,150,163,48,207,115,184,38,179,69,38,95,88,13,154,177,156,142,162,190,39,31,229,179,131,222,133,186,86,188,59,204,127,25,32,227,188,50,114,88,91,130,223,146,3,221,6,131,12,88,40,88,227,104,93,33,148,150,161,73,126,237,17,210,174,64,199,28,120,86,85,64,151,29,50,242,163,144,191,183,88,170,80,249,27,50,133,44,28,251,93,131,182,28,47,123,59,156,92,192,157,80,135,41,24,249,137,32,6,92,246,85,147,127,98,217,132,117,69,122,191,205,79,117,176,199,118,66,109,32,151,37,223,15,198,114,60,207,161,229,47,168,239,163,113,82,124,23,238,9,221,88,152,51,42,143,174,203,88,8,136,18,241,216,243,242,212,180,197,121,202,51,85,26,197,170,142,168,166,163,224,144,229,28,6,117,219,154,163,217,74,230,114,49,135,66,118,157,71,117,92,188,71,247,105,228,120,213,49,130,174,239,68,152,174,149,195,113,191,220,182,255,224,117,143,21,77,145,200,118,49,75,70,131,236,165,197,5,50,91,47,107,177,248,31,231,27,73,250,6,230,91,229,85,106,194,68,55,24,122,146,49,21,104,60,149,132,252,5,75,105,232,180,23,176,207,242,38,69,15,191,3,21,209,239,177,181,123,16,183,213,178,128,233,172,91,203,18,193,190,46,61,224,62,134,4,167,91,124,125,3,14,83,15,101,100,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e45599cf-db78-4a8d-b5e2-31927002be8f"));
		}

		#endregion

	}

	#endregion

}

