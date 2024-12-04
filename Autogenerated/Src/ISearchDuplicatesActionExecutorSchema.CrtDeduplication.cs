namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISearchDuplicatesActionExecutorSchema

	/// <exclude/>
	public class ISearchDuplicatesActionExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISearchDuplicatesActionExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISearchDuplicatesActionExecutorSchema(ISearchDuplicatesActionExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b0287fd-e228-4668-ae2a-c035310e2343");
			Name = "ISearchDuplicatesActionExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,144,207,106,195,48,12,198,207,41,244,29,4,187,180,151,228,222,141,194,104,74,233,97,48,232,94,192,115,148,212,16,203,65,178,97,101,244,221,231,218,253,151,50,232,197,32,235,167,239,251,36,82,22,101,80,26,225,11,153,149,184,214,151,43,71,173,233,2,43,111,28,149,53,54,97,232,141,78,213,116,242,59,157,20,65,12,117,176,59,136,71,251,250,80,199,233,190,71,125,130,165,220,32,33,27,125,99,238,77,172,117,20,59,177,247,194,216,69,30,182,228,145,219,24,102,1,219,29,42,214,251,250,108,141,242,158,36,215,63,168,131,119,156,198,170,170,130,55,9,214,42,62,44,207,245,40,45,88,69,170,67,46,47,112,117,71,15,225,59,114,96,46,158,207,45,139,184,123,124,175,113,63,208,239,93,35,11,248,76,82,185,185,9,166,129,60,131,55,169,44,61,251,223,97,116,111,144,231,204,252,116,208,34,69,65,106,114,154,228,126,204,231,28,125,30,255,0,203,238,46,251,227,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b0287fd-e228-4668-ae2a-c035310e2343"));
		}

		#endregion

	}

	#endregion

}

