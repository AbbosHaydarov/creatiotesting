namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordDeleterWithStopProcessSchema

	/// <exclude/>
	public class RecordDeleterWithStopProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordDeleterWithStopProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordDeleterWithStopProcessSchema(RecordDeleterWithStopProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0257476-0351-4841-902a-f92f292b905b");
			Name = "RecordDeleterWithStopProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,219,78,235,48,16,124,54,18,255,96,137,151,34,161,124,192,57,136,7,218,10,29,9,68,197,69,60,34,215,89,90,163,212,206,89,111,42,34,212,127,103,109,199,148,4,82,222,124,25,207,238,204,142,173,218,128,175,149,6,249,0,136,202,187,23,42,166,206,190,152,85,131,138,140,179,242,253,248,72,52,222,216,149,188,111,61,193,230,239,96,207,240,170,2,29,176,190,184,2,11,104,244,65,204,237,242,149,151,55,174,132,106,143,251,90,29,97,236,188,152,91,50,100,192,143,2,102,151,163,87,11,116,26,252,200,211,205,198,217,111,93,95,27,251,127,148,174,231,18,163,24,119,130,176,10,150,77,43,229,253,31,121,7,218,97,57,131,10,8,240,201,208,250,158,92,221,117,17,241,117,179,172,140,150,58,192,15,162,229,128,44,12,133,223,239,11,178,175,132,141,38,135,92,119,17,105,19,162,43,113,136,124,242,232,1,153,193,166,1,201,166,183,61,11,44,66,252,155,153,184,85,216,158,115,41,246,227,76,186,56,200,11,89,43,228,20,49,177,63,229,70,151,202,195,100,192,209,131,132,64,137,93,39,0,108,153,52,244,5,221,0,173,93,25,180,160,217,42,130,112,23,229,164,173,220,58,83,202,36,39,168,153,42,171,161,154,191,129,110,66,189,44,108,159,186,243,238,232,218,240,96,57,162,220,116,255,32,247,37,58,224,220,174,140,133,71,50,85,204,91,145,42,44,20,130,165,76,255,252,77,229,144,51,132,71,136,224,72,145,154,189,173,33,5,102,146,238,118,89,216,239,70,116,67,205,62,56,226,170,80,74,183,229,88,154,178,103,201,151,42,157,42,194,182,91,29,234,70,236,164,86,164,215,114,18,255,89,203,193,40,47,219,236,200,155,134,58,6,4,242,42,179,139,95,39,241,249,36,255,194,161,71,209,136,31,66,17,229,166,243,222,241,241,209,238,3,106,64,223,238,187,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0257476-0351-4841-902a-f92f292b905b"));
		}

		#endregion

	}

	#endregion

}

