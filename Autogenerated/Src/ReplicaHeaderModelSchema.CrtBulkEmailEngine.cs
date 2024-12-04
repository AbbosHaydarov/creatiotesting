namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReplicaHeaderModelSchema

	/// <exclude/>
	public class ReplicaHeaderModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReplicaHeaderModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReplicaHeaderModelSchema(ReplicaHeaderModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3621dd38-75e4-442f-bb93-2a3c04ec45c8");
			Name = "ReplicaHeaderModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,144,203,106,195,48,16,69,215,54,228,31,6,178,143,247,113,233,38,45,105,23,161,161,205,15,40,214,216,17,209,195,204,72,139,16,242,239,29,217,113,73,74,232,162,32,36,230,161,123,207,140,87,14,185,87,13,194,14,137,20,135,54,46,86,193,183,166,75,164,162,9,126,86,158,103,101,145,216,248,14,190,78,28,209,213,18,203,153,19,118,82,135,149,85,204,75,248,196,222,154,70,189,161,210,72,155,160,209,206,74,233,170,170,10,158,56,57,167,232,244,124,141,165,149,144,209,71,134,151,221,7,132,22,14,195,47,134,54,16,196,3,194,62,217,35,160,83,198,130,24,246,86,69,4,26,13,22,147,104,117,163,218,167,189,212,160,201,40,15,72,96,9,175,89,236,14,174,144,185,228,254,153,99,75,161,71,138,6,101,152,237,160,55,214,127,79,80,228,196,26,5,94,96,57,191,153,248,74,7,78,241,49,35,14,93,119,140,19,164,241,113,66,220,72,51,156,161,195,88,103,165,26,46,255,177,52,90,86,105,90,131,244,183,241,58,25,61,57,191,235,71,190,115,244,122,220,198,16,143,217,219,228,229,27,53,92,167,90,47,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3621dd38-75e4-442f-bb93-2a3c04ec45c8"));
		}

		#endregion

	}

	#endregion

}

