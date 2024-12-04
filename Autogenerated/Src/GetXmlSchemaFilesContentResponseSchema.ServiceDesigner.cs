namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetXmlSchemaFilesContentResponseSchema

	/// <exclude/>
	public class GetXmlSchemaFilesContentResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetXmlSchemaFilesContentResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetXmlSchemaFilesContentResponseSchema(GetXmlSchemaFilesContentResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90c4c327-4a7f-a0dd-f8fb-e87a2ae11e91");
			Name = "GetXmlSchemaFilesContentResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0cd720a-279e-436c-a704-8c755267ad15");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,205,78,195,48,16,132,207,169,212,119,176,202,5,36,148,7,40,63,7,26,209,83,81,213,112,64,170,122,112,221,73,88,201,113,162,181,131,84,16,239,206,218,105,40,112,225,98,173,215,179,179,159,199,233,6,190,211,6,234,25,204,218,183,85,200,23,173,171,168,238,89,7,106,93,94,130,223,200,160,128,167,218,129,167,147,143,233,36,235,61,185,90,149,71,31,208,136,222,90,152,40,246,249,18,162,33,115,243,87,179,233,93,160,6,209,141,180,165,247,228,125,86,253,92,206,24,119,174,218,3,172,208,4,214,38,136,88,228,23,140,90,38,213,194,106,239,231,106,137,240,210,216,210,188,162,209,143,100,225,163,26,46,108,228,83,130,131,52,179,45,116,208,163,205,78,26,93,191,183,100,148,137,30,255,90,168,185,122,208,30,103,199,76,2,144,243,27,101,205,109,7,14,4,225,89,39,231,225,61,173,93,161,217,131,47,159,36,102,117,167,102,85,92,48,187,138,16,35,69,65,41,58,205,199,91,31,88,194,184,86,228,194,118,119,175,18,141,138,113,103,89,141,24,128,20,254,84,124,158,32,224,14,3,71,186,15,221,223,77,233,125,1,35,5,148,171,230,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90c4c327-4a7f-a0dd-f8fb-e87a2ae11e91"));
		}

		#endregion

	}

	#endregion

}

