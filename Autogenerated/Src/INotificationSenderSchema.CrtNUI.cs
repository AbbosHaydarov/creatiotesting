namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationSenderSchema

	/// <exclude/>
	public class INotificationSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationSenderSchema(INotificationSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0434505-a3a8-488e-a33b-2a071c2954f0");
			Name = "INotificationSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,65,106,195,48,16,69,215,49,248,14,34,171,118,99,29,160,174,55,165,4,111,74,33,185,128,34,143,146,1,107,100,102,164,64,40,185,123,37,55,133,136,44,103,230,191,255,63,67,198,131,44,198,130,58,0,179,145,224,98,247,17,200,225,41,177,137,24,168,109,126,218,102,147,4,233,164,246,87,137,224,243,125,158,193,150,163,116,59,32,96,180,111,109,147,85,90,107,213,75,242,222,240,117,184,207,223,28,46,56,129,40,1,154,138,9,133,136,14,237,106,46,202,67,60,135,73,186,127,90,63,224,75,58,206,104,21,82,4,118,165,226,248,245,192,238,179,31,112,150,149,126,79,209,235,162,72,164,14,44,65,207,73,127,155,197,176,241,138,242,71,222,183,21,180,29,14,103,168,124,114,41,23,216,223,61,123,189,162,171,211,37,224,180,6,191,140,159,148,60,176,57,206,208,87,205,199,204,14,117,173,215,252,192,205,173,109,110,191,231,226,60,180,144,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0434505-a3a8-488e-a33b-2a071c2954f0"));
		}

		#endregion

	}

	#endregion

}

