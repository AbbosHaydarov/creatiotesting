namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationRuleSchema

	/// <exclude/>
	public class IMailingStateValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationRuleSchema(IMailingStateValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d21ccf92-5dc5-4e8f-9f1a-b4b1c7befaaa");
			Name = "IMailingStateValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,79,79,195,48,12,197,207,173,212,239,96,149,11,92,218,59,108,189,32,14,59,76,66,99,226,30,90,103,139,212,58,149,227,32,16,226,187,227,254,217,90,129,144,114,72,94,156,159,159,95,200,116,24,122,83,35,28,145,217,4,111,165,120,244,100,221,41,178,17,231,41,75,191,178,52,75,147,178,44,97,19,98,215,25,254,172,230,243,1,123,198,128,36,1,228,140,176,55,174,117,116,122,17,35,248,106,90,215,140,128,67,108,17,106,79,194,166,150,226,66,42,87,168,62,190,181,174,6,71,130,108,7,43,187,255,73,90,62,249,73,110,24,79,42,194,30,229,236,155,112,15,207,35,102,186,252,237,118,16,146,167,15,172,163,32,188,95,137,96,61,67,232,177,118,214,97,3,172,13,138,235,243,181,197,73,233,13,155,14,72,35,219,230,97,240,150,87,71,157,123,220,142,168,133,92,108,202,177,122,121,204,40,145,41,84,59,210,122,210,41,189,85,139,168,217,48,218,109,190,26,83,63,196,83,192,188,172,128,151,132,87,174,85,138,173,4,237,113,129,14,93,254,18,96,150,240,118,29,232,228,247,238,97,142,17,169,153,146,28,207,223,89,170,235,7,66,225,197,19,22,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d21ccf92-5dc5-4e8f-9f1a-b4b1c7befaaa"));
		}

		#endregion

	}

	#endregion

}

