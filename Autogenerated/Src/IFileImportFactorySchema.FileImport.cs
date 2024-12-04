namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportFactorySchema

	/// <exclude/>
	public class IFileImportFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportFactorySchema(IFileImportFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40607472-ce99-41c0-a6b6-c3ff07be295d");
			Name = "IFileImportFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,77,107,132,48,16,61,43,248,31,6,123,233,66,209,123,187,21,150,165,22,111,123,104,127,64,86,71,9,104,34,147,164,32,101,255,123,39,102,187,214,174,185,205,35,239,99,222,40,49,160,25,69,141,240,129,68,194,232,214,102,71,173,90,217,57,18,86,106,149,149,178,199,106,24,53,217,36,254,78,98,224,231,140,84,221,138,64,248,146,196,73,28,61,16,118,76,130,74,89,164,150,101,159,161,90,4,74,81,91,77,147,255,201,127,243,60,135,189,113,195,32,104,42,174,243,141,7,173,38,56,59,217,55,222,10,149,149,86,162,1,171,97,145,203,126,69,242,63,42,163,59,247,178,6,121,19,218,242,143,120,145,232,46,192,12,188,163,133,145,164,199,130,237,4,173,84,13,146,119,187,183,11,200,40,72,12,160,184,203,215,212,25,36,110,80,97,237,235,75,139,96,205,157,33,129,65,107,121,31,147,237,243,153,178,173,80,235,222,13,202,156,72,215,104,140,166,180,56,6,4,190,68,239,208,100,43,122,117,10,105,223,230,176,229,156,213,111,177,1,63,126,174,178,205,153,150,241,9,170,171,207,161,235,248,142,130,187,58,52,98,228,34,225,127,164,29,159,59,186,132,147,163,106,194,213,253,120,249,1,21,227,85,65,81,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40607472-ce99-41c0-a6b6-c3ff07be295d"));
		}

		#endregion

	}

	#endregion

}

