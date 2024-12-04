namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceSchemaParameterBuilderSchema

	/// <exclude/>
	public class ServiceSchemaParameterBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceSchemaParameterBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceSchemaParameterBuilderSchema(ServiceSchemaParameterBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f037ecb-feb6-462e-a7ed-458ad1f12252");
			Name = "ServiceSchemaParameterBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,83,77,75,195,64,16,61,111,160,255,97,192,75,2,37,63,160,106,139,182,42,5,17,161,226,69,60,108,55,147,118,37,217,196,217,77,165,72,255,187,147,108,107,98,149,214,67,115,201,199,190,121,243,222,204,139,145,57,218,82,42,132,39,36,146,182,72,93,60,46,76,170,23,21,73,167,11,19,207,144,86,90,225,76,45,49,151,189,224,179,23,244,2,81,89,109,22,48,91,91,135,57,227,179,12,85,13,182,241,29,26,36,173,206,247,49,247,218,188,183,31,187,189,8,227,91,169,92,65,26,45,35,24,115,70,184,96,50,152,26,135,148,178,182,1,76,127,168,120,148,196,178,249,240,186,210,89,130,212,84,149,213,60,211,10,244,174,232,104,141,96,43,66,76,116,163,92,210,250,194,58,98,113,125,40,230,111,108,103,8,13,50,156,222,152,42,71,146,243,12,47,254,102,28,66,185,123,180,81,109,114,227,109,160,73,188,19,126,233,216,26,103,210,218,1,28,119,244,50,193,84,86,153,187,214,38,97,97,161,91,151,88,164,225,97,95,81,244,218,14,67,213,173,14,119,130,193,191,6,85,143,170,36,189,146,14,193,58,78,134,130,19,79,174,95,183,56,184,15,235,57,190,171,109,4,205,10,69,202,33,146,106,9,225,74,82,203,200,81,232,46,102,139,21,158,13,86,50,171,16,46,91,68,252,128,156,212,164,101,31,113,244,235,92,135,230,231,1,92,14,61,147,240,54,247,142,251,96,240,227,192,112,194,40,138,226,167,226,94,91,23,70,48,26,117,20,60,215,154,234,0,241,245,203,108,124,149,36,97,139,29,23,9,246,189,139,38,115,66,108,160,185,17,186,138,204,239,97,53,32,159,204,93,60,78,157,253,237,136,183,10,60,69,103,193,199,7,179,211,248,199,31,212,11,54,95,81,24,21,89,172,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f037ecb-feb6-462e-a7ed-458ad1f12252"));
		}

		#endregion

	}

	#endregion

}

