namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StorableStreamEntitySchema

	/// <exclude/>
	public class StorableStreamEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StorableStreamEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StorableStreamEntitySchema(StorableStreamEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0a87ec1-0968-41f6-a659-4da5f3e39a17");
			Name = "StorableStreamEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,80,193,106,2,49,16,61,43,248,15,83,189,180,151,172,45,148,130,150,130,85,15,189,40,116,21,15,34,101,86,103,151,64,118,179,76,102,11,91,241,223,155,24,133,98,47,147,188,151,121,243,222,164,194,146,92,141,123,130,21,49,163,179,185,168,169,173,114,93,52,140,162,109,213,235,30,123,221,78,227,116,85,64,218,58,161,114,124,131,213,199,210,83,158,28,48,21,94,1,83,131,206,141,32,21,203,152,25,74,133,9,203,115,71,146,36,240,234,154,178,68,110,223,46,120,195,88,215,196,144,91,6,119,110,5,177,144,145,7,150,233,160,174,178,228,143,110,155,18,107,52,250,39,204,223,121,162,110,50,163,247,176,15,206,55,198,243,74,180,180,48,130,119,116,158,138,79,145,244,194,176,92,103,160,115,184,91,204,87,233,106,178,152,77,62,103,79,95,195,115,220,206,118,153,57,107,72,232,190,191,209,198,132,84,76,165,253,166,3,96,46,62,244,139,122,124,86,67,5,107,71,48,67,65,168,217,250,101,164,85,253,135,144,235,26,44,70,185,30,71,40,72,198,224,66,57,69,167,1,85,7,157,199,251,69,147,181,66,219,93,28,251,95,17,107,144,197,95,15,240,244,11,211,19,125,133,206,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0a87ec1-0968-41f6-a659-4da5f3e39a17"));
		}

		#endregion

	}

	#endregion

}

