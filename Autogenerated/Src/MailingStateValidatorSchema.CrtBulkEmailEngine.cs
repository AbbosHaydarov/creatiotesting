namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateValidatorSchema

	/// <exclude/>
	public class MailingStateValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateValidatorSchema(MailingStateValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c9024bb-355f-4ec3-8193-b5436b64da82");
			Name = "MailingStateValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,203,110,219,48,16,69,215,50,224,127,152,122,229,108,164,15,168,227,69,131,162,200,162,155,56,200,182,24,83,163,152,8,69,9,28,82,133,17,228,223,51,124,248,17,196,14,178,144,44,15,57,119,120,207,165,197,158,120,68,69,240,72,206,33,15,157,175,239,6,219,233,231,224,208,235,193,206,103,175,243,89,21,88,219,103,216,236,217,83,47,235,198,144,138,139,92,255,33,75,78,171,159,243,153,236,106,154,6,86,28,250,30,221,126,93,254,63,208,232,136,201,122,6,191,35,152,208,232,22,253,224,160,147,167,71,109,162,48,123,244,196,128,74,13,174,141,5,63,164,221,46,24,226,250,160,220,156,73,143,97,107,180,2,101,144,25,254,102,153,77,84,121,58,12,144,77,241,228,213,232,244,36,117,112,132,237,96,205,30,238,127,219,208,147,195,173,161,213,253,133,86,241,245,32,115,215,240,47,141,207,214,62,121,75,133,59,17,21,105,109,197,128,101,130,255,218,239,128,71,82,186,211,212,194,54,104,211,146,139,6,62,59,200,149,17,29,246,96,37,133,219,69,28,247,43,183,44,214,143,98,255,3,158,4,67,36,147,226,170,73,141,73,167,160,184,8,97,121,197,96,25,147,52,203,247,13,36,92,85,118,13,183,231,107,18,179,143,76,120,121,35,56,170,234,237,11,38,101,136,72,196,4,175,37,123,130,116,204,248,59,136,146,220,98,157,220,164,27,52,29,45,93,98,50,105,231,3,154,15,145,63,157,82,150,155,47,119,88,146,46,53,90,158,211,202,103,63,96,145,97,132,106,7,215,136,70,60,57,34,109,203,205,57,180,86,19,10,105,226,96,124,193,90,31,7,230,25,9,106,85,237,53,25,1,66,62,56,91,26,202,138,238,96,249,35,87,234,77,80,138,248,164,94,218,182,114,190,151,178,93,242,137,63,233,157,190,227,75,158,183,119,55,83,149,151,239,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c9024bb-355f-4ec3-8193-b5436b64da82"));
		}

		#endregion

	}

	#endregion

}

