namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityMLangBinderSchema

	/// <exclude/>
	public class OpportunityMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityMLangBinderSchema(OpportunityMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c44c1193-13fd-4b69-b47e-53e7dc114349");
			Name = "OpportunityMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,93,107,194,48,20,125,174,224,127,184,184,23,7,163,125,119,34,168,108,32,40,14,54,216,115,218,94,187,64,147,148,228,166,172,12,255,251,110,154,118,212,225,75,67,114,62,238,61,167,90,40,116,141,40,16,62,208,90,225,204,133,210,189,209,23,89,121,43,72,26,61,159,253,204,103,137,119,82,87,55,20,139,233,171,40,200,88,137,238,249,14,227,19,115,102,41,101,52,163,140,63,88,172,216,14,246,181,112,110,5,231,166,49,150,188,150,212,157,142,66,87,59,169,75,180,61,51,203,50,88,59,175,148,176,221,102,184,79,232,160,124,77,178,102,141,23,21,66,17,252,32,239,229,233,168,206,38,242,198,231,181,44,6,222,253,177,176,130,109,211,188,180,168,233,40,29,161,70,187,19,14,89,204,217,249,251,183,252,9,233,203,148,188,254,91,111,26,193,97,128,105,57,187,44,17,90,35,75,56,107,118,124,39,97,105,57,90,115,173,132,223,4,69,60,31,33,20,155,36,57,79,74,39,244,17,14,165,38,73,95,87,44,186,75,195,182,235,67,216,59,68,63,16,242,47,50,246,105,154,234,63,184,89,46,38,232,34,186,94,135,84,168,203,24,172,191,199,215,219,199,235,47,216,24,93,152,32,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c44c1193-13fd-4b69-b47e-53e7dc114349"));
		}

		#endregion

	}

	#endregion

}

