namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncomingMessageListenerSchema

	/// <exclude/>
	public class IIncomingMessageListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncomingMessageListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncomingMessageListenerSchema(IIncomingMessageListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4621d47-b46b-4fa0-8ceb-e6a359374028");
			Name = "IIncomingMessageListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,145,193,106,195,48,12,134,207,13,228,29,68,119,217,46,201,189,235,122,217,41,176,110,101,108,15,160,37,74,106,136,229,32,57,131,49,250,238,115,237,36,116,1,95,36,255,250,248,127,137,209,146,14,88,19,124,144,8,170,107,125,241,236,184,53,221,40,232,141,227,226,205,178,169,207,200,76,125,113,36,85,236,12,119,121,246,155,103,121,182,185,19,234,130,8,42,246,36,109,192,236,160,170,184,118,54,104,146,152,94,157,55,173,33,137,250,178,44,97,175,163,181,40,63,135,169,126,167,65,72,137,189,130,153,49,208,58,129,222,168,39,14,164,208,79,72,176,137,169,5,204,176,242,134,54,140,95,189,169,111,40,107,47,47,145,120,245,178,73,254,151,0,71,242,103,215,232,14,78,145,145,62,215,110,99,227,20,216,78,172,2,214,215,253,64,120,107,123,197,50,124,235,46,117,6,20,180,192,97,237,79,219,73,190,61,204,54,23,192,190,140,186,56,246,237,76,3,159,67,131,158,238,151,3,76,129,230,129,135,199,41,14,113,147,18,197,250,146,142,244,175,121,249,3,249,134,34,28,243,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4621d47-b46b-4fa0-8ceb-e6a359374028"));
		}

		#endregion

	}

	#endregion

}

