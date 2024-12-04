namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualizedConditionSchema

	/// <exclude/>
	public class ActualizedConditionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualizedConditionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualizedConditionSchema(ActualizedConditionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d465fc2e-b275-4e5b-aa8c-bb3916adc374");
			Name = "ActualizedCondition";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,77,106,195,48,16,133,215,54,248,14,3,217,219,251,166,20,138,3,221,21,47,122,129,137,60,118,135,218,146,145,70,133,36,244,238,149,165,212,77,250,71,26,109,132,158,230,205,251,52,72,227,72,110,66,69,240,68,214,162,51,157,148,181,209,29,247,222,162,176,209,69,126,40,242,34,135,176,86,150,250,160,64,61,160,115,55,112,175,196,227,192,123,106,131,161,229,84,156,42,171,170,130,91,231,199,17,237,238,238,83,138,70,80,70,11,178,118,192,186,51,118,140,41,128,91,227,5,80,9,191,82,170,80,82,158,52,171,206,187,77,126,59,176,2,21,27,254,8,146,69,236,44,251,128,110,172,153,200,10,83,32,111,162,59,221,127,65,77,194,3,137,3,99,193,205,187,60,19,232,48,38,48,29,4,27,105,71,229,226,60,225,202,178,35,149,19,203,186,135,6,213,11,246,244,56,91,15,208,147,172,231,126,107,120,251,79,176,50,94,203,156,252,109,52,127,0,112,176,44,163,168,99,135,171,1,90,20,170,132,211,243,253,52,31,47,122,253,146,191,9,142,235,227,143,3,135,214,39,148,139,178,55,158,126,75,93,145,110,211,143,136,231,168,198,191,125,166,7,249,29,98,250,195,158,25,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d465fc2e-b275-4e5b-aa8c-bb3916adc374"));
		}

		#endregion

	}

	#endregion

}

