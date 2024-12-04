namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMarkNotificationAsReadExecutorSchema

	/// <exclude/>
	public class IMarkNotificationAsReadExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMarkNotificationAsReadExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMarkNotificationAsReadExecutorSchema(IMarkNotificationAsReadExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5756ae2a-e1ed-46c5-b16e-e91d802e9c2d");
			Name = "IMarkNotificationAsReadExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,143,77,10,194,48,16,133,215,13,244,14,3,221,40,72,15,80,87,162,34,93,84,68,123,129,216,76,235,160,73,74,126,196,34,222,221,216,160,116,231,102,152,247,134,239,61,70,113,137,182,231,13,66,141,198,112,171,91,151,175,181,106,169,243,134,59,210,42,223,107,71,45,53,163,176,41,123,166,44,241,150,84,7,167,193,58,148,203,148,5,39,51,216,133,59,148,202,161,105,67,92,1,101,197,205,117,10,175,236,17,185,216,62,176,241,78,155,17,235,253,249,70,13,208,151,250,15,37,161,63,204,95,97,133,238,162,133,45,224,48,70,197,227,93,147,128,200,224,108,231,131,80,147,200,122,232,177,20,11,216,112,135,53,73,4,131,146,148,248,172,243,248,77,146,161,18,177,32,168,87,252,112,98,165,44,120,111,87,17,43,114,58,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5756ae2a-e1ed-46c5-b16e-e91d802e9c2d"));
		}

		#endregion

	}

	#endregion

}

