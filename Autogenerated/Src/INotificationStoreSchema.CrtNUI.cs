namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationStoreSchema

	/// <exclude/>
	public class INotificationStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationStoreSchema(INotificationStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ee4e1be-170c-44d3-92be-47cd9f1c5368");
			Name = "INotificationStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,193,106,195,48,12,134,207,9,228,29,116,220,46,241,3,44,228,50,70,201,165,140,117,47,224,186,114,103,72,228,32,201,131,50,246,238,83,218,101,11,20,108,35,235,151,244,137,159,252,132,50,251,128,240,142,204,94,114,212,246,57,83,76,231,194,94,83,166,166,254,106,234,170,72,162,51,28,46,162,56,153,62,142,24,22,81,218,29,18,114,10,79,77,109,85,206,57,232,164,76,147,231,75,255,251,31,72,145,227,2,136,153,193,135,128,34,112,242,234,33,71,208,15,4,202,154,98,10,87,24,204,156,63,211,9,89,218,117,156,219,204,155,203,113,76,1,210,223,200,97,191,105,62,104,102,180,42,219,215,222,187,101,174,137,55,212,194,36,255,28,32,51,96,129,221,211,110,25,190,117,244,157,91,163,69,26,94,168,76,200,254,56,98,39,202,102,78,15,59,212,237,58,175,43,98,111,132,135,71,115,168,170,236,126,55,181,157,31,135,134,173,246,119,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ee4e1be-170c-44d3-92be-47cd9f1c5368"));
		}

		#endregion

	}

	#endregion

}

