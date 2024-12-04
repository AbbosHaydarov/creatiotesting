namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingValidationCodesSchema

	/// <exclude/>
	public class MailingValidationCodesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingValidationCodesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingValidationCodesSchema(MailingValidationCodesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f38971ac-7530-4dd4-a0fa-d09215a8d0ef");
			Name = "MailingValidationCodes";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f5a6178-e602-42c0-b4d9-e7d8824941b4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,75,79,35,49,12,62,183,82,255,131,5,135,189,209,59,44,72,168,84,226,0,18,162,136,187,73,156,78,164,153,100,20,103,42,30,226,191,175,243,104,169,168,118,165,41,123,139,173,207,254,62,63,98,135,29,113,143,138,224,137,66,64,246,38,158,45,188,51,118,61,4,140,214,187,217,244,99,54,157,77,39,167,129,214,98,194,162,69,230,115,184,71,219,90,183,126,198,214,234,140,91,120,77,156,145,243,249,28,126,243,208,117,24,222,174,170,93,225,176,217,225,65,149,128,2,159,239,225,251,225,165,181,10,56,10,78,129,74,124,127,165,155,136,184,201,1,99,118,60,82,31,136,201,69,6,252,206,11,3,147,134,232,129,28,15,129,32,54,4,56,104,75,78,26,193,246,157,206,118,105,247,149,109,165,41,239,56,138,192,144,74,186,174,113,43,9,131,75,56,217,183,79,46,114,71,126,46,208,154,172,145,58,233,3,72,140,78,204,173,237,108,132,6,25,94,136,28,4,66,213,144,30,33,125,153,210,173,74,182,187,156,76,244,31,56,127,94,68,245,151,62,23,188,244,25,157,22,88,8,164,162,35,153,177,55,181,190,134,80,83,224,17,133,220,150,136,36,191,62,255,41,250,250,64,169,241,1,54,20,172,121,75,233,190,90,221,7,191,177,146,239,215,24,53,15,53,40,201,217,190,143,208,147,198,156,152,139,148,17,252,105,120,133,189,188,142,224,214,100,112,104,35,200,109,24,77,127,83,98,151,171,135,188,74,73,199,55,215,17,130,132,193,216,208,237,166,243,106,57,230,45,146,173,65,87,167,21,169,235,91,217,179,17,98,159,168,132,44,119,9,69,238,129,243,191,253,227,175,205,138,149,35,159,27,64,221,144,36,73,72,238,73,89,99,37,44,255,239,49,139,183,213,189,61,69,251,118,42,97,242,89,78,185,108,69,185,230,201,252,156,77,255,0,94,167,182,97,5,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f38971ac-7530-4dd4-a0fa-d09215a8d0ef"));
		}

		#endregion

	}

	#endregion

}

