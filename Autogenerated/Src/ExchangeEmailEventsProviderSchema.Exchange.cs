namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeEmailEventsProviderSchema

	/// <exclude/>
	public class ExchangeEmailEventsProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeEmailEventsProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeEmailEventsProviderSchema(ExchangeEmailEventsProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2eb6a61-1c72-4cbf-9db4-831b77de2c84");
			Name = "ExchangeEmailEventsProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,193,110,163,48,16,61,83,169,255,48,162,151,68,138,224,222,77,168,86,81,14,145,90,169,90,178,151,189,172,92,152,4,75,96,71,182,73,55,89,245,223,119,108,32,193,41,69,237,97,47,8,63,198,111,222,204,60,6,4,171,80,239,89,134,176,65,165,152,150,91,19,165,71,145,69,171,63,89,193,196,14,111,111,254,222,222,4,181,230,98,7,233,81,27,172,190,157,207,151,43,75,169,144,112,250,114,167,112,199,165,128,101,201,180,190,135,142,102,85,49,94,174,14,40,140,126,86,242,192,115,84,46,124,95,191,148,60,131,204,70,143,5,195,21,149,213,120,33,10,72,35,61,47,201,165,208,70,213,153,145,138,52,60,187,28,77,68,28,199,48,215,117,85,49,117,76,58,96,45,184,225,172,228,39,4,129,175,192,233,50,19,212,18,185,165,88,68,200,20,110,23,225,136,186,16,226,4,94,185,41,96,79,117,96,14,154,228,21,74,10,126,98,198,10,210,104,12,117,76,71,103,13,241,181,136,249,158,41,86,129,29,200,34,172,53,42,42,66,96,102,175,135,73,79,198,79,255,19,37,238,244,70,243,216,113,12,83,106,20,164,212,137,255,158,231,10,181,14,147,212,97,128,22,4,214,160,227,44,86,88,218,22,227,201,106,186,210,182,232,28,241,145,186,118,236,35,45,157,248,117,130,223,145,25,208,124,173,5,223,87,53,131,65,41,142,224,124,88,128,168,203,114,106,165,4,247,240,194,52,78,222,37,24,96,238,115,76,161,53,221,219,255,118,214,103,77,99,120,133,191,164,192,181,216,202,48,89,214,74,17,19,88,244,68,232,215,221,177,41,16,44,96,251,220,154,195,10,55,4,95,249,251,171,179,29,25,222,166,87,132,211,222,29,188,97,13,221,244,130,175,134,115,71,241,205,110,240,23,197,19,154,66,230,159,217,17,31,141,171,191,136,162,71,201,114,11,172,105,77,78,186,151,52,43,232,7,155,181,142,157,210,63,49,60,207,182,111,242,64,91,149,216,96,253,3,43,105,208,82,192,8,49,104,143,31,120,238,138,167,94,165,168,14,156,204,182,128,238,237,225,161,231,200,22,156,252,246,157,63,181,251,61,8,20,154,90,9,215,109,191,172,46,29,229,113,145,195,29,110,80,31,124,251,7,96,115,16,159,110,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2eb6a61-1c72-4cbf-9db4-831b77de2c84"));
		}

		#endregion

	}

	#endregion

}

