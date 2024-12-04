namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCounterFactorySchema

	/// <exclude/>
	public class INotificationCounterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCounterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCounterFactorySchema(INotificationCounterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77f3b853-df5f-4ea2-af13-167cb7ffd1ed");
			Name = "INotificationCounterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,193,106,195,48,12,134,207,13,228,29,68,119,217,46,201,125,75,115,41,93,233,101,140,173,47,224,186,74,106,136,237,32,201,131,48,250,238,115,156,117,13,172,140,221,236,95,191,126,127,70,114,202,34,247,74,35,236,145,72,177,111,164,88,123,215,152,54,144,18,227,93,158,125,230,217,34,176,113,45,188,15,44,104,99,189,235,80,143,69,46,182,232,144,140,126,202,179,232,186,35,108,163,10,59,39,72,77,12,125,132,221,139,23,211,24,157,178,214,62,140,149,103,165,197,211,144,90,202,178,132,138,131,181,138,134,250,251,254,74,254,195,28,145,65,129,69,57,249,35,136,7,165,53,50,131,156,16,116,167,152,99,185,241,4,45,138,140,104,73,159,226,185,184,228,150,179,224,62,28,58,163,193,92,208,254,38,91,140,159,254,5,151,132,55,148,64,142,99,18,139,114,17,10,124,19,93,24,223,39,108,86,203,91,185,203,178,134,195,48,119,205,77,91,242,161,143,150,159,39,231,220,147,210,43,82,22,92,28,214,106,217,38,123,189,143,63,78,199,36,23,85,153,60,215,22,154,56,235,235,180,254,7,90,149,151,206,49,106,183,113,193,34,169,67,135,213,173,134,26,182,40,55,116,190,103,161,113,48,9,241,33,238,199,226,60,237,8,186,227,180,38,121,118,254,2,97,121,252,37,126,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77f3b853-df5f-4ea2-af13-167cb7ffd1ed"));
		}

		#endregion

	}

	#endregion

}

