namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageNotifierSchema

	/// <exclude/>
	public class TouchQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageNotifierSchema(TouchQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38be02db-3e45-4885-b616-878b6f010bac");
			Name = "TouchQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,77,111,219,48,12,61,167,64,255,3,225,93,82,96,136,239,205,199,97,221,80,236,208,34,107,178,31,160,200,116,162,45,150,60,82,26,16,20,251,239,163,36,123,77,220,164,216,118,72,32,81,228,227,123,143,146,173,106,144,91,165,17,214,72,164,216,213,126,114,231,108,109,182,129,148,55,206,94,95,61,95,95,141,2,27,187,133,213,129,61,54,211,63,251,227,18,66,137,203,201,59,194,173,148,193,221,94,49,223,194,218,5,189,251,18,48,224,3,50,171,45,62,58,111,106,131,148,146,203,178,132,25,135,166,81,116,88,116,251,84,8,222,129,141,153,7,80,27,23,188,236,5,7,126,68,32,104,50,18,180,228,180,44,35,19,66,14,123,207,147,30,179,60,2,109,195,102,111,52,232,132,123,145,15,220,194,7,197,120,158,234,72,60,144,255,23,113,206,178,167,160,189,35,209,184,76,13,114,198,80,81,150,244,146,14,181,252,102,140,8,154,176,158,23,23,249,20,229,34,83,142,154,94,139,202,145,86,145,106,192,202,12,231,69,96,36,105,100,81,199,177,21,139,89,153,78,83,114,103,193,197,102,227,175,39,197,112,138,117,35,222,108,196,155,241,48,252,12,191,58,95,208,86,217,154,83,159,150,228,188,36,99,117,198,36,99,119,72,198,87,78,151,153,99,159,11,238,167,220,43,83,33,136,105,113,184,61,203,71,209,9,243,5,100,211,150,206,88,207,197,244,191,32,159,176,49,182,146,213,74,239,176,81,61,114,116,210,213,227,132,127,51,125,91,219,3,250,157,171,206,141,255,47,104,220,7,83,193,61,250,85,216,124,147,163,207,213,56,94,190,181,226,239,199,227,129,238,166,139,211,17,103,68,232,3,217,84,60,249,212,180,254,16,159,226,168,155,193,63,58,32,205,179,175,58,61,243,143,200,154,76,27,151,111,82,121,223,215,187,22,243,7,226,41,61,189,1,197,193,233,49,207,129,159,57,122,26,148,216,111,255,198,208,179,152,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38be02db-3e45-4885-b616-878b6f010bac"));
		}

		#endregion

	}

	#endregion

}

