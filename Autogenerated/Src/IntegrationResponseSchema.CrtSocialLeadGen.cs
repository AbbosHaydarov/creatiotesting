namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationResponseSchema

	/// <exclude/>
	public class IntegrationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationResponseSchema(IntegrationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34726720-1e07-4f00-be95-bf2446ea34bc");
			Name = "IntegrationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,145,49,79,195,48,16,133,231,86,234,127,56,149,5,150,100,111,129,37,149,42,164,2,85,211,13,49,184,201,37,88,138,237,234,124,1,149,138,255,206,217,73,75,90,22,199,247,252,252,238,62,199,42,131,126,175,10,132,45,18,41,239,42,78,50,103,43,93,183,164,88,59,155,228,174,208,170,89,161,42,151,104,39,227,227,100,60,106,189,182,53,228,7,207,104,146,77,107,89,27,76,114,36,241,233,239,120,107,62,25,139,239,134,176,150,2,178,70,121,63,131,39,203,88,119,169,43,237,121,35,141,157,245,24,173,105,154,194,189,111,141,81,116,120,236,235,172,113,109,9,212,219,96,177,125,133,47,205,31,160,109,229,200,196,28,112,149,148,231,216,228,148,148,14,162,222,22,138,149,48,49,169,130,223,69,216,183,187,70,23,80,132,169,134,67,157,6,130,25,92,64,139,206,107,114,159,186,68,250,27,122,36,47,33,235,25,82,28,123,36,214,40,164,235,216,161,59,191,38,139,194,18,217,131,35,240,225,59,0,128,70,30,38,80,252,199,232,56,158,209,236,144,110,95,228,183,193,3,76,7,87,195,233,244,46,240,157,0,7,104,195,125,48,194,17,106,228,121,232,63,135,159,30,4,109,217,177,196,186,83,47,69,209,126,1,15,4,120,22,49,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34726720-1e07-4f00-be95-bf2446ea34bc"));
		}

		#endregion

	}

	#endregion

}

