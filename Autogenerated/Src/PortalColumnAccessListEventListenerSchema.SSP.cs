namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalColumnAccessListEventListenerSchema

	/// <exclude/>
	public class PortalColumnAccessListEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalColumnAccessListEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalColumnAccessListEventListenerSchema(PortalColumnAccessListEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67f28e51-44e9-4af8-8454-8ad240db235e");
			Name = "PortalColumnAccessListEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,83,77,111,219,48,12,61,187,64,255,3,225,30,154,0,131,125,207,146,0,153,91,96,135,125,20,112,119,26,118,96,100,218,209,32,75,129,36,103,8,134,253,247,81,82,93,52,157,179,21,59,13,216,197,176,40,242,241,241,61,81,99,79,110,143,130,224,158,172,69,103,90,95,84,70,183,178,27,44,122,105,244,229,197,247,203,139,108,112,82,119,39,41,150,94,159,137,23,183,218,75,47,201,253,49,161,184,61,144,246,231,243,106,159,218,240,253,149,165,142,217,64,165,208,185,5,220,25,235,81,85,70,13,189,222,8,65,206,189,147,206,71,184,240,67,154,108,44,43,203,18,150,110,232,123,180,199,245,195,121,76,128,214,88,184,158,70,186,6,70,146,254,8,20,25,22,35,84,249,12,107,233,136,80,57,3,194,82,187,202,127,63,103,241,6,29,197,216,241,132,105,14,101,192,251,60,113,53,171,197,142,122,252,192,46,193,10,242,105,178,249,252,11,151,239,135,173,146,2,68,16,232,37,250,192,2,206,240,97,48,246,156,191,143,170,191,39,191,51,77,208,61,54,73,151,207,181,141,129,183,168,27,69,110,148,175,198,3,53,73,196,160,225,175,34,166,200,30,45,246,160,121,202,85,238,72,55,172,201,58,82,130,116,42,150,101,76,153,174,160,124,125,191,163,232,197,232,195,226,172,19,145,215,166,245,100,99,131,141,237,92,208,31,164,118,30,53,239,129,48,218,163,212,225,57,250,29,141,13,227,8,208,160,199,19,46,15,162,155,3,183,147,13,193,193,200,6,62,234,56,246,204,108,191,146,24,71,120,5,83,173,129,230,16,246,43,203,182,236,69,49,86,142,37,52,15,187,145,101,169,20,246,79,92,229,231,48,75,225,121,202,78,153,117,125,87,147,24,108,240,84,119,82,83,81,41,66,91,33,191,163,102,163,148,249,70,77,2,112,179,167,112,197,39,71,150,23,95,51,99,118,60,245,253,241,114,163,111,72,145,255,31,173,190,73,131,255,149,217,99,237,191,101,247,21,227,167,189,143,231,20,61,13,114,236,39,200,88,189,61,57,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67f28e51-44e9-4af8-8454-8ad240db235e"));
		}

		#endregion

	}

	#endregion

}

