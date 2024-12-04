namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDuplicatesGroupResponseSchema

	/// <exclude/>
	public class BulkDuplicatesGroupResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDuplicatesGroupResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDuplicatesGroupResponseSchema(BulkDuplicatesGroupResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb44fa4e-3083-461b-a753-81b61ff52720");
			Name = "BulkDuplicatesGroupResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,203,110,194,48,16,60,131,196,63,172,224,210,74,21,220,129,114,40,84,136,3,173,68,122,171,122,48,201,38,114,235,216,200,143,86,41,226,223,187,113,4,33,60,67,47,78,236,204,172,199,179,158,72,150,162,89,177,16,225,13,181,102,70,197,182,59,86,50,230,137,211,204,114,37,91,205,117,171,217,112,134,203,4,130,204,88,76,7,7,115,194,11,129,97,14,54,221,41,74,212,60,188,136,121,93,126,210,235,92,69,40,142,112,11,39,45,79,177,27,80,21,38,248,175,215,64,40,194,117,52,38,52,129,177,96,198,244,225,201,137,175,103,2,219,108,44,56,74,59,113,43,193,67,102,209,76,181,114,43,79,121,159,48,203,232,56,86,179,208,126,208,194,202,45,9,4,97,94,226,90,5,232,195,197,250,141,220,152,70,175,215,131,161,113,105,202,116,54,218,46,204,34,34,240,152,163,6,21,67,146,227,187,59,112,111,31,237,21,206,49,93,162,190,123,161,94,192,35,180,61,126,22,181,239,115,197,91,201,18,127,96,234,120,4,126,247,89,4,107,72,208,14,192,228,195,198,159,182,142,22,163,156,166,102,231,75,54,187,65,83,193,43,252,56,148,230,101,5,21,64,109,117,99,69,13,207,133,69,59,123,129,203,155,45,43,217,190,96,85,159,80,116,191,202,246,21,91,214,21,24,236,27,182,125,124,51,225,208,252,211,190,170,184,9,247,169,32,242,208,88,77,73,120,0,229,243,49,170,88,122,66,111,49,118,80,70,69,48,206,133,228,224,226,46,40,239,148,66,172,25,144,201,105,54,133,227,204,151,139,193,40,127,3,187,96,220,98,99,65,56,14,70,89,118,120,37,212,163,34,63,230,208,207,147,110,110,254,0,7,78,143,19,30,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb44fa4e-3083-461b-a753-81b61ff52720"));
		}

		#endregion

	}

	#endregion

}

