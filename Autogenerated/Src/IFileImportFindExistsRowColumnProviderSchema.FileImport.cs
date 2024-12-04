namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportFindExistsRowColumnProviderSchema

	/// <exclude/>
	public class IFileImportFindExistsRowColumnProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportFindExistsRowColumnProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportFindExistsRowColumnProviderSchema(IFileImportFindExistsRowColumnProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b5f7147-1048-4e83-b190-46e2217d17c7");
			Name = "IFileImportFindExistsRowColumnProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,203,110,226,64,16,60,131,196,63,180,156,75,246,130,239,9,177,20,145,176,66,187,90,69,43,126,96,240,180,161,181,158,25,52,15,30,138,242,239,59,15,27,12,36,38,23,100,247,148,171,107,186,170,145,76,160,217,176,18,97,129,90,51,163,42,59,158,42,89,209,202,105,102,73,201,241,140,106,156,139,141,210,118,52,124,31,13,71,195,193,157,198,149,63,129,105,205,140,121,128,19,96,70,146,191,238,201,88,243,87,237,166,170,118,66,206,101,165,226,71,121,158,195,196,56,33,152,62,20,205,251,155,86,91,226,104,128,60,74,139,216,15,216,82,57,11,20,9,145,67,25,105,198,45,67,222,161,216,184,101,77,37,148,65,198,119,84,12,146,252,43,41,177,176,88,35,72,39,80,123,198,45,171,29,130,170,192,250,98,18,224,37,114,220,7,25,215,58,90,33,36,45,180,253,60,24,222,97,133,246,17,76,248,249,232,105,157,100,183,141,38,6,125,83,141,213,83,150,14,18,101,150,23,253,221,187,224,243,151,11,29,131,164,229,14,37,79,70,158,153,58,151,22,117,229,3,241,0,243,222,153,54,230,233,219,238,86,78,150,193,90,86,147,61,128,85,32,152,100,171,227,100,101,136,32,248,0,120,133,76,151,107,146,43,192,208,43,60,104,181,51,192,157,14,207,149,151,211,4,163,47,15,212,222,224,219,23,8,193,248,194,155,23,244,100,130,164,87,200,153,101,75,102,206,116,127,97,73,172,108,152,102,34,162,158,178,242,24,195,172,104,92,9,153,239,120,125,51,191,33,0,147,60,146,158,122,104,180,78,75,211,114,70,73,147,188,173,6,152,177,113,118,63,209,190,44,19,234,143,7,221,223,108,215,220,50,60,254,120,236,11,175,36,107,26,176,185,242,178,99,36,150,74,115,211,55,48,220,151,184,137,255,1,151,35,121,245,39,200,145,63,111,25,213,108,89,227,47,60,36,169,230,55,9,138,231,241,203,172,88,172,99,100,118,107,148,113,125,5,219,147,112,2,234,128,243,59,221,118,99,45,21,252,195,195,81,63,25,175,56,245,242,115,60,10,250,220,212,20,197,183,80,9,41,49,89,209,108,114,4,197,210,213,50,119,208,121,209,181,115,171,136,199,97,118,109,154,41,125,186,233,253,37,67,179,11,167,66,99,212,103,251,253,241,31,204,19,245,31,233,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b5f7147-1048-4e83-b190-46e2217d17c7"));
		}

		#endregion

	}

	#endregion

}

