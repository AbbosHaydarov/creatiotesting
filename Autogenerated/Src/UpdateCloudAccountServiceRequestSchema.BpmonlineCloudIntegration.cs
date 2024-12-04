namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateCloudAccountServiceRequestSchema

	/// <exclude/>
	public class UpdateCloudAccountServiceRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateCloudAccountServiceRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateCloudAccountServiceRequestSchema(UpdateCloudAccountServiceRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("924fae82-030c-42fa-84b9-94064bc4d89e");
			Name = "UpdateCloudAccountServiceRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,65,79,194,64,16,133,207,146,240,31,38,112,209,75,123,23,36,33,213,16,162,24,2,122,50,30,150,101,90,55,182,187,117,103,214,164,18,255,187,211,22,20,208,3,94,218,204,155,183,111,191,153,181,170,64,42,149,70,120,64,239,21,185,148,163,196,217,212,100,193,43,54,206,70,201,205,114,230,214,152,83,183,179,233,118,206,2,25,155,193,178,34,198,66,156,121,142,186,182,81,52,65,139,222,232,193,177,103,17,44,155,2,163,165,116,85,110,62,154,84,113,137,175,239,49,147,2,146,92,17,93,194,99,185,86,140,73,238,194,122,172,181,147,115,114,230,221,104,92,224,91,64,226,230,76,28,199,48,164,80,20,202,87,163,109,189,192,210,35,161,101,2,223,90,129,29,132,38,14,168,205,32,112,41,240,11,130,106,163,163,93,86,188,23,246,116,173,88,201,248,236,149,230,103,17,202,176,202,141,6,93,3,158,192,119,38,27,146,239,247,96,115,239,74,244,108,80,166,155,55,81,109,255,120,136,70,152,160,240,59,47,192,242,175,73,199,243,41,188,98,85,147,254,70,109,89,103,88,172,208,159,223,203,43,194,21,244,84,105,110,177,234,93,212,232,59,118,98,95,191,198,184,105,193,6,50,228,65,125,199,0,62,255,3,163,235,177,127,150,41,58,75,44,65,42,166,189,149,158,8,186,203,57,68,189,51,196,195,237,78,167,54,117,35,216,22,244,23,119,31,237,186,221,115,83,183,234,161,40,218,23,129,218,240,169,225,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("924fae82-030c-42fa-84b9-94064bc4d89e"));
		}

		#endregion

	}

	#endregion

}

