namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnProcessErrorEventArgsSchema

	/// <exclude/>
	public class ColumnProcessErrorEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnProcessErrorEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnProcessErrorEventArgsSchema(ColumnProcessErrorEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1ce7950-dd79-4139-9857-1c8e2032f3d9");
			Name = "ColumnProcessErrorEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,79,203,10,194,64,12,60,183,208,127,88,240,238,7,212,147,20,133,30,4,81,127,96,173,211,101,97,155,45,201,86,16,241,223,77,31,136,94,188,132,100,50,153,201,144,237,32,189,109,96,46,96,182,18,219,180,174,34,181,222,13,108,147,143,180,222,251,128,186,235,35,167,34,127,22,121,54,136,39,103,206,15,73,232,54,69,174,200,138,225,148,105,170,96,69,74,83,197,48,116,116,228,216,64,100,199,28,121,119,7,165,45,59,153,232,253,112,13,190,49,205,200,254,71,54,165,169,169,141,7,93,88,135,47,141,76,223,208,250,241,213,235,30,156,60,212,252,56,137,207,251,197,72,18,143,31,87,8,225,132,22,12,210,180,99,146,44,115,72,26,65,27,89,154,215,162,12,186,205,226,211,60,163,191,160,98,111,184,178,5,28,60,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1ce7950-dd79-4139-9857-1c8e2032f3d9"));
		}

		#endregion

	}

	#endregion

}

