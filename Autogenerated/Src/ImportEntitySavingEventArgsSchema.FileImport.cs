namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySavingEventArgsSchema

	/// <exclude/>
	public class ImportEntitySavingEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySavingEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySavingEventArgsSchema(ImportEntitySavingEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ddd5a40-8a06-4e75-ab40-8d237a2f6898");
			Name = "ImportEntitySavingEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f3a21-2903-49a8-8e29-be203e6136ba");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,143,77,10,194,64,12,133,215,45,244,14,3,238,61,128,174,164,40,184,16,196,122,129,177,77,135,129,54,41,147,140,82,196,187,155,254,32,138,32,110,134,228,205,151,247,18,180,45,112,103,75,48,103,8,193,50,213,178,204,9,107,239,98,176,226,9,151,59,223,192,190,237,40,72,150,222,179,52,137,236,209,153,162,103,129,118,157,165,170,44,2,56,37,77,222,88,230,149,153,224,45,138,151,190,176,87,165,183,87,64,217,4,199,35,222,197,75,227,75,83,14,244,47,216,168,21,214,116,0,102,235,224,205,35,209,53,244,125,229,30,3,117,16,196,131,134,31,71,243,233,127,14,138,30,197,156,73,108,115,162,27,231,20,181,29,14,73,18,7,162,23,104,193,115,241,248,30,84,243,82,55,128,234,223,225,5,96,53,45,54,246,147,250,41,170,246,4,66,107,25,210,120,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ddd5a40-8a06-4e75-ab40-8d237a2f6898"));
		}

		#endregion

	}

	#endregion

}

