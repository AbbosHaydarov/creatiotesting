namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateBasedSentSinceSyncStrategySchema

	/// <exclude/>
	public class DateBasedSentSinceSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateBasedSentSinceSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateBasedSentSinceSyncStrategySchema(DateBasedSentSinceSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15be1ecd-0b88-4e9e-b6d5-d613f5e51e4e");
			Name = "DateBasedSentSinceSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,219,110,219,48,12,125,118,129,254,3,225,189,116,64,22,239,57,107,3,108,137,7,20,88,131,110,78,62,64,177,25,79,152,45,25,20,61,212,40,242,239,163,236,92,148,52,205,94,108,145,226,229,240,240,200,168,26,93,163,114,132,37,18,41,103,55,60,126,82,186,186,189,121,189,189,137,90,167,77,25,220,204,172,217,232,178,37,197,218,154,47,23,3,8,223,243,143,83,195,154,53,58,9,144,144,15,132,165,84,129,89,165,156,155,192,92,49,126,83,14,139,12,13,103,218,228,152,117,38,207,88,122,97,217,245,25,73,146,192,189,107,235,90,81,55,61,216,136,144,19,110,30,226,199,48,33,78,166,160,235,166,194,90,202,41,205,214,140,160,192,74,255,69,194,2,54,100,235,48,245,216,252,180,196,120,223,37,57,111,75,40,230,31,183,183,175,163,135,86,110,128,45,56,172,48,103,80,85,5,198,242,167,130,212,134,71,195,81,110,88,130,100,27,78,149,232,70,187,194,194,163,236,198,73,85,40,164,214,17,80,0,160,105,215,149,206,33,247,68,254,15,73,72,244,9,191,145,236,91,190,135,181,60,147,109,144,184,155,248,19,11,106,44,134,128,243,45,244,142,12,21,229,191,1,95,26,146,1,124,62,163,176,191,67,252,150,195,168,217,23,5,43,43,33,93,200,144,76,94,52,43,227,4,216,147,43,135,154,63,91,164,14,188,24,163,168,68,222,157,34,66,110,201,64,188,90,204,127,125,253,190,4,249,167,63,210,101,58,135,44,93,44,179,199,197,44,133,215,207,219,216,139,49,138,182,254,187,221,13,136,166,24,102,60,29,88,180,45,8,218,156,45,137,28,159,123,78,175,76,60,35,148,233,220,101,21,93,162,190,87,164,180,80,226,127,135,148,222,211,40,82,53,24,121,151,15,177,232,134,4,151,17,166,4,98,60,93,137,13,249,193,49,190,79,250,232,203,201,206,55,71,102,33,213,197,211,0,167,127,223,107,251,210,131,219,223,135,224,194,170,59,109,93,31,237,206,227,58,226,244,114,15,204,17,244,15,191,131,16,208,199,126,47,19,88,75,209,187,243,248,147,192,97,227,151,151,55,120,67,231,246,31,240,119,88,31,209,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15be1ecd-0b88-4e9e-b6d5-d613f5e51e4e"));
		}

		#endregion

	}

	#endregion

}

