namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseStorableEntitySchema

	/// <exclude/>
	public class BaseStorableEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseStorableEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseStorableEntitySchema(BaseStorableEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29c15305-d044-47a9-b58f-c7d81b88fdca");
			Name = "BaseStorableEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,203,106,195,48,16,69,215,50,248,31,6,178,73,54,246,62,173,83,72,8,37,155,16,112,119,165,20,197,154,184,3,182,100,244,72,112,75,254,189,146,108,23,211,118,97,140,142,238,92,29,73,242,22,77,199,43,132,23,212,154,27,117,177,217,78,201,11,213,78,115,75,74,166,201,87,154,48,103,72,214,80,246,198,98,251,144,38,158,44,52,214,126,27,118,13,55,102,13,91,110,176,180,74,243,115,131,123,105,201,246,49,149,231,57,60,26,215,182,92,247,155,113,29,162,96,198,44,96,12,195,141,236,7,112,103,85,141,18,253,201,40,128,68,54,53,228,179,138,215,18,53,241,134,62,195,248,155,7,157,59,55,84,65,21,68,254,245,96,225,6,44,124,147,244,73,171,14,181,37,244,230,167,56,62,37,126,11,71,48,20,141,66,127,141,88,167,233,234,149,225,217,145,128,119,18,254,133,60,28,180,34,59,8,136,14,172,70,11,197,38,100,160,40,226,94,182,111,59,223,253,4,203,8,7,118,196,91,248,47,87,43,88,255,20,50,51,27,134,43,111,28,70,126,143,47,205,22,40,197,112,189,184,30,232,28,222,225,27,100,162,10,33,237,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29c15305-d044-47a9-b58f-c7d81b88fdca"));
		}

		#endregion

	}

	#endregion

}

