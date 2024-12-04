namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingsValueEventListenerSchema

	/// <exclude/>
	public class SysSettingsValueEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingsValueEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingsValueEventListenerSchema(SysSettingsValueEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b87f92fc-2bfc-4aea-b3b7-8872e42ad5ac");
			Name = "SysSettingsValueEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,79,131,64,16,61,211,196,255,48,105,47,109,210,192,189,86,19,37,189,169,49,105,245,98,60,172,48,165,155,192,46,217,89,48,104,252,239,14,139,52,128,212,143,11,100,190,222,190,247,102,148,200,144,114,17,33,236,208,24,65,122,111,253,80,171,189,76,10,35,172,212,234,108,242,126,54,241,10,146,42,233,181,24,60,63,145,247,55,202,74,43,145,126,109,240,55,37,42,219,233,171,171,219,138,182,104,45,135,4,23,195,201,30,53,191,211,122,18,227,81,164,5,254,3,200,245,51,26,227,205,12,38,92,133,48,21,68,43,24,54,57,242,55,146,44,42,52,110,32,8,2,88,83,145,101,194,84,151,95,177,27,134,220,232,82,198,72,128,78,49,28,132,138,211,154,237,94,27,160,138,49,50,160,86,117,89,163,147,223,2,6,29,196,39,103,93,213,123,122,190,141,14,152,137,59,222,36,235,156,14,105,78,23,207,60,152,23,47,169,140,32,114,108,126,84,2,43,184,22,212,181,176,87,94,143,249,91,83,227,51,225,239,209,180,91,180,7,29,179,109,247,70,91,140,44,198,77,61,111,67,208,37,175,132,77,25,223,88,104,80,88,172,75,141,228,249,3,161,225,173,41,30,174,241,139,94,184,128,250,74,61,207,160,45,140,2,133,175,163,168,243,193,84,125,53,222,199,73,98,165,150,49,92,69,182,16,169,124,251,51,151,165,99,226,141,170,138,142,24,75,104,254,33,159,66,130,187,42,71,96,151,123,137,86,212,0,201,63,50,114,152,52,16,181,236,61,242,13,179,43,121,134,42,110,214,229,226,38,219,79,114,14,62,1,2,227,211,56,36,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b87f92fc-2bfc-4aea-b3b7-8872e42ad5ac"));
		}

		#endregion

	}

	#endregion

}

