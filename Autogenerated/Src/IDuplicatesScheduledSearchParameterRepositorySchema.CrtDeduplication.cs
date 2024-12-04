namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesScheduledSearchParameterRepositorySchema

	/// <exclude/>
	public class IDuplicatesScheduledSearchParameterRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesScheduledSearchParameterRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesScheduledSearchParameterRepositorySchema(IDuplicatesScheduledSearchParameterRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99c0874b-e6e1-4d26-9563-bae0f7a8c6d5");
			Name = "IDuplicatesScheduledSearchParameterRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,83,205,110,219,48,12,62,55,64,222,129,104,47,27,48,196,247,174,203,97,205,48,228,176,161,88,242,2,180,76,199,66,21,201,32,229,116,198,176,119,31,37,219,73,215,0,27,210,195,118,19,105,242,251,35,236,113,79,210,162,33,216,18,51,74,168,227,226,62,248,218,238,58,198,104,131,95,172,168,234,90,103,77,174,230,179,31,243,217,213,13,211,78,11,88,251,72,92,235,242,45,172,87,227,16,201,198,52,186,226,168,218,16,178,105,30,144,149,67,7,191,81,27,196,198,192,253,124,166,32,69,81,192,157,116,251,61,114,191,28,107,29,97,18,242,81,0,129,143,243,16,3,160,49,36,146,94,237,4,40,16,106,136,13,129,140,140,48,41,37,1,201,228,139,137,168,120,198,212,118,165,78,129,157,212,95,42,254,42,101,112,12,225,11,197,38,84,114,11,15,25,54,123,59,51,151,27,247,13,153,71,201,138,241,128,214,97,105,157,141,125,114,129,39,87,127,55,5,101,175,11,210,146,177,181,165,106,234,166,133,61,130,87,152,100,251,220,247,208,201,68,121,234,195,245,176,242,85,223,215,203,109,226,60,67,74,129,107,101,30,23,119,69,222,60,1,49,197,142,189,44,183,220,17,216,75,61,60,217,216,140,98,152,234,115,61,197,18,232,187,149,40,239,32,40,20,63,89,33,168,209,9,169,146,137,58,105,41,67,112,240,153,226,90,94,156,76,62,165,253,55,18,217,250,29,156,160,223,190,255,211,141,152,178,202,87,152,169,168,198,206,69,56,160,235,244,211,63,60,210,111,183,57,4,91,141,54,86,131,162,23,185,124,236,55,71,196,11,211,89,145,163,203,211,41,255,103,18,131,228,87,69,112,67,190,26,126,114,173,126,230,222,243,150,118,126,1,52,17,176,248,62,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99c0874b-e6e1-4d26-9563-bae0f7a8c6d5"));
		}

		#endregion

	}

	#endregion

}

