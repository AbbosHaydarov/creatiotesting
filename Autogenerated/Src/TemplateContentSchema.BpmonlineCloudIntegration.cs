namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TemplateContentSchema

	/// <exclude/>
	public class TemplateContentSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TemplateContentSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TemplateContentSchema(TemplateContentSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5dae23e0-f39b-4db5-9d47-a9196b501f89");
			Name = "TemplateContent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,205,14,130,48,16,132,207,146,240,14,155,120,135,187,26,47,196,120,50,33,145,23,168,184,96,19,104,201,238,114,48,196,119,183,165,98,240,231,160,189,52,157,157,233,124,173,81,45,114,167,74,132,2,137,20,219,74,146,204,154,74,215,61,41,209,214,36,217,238,120,176,103,108,56,142,134,56,138,163,197,146,176,118,3,200,26,197,188,114,185,182,107,148,160,75,9,26,25,45,105,154,194,134,251,182,85,116,221,62,206,126,21,23,4,121,248,161,12,129,100,242,167,179,64,215,159,26,93,66,233,43,62,27,22,1,228,73,146,147,237,144,68,163,195,201,199,100,152,191,99,140,194,30,133,193,18,176,223,197,1,205,56,62,65,38,18,22,210,166,158,188,48,64,141,178,246,119,172,225,246,79,153,113,255,253,83,147,55,126,171,89,162,57,135,103,143,231,160,190,138,78,187,3,77,211,55,129,215,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5dae23e0-f39b-4db5-9d47-a9196b501f89"));
		}

		#endregion

	}

	#endregion

}

