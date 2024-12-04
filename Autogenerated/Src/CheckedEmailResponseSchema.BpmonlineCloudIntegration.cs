namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailResponseSchema

	/// <exclude/>
	public class CheckedEmailResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailResponseSchema(CheckedEmailResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3507f4f-1914-4114-8a7c-cc67545f380a");
			Name = "CheckedEmailResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,79,79,2,49,16,197,207,144,240,29,38,120,209,203,238,93,144,203,74,136,7,12,1,111,198,67,41,195,210,216,63,155,153,246,128,196,239,238,116,23,20,145,120,105,211,55,239,205,252,218,122,229,144,27,165,17,94,144,72,113,216,198,162,10,126,107,234,68,42,154,224,139,106,186,90,138,37,120,70,30,244,15,131,126,47,177,241,53,172,246,28,209,137,217,90,212,217,201,197,12,61,146,209,163,75,207,50,249,104,28,22,43,169,42,107,62,218,198,63,174,127,38,207,195,6,45,139,85,204,55,132,181,200,80,89,197,124,15,213,14,245,59,110,166,78,25,123,2,108,125,101,89,194,152,147,115,138,246,147,227,121,137,13,33,163,143,12,113,135,160,187,44,96,14,3,29,211,176,165,224,64,166,22,167,46,229,89,155,215,71,21,149,0,70,82,58,190,137,208,164,181,53,26,116,198,129,235,52,61,121,46,89,191,209,23,20,26,164,104,80,248,23,109,188,171,95,34,183,194,12,133,54,16,112,222,51,181,112,38,27,51,220,95,186,14,111,142,110,141,116,251,44,159,10,15,48,236,2,195,187,76,123,194,125,154,250,228,144,212,218,226,248,28,122,34,111,148,221,112,128,26,227,40,79,29,193,231,17,31,253,166,187,65,123,238,212,223,162,104,95,178,189,32,218,75,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3507f4f-1914-4114-8a7c-cc67545f380a"));
		}

		#endregion

	}

	#endregion

}

