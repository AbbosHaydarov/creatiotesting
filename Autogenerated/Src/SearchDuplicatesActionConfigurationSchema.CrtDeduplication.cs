namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SearchDuplicatesActionConfigurationSchema

	/// <exclude/>
	public class SearchDuplicatesActionConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SearchDuplicatesActionConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SearchDuplicatesActionConfigurationSchema(SearchDuplicatesActionConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9a4d829-6614-4e72-91b0-9433556c337c");
			Name = "SearchDuplicatesActionConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,95,107,194,48,16,127,86,240,59,28,248,222,190,171,8,67,135,8,123,144,117,95,32,75,175,53,208,36,37,151,12,138,248,221,119,73,219,77,157,108,238,37,112,119,191,251,253,57,98,132,70,106,133,68,120,67,231,4,217,202,103,27,107,42,85,7,39,188,178,38,219,98,25,218,70,201,84,205,166,167,217,116,18,72,153,26,138,142,60,234,229,77,205,219,77,131,50,130,41,219,161,65,167,228,55,230,82,68,107,107,238,79,28,102,7,103,37,18,241,156,17,115,135,53,243,193,166,17,68,11,40,80,56,121,220,14,174,144,158,146,218,149,235,180,150,231,57,172,40,104,45,92,183,30,106,230,253,80,37,18,80,34,129,49,27,119,68,162,1,121,149,126,164,201,47,120,218,240,206,59,32,163,155,199,204,76,248,106,252,126,5,97,23,45,58,175,144,211,28,18,91,63,191,117,156,26,207,198,43,223,193,190,140,102,126,186,25,237,236,130,42,7,236,190,132,19,212,232,151,156,146,159,243,223,228,36,143,168,5,24,254,13,15,171,20,105,231,31,90,47,138,60,216,10,92,104,144,126,151,137,208,85,212,90,195,107,68,167,213,59,58,115,52,101,127,211,84,247,221,235,230,249,19,248,234,101,142,227,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9a4d829-6614-4e72-91b0-9433556c337c"));
		}

		#endregion

	}

	#endregion

}

