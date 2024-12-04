namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailProcessTemplateUserTaskMessageProviderSchema

	/// <exclude/>
	public class EmailProcessTemplateUserTaskMessageProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailProcessTemplateUserTaskMessageProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailProcessTemplateUserTaskMessageProviderSchema(EmailProcessTemplateUserTaskMessageProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b79b40c-b679-49a4-ace9-9049573f8669");
			Name = "EmailProcessTemplateUserTaskMessageProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,77,110,194,48,16,133,215,65,226,14,150,186,9,155,28,0,196,2,104,212,21,18,45,244,0,38,153,4,139,196,14,51,54,82,84,113,247,142,243,3,4,216,176,137,226,241,123,243,190,241,104,89,2,85,50,1,177,3,68,73,38,179,209,202,32,68,27,52,9,16,241,65,103,42,119,40,173,50,122,60,250,27,143,2,71,74,231,3,253,157,164,55,126,2,169,92,3,206,94,26,56,32,214,86,89,5,196,2,150,124,32,228,236,22,171,66,18,77,69,92,74,85,116,157,118,80,86,133,180,240,75,128,59,73,199,53,215,100,14,124,123,86,41,96,99,175,220,190,80,137,72,188,251,29,179,152,138,165,36,232,196,141,241,169,125,192,51,243,247,134,104,52,89,116,137,53,200,164,155,38,185,85,116,20,111,228,135,141,246,81,36,92,247,51,241,93,131,169,216,51,99,120,45,10,191,132,224,210,81,129,78,91,176,33,229,26,236,193,164,30,16,141,133,196,66,218,49,246,71,97,206,188,16,134,16,60,141,223,207,23,216,134,102,105,210,58,236,66,2,4,235,80,183,35,245,120,145,87,204,238,24,94,244,140,253,118,235,109,114,128,82,126,59,192,218,183,223,50,43,96,76,167,107,251,103,25,208,73,204,155,129,163,161,163,9,12,84,38,218,55,187,194,120,73,251,138,117,5,98,62,23,161,210,118,50,168,70,11,103,77,31,25,112,66,196,238,69,90,42,253,163,242,131,37,14,204,100,65,208,70,240,80,183,193,89,124,63,233,195,107,183,213,97,241,242,15,220,94,197,116,83,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b79b40c-b679-49a4-ace9-9049573f8669"));
		}

		#endregion

	}

	#endregion

}

