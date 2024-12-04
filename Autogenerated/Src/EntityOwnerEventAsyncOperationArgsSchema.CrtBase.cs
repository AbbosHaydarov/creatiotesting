namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityOwnerEventAsyncOperationArgsSchema

	/// <exclude/>
	public class EntityOwnerEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityOwnerEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityOwnerEventAsyncOperationArgsSchema(EntityOwnerEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6eeec1f5-f32a-4553-8347-9fd59c89add8");
			Name = "EntityOwnerEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,77,111,194,48,12,61,131,196,127,176,216,133,73,83,123,231,75,66,104,135,93,54,164,237,15,132,224,86,149,90,167,138,147,109,12,241,223,231,36,5,193,6,130,75,149,216,207,207,207,207,41,169,6,185,85,26,225,3,173,85,108,10,151,45,13,21,85,233,173,114,149,161,65,127,55,232,247,60,87,84,194,251,150,29,54,147,227,253,180,196,98,246,76,174,114,21,242,77,64,182,224,45,233,183,22,83,139,80,32,37,15,22,75,185,193,178,86,204,99,136,224,237,219,23,161,125,254,68,114,231,53,11,91,114,172,202,243,28,166,236,155,70,217,237,188,187,47,54,27,233,99,72,213,96,66,61,40,91,250,70,56,24,156,129,86,232,161,34,57,225,55,106,239,140,205,14,60,249,9,81,235,215,117,165,65,7,53,119,136,57,8,190,170,181,39,62,202,247,56,230,202,26,1,4,59,198,176,138,189,82,254,239,64,49,240,42,107,2,83,0,198,30,221,84,218,212,190,161,32,254,191,250,131,124,118,54,44,34,42,95,70,124,164,218,65,137,110,2,28,62,251,78,23,210,38,73,59,215,41,175,65,72,188,22,159,238,81,250,66,98,189,170,171,31,100,32,252,18,163,217,41,210,81,253,148,17,65,91,44,102,195,219,134,14,243,249,229,201,98,164,85,86,53,64,50,203,108,152,76,25,206,19,103,54,205,99,242,10,54,54,11,244,243,23,42,12,168,181,241,238,248,62,32,166,249,140,162,51,242,182,224,81,130,116,59,122,130,4,147,68,98,13,167,71,24,195,90,49,142,14,152,147,76,248,205,122,151,119,145,162,167,193,222,160,191,255,5,228,75,27,197,187,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6eeec1f5-f32a-4553-8347-9fd59c89add8"));
		}

		#endregion

	}

	#endregion

}

