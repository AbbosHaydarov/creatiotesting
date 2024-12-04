namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskContactLanguageRuleSchema

	/// <exclude/>
	public class EmailTemplateUserTaskContactLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskContactLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskContactLanguageRuleSchema(EmailTemplateUserTaskContactLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93d56a0b-3d90-4502-a157-7f5bc05c865d");
			Name = "EmailTemplateUserTaskContactLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,75,107,219,64,16,62,43,144,255,48,85,47,54,24,233,238,23,20,97,130,161,105,211,196,233,125,35,141,228,165,210,174,58,187,155,34,74,254,123,103,245,112,44,165,13,238,197,48,163,111,230,123,104,100,37,42,52,181,72,17,14,72,36,140,206,109,148,104,149,203,194,145,176,82,171,235,171,223,215,87,129,51,82,21,240,208,24,139,213,234,84,39,154,112,92,69,59,101,165,149,104,184,205,15,62,18,22,188,3,146,82,24,179,100,132,178,34,181,159,133,42,156,40,240,222,149,216,194,226,56,134,181,113,85,37,168,217,246,117,59,178,0,123,20,22,106,210,207,50,67,3,101,63,9,57,233,10,210,110,93,15,50,104,65,42,192,74,200,18,88,102,93,10,139,224,12,18,88,97,126,0,122,101,77,52,208,197,103,124,181,123,42,101,10,169,167,132,157,95,112,232,231,31,121,252,192,211,127,81,14,75,216,143,157,4,156,20,255,158,92,223,145,174,145,124,26,75,184,107,41,186,231,83,187,109,195,51,121,71,10,83,31,187,215,249,86,232,160,212,131,147,19,118,90,250,23,22,4,5,218,149,15,197,191,160,224,165,87,134,42,235,196,141,149,242,176,177,228,82,171,233,18,173,9,33,103,99,56,110,99,133,226,219,209,57,131,16,33,37,204,55,225,165,9,134,241,246,31,54,219,78,45,72,84,160,248,64,55,161,27,57,12,183,211,180,214,113,139,62,207,232,82,21,179,73,122,99,170,121,159,230,4,180,153,192,46,9,249,22,237,81,103,151,228,251,245,201,10,206,246,245,220,249,248,249,122,115,201,166,255,255,242,223,203,88,170,35,146,180,153,78,33,62,15,239,198,201,12,110,240,20,212,62,155,181,173,238,35,186,199,84,83,182,207,134,112,158,5,1,154,159,156,138,194,95,208,254,5,52,15,233,145,5,125,115,72,205,36,225,232,28,112,43,20,175,167,5,132,253,171,9,231,171,211,206,193,127,162,75,87,169,47,124,9,76,193,68,209,167,44,235,122,179,112,80,24,237,179,112,30,121,76,55,223,145,12,73,245,85,55,205,190,186,122,34,108,49,181,215,109,146,57,204,198,107,62,176,81,87,150,131,253,128,208,58,82,99,46,207,114,104,106,236,133,126,23,165,195,181,207,112,59,123,107,171,103,226,3,122,221,230,177,209,174,170,109,243,206,113,117,221,113,243,229,15,140,57,173,110,212,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93d56a0b-3d90-4502-a157-7f5bc05c865d"));
		}

		#endregion

	}

	#endregion

}

