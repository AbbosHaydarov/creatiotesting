namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorActionsCompatibilitySchema

	/// <exclude/>
	public class TermCalculatorActionsCompatibilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorActionsCompatibilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorActionsCompatibilitySchema(TermCalculatorActionsCompatibilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bd1f02c-f0ef-4a00-a80e-35032b31deb1");
			Name = "TermCalculatorActionsCompatibility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ccef5f7c-bb3c-488e-aeef-d23f70e5d985");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,83,200,75,204,77,45,46,72,76,78,85,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,74,44,201,204,207,227,229,82,168,230,229,226,44,45,206,204,75,87,8,174,44,46,73,205,181,70,227,3,53,228,228,164,38,131,84,23,235,185,167,230,165,22,101,38,99,168,241,201,204,43,68,8,34,91,150,155,155,159,135,93,166,40,21,151,184,158,107,94,73,102,73,102,106,49,80,129,66,45,0,135,167,198,25,198,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bd1f02c-f0ef-4a00-a80e-35032b31deb1"));
		}

		#endregion

	}

	#endregion

}

