namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationServiceResponseSchema

	/// <exclude/>
	public class TranslationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationServiceResponseSchema(TranslationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fe50c86-213a-4ba1-9a12-4686b15dab3c");
			Name = "TranslationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2c48a34f-0c95-44d9-a69e-4bfc769a17b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,146,77,111,194,48,12,134,207,69,226,63,68,112,129,75,127,0,251,184,48,152,38,141,105,2,110,211,52,165,193,116,145,210,164,114,18,246,165,253,247,185,13,160,182,12,84,196,165,106,28,251,245,227,55,214,60,3,155,115,1,108,9,136,220,154,181,139,199,70,175,101,234,145,59,105,116,188,68,174,173,42,255,187,157,159,110,39,242,86,234,148,45,190,172,131,236,170,113,166,90,165,64,20,201,54,190,7,13,40,197,65,206,220,107,39,51,136,23,116,203,149,252,46,181,41,139,242,250,8,41,29,216,88,113,107,71,172,210,155,146,55,82,192,156,104,73,27,202,236,151,59,238,56,209,58,228,194,189,82,32,247,137,146,130,137,162,250,68,49,27,177,218,140,7,218,17,205,73,223,61,206,84,130,90,17,207,51,202,13,119,161,121,232,62,131,44,1,28,60,145,141,236,134,245,76,14,65,242,209,164,189,97,129,20,229,161,134,61,76,180,207,232,54,81,112,109,29,146,31,183,236,173,154,31,28,136,250,160,87,161,109,157,129,136,169,204,11,103,176,73,178,107,113,124,226,193,144,21,79,23,253,182,46,152,124,10,200,139,11,6,67,242,43,225,20,131,179,85,254,27,186,58,243,86,48,170,25,65,70,54,124,217,183,60,102,206,12,220,187,41,95,168,220,128,45,95,216,6,235,72,73,156,90,135,49,2,205,177,240,66,128,181,20,245,202,237,12,139,16,156,71,205,52,124,156,180,183,10,121,81,223,182,142,97,43,174,90,229,5,140,83,46,149,199,34,90,48,214,118,227,28,28,168,49,52,30,51,68,235,65,138,253,1,217,60,246,192,162,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fe50c86-213a-4ba1-9a12-4686b15dab3c"));
		}

		#endregion

	}

	#endregion

}

