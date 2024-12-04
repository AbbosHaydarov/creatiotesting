namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValueSchema

	/// <exclude/>
	public class ColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValueSchema(ColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3acab525-0700-4166-92ec-120c1b6f08ac");
			Name = "ColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,205,110,219,48,12,62,167,64,223,129,104,239,241,125,73,115,88,134,109,5,86,160,192,220,221,105,155,182,181,218,146,39,81,219,130,182,239,62,74,118,210,38,89,140,20,201,197,129,72,126,127,180,21,141,45,185,14,115,130,148,172,69,103,74,158,46,141,46,85,229,45,178,50,122,186,196,182,67,85,105,119,121,241,116,121,49,241,78,233,10,190,175,28,83,59,219,156,223,130,45,73,93,58,215,150,42,33,128,101,131,206,125,128,165,105,124,171,127,96,227,41,182,147,36,129,185,243,109,139,118,181,24,206,162,204,168,180,3,165,75,99,219,104,0,48,51,158,225,119,0,130,84,129,52,43,94,65,30,249,166,107,166,228,13,85,231,179,70,229,144,7,225,109,221,137,68,144,231,198,219,189,53,29,89,86,36,6,239,35,170,239,239,154,139,133,7,173,126,137,7,85,4,7,165,34,11,166,220,119,179,111,103,237,231,139,87,197,96,231,225,182,128,39,168,136,103,224,194,227,101,68,54,90,15,82,142,26,202,153,138,163,196,76,246,83,134,7,240,177,82,159,27,172,128,141,172,191,80,57,50,1,215,184,94,125,141,14,90,204,173,113,227,194,153,49,13,124,69,119,23,103,223,167,63,119,68,144,91,42,111,174,62,33,99,4,167,171,142,174,146,197,59,119,189,5,223,57,29,235,102,89,83,254,232,224,79,77,92,203,203,238,101,135,109,20,194,8,28,216,148,3,166,191,124,192,78,172,88,98,111,181,91,164,86,144,66,119,152,100,158,172,103,119,55,122,235,82,25,232,191,30,184,89,236,68,18,124,104,111,21,103,231,136,38,140,148,170,150,78,142,183,33,26,139,184,30,58,16,115,250,58,113,150,112,149,92,200,147,131,69,146,177,80,225,218,31,14,244,205,152,71,223,5,212,228,249,121,175,123,231,27,86,35,35,193,64,224,63,255,139,207,196,252,201,187,137,36,99,187,249,40,63,132,122,228,179,30,38,254,23,240,154,116,209,255,143,199,115,127,149,183,139,47,255,0,132,8,184,52,224,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3acab525-0700-4166-92ec-120c1b6f08ac"));
		}

		#endregion

	}

	#endregion

}

