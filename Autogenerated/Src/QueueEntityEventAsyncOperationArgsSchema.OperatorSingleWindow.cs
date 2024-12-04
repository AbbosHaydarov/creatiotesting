namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueueEntityEventAsyncOperationArgsSchema

	/// <exclude/>
	public class QueueEntityEventAsyncOperationArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueueEntityEventAsyncOperationArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueueEntityEventAsyncOperationArgsSchema(QueueEntityEventAsyncOperationArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ee00480-4744-4349-9314-bc0a08994574");
			Name = "QueueEntityEventAsyncOperationArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("64ebcdcc-1a9c-4eb3-9403-16c8221d18f7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,109,107,194,48,16,199,95,87,240,59,28,238,141,131,209,190,87,39,136,136,8,131,57,182,47,16,227,181,11,180,169,228,146,129,12,191,251,46,137,15,173,99,86,246,162,15,73,255,119,247,187,255,165,90,84,72,59,33,17,62,208,24,65,117,110,211,121,173,115,85,56,35,172,170,117,191,247,221,239,37,142,148,46,224,125,79,22,171,241,213,154,245,101,137,210,139,41,93,162,70,163,228,69,211,76,107,48,93,104,171,172,66,234,20,164,51,218,107,249,186,195,136,225,3,56,228,193,96,193,43,152,151,130,104,4,111,14,29,134,136,253,226,11,181,109,199,204,76,65,33,42,203,50,152,144,171,42,97,246,211,227,58,100,0,131,59,131,196,145,196,2,68,144,6,243,231,193,205,140,131,108,10,74,127,114,151,182,54,144,243,229,8,121,167,153,32,112,173,216,27,10,73,94,20,251,196,190,112,104,122,194,201,26,60,59,183,41,149,4,25,144,186,123,130,17,116,244,156,240,204,248,126,177,139,13,180,198,73,38,102,215,214,161,92,84,28,75,119,23,29,198,175,128,225,241,4,81,230,105,240,244,246,200,96,27,65,56,60,105,26,95,252,33,74,14,71,42,212,219,8,214,166,92,155,154,43,250,225,183,25,175,199,119,220,104,187,29,199,66,86,104,62,203,242,124,34,189,223,191,13,63,181,189,90,104,87,113,147,155,18,39,177,191,105,180,130,34,112,82,160,29,3,241,237,140,127,15,80,76,213,34,18,119,208,240,136,252,15,49,11,210,63,1,254,85,222,27,27,70,9,106,235,167,147,43,52,183,97,150,78,109,225,124,2,86,219,27,60,87,243,140,187,237,205,195,15,147,112,236,157,104,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ee00480-4744-4349-9314-bc0a08994574"));
		}

		#endregion

	}

	#endregion

}

