namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingErrorSchema

	/// <exclude/>
	public class SysSettingErrorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingErrorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingErrorSchema(SysSettingErrorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69961719-9444-4a29-85dd-698b7eef2210");
			Name = "SysSettingError";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,82,203,110,194,48,16,60,7,137,127,88,165,151,86,170,146,59,175,11,173,16,234,5,9,250,1,198,44,193,82,98,71,94,167,136,34,254,189,142,237,130,226,210,130,212,155,179,158,157,204,195,146,85,72,53,227,8,83,109,166,165,106,54,115,105,176,208,204,8,37,179,119,35,74,97,4,82,246,170,181,210,212,239,29,251,189,126,47,121,208,88,216,123,152,150,140,104,0,203,3,45,209,24,33,11,7,115,144,60,207,97,68,77,85,49,125,152,132,239,23,36,174,197,26,129,73,192,22,9,251,29,74,32,85,33,168,45,208,129,128,60,15,236,24,129,144,92,105,141,220,192,7,43,27,204,190,89,243,136,118,68,136,172,36,5,92,227,118,156,222,99,36,123,147,106,47,221,57,133,188,37,170,155,117,41,56,240,214,81,108,8,6,48,15,206,18,31,192,37,1,37,201,232,134,27,75,58,128,133,35,241,136,56,0,55,152,75,171,130,149,226,19,9,24,72,220,91,147,100,152,228,46,0,179,67,103,38,24,137,84,164,249,196,203,107,131,248,153,132,159,212,76,179,10,164,109,117,156,210,121,127,170,54,152,78,86,150,222,206,12,86,231,152,185,189,200,70,185,219,186,78,82,104,213,212,126,215,29,59,232,16,90,36,244,209,38,210,146,119,255,255,12,97,236,104,158,192,6,153,36,201,178,131,129,113,180,52,140,64,179,118,215,162,28,135,187,60,133,62,80,110,124,37,221,126,22,90,213,168,219,230,239,104,103,134,134,92,9,215,82,250,35,116,247,60,207,159,171,155,4,23,124,8,48,36,179,60,116,194,56,66,129,102,8,193,225,239,138,237,3,181,63,186,170,220,87,246,31,233,49,195,109,237,190,163,32,222,210,156,29,68,29,249,105,119,120,250,2,58,175,128,44,144,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69961719-9444-4a29-85dd-698b7eef2210"));
		}

		#endregion

	}

	#endregion

}

