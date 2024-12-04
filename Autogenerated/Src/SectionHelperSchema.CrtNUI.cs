namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionHelperSchema

	/// <exclude/>
	public class SectionHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionHelperSchema(SectionHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33d4e612-facc-4d4c-9516-d0f60d673446");
			Name = "SectionHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9defff70-969f-468c-8263-69f6e8af1009");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,81,205,110,194,48,12,62,7,137,119,136,196,5,46,125,0,216,118,24,221,216,14,155,38,21,30,32,11,166,141,148,38,149,237,78,67,104,239,190,164,65,26,133,149,43,82,46,254,108,127,63,142,83,53,80,163,52,200,53,32,42,242,59,206,150,222,237,76,217,162,98,227,221,120,116,24,143,68,75,198,149,178,216,19,67,189,56,171,179,53,124,243,5,184,244,214,130,142,12,148,173,192,1,26,125,49,147,43,86,127,224,169,129,186,246,238,255,14,194,16,158,61,57,54,108,128,6,7,158,149,102,143,3,19,239,173,25,92,204,31,67,43,52,155,246,211,26,45,181,85,68,178,72,241,94,192,54,128,115,249,218,171,229,161,91,16,19,132,50,128,242,13,184,242,91,154,203,143,142,34,53,143,116,196,24,53,87,192,189,203,23,26,77,195,211,13,1,6,220,37,118,217,246,202,89,212,17,66,124,41,148,85,18,190,151,203,104,47,101,221,135,219,243,93,159,246,212,230,195,116,22,67,11,129,192,45,186,35,71,54,96,229,76,123,17,55,127,134,162,88,3,142,55,206,112,161,43,168,85,14,212,145,120,164,155,69,186,98,233,74,180,9,184,109,250,197,174,14,104,120,191,13,139,216,82,56,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33d4e612-facc-4d4c-9516-d0f60d673446"));
		}

		#endregion

	}

	#endregion

}

