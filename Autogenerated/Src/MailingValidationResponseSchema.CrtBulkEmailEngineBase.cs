namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingValidationResponseSchema

	/// <exclude/>
	public class MailingValidationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingValidationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingValidationResponseSchema(MailingValidationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd9b38cb-05b6-4b32-864e-0f463622ed1e");
			Name = "MailingValidationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f64a0efe-cafe-4865-b986-9aab139aa761");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,207,78,195,48,12,135,207,173,212,119,240,3,160,246,206,166,93,0,33,14,92,54,196,5,113,112,131,219,89,202,159,41,78,134,198,180,119,199,45,235,6,168,145,18,41,241,47,95,62,199,163,35,217,161,33,120,161,24,81,66,151,234,187,224,59,238,115,196,196,193,87,229,177,42,65,71,22,246,61,108,14,146,200,105,196,90,50,67,93,234,71,242,20,217,44,102,98,235,236,19,59,170,55,26,64,203,95,35,81,131,85,89,52,77,3,75,201,206,97,60,172,206,251,181,170,40,145,110,224,115,203,102,11,38,248,132,236,5,216,119,33,186,241,54,96,27,114,130,189,226,62,206,130,63,172,70,174,176,183,123,76,168,109,164,136,38,189,235,193,46,183,150,13,24,139,34,240,140,108,85,242,245,130,152,222,189,133,63,173,171,245,158,13,77,85,208,143,40,138,97,254,119,31,15,174,56,136,36,217,38,185,68,127,171,77,42,79,15,62,59,138,216,90,90,206,9,41,96,53,107,58,144,225,8,61,165,5,200,176,156,148,170,243,244,13,151,21,36,207,203,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd9b38cb-05b6-4b32-864e-0f463622ed1e"));
		}

		#endregion

	}

	#endregion

}

