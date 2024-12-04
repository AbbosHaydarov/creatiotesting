namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeTypeWebhookHandlerSchema

	/// <exclude/>
	public class DateTimeTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeTypeWebhookHandlerSchema(DateTimeTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6423a49-1ee5-458c-ab0f-20db6e65c91d");
			Name = "DateTimeTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7950703-7230-445f-b3e5-fcd99a7a2e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,193,138,219,48,16,134,207,94,216,119,24,188,151,24,22,251,158,77,12,221,44,165,61,180,4,18,232,161,244,160,216,227,68,173,45,153,145,180,37,148,190,123,71,178,236,110,155,120,217,139,177,198,51,255,63,243,141,172,68,135,166,23,21,194,30,137,132,209,141,205,55,90,53,242,232,72,88,169,213,237,205,175,219,155,196,25,169,142,176,59,27,139,221,195,116,126,89,66,152,191,23,149,213,36,209,112,6,231,220,17,30,89,0,54,173,48,102,9,79,194,226,94,118,184,63,247,248,5,15,39,173,127,124,16,170,110,145,66,118,81,20,176,50,174,235,4,157,203,120,142,105,112,26,242,160,209,196,57,136,80,17,54,235,116,84,76,139,18,44,171,230,163,76,241,159,142,175,17,173,209,177,110,102,210,252,227,198,25,171,187,203,6,83,40,188,212,215,39,108,132,107,237,163,84,53,143,191,240,158,186,89,204,150,101,247,240,153,241,194,26,166,86,175,104,103,223,88,186,119,135,86,86,80,121,84,175,144,130,37,204,186,177,138,223,212,132,125,75,186,71,178,188,142,37,108,131,124,224,124,1,58,4,56,249,89,214,108,160,184,97,207,241,18,228,216,163,177,228,119,63,86,12,19,150,227,174,118,218,81,133,204,213,88,161,172,201,223,169,243,195,43,190,161,119,47,55,238,111,222,215,79,60,60,216,45,162,31,73,101,209,227,14,85,61,140,31,207,145,197,39,180,39,93,191,5,196,212,208,207,120,247,122,65,60,161,101,52,207,162,117,115,61,134,72,72,13,4,215,169,84,189,179,105,185,27,96,133,82,208,205,21,85,127,167,71,211,124,85,132,15,127,37,9,173,35,101,202,85,49,190,189,32,162,15,223,177,178,67,53,46,226,94,130,113,6,225,42,36,178,129,137,81,190,167,243,86,144,193,69,72,185,7,237,236,116,213,128,208,240,205,206,198,194,100,176,139,97,255,199,39,201,239,240,140,31,148,107,219,16,230,232,21,242,67,244,223,32,199,254,0,166,221,26,181,110,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6423a49-1ee5-458c-ab0f-20db6e65c91d"));
		}

		#endregion

	}

	#endregion

}

