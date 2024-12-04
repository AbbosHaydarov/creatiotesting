namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigFactorySchema

	/// <exclude/>
	public class IMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigFactorySchema(IMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e17ee573-06a4-435b-80a1-7eb5968f81d8");
			Name = "IMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,77,106,195,48,16,133,215,49,248,14,194,217,180,155,104,159,58,222,4,2,94,4,66,105,15,160,202,35,71,16,75,102,36,21,66,233,221,59,150,236,214,110,3,165,221,216,104,126,222,251,70,35,35,58,112,189,144,192,158,0,81,56,171,252,102,111,141,210,109,64,225,181,53,121,246,150,103,171,224,180,105,23,37,8,15,121,70,153,53,66,75,101,172,54,30,80,145,208,150,213,71,161,47,84,127,66,251,170,27,192,164,119,16,210,91,188,198,38,206,57,43,93,232,58,129,215,106,60,143,213,142,117,224,207,182,113,76,89,100,18,129,40,200,90,27,231,133,145,154,242,86,49,127,6,234,7,24,242,106,87,220,54,44,120,181,153,188,248,204,172,15,47,23,45,73,113,4,254,141,119,69,23,64,223,207,73,143,137,111,203,78,81,40,37,191,79,20,3,251,129,158,136,71,120,248,43,250,79,246,20,233,5,138,142,25,90,221,174,8,46,54,25,144,195,182,138,170,158,121,205,124,158,151,101,164,95,242,40,243,165,138,224,3,26,87,61,166,255,255,168,75,62,201,12,186,183,235,198,123,153,72,239,150,108,108,57,209,125,122,102,171,53,152,38,45,32,158,223,211,227,91,4,41,246,1,67,40,91,221,207,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e17ee573-06a4-435b-80a1-7eb5968f81d8"));
		}

		#endregion

	}

	#endregion

}

