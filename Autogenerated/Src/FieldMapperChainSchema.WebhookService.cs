namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FieldMapperChainSchema

	/// <exclude/>
	public class FieldMapperChainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FieldMapperChainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FieldMapperChainSchema(FieldMapperChainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78eea549-96b0-4d4a-9003-79a704dc0682");
			Name = "FieldMapperChain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,77,107,220,48,16,61,59,144,255,48,36,23,7,194,250,158,102,125,89,154,80,72,74,32,133,30,139,214,30,175,69,109,201,29,73,27,150,146,255,222,177,71,107,188,107,39,245,193,178,103,222,204,155,143,39,163,90,116,157,42,16,126,32,145,114,182,242,171,141,53,149,222,5,82,94,91,115,121,241,247,242,34,9,78,155,29,188,30,156,199,150,253,77,131,69,239,116,171,71,52,72,186,248,114,142,121,210,230,15,27,217,124,77,184,99,40,108,26,229,220,29,60,104,108,202,103,213,117,72,155,90,105,51,96,178,44,131,123,109,106,78,229,75,91,64,65,88,173,175,190,157,99,175,178,156,193,93,216,54,154,49,125,190,89,58,184,131,89,24,199,112,15,252,30,107,25,16,92,204,11,233,189,242,40,206,78,126,78,226,31,84,225,45,29,224,87,53,179,73,119,201,53,154,82,178,158,82,188,144,101,172,215,216,211,12,21,139,127,104,213,133,182,85,116,200,143,134,71,244,14,44,129,235,79,95,35,12,116,208,14,124,80,9,225,106,12,207,166,241,113,28,75,85,47,152,250,101,38,201,14,125,252,74,116,5,233,66,119,176,94,131,9,77,115,115,196,37,132,62,144,89,154,4,48,20,223,22,216,210,155,94,23,252,188,203,241,113,10,193,9,140,135,0,235,252,3,162,189,106,2,14,232,247,207,231,255,140,190,182,229,210,240,255,175,51,86,181,31,126,75,17,138,232,110,156,244,87,19,90,36,181,109,240,254,39,110,107,107,127,243,141,8,173,225,144,28,206,66,211,41,218,121,226,43,146,195,155,68,9,226,22,196,124,180,190,218,64,5,222,202,40,196,131,198,107,127,248,206,87,245,184,142,189,34,81,71,164,137,43,120,210,206,207,107,58,174,97,90,202,180,231,60,10,173,207,50,95,226,56,12,114,233,105,137,211,186,132,161,178,132,170,168,33,157,166,23,49,199,111,190,161,145,108,84,214,196,189,226,35,206,237,108,70,211,102,35,153,168,37,106,106,234,255,68,30,98,61,53,178,237,31,114,201,32,23,6,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78eea549-96b0-4d4a-9003-79a704dc0682"));
		}

		#endregion

	}

	#endregion

}

