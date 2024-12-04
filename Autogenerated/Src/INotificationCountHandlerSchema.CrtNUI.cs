namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCountHandlerSchema

	/// <exclude/>
	public class INotificationCountHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCountHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCountHandlerSchema(INotificationCountHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e44863be-4aaa-47e8-b8fa-552d50bcc3f3");
			Name = "INotificationCountHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,111,194,48,12,61,131,196,127,176,216,101,147,80,123,223,88,47,76,98,189,160,105,31,63,32,75,221,18,173,117,42,39,97,66,19,255,125,78,10,27,3,118,232,193,206,123,207,207,175,38,213,161,235,149,70,120,69,102,229,108,237,179,133,165,218,52,129,149,55,150,38,227,175,201,120,20,156,161,6,94,182,206,99,119,119,82,11,190,109,81,71,176,203,150,72,200,70,11,70,80,87,140,141,116,161,36,143,92,203,144,91,40,87,214,155,218,232,164,189,176,129,252,163,162,170,69,134,196,200,243,28,230,46,116,157,226,109,177,175,159,216,110,76,133,14,58,244,107,91,129,183,192,232,217,224,6,193,175,17,116,84,65,118,217,129,159,31,9,244,225,189,53,26,204,193,193,255,6,4,28,55,29,197,239,212,70,106,60,163,15,76,238,207,76,168,45,131,130,224,144,51,248,97,30,27,24,58,189,98,213,1,73,216,247,83,109,201,43,237,203,106,90,188,9,15,100,55,138,150,68,98,158,39,224,101,94,195,54,244,211,98,37,5,216,58,217,72,173,115,150,196,19,157,22,15,38,253,21,113,50,131,207,53,50,194,7,110,193,184,129,23,69,210,30,32,1,192,70,181,1,227,91,106,137,230,65,36,170,150,191,74,115,39,209,83,51,139,145,22,176,68,127,150,167,196,114,189,12,166,18,165,253,162,51,24,72,195,220,155,120,64,187,225,64,144,170,225,70,38,227,221,55,78,140,149,60,139,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e44863be-4aaa-47e8-b8fa-552d50bcc3f3"));
		}

		#endregion

	}

	#endregion

}

