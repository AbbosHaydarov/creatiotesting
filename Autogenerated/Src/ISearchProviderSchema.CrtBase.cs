namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISearchProviderSchema

	/// <exclude/>
	public class ISearchProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISearchProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISearchProviderSchema(ISearchProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce4a57cc-37d9-4a85-b56a-a7ea95f370e8");
			Name = "ISearchProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,145,193,110,131,48,12,134,207,32,241,14,86,123,217,164,9,238,29,227,210,77,19,135,73,157,186,23,8,96,104,36,18,152,157,76,66,83,223,125,33,129,181,221,46,137,226,255,179,253,199,214,66,33,143,162,70,248,64,34,193,67,107,210,253,160,91,217,89,18,70,14,58,137,191,147,56,178,44,117,7,199,137,13,42,167,247,61,214,179,200,233,43,106,36,89,63,38,177,163,182,132,157,139,66,169,13,82,235,138,238,160,60,162,160,250,116,160,225,75,54,72,30,203,178,12,114,182,74,9,154,138,229,29,48,24,23,46,93,177,236,138,27,109,213,203,26,228,90,253,127,241,200,121,117,231,175,145,55,52,167,161,225,29,28,124,106,16,255,182,143,46,253,25,170,9,62,45,210,52,27,240,194,141,131,16,25,5,9,5,218,77,238,105,195,62,239,125,78,217,20,203,39,66,129,60,243,220,37,141,208,88,210,188,82,132,108,123,195,142,91,133,153,44,95,180,85,72,162,234,49,127,150,126,200,174,119,206,134,220,2,30,32,220,69,177,248,189,11,151,111,15,87,86,238,195,62,162,45,234,38,140,194,191,207,97,75,55,193,243,15,251,245,215,252,2,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce4a57cc-37d9-4a85-b56a-a7ea95f370e8"));
		}

		#endregion

	}

	#endregion

}

