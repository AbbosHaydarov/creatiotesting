namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageNotifierSchema

	/// <exclude/>
	public class PortalMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageNotifierSchema(PortalMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d380dfa-98cc-4b28-8b3b-626ea934efae");
			Name = "PortalMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3cbee395-bc39-4c92-abe2-fb401673f115");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,219,110,194,48,12,134,175,139,196,59,68,236,6,36,212,7,96,7,105,192,196,144,182,129,6,219,189,151,186,37,82,147,160,28,52,85,136,119,159,155,20,232,54,132,184,106,226,124,254,109,255,181,183,66,21,108,85,89,135,242,182,219,241,173,107,58,209,101,137,220,9,173,108,58,67,133,70,240,35,178,70,99,192,234,220,17,101,48,125,82,78,56,129,150,222,187,29,5,18,237,22,56,254,162,84,46,10,111,160,150,235,118,118,53,151,220,24,44,232,202,38,37,88,59,98,75,109,28,148,175,104,45,20,248,166,157,200,5,154,0,242,26,56,255,206,70,108,12,22,255,101,37,177,196,169,6,77,225,140,231,78,27,170,228,191,74,193,35,176,13,231,243,226,253,48,87,197,48,124,6,140,52,147,36,105,160,185,202,53,187,103,10,191,89,59,18,153,3,68,64,76,38,7,221,186,218,98,70,174,122,169,62,161,244,120,71,29,145,153,15,253,94,67,247,6,195,152,61,49,8,14,179,113,53,207,46,43,204,188,200,40,191,197,255,213,88,168,203,10,83,130,214,66,226,73,101,161,142,26,207,96,31,157,3,190,145,164,64,58,228,32,54,79,7,143,222,145,107,147,181,251,92,26,33,193,84,173,34,195,152,178,226,27,148,240,209,102,99,40,165,88,195,188,8,218,61,218,53,75,125,65,99,239,84,132,45,36,205,48,239,144,133,169,15,78,39,187,43,12,138,63,242,216,0,13,120,117,82,77,179,125,172,21,63,123,90,243,112,14,11,134,42,139,59,22,238,49,250,59,184,255,1,191,212,208,73,102,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d380dfa-98cc-4b28-8b3b-626ea934efae"));
		}

		#endregion

	}

	#endregion

}

