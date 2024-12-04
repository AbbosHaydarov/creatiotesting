namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenericErrorTranslatorSchema

	/// <exclude/>
	public class GenericErrorTranslatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenericErrorTranslatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenericErrorTranslatorSchema(GenericErrorTranslatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aca0b116-a4c6-4063-89a7-9a142e9ebd4e");
			Name = "GenericErrorTranslator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,193,74,3,49,16,134,207,89,232,59,4,122,217,66,217,7,168,120,113,171,165,7,65,80,241,40,105,118,88,131,49,89,38,179,130,72,223,221,201,78,91,92,91,247,146,144,201,207,255,205,63,19,204,7,164,206,88,208,53,82,237,99,223,108,3,65,139,134,92,12,213,51,57,239,200,65,154,21,223,179,66,245,201,133,246,162,112,77,241,106,82,112,114,170,110,17,35,38,86,179,126,142,208,242,175,174,189,73,105,165,55,16,0,157,29,20,79,104,66,242,134,34,14,202,174,223,121,103,181,205,194,127,116,43,125,99,18,252,41,46,245,246,204,78,113,22,62,79,244,59,7,190,97,252,3,186,79,67,32,159,157,60,52,130,105,98,240,95,35,168,126,133,124,73,8,53,135,208,136,213,216,183,142,33,81,111,153,153,205,135,0,7,111,9,115,57,70,185,249,13,26,56,11,157,167,175,148,80,245,181,84,243,192,213,126,186,133,123,160,183,56,100,59,199,191,192,238,49,218,119,32,94,158,62,242,161,60,194,16,168,71,14,193,3,32,153,42,235,74,105,161,90,67,178,232,186,188,218,229,97,24,178,216,58,54,176,152,232,76,170,227,226,190,248,1,161,65,32,9,134,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aca0b116-a4c6-4063-89a7-9a142e9ebd4e"));
		}

		#endregion

	}

	#endregion

}

