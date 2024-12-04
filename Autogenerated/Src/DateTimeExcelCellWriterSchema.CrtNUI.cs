namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExcelCellWriterSchema

	/// <exclude/>
	public class DateTimeExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExcelCellWriterSchema(DateTimeExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2cb26043-42ca-4c84-9e87-fb66c4e44a45");
			Name = "DateTimeExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,205,78,195,48,16,132,207,137,212,119,88,169,23,184,36,119,40,149,80,40,156,144,42,17,193,217,196,219,212,200,177,163,245,186,180,66,125,119,236,252,81,17,193,193,135,29,205,120,62,175,141,104,208,181,162,66,40,145,72,56,187,227,172,176,102,167,106,79,130,149,53,217,230,216,90,226,210,110,142,21,234,69,250,181,72,19,239,148,169,225,229,228,24,155,219,69,26,148,37,97,29,204,80,104,225,220,13,60,8,198,82,53,216,101,10,212,250,141,20,35,117,214,60,207,97,229,124,211,8,58,173,135,121,244,3,198,0,132,163,225,179,139,100,99,34,191,136,180,254,93,171,10,170,88,246,87,23,244,20,51,130,36,62,96,226,221,146,109,145,88,97,128,222,118,183,118,140,177,114,165,204,30,67,72,218,10,242,216,58,214,218,67,216,148,146,8,211,221,143,150,26,193,179,249,110,253,91,202,70,216,126,107,201,18,141,236,73,134,121,192,122,70,222,91,25,153,200,50,86,140,242,63,172,209,243,67,54,237,243,9,249,94,126,248,240,81,114,212,94,133,246,120,53,57,14,113,188,134,110,43,9,33,123,50,189,22,16,147,228,60,231,28,180,75,233,252,13,231,246,167,225,70,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2cb26043-42ca-4c84-9e87-fb66c4e44a45"));
		}

		#endregion

	}

	#endregion

}

