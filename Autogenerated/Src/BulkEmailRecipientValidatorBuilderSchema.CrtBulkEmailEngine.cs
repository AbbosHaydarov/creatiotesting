namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailRecipientValidatorBuilderSchema

	/// <exclude/>
	public class BulkEmailRecipientValidatorBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientValidatorBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailRecipientValidatorBuilderSchema(BulkEmailRecipientValidatorBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2e4fa4cb-5936-4dd2-a2dd-ac02354cb9ca");
			Name = "BulkEmailRecipientValidatorBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,85,93,143,210,64,20,125,46,9,255,225,166,251,2,201,102,154,53,38,110,20,72,132,160,217,100,65,3,234,139,241,97,104,47,48,97,58,83,103,166,16,84,254,187,119,166,172,124,71,124,210,248,210,180,55,231,156,158,123,238,220,86,241,28,109,193,83,132,15,104,12,183,122,234,88,79,171,169,152,149,134,59,161,85,189,246,189,94,139,74,43,212,12,198,107,235,48,127,117,244,76,120,41,49,245,96,203,222,162,66,35,210,29,102,95,54,207,181,58,97,63,10,245,245,60,124,207,5,235,245,199,87,129,6,58,67,105,207,67,13,178,190,114,194,9,244,0,130,220,24,156,17,15,122,146,91,251,18,186,165,92,244,115,46,228,8,83,81,8,84,238,19,151,34,227,78,155,110,41,100,134,38,176,146,36,129,150,45,243,156,155,117,103,251,60,194,194,160,37,134,5,14,169,151,131,169,54,48,241,52,111,35,231,169,209,176,172,228,252,43,77,41,209,178,39,181,100,79,174,40,39,82,164,91,145,107,44,69,52,32,186,238,186,161,57,56,83,166,132,161,166,222,7,185,10,113,236,60,20,30,20,37,66,162,223,208,123,87,184,2,65,124,174,232,72,232,41,184,57,18,5,17,82,131,211,118,252,123,63,113,210,169,188,251,230,78,187,171,42,5,55,60,7,69,103,175,29,91,52,75,145,226,235,66,196,157,113,117,31,178,91,105,179,240,209,173,132,155,3,47,4,107,37,129,22,84,62,191,155,88,45,209,97,35,126,193,238,238,217,115,248,1,31,45,94,145,87,163,25,250,67,158,177,184,249,197,107,109,3,191,130,250,64,7,140,124,194,206,114,19,252,118,68,155,255,45,223,19,149,201,147,177,184,243,203,35,144,61,225,214,151,6,115,207,238,216,179,191,52,151,91,8,155,190,166,13,220,178,255,189,73,93,223,223,161,247,27,84,89,181,234,135,123,63,64,55,215,217,159,174,252,185,111,210,101,179,143,194,186,86,151,91,220,122,36,218,136,88,157,32,233,239,236,147,217,104,201,13,208,55,177,148,14,218,33,204,139,220,10,31,121,204,27,163,243,33,29,184,161,118,195,82,202,67,100,163,121,123,136,12,177,13,184,93,28,227,2,108,227,255,2,81,100,208,149,134,154,11,86,66,233,124,142,85,245,176,184,169,215,126,2,182,161,19,137,33,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e4fa4cb-5936-4dd2-a2dd-ac02354cb9ca"));
		}

		#endregion

	}

	#endregion

}

