namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRemindingRepositorySchema

	/// <exclude/>
	public class IRemindingRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRemindingRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRemindingRepositorySchema(IRemindingRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4233de2b-b2d2-4f8a-93e4-3ee4626b552e");
			Name = "IRemindingRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,205,106,2,49,16,62,43,248,14,131,94,218,139,123,111,237,94,74,145,92,74,209,190,64,220,204,234,192,38,89,102,18,65,74,223,189,73,252,91,20,11,123,201,240,253,206,142,211,22,165,215,13,194,55,50,107,241,109,152,191,123,215,210,54,178,14,228,221,100,252,51,25,143,162,144,219,194,250,32,1,237,235,205,59,225,187,14,155,12,150,249,18,29,50,53,25,147,190,25,227,54,141,65,185,128,220,38,151,23,80,43,180,228,76,162,175,176,247,66,193,243,97,50,78,216,170,170,96,33,209,90,205,135,250,244,254,98,191,39,131,2,26,44,134,157,55,208,122,6,198,6,105,159,3,112,209,66,150,249,89,160,26,40,244,113,211,81,3,116,54,127,224,61,202,5,239,236,203,96,133,33,178,147,147,79,226,21,163,123,167,227,132,143,232,250,186,15,160,22,194,14,135,252,69,117,134,101,158,250,112,209,34,235,77,135,11,245,233,3,181,212,148,181,43,215,250,26,150,24,46,145,229,233,57,109,245,97,212,53,134,97,78,32,1,65,23,254,203,219,107,214,22,92,186,128,183,233,133,169,204,116,88,192,223,20,128,244,59,92,142,137,156,170,20,133,34,184,247,100,114,134,107,92,37,235,132,124,26,54,92,70,50,245,85,75,153,220,104,244,91,90,205,208,153,227,181,148,211,73,195,63,252,54,224,50,155,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4233de2b-b2d2-4f8a-93e4-3ee4626b552e"));
		}

		#endregion

	}

	#endregion

}

