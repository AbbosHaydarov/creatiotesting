namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueGetOperationSchema

	/// <exclude/>
	public class IForecastObjectValueGetOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueGetOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueGetOperationSchema(IForecastObjectValueGetOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8085a14a-5f12-d391-672c-77b5acc1b8d6");
			Name = "IForecastObjectValueGetOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,146,65,107,195,48,12,133,207,41,244,63,136,236,178,193,72,96,199,45,203,101,172,165,48,40,172,163,119,55,149,51,143,196,14,178,61,40,99,255,125,178,221,148,64,6,189,36,209,203,211,203,39,71,90,244,104,7,209,32,124,32,145,176,70,186,226,197,104,169,90,79,194,41,163,139,149,33,108,132,117,251,135,229,226,103,185,200,188,85,186,133,221,201,58,236,217,218,117,216,4,159,45,214,168,145,84,243,180,92,176,235,134,176,101,21,54,218,33,73,206,127,132,205,152,180,61,124,113,207,94,116,30,215,232,182,3,166,47,197,190,178,44,161,178,190,239,5,157,234,115,125,201,0,105,8,90,116,46,16,200,115,26,152,24,7,223,33,15,88,51,116,180,197,24,85,78,178,6,127,232,84,3,234,18,119,157,40,227,137,249,58,195,138,2,91,175,83,204,49,178,168,12,130,68,15,154,143,255,57,183,159,136,46,175,119,225,86,149,241,205,255,70,169,58,102,79,255,39,175,87,177,130,38,150,179,62,66,231,73,219,250,77,49,29,106,223,243,80,135,14,193,200,17,175,42,71,79,104,218,188,94,60,213,228,60,222,163,183,14,195,166,71,123,27,57,33,66,223,67,130,72,72,48,229,187,227,69,200,126,211,50,160,62,166,125,8,37,107,127,52,81,98,22,118,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8085a14a-5f12-d391-672c-77b5acc1b8d6"));
		}

		#endregion

	}

	#endregion

}

