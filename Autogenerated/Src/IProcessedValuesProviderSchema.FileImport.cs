namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IProcessedValuesProviderSchema

	/// <exclude/>
	public class IProcessedValuesProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IProcessedValuesProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IProcessedValuesProviderSchema(IProcessedValuesProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d35a2012-d756-4c04-a033-754a28ca5950");
			Name = "IProcessedValuesProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,193,106,195,48,12,134,207,13,228,29,76,79,29,140,248,1,150,229,210,18,232,109,208,177,187,234,40,197,35,150,141,108,7,202,232,187,47,113,150,44,180,189,89,214,247,75,159,8,12,122,7,10,197,39,50,131,183,109,40,246,150,90,125,137,12,65,91,42,106,221,225,209,56,203,33,207,126,242,108,227,226,185,211,74,104,10,200,237,24,60,126,176,85,232,61,54,95,208,69,244,67,217,235,6,121,96,71,126,35,165,20,165,143,198,0,95,171,249,163,214,212,120,225,230,164,232,199,104,177,224,242,158,47,29,48,24,65,131,238,251,182,65,31,52,37,189,109,53,185,9,101,187,104,72,172,90,69,41,83,232,249,140,137,79,198,247,51,38,151,135,52,99,136,76,190,90,206,93,192,185,51,162,246,252,141,42,164,251,210,240,218,242,9,122,220,77,43,246,105,195,225,95,114,45,252,42,214,80,74,255,41,165,247,203,91,158,13,27,110,121,118,251,5,6,133,52,35,182,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d35a2012-d756-4c04-a033-754a28ca5950"));
		}

		#endregion

	}

	#endregion

}

