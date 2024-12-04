namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecurityTokenCleanerSchema

	/// <exclude/>
	public class SecurityTokenCleanerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecurityTokenCleanerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecurityTokenCleanerSchema(SecurityTokenCleanerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0104f03c-a574-4da3-bbd9-fc323cbac58a");
			Name = "SecurityTokenCleaner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,193,110,194,48,12,61,23,105,255,96,177,11,72,168,189,111,172,23,64,19,147,38,161,1,31,144,182,134,133,165,73,21,167,12,52,241,239,115,154,14,232,134,118,137,156,247,156,231,103,59,90,148,72,149,200,17,86,104,173,32,179,113,241,196,232,141,220,214,86,56,105,244,93,239,235,174,23,213,36,245,22,150,71,114,88,50,175,20,230,158,164,248,25,53,90,153,63,158,115,174,101,44,50,206,204,189,197,45,103,195,68,9,34,120,128,37,230,181,149,238,184,50,31,168,39,10,5,107,52,137,73,146,192,152,234,178,20,246,152,182,247,55,172,44,18,106,71,32,32,15,201,176,51,25,108,140,5,60,84,210,98,1,212,42,130,243,146,20,255,104,37,87,98,85,157,41,153,179,132,55,113,203,2,59,155,191,152,108,118,96,206,25,118,20,113,235,124,158,253,191,162,123,55,133,239,96,209,104,5,246,183,233,6,152,162,66,135,244,159,193,191,14,3,82,9,43,74,208,188,152,167,126,77,104,121,29,58,140,187,159,174,249,14,249,25,136,199,73,147,125,251,113,229,99,118,97,169,159,46,206,113,231,77,59,147,189,180,174,22,10,246,70,22,16,250,199,129,175,117,169,13,93,43,35,152,79,101,19,177,247,49,57,203,187,31,129,201,118,76,167,112,169,60,4,255,125,162,72,227,103,119,230,107,39,149,116,18,105,208,21,30,198,97,116,179,48,184,38,151,6,67,255,193,162,83,187,14,212,69,216,72,115,15,104,23,60,125,3,111,167,53,82,216,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0104f03c-a574-4da3-bbd9-fc323cbac58a"));
		}

		#endregion

	}

	#endregion

}

