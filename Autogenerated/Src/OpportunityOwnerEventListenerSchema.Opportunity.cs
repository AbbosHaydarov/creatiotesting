namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityOwnerEventListenerSchema

	/// <exclude/>
	public class OpportunityOwnerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityOwnerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityOwnerEventListenerSchema(OpportunityOwnerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45b2d596-38cb-494e-80ad-afc0697d9ae4");
			Name = "OpportunityOwnerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a637eec-ed5e-4e5a-93be-edcf08166986");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,177,78,195,48,16,157,83,169,255,112,10,11,44,241,94,90,6,170,110,85,59,148,13,49,28,238,37,88,138,237,200,103,23,69,136,127,231,156,82,8,80,96,176,172,119,126,239,238,221,179,67,75,220,161,38,184,163,16,144,125,29,171,165,119,181,105,82,192,104,188,155,78,94,166,147,34,177,113,13,236,122,142,100,175,63,240,88,18,232,183,122,181,114,209,68,67,252,47,161,90,29,200,197,204,19,230,69,160,70,230,195,178,69,230,25,172,9,247,219,103,71,97,224,172,141,56,17,48,48,149,82,48,231,100,45,134,254,230,29,159,8,224,107,240,89,6,210,106,219,117,62,196,228,76,236,65,154,200,85,157,228,234,155,126,206,68,216,178,7,29,168,94,148,127,27,174,110,145,105,168,245,95,220,149,160,114,191,251,51,79,151,59,253,68,22,55,18,63,44,160,28,57,43,175,30,68,211,165,199,214,104,208,121,249,177,239,159,17,192,12,62,199,159,75,168,200,31,88,200,121,61,230,74,110,127,140,54,67,169,189,1,32,78,178,134,3,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45b2d596-38cb-494e-80ad-afc0697d9ae4"));
		}

		#endregion

	}

	#endregion

}

