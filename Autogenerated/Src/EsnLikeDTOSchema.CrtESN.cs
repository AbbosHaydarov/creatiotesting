namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnLikeDTOSchema

	/// <exclude/>
	public class EsnLikeDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnLikeDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnLikeDTOSchema(EsnLikeDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9ba4548-db18-453f-afd7-0da2ee2c2296");
			Name = "EsnLikeDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,193,110,194,48,12,134,207,32,241,14,17,92,182,75,31,96,104,167,130,80,165,193,170,149,157,166,29,66,106,42,107,77,90,217,201,129,33,222,125,73,10,211,58,21,9,46,145,126,251,247,231,216,137,145,26,184,149,10,196,22,136,36,55,123,155,164,141,217,99,229,72,90,108,76,178,44,54,147,241,113,50,30,57,70,83,137,226,192,22,244,252,159,78,222,156,177,168,33,41,128,80,214,248,29,107,189,203,251,102,4,149,23,34,173,37,243,147,88,178,121,193,47,88,108,95,99,246,99,33,173,244,29,45,73,101,63,125,160,117,187,26,149,80,193,221,51,143,194,37,126,105,57,53,45,144,69,240,200,60,150,68,92,199,91,131,222,1,61,108,252,112,226,89,76,177,156,62,6,244,133,189,114,88,138,172,20,71,81,129,157,11,14,199,233,122,57,55,202,207,180,6,102,89,65,54,196,42,250,142,91,193,142,129,6,121,239,49,113,43,70,249,237,249,229,13,146,210,75,238,78,88,144,125,28,91,10,239,125,6,70,251,125,200,156,80,75,58,100,250,218,22,207,232,190,111,168,201,12,76,217,125,3,175,186,216,223,208,233,7,212,253,34,125,213,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9ba4548-db18-453f-afd7-0da2ee2c2296"));
		}

		#endregion

	}

	#endregion

}

