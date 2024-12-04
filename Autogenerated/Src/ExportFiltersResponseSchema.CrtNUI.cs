namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExportFiltersResponseSchema

	/// <exclude/>
	public class ExportFiltersResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExportFiltersResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExportFiltersResponseSchema(ExportFiltersResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83451a60-7d62-4ce4-941d-7458d5f504cd");
			Name = "ExportFiltersResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,193,78,2,65,12,134,207,144,240,14,13,92,244,178,15,0,241,180,226,197,64,200,226,205,120,24,198,178,105,220,153,217,116,186,200,74,120,119,187,179,138,89,149,75,147,182,127,191,254,173,55,14,99,109,44,194,19,50,155,24,246,146,229,193,239,169,108,216,8,5,159,21,88,7,150,45,242,129,44,78,198,167,201,120,212,68,242,37,108,219,40,232,178,162,241,66,14,51,85,144,169,232,35,77,45,46,170,43,88,21,168,100,198,88,106,2,121,101,98,156,195,242,216,173,122,160,74,144,99,161,190,130,143,152,132,207,247,70,140,2,132,141,149,23,45,212,205,174,34,11,182,27,252,127,14,230,48,216,248,117,193,15,118,164,167,104,188,152,216,112,168,145,133,80,157,108,18,190,239,167,221,43,116,59,228,155,181,190,11,238,96,250,134,237,244,182,243,241,109,36,10,119,215,62,98,11,167,18,101,1,81,195,249,58,192,153,227,82,255,38,109,17,222,243,160,47,28,226,200,11,172,126,75,254,146,103,232,95,123,247,41,239,171,195,226,249,19,116,13,134,156,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83451a60-7d62-4ce4-941d-7458d5f504cd"));
		}

		#endregion

	}

	#endregion

}

