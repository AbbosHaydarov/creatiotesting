namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWorkplaceContentChangedNotifierSchema

	/// <exclude/>
	public class IWorkplaceContentChangedNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWorkplaceContentChangedNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWorkplaceContentChangedNotifierSchema(IWorkplaceContentChangedNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9069699-d4c5-46f2-903e-71f11dc83ff9");
			Name = "IWorkplaceContentChangedNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9229ed18-5614-47df-8744-72b0c7198840");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,49,79,195,48,16,133,231,68,202,127,56,181,11,44,201,14,165,75,134,42,3,8,169,72,12,136,193,77,206,169,69,227,139,124,54,40,66,253,239,156,29,82,1,35,131,45,221,89,239,123,247,206,96,213,128,60,170,22,225,9,157,83,76,218,151,53,89,109,250,224,148,55,100,139,252,179,200,179,192,198,246,176,159,216,227,112,91,228,210,169,170,10,54,28,134,65,185,105,251,93,55,214,163,211,17,166,201,1,163,237,162,202,146,55,218,180,137,6,226,198,170,71,80,7,10,30,62,200,189,141,167,40,104,73,180,214,67,123,84,182,23,85,185,88,84,63,60,198,112,56,153,22,204,197,166,121,94,0,245,172,175,163,28,187,135,100,137,78,52,50,189,220,217,218,97,31,253,239,209,31,169,227,27,120,76,172,248,20,207,223,52,169,177,151,0,252,255,241,103,232,168,156,26,32,174,249,110,21,24,93,211,241,106,43,23,144,134,88,51,120,74,171,90,216,229,166,74,154,203,24,191,86,144,189,147,233,32,229,155,174,118,193,116,47,175,9,35,196,235,249,99,178,181,192,230,180,82,157,139,252,252,5,220,35,188,86,229,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9069699-d4c5-46f2-903e-71f11dc83ff9"));
		}

		#endregion

	}

	#endregion

}

