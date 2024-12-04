namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoHandlerSchema

	/// <exclude/>
	public class INotificationInfoHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoHandlerSchema(INotificationInfoHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fc817aa-1460-4964-9d28-c837ff664b7c");
			Name = "INotificationInfoHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,75,3,49,16,61,183,208,255,48,236,169,66,217,197,94,60,88,23,68,164,238,69,5,21,15,226,33,187,153,212,129,124,44,73,182,80,196,255,238,100,215,98,219,85,8,129,12,111,222,155,247,38,86,24,12,173,104,16,158,209,123,17,156,138,249,141,179,138,54,157,23,145,156,157,77,63,103,211,73,23,200,110,224,105,23,34,154,203,147,55,227,181,198,38,129,67,190,70,139,158,26,198,48,170,40,10,88,133,206,24,225,119,229,240,174,108,68,175,146,158,114,30,90,239,26,12,61,151,117,145,20,53,189,102,200,247,205,197,65,247,219,67,29,156,198,136,243,236,149,180,134,26,193,163,113,91,148,32,20,179,194,69,126,190,204,151,11,32,203,99,9,9,93,248,215,85,94,221,31,232,221,9,43,53,250,236,236,157,101,218,174,214,212,48,201,126,208,35,104,101,149,251,129,51,150,163,225,123,228,179,47,60,14,222,48,140,173,77,70,222,134,74,43,188,48,96,121,37,87,25,177,80,200,202,223,108,193,41,136,31,120,194,182,42,250,166,191,57,56,0,95,201,17,11,201,0,202,59,147,246,119,45,13,217,23,75,241,136,105,235,72,194,96,51,25,158,87,183,182,51,232,69,173,113,53,138,163,228,172,120,153,102,152,104,1,135,224,117,71,178,76,139,72,115,156,165,159,243,53,155,242,249,6,108,196,95,102,119,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fc817aa-1460-4964-9d28-c837ff664b7c"));
		}

		#endregion

	}

	#endregion

}

