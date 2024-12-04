namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalMessageNotifierSchema

	/// <exclude/>
	public class LocalMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalMessageNotifierSchema(LocalMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4f644d0-eb01-48be-be16-2d50b24a40a4");
			Name = "LocalMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,219,106,194,64,16,134,175,35,248,14,139,189,81,144,60,128,61,64,141,197,10,182,74,181,189,159,110,38,113,33,217,149,61,80,130,248,238,157,236,70,141,173,136,87,155,157,253,230,159,153,63,227,140,144,57,91,85,198,98,121,223,237,184,214,53,78,84,81,32,183,66,73,19,79,81,162,22,252,136,172,81,107,48,42,179,68,105,140,95,164,21,86,160,161,247,110,71,66,137,102,11,28,207,40,153,137,220,105,168,229,186,157,93,205,69,119,26,115,186,178,164,0,99,70,108,174,56,20,111,104,12,228,248,174,172,200,4,106,207,109,221,119,33,56,227,53,118,145,98,35,54,6,131,255,114,163,80,231,84,136,70,177,218,113,171,244,136,45,189,106,0,154,10,151,180,251,126,182,138,161,63,6,140,36,163,40,106,160,153,204,20,123,100,18,127,88,59,18,152,3,68,64,72,38,23,237,186,218,98,74,206,186,82,126,65,225,240,129,26,34,67,159,250,189,134,238,13,134,33,59,209,8,22,211,113,53,75,175,43,76,157,72,41,191,197,255,213,88,200,235,10,19,130,214,162,196,147,202,66,30,53,94,193,60,91,11,124,83,146,2,233,144,129,216,60,29,60,250,64,174,116,218,238,115,169,69,9,186,106,21,25,134,148,21,223,96,9,159,109,54,132,98,138,53,204,92,208,254,209,190,25,234,11,26,123,39,194,111,34,105,250,121,135,204,79,125,112,58,218,221,96,80,248,145,199,6,104,192,155,147,106,154,237,67,173,112,236,105,213,253,183,223,47,148,105,88,49,127,15,209,243,160,143,253,2,157,221,3,129,110,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4f644d0-eb01-48be-be16-2d50b24a40a4"));
		}

		#endregion

	}

	#endregion

}

