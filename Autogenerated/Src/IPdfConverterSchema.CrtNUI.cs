namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPdfConverterSchema

	/// <exclude/>
	public class IPdfConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPdfConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPdfConverterSchema(IPdfConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76370a5e-e3c8-4be4-b8c3-cb6e28b3bda1");
			Name = "IPdfConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f001c5cb-0040-4460-8f61-804897c60feb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,143,189,142,194,48,16,132,107,34,229,29,86,84,208,196,15,0,164,161,162,64,162,160,59,93,177,36,107,20,9,255,104,189,225,20,157,120,119,236,224,240,35,36,55,187,59,51,223,216,162,161,224,177,33,56,18,51,6,167,165,218,58,171,187,115,207,40,157,179,101,241,95,22,51,165,20,172,67,111,12,242,80,231,121,103,133,88,39,171,118,12,141,179,87,98,1,19,224,207,113,11,76,222,197,81,28,248,86,87,83,132,122,203,240,253,233,210,53,208,61,99,118,135,86,71,118,138,33,134,136,141,162,47,242,184,200,170,39,172,69,193,140,74,101,12,74,34,126,35,31,27,143,140,6,108,252,249,102,158,156,243,122,159,115,78,131,80,24,211,170,181,26,101,47,23,147,244,108,67,29,75,126,234,166,67,82,166,195,207,239,212,111,145,199,36,92,174,226,253,86,22,241,221,1,41,62,139,12,116,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76370a5e-e3c8-4be4-b8c3-cb6e28b3bda1"));
		}

		#endregion

	}

	#endregion

}

