namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDashboardItemDataSchema

	/// <exclude/>
	public class IDashboardItemDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDashboardItemDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDashboardItemDataSchema(IDashboardItemDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b9c62e2-4fb8-44c6-bf30-c17c6dcdc426");
			Name = "IDashboardItemData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,193,106,195,48,12,61,183,208,127,208,113,187,36,31,208,177,75,10,35,165,172,59,100,12,118,115,18,57,243,214,72,153,237,48,186,210,127,159,226,180,33,100,25,236,98,144,222,123,126,210,179,73,213,232,26,85,32,100,104,173,114,172,125,148,48,105,83,181,86,121,195,180,90,158,86,203,69,235,12,85,144,176,197,245,80,61,226,151,103,10,138,173,99,138,118,134,62,5,21,60,142,99,184,115,109,93,43,123,188,191,212,41,121,180,186,51,210,108,161,84,238,45,103,101,75,48,30,107,41,189,138,174,194,120,164,108,218,252,96,10,48,131,56,221,92,149,169,8,55,162,19,150,76,40,231,47,219,208,120,118,104,161,96,34,44,186,117,34,24,152,99,159,69,71,75,6,86,80,141,202,19,84,232,215,112,238,125,182,251,252,93,0,232,115,130,41,154,241,7,18,60,41,43,209,202,216,110,74,112,222,134,248,4,158,71,94,76,41,221,236,216,76,241,217,5,135,64,250,40,11,213,132,61,231,215,188,56,36,61,233,63,215,103,70,198,252,102,66,96,173,29,250,63,46,150,23,10,212,87,97,238,3,113,62,179,7,244,221,103,185,185,237,127,74,64,207,63,227,191,149,169,133,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b9c62e2-4fb8-44c6-bf30-c17c6dcdc426"));
		}

		#endregion

	}

	#endregion

}

