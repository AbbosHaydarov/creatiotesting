namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultFileImportHeadersProcessorSchema

	/// <exclude/>
	public class DefaultFileImportHeadersProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultFileImportHeadersProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultFileImportHeadersProcessorSchema(DefaultFileImportHeadersProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d4b90d0-4c5e-4fab-b39c-029dbd674809");
			Name = "DefaultFileImportHeadersProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,83,193,110,219,48,12,61,103,192,254,129,232,46,9,16,216,247,172,205,97,94,186,5,216,208,2,217,122,87,36,58,17,32,75,46,41,21,8,138,254,251,104,203,89,220,100,91,129,93,12,147,226,227,123,120,36,189,106,144,91,165,17,126,32,145,226,80,199,162,10,190,182,187,68,42,218,224,139,91,235,112,221,180,129,34,60,191,127,55,73,108,253,14,54,7,142,216,124,60,139,5,233,28,234,14,198,197,23,244,72,86,95,212,124,179,254,241,148,28,179,18,254,45,95,172,124,180,209,34,75,129,148,124,32,220,9,7,84,78,49,47,224,51,214,42,185,120,18,250,21,149,65,226,123,10,26,153,3,245,160,178,44,225,218,250,189,136,138,38,104,208,132,245,205,213,39,197,120,1,172,8,85,12,116,85,46,143,56,78,77,163,232,112,140,165,243,147,53,200,96,50,53,232,78,9,212,129,160,205,164,176,207,173,138,99,135,114,212,162,77,91,103,245,0,122,83,61,44,224,95,42,165,159,204,69,190,39,91,196,254,72,73,203,163,184,115,223,147,229,138,129,248,77,202,233,79,70,146,54,62,15,19,210,171,112,214,181,154,44,96,43,170,166,103,79,240,12,47,131,26,244,38,11,122,173,238,59,198,125,48,157,48,10,81,80,104,242,251,185,207,255,55,48,248,141,28,27,62,105,143,92,16,158,100,179,100,118,208,175,212,97,163,247,216,40,217,219,212,120,184,181,222,228,223,233,122,229,83,131,164,182,14,175,47,43,151,64,33,196,113,134,231,32,158,119,155,171,251,248,65,185,132,226,70,111,21,97,76,228,47,49,114,91,196,241,142,134,121,76,51,20,110,150,67,175,98,245,152,148,227,33,95,84,170,237,60,158,143,41,230,176,233,75,171,208,180,138,44,203,193,222,145,177,94,185,245,206,203,229,84,98,215,108,214,221,213,228,207,115,201,217,113,242,229,23,246,24,193,55,20,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d4b90d0-4c5e-4fab-b39c-029dbd674809"));
		}

		#endregion

	}

	#endregion

}

