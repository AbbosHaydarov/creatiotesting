namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILogoutEventHandlerSchema

	/// <exclude/>
	public class ILogoutEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILogoutEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILogoutEventHandlerSchema(ILogoutEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f8ea2d-d42f-9e96-1ad8-2155021d7863");
			Name = "ILogoutEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,145,207,106,195,48,12,135,207,45,244,29,68,122,217,46,201,189,107,123,41,131,21,54,232,161,123,0,215,81,82,131,255,4,201,238,24,163,239,62,197,94,199,82,118,139,229,159,190,124,178,188,114,200,131,210,8,71,36,82,28,186,88,239,130,239,76,159,72,69,19,252,98,254,181,152,207,18,27,223,79,34,132,79,139,185,220,44,9,123,137,193,222,71,164,78,64,43,216,191,134,62,164,248,124,65,31,95,148,111,45,82,142,54,77,3,107,78,206,41,250,220,254,156,15,20,46,166,69,6,53,24,232,2,65,37,172,196,72,96,51,164,2,165,71,13,6,227,6,139,78,144,89,171,190,241,154,63,192,33,157,172,209,96,110,42,255,153,128,140,35,209,95,239,55,140,231,208,242,10,14,185,185,92,222,155,206,198,194,241,108,24,92,142,195,135,177,22,78,8,90,89,139,173,124,137,58,22,111,70,230,17,140,190,21,19,144,192,157,58,143,238,153,56,145,47,149,65,145,114,224,101,43,155,42,233,106,187,102,148,191,16,118,155,234,93,232,178,26,143,249,65,170,102,43,120,142,202,107,172,215,77,238,203,152,75,48,45,148,97,243,220,15,211,62,72,250,177,108,110,182,20,197,242,10,249,124,45,251,156,20,175,223,220,32,59,206,32,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f8ea2d-d42f-9e96-1ad8-2155021d7863"));
		}

		#endregion

	}

	#endregion

}

