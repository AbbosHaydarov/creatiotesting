namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SyncEntityEventAsyncOperationArgsSchema

	/// <exclude/>
	public class SyncEntityEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SyncEntityEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SyncEntityEventAsyncOperationArgsSchema(SyncEntityEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e247f3a-b8b6-4b8f-a8ea-e969f8ba34fb");
			Name = "SyncEntityEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,81,107,194,48,16,199,159,21,252,14,135,123,217,96,180,239,234,4,17,17,97,48,193,237,3,196,244,218,5,218,180,187,36,131,110,248,221,119,105,234,90,197,41,123,105,218,203,255,254,247,203,93,170,69,129,166,18,18,225,21,137,132,41,83,27,45,75,157,170,204,145,176,170,212,163,225,247,104,56,112,70,233,12,118,181,177,88,76,207,190,89,159,231,40,189,216,68,107,212,72,74,118,154,190,45,97,180,210,86,89,133,230,166,32,90,152,90,203,151,10,3,198,197,132,29,43,56,206,59,119,132,25,171,96,153,11,99,38,12,166,101,99,84,175,62,81,219,83,171,5,101,166,73,170,220,62,87,18,164,207,185,157,2,19,184,97,57,224,78,241,179,131,97,108,75,78,218,146,152,105,219,84,11,138,182,242,205,154,247,97,23,176,89,30,33,200,60,12,30,223,30,152,107,47,12,222,31,53,189,29,63,185,193,161,133,66,157,4,174,83,200,45,149,92,209,119,252,20,49,142,99,152,25,87,20,130,234,121,23,64,4,73,152,62,141,55,30,254,157,74,173,190,26,92,62,172,37,127,17,104,28,207,65,21,85,142,5,131,132,225,129,246,215,44,250,181,137,251,198,109,51,158,149,177,51,238,23,143,120,14,157,155,9,167,24,100,104,167,96,248,209,59,211,69,198,112,41,193,25,36,32,204,133,197,164,207,237,157,133,180,13,36,143,71,104,190,250,78,171,15,135,160,18,223,195,84,33,93,39,93,59,149,192,27,251,183,94,155,228,191,140,61,30,223,198,69,243,243,48,210,245,186,157,20,218,229,239,178,103,227,14,209,211,224,225,7,138,64,25,233,252,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e247f3a-b8b6-4b8f-a8ea-e969f8ba34fb"));
		}

		#endregion

	}

	#endregion

}

