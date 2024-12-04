namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportTagManagerSchema

	/// <exclude/>
	public class IFileImportTagManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportTagManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportTagManagerSchema(IFileImportTagManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee7c80a9-3a5c-4e84-9235-9be88e7c35d7");
			Name = "IFileImportTagManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,147,77,78,195,48,16,133,215,141,148,59,140,186,1,36,148,28,128,80,169,148,34,117,1,27,202,1,166,201,56,24,37,118,228,153,68,138,80,239,142,243,199,159,130,84,118,221,141,173,111,158,231,61,219,6,75,226,10,83,130,61,57,135,108,149,68,27,107,148,206,107,135,162,173,137,30,116,65,187,178,178,78,194,224,61,12,22,85,125,40,116,10,218,8,57,213,53,238,190,136,61,230,143,104,48,39,231,193,14,94,196,113,12,9,215,101,137,174,93,77,27,27,71,40,196,32,152,115,244,73,197,191,177,164,66,135,37,24,63,226,237,146,201,100,228,150,171,109,67,70,96,88,129,61,188,81,42,81,18,247,228,124,35,186,156,167,54,95,215,165,47,248,71,75,99,117,54,206,228,13,240,229,160,58,158,113,13,119,164,172,27,13,110,141,104,209,196,207,216,80,47,185,246,234,157,44,95,221,132,193,159,134,59,220,99,69,209,91,6,175,7,132,233,43,232,94,148,50,240,74,90,218,115,201,162,119,215,79,52,151,199,183,36,218,142,204,254,17,196,61,21,52,221,60,104,53,248,246,121,66,102,137,205,133,140,137,156,75,16,195,184,79,86,94,152,178,185,44,214,202,255,130,19,159,198,49,12,142,31,163,6,56,38,111,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee7c80a9-3a5c-4e84-9235-9be88e7c35d7"));
		}

		#endregion

	}

	#endregion

}

