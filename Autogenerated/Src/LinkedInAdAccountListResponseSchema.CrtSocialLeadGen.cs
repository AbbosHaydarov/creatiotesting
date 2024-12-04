namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LinkedInAdAccountListResponseSchema

	/// <exclude/>
	public class LinkedInAdAccountListResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LinkedInAdAccountListResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LinkedInAdAccountListResponseSchema(LinkedInAdAccountListResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26f7958d-2eef-c66c-ca40-74d11543a381");
			Name = "LinkedInAdAccountListResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5eec482-a90e-42cc-86d3-ef2673139bae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,146,205,106,195,48,16,132,207,54,248,29,22,114,183,239,73,8,132,28,74,192,148,208,244,5,84,105,99,68,109,201,104,165,66,8,121,247,174,227,159,56,142,105,41,244,34,240,104,118,230,147,100,35,42,164,90,72,132,119,116,78,144,61,249,116,103,205,73,23,193,9,175,173,73,143,86,106,81,230,40,212,11,154,36,190,36,113,20,72,155,2,142,103,242,88,177,187,44,81,54,86,74,217,129,78,203,85,18,179,107,225,176,96,21,118,165,32,90,66,174,205,39,170,189,217,170,173,148,54,24,159,107,242,111,92,206,131,120,27,200,178,12,214,20,170,74,184,243,166,251,238,229,108,164,215,225,163,212,18,100,147,251,115,44,44,225,1,159,117,127,112,246,75,43,116,247,234,136,207,196,235,20,120,72,108,119,167,116,61,222,51,223,35,224,40,38,234,155,134,42,134,169,209,121,141,220,119,184,77,117,134,167,182,161,110,166,175,47,36,239,154,135,25,26,247,10,46,80,160,95,1,53,203,245,63,179,95,249,199,153,77,95,160,81,237,233,90,161,211,167,242,111,55,240,247,235,110,30,126,61,240,109,238,168,52,199,57,225,105,213,177,120,253,6,95,18,60,9,27,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26f7958d-2eef-c66c-ca40-74d11543a381"));
		}

		#endregion

	}

	#endregion

}

