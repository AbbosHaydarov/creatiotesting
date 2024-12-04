namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchFeaturesSchema

	/// <exclude/>
	public class GlobalSearchFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchFeaturesSchema(GlobalSearchFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ce6e5c0-35f8-4d5b-be9a-e16f527da2d1");
			Name = "GlobalSearchFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ca3090cb-7cbd-4956-acde-76442c58fa1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,77,78,3,49,12,133,215,29,169,119,176,202,6,54,115,128,34,22,104,248,17,11,4,18,237,1,60,25,207,52,82,72,70,118,194,6,245,238,56,147,84,208,74,100,225,72,207,207,95,252,226,241,147,100,70,67,176,35,102,148,48,198,182,11,126,180,83,98,140,54,248,246,217,133,30,221,7,33,155,195,186,249,94,55,171,36,214,79,208,49,101,67,251,164,87,98,218,133,105,114,170,223,174,27,181,92,49,77,58,12,157,67,145,45,252,101,84,191,44,190,57,245,206,26,48,217,246,143,107,165,79,106,189,68,238,133,222,238,83,60,148,230,25,103,95,91,176,133,138,121,165,136,3,70,204,214,138,251,229,5,47,145,147,137,129,21,251,190,128,170,165,82,79,188,235,27,200,241,245,188,200,163,199,222,209,0,119,160,179,164,161,179,252,64,98,216,206,249,219,180,177,209,57,40,139,160,22,242,209,154,229,75,97,12,92,195,66,73,11,66,252,101,13,109,10,232,120,90,145,252,80,182,44,66,213,47,228,162,158,139,199,31,66,168,22,27,216,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ce6e5c0-35f8-4d5b-be9a-e16f527da2d1"));
		}

		#endregion

	}

	#endregion

}

