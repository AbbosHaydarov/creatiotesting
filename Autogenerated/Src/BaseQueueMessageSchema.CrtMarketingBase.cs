namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueueMessageSchema

	/// <exclude/>
	public class BaseQueueMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueueMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueueMessageSchema(BaseQueueMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04c48118-f957-49c4-a4ac-39fa34b1c523");
			Name = "BaseQueueMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("097cd95f-c972-4e9b-ab53-9b1cae85bae7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,177,78,195,64,12,134,231,86,234,59,88,234,2,75,178,83,96,160,32,1,18,168,64,97,65,12,110,226,132,19,201,93,57,251,84,170,138,119,199,151,132,210,210,170,203,73,182,127,219,223,239,196,98,77,60,199,140,96,74,222,35,187,66,146,177,179,133,41,131,71,49,206,14,250,171,65,191,23,216,216,18,158,150,44,84,143,214,241,61,45,196,217,166,231,150,157,213,130,150,134,158,74,237,131,113,133,204,39,112,129,76,15,129,2,221,17,51,150,212,104,210,52,133,83,14,117,141,126,121,222,197,81,8,117,43,130,194,121,248,140,93,201,175,58,221,144,207,195,172,50,25,224,140,197,99,38,144,197,85,59,155,160,93,62,69,254,216,6,232,169,35,125,215,164,19,239,230,228,197,144,226,78,154,209,109,253,63,101,147,184,98,49,53,10,229,64,86,76,108,130,204,5,43,17,116,151,180,247,26,15,115,83,90,231,233,45,198,29,186,177,242,55,233,209,45,120,28,103,192,10,74,146,17,112,124,190,15,64,60,51,121,157,161,87,210,1,209,130,43,64,222,9,178,224,189,98,65,208,250,33,160,206,241,242,232,146,10,12,149,188,96,21,232,26,109,94,197,207,122,6,251,210,73,235,226,120,211,134,222,63,54,68,28,253,105,132,190,246,90,24,146,205,219,83,55,113,155,221,78,106,238,7,35,193,125,80,138,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04c48118-f957-49c4-a4ac-39fa34b1c523"));
		}

		#endregion

	}

	#endregion

}

