namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFullPipelineQueryBuilderSchema

	/// <exclude/>
	public class IFullPipelineQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFullPipelineQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFullPipelineQueryBuilderSchema(IFullPipelineQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72be6cd2-93c1-4725-9a00-7c556867169a");
			Name = "IFullPipelineQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,77,79,195,48,12,61,111,210,254,131,213,93,64,66,205,125,116,61,108,12,180,3,104,104,251,3,89,235,110,145,242,81,156,4,169,66,252,119,210,100,29,131,33,14,141,234,103,191,231,23,199,154,43,180,45,175,16,118,72,196,173,105,92,190,52,186,17,7,79,220,9,163,39,227,143,201,120,228,173,208,7,216,118,214,161,10,121,41,177,234,147,54,127,66,141,36,170,251,115,205,210,16,230,15,139,0,4,104,74,120,8,101,176,214,14,169,9,93,102,176,126,244,82,110,68,139,82,104,124,245,72,221,194,11,89,35,69,2,99,12,10,235,149,226,212,149,167,120,67,230,93,212,104,65,161,59,154,26,156,129,183,158,7,251,68,132,198,132,47,168,66,123,146,205,7,37,118,33,213,250,189,20,21,136,193,202,127,78,70,225,206,225,60,251,127,142,157,237,12,54,81,36,37,127,123,141,64,148,176,224,142,152,76,246,86,174,189,36,164,229,196,21,232,240,2,243,172,138,51,183,89,185,11,204,83,144,23,44,150,252,205,176,213,17,21,127,9,255,89,217,159,96,154,216,54,225,215,92,66,231,73,219,178,176,24,58,16,54,243,108,139,253,59,102,172,44,216,144,237,203,19,156,174,18,231,114,179,94,105,175,144,248,94,98,113,57,181,149,118,194,117,105,95,202,193,246,29,88,71,253,42,124,59,188,77,235,48,154,162,174,211,72,99,252,153,150,228,7,24,176,47,244,136,120,76,148,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72be6cd2-93c1-4725-9a00-7c556867169a"));
		}

		#endregion

	}

	#endregion

}

