namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingsRightsEventListenerSchema

	/// <exclude/>
	public class SysSettingsRightsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingsRightsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingsRightsEventListenerSchema(SysSettingsRightsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42f59b37-f248-46d7-8658-207f7a813139");
			Name = "SysSettingsRightsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,79,131,64,16,61,211,164,255,97,210,94,218,164,129,123,173,38,74,122,83,99,108,61,25,15,43,76,97,19,216,37,187,11,6,141,255,221,97,145,134,109,193,143,11,100,62,222,219,247,102,70,176,28,117,193,34,132,61,42,197,180,60,24,63,148,226,192,147,82,49,195,165,152,78,62,166,19,175,212,92,36,78,139,194,139,145,188,191,21,134,27,142,250,215,6,127,91,161,48,189,190,166,186,171,245,14,141,161,80,195,229,41,210,145,230,247,90,71,57,30,121,146,154,255,48,181,0,226,35,198,185,194,132,202,16,102,76,235,53,156,117,89,253,183,92,27,20,168,44,34,8,2,216,232,50,207,153,170,175,190,99,139,134,66,201,138,199,168,1,173,105,72,153,136,179,70,240,65,42,208,53,113,228,160,59,227,202,210,251,29,97,208,99,124,182,211,171,157,167,23,187,40,197,156,221,211,50,201,233,236,76,231,108,249,66,200,162,124,205,120,4,145,149,243,179,23,88,195,13,211,253,57,58,229,205,224,144,27,117,116,44,244,61,14,238,14,77,42,99,26,221,131,146,6,35,131,113,91,47,186,16,100,69,123,161,185,140,236,45,84,200,12,54,181,214,246,226,73,163,162,221,9,66,55,15,148,78,184,132,230,88,61,79,161,41,149,0,129,111,195,180,139,19,88,115,61,222,231,168,180,74,242,24,174,35,83,178,140,191,255,89,204,10,172,22,111,216,88,116,100,89,65,251,15,233,34,18,220,215,5,2,141,218,73,116,190,78,168,252,163,166,65,91,43,231,145,51,206,190,233,57,138,184,93,153,141,219,172,155,164,28,124,1,27,233,210,109,46,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42f59b37-f248-46d7-8658-207f7a813139"));
		}

		#endregion

	}

	#endregion

}

