namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsValidationResultSchema

	/// <exclude/>
	public class ActiveContactsValidationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsValidationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsValidationResultSchema(ActiveContactsValidationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45311f20-f594-44c6-8b97-79025c4a6695");
			Name = "ActiveContactsValidationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,79,75,196,48,16,197,207,41,244,59,12,236,189,213,171,171,130,22,143,194,162,226,61,166,179,37,208,38,101,102,178,32,139,223,221,52,177,251,71,196,109,14,129,60,222,123,191,100,136,211,3,242,168,13,194,27,18,105,246,91,169,26,239,182,182,11,164,197,122,87,22,251,178,40,11,136,107,69,216,69,5,154,94,51,223,192,131,17,187,195,104,22,109,132,223,117,111,219,148,120,65,14,189,204,161,186,174,225,150,195,48,104,250,188,63,74,143,154,17,118,135,12,80,10,85,39,153,250,60,52,134,143,222,26,48,19,251,34,90,165,59,43,245,11,158,133,163,29,56,24,131,204,213,193,123,2,85,106,70,122,199,2,214,9,188,102,59,220,193,213,122,25,32,206,212,211,210,250,167,201,28,203,175,127,202,231,121,111,200,143,72,98,49,14,125,147,66,203,224,198,183,248,63,123,162,54,209,5,123,232,80,214,192,211,246,181,172,61,254,27,214,221,5,0,11,89,215,193,115,246,254,133,89,161,107,243,59,211,57,171,231,98,212,190,1,22,229,24,109,167,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45311f20-f594-44c6-8b97-79025c4a6695"));
		}

		#endregion

	}

	#endregion

}

