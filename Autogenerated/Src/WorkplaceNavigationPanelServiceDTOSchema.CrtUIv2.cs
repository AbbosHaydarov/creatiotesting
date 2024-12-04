namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkplaceNavigationPanelServiceDTOSchema

	/// <exclude/>
	public class WorkplaceNavigationPanelServiceDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkplaceNavigationPanelServiceDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkplaceNavigationPanelServiceDTOSchema(WorkplaceNavigationPanelServiceDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e6ee3c5-590e-48d3-b5b9-30fd1fb88a29");
			Name = "WorkplaceNavigationPanelServiceDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b5fa047-b3f1-455e-b921-26461fc6607e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,148,177,110,194,48,16,134,103,144,120,7,11,150,118,201,3,64,203,80,90,33,36,96,0,170,14,85,135,195,57,82,11,199,142,108,135,138,34,222,189,231,4,90,72,141,26,198,46,81,146,251,253,221,239,223,151,40,72,209,102,192,145,45,208,24,176,122,229,162,129,86,43,145,228,6,156,208,42,154,194,70,36,197,237,4,85,222,106,238,90,205,70,110,133,74,216,124,107,29,166,36,151,18,185,23,216,104,136,10,141,224,189,170,102,150,43,39,82,140,230,84,5,41,62,11,30,169,72,215,49,152,208,3,27,72,176,182,203,134,232,206,59,14,141,206,51,59,35,151,212,0,139,37,175,143,224,128,92,58,3,220,189,209,139,44,95,74,193,25,247,136,191,8,172,203,6,218,20,86,54,130,227,68,199,40,143,172,232,1,44,254,180,106,248,189,150,221,38,152,46,209,220,76,41,46,118,207,218,31,218,172,51,73,177,217,246,173,55,112,116,48,122,82,121,138,6,150,18,239,2,38,250,236,229,123,33,219,177,4,93,143,89,127,217,23,251,10,182,146,26,98,74,146,92,229,210,157,119,179,206,248,140,199,167,138,42,182,81,162,59,168,226,50,232,80,232,1,171,53,130,14,174,186,156,153,136,131,238,71,113,221,36,56,100,190,89,144,50,40,107,117,81,246,48,176,149,211,27,11,235,42,231,54,162,241,237,179,249,65,31,224,95,159,175,71,94,29,111,185,232,127,164,43,184,86,15,192,215,9,141,132,138,233,255,160,77,216,220,111,221,53,45,158,141,188,136,165,90,93,148,130,20,131,156,169,23,212,132,184,109,22,134,44,168,80,127,42,193,240,247,67,216,65,218,252,84,81,227,83,223,183,154,95,110,172,42,200,226,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e6ee3c5-590e-48d3-b5b9-30fd1fb88a29"));
		}

		#endregion

	}

	#endregion

}

