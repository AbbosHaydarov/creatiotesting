namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExportToExcelExceptionSchema

	/// <exclude/>
	public class ExportToExcelExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExportToExcelExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExportToExcelExceptionSchema(ExportToExcelExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("091dd986-6c16-40af-a793-56676e4cbe11");
			Name = "ExportToExcelException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,193,10,131,48,12,134,207,10,190,67,240,164,32,101,231,141,157,198,6,59,236,52,95,160,118,81,4,109,165,169,224,16,223,125,169,186,137,176,67,67,154,254,255,151,191,90,182,72,157,84,8,57,90,43,201,148,78,92,140,46,235,170,183,210,213,70,139,235,208,25,235,114,115,29,20,54,81,56,70,97,208,83,173,43,120,190,201,97,123,138,66,158,116,125,209,212,10,84,35,137,96,231,240,165,243,32,56,242,195,218,179,195,115,126,54,163,201,1,57,235,177,15,36,146,21,222,140,109,165,131,51,196,27,225,213,207,10,156,249,224,12,119,188,65,192,93,107,180,243,101,209,141,135,41,94,114,125,55,252,143,148,108,104,28,82,14,88,72,194,100,201,33,150,0,201,46,78,198,58,177,78,210,204,243,3,111,156,255,50,113,225,19,133,211,7,120,46,164,241,84,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("091dd986-6c16-40af-a793-56676e4cbe11"));
		}

		#endregion

	}

	#endregion

}

