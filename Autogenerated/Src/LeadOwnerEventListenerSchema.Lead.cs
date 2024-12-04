namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadOwnerEventListenerSchema

	/// <exclude/>
	public class LeadOwnerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadOwnerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadOwnerEventListenerSchema(LeadOwnerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("265f0b5e-a6be-455d-942d-40f04c0b5236");
			Name = "LeadOwnerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,61,111,2,49,12,157,65,226,63,88,215,165,44,201,78,161,3,136,13,193,64,55,196,224,6,223,53,210,37,65,113,14,116,170,248,239,56,71,233,151,160,93,34,61,251,61,251,249,197,163,35,222,163,33,120,161,24,145,67,153,212,44,248,210,86,77,196,100,131,31,244,223,7,253,94,195,214,87,176,110,57,145,123,250,196,223,37,145,238,213,213,220,39,155,44,241,191,4,53,63,144,79,153,39,204,135,72,149,236,135,89,141,204,35,88,16,238,86,71,79,177,227,44,172,56,17,208,49,181,214,48,230,198,57,140,237,243,7,190,18,32,148,16,178,12,100,84,158,1,162,182,169,85,87,157,254,37,28,51,17,214,28,192,68,42,39,197,223,78,213,20,153,186,90,251,195,86,1,58,207,219,220,104,61,174,205,27,57,92,74,238,48,129,34,91,42,134,91,33,239,155,215,218,26,48,249,220,59,215,194,8,190,22,222,10,163,39,127,37,239,233,18,32,249,221,37,195,12,165,118,6,246,240,204,21,236,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("265f0b5e-a6be-455d-942d-40f04c0b5236"));
		}

		#endregion

	}

	#endregion

}

