namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatContactSchema

	/// <exclude/>
	public class ChatContactSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatContactSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatContactSchema(ChatContactSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dfeee86-228f-4670-b6f8-b56e2b8c7992");
			Name = "ChatContact";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,203,78,195,48,16,69,215,68,202,63,88,93,193,38,249,0,30,18,10,8,85,34,128,40,98,131,88,76,157,73,58,194,143,200,15,164,130,250,239,140,19,42,90,148,172,236,241,189,103,174,61,54,160,209,247,32,81,188,160,115,224,109,27,138,202,154,150,186,232,32,144,53,197,163,54,36,55,96,12,170,162,70,239,161,35,211,229,217,119,158,157,68,207,91,177,218,250,128,250,252,95,93,60,71,19,72,99,177,66,71,160,232,107,232,246,231,58,140,115,131,235,147,36,214,182,65,197,249,193,129,12,108,102,123,89,150,226,194,71,173,193,109,175,126,235,74,129,247,66,178,15,200,160,19,173,117,130,239,24,198,35,25,68,3,1,138,61,92,30,208,111,55,172,236,3,222,249,160,143,107,69,82,200,161,99,197,61,146,200,26,75,233,137,35,80,163,94,163,59,125,224,97,137,75,177,160,102,113,150,216,61,124,23,169,17,203,38,61,110,210,111,120,61,38,124,112,105,8,201,48,75,245,27,27,236,114,42,234,105,84,102,73,212,64,106,50,240,54,41,179,28,72,105,249,215,142,201,123,107,63,98,255,10,42,162,184,30,13,169,193,46,207,118,63,119,81,95,172,61,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dfeee86-228f-4670-b6f8-b56e2b8c7992"));
		}

		#endregion

	}

	#endregion

}

