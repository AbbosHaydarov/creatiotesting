namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationBatchSchema

	/// <exclude/>
	public class TranslationBatchSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationBatchSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationBatchSchema(TranslationBatchSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10369cb8-3549-4f33-8ff6-7c40df21ba6d");
			Name = "TranslationBatch";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,143,221,74,195,64,16,133,175,55,144,119,24,240,70,161,36,247,181,246,194,10,34,222,20,204,11,172,235,52,93,76,54,97,102,35,4,241,221,157,253,81,211,214,155,36,156,28,206,247,141,211,61,242,168,13,66,131,68,154,135,131,175,118,131,59,216,118,34,237,237,224,170,134,180,227,46,126,151,197,103,89,168,137,173,107,225,101,102,143,189,116,187,14,77,248,201,213,35,58,36,107,110,203,66,90,87,132,173,164,176,235,52,243,26,22,43,247,218,155,99,236,140,211,107,103,13,152,80,185,104,192,26,30,108,92,214,52,111,216,147,80,87,144,222,219,21,60,93,46,42,177,147,231,31,90,164,60,77,198,15,36,6,251,8,75,141,12,110,206,38,174,211,58,188,227,124,3,225,84,165,158,113,134,187,16,200,85,74,125,101,0,186,183,196,56,5,238,105,24,145,188,197,51,92,93,215,176,225,169,239,229,146,237,79,176,128,135,253,234,183,88,47,155,217,52,139,5,155,228,213,162,143,70,106,36,251,161,61,2,231,224,127,197,148,158,134,146,125,3,35,55,58,13,254,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10369cb8-3549-4f33-8ff6-7c40df21ba6d"));
		}

		#endregion

	}

	#endregion

}

