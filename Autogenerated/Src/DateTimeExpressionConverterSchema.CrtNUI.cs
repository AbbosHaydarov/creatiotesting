namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExpressionConverterSchema

	/// <exclude/>
	public class DateTimeExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExpressionConverterSchema(DateTimeExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3950f08c-8bf5-45b1-a16f-7b3f28203807");
			Name = "DateTimeExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e35bf724-6dee-44c8-b23b-34796602023a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,77,107,227,48,16,61,59,144,255,48,235,189,216,176,216,247,110,27,40,109,22,122,200,182,208,220,150,61,40,246,196,117,177,36,51,146,74,77,233,127,239,72,178,157,52,13,53,70,160,247,230,189,249,208,40,33,209,244,162,66,216,34,145,48,122,111,139,27,173,246,109,227,72,216,86,171,229,226,109,185,72,156,105,85,3,143,131,177,40,127,207,247,99,137,148,90,121,134,255,159,132,13,43,225,166,19,198,92,192,173,176,184,109,37,174,95,123,66,99,152,225,4,47,72,22,105,185,224,240,178,44,225,210,56,41,5,13,171,241,238,53,96,89,4,56,171,160,154,100,80,121,231,98,210,150,71,226,127,103,178,92,91,75,237,206,89,204,82,239,155,230,255,57,176,119,187,174,173,162,211,119,37,194,5,220,157,131,217,130,7,195,231,220,238,6,237,147,174,185,225,135,96,29,201,211,230,2,48,186,24,168,231,54,95,68,231,208,119,244,181,165,136,244,130,132,4,197,207,117,149,134,224,116,117,123,162,190,44,67,208,121,141,160,198,73,84,214,164,43,184,174,235,214,191,173,232,96,134,191,170,9,173,35,101,86,83,207,245,81,185,134,39,170,26,214,76,65,94,53,142,52,114,176,246,69,177,32,211,187,103,172,108,172,241,215,196,206,121,225,10,210,52,7,191,100,73,50,146,62,207,31,77,82,88,207,214,117,177,217,20,3,127,169,95,176,36,105,247,144,253,56,20,126,103,254,186,174,187,167,181,236,237,144,229,147,87,242,201,101,14,143,22,239,225,156,158,61,36,60,120,79,112,177,165,225,65,144,193,44,139,133,229,99,15,218,217,32,57,228,138,99,8,96,177,213,143,33,58,59,20,144,31,103,29,99,199,17,134,170,3,205,108,88,39,84,117,220,168,112,143,232,103,240,253,3,241,221,61,20,182,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3950f08c-8bf5-45b1-a16f-7b3f28203807"));
		}

		#endregion

	}

	#endregion

}

