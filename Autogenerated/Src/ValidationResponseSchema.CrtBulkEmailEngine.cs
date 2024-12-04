namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationResponseSchema

	/// <exclude/>
	public class ValidationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationResponseSchema(ValidationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d");
			Name = "ValidationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,205,110,194,48,16,132,207,68,202,59,172,196,157,220,219,170,23,174,28,16,160,222,157,205,198,88,117,236,104,215,70,2,196,187,215,118,160,84,173,168,184,88,235,159,153,111,60,78,13,36,163,66,130,29,49,43,241,125,88,44,189,235,141,142,172,130,241,174,174,206,117,85,87,179,166,105,224,77,226,48,40,62,190,95,247,27,26,153,132,92,16,8,123,130,52,71,27,192,247,128,123,194,79,227,52,28,148,53,93,241,1,142,150,22,55,163,230,135,211,24,91,107,16,208,42,17,248,248,22,108,82,46,239,132,210,139,41,193,108,206,164,179,211,154,253,72,28,12,201,11,172,139,120,186,255,29,241,154,49,135,202,224,191,228,27,186,245,222,194,54,34,82,74,112,6,77,225,21,36,47,151,127,140,87,30,83,214,147,106,45,65,234,80,148,38,64,223,149,63,62,70,73,224,220,203,10,79,219,50,45,147,226,105,228,189,156,66,122,6,116,151,60,34,205,201,117,83,177,101,159,78,47,117,245,5,103,204,120,153,23,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d"));
		}

		#endregion

	}

	#endregion

}

