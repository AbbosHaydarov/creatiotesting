namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeleteRelationshipEntityAsyncOperationSchema

	/// <exclude/>
	public class DeleteRelationshipEntityAsyncOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeleteRelationshipEntityAsyncOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeleteRelationshipEntityAsyncOperationSchema(DeleteRelationshipEntityAsyncOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2810347f-8d41-bc89-5b74-bf02880df2b3");
			Name = "DeleteRelationshipEntityAsyncOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ac9dec01-f305-4a8c-bd6f-7a943e292d3e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,203,106,195,48,16,60,43,144,127,16,233,197,129,160,15,72,31,144,38,105,241,33,180,132,246,3,84,121,163,8,28,201,236,74,105,77,233,191,87,150,66,136,3,134,246,98,172,209,206,206,236,172,172,60,0,53,82,1,127,3,68,73,110,231,197,210,217,157,209,1,165,55,206,138,45,212,233,135,246,166,89,1,25,109,1,199,163,239,241,136,5,50,86,247,120,8,183,3,184,88,91,111,188,1,18,11,106,173,122,105,32,183,167,127,19,68,105,61,224,46,90,30,230,62,73,229,29,154,84,17,107,110,16,116,164,242,101,45,137,230,124,5,53,120,184,156,43,105,181,125,161,196,108,194,71,109,20,87,29,241,143,60,62,231,101,198,215,71,176,254,186,41,139,201,197,239,217,211,6,252,222,85,209,213,107,146,202,151,39,217,163,51,21,95,127,129,10,30,138,119,2,140,155,177,160,146,74,232,29,103,124,80,114,129,154,184,68,29,14,241,138,166,188,219,28,99,71,137,28,47,55,107,164,70,121,216,72,43,53,32,191,207,89,229,28,91,241,12,254,174,236,61,132,94,249,67,145,122,50,11,159,60,122,34,143,161,227,69,229,36,90,76,250,102,39,179,43,247,211,105,183,73,198,134,13,137,156,125,30,242,177,221,130,114,88,149,85,113,158,43,63,151,182,172,114,171,159,83,200,96,171,156,115,58,103,244,18,140,200,47,115,5,118,184,2,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2810347f-8d41-bc89-5b74-bf02880df2b3"));
		}

		#endregion

	}

	#endregion

}

