﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UidBasedSinceSyncStrategySchema

	/// <exclude/>
	public class UidBasedSinceSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UidBasedSinceSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UidBasedSinceSyncStrategySchema(UidBasedSinceSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("25a423ba-ef87-4ede-853f-5adb10273007");
			Name = "UidBasedSinceSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,85,219,110,155,64,16,125,38,82,254,97,68,95,64,178,112,158,147,218,82,227,75,100,169,118,47,216,79,85,85,173,97,112,86,130,93,180,187,164,161,137,255,189,179,128,29,112,76,162,188,96,152,157,219,57,103,102,45,88,134,58,103,17,194,26,149,98,90,38,38,88,50,158,94,94,60,93,94,56,133,230,98,7,97,169,13,102,55,39,223,193,93,42,183,44,229,255,152,225,82,188,156,190,228,153,72,145,240,93,161,222,112,80,216,103,15,102,194,112,195,81,247,58,204,89,100,164,170,61,200,231,147,194,29,213,129,73,202,180,190,134,13,143,111,153,198,56,228,34,194,176,20,81,104,168,17,220,149,149,243,112,56,132,207,186,200,50,166,202,241,241,27,17,34,133,201,200,93,180,3,220,225,24,120,150,167,152,161,48,132,197,72,49,128,24,83,254,128,10,99,72,148,204,218,177,199,194,221,20,193,161,202,176,85,246,215,20,19,86,164,230,150,139,152,16,122,166,204,81,38,94,167,188,63,128,21,137,4,35,112,123,49,185,254,111,202,150,23,219,148,71,16,89,2,250,241,67,139,155,14,45,14,41,78,207,35,145,223,149,204,81,89,9,174,237,187,193,200,96,92,187,156,210,87,25,66,100,42,186,7,124,204,21,106,109,51,208,148,228,41,101,183,216,95,131,119,242,67,82,144,68,165,226,49,130,54,202,42,189,17,154,90,91,234,93,157,243,71,129,170,4,59,144,142,179,67,211,188,57,10,77,161,4,209,178,154,254,252,50,95,3,253,206,190,206,214,179,41,132,139,213,100,6,79,87,123,215,78,143,227,236,237,115,223,192,67,17,215,8,187,112,105,90,169,122,97,103,202,2,174,184,124,3,237,68,33,33,211,32,240,239,89,245,95,73,100,167,136,42,48,178,247,240,81,89,114,166,88,6,130,20,31,185,133,70,69,109,9,34,137,58,116,199,27,250,134,232,104,8,62,15,43,239,243,193,150,193,16,141,33,62,181,59,110,181,104,215,123,43,31,195,246,121,187,185,118,214,102,164,122,81,121,155,78,139,208,237,120,0,213,18,151,208,238,197,175,20,185,134,45,37,244,78,253,59,142,181,206,239,200,182,68,115,47,227,183,20,235,219,235,224,14,205,185,65,35,50,78,230,180,38,225,116,72,123,194,189,166,111,135,39,224,213,174,193,66,175,138,52,253,166,102,89,110,74,111,82,40,69,87,201,146,182,132,237,144,184,93,136,185,76,99,84,62,60,63,67,239,41,140,232,10,184,114,15,233,157,41,161,88,115,186,25,82,201,226,89,70,170,234,57,221,69,214,76,151,5,117,87,129,181,138,89,147,231,223,116,182,134,206,231,20,98,65,157,244,255,58,157,223,218,162,67,188,149,175,143,193,166,214,254,131,98,244,244,51,109,112,250,31,16,230,157,84,64,255,39,53,45,7,54,27,84,141,94,115,169,50,102,188,115,216,104,70,15,177,193,90,82,251,246,222,254,195,51,150,91,83,29,56,32,17,83,202,135,11,145,200,96,33,30,152,226,76,152,198,232,119,216,57,153,235,218,218,54,146,229,63,1,75,127,120,165,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25a423ba-ef87-4ede-853f-5adb10273007"));
		}

		#endregion

	}

	#endregion

}

