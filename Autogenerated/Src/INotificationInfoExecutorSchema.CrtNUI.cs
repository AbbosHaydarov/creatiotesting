namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoExecutorSchema

	/// <exclude/>
	public class INotificationInfoExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoExecutorSchema(INotificationInfoExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70829de2-1828-4038-881b-1a16b2b88f30");
			Name = "INotificationInfoExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,145,177,78,3,49,12,134,231,70,202,59,88,93,218,46,57,193,0,3,85,151,138,225,24,56,9,216,16,67,114,117,170,72,185,184,138,19,160,2,222,157,220,29,133,67,149,162,196,113,252,217,255,175,100,118,97,15,143,71,78,216,221,72,33,69,208,29,242,65,183,8,79,24,163,102,178,73,109,41,88,183,207,81,39,71,65,138,15,41,102,85,85,193,154,115,215,233,120,220,252,220,235,144,48,218,30,181,20,33,80,114,214,181,3,3,248,142,109,238,35,117,98,171,9,252,220,24,38,143,9,151,243,107,117,113,165,46,225,115,210,236,205,121,15,6,33,98,71,175,184,3,109,203,11,236,176,7,192,162,78,57,34,44,238,39,227,184,9,77,192,173,215,204,119,100,22,106,190,122,41,83,14,217,120,215,130,251,109,92,79,153,58,88,186,29,84,82,44,197,197,99,217,207,108,14,137,41,246,223,217,185,181,49,19,177,136,12,188,121,24,207,63,8,56,233,132,106,93,157,42,122,196,16,121,24,181,224,114,85,126,101,246,37,69,89,223,55,157,35,56,172,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70829de2-1828-4038-881b-1a16b2b88f30"));
		}

		#endregion

	}

	#endregion

}

