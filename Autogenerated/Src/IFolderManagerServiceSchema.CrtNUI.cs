namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFolderManagerServiceSchema

	/// <exclude/>
	public class IFolderManagerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFolderManagerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFolderManagerServiceSchema(IFolderManagerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13");
			Name = "IFolderManagerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,77,79,227,48,16,61,7,137,255,96,149,75,145,170,252,0,208,94,88,118,81,86,234,130,72,87,28,42,14,198,158,20,11,199,14,99,167,171,8,241,223,25,199,73,218,176,45,210,74,69,66,202,197,243,241,230,249,61,103,12,47,193,85,92,0,91,0,34,119,182,240,233,119,107,10,181,170,145,123,101,77,250,211,106,9,56,231,134,175,0,115,192,181,18,112,124,244,114,124,148,212,78,153,21,203,27,231,161,60,127,119,38,16,173,65,4,4,151,94,129,1,84,226,159,154,14,109,110,37,232,15,147,233,29,60,108,10,182,153,34,140,10,137,186,71,46,60,21,83,249,9,194,138,8,176,204,120,192,130,46,121,198,178,221,215,73,232,91,118,167,30,99,250,155,180,97,223,216,100,87,203,228,244,158,90,170,250,65,43,193,84,143,191,23,62,200,53,208,153,131,127,180,210,157,177,155,182,189,165,154,44,175,43,136,138,247,243,195,128,100,73,55,207,204,218,62,193,52,182,5,66,55,215,249,98,50,99,127,80,45,160,172,52,247,45,77,234,91,3,250,200,128,210,23,86,54,185,111,116,72,18,202,28,156,35,82,67,52,189,67,94,85,32,103,44,204,73,110,225,185,6,71,221,88,114,63,234,136,161,244,151,179,102,198,110,233,181,144,165,240,113,93,43,78,178,182,74,178,17,171,233,85,77,33,3,127,227,49,163,225,109,164,226,8,198,111,130,206,99,48,154,98,202,55,185,120,132,146,7,51,78,195,27,72,14,170,214,194,230,158,112,196,215,81,237,130,59,232,235,217,78,150,7,80,241,48,26,102,70,232,90,194,143,48,64,129,203,204,255,170,216,201,55,251,44,45,71,155,172,251,27,7,109,247,176,159,118,178,57,91,163,128,141,108,131,158,146,72,42,19,33,55,217,246,10,35,197,105,3,214,165,9,201,30,186,29,213,116,110,21,239,125,42,148,166,53,226,34,231,195,153,116,9,26,60,73,243,181,156,217,102,53,56,178,29,220,111,67,80,111,121,207,16,132,69,233,122,161,78,192,200,184,95,233,244,26,215,255,16,162,159,245,245,13,23,165,178,232,234,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13"));
		}

		#endregion

	}

	#endregion

}

