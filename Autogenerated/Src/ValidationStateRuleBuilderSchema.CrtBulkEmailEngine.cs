namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationStateRuleBuilderSchema

	/// <exclude/>
	public class ValidationStateRuleBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationStateRuleBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationStateRuleBuilderSchema(ValidationStateRuleBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65");
			Name = "ValidationStateRuleBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,193,106,2,49,16,61,43,248,15,131,189,232,197,189,171,21,218,82,68,168,32,213,246,30,119,71,13,36,89,153,153,40,82,250,239,157,236,42,213,214,130,133,37,108,102,222,123,121,47,153,96,60,242,214,228,8,11,36,50,92,174,164,247,84,134,149,93,71,50,98,203,208,106,126,180,154,141,200,54,172,97,126,96,65,175,125,231,48,79,77,238,141,49,32,217,124,208,106,42,42,203,50,24,114,244,222,208,97,116,220,207,168,220,217,2,25,60,202,166,44,64,74,88,163,0,69,167,181,85,73,192,98,4,97,103,156,45,140,148,212,59,233,100,103,66,219,184,116,54,135,220,25,102,120,175,161,122,252,60,81,95,85,233,49,90,87,32,65,31,38,83,99,157,122,173,90,223,200,35,64,165,52,141,174,141,59,194,181,214,97,90,185,226,62,204,170,35,234,230,207,28,85,97,140,194,32,27,60,179,238,235,179,46,35,168,106,202,240,59,68,93,33,148,72,129,71,67,70,132,156,112,117,223,158,60,135,232,145,204,210,225,240,15,255,41,228,168,157,141,96,111,101,83,59,232,13,179,147,86,18,63,94,209,206,146,68,227,224,86,205,20,43,253,112,167,11,233,161,27,141,131,69,87,64,45,13,1,247,240,160,79,189,67,29,10,49,185,240,37,191,211,29,92,39,189,49,210,12,201,91,230,52,39,55,178,230,91,103,101,129,44,201,106,188,153,245,31,240,76,47,226,86,93,12,133,162,95,172,183,114,149,242,121,156,37,197,213,227,84,237,181,170,223,23,116,198,24,125,89,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65"));
		}

		#endregion

	}

	#endregion

}

