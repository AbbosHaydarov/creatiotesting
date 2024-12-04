namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IValidationRuleSchema

	/// <exclude/>
	public class IValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IValidationRuleSchema(IValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b8f6e9b-17b0-478d-8b69-e7bce7da0263");
			Name = "IValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,203,10,194,48,16,69,215,22,250,15,179,212,141,249,0,197,133,226,194,173,136,251,105,157,214,96,154,200,204,68,144,226,191,155,6,95,32,10,217,228,230,220,57,19,143,29,201,25,107,130,29,49,163,132,70,167,171,224,27,219,70,70,181,193,151,69,95,22,35,99,12,204,37,118,29,242,117,241,184,47,81,8,46,232,236,33,131,192,209,209,244,201,154,15,248,28,43,103,107,176,94,137,155,65,181,217,191,90,219,84,74,200,224,248,146,228,32,45,163,104,61,232,145,32,109,24,24,58,20,193,150,192,54,105,100,246,191,212,223,238,145,40,91,223,194,58,87,123,104,73,103,112,43,139,223,190,35,213,167,108,251,51,52,39,76,26,217,203,226,253,25,96,146,232,116,110,158,79,3,91,133,224,224,193,208,120,50,75,89,242,167,115,7,66,16,195,8,123,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b8f6e9b-17b0-478d-8b69-e7bce7da0263"));
		}

		#endregion

	}

	#endregion

}

