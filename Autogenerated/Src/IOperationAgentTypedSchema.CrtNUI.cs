namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOperationAgentTypedSchema

	/// <exclude/>
	public class IOperationAgentTypedSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOperationAgentTypedSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOperationAgentTypedSchema(IOperationAgentTypedSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b084da8-1bf5-4242-9e04-24f04039b8b1");
			Name = "IOperationAgentTyped";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,81,107,194,48,16,199,159,21,252,14,135,123,113,48,236,187,58,65,68,164,15,110,162,101,239,177,189,214,64,154,116,201,69,38,178,239,190,36,181,162,206,142,61,149,187,254,127,119,255,187,156,100,37,154,138,165,8,9,106,205,140,202,105,56,87,50,231,133,213,140,184,146,208,235,158,122,221,142,53,92,22,176,61,26,194,114,124,23,59,64,8,76,189,218,12,151,40,81,243,212,105,156,234,73,99,225,107,196,146,80,231,174,203,8,226,247,10,235,202,179,2,37,5,89,20,69,48,49,182,44,153,62,78,207,113,114,172,48,3,222,128,160,114,160,189,251,52,52,48,143,15,27,58,186,194,43,187,19,60,189,98,239,122,78,146,15,38,44,190,64,178,65,99,5,77,193,77,232,184,139,221,181,246,109,136,163,25,193,186,46,86,11,238,141,134,196,6,201,106,105,128,180,69,224,57,148,74,35,176,3,227,130,237,4,122,135,191,45,118,118,74,9,88,57,229,236,192,4,247,66,56,65,129,52,134,111,255,59,184,65,153,213,134,110,221,173,144,246,42,187,88,251,135,51,137,95,4,233,229,145,154,93,106,76,149,206,76,139,195,144,209,117,133,233,188,21,158,68,141,198,67,241,66,218,210,237,218,205,51,185,108,119,137,244,230,28,196,238,84,204,224,185,190,140,199,134,183,72,166,221,40,144,10,225,167,69,219,182,215,144,169,152,102,37,72,119,218,175,253,51,219,255,115,132,0,4,254,160,120,6,11,25,90,12,110,166,9,55,51,61,67,113,102,252,32,15,31,202,61,160,63,253,155,100,200,253,0,46,213,80,220,108,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b084da8-1bf5-4242-9e04-24f04039b8b1"));
		}

		#endregion

	}

	#endregion

}

