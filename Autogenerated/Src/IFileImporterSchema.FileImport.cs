namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImporterSchema

	/// <exclude/>
	public class IFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImporterSchema(IFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa525843-9e33-4417-81db-be5e451e98f6");
			Name = "IFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,111,194,48,12,134,207,84,234,127,176,216,101,92,90,113,152,38,1,67,2,196,52,14,104,104,112,155,118,8,173,91,34,181,73,101,167,76,104,219,127,95,154,142,207,173,104,183,56,175,253,216,126,147,146,165,74,97,185,99,131,121,223,247,124,79,137,28,185,16,17,194,10,137,4,235,196,4,19,173,18,153,150,36,140,212,42,120,148,25,206,242,66,147,241,189,15,223,107,21,229,58,147,17,72,101,144,146,170,112,118,204,64,130,30,204,198,130,241,244,206,22,85,133,173,48,12,97,192,101,158,11,218,13,247,23,75,177,69,144,46,19,182,34,43,145,193,104,136,215,144,104,2,70,65,209,6,80,25,105,36,242,1,18,94,82,6,133,32,145,67,181,205,67,219,157,209,54,230,246,112,16,186,232,152,72,104,74,82,108,133,253,169,146,94,159,215,172,51,91,115,219,190,15,186,119,65,23,62,97,181,65,176,152,141,142,65,50,196,88,16,70,194,96,28,180,59,111,85,205,90,235,204,141,255,34,222,235,85,167,63,115,222,214,225,226,48,7,28,71,234,56,219,91,173,27,194,212,218,11,211,173,221,142,123,176,112,182,214,26,86,119,181,242,36,84,156,33,13,78,26,236,108,79,251,138,78,30,81,202,67,248,45,246,255,11,194,41,145,166,102,86,173,55,227,198,104,223,9,207,215,119,101,71,98,83,74,51,116,148,88,167,174,50,71,127,103,92,89,91,37,122,142,204,34,61,197,156,19,230,72,233,53,196,133,51,241,21,215,226,102,204,68,103,101,174,22,164,35,59,206,165,251,191,197,253,119,65,21,215,63,198,197,95,190,247,245,13,53,177,95,199,204,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa525843-9e33-4417-81db-be5e451e98f6"));
		}

		#endregion

	}

	#endregion

}

