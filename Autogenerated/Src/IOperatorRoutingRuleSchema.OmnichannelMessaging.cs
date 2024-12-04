namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOperatorRoutingRuleSchema

	/// <exclude/>
	public class IOperatorRoutingRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOperatorRoutingRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOperatorRoutingRuleSchema(IOperatorRoutingRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e93c971a-debf-4f24-ad8f-d4b461191ae0");
			Name = "IOperatorRoutingRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,82,93,107,220,48,16,124,78,32,255,97,185,190,180,80,236,247,156,107,40,9,28,130,134,164,105,250,3,100,107,237,91,144,37,87,31,45,33,244,191,119,37,157,157,75,154,64,95,10,121,49,246,122,118,52,51,26,35,39,244,179,236,17,238,208,57,233,237,16,170,11,107,6,26,163,147,129,172,169,174,39,67,253,94,26,131,186,186,66,239,229,72,102,60,59,125,56,59,61,137,158,95,225,219,189,15,56,109,159,125,51,139,214,216,39,10,95,237,208,160,163,158,49,140,122,231,112,228,41,8,19,208,13,124,244,57,136,235,25,249,56,235,110,109,12,204,113,27,53,102,236,28,59,77,61,208,2,125,5,121,194,106,248,185,82,223,56,203,176,64,232,207,225,38,83,148,255,117,93,67,227,227,52,73,119,223,46,3,225,129,253,5,80,228,131,163,46,6,84,16,44,72,173,65,254,148,154,100,167,17,236,225,88,15,131,150,99,181,238,14,192,144,136,208,244,237,32,181,199,166,238,219,66,231,112,37,76,146,180,29,217,200,47,98,214,14,65,206,179,38,84,43,79,83,31,171,234,172,213,44,235,130,105,46,31,69,221,217,207,90,47,246,61,60,192,136,97,11,191,15,206,209,168,98,254,105,18,87,24,246,86,253,75,12,59,12,199,46,173,43,54,202,157,250,25,123,26,216,64,177,145,255,70,231,208,4,120,225,66,94,177,149,39,179,116,114,2,195,181,251,180,153,114,157,112,211,150,94,33,199,19,246,48,112,70,124,5,201,189,80,32,77,126,77,245,251,26,49,162,80,85,83,103,146,71,78,135,33,58,227,91,161,88,16,203,68,54,96,135,84,68,169,38,50,223,13,29,89,227,245,5,159,8,190,112,192,205,46,146,106,83,2,139,25,161,252,251,181,236,139,186,131,220,15,219,183,149,98,58,64,168,77,155,2,3,90,35,248,59,166,227,165,31,37,203,188,149,178,133,60,120,121,29,254,107,204,169,223,156,77,113,241,17,18,166,136,17,106,73,250,89,185,75,229,159,14,121,246,7,185,12,93,132,203,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e93c971a-debf-4f24-ad8f-d4b461191ae0"));
		}

		#endregion

	}

	#endregion

}

