namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationBuilderSchema

	/// <exclude/>
	public class IMailingStateValidationBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationBuilderSchema(IMailingStateValidationBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba");
			Name = "IMailingStateValidationBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,145,77,107,195,48,12,134,207,9,228,63,136,246,178,93,226,251,150,229,208,49,74,15,133,178,142,221,221,68,73,12,254,40,178,220,81,198,254,251,236,120,133,110,99,48,48,194,122,101,189,122,108,91,105,208,31,101,135,240,130,68,210,187,129,235,71,103,7,53,6,146,172,156,173,202,247,170,44,130,87,118,132,253,217,51,154,88,215,26,187,84,244,245,26,45,146,234,238,171,50,158,18,66,64,227,131,49,146,206,237,87,190,35,119,82,61,122,48,200,147,235,129,29,140,200,64,65,71,109,112,4,158,37,35,156,164,86,189,100,71,245,197,71,92,25,29,195,65,171,14,148,101,164,33,193,110,182,82,233,136,180,79,205,175,185,55,242,172,130,210,61,82,236,136,208,49,22,75,194,49,234,176,157,135,251,59,216,205,78,185,40,126,224,206,194,26,217,3,79,120,69,104,242,172,239,164,209,53,161,254,102,205,10,33,7,178,190,109,60,34,116,132,195,195,98,243,100,131,65,146,7,141,205,31,252,207,113,102,187,16,45,188,41,158,50,65,221,136,139,87,50,255,175,73,186,71,218,248,155,219,252,55,197,18,109,159,95,99,206,63,170,50,174,79,4,158,131,14,255,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba"));
		}

		#endregion

	}

	#endregion

}

