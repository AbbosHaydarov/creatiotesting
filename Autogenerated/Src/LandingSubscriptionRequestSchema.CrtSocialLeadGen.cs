namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingSubscriptionRequestSchema

	/// <exclude/>
	public class LandingSubscriptionRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingSubscriptionRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingSubscriptionRequestSchema(LandingSubscriptionRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0ca51e0-3be3-3d77-16f1-134361882e48");
			Name = "LandingSubscriptionRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,193,106,195,48,12,134,207,13,228,29,4,187,39,247,181,236,210,65,25,20,86,150,190,128,98,43,153,32,182,51,203,166,148,210,119,159,227,36,163,108,176,139,64,191,127,62,125,182,104,72,70,84,4,103,242,30,197,117,161,218,59,219,113,31,61,6,118,182,106,156,98,28,142,132,250,64,182,44,110,101,177,137,194,182,135,230,42,129,204,182,44,82,242,228,169,79,101,216,15,40,242,12,71,180,58,85,154,216,138,242,60,78,156,15,250,138,36,33,183,235,186,134,157,68,99,208,95,95,150,253,245,252,14,126,238,192,133,195,39,176,237,156,55,217,1,176,117,49,192,48,83,171,149,80,63,32,198,216,14,172,64,77,247,255,61,191,73,31,72,243,199,248,228,221,72,62,48,37,237,83,134,204,239,191,29,115,176,128,129,245,36,241,215,98,213,56,68,214,107,249,77,195,13,122,10,91,144,105,220,151,243,100,245,108,144,247,57,125,12,239,223,236,203,241,68,154,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0ca51e0-3be3-3d77-16f1-134361882e48"));
		}

		#endregion

	}

	#endregion

}

