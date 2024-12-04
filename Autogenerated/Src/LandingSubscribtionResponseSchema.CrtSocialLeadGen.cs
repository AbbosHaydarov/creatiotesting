namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingSubscribtionResponseSchema

	/// <exclude/>
	public class LandingSubscribtionResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingSubscribtionResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingSubscribtionResponseSchema(LandingSubscribtionResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da97b47f-924c-f15e-42df-bea8ad415e53");
			Name = "LandingSubscribtionResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,107,195,48,12,61,55,144,255,32,232,61,185,111,99,151,142,141,66,217,194,218,63,160,216,106,48,36,118,144,156,195,40,253,239,179,227,164,116,31,172,217,69,32,233,189,167,135,36,139,29,73,143,138,224,64,204,40,238,232,139,141,179,71,211,12,140,222,56,91,236,157,50,216,238,8,245,11,217,60,59,229,89,158,173,214,76,77,104,194,166,69,145,59,216,161,213,198,54,251,161,22,197,166,142,188,247,32,235,172,208,8,47,203,18,30,100,232,58,228,143,199,41,127,58,188,1,79,32,192,218,13,30,228,138,95,204,180,242,138,215,15,117,107,20,168,56,245,239,161,171,228,243,98,180,98,215,19,123,67,193,109,53,170,164,254,119,103,99,161,194,134,192,232,104,225,167,135,217,132,120,14,211,71,236,86,195,9,26,242,247,32,49,156,111,73,219,176,244,197,226,175,1,188,88,254,217,113,183,92,62,162,255,37,191,21,104,195,35,4,180,165,244,30,151,155,209,141,117,213,206,181,129,63,253,209,124,52,250,117,115,107,178,58,221,109,204,83,245,107,241,252,9,35,36,231,153,185,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da97b47f-924c-f15e-42df-bea8ad415e53"));
		}

		#endregion

	}

	#endregion

}

