namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingResponseSchema

	/// <exclude/>
	public class MailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingResponseSchema(MailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e");
			Name = "MailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6e206974-7c3f-4704-9c49-6b38b2d992b2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,84,75,79,219,64,16,62,19,41,255,97,36,238,201,29,80,14,77,81,132,68,218,40,70,229,128,122,88,175,199,238,170,251,176,246,129,128,136,255,206,236,174,157,167,131,168,122,137,188,179,243,61,60,243,197,154,41,116,45,227,8,15,104,45,115,166,246,147,185,209,181,104,130,101,94,24,61,30,109,198,163,241,232,34,56,161,27,40,94,157,71,117,125,116,38,132,148,200,99,187,155,44,80,163,21,252,164,103,29,180,23,10,39,5,221,50,41,222,18,59,117,81,223,165,197,134,14,48,151,204,185,43,88,50,33,9,184,38,99,68,136,169,101,58,157,194,141,11,74,49,251,58,131,174,176,178,230,89,84,232,160,181,166,69,235,5,61,154,26,252,31,132,50,200,191,128,138,152,192,161,174,162,15,219,241,77,122,186,105,207,71,133,167,239,204,51,122,113,111,25,247,191,169,208,134,82,10,14,60,90,58,117,116,145,135,178,117,190,218,26,184,130,85,66,230,251,3,219,125,129,104,130,244,209,105,103,45,58,58,181,148,61,45,81,149,104,163,163,222,82,105,140,132,34,112,142,228,108,3,13,250,107,34,162,159,247,79,52,191,237,205,195,51,31,220,191,105,46,130,168,160,72,192,187,234,203,162,11,244,180,16,27,27,29,224,11,199,54,238,252,140,114,167,116,219,183,237,61,13,232,117,221,206,219,184,218,53,42,145,38,121,207,223,138,84,154,155,10,135,112,79,63,75,103,36,122,220,127,187,187,91,29,20,90,86,74,188,201,140,51,248,97,188,168,5,79,41,189,231,110,199,58,56,243,1,162,95,20,242,42,193,243,190,31,45,107,41,35,51,56,190,24,36,188,164,100,228,108,165,115,174,30,15,57,158,99,102,153,208,14,132,174,141,85,137,23,88,105,130,135,231,173,208,80,226,15,2,126,198,44,108,62,217,238,14,3,244,13,113,172,137,255,139,243,139,237,86,181,67,45,51,232,203,105,250,95,189,28,137,168,21,165,72,169,155,234,225,168,223,199,163,15,139,1,71,84,20,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e"));
		}

		#endregion

	}

	#endregion

}

