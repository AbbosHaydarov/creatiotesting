namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateCommLangHandlerSchema

	/// <exclude/>
	public class EmailTemplateCommLangHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateCommLangHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateCommLangHandlerSchema(EmailTemplateCommLangHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e74a254-fcca-4fb6-be7b-59789815c512");
			Name = "EmailTemplateCommLangHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,77,75,195,64,16,61,71,240,63,12,233,69,65,155,187,218,128,150,162,130,55,235,15,152,110,38,97,33,59,9,251,161,84,241,191,59,155,164,106,109,27,240,34,94,22,102,246,205,219,55,111,134,101,52,228,90,84,4,75,178,22,93,83,250,233,188,225,82,87,193,162,215,13,195,241,209,219,241,81,18,156,230,10,30,215,206,147,185,252,140,191,215,88,58,148,159,46,216,107,175,201,9,64,32,19,75,85,36,158,215,232,220,5,44,12,234,122,73,166,173,209,211,188,49,230,1,185,186,67,46,106,178,29,62,203,50,184,114,193,24,180,235,124,136,175,25,112,229,188,69,229,129,206,35,3,248,129,2,148,112,4,214,170,151,95,11,91,192,138,192,146,34,253,76,118,186,161,204,190,113,182,97,85,107,245,197,169,162,182,81,105,48,174,252,6,29,9,175,88,39,231,78,11,93,98,46,16,160,104,205,58,106,218,21,149,180,182,241,164,60,21,61,54,30,157,149,107,136,35,73,146,138,60,204,114,24,114,232,58,68,156,66,146,184,173,171,25,60,99,29,250,171,247,17,73,247,44,115,194,90,191,18,48,189,128,102,231,145,101,55,154,82,176,36,214,90,42,103,233,88,223,41,100,249,129,110,186,76,139,22,13,176,108,221,44,85,162,246,190,72,243,174,57,25,79,99,11,208,69,116,164,212,50,167,171,172,3,239,175,13,142,172,236,41,139,61,50,229,52,127,146,88,38,191,73,108,21,127,217,56,166,252,228,54,232,2,122,77,103,240,180,197,15,219,207,157,118,22,95,192,74,192,39,155,138,31,16,120,131,255,227,52,113,92,131,52,95,244,219,246,215,206,246,207,14,187,254,27,111,55,21,123,189,29,54,121,66,92,244,63,74,12,223,63,0,79,46,213,199,209,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e74a254-fcca-4fb6-be7b-59789815c512"));
		}

		#endregion

	}

	#endregion

}

