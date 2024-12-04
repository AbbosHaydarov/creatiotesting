namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationFactorySchema

	/// <exclude/>
	public class INotificationFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationFactorySchema(INotificationFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("105f1ef7-143f-4c69-82ab-4aee819c63e5");
			Name = "INotificationFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,193,10,194,48,12,134,207,14,246,14,197,147,94,214,7,112,238,50,16,118,217,201,23,136,93,42,5,151,142,180,19,134,248,238,182,115,211,201,16,114,72,147,124,249,255,148,160,69,215,129,66,113,70,102,112,86,251,172,180,164,205,181,103,240,198,82,154,60,210,100,19,66,74,41,114,215,183,45,240,80,76,239,138,60,178,142,180,182,44,20,99,64,232,42,200,122,163,141,26,121,209,177,189,155,6,57,155,119,200,197,146,174,191,220,140,18,230,179,167,170,23,236,9,148,183,60,132,185,232,97,229,96,44,148,81,20,155,255,154,107,209,119,165,3,134,86,80,184,255,184,85,55,112,174,14,233,182,40,99,58,150,179,92,142,51,95,132,209,247,76,174,88,122,252,106,229,114,238,71,224,231,144,201,101,69,206,3,41,220,57,207,241,159,62,178,251,67,64,158,105,18,226,5,59,161,37,242,145,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("105f1ef7-143f-4c69-82ab-4aee819c63e5"));
		}

		#endregion

	}

	#endregion

}

