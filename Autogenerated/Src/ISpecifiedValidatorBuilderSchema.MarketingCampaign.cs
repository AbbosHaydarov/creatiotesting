namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISpecifiedValidatorBuilderSchema

	/// <exclude/>
	public class ISpecifiedValidatorBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISpecifiedValidatorBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISpecifiedValidatorBuilderSchema(ISpecifiedValidatorBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc9cc121-d353-4d3a-b160-b3888156283d");
			Name = "ISpecifiedValidatorBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,189,106,196,48,16,132,235,51,248,29,150,171,146,198,234,19,197,69,142,16,220,230,76,122,157,188,62,22,244,99,86,82,192,132,188,123,164,179,157,194,71,64,141,102,103,102,245,33,167,44,134,73,105,132,30,153,85,240,99,108,78,222,141,116,77,172,34,121,87,87,223,117,117,72,129,220,21,206,115,136,104,243,220,24,212,101,24,154,119,116,200,164,159,235,42,187,132,16,32,67,178,86,241,220,174,247,215,68,102,64,134,209,51,132,9,53,141,164,225,75,25,26,110,245,192,201,96,179,101,197,46,44,227,60,225,164,88,89,112,249,161,47,199,254,216,158,151,18,28,192,250,1,141,20,127,158,146,154,210,197,228,5,228,34,242,88,176,186,213,175,63,151,157,158,215,23,201,190,133,39,232,246,114,238,40,192,119,44,55,225,196,168,34,254,203,1,134,66,44,48,247,52,139,194,24,19,187,176,49,220,21,4,41,54,75,201,116,111,46,89,100,117,49,40,247,28,57,242,145,19,153,162,133,206,81,220,198,69,12,15,143,249,67,14,63,117,149,207,47,95,181,75,34,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc9cc121-d353-4d3a-b160-b3888156283d"));
		}

		#endregion

	}

	#endregion

}

