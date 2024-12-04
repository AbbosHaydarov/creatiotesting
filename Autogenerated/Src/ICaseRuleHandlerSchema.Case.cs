namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICaseRuleHandlerSchema

	/// <exclude/>
	public class ICaseRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICaseRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICaseRuleHandlerSchema(ICaseRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66c513b1-90ad-4e77-a206-4ecd2c1e8325");
			Name = "ICaseRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,65,106,3,49,12,69,215,19,200,29,68,86,205,102,124,128,164,217,132,64,178,45,233,1,84,71,51,53,120,228,65,182,11,67,232,221,35,123,218,208,54,20,188,145,244,229,255,190,24,7,138,35,90,130,51,137,96,12,93,106,247,129,59,215,103,193,228,2,47,23,215,229,162,201,209,113,255,75,34,180,249,167,223,30,56,185,228,40,170,64,37,198,24,216,198,60,12,40,211,238,171,62,113,34,233,138,107,23,4,36,123,138,32,100,209,219,236,171,107,251,189,104,126,108,142,249,205,59,11,238,190,124,218,99,164,23,221,62,34,95,60,137,106,10,108,243,26,73,52,4,147,45,127,193,159,178,74,154,158,82,9,208,124,86,200,7,202,218,208,32,50,193,24,212,241,14,10,239,197,75,83,23,196,71,198,185,51,162,224,0,172,183,125,94,81,185,198,180,218,213,171,76,91,83,103,85,250,17,220,5,102,116,120,154,199,48,171,215,5,77,201,244,221,0,102,36,146,92,161,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66c513b1-90ad-4e77-a206-4ecd2c1e8325"));
		}

		#endregion

	}

	#endregion

}

