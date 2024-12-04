namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IConfigurableMailingProviderSchema

	/// <exclude/>
	public class IConfigurableMailingProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IConfigurableMailingProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IConfigurableMailingProviderSchema(IConfigurableMailingProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cc13a695-7766-435a-88b7-db1edaea23f9");
			Name = "IConfigurableMailingProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,191,14,130,48,16,135,103,72,120,135,75,92,116,129,93,141,139,147,3,137,131,47,80,202,129,151,208,150,92,139,137,49,188,187,149,22,255,14,110,189,235,253,190,126,87,45,20,218,94,72,132,19,50,11,107,26,151,239,141,110,168,29,88,56,50,58,47,5,117,164,219,44,189,101,105,150,38,11,198,214,183,225,160,29,114,227,131,107,56,60,3,85,135,113,252,200,230,66,53,242,148,41,138,2,182,118,80,74,240,117,23,235,56,96,65,161,59,155,218,130,51,32,35,7,65,5,10,244,17,147,207,148,226,13,211,15,85,71,18,104,54,249,35,146,132,5,158,27,148,225,225,53,28,39,78,184,252,86,157,26,51,214,219,122,161,30,217,145,63,154,6,228,192,140,218,121,5,235,132,150,248,208,252,245,76,46,134,234,23,100,185,218,68,17,212,117,112,153,234,49,252,239,71,115,188,3,127,193,109,112,160,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc13a695-7766-435a-88b7-db1edaea23f9"));
		}

		#endregion

	}

	#endregion

}

