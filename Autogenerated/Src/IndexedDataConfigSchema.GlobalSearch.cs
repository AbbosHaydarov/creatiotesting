namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexedDataConfigSchema

	/// <exclude/>
	public class IndexedDataConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexedDataConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexedDataConfigSchema(IndexedDataConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5326868b-e6e3-4b52-8fc8-2345a24cdc02");
			Name = "IndexedDataConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30c103fe-34c6-441e-895c-acadc354f737");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,203,10,194,64,12,69,215,22,250,15,3,110,165,31,160,226,70,65,92,215,157,184,136,211,88,7,166,153,146,76,65,17,255,221,140,163,11,95,144,77,194,225,222,67,8,58,148,30,44,154,45,50,131,132,99,172,150,129,142,174,29,24,162,11,84,173,125,56,128,175,17,216,158,202,226,90,22,163,65,28,181,166,190,72,196,78,97,239,209,38,82,170,53,18,178,179,179,178,80,106,204,216,234,213,44,61,136,76,205,134,26,60,99,179,130,8,57,95,17,157,126,56,120,103,141,77,208,55,99,166,102,229,30,225,192,151,185,68,214,226,201,11,171,115,109,38,23,154,149,220,110,57,118,140,212,228,254,231,254,83,230,45,225,191,207,39,150,122,94,96,118,218,237,205,166,165,192,216,232,59,134,142,68,95,144,84,190,77,244,120,7,131,115,6,138,115,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5326868b-e6e3-4b52-8fc8-2345a24cdc02"));
		}

		#endregion

	}

	#endregion

}

