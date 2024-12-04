namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityProcessElementDataOwnerAsyncExecutorSchema

	/// <exclude/>
	public class EntityProcessElementDataOwnerAsyncExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityProcessElementDataOwnerAsyncExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityProcessElementDataOwnerAsyncExecutorSchema(EntityProcessElementDataOwnerAsyncExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("232b7840-ec6e-489d-a023-bb9b694170a3");
			Name = "EntityProcessElementDataOwnerAsyncExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,107,227,48,16,61,167,208,255,48,116,47,54,20,249,222,166,129,146,154,146,67,155,194,118,247,174,218,99,71,212,150,140,62,146,154,37,255,125,199,146,157,196,221,120,161,208,139,97,62,222,123,163,55,146,37,175,209,52,60,67,120,69,173,185,81,133,101,75,37,11,81,58,205,173,80,242,242,226,207,229,197,204,25,33,75,248,217,26,139,245,237,33,62,133,212,181,146,231,43,26,167,242,44,149,86,88,129,134,221,155,86,102,235,6,131,166,249,50,128,173,164,69,93,208,57,58,44,161,127,104,44,169,0,203,138,27,115,3,30,215,190,104,69,13,38,173,176,70,105,31,184,229,129,102,39,81,123,84,146,36,48,55,174,174,185,110,23,125,236,25,96,39,178,13,224,7,102,206,162,1,53,8,67,161,52,100,27,46,203,110,88,213,17,129,42,0,189,28,52,65,15,48,8,26,200,73,146,193,32,148,156,40,53,238,173,18,25,100,94,108,106,90,63,168,31,57,245,147,144,246,13,172,66,119,186,165,166,177,43,68,75,187,163,239,193,141,39,180,27,149,147,31,47,94,46,20,63,31,186,79,32,66,166,177,184,187,154,22,96,97,12,188,74,142,56,141,196,243,110,22,233,191,94,189,181,71,171,206,90,19,12,100,243,100,32,57,176,158,90,53,120,181,85,34,135,94,38,250,101,80,211,189,149,152,121,41,55,10,175,97,242,8,247,186,52,192,117,233,252,20,49,116,151,125,54,219,114,90,227,168,229,14,162,192,225,119,48,65,20,31,136,110,143,52,93,127,191,202,149,44,20,49,73,220,117,79,105,98,191,190,41,140,49,11,146,171,156,64,163,113,216,80,184,14,125,207,184,11,216,169,206,165,170,92,45,127,243,202,209,219,121,68,251,218,54,152,251,112,254,232,68,190,136,198,160,117,71,22,48,207,244,131,136,123,153,117,149,251,202,25,25,42,125,163,210,62,248,247,127,163,162,241,146,99,182,236,46,23,70,159,29,143,61,217,190,127,9,40,243,240,24,124,28,178,227,228,254,47,65,102,59,131,20,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("232b7840-ec6e-489d-a023-bb9b694170a3"));
		}

		#endregion

	}

	#endregion

}

