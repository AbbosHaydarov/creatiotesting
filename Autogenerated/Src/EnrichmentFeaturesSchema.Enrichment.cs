namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichmentFeaturesSchema

	/// <exclude/>
	public class EnrichmentFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichmentFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichmentFeaturesSchema(EnrichmentFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b04c4e9f-9c27-4baf-aabc-9d025acb482c");
			Name = "EnrichmentFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("523e180e-845f-4752-bb0d-120bebcd70d6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,77,75,195,64,16,134,207,9,228,63,12,245,162,151,228,94,173,80,106,5,15,162,135,250,3,166,155,201,118,33,217,13,51,187,130,72,255,187,147,143,26,138,224,101,23,222,60,121,247,153,241,216,145,244,104,8,14,196,140,18,154,88,238,130,111,156,77,140,209,5,95,238,61,59,115,234,200,199,34,255,46,242,44,137,243,22,118,76,195,231,242,89,175,196,116,8,214,182,154,223,23,185,34,125,58,182,206,128,105,81,4,150,255,103,86,148,24,138,174,177,15,161,183,109,138,39,88,195,204,189,82,196,26,35,14,168,242,195,149,221,48,89,149,2,85,148,200,201,196,192,178,134,247,177,104,70,170,170,130,7,73,93,135,252,245,248,155,104,61,76,253,168,135,202,56,51,142,7,77,96,64,99,72,198,177,22,89,16,226,79,103,168,92,74,171,171,214,217,254,226,125,123,7,227,80,89,246,34,123,143,199,150,106,216,128,58,146,238,100,136,159,72,12,187,126,124,116,3,171,127,133,254,106,172,166,150,243,101,15,228,235,105,21,83,48,229,122,158,161,200,127,0,28,237,193,171,212,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b04c4e9f-9c27-4baf-aabc-9d025acb482c"));
		}

		#endregion

	}

	#endregion

}

