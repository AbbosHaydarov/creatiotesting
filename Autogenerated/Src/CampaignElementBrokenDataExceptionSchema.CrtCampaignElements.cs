namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignElementBrokenDataExceptionSchema

	/// <exclude/>
	public class CampaignElementBrokenDataExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignElementBrokenDataExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignElementBrokenDataExceptionSchema(CampaignElementBrokenDataExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("244e9e83-75da-48e7-886d-ea2dfe372f7f");
			Name = "CampaignElementBrokenDataException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,77,111,194,48,12,61,15,137,255,96,117,23,118,105,239,12,56,140,113,216,109,210,248,3,110,234,150,104,77,82,197,169,24,67,252,247,185,105,128,125,28,216,37,146,159,252,158,159,159,99,209,16,119,168,8,182,228,61,178,171,67,190,118,182,214,77,239,49,104,103,243,53,154,14,117,99,55,45,25,178,129,167,147,227,116,114,215,179,182,13,188,29,56,144,121,156,78,4,185,247,212,72,63,172,91,100,158,195,47,218,147,119,239,100,159,49,224,230,67,81,55,40,71,86,81,20,176,224,222,24,244,135,85,170,47,29,160,109,165,21,6,170,160,140,124,112,94,48,229,44,107,25,108,3,84,34,40,8,168,52,13,104,28,151,159,165,139,111,218,93,95,182,90,129,26,12,254,195,31,204,175,78,132,45,91,203,123,93,83,76,4,223,171,224,188,108,251,26,165,199,142,223,43,69,224,197,234,160,177,213,159,196,128,96,105,47,174,57,160,149,224,93,13,97,71,66,33,2,229,169,94,102,183,189,101,197,42,237,177,215,97,7,231,41,8,220,145,210,181,150,196,228,156,146,150,92,151,177,161,33,143,191,129,140,72,135,30,13,88,249,8,203,44,181,103,171,173,56,74,133,184,67,73,154,88,121,93,138,253,193,108,20,207,23,69,228,70,169,20,238,109,235,51,137,109,248,59,73,253,65,98,46,145,105,118,169,143,112,74,81,147,173,198,180,99,61,162,63,193,211,23,65,86,41,137,192,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("244e9e83-75da-48e7-886d-ea2dfe372f7f"));
		}

		#endregion

	}

	#endregion

}

