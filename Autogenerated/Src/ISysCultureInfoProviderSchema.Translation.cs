namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoProviderSchema

	/// <exclude/>
	public class ISysCultureInfoProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoProviderSchema(ISysCultureInfoProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8d77611-044f-49a7-9b8f-472b0b015ec7");
			Name = "ISysCultureInfoProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,146,77,106,195,48,16,133,215,9,228,14,34,217,180,27,123,159,184,222,120,97,12,45,132,38,23,80,173,177,43,176,70,102,36,149,134,210,187,119,44,97,67,93,74,119,221,8,233,233,123,51,79,63,40,13,184,81,182,32,174,64,36,157,237,124,86,89,236,116,31,72,122,109,49,187,146,68,55,196,249,110,251,177,219,110,130,211,216,139,203,205,121,48,167,213,154,189,195,0,237,4,187,172,6,4,210,45,51,76,29,8,122,86,69,131,30,168,227,134,71,209,176,167,10,131,15,4,13,118,246,76,246,77,43,160,136,143,225,101,208,173,208,51,253,59,188,225,76,60,46,13,158,192,191,90,229,142,226,28,75,164,205,60,207,69,225,130,49,146,110,229,44,212,224,157,112,49,183,104,83,105,110,216,89,50,233,228,139,49,95,59,139,81,146,52,2,249,242,30,246,90,237,203,203,170,138,2,244,186,211,64,89,145,71,54,90,87,103,16,207,32,213,93,29,180,98,195,253,233,31,146,162,130,247,159,97,39,245,239,156,252,20,9,157,147,62,106,231,139,21,90,38,118,70,38,79,101,3,250,69,57,0,170,244,80,113,253,153,254,198,55,145,181,47,161,18,187,9,150,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8d77611-044f-49a7-9b8f-472b0b015ec7"));
		}

		#endregion

	}

	#endregion

}

