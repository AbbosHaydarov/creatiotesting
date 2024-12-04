namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysTranslationColumnsConfiguratorSchema

	/// <exclude/>
	public class ISysTranslationColumnsConfiguratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysTranslationColumnsConfiguratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysTranslationColumnsConfiguratorSchema(ISysTranslationColumnsConfiguratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72ebf492-d797-436e-ab08-aef6a2bee1fc");
			Name = "ISysTranslationColumnsConfigurator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,145,177,110,195,32,16,64,103,91,242,63,160,100,105,23,179,167,174,151,168,138,60,68,170,212,252,0,193,103,23,9,206,209,29,12,81,148,127,47,54,113,147,180,138,218,5,184,227,222,241,0,84,14,248,160,52,136,29,16,41,30,58,95,174,7,236,76,31,72,121,51,96,185,35,133,108,167,117,145,159,138,60,11,108,176,23,31,71,246,224,98,173,181,160,199,77,46,55,128,64,70,191,20,121,172,90,18,244,49,43,26,244,64,93,60,96,37,154,200,220,116,139,104,112,200,215,211,6,154,72,41,165,168,56,56,167,232,88,95,226,11,153,64,161,19,25,231,43,90,206,164,188,65,15,97,111,141,22,102,118,248,151,66,22,47,25,199,239,27,108,193,127,14,45,175,196,251,212,45,109,254,148,204,198,196,6,60,255,161,10,163,231,84,124,39,154,50,4,62,16,114,93,49,128,208,4,221,235,226,151,236,236,10,11,89,87,114,38,198,22,205,27,6,7,164,246,22,170,199,88,61,90,62,126,2,104,159,158,211,7,102,75,192,54,61,193,20,159,211,183,222,37,207,95,149,178,9,108,63,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72ebf492-d797-436e-ab08-aef6a2bee1fc"));
		}

		#endregion

	}

	#endregion

}

