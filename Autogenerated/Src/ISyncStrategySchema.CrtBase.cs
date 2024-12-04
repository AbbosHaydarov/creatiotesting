namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISyncStrategySchema

	/// <exclude/>
	public class ISyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISyncStrategySchema(ISyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b771ff15-a14f-4f39-be65-1b31aa728594");
			Name = "ISyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,146,193,78,195,48,12,134,207,171,212,119,176,182,11,92,214,11,167,49,38,33,16,104,135,74,67,29,15,16,90,47,139,212,36,197,78,38,42,180,119,39,105,183,169,234,224,200,161,82,226,218,191,191,223,177,17,26,185,17,37,194,22,137,4,219,157,155,231,66,213,105,242,157,38,19,207,202,72,40,90,118,168,239,211,36,68,102,132,82,89,3,107,227,144,118,161,110,1,235,162,53,101,225,72,56,148,109,151,148,101,25,44,217,107,45,168,93,157,238,27,178,7,85,33,131,70,183,183,21,195,206,18,72,116,240,233,145,90,112,22,24,5,149,251,216,208,88,7,28,68,177,10,217,204,66,34,207,207,178,217,64,183,241,31,181,42,161,17,228,148,168,65,157,153,198,72,147,232,229,130,158,247,0,11,216,116,229,241,87,252,198,208,93,224,137,48,104,240,137,13,240,171,161,0,20,85,84,152,65,254,184,185,131,90,24,233,3,98,36,188,70,236,35,132,206,147,225,75,160,24,203,13,138,135,185,236,40,206,227,21,221,187,137,3,201,89,246,165,111,113,104,55,183,253,155,252,43,122,35,72,104,48,97,77,30,166,97,27,74,124,14,170,211,85,17,143,80,133,51,28,68,237,113,190,204,186,204,107,207,191,152,253,203,228,75,88,60,123,64,26,217,140,29,183,74,35,92,250,159,141,207,208,84,253,171,134,219,177,95,208,65,40,77,142,63,232,185,99,216,224,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b771ff15-a14f-4f39-be65-1b31aa728594"));
		}

		#endregion

	}

	#endregion

}

