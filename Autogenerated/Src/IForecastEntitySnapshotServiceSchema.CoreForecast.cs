namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastEntitySnapshotServiceSchema

	/// <exclude/>
	public class IForecastEntitySnapshotServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastEntitySnapshotServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastEntitySnapshotServiceSchema(IForecastEntitySnapshotServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c7ea9e9-65c5-7705-1050-9886d7a946fc");
			Name = "IForecastEntitySnapshotService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,205,74,196,48,16,62,183,208,119,24,234,69,97,105,192,163,174,189,184,46,236,185,226,125,76,167,107,96,147,148,73,90,88,196,119,55,77,54,186,186,130,167,48,147,239,111,102,12,106,114,35,74,130,103,98,70,103,7,223,60,90,51,168,253,196,232,149,53,205,214,50,73,116,254,229,182,42,223,171,178,42,139,43,166,125,248,129,157,241,196,67,224,222,193,46,163,158,140,87,254,216,25,28,221,155,245,29,241,172,36,69,150,16,2,214,110,210,26,249,216,158,234,14,103,2,119,2,131,75,104,24,44,3,69,157,38,243,196,25,113,156,94,15,74,130,202,238,255,154,23,33,118,113,225,255,21,192,125,39,232,209,227,47,251,75,255,212,25,145,81,131,9,235,123,168,51,191,110,179,55,104,242,184,168,53,107,17,145,127,19,7,117,8,67,212,237,54,190,32,127,44,254,156,57,91,213,199,176,217,224,58,207,156,27,155,37,122,14,178,130,164,152,46,9,201,230,230,62,40,125,164,11,146,233,211,17,151,50,244,62,1,52,147,220,161,7,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c7ea9e9-65c5-7705-1050-9886d7a946fc"));
		}

		#endregion

	}

	#endregion

}

