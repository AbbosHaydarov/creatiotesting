namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailQueueJobDispatcherSchema

	/// <exclude/>
	public class BulkEmailQueueJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailQueueJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailQueueJobDispatcherSchema(BulkEmailQueueJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36fbfa11-e34f-c606-1a25-604da3e18cd6");
			Name = "BulkEmailQueueJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,77,111,26,49,16,61,19,41,255,97,164,92,18,9,237,170,87,74,145,72,74,163,173,74,149,150,84,61,84,61,152,245,0,86,188,246,118,108,131,86,85,254,123,199,251,129,22,154,210,82,14,8,102,222,27,191,121,158,177,17,5,186,82,228,8,143,72,36,156,93,249,228,206,154,149,90,7,18,94,89,115,121,241,243,242,98,16,156,50,107,88,84,206,99,193,121,173,49,143,73,151,220,163,65,82,249,235,61,166,95,134,48,89,228,27,148,65,35,189,132,248,138,75,70,21,133,53,156,229,252,21,225,154,171,194,157,22,206,141,224,54,232,167,89,33,148,254,20,48,224,123,187,124,171,88,170,231,138,84,195,211,52,133,177,11,69,33,168,154,180,255,23,72,91,116,176,100,42,96,228,194,143,72,134,157,242,27,224,86,157,88,115,122,101,169,15,17,65,42,52,236,65,73,54,103,12,171,76,186,250,105,239,128,50,44,181,202,33,143,242,78,169,3,214,46,28,158,64,12,33,155,150,229,108,139,198,127,80,108,42,155,200,245,217,105,254,222,219,240,64,182,68,242,10,217,11,254,237,217,115,148,13,164,150,166,12,87,82,94,218,60,141,234,6,101,135,1,187,101,143,149,68,200,102,38,20,72,98,169,113,124,40,103,222,120,241,88,149,56,129,169,214,118,135,178,23,115,240,166,174,57,48,184,59,106,181,135,250,246,29,226,116,240,231,143,144,100,42,229,180,245,247,182,122,167,180,231,238,207,227,88,45,145,50,121,30,43,218,250,87,198,103,44,216,42,238,190,227,253,43,227,220,134,142,105,81,93,205,121,110,38,127,112,133,70,54,215,126,56,3,115,244,27,43,255,127,0,182,86,73,232,150,144,71,240,218,121,138,75,184,179,244,84,239,253,71,126,0,134,208,70,131,67,138,129,155,246,90,121,70,247,11,188,95,229,185,50,193,163,174,184,218,248,196,136,79,174,27,83,56,120,79,54,148,205,65,71,231,118,7,14,129,39,93,89,153,153,166,58,55,252,170,53,85,185,230,217,249,194,208,17,120,10,81,110,39,106,180,239,173,187,131,66,185,149,34,204,12,183,20,234,71,106,4,253,54,230,191,229,147,5,239,183,127,176,188,218,213,77,124,166,6,207,47,222,73,19,61,12,114,236,23,74,212,88,173,66,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36fbfa11-e34f-c606-1a25-604da3e18cd6"));
		}

		#endregion

	}

	#endregion

}

