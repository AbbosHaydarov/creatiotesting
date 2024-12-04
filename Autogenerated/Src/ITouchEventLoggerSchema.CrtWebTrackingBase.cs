namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITouchEventLoggerSchema

	/// <exclude/>
	public class ITouchEventLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITouchEventLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITouchEventLoggerSchema(ITouchEventLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("340e6a01-19e4-429a-9c15-c7cd3265b96c");
			Name = "ITouchEventLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,84,209,74,195,48,20,125,222,96,255,112,169,47,10,101,245,89,93,95,116,200,64,69,116,63,16,211,219,46,184,38,37,55,25,14,241,223,189,73,237,236,230,152,62,8,130,80,214,230,164,231,220,115,111,207,162,69,141,212,8,137,48,71,107,5,153,210,141,47,141,46,85,229,173,112,202,232,209,240,117,52,28,120,82,186,130,199,53,57,172,207,71,67,70,178,44,131,11,242,117,45,236,58,255,88,63,96,99,145,80,59,112,11,4,165,29,218,50,72,151,198,70,164,70,183,48,5,129,51,176,52,21,223,188,92,128,144,161,12,141,59,205,172,39,218,248,167,165,146,61,165,217,60,112,166,43,174,113,99,170,10,45,191,196,254,248,119,112,100,177,98,33,184,109,139,156,193,125,36,183,155,187,110,35,192,10,4,220,117,112,103,120,27,17,164,197,114,146,108,21,73,178,188,109,192,10,249,28,166,64,113,10,64,13,74,85,42,44,130,243,175,214,91,164,17,86,212,160,121,200,147,4,131,224,29,63,38,121,44,0,17,136,155,227,139,44,190,185,159,72,78,88,119,37,28,19,163,41,136,0,20,140,28,38,226,139,196,38,76,151,137,221,227,97,70,215,228,172,72,242,89,1,166,220,109,251,155,130,193,222,124,221,108,156,198,207,204,235,195,180,2,73,90,213,57,141,196,30,180,197,93,25,85,192,52,124,179,99,114,54,248,218,140,53,133,48,163,185,170,177,29,80,88,165,176,105,28,54,211,72,225,218,179,202,103,175,105,80,30,12,250,130,161,9,152,64,146,164,240,1,247,28,197,141,147,248,63,56,28,46,242,82,34,81,151,241,127,26,179,191,9,141,168,141,215,46,201,111,121,192,162,66,104,172,137,179,230,19,200,47,29,200,176,251,187,177,155,233,210,252,48,117,187,1,235,66,180,155,45,62,217,160,109,132,129,211,237,28,238,15,28,31,116,168,139,246,172,139,235,183,209,144,175,119,162,40,201,30,200,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("340e6a01-19e4-429a-9c15-c7cd3265b96c"));
		}

		#endregion

	}

	#endregion

}

