namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateContractResponseSchema

	/// <exclude/>
	public class DCTemplateContractResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateContractResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateContractResponseSchema(DCTemplateContractResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3fd21c44-491c-46a0-85b5-eea55b81914b");
			Name = "DCTemplateContractResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,203,110,194,48,16,60,23,169,255,176,162,135,222,146,59,180,92,224,90,9,1,183,170,135,197,108,130,171,216,142,236,117,171,20,241,239,93,231,37,40,106,213,139,21,143,103,103,103,38,22,13,133,26,21,193,142,188,199,224,10,206,150,206,22,186,140,30,89,59,155,173,26,139,70,43,1,153,44,223,79,78,247,147,187,24,180,45,97,219,4,38,147,109,162,101,109,40,219,146,215,88,233,175,118,108,62,178,254,167,155,173,144,49,125,123,84,44,195,50,254,224,169,20,34,44,43,12,97,6,171,229,142,76,93,33,211,64,219,136,115,103,3,181,236,60,207,225,41,68,99,208,55,139,254,62,16,64,37,9,248,60,106,117,4,37,211,168,109,16,54,201,139,167,226,121,122,171,61,205,23,208,171,160,61,64,17,173,74,174,37,31,55,224,10,224,35,93,10,92,69,147,34,62,180,162,97,187,72,101,163,33,142,94,86,115,191,237,49,128,182,133,243,166,171,100,136,145,95,228,120,189,44,230,77,128,58,238,43,173,250,72,191,151,2,51,248,203,148,8,201,143,148,115,172,121,237,93,77,158,53,73,215,235,118,71,247,254,179,216,22,24,182,182,109,166,181,224,246,239,164,56,69,184,205,208,133,120,33,179,39,159,34,12,25,110,221,143,194,35,112,130,146,120,14,33,29,231,222,49,217,67,103,186,189,119,232,53,120,254,6,184,140,116,172,216,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fd21c44-491c-46a0-85b5-eea55b81914b"));
		}

		#endregion

	}

	#endregion

}

