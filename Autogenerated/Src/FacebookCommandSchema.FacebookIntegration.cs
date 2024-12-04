namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandSchema

	/// <exclude/>
	public class FacebookCommandSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandSchema(FacebookCommandSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eaf15c5a-de82-46d3-9492-d1bed2d4d5e1");
			Name = "FacebookCommand";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,203,106,195,48,16,60,59,144,127,88,210,75,12,193,31,144,62,14,53,180,151,28,2,233,61,200,202,198,89,162,135,171,149,40,165,248,223,43,217,78,76,93,104,115,17,154,217,153,217,93,214,8,141,220,8,137,240,134,206,9,182,71,95,148,214,28,169,14,78,120,178,166,216,89,73,66,205,103,95,243,89,22,152,76,13,187,79,246,168,239,39,56,218,148,66,153,60,92,188,162,65,71,242,151,102,67,230,61,146,145,190,115,88,71,41,148,74,48,175,225,37,142,80,89,123,46,173,214,194,28,58,73,19,42,69,18,100,82,76,5,176,134,103,193,120,149,103,113,188,248,142,177,113,10,239,130,244,214,197,244,109,151,212,43,134,212,73,222,50,135,180,96,150,109,209,105,98,78,91,192,35,24,252,128,13,177,127,72,205,198,210,211,32,206,82,253,146,52,150,151,139,192,232,246,162,178,193,239,53,46,86,48,33,242,213,223,118,212,130,84,178,245,159,255,228,93,248,209,17,154,3,95,155,93,240,77,102,69,103,28,173,61,186,201,216,156,172,183,163,115,128,121,231,108,211,249,179,118,56,76,28,166,191,77,135,123,246,39,217,126,3,23,172,63,91,141,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eaf15c5a-de82-46d3-9492-d1bed2d4d5e1"));
		}

		#endregion

	}

	#endregion

}

