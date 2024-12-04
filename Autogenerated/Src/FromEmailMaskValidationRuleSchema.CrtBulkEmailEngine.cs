namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromEmailMaskValidationRuleSchema

	/// <exclude/>
	public class FromEmailMaskValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromEmailMaskValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromEmailMaskValidationRuleSchema(FromEmailMaskValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246");
			Name = "FromEmailMaskValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,95,111,211,48,16,127,206,164,125,135,219,144,166,86,66,206,251,88,247,64,129,169,130,34,212,141,190,187,201,165,181,234,216,193,103,23,85,104,223,157,179,157,132,18,36,94,156,248,238,252,251,115,62,27,217,34,117,178,66,120,65,231,36,217,198,139,165,53,141,218,7,39,189,178,6,174,175,126,93,95,21,129,148,217,195,243,153,60,182,92,160,53,86,49,75,226,9,13,58,85,189,155,214,124,81,230,7,7,57,252,198,225,62,2,45,181,36,186,7,248,228,108,251,177,149,74,175,37,29,183,82,171,58,17,109,130,198,84,95,150,37,60,80,104,91,233,206,143,253,126,131,157,67,66,227,9,252,1,161,138,80,240,83,249,67,94,28,159,37,176,13,156,70,56,104,172,3,140,52,4,13,51,66,43,43,103,9,118,103,254,163,163,24,136,202,11,166,46,236,180,170,122,244,255,200,132,123,120,47,9,39,65,6,224,78,241,58,58,94,163,63,216,154,61,127,115,214,115,195,176,206,249,169,195,20,232,209,48,59,100,175,53,246,6,178,254,24,189,208,196,102,162,135,127,77,228,72,39,157,108,193,240,237,46,110,29,86,170,83,220,188,219,199,205,240,27,155,181,11,250,152,25,196,67,153,14,164,243,221,32,22,236,137,103,66,213,8,39,171,106,88,25,143,206,72,61,8,157,173,214,72,36,247,56,130,174,76,99,97,100,155,67,28,156,162,56,73,23,239,37,224,168,30,22,240,132,62,121,216,14,137,17,100,54,2,188,133,53,23,243,76,241,64,146,39,241,183,251,207,120,158,199,169,43,10,213,192,108,66,112,179,0,19,180,134,187,59,184,233,65,190,123,254,120,133,36,6,3,169,116,114,50,38,3,138,63,218,230,131,141,98,212,37,86,134,129,164,222,240,203,97,101,184,180,220,162,5,204,20,123,238,201,46,83,98,41,77,133,26,235,231,116,167,244,193,50,145,249,106,253,150,31,78,163,176,206,46,94,227,202,75,26,32,174,204,51,148,246,57,122,25,124,253,13,198,89,71,146,184,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246"));
		}

		#endregion

	}

	#endregion

}

