namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordProcessedEventArgsSchema

	/// <exclude/>
	public class RecordProcessedEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordProcessedEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordProcessedEventArgsSchema(RecordProcessedEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55febf69-27f8-44d0-b988-9700d6626862");
			Name = "RecordProcessedEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,221,106,195,48,12,133,175,27,200,59,8,122,223,220,183,99,48,74,25,189,43,251,121,0,207,86,50,65,108,103,146,93,86,202,222,125,182,211,46,221,95,111,140,124,44,159,243,73,78,89,148,65,105,132,39,100,86,226,219,176,88,123,215,82,23,89,5,242,14,142,117,53,139,66,174,131,199,131,4,180,171,186,74,202,156,177,203,175,235,94,137,44,225,1,181,103,179,99,175,81,4,205,102,143,46,220,113,39,165,183,105,26,184,145,104,173,226,195,237,233,158,90,247,100,80,64,25,67,57,71,245,64,174,245,108,199,212,84,65,120,197,159,198,128,217,121,113,54,109,46,92,135,248,210,147,6,157,129,254,229,129,37,76,117,158,236,107,144,212,59,32,7,194,52,205,174,88,21,246,95,240,179,44,108,222,53,14,133,211,183,192,37,11,134,49,44,45,42,227,149,182,111,124,103,192,233,239,84,29,161,195,176,2,201,199,199,149,220,103,71,111,17,33,45,206,5,106,9,89,38,128,235,169,247,145,204,105,43,91,243,87,222,28,157,25,87,145,110,163,118,41,213,85,210,62,1,138,144,1,183,45,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55febf69-27f8-44d0-b988-9700d6626862"));
		}

		#endregion

	}

	#endregion

}

