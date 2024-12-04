namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RequestContentTypeSchema

	/// <exclude/>
	public class RequestContentTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RequestContentTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RequestContentTypeSchema(RequestContentTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9276eb3a-690d-4f9a-89bf-69e191abc4b4");
			Name = "RequestContentType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,189,14,194,48,12,132,231,86,234,59,88,98,232,214,48,35,96,65,44,140,40,47,16,138,91,138,136,19,242,51,84,136,119,199,77,138,132,84,198,179,63,223,249,72,105,244,86,181,8,18,157,83,222,116,161,57,24,234,134,62,58,21,6,67,85,249,170,202,170,44,86,14,123,150,112,164,168,55,112,198,103,68,31,152,12,72,65,142,22,19,36,132,128,173,143,90,43,55,238,103,45,111,8,46,227,208,102,30,2,31,52,95,94,252,28,216,120,121,12,45,32,135,252,205,40,242,51,139,160,52,152,201,228,14,181,178,150,173,82,7,113,247,134,234,41,112,153,88,156,120,7,59,88,39,227,119,238,138,116,205,117,39,201,179,15,114,77,155,64,38,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9276eb3a-690d-4f9a-89bf-69e191abc4b4"));
		}

		#endregion

	}

	#endregion

}

