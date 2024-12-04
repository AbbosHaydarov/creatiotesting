namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatMessageSchema

	/// <exclude/>
	public class ChatMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatMessageSchema(ChatMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21c9a1d7-90b7-429c-ad25-dd578ea023a7");
			Name = "ChatMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,65,79,194,64,16,133,207,146,240,31,38,156,244,178,253,1,34,9,130,33,36,162,70,184,25,15,75,59,192,38,221,93,178,51,53,162,225,191,59,219,82,164,136,189,52,219,190,249,222,190,190,93,167,45,210,86,167,8,11,12,65,147,95,177,26,121,183,50,235,34,104,54,222,169,103,235,76,186,209,206,97,174,102,72,164,215,198,173,187,157,239,110,231,170,32,89,194,201,192,75,240,31,38,195,64,106,236,173,54,78,61,56,54,108,144,110,143,211,243,29,49,218,243,119,217,51,207,49,141,27,146,154,160,195,96,210,63,51,175,133,184,89,84,115,81,117,110,190,202,124,50,37,115,73,146,64,159,10,107,117,216,13,14,239,163,92,19,65,234,29,75,18,12,176,242,1,36,39,131,45,255,2,73,213,96,114,66,190,141,53,107,105,128,131,78,249,93,62,108,139,101,110,82,72,75,183,145,240,85,9,40,82,236,160,2,102,104,151,24,174,159,164,77,184,131,158,201,122,55,145,173,225,73,97,50,152,102,85,214,139,132,46,120,227,67,147,138,155,197,36,18,4,134,165,222,98,16,155,105,226,196,33,150,183,16,161,141,195,79,190,204,137,208,194,101,38,84,231,213,132,103,85,57,227,90,133,227,170,45,195,110,123,150,253,96,179,16,1,226,163,173,57,150,130,54,22,29,83,211,227,209,16,247,15,70,195,227,208,0,126,215,241,90,254,123,132,116,239,235,163,110,250,46,189,207,97,122,34,199,139,186,239,118,246,63,91,7,137,235,76,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21c9a1d7-90b7-429c-ad25-dd578ea023a7"));
		}

		#endregion

	}

	#endregion

}

