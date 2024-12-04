namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordProcessedHandlerSchema

	/// <exclude/>
	public class IRecordProcessedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordProcessedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordProcessedHandlerSchema(IRecordProcessedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19ec078f-2d2a-4581-b154-931f817b018f");
			Name = "IRecordProcessedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,221,106,195,48,12,133,175,91,232,59,136,236,102,131,145,220,119,93,160,140,194,122,49,40,99,47,224,218,74,226,146,216,65,118,74,199,216,187,79,118,126,232,178,14,76,64,202,209,241,167,99,35,26,116,173,144,8,31,72,36,156,45,124,250,98,77,161,203,142,132,215,214,192,215,106,185,224,115,71,88,134,114,111,60,82,193,3,107,216,191,163,180,164,14,100,37,58,135,234,85,24,85,35,173,150,44,207,178,12,54,174,107,26,65,159,249,80,79,163,96,11,240,21,2,197,121,104,71,3,168,122,135,116,52,200,174,28,218,238,88,107,9,122,50,249,231,250,0,204,242,9,248,13,125,101,149,91,195,33,26,244,63,231,120,177,49,26,20,150,110,227,225,25,141,15,112,127,233,22,177,211,10,18,13,24,206,244,57,113,104,20,82,146,239,46,40,187,152,164,180,204,126,241,233,38,139,186,219,99,130,74,151,228,91,165,116,152,17,53,47,204,60,77,255,22,67,110,179,197,7,174,107,219,179,213,106,216,103,38,190,183,199,19,74,15,61,222,227,220,107,23,172,182,204,0,1,228,225,105,200,146,197,125,156,177,254,142,223,223,77,238,253,0,131,245,204,25,76,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19ec078f-2d2a-4581-b154-931f817b018f"));
		}

		#endregion

	}

	#endregion

}

