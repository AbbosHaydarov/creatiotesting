namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationRemindingRepositorySchema

	/// <exclude/>
	public class IDeduplicationRemindingRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationRemindingRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationRemindingRepositorySchema(IDeduplicationRemindingRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de0d4303-7aff-4f8a-be80-67a2241441e9");
			Name = "IDeduplicationRemindingRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,65,106,195,48,16,69,215,49,228,14,131,87,45,4,251,0,77,189,73,54,221,148,146,180,7,144,173,177,163,80,73,102,36,5,76,201,221,59,178,157,196,38,161,116,167,153,209,124,189,255,145,17,26,93,43,42,132,79,36,18,206,214,62,219,88,83,171,38,144,240,202,154,108,139,50,180,223,170,234,171,101,242,179,76,22,193,41,211,204,22,8,95,150,9,79,242,60,135,181,11,90,11,234,138,177,254,32,123,82,18,29,104,244,7,43,161,182,4,90,24,209,68,17,57,85,7,66,173,140,228,190,203,46,98,249,68,173,13,37,95,5,101,60,82,29,153,223,102,112,187,203,246,14,91,235,148,183,212,241,82,4,190,227,234,27,27,66,225,153,171,127,181,167,41,59,104,212,9,39,32,12,232,42,82,109,212,95,129,11,229,17,43,15,194,200,57,249,69,210,85,7,212,2,12,167,26,29,220,91,24,58,173,32,161,251,91,175,105,112,72,156,184,97,93,22,74,139,47,174,161,186,54,178,117,222,223,126,188,124,229,220,222,48,211,98,247,136,254,159,66,251,193,226,84,100,116,253,183,192,224,252,157,207,105,177,159,164,48,93,58,89,37,199,212,175,234,79,209,239,205,63,204,227,224,200,61,69,134,71,70,239,135,35,252,42,62,182,24,135,55,176,103,254,163,139,115,252,167,231,95,218,147,52,42,247,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de0d4303-7aff-4f8a-be80-67a2241441e9"));
		}

		#endregion

	}

	#endregion

}

