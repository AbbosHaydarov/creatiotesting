namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISectionStructureBuilderSchema

	/// <exclude/>
	public class ISectionStructureBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISectionStructureBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISectionStructureBuilderSchema(ISectionStructureBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f3b188d-ae35-4cb4-bff8-fb00b0b7fadd");
			Name = "ISectionStructureBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,193,10,194,48,12,134,207,29,236,29,2,94,20,100,15,160,39,55,47,187,120,153,47,80,187,108,22,214,118,36,173,48,100,239,110,187,161,120,209,83,248,147,63,249,191,88,105,144,71,169,16,174,72,36,217,117,190,168,156,237,116,31,72,122,237,108,158,61,243,44,207,68,96,109,123,104,38,246,104,142,31,253,189,68,248,171,95,156,203,56,138,195,13,97,31,111,66,109,61,82,23,83,15,80,55,168,82,78,227,41,40,31,8,203,160,135,22,105,241,143,225,54,104,5,250,109,255,227,22,17,83,136,135,211,45,156,198,113,152,170,192,222,153,248,74,171,211,2,111,217,83,34,99,117,71,35,47,241,237,61,52,56,196,115,192,75,217,37,250,121,197,68,219,174,164,73,206,47,223,20,32,138,36,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f3b188d-ae35-4cb4-bff8-fb00b0b7fadd"));
		}

		#endregion

	}

	#endregion

}

