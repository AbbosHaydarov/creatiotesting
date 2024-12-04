namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotifySettingsByUserEventListenerSchema

	/// <exclude/>
	public class NotifySettingsByUserEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotifySettingsByUserEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotifySettingsByUserEventListenerSchema(NotifySettingsByUserEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b735c7f-e2d0-455f-b385-4bc2d14bce5b");
			Name = "NotifySettingsByUserEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,193,110,194,48,12,61,131,196,63,68,221,133,74,168,189,3,67,26,21,218,101,99,147,202,118,153,118,8,173,129,76,109,82,37,105,165,106,226,223,231,36,180,163,172,27,218,165,106,236,231,103,251,61,115,154,131,42,104,2,100,3,82,82,37,118,58,136,4,223,177,125,41,169,102,130,143,134,159,163,225,160,84,140,239,59,16,9,193,138,107,166,25,168,217,53,64,176,170,128,235,51,92,92,43,13,121,12,90,227,75,145,219,203,194,206,4,1,162,27,40,82,32,201,141,132,61,38,72,148,81,165,166,100,45,52,219,213,13,100,89,191,40,144,182,227,3,195,54,28,164,45,122,179,211,212,157,196,56,78,14,144,211,53,138,128,67,120,125,68,158,255,142,197,69,185,205,88,66,18,211,240,122,63,50,37,75,170,160,167,33,82,161,156,248,109,119,120,4,125,16,41,110,241,44,89,69,53,184,108,225,30,68,105,148,32,33,149,96,41,121,41,82,12,125,139,49,118,252,132,159,143,227,98,62,49,166,13,6,21,149,68,185,68,36,82,179,99,15,56,184,7,189,169,11,72,35,145,149,57,127,165,89,9,115,165,37,2,22,99,207,212,121,254,236,146,206,162,254,193,183,21,34,67,182,24,247,105,233,186,87,16,224,143,197,142,251,56,141,198,120,21,28,18,115,18,147,243,173,218,135,173,118,220,199,147,200,192,83,167,243,111,162,91,95,77,210,164,195,48,36,115,198,15,32,153,78,69,66,194,133,245,194,121,47,42,188,81,134,34,90,51,158,120,76,43,99,130,216,126,224,76,56,2,79,65,78,136,27,119,9,59,60,99,235,252,157,196,3,135,198,144,45,158,69,208,214,54,69,167,161,7,63,28,62,89,236,59,224,95,171,185,104,55,120,28,13,191,0,5,65,241,244,223,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b735c7f-e2d0-455f-b385-4bc2d14bce5b"));
		}

		#endregion

	}

	#endregion

}

