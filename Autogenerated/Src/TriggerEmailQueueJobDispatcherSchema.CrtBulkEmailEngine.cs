namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TriggerEmailQueueJobDispatcherSchema

	/// <exclude/>
	public class TriggerEmailQueueJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TriggerEmailQueueJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TriggerEmailQueueJobDispatcherSchema(TriggerEmailQueueJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0d4e234-cd3d-0785-1103-1944273b2e8b");
			Name = "TriggerEmailQueueJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,77,107,219,64,16,61,43,144,255,48,144,75,2,70,162,87,213,53,36,169,9,46,117,73,145,75,15,37,135,149,52,150,151,172,118,213,217,93,27,81,242,223,59,210,90,66,110,226,22,234,131,177,103,222,124,188,55,111,181,168,209,54,162,64,216,32,145,176,102,235,226,123,163,183,178,242,36,156,52,250,242,226,215,229,69,228,173,212,21,100,173,117,88,115,94,41,44,186,164,141,31,80,35,201,226,253,136,153,182,33,140,179,98,135,165,87,72,111,33,190,99,206,168,186,54,154,179,156,191,34,172,184,43,220,43,97,109,10,27,146,85,133,180,172,133,84,95,61,122,252,100,242,143,146,183,117,220,148,250,138,36,73,96,110,125,93,11,106,23,199,255,25,210,30,45,228,94,61,3,118,181,240,179,43,134,131,116,59,96,182,86,84,156,222,26,2,23,6,96,25,112,54,30,58,38,147,150,141,207,149,44,160,232,118,250,199,74,144,194,157,176,120,199,147,207,32,102,176,186,109,154,229,30,181,251,44,89,76,22,143,71,176,194,252,61,210,127,36,211,32,57,137,172,1,255,118,172,53,150,1,210,111,39,53,119,146,174,52,69,210,45,24,53,3,6,204,158,181,149,37,194,106,169,125,141,36,114,133,243,211,117,214,65,128,77,219,224,2,110,149,50,7,44,39,49,11,31,250,158,145,198,3,156,173,252,241,4,157,43,248,115,22,18,103,168,203,169,92,61,254,37,28,58,186,226,100,96,123,74,125,141,110,103,202,255,231,189,55,178,132,193,115,172,252,181,229,27,179,231,14,134,158,123,155,127,97,191,207,224,24,245,22,169,11,220,28,217,240,105,70,191,142,206,93,75,237,29,170,150,187,205,255,126,254,197,117,208,132,131,15,100,124,19,102,253,49,122,152,57,3,190,177,52,229,74,135,1,204,249,221,44,212,75,27,30,218,55,134,166,108,82,223,109,60,236,149,142,244,232,8,175,165,221,74,194,149,102,86,190,127,150,41,76,153,172,95,229,227,140,205,237,30,13,251,186,189,233,30,102,244,242,230,89,66,244,52,200,177,223,59,226,99,128,52,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0d4e234-cd3d-0785-1103-1944273b2e8b"));
		}

		#endregion

	}

	#endregion

}

