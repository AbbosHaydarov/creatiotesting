namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UserReportGenerationTaskSchema

	/// <exclude/>
	public class UserReportGenerationTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UserReportGenerationTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UserReportGenerationTaskSchema(UserReportGenerationTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd121194-abe4-482b-9424-0b625f81bd05");
			Name = "UserReportGenerationTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,177,110,194,48,16,157,19,137,127,56,137,5,36,68,118,104,187,48,68,44,21,42,116,170,58,56,201,37,61,53,177,163,243,121,160,168,255,94,219,73,105,169,64,234,98,75,207,239,221,123,239,172,85,135,182,87,37,194,1,153,149,53,181,44,55,70,215,212,56,86,66,70,79,210,211,36,77,156,37,221,192,254,104,5,187,245,36,245,200,148,177,241,207,176,105,149,181,43,120,182,200,79,216,27,150,28,53,14,210,131,178,239,145,251,178,71,38,213,210,135,42,90,124,245,64,239,138,150,74,40,131,246,166,20,86,112,125,98,226,19,249,243,39,130,209,86,216,149,98,216,39,217,197,217,3,99,244,185,229,48,155,67,40,151,124,254,143,125,53,164,248,99,1,185,163,10,156,23,110,171,121,24,149,172,160,80,22,103,225,117,25,120,219,106,17,169,203,97,200,163,95,251,104,158,4,191,109,5,247,163,222,175,247,156,104,138,186,26,74,94,54,222,177,233,145,133,240,79,223,44,203,224,206,186,174,83,124,124,248,6,114,20,11,134,193,134,91,105,160,10,181,80,77,200,96,234,104,10,242,166,4,72,147,196,95,66,224,24,18,154,115,213,33,251,217,34,251,237,49,174,45,174,96,236,114,242,82,89,7,199,53,92,175,50,160,151,160,199,190,0,127,43,108,246,143,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd121194-abe4-482b-9424-0b625f81bd05"));
		}

		#endregion

	}

	#endregion

}

