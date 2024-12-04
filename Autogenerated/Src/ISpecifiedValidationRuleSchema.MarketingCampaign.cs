namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISpecifiedValidationRuleSchema

	/// <exclude/>
	public class ISpecifiedValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISpecifiedValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISpecifiedValidationRuleSchema(ISpecifiedValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09a3c370-1a84-44b1-9af8-a13146a5503c");
			Name = "ISpecifiedValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,77,106,3,49,12,133,215,25,152,59,136,172,218,77,124,128,184,179,41,93,100,219,14,221,43,19,121,98,234,63,100,187,16,66,239,94,219,100,166,208,208,130,55,214,251,164,247,36,112,104,41,6,156,8,70,98,198,232,85,218,61,123,167,244,156,25,147,246,174,239,174,125,183,17,66,128,140,217,90,228,203,112,251,191,5,154,180,210,19,124,162,209,167,6,3,103,67,187,133,23,191,26,100,186,4,10,200,104,161,218,62,109,199,237,176,14,177,254,68,70,138,21,169,77,33,31,77,145,180,75,196,170,102,60,44,248,251,106,249,90,28,229,88,233,154,243,46,104,43,148,133,18,106,7,233,76,80,182,244,12,22,99,196,153,64,171,50,189,229,95,163,223,103,223,196,196,218,205,240,210,90,175,48,83,218,195,87,223,253,237,119,166,233,163,185,253,51,180,85,152,82,102,23,135,159,125,128,41,102,147,164,88,164,202,30,189,55,112,99,232,97,132,118,33,42,87,137,143,251,162,151,44,229,125,3,132,74,141,44,204,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09a3c370-1a84-44b1-9af8-a13146a5503c"));
		}

		#endregion

	}

	#endregion

}

