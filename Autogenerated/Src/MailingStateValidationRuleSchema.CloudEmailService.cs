namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateValidationRuleSchema

	/// <exclude/>
	public class MailingStateValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateValidationRuleSchema(MailingStateValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a9f50c4-bce9-47b7-a069-b260821478be");
			Name = "MailingStateValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,49,79,195,48,16,133,231,68,202,127,56,133,5,150,68,172,208,102,169,24,58,84,66,165,98,55,201,185,181,148,156,163,243,25,129,16,255,157,75,210,54,17,8,201,131,253,124,254,238,221,51,153,14,67,111,106,132,3,50,155,224,173,20,27,79,214,29,35,27,113,158,178,244,43,75,179,52,41,203,18,86,33,118,157,225,207,234,124,222,99,207,24,144,36,128,156,16,118,198,181,142,142,47,98,4,95,77,235,154,17,176,143,45,66,237,73,216,212,82,92,72,229,2,213,199,183,214,213,224,72,144,237,96,101,251,63,233,94,235,39,67,201,13,227,81,85,216,161,156,124,19,30,224,121,228,76,151,191,237,14,66,242,244,129,117,20,132,247,43,18,172,103,8,61,214,206,58,108,128,181,67,113,125,190,244,56,41,189,97,211,1,105,102,235,60,12,230,242,234,160,131,143,219,17,53,147,139,85,57,86,207,143,25,37,50,133,106,75,90,79,58,166,183,106,17,53,28,70,187,206,23,115,234,143,120,10,152,151,21,240,28,241,194,181,74,177,149,160,61,46,208,161,203,95,2,156,37,188,93,38,58,249,189,123,60,199,136,212,76,73,142,231,239,44,213,245,3,23,71,181,188,23,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a9f50c4-bce9-47b7-a069-b260821478be"));
		}

		#endregion

	}

	#endregion

}

