namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MergeSocialMessageReferencesFactorySchema

	/// <exclude/>
	public class MergeSocialMessageReferencesFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MergeSocialMessageReferencesFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MergeSocialMessageReferencesFactorySchema(MergeSocialMessageReferencesFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e48291b4-a733-42d9-a644-93ba7e513590");
			Name = "MergeSocialMessageReferencesFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,203,106,195,48,16,60,39,144,127,88,156,67,19,8,246,61,109,115,232,35,33,208,148,210,244,86,74,81,229,181,35,176,37,163,149,91,76,201,191,119,45,53,15,211,6,114,89,33,105,52,154,153,93,45,74,164,74,72,132,23,180,86,144,201,92,124,107,116,166,242,218,10,167,140,142,239,215,143,131,254,247,160,223,171,73,233,28,214,13,57,44,25,83,20,40,91,0,197,11,212,104,149,188,220,99,78,81,221,97,90,87,133,146,126,247,63,220,98,60,23,210,25,171,144,24,193,152,161,197,156,225,176,66,155,227,218,72,37,138,21,18,137,28,159,49,67,139,90,34,133,39,141,199,39,73,2,87,84,151,165,176,205,236,119,255,100,205,167,74,145,128,252,123,40,3,193,5,129,200,115,230,23,14,193,238,217,98,216,209,36,71,60,175,119,152,137,186,112,55,74,167,172,122,228,154,10,77,54,90,122,93,127,164,140,39,240,200,209,194,53,68,103,8,143,198,111,252,67,85,127,112,56,32,11,65,116,142,93,152,194,137,223,153,140,59,198,117,159,222,92,97,145,210,148,147,80,159,236,54,92,86,97,3,228,184,35,146,19,16,169,209,69,3,93,210,67,171,225,253,16,18,59,211,248,117,26,218,78,76,175,85,193,181,23,117,140,68,19,255,244,65,145,187,34,103,57,204,217,47,156,145,247,218,41,215,44,211,40,28,108,253,226,235,54,204,67,111,136,58,13,174,186,22,87,232,54,198,123,244,57,134,75,223,70,165,55,60,160,46,53,50,105,59,185,11,250,164,246,5,186,67,164,163,32,17,72,110,176,20,109,83,199,112,61,59,142,226,127,93,172,185,157,222,206,225,246,7,151,55,60,113,111,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e48291b4-a733-42d9-a644-93ba7e513590"));
		}

		#endregion

	}

	#endregion

}

