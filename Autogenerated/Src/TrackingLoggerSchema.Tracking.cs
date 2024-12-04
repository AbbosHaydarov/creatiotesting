namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TrackingLoggerSchema

	/// <exclude/>
	public class TrackingLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TrackingLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TrackingLoggerSchema(TrackingLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1b4bc65-b177-4549-904d-d9ef71e207d9");
			Name = "TrackingLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("874306e1-e314-437e-96bf-3f336a8aaf12");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,203,110,219,48,16,60,203,64,254,97,161,92,100,192,160,238,137,237,67,83,23,48,80,7,1,236,156,3,150,90,171,68,37,82,224,35,141,19,228,223,179,164,30,177,84,183,232,73,220,199,204,206,206,74,241,26,109,195,5,194,1,141,225,86,31,29,187,211,234,40,75,111,184,147,90,177,131,225,226,151,84,229,213,236,237,106,150,120,75,79,216,159,172,195,250,118,136,207,177,6,255,150,103,95,191,80,137,138,215,6,75,162,134,187,138,91,123,3,253,132,239,186,44,209,196,142,198,255,168,164,0,17,26,254,168,39,65,200,64,242,77,98,85,16,203,131,145,207,220,97,132,39,77,27,128,65,94,104,85,157,224,209,162,161,189,20,138,176,20,60,249,81,220,202,74,174,81,21,45,107,23,247,58,181,178,206,120,225,180,9,131,162,182,182,35,207,115,88,90,95,215,220,156,214,125,98,171,164,147,188,146,175,72,53,68,16,6,143,171,116,188,69,154,175,65,18,43,87,2,217,192,148,79,169,150,13,55,188,6,69,87,90,165,99,205,233,122,219,225,65,31,207,7,141,87,165,65,108,153,71,154,200,218,57,59,86,147,77,236,25,79,154,67,52,60,153,152,6,171,73,95,184,123,242,254,111,43,119,232,126,234,98,226,98,167,233,89,203,2,72,80,70,102,135,191,167,214,133,175,240,158,118,95,64,159,66,107,121,137,189,34,114,0,141,11,70,134,207,10,20,254,38,247,67,144,77,196,206,217,86,57,157,157,95,33,157,71,193,73,139,102,123,116,89,186,27,70,166,11,58,123,229,107,197,30,130,119,232,200,165,79,65,243,75,216,86,219,69,96,39,123,140,218,188,160,240,14,179,54,219,25,247,31,94,108,94,4,54,241,2,216,191,122,67,2,226,188,117,104,96,7,189,143,76,89,39,226,242,157,218,236,56,249,254,1,158,150,247,59,36,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1b4bc65-b177-4549-904d-d9ef71e207d9"));
		}

		#endregion

	}

	#endregion

}

