namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationRepositorySchema

	/// <exclude/>
	public class INotificationRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationRepositorySchema(INotificationRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c3d2ee1-fb37-4416-8019-d5f16be32ce0");
			Name = "INotificationRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,146,193,74,196,48,16,134,207,91,232,59,12,61,173,151,246,1,172,5,21,41,189,236,97,245,5,210,56,169,129,52,41,147,228,80,196,119,55,201,218,117,235,138,162,32,66,8,36,153,63,255,55,127,162,217,136,118,98,28,225,1,137,152,53,194,149,183,70,11,57,120,98,78,26,157,103,207,121,182,241,86,234,1,238,103,235,112,12,231,74,33,143,135,182,108,81,35,73,126,25,106,194,168,170,10,106,235,199,145,209,220,188,173,59,237,144,68,116,16,134,224,145,57,6,140,115,180,22,180,113,82,72,158,108,202,69,93,157,200,39,223,43,201,65,30,111,232,118,39,146,61,78,198,74,103,104,14,165,17,242,204,62,109,236,209,121,210,22,152,82,43,71,27,45,207,61,15,59,116,16,53,239,173,130,17,224,158,240,195,21,117,181,84,70,105,119,167,253,136,196,122,133,245,10,181,211,194,52,208,162,187,86,106,123,17,195,218,124,203,187,50,130,126,6,29,158,234,43,230,137,17,27,83,213,85,17,231,162,217,133,249,51,238,128,157,138,255,190,223,155,57,50,108,173,163,248,127,34,213,111,187,31,200,248,233,71,25,36,69,209,180,71,225,127,71,145,72,150,44,18,93,10,227,37,207,194,120,5,165,169,105,182,137,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c3d2ee1-fb37-4416-8019-d5f16be32ce0"));
		}

		#endregion

	}

	#endregion

}

