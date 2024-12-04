namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationBatchSchema

	/// <exclude/>
	public class ITranslationBatchSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationBatchSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationBatchSchema(ITranslationBatchSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a16d126-b908-4b9c-8616-b21a5c69f407");
			Name = "ITranslationBatch";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,77,10,194,48,16,133,215,41,244,14,3,110,165,221,171,184,80,65,138,27,65,47,16,227,180,6,219,180,204,164,139,34,222,221,105,162,82,113,147,159,55,111,222,55,137,211,13,114,167,13,194,25,137,52,183,165,207,182,173,43,109,213,147,246,182,117,217,153,180,227,58,156,211,228,145,38,170,103,235,42,56,13,236,177,17,111,93,163,25,139,156,237,209,33,89,179,76,19,113,205,8,43,81,161,112,30,169,20,192,2,138,73,212,70,123,115,11,198,174,191,212,214,128,253,248,254,109,32,173,59,27,32,154,134,21,123,146,1,230,16,247,181,68,200,84,178,126,145,71,106,59,36,111,145,23,112,12,233,177,158,231,57,172,184,111,26,73,25,219,130,48,129,193,29,135,236,107,204,167,206,200,130,3,14,48,126,129,82,21,122,121,167,82,207,55,26,221,53,210,195,61,170,191,162,104,47,48,124,134,191,109,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a16d126-b908-4b9c-8616-b21a5c69f407"));
		}

		#endregion

	}

	#endregion

}

