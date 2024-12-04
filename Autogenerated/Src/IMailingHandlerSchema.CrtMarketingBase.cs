namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingHandlerSchema

	/// <exclude/>
	public class IMailingHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingHandlerSchema(IMailingHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6d073d5-261f-4fd0-a166-ab3452299b92");
			Name = "IMailingHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,191,110,131,48,16,198,231,32,241,14,167,100,105,23,188,167,105,150,44,97,136,20,69,237,3,92,225,0,75,216,70,103,131,84,69,125,247,58,118,160,208,116,233,98,233,254,124,223,253,124,182,70,69,182,195,130,224,141,152,209,154,202,101,7,163,43,89,247,140,78,26,157,38,215,52,89,245,86,234,122,209,194,244,146,38,190,178,97,170,125,27,228,218,17,87,222,104,11,249,9,101,235,251,143,168,203,150,56,180,9,33,96,103,123,165,144,63,247,247,248,204,102,144,37,89,144,163,22,42,195,224,26,2,21,29,160,137,22,217,232,32,102,22,93,255,209,202,98,38,126,152,187,242,232,254,156,24,79,228,26,83,218,45,156,131,52,22,127,147,133,196,129,9,93,32,179,14,181,247,54,85,224,154,241,60,2,197,76,135,140,10,180,223,235,235,186,183,196,126,155,154,138,219,42,215,251,124,102,119,171,65,49,21,179,157,8,202,96,52,24,89,222,25,70,201,211,251,194,43,200,127,194,231,248,24,127,95,230,66,202,12,255,190,76,96,136,210,137,97,28,179,33,93,198,157,134,248,43,254,132,69,210,231,190,1,208,161,231,13,92,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6d073d5-261f-4fd0-a166-ab3452299b92"));
		}

		#endregion

	}

	#endregion

}

