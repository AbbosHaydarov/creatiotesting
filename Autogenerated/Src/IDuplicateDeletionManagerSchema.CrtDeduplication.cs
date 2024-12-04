namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicateDeletionManagerSchema

	/// <exclude/>
	public class IDuplicateDeletionManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicateDeletionManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicateDeletionManagerSchema(IDuplicateDeletionManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1767778-661d-431a-a382-dbbf65e7e3a2");
			Name = "IDuplicateDeletionManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,193,78,195,48,12,61,175,210,254,193,234,46,32,161,246,62,70,47,12,161,30,134,208,128,19,226,96,26,183,68,90,146,226,36,147,42,180,127,39,77,187,177,13,196,37,138,159,223,179,159,252,52,42,178,45,86,4,207,196,140,214,212,46,187,53,186,150,141,103,116,210,232,108,73,194,183,27,89,197,106,154,124,77,147,137,183,82,55,240,212,89,71,234,122,154,4,100,198,212,132,54,148,218,17,215,97,220,28,202,229,40,163,37,109,168,23,175,80,99,67,28,5,121,158,195,194,122,165,144,187,98,172,15,2,16,163,34,219,51,243,35,106,235,223,3,13,228,126,213,127,155,38,193,110,120,15,254,86,228,62,140,176,115,120,140,67,134,230,185,151,8,172,73,153,45,89,96,170,12,11,11,53,27,21,124,29,221,2,4,58,236,29,254,182,56,32,45,50,42,208,225,194,55,41,105,39,93,247,16,254,105,113,23,255,177,145,45,242,200,250,91,228,181,252,244,180,142,14,74,97,211,226,37,2,163,39,192,16,88,119,50,97,107,164,128,120,4,186,176,142,251,148,126,22,95,193,189,151,226,245,13,206,198,94,14,17,78,102,164,197,112,166,88,239,134,96,79,192,221,55,175,45,95,67,47,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1767778-661d-431a-a382-dbbf65e7e3a2"));
		}

		#endregion

	}

	#endregion

}

