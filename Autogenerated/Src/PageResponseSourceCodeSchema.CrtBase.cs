namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PageResponseSourceCodeSchema

	/// <exclude/>
	public class PageResponseSourceCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PageResponseSourceCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PageResponseSourceCodeSchema(PageResponseSourceCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7282cd51-6666-41a7-9651-efa983edf92b");
			Name = "PageResponseSourceCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,107,227,48,16,61,215,224,255,32,124,169,179,77,212,235,66,200,33,155,205,110,11,221,54,180,14,45,44,123,80,164,113,34,208,135,145,198,165,166,244,191,239,200,105,218,96,26,176,177,53,243,102,230,189,55,106,163,118,91,246,208,69,4,59,205,179,246,232,200,43,120,193,97,108,225,141,1,137,218,187,200,127,131,131,160,229,16,242,8,27,10,229,153,19,22,98,35,36,176,10,66,16,209,215,72,229,174,214,219,54,136,212,33,207,94,243,236,172,105,55,70,75,22,145,98,146,73,35,98,100,4,67,112,88,117,13,48,130,36,216,0,23,49,244,35,49,128,176,61,110,198,138,249,106,117,115,189,152,87,215,119,183,151,119,139,106,89,77,30,170,251,229,252,79,49,61,217,224,201,154,67,181,104,26,202,247,204,46,159,157,226,190,1,247,98,77,237,131,21,24,39,190,174,181,4,229,101,107,137,26,143,13,77,86,113,7,128,214,240,254,203,173,208,238,130,74,250,121,111,39,180,173,196,22,238,201,24,114,240,148,184,103,175,21,123,12,26,161,188,66,108,62,208,225,253,103,204,54,29,194,223,127,76,9,20,227,131,148,90,27,184,37,207,63,2,242,211,197,81,63,229,236,208,128,207,149,186,34,250,16,202,226,221,235,201,79,77,185,168,147,252,98,76,110,32,10,185,75,82,167,125,231,180,205,111,179,117,245,107,242,253,252,188,96,23,71,219,230,137,228,26,181,209,216,241,117,48,43,129,187,165,147,94,65,121,224,52,162,130,162,24,245,123,248,100,113,188,230,217,49,221,1,238,11,182,55,224,182,184,35,162,201,2,190,63,241,202,211,125,32,229,229,104,56,233,135,118,34,116,123,75,83,197,48,191,116,170,220,199,210,218,232,165,39,207,254,3,103,132,143,124,29,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7282cd51-6666-41a7-9651-efa983edf92b"));
		}

		#endregion

	}

	#endregion

}

