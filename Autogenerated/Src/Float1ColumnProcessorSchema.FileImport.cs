namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float1ColumnProcessorSchema

	/// <exclude/>
	public class Float1ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float1ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float1ColumnProcessorSchema(Float1ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f839451-e4a5-40f4-bb65-4692bb45345c");
			Name = "Float1ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,193,106,227,64,12,134,207,41,244,29,68,246,146,192,98,211,107,183,9,108,83,178,228,178,20,218,236,165,244,160,140,229,116,192,158,49,210,76,33,44,125,247,149,61,201,54,118,210,66,47,182,71,252,210,47,125,35,59,172,73,26,52,4,143,196,140,226,203,144,45,188,43,237,54,50,6,235,93,182,180,21,173,234,198,115,184,188,248,123,121,49,138,98,221,22,30,118,18,168,254,241,255,124,156,205,244,81,60,91,162,9,158,45,137,42,84,243,141,105,171,30,176,168,80,228,26,150,149,199,112,181,240,85,172,221,61,123,67,34,158,59,97,158,231,112,99,221,11,177,13,133,55,96,152,202,217,184,211,15,228,227,124,126,208,75,172,107,228,221,225,252,211,129,117,18,208,233,176,190,132,240,98,5,76,107,12,250,193,74,193,59,177,155,138,160,244,12,77,170,215,142,144,186,2,211,249,192,43,86,145,36,59,120,228,71,38,79,119,84,98,172,194,173,117,133,38,78,194,174,33,95,78,86,131,14,167,223,225,183,82,135,25,56,125,169,224,236,216,211,233,179,150,108,226,166,178,102,223,230,89,29,236,177,157,80,27,233,101,233,243,157,177,142,23,56,182,252,21,245,125,87,56,41,190,10,247,132,110,23,88,48,97,32,233,51,86,2,170,36,58,174,121,117,90,180,197,121,202,51,69,26,100,172,59,84,179,113,20,98,157,195,145,105,87,115,60,95,235,89,47,230,16,200,110,242,78,221,37,239,209,157,181,156,172,123,133,160,95,119,170,76,55,40,52,25,134,219,245,31,189,237,177,146,43,18,217,62,102,245,104,136,131,174,184,66,102,31,52,151,138,207,56,223,170,211,121,204,186,131,41,29,252,171,254,70,182,32,248,21,109,1,119,24,240,79,187,134,143,138,119,189,42,96,54,239,199,178,52,244,80,151,254,185,97,231,105,158,126,240,237,31,184,243,51,147,23,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f839451-e4a5-40f4-bb65-4692bb45345c"));
		}

		#endregion

	}

	#endregion

}

