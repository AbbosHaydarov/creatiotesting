namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadMLangBinderSchema

	/// <exclude/>
	public class LeadMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadMLangBinderSchema(LeadMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f319c644-f47a-4da7-b6eb-96ccd3799545");
			Name = "LeadMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,193,106,195,48,12,61,167,208,127,16,221,165,131,145,220,187,82,88,203,6,133,148,13,54,216,89,137,213,204,16,219,193,118,194,202,232,191,79,182,147,209,150,93,108,252,244,244,164,247,172,81,145,235,176,38,248,32,107,209,153,163,207,119,70,31,101,211,91,244,210,232,249,236,103,62,203,122,39,117,115,69,177,148,191,96,237,141,149,228,30,255,97,124,82,197,44,165,140,230,42,215,239,44,53,44,7,187,22,157,91,65,73,40,14,37,234,102,43,181,32,27,41,69,81,192,218,245,74,161,61,109,198,119,224,129,234,91,47,91,38,247,216,16,212,65,1,170,216,151,79,109,197,69,95,215,87,173,172,71,222,205,32,88,193,83,215,61,15,164,125,41,157,39,77,118,139,142,184,139,109,242,249,183,231,129,252,151,17,188,233,91,84,75,197,81,217,12,108,83,10,130,193,72,1,175,154,21,223,61,90,191,156,164,57,65,79,223,30,234,116,223,67,200,48,203,42,158,148,95,208,167,114,200,47,203,98,50,41,211,83,30,182,93,239,195,222,193,243,222,19,255,134,177,15,209,206,45,186,89,46,2,188,72,58,231,209,7,105,145,172,196,119,66,175,193,243,47,226,87,84,248,253,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f319c644-f47a-4da7-b6eb-96ccd3799545"));
		}

		#endregion

	}

	#endregion

}

