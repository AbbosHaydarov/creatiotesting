namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BooleanTypeWebhookHandlerSchema

	/// <exclude/>
	public class BooleanTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BooleanTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BooleanTypeWebhookHandlerSchema(BooleanTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f16699b7-b1d3-41a0-8e54-4983dfa47e58");
			Name = "BooleanTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7950703-7230-445f-b3e5-fcd99a7a2e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,193,110,219,48,12,61,187,64,255,129,112,47,49,80,216,247,52,49,176,102,40,218,67,135,0,13,176,195,176,131,98,211,169,55,89,50,40,41,131,49,236,223,71,201,114,154,118,117,177,139,96,147,143,239,145,143,146,18,29,154,94,84,8,59,36,18,70,55,54,223,104,213,180,7,71,194,182,90,93,94,252,190,188,72,156,105,213,1,158,6,99,177,187,57,253,159,151,16,230,119,162,178,154,90,52,140,96,204,21,225,129,9,96,35,133,49,75,184,213,90,162,80,187,161,199,175,184,127,214,250,231,189,80,181,68,10,224,162,40,96,101,92,215,9,26,202,248,31,97,16,113,208,104,98,12,34,84,132,205,58,221,51,97,90,148,96,153,113,98,40,222,80,120,184,144,70,199,146,153,25,243,135,141,51,86,119,255,246,150,66,225,169,190,125,198,70,56,105,111,91,85,243,224,11,47,169,155,197,108,89,118,13,95,216,88,88,67,58,59,118,154,125,103,230,222,237,101,91,65,229,61,154,183,8,150,48,171,197,36,188,33,62,79,134,111,73,247,72,150,23,177,132,109,224,31,243,111,61,14,1,6,31,219,154,37,20,55,156,159,96,231,70,78,77,26,75,126,235,83,197,56,97,57,173,233,73,59,170,144,125,53,86,40,107,242,79,106,184,249,64,55,116,239,233,188,151,31,235,250,153,199,131,213,162,245,126,249,89,228,191,66,85,143,163,191,246,225,17,237,179,174,255,199,132,83,51,191,226,149,235,5,241,116,150,109,57,10,233,230,250,11,145,0,13,238,173,211,86,245,206,166,101,52,234,232,75,65,55,239,176,250,171,60,137,230,171,34,36,94,40,9,173,35,101,202,85,49,125,157,185,161,247,63,176,178,241,81,44,162,84,16,206,192,63,213,36,105,27,8,254,228,59,26,182,130,12,46,66,250,26,180,179,224,19,64,104,248,54,103,83,65,50,202,196,176,127,223,73,242,39,156,49,161,156,148,33,204,209,119,28,31,163,175,131,28,251,11,182,80,74,211,92,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f16699b7-b1d3-41a0-8e54-4983dfa47e58"));
		}

		#endregion

	}

	#endregion

}

