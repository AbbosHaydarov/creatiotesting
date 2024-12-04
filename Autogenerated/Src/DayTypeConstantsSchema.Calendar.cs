namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DayTypeConstantsSchema

	/// <exclude/>
	public class DayTypeConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DayTypeConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DayTypeConstantsSchema(DayTypeConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4a46baa-a9bf-4def-a556-bd42551ffe45");
			Name = "DayTypeConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,143,203,106,195,48,16,69,215,49,248,31,68,186,105,23,170,29,37,146,165,190,192,15,165,116,221,64,215,170,173,4,147,88,54,122,80,76,233,191,87,118,226,18,210,77,43,52,51,154,203,133,115,165,68,35,77,39,74,9,54,82,107,97,218,173,189,205,91,181,173,119,78,11,91,183,42,12,62,195,96,230,76,173,118,224,181,55,86,54,247,97,224,149,40,138,192,131,113,77,35,116,255,116,218,175,166,115,124,13,125,114,70,103,214,206,189,31,234,18,24,235,1,37,40,15,194,24,80,136,126,211,119,210,163,189,172,172,241,182,129,251,11,51,113,134,186,155,128,227,252,113,159,163,46,88,207,174,174,192,91,171,247,30,247,82,129,71,160,228,199,40,94,207,121,156,19,66,210,2,166,152,113,184,34,8,67,202,56,129,152,199,217,58,193,69,90,160,116,126,115,252,251,223,82,253,55,150,148,123,174,170,139,88,113,66,115,150,45,56,100,203,5,130,171,37,95,195,140,178,24,114,140,24,45,50,130,40,74,198,88,179,175,48,240,247,27,178,165,4,152,208,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4a46baa-a9bf-4def-a556-bd42551ffe45"));
		}

		#endregion

	}

	#endregion

}

