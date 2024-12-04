namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberDigitExpressionConverterSchema

	/// <exclude/>
	public class NumberDigitExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberDigitExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberDigitExpressionConverterSchema(NumberDigitExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f1dacd9b-b93b-430e-89f3-3ee26a40f8d8");
			Name = "NumberDigitExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,111,219,48,12,61,187,64,255,3,231,92,108,32,80,118,238,218,12,69,150,5,57,172,43,144,220,134,29,20,155,113,52,88,146,161,143,110,217,208,255,62,74,178,189,230,3,216,33,118,244,200,247,72,62,209,138,75,180,29,175,16,182,104,12,183,122,239,216,66,171,189,104,188,225,78,104,117,123,243,231,246,38,243,86,168,6,54,71,235,80,126,56,59,179,85,171,119,188,21,191,99,254,69,116,123,48,200,107,2,40,66,177,137,193,134,210,96,209,114,107,239,224,201,203,29,154,79,162,17,110,249,171,51,104,45,5,169,129,23,52,14,77,100,204,102,51,184,183,94,74,110,142,243,254,156,104,80,7,30,224,72,132,106,96,66,21,244,217,64,159,189,225,127,187,82,232,209,57,35,118,222,97,145,191,233,40,47,191,83,126,231,119,173,168,146,224,127,250,133,59,88,95,131,73,133,92,164,231,56,254,23,116,7,93,147,1,207,81,61,5,207,39,141,192,6,59,78,87,129,22,136,225,45,87,181,133,159,194,29,64,37,15,26,163,125,7,54,101,105,19,70,190,156,57,33,33,69,130,162,43,127,200,95,120,235,49,159,247,70,198,19,187,159,197,140,235,4,110,26,47,81,57,155,207,225,177,174,69,184,108,222,194,8,95,178,13,58,111,148,157,15,62,212,67,151,225,31,249,77,59,50,212,29,82,3,183,247,187,207,88,134,20,162,20,122,247,3,43,151,24,211,33,58,86,135,7,200,33,47,33,44,107,150,213,88,9,73,205,209,59,236,99,150,137,61,20,239,122,148,109,205,241,153,27,139,69,145,84,202,94,83,123,23,24,229,160,146,165,174,250,90,108,41,59,119,76,114,175,241,153,188,251,172,141,228,110,173,246,26,232,179,161,62,206,97,182,66,122,91,199,85,133,69,250,26,216,194,27,67,109,159,158,22,190,165,122,88,178,69,171,21,22,37,240,97,223,254,137,165,250,84,136,165,200,42,220,126,191,34,218,80,245,190,217,181,125,242,109,251,213,196,166,139,209,166,18,62,6,159,104,79,71,40,41,246,163,210,248,108,171,55,81,163,200,39,147,201,244,244,247,158,157,97,249,52,76,93,146,167,66,22,101,212,34,115,226,166,163,170,211,178,199,115,66,79,193,215,191,197,217,131,237,126,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f1dacd9b-b93b-430e-89f3-3ee26a40f8d8"));
		}

		#endregion

	}

	#endregion

}

