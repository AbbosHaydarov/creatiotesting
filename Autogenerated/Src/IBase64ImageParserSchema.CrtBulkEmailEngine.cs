namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBase64ImageParserSchema

	/// <exclude/>
	public class IBase64ImageParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBase64ImageParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBase64ImageParserSchema(IBase64ImageParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d22fb757-667d-4ac9-b5bd-1e09eb515bb0");
			Name = "IBase64ImageParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,193,74,195,64,16,61,183,208,127,24,210,139,130,36,23,241,160,109,14,138,96,192,130,212,254,192,26,103,227,194,102,55,204,236,90,138,244,223,157,36,77,9,180,160,232,105,217,97,222,155,247,222,236,58,85,35,55,170,68,216,32,145,98,175,67,250,224,157,54,85,36,21,140,119,233,74,25,107,92,53,155,126,205,166,147,57,97,37,69,40,92,64,210,2,187,133,226,94,49,222,92,23,181,170,240,69,17,35,205,166,210,153,101,25,44,56,214,181,162,93,126,184,175,177,33,100,116,129,193,12,4,160,61,65,35,56,153,1,79,155,213,115,71,244,104,177,150,62,96,31,73,122,164,219,195,145,20,17,74,66,189,76,126,144,156,142,148,37,89,158,14,4,217,72,86,19,223,172,41,71,114,206,217,153,180,214,79,28,117,5,25,252,137,36,134,194,7,2,7,106,93,208,96,179,83,3,94,131,114,96,90,66,153,3,170,53,242,127,39,167,86,250,138,68,169,106,112,178,214,101,194,84,38,249,107,31,225,88,133,132,89,246,186,211,69,214,1,206,227,187,238,36,47,28,7,229,122,142,214,230,159,117,131,209,71,243,195,202,183,138,129,99,89,34,179,142,246,10,188,76,160,173,97,4,23,173,61,213,71,24,34,57,206,215,253,9,129,162,196,170,127,193,167,149,101,20,194,129,161,165,124,243,222,194,134,118,221,166,47,14,251,147,216,4,23,3,140,212,247,201,93,222,9,104,223,189,239,57,186,247,254,51,180,215,253,55,162,142,52,117,72,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d22fb757-667d-4ac9-b5bd-1e09eb515bb0"));
		}

		#endregion

	}

	#endregion

}

