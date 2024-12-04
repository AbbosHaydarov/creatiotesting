namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HeaderExcelCellWriterSchema

	/// <exclude/>
	public class HeaderExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HeaderExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HeaderExcelCellWriterSchema(HeaderExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("881c36f8-3731-4978-a3c3-2634f94cdae3");
			Name = "HeaderExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,80,77,171,194,48,16,60,91,232,127,88,240,222,220,125,234,165,248,240,40,40,120,142,233,218,23,72,179,101,147,62,21,241,191,187,77,85,252,130,236,194,236,206,236,12,241,186,193,208,106,131,176,65,102,29,104,31,139,146,252,222,214,29,235,104,201,23,139,99,75,28,55,180,56,26,116,121,118,206,179,145,188,49,99,45,91,40,157,14,97,2,75,212,21,114,162,148,232,220,150,109,68,206,51,33,42,165,96,26,186,166,209,124,154,223,240,192,6,236,233,32,229,224,144,4,197,157,175,158,4,109,183,115,214,128,233,141,190,251,192,4,214,145,173,175,63,252,71,146,86,250,35,237,138,169,69,142,22,37,242,42,221,29,246,98,58,181,254,15,69,86,145,1,213,251,222,141,233,95,62,198,86,8,143,235,191,196,141,142,31,120,54,127,31,21,67,220,159,91,8,244,213,144,35,225,75,234,175,195,203,21,71,10,163,48,143,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("881c36f8-3731-4978-a3c3-2634f94cdae3"));
		}

		#endregion

	}

	#endregion

}

