namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesScheduledSearchParameterCronFactorySchema

	/// <exclude/>
	public class DuplicatesScheduledSearchParameterCronFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesScheduledSearchParameterCronFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesScheduledSearchParameterCronFactorySchema(DuplicatesScheduledSearchParameterCronFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bafd10b7-77ee-4318-8348-d2d3788c8c67");
			Name = "DuplicatesScheduledSearchParameterCronFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,219,78,219,64,16,134,175,141,196,59,12,166,66,54,138,86,72,189,43,5,46,18,14,170,128,34,57,45,215,203,122,98,175,112,118,205,236,46,106,132,242,238,140,15,137,147,84,21,229,114,78,223,204,255,239,26,57,71,87,75,133,48,69,34,233,236,204,139,177,53,51,93,4,146,94,91,35,38,152,135,186,210,170,141,246,247,222,246,247,162,224,180,41,32,91,56,143,243,211,157,88,220,106,243,194,73,78,31,18,22,60,3,227,74,58,247,13,38,61,6,93,166,74,134,86,152,103,40,73,149,15,146,248,10,143,52,38,107,174,164,242,150,22,45,160,14,79,60,1,206,243,110,5,170,193,124,150,18,53,247,14,151,88,195,48,227,249,154,7,210,175,76,105,247,68,117,23,128,106,234,160,141,135,137,92,252,156,61,34,62,103,165,37,127,207,228,91,52,133,47,225,12,190,118,234,162,67,52,121,199,237,227,126,201,29,250,210,230,205,138,246,252,126,195,150,20,231,169,113,236,26,125,115,236,229,159,154,208,57,158,77,154,214,40,242,165,254,31,161,144,127,216,146,66,171,63,122,149,4,174,45,177,48,199,34,62,30,21,217,186,255,116,135,49,213,115,252,12,163,233,31,24,57,19,59,111,153,113,105,194,92,176,15,191,101,21,208,37,126,81,163,157,37,235,213,93,95,154,118,190,136,177,116,254,251,78,241,60,89,85,31,75,36,76,24,191,162,159,111,104,22,55,210,93,85,178,24,234,41,28,29,193,208,125,112,6,59,100,113,111,13,174,224,25,86,168,252,54,125,29,136,169,205,218,39,77,226,235,56,21,89,120,234,94,56,57,25,253,243,39,165,60,244,171,174,145,146,52,237,204,33,244,129,12,124,137,79,224,109,48,90,220,105,19,216,227,229,86,242,198,6,226,212,5,28,115,186,221,37,126,88,109,146,120,20,143,54,28,78,151,112,28,183,244,229,223,159,182,207,109,166,150,239,34,70,159,127,16,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bafd10b7-77ee-4318-8348-d2d3788c8c67"));
		}

		#endregion

	}

	#endregion

}

