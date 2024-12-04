namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantResponsInstallScriptExecutorSchema

	/// <exclude/>
	public class ParticipantResponsInstallScriptExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantResponsInstallScriptExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantResponsInstallScriptExecutorSchema(ParticipantResponsInstallScriptExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82641b93-7f38-4bdb-b4da-504eec4b810c");
			Name = "ParticipantResponsInstallScriptExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("95a133a1-cd5f-4df8-af8f-ad440775d7d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,207,78,195,48,12,198,207,69,226,29,162,114,41,18,244,1,134,56,176,241,71,149,24,66,20,184,103,153,183,69,74,157,42,113,10,3,241,238,184,233,54,49,214,34,46,81,227,248,251,217,254,228,162,172,192,215,82,129,120,6,231,164,183,11,202,39,22,23,122,25,156,36,109,241,248,232,243,248,40,9,94,227,82,148,107,79,80,229,119,198,206,164,209,31,241,253,98,247,250,19,80,85,67,47,14,134,226,249,13,146,38,13,158,19,56,229,196,193,146,249,98,98,164,247,35,241,40,29,105,165,107,137,244,196,29,91,244,5,122,146,198,148,202,233,154,110,222,65,5,178,46,74,53,18,56,148,70,168,86,251,95,169,24,137,98,128,153,176,7,124,238,122,154,2,173,236,188,237,42,204,140,86,221,99,29,191,69,99,245,92,116,82,200,94,60,56,182,19,65,181,94,137,176,119,61,21,173,181,73,18,231,94,151,106,5,149,156,74,148,75,112,2,122,98,151,191,244,157,97,251,73,23,63,136,162,62,24,28,24,210,131,206,239,128,58,205,120,253,192,27,145,165,135,158,65,122,246,187,255,174,152,94,136,172,167,82,126,11,164,86,183,206,86,215,227,236,138,5,13,227,89,236,201,231,61,244,2,175,109,152,81,49,63,221,218,146,52,210,245,141,208,54,200,99,32,188,137,123,171,226,34,206,12,148,228,120,165,178,77,79,81,11,56,9,134,130,219,102,111,110,5,46,108,150,2,158,191,148,233,54,125,160,76,94,2,109,84,175,210,4,200,118,200,51,145,62,179,145,252,11,52,240,23,37,18,172,9,21,118,128,180,197,178,147,3,5,255,36,201,6,182,243,125,181,39,31,113,41,1,231,221,94,198,123,23,221,15,114,236,27,204,121,157,229,233,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82641b93-7f38-4bdb-b4da-504eec4b810c"));
		}

		#endregion

	}

	#endregion

}

