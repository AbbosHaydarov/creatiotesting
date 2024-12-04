namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichActivityInfoSchema

	/// <exclude/>
	public class EnrichActivityInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichActivityInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichActivityInfoSchema(EnrichActivityInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32631f18-b4d5-4b3a-96de-3aa147def4d1");
			Name = "EnrichActivityInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,83,219,106,219,64,16,125,118,32,255,48,56,16,44,10,210,123,125,129,162,134,52,15,105,67,237,183,210,135,181,52,178,183,104,119,221,189,4,220,146,127,239,172,180,186,57,106,112,66,11,66,210,156,157,203,153,51,179,146,9,52,7,150,33,108,80,107,102,84,97,227,84,201,130,239,156,102,150,43,121,121,241,251,242,98,226,12,151,59,88,31,141,69,49,63,177,227,175,78,90,46,48,94,163,230,172,228,191,170,56,242,34,191,43,141,59,50,32,45,153,49,239,225,70,106,158,237,63,100,150,63,114,123,188,147,133,34,31,122,146,36,129,133,113,66,48,125,92,5,187,246,197,28,80,48,94,2,39,103,45,170,212,113,19,145,244,66,190,125,100,150,17,115,171,89,102,191,19,112,112,219,146,103,144,249,202,227,133,169,49,122,183,28,31,180,58,160,182,28,137,232,67,29,92,59,156,178,171,128,205,30,3,51,22,178,2,207,145,132,40,56,106,207,240,57,197,154,227,61,138,45,234,217,103,18,30,150,48,109,162,239,242,105,228,105,55,188,111,29,207,161,37,156,207,95,160,210,42,149,81,251,148,239,109,68,66,240,40,143,180,57,123,21,13,73,153,95,79,192,155,67,10,198,106,191,109,105,119,30,104,92,161,204,235,225,13,39,121,143,118,175,242,179,198,184,48,136,144,105,44,150,211,176,205,95,182,63,48,179,241,205,79,199,74,51,83,149,21,77,147,213,120,35,129,162,122,164,219,67,178,195,86,169,18,6,177,64,159,8,252,37,154,76,120,1,30,133,229,18,164,43,203,6,158,104,180,78,75,40,40,202,247,70,200,83,245,126,190,182,62,219,70,165,74,28,152,246,170,249,108,108,108,191,231,253,130,189,136,51,43,7,188,91,192,158,32,109,182,184,59,142,224,250,186,91,147,81,231,246,52,170,10,61,253,255,169,244,135,49,46,229,91,7,243,146,60,231,168,242,79,196,184,69,251,137,153,125,170,114,156,253,93,139,10,169,249,154,213,34,105,254,198,150,151,75,11,131,164,65,134,208,237,172,215,238,70,173,171,91,73,62,239,122,29,118,112,52,164,215,239,242,228,218,214,232,16,36,236,15,54,87,144,247,154,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32631f18-b4d5-4b3a-96de-3aa147def4d1"));
		}

		#endregion

	}

	#endregion

}

