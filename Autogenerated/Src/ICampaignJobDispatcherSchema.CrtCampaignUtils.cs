namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignJobDispatcherSchema

	/// <exclude/>
	public class ICampaignJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignJobDispatcherSchema(ICampaignJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef");
			Name = "ICampaignJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,85,77,111,219,48,12,61,167,64,255,3,225,29,182,1,131,125,111,154,92,82,116,240,128,13,93,154,157,7,217,162,109,21,150,228,233,163,89,86,244,191,143,150,99,215,110,90,44,135,96,151,94,2,232,137,226,227,123,36,29,197,36,218,134,229,8,27,52,134,89,93,184,120,165,85,33,74,111,152,19,90,157,159,61,156,159,205,188,21,170,132,219,157,117,40,231,195,121,165,13,174,152,108,152,40,213,109,94,161,100,176,152,228,49,24,247,247,241,52,240,41,201,119,207,140,251,67,103,66,222,25,44,137,19,82,229,208,20,84,213,5,164,253,187,47,58,187,18,84,170,163,247,38,68,39,73,2,151,214,75,201,204,110,185,63,175,177,49,104,81,57,11,18,93,165,185,133,66,27,184,211,153,125,15,146,41,86,162,164,219,184,127,158,140,222,55,62,171,69,14,162,39,127,149,123,70,150,208,239,80,238,141,209,13,26,39,208,94,192,77,72,210,221,63,47,48,0,169,178,142,41,202,174,11,186,68,132,220,96,177,136,210,214,23,238,107,52,81,178,132,173,112,21,40,234,205,56,228,103,62,178,48,132,126,163,136,54,156,20,114,44,152,175,131,176,67,101,179,167,236,48,238,67,135,60,64,137,110,14,143,176,87,133,138,119,194,166,42,191,118,126,30,33,177,79,109,65,225,111,215,154,31,154,224,42,4,219,96,46,10,129,28,122,49,175,84,28,144,134,25,38,131,15,139,200,134,185,137,150,155,106,98,202,225,12,6,67,178,59,204,93,96,221,138,188,2,106,32,52,53,83,54,190,76,66,210,151,57,10,97,112,35,36,118,27,16,45,175,233,12,142,0,200,3,210,207,210,36,203,189,22,124,144,76,68,31,94,88,139,174,248,79,131,249,215,19,34,152,242,126,156,31,225,237,41,173,29,207,149,100,63,82,222,185,236,149,248,229,17,4,167,133,105,19,155,118,100,251,216,189,36,218,150,110,156,255,135,177,159,61,1,7,197,158,194,213,53,74,125,79,243,106,247,108,60,124,49,78,104,237,113,158,182,160,219,193,182,106,103,182,237,173,173,180,175,57,100,72,251,93,163,67,126,104,80,87,58,217,99,167,254,164,252,31,138,123,173,246,77,44,232,122,208,123,202,21,125,246,173,124,236,254,197,38,32,97,127,1,3,205,133,253,101,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc8d4fc1-fb96-4b0b-924c-b75865ecfbef"));
		}

		#endregion

	}

	#endregion

}

