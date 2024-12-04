namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailPageUrlProviderSchema

	/// <exclude/>
	public class IEmailPageUrlProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailPageUrlProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailPageUrlProviderSchema(IEmailPageUrlProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("165404bb-9661-404d-9757-27cf818ed4a9");
			Name = "IEmailPageUrlProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3d36152b-fa20-493f-a37d-8eae7cdc8721");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,143,203,10,194,48,16,69,215,45,244,31,102,169,27,243,1,138,27,21,17,92,72,209,15,136,58,141,193,54,173,147,137,32,226,191,155,244,129,245,181,10,185,153,147,115,199,200,2,109,37,15,8,91,36,146,182,204,120,52,43,77,166,149,35,201,186,52,73,124,79,226,72,8,1,19,235,138,66,210,109,218,222,55,84,94,245,17,45,240,9,97,239,242,51,96,33,117,14,62,210,202,32,193,46,93,143,58,86,244,224,202,237,115,125,0,109,24,41,11,234,213,34,128,27,169,112,71,121,251,45,249,193,96,254,82,71,33,168,129,151,137,111,21,6,85,253,246,230,138,44,147,54,10,230,237,232,214,79,174,142,112,7,133,60,134,71,18,255,85,164,200,142,140,109,151,170,124,185,110,161,31,150,58,161,134,152,54,229,58,98,34,186,188,87,103,137,220,223,121,240,113,79,241,226,208,50,80,115,14,199,30,245,93,31,73,252,4,23,93,168,245,176,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("165404bb-9661-404d-9757-27cf818ed4a9"));
		}

		#endregion

	}

	#endregion

}

