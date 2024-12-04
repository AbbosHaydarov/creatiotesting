namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UidSinceSyncStrategySchema

	/// <exclude/>
	public class UidSinceSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UidSinceSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UidSinceSyncStrategySchema(UidSinceSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1a0baf-434e-4325-bd23-753efc693955");
			Name = "UidSinceSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,75,111,155,64,16,62,99,201,255,97,68,47,182,100,65,207,110,236,67,156,84,202,33,81,42,234,83,149,195,26,6,178,42,236,162,217,161,50,138,252,223,59,11,182,131,93,220,11,176,195,188,190,199,26,85,161,171,85,138,240,19,137,148,179,57,71,207,74,151,211,201,199,116,18,52,78,155,98,240,103,99,77,174,139,134,20,107,107,190,141,38,16,222,138,71,143,134,53,107,116,55,19,190,171,148,45,245,25,146,243,133,176,144,57,176,41,149,115,75,216,234,44,209,38,197,164,53,105,194,178,3,22,109,151,23,199,49,220,185,166,170,20,181,235,243,25,17,82,194,124,21,62,13,11,194,120,13,186,170,75,172,208,176,210,108,205,2,50,44,245,31,36,204,32,39,91,13,75,101,228,189,114,152,93,117,136,78,67,226,235,169,132,114,252,237,78,231,177,122,104,36,0,108,193,97,137,41,131,42,75,16,13,156,42,208,129,54,25,238,229,221,45,34,20,137,46,78,22,133,76,74,63,167,14,166,252,122,192,92,53,37,223,75,165,48,58,227,182,70,155,207,46,48,207,23,240,34,50,195,10,194,49,14,195,249,155,52,170,155,93,169,83,72,61,215,163,84,195,114,20,142,148,138,83,228,121,150,235,149,108,141,196,237,210,127,177,64,196,172,79,184,214,169,11,36,168,40,125,7,220,215,36,36,248,122,70,209,231,136,247,95,154,131,250,212,20,172,136,70,58,19,138,152,188,155,182,198,201,98,207,174,232,123,254,104,144,90,240,54,14,130,2,249,248,21,16,114,67,6,194,228,233,101,243,8,31,95,15,161,247,99,16,28,252,243,112,132,130,38,235,209,92,66,19,255,203,172,198,187,84,12,249,218,81,246,31,108,145,79,188,1,163,139,212,138,84,5,70,196,89,133,98,11,146,254,70,176,201,168,112,189,149,51,164,231,64,116,23,119,217,235,209,98,15,60,65,102,161,193,133,235,129,131,253,93,222,217,125,167,216,233,191,191,2,130,67,137,192,23,93,143,22,24,19,127,230,183,249,220,206,123,120,112,92,64,119,181,91,24,174,49,239,88,93,194,78,28,51,187,206,191,72,236,149,25,167,190,143,14,131,193,116,114,248,11,23,21,130,4,182,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1a0baf-434e-4325-bd23-753efc693955"));
		}

		#endregion

	}

	#endregion

}

