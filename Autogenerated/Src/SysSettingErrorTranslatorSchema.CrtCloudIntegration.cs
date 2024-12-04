namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingErrorTranslatorSchema

	/// <exclude/>
	public class SysSettingErrorTranslatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingErrorTranslatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingErrorTranslatorSchema(SysSettingErrorTranslatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1fd68ecf-fbcc-4ad5-92f1-9d2e6b350bf8");
			Name = "SysSettingErrorTranslator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,65,110,194,48,16,69,215,142,196,29,44,232,34,72,81,14,0,234,166,161,69,72,44,42,1,237,50,50,206,20,89,117,237,104,60,65,2,196,221,235,196,64,74,128,46,61,254,51,255,125,143,141,248,1,87,10,9,60,67,202,180,173,138,153,33,216,160,32,101,77,186,34,165,21,41,112,189,232,208,139,88,229,148,217,220,21,78,200,142,255,21,92,38,165,175,136,22,93,171,94,2,162,112,246,139,210,204,34,248,186,191,25,32,108,124,23,207,180,112,110,196,23,59,183,0,34,175,110,154,151,40,140,211,130,44,54,226,178,90,107,37,185,172,181,143,165,35,254,34,28,116,138,9,159,221,76,100,117,210,11,193,155,2,93,120,132,119,84,91,65,208,24,178,50,28,56,130,40,172,209,187,174,43,207,125,38,139,227,187,218,149,3,204,172,49,32,235,135,225,121,117,117,14,249,217,0,76,17,8,78,142,33,227,195,116,113,151,160,1,72,186,102,215,94,67,222,68,101,129,150,63,243,150,154,117,176,252,229,13,39,99,199,43,184,79,88,47,172,252,6,242,159,129,159,209,32,62,187,108,5,242,2,156,68,85,214,3,230,114,239,135,62,245,91,240,252,16,64,210,182,52,69,91,149,199,153,217,10,173,138,15,161,43,200,39,237,136,126,64,69,160,10,253,95,241,47,76,97,193,30,32,158,2,205,173,244,125,123,177,214,208,244,198,141,252,38,91,114,90,215,31,223,204,22,144,116,104,135,195,115,230,83,238,118,71,209,49,250,5,190,194,160,152,72,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1fd68ecf-fbcc-4ad5-92f1-9d2e6b350bf8"));
		}

		#endregion

	}

	#endregion

}

