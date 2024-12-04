namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateGroupModelSchema

	/// <exclude/>
	public class DCTemplateGroupModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateGroupModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateGroupModelSchema(DCTemplateGroupModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a31f9786-6cb9-4933-9916-2eea05b45be7");
			Name = "DCTemplateGroupModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,193,78,227,48,16,61,23,137,127,24,202,5,164,85,114,167,164,28,90,9,245,0,139,180,240,1,198,158,52,70,137,237,181,39,91,34,180,255,206,216,105,218,210,109,119,187,61,196,245,139,103,222,155,153,231,24,209,96,112,66,34,60,163,247,34,216,146,178,153,53,165,94,182,94,144,182,38,155,119,70,52,90,50,72,104,40,123,176,10,235,112,126,246,113,126,54,106,131,54,75,248,209,5,194,102,178,217,159,152,104,46,72,196,255,94,72,226,96,14,191,244,184,228,131,48,171,69,8,55,48,159,61,99,227,106,65,120,239,109,235,18,113,58,151,231,57,220,134,182,105,132,239,166,235,125,138,1,178,224,209,121,12,76,0,138,9,160,137,81,80,90,207,17,136,32,61,150,197,120,47,243,56,159,2,7,104,234,178,33,123,190,147,222,181,175,181,150,32,19,195,97,81,35,238,6,63,55,21,60,121,235,208,147,70,46,227,41,133,247,239,247,149,39,224,197,232,159,45,130,86,81,67,169,209,71,21,127,202,24,116,220,183,90,193,66,193,7,44,145,38,16,226,227,55,20,9,207,30,113,21,215,171,235,201,255,16,130,45,129,214,101,237,116,226,31,26,182,173,216,87,115,2,183,81,248,14,43,77,149,54,64,21,110,232,255,206,171,121,172,139,20,122,128,239,18,141,234,251,255,117,24,15,72,149,85,167,76,226,251,47,182,46,183,37,0,190,59,62,170,9,164,53,12,82,244,53,155,235,184,135,6,39,71,47,81,231,182,117,204,250,4,1,76,91,215,49,71,92,143,84,153,16,39,188,104,128,175,10,22,227,228,222,241,116,96,90,187,217,190,190,161,36,88,85,90,86,131,64,84,217,109,158,66,119,251,21,136,175,158,220,86,19,93,41,136,47,195,17,245,87,135,236,221,179,94,67,145,50,143,122,13,23,69,42,36,33,163,59,48,184,58,150,19,226,151,34,254,216,37,69,159,43,91,168,111,3,152,166,185,193,227,174,127,195,67,141,203,77,162,89,187,121,111,194,253,220,191,130,140,125,2,97,179,231,173,211,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a31f9786-6cb9-4933-9916-2eea05b45be7"));
		}

		#endregion

	}

	#endregion

}

