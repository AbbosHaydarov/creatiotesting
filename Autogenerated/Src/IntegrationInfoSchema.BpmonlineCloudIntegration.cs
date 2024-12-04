namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationInfoSchema

	/// <exclude/>
	public class IntegrationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationInfoSchema(IntegrationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fa37aed-45de-4068-b0cc-7201310174fb");
			Name = "IntegrationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e8c267b1-bae4-4c71-bb04-0c218f8cac09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,146,221,74,196,48,16,133,175,91,232,59,12,187,247,173,120,233,234,130,84,144,222,232,194,250,2,217,116,218,6,218,164,204,36,138,44,190,187,211,214,117,127,20,113,181,23,41,57,61,39,231,35,83,171,58,228,94,105,132,39,36,82,236,42,159,230,206,86,166,14,164,188,113,54,137,183,73,156,196,32,207,156,176,22,5,242,86,49,95,65,97,61,214,147,169,176,149,219,185,178,44,131,107,14,93,167,232,117,185,151,238,148,87,80,145,235,224,241,54,248,230,50,189,0,179,63,224,32,154,29,103,251,176,105,141,6,61,116,126,173,140,70,184,40,218,161,173,200,245,72,222,160,240,173,198,228,244,253,4,106,18,238,209,51,56,2,30,222,190,65,176,114,25,233,167,253,0,36,138,62,48,216,147,177,53,60,136,17,182,80,163,95,12,233,5,188,157,83,163,91,131,214,131,41,101,53,149,65,250,85,103,62,166,138,242,223,189,140,154,208,159,209,185,30,3,127,235,85,240,172,218,128,50,235,210,104,25,156,28,250,210,160,208,144,32,25,150,52,10,24,97,117,51,59,25,238,44,91,130,24,56,104,141,204,63,227,110,156,107,97,61,57,191,227,156,163,45,167,63,100,220,79,234,177,40,218,59,134,79,146,88,12,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fa37aed-45de-4068-b0cc-7201310174fb"));
		}

		#endregion

	}

	#endregion

}

