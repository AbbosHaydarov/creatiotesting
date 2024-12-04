namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IConversationProviderSchema

	/// <exclude/>
	public class IConversationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IConversationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IConversationProviderSchema(IConversationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae9b308e-924f-4ea5-bac1-90760e48d38f");
			Name = "IConversationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5c46c08-cc76-4157-b24b-44267444e258");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,147,193,106,2,49,16,134,207,10,190,195,96,47,45,136,123,175,214,67,69,138,208,22,161,133,158,227,102,118,13,152,100,153,36,82,41,125,247,78,178,174,93,209,210,106,143,147,252,51,243,253,147,76,112,202,148,240,178,117,30,245,168,215,237,117,141,208,232,42,145,35,188,34,145,112,182,240,195,169,53,133,42,3,9,175,172,129,143,40,235,92,17,150,49,154,27,143,84,176,254,22,230,172,219,32,185,36,91,144,221,40,137,148,196,89,150,193,216,5,173,5,109,39,187,120,174,171,53,106,52,222,193,218,150,101,196,176,5,224,59,230,33,181,225,160,34,155,163,12,132,195,166,70,214,42,82,133,229,90,229,160,26,128,211,253,119,184,71,8,233,224,145,27,163,228,18,133,37,93,187,19,75,27,60,44,217,156,49,145,233,103,160,99,162,250,164,18,36,52,196,57,222,245,247,9,207,28,246,39,139,38,76,215,195,113,150,180,223,169,132,62,144,113,147,182,17,80,146,133,205,77,148,62,4,37,225,62,18,182,117,215,206,83,4,62,104,121,51,186,196,125,110,227,219,52,166,253,10,207,55,158,183,200,230,178,127,194,209,183,245,141,101,63,51,35,15,220,36,147,135,85,46,51,195,191,216,18,48,251,255,95,243,28,83,71,201,137,99,106,37,127,131,89,66,250,83,194,19,58,39,202,125,14,239,102,12,127,29,223,155,242,171,58,227,212,32,7,113,105,234,193,68,160,1,236,190,78,187,99,28,118,231,179,94,117,52,178,222,246,94,151,79,190,0,28,107,210,217,51,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae9b308e-924f-4ea5-bac1-90760e48d38f"));
		}

		#endregion

	}

	#endregion

}

