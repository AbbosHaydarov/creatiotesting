namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspOperationExtensionsSchema

	/// <exclude/>
	public class SspOperationExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspOperationExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspOperationExtensionsSchema(SspOperationExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63085386-1dd0-42f1-b47d-9c7bcf45cfbd");
			Name = "SspOperationExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,205,110,219,48,12,199,207,46,208,119,224,188,139,3,20,246,125,109,2,172,105,182,203,134,21,240,246,0,138,66,219,66,45,201,16,233,38,217,218,119,159,36,59,70,62,218,97,7,11,22,73,253,249,163,72,25,161,145,58,33,17,126,162,115,130,108,197,249,210,154,74,213,189,19,172,172,201,203,242,241,250,234,207,245,85,210,147,50,53,148,123,98,212,121,137,178,119,138,247,183,147,227,248,188,214,214,188,237,113,248,158,61,127,184,247,46,239,252,232,176,246,137,97,217,10,162,79,80,82,247,163,195,1,102,181,99,52,228,127,40,70,22,69,1,119,212,107,45,220,126,49,238,227,41,168,172,131,173,117,79,33,205,86,113,3,226,89,168,86,172,91,4,123,16,35,240,73,136,186,252,160,84,28,73,117,253,186,85,18,136,125,168,4,25,69,223,35,73,252,237,248,245,2,103,224,105,80,62,17,168,10,184,65,232,9,29,52,130,192,169,186,97,2,182,160,133,17,53,6,144,232,165,128,115,201,51,88,58,225,132,6,227,123,54,79,105,236,192,202,212,202,96,186,56,116,4,48,26,60,9,34,72,135,213,60,125,184,47,79,131,139,197,93,17,181,162,244,105,173,207,86,109,6,234,165,48,223,35,156,47,252,87,64,203,184,81,4,231,106,112,74,50,131,48,44,73,178,182,182,5,41,204,231,141,86,70,17,251,123,67,152,159,5,231,95,145,125,154,213,206,91,25,167,219,205,210,41,119,76,156,206,224,229,37,170,38,255,127,254,56,241,163,117,44,218,81,235,54,42,249,142,100,31,206,248,14,236,9,55,206,110,193,224,22,166,90,119,18,187,168,237,67,253,88,229,95,172,211,130,179,16,243,205,74,209,170,223,97,188,202,232,204,210,211,217,78,111,6,217,228,162,21,249,164,155,47,123,231,208,112,128,244,244,198,242,88,85,4,156,74,75,103,55,240,207,234,198,242,94,195,26,22,255,133,71,133,102,51,188,171,176,125,253,11,191,116,34,149,247,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63085386-1dd0-42f1-b47d-9c7bcf45cfbd"));
		}

		#endregion

	}

	#endregion

}

