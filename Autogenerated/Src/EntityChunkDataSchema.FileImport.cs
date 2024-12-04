namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityChunkDataSchema

	/// <exclude/>
	public class EntityChunkDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityChunkDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityChunkDataSchema(EntityChunkDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2514f3cc-6ad8-4976-a835-7cf0143ff738");
			Name = "EntityChunkData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,207,78,2,49,16,135,207,144,240,14,19,184,232,101,31,64,212,203,186,26,14,26,226,154,120,32,30,186,101,88,26,251,103,51,109,15,72,124,119,167,91,33,65,192,112,233,166,211,223,55,223,236,88,97,208,119,66,34,188,33,145,240,110,21,138,210,217,149,106,35,137,160,156,45,30,149,198,153,233,28,133,209,112,59,26,14,162,87,182,133,122,227,3,154,233,159,59,163,90,163,76,156,47,158,208,34,41,121,148,121,141,54,40,131,69,205,175,66,171,175,94,195,41,206,77,8,91,190,0,148,90,120,127,3,21,39,195,166,92,71,251,249,32,130,232,51,139,61,215,104,252,224,66,23,27,173,36,200,132,28,19,3,158,153,207,125,235,57,185,14,41,40,228,246,243,158,204,239,139,20,127,70,211,32,93,189,240,82,224,14,198,152,154,113,114,124,157,60,59,209,172,178,209,32,37,253,109,94,76,150,50,204,128,187,207,51,48,6,91,104,49,76,193,167,227,251,188,198,71,41,209,123,158,44,125,112,249,251,15,142,247,116,104,86,54,64,125,62,124,169,175,219,177,239,42,172,43,34,71,255,26,247,170,83,241,83,206,9,218,101,222,118,127,207,213,195,34,215,126,0,228,182,22,166,122,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2514f3cc-6ad8-4976-a835-7cf0143ff738"));
		}

		#endregion

	}

	#endregion

}

