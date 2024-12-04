namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCrudObjectColumnValueSchema

	/// <exclude/>
	public class CampaignCrudObjectColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCrudObjectColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCrudObjectColumnValueSchema(CampaignCrudObjectColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64496986-5fe2-4f0f-beca-e34f759c7102");
			Name = "CampaignCrudObjectColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,203,78,3,49,12,60,183,82,255,193,82,239,221,59,69,92,22,241,56,84,32,160,189,123,19,239,110,80,30,37,78,144,170,138,127,39,155,108,17,15,149,246,98,37,99,123,102,108,91,52,196,91,20,4,47,228,61,178,107,195,162,118,182,85,93,244,24,148,179,179,233,126,54,157,68,86,182,131,231,29,7,50,203,217,52,33,115,79,93,74,67,173,145,249,2,106,52,91,84,157,173,125,148,15,205,43,137,80,59,29,141,221,160,142,148,27,170,170,130,75,142,198,160,223,93,141,255,82,3,239,67,17,24,39,73,67,232,49,128,98,136,76,18,154,29,136,145,24,234,167,245,53,184,76,13,164,201,144,13,188,56,240,86,223,136,183,177,209,74,128,24,140,157,242,53,73,195,165,248,53,205,138,66,239,100,154,231,49,147,148,228,111,231,25,88,91,245,150,76,43,153,124,168,86,145,7,215,194,240,14,201,115,150,24,204,253,117,119,176,119,27,149,28,231,95,223,75,216,67,71,97,9,60,132,143,127,100,55,121,85,73,138,211,14,68,72,59,58,71,108,92,91,105,62,87,234,70,99,7,193,129,178,82,9,12,84,78,83,110,213,35,131,65,225,93,62,193,113,225,198,57,13,119,200,171,92,123,84,127,78,86,150,11,228,127,65,127,130,9,251,4,22,182,146,63,172,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64496986-5fe2-4f0f-beca-e34f759c7102"));
		}

		#endregion

	}

	#endregion

}

