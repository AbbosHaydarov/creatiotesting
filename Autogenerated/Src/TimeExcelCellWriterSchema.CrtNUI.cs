namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeExcelCellWriterSchema

	/// <exclude/>
	public class TimeExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeExcelCellWriterSchema(TimeExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b9f4301-da1a-457b-8c99-61b188d2ca09");
			Name = "TimeExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,193,110,194,48,12,134,207,65,226,29,44,113,129,75,123,103,12,9,1,219,105,26,210,208,118,206,26,23,50,165,73,229,58,12,52,241,238,75,66,219,77,3,237,144,131,127,125,137,63,59,86,86,216,212,178,64,216,34,145,108,92,201,217,210,217,82,239,60,73,214,206,102,235,99,237,136,183,110,125,44,208,12,7,95,195,129,240,141,182,59,120,57,53,140,213,221,112,16,146,17,225,46,192,176,52,178,105,166,176,213,21,38,126,137,198,188,145,102,164,132,229,121,14,179,198,87,149,164,211,188,173,35,11,24,97,8,199,192,103,194,179,142,206,59,92,132,164,246,239,70,23,80,196,46,183,154,192,20,86,146,175,91,139,104,221,75,110,200,213,72,172,49,152,110,210,139,73,46,246,155,105,187,199,112,73,185,2,242,104,216,181,116,135,176,30,173,16,250,183,31,28,85,146,175,234,251,249,223,40,139,162,151,53,137,17,90,117,177,104,235,86,233,9,121,239,84,244,33,199,88,48,170,255,148,58,230,199,42,78,157,22,249,136,188,80,31,62,252,140,234,178,87,105,60,142,123,226,16,203,9,164,141,8,66,246,100,65,97,41,189,225,30,154,100,11,165,198,137,76,246,207,229,74,158,38,97,6,33,206,215,131,180,217,239,232,252,13,55,223,181,179,88,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b9f4301-da1a-457b-8c99-61b188d2ca09"));
		}

		#endregion

	}

	#endregion

}

