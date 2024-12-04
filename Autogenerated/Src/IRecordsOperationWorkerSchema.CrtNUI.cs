namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordsOperationWorkerSchema

	/// <exclude/>
	public class IRecordsOperationWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordsOperationWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordsOperationWorkerSchema(IRecordsOperationWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de0a68c6-78e9-4e0a-a753-aa946a7db874");
			Name = "IRecordsOperationWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,77,79,195,48,12,61,15,137,255,96,109,23,184,180,247,49,42,77,104,26,59,32,38,152,196,57,107,220,206,162,77,138,147,12,77,136,255,78,154,172,221,7,67,226,20,217,126,207,239,217,142,18,53,154,70,228,8,43,100,22,70,23,54,121,208,170,160,210,177,176,164,21,124,93,95,13,156,33,85,194,235,206,88,172,239,206,98,15,175,42,204,91,172,73,230,168,144,41,247,24,143,26,49,150,109,135,133,178,200,133,215,24,195,226,5,115,205,210,60,55,24,219,191,105,126,71,14,240,52,77,97,98,92,93,11,222,101,251,184,167,130,46,192,110,252,211,17,193,106,224,216,44,233,200,233,17,187,113,235,138,114,160,190,193,31,210,237,124,30,222,155,157,109,81,89,51,134,101,224,199,218,185,179,144,88,49,149,37,178,129,207,13,42,16,123,51,64,6,26,214,57,26,131,178,53,246,219,217,0,91,137,40,244,40,148,172,144,39,209,219,178,35,134,218,148,75,147,193,89,37,110,118,48,66,37,163,225,83,247,79,104,55,90,254,199,254,180,105,42,66,115,186,208,118,195,71,75,189,224,61,100,26,193,162,6,229,191,206,253,48,239,175,63,204,14,63,161,59,151,83,244,225,16,72,250,121,168,32,191,174,100,146,6,122,232,182,213,36,131,147,93,127,21,115,179,152,41,87,251,104,93,225,100,238,72,102,112,208,184,189,60,255,119,252,111,39,73,159,251,1,42,103,200,209,221,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de0a68c6-78e9-4e0a-a753-aa946a7db874"));
		}

		#endregion

	}

	#endregion

}

