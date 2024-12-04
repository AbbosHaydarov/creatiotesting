namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailIndicatorSchema

	/// <exclude/>
	public class EmailIndicatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailIndicatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailIndicatorSchema(EmailIndicatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051");
			Name = "EmailIndicator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,147,77,111,211,64,16,134,207,174,212,255,48,114,47,112,73,238,165,84,2,23,69,145,40,170,26,196,5,113,152,172,39,201,170,235,93,107,103,140,84,170,254,119,102,215,142,105,146,74,4,114,177,61,159,251,188,158,29,143,13,113,139,134,224,43,197,136,28,86,50,169,130,95,217,117,23,81,108,240,231,103,79,231,103,69,199,214,175,97,241,200,66,205,187,61,91,243,157,35,147,146,121,50,35,79,209,154,131,156,251,206,139,109,104,178,208,40,58,251,43,247,214,44,205,187,136,180,86,3,42,135,204,151,240,169,65,235,230,190,182,6,37,196,156,49,157,78,225,138,187,166,193,248,120,61,216,247,212,70,98,242,194,64,169,2,36,134,110,233,8,236,182,116,178,173,156,190,40,253,126,131,130,42,80,34,26,249,161,142,86,139,172,1,147,14,63,56,187,80,237,250,28,17,239,98,104,41,138,37,229,188,203,133,125,124,31,48,59,102,164,108,33,2,167,247,72,5,6,219,164,61,209,29,226,245,124,183,212,44,41,190,249,162,179,129,247,80,14,21,229,219,196,187,5,102,137,233,247,86,125,12,210,144,138,98,77,146,254,124,81,240,240,241,124,44,223,146,188,217,104,248,1,126,162,235,232,31,232,198,202,93,62,235,5,62,142,77,79,197,211,97,117,232,122,54,8,43,144,205,222,160,143,132,237,251,84,65,111,227,33,238,135,28,252,150,207,56,21,152,5,229,104,210,236,201,218,70,179,66,15,70,175,41,90,207,131,236,50,60,148,169,127,169,139,26,98,249,162,215,159,210,215,52,103,148,87,47,207,34,67,158,42,213,89,150,164,116,126,163,190,94,112,222,72,6,168,109,13,62,8,52,40,102,243,95,3,203,157,230,245,103,61,99,87,66,242,92,205,58,91,95,15,91,155,115,254,34,230,130,124,221,175,114,182,123,239,174,83,125,191,1,91,66,81,157,20,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051"));
		}

		#endregion

	}

	#endregion

}

