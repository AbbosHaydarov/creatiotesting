namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISocialMentionExecutorSchema

	/// <exclude/>
	public class ISocialMentionExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISocialMentionExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISocialMentionExecutorSchema(ISocialMentionExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("731044fc-827f-47a1-af08-e646f558fb9f");
			Name = "ISocialMentionExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,205,110,194,48,16,132,207,32,241,14,43,184,180,82,149,220,41,229,82,161,138,3,21,82,250,2,38,217,36,86,137,141,118,215,252,168,226,221,187,216,64,105,171,246,102,143,103,214,159,61,206,116,200,27,83,34,188,33,145,97,95,75,246,236,93,109,155,64,70,172,119,217,172,120,29,244,63,6,253,94,96,235,26,40,14,44,216,61,14,250,170,140,8,27,181,0,204,157,32,213,58,101,12,243,194,151,214,172,23,232,78,233,217,30,203,32,158,162,61,207,115,152,112,232,58,67,135,233,121,191,36,191,181,21,50,116,40,173,175,24,106,79,176,243,244,14,59,43,45,4,70,210,163,56,139,179,203,140,252,102,200,38,172,214,182,4,123,33,248,3,0,244,5,234,190,34,47,210,117,99,88,198,124,58,252,9,24,133,194,108,241,130,0,102,229,131,68,42,6,105,141,92,217,20,64,5,132,50,16,169,164,58,179,105,240,132,252,155,57,41,27,67,166,3,167,5,60,13,207,246,121,53,156,46,210,18,108,149,77,242,232,249,55,242,21,16,220,203,183,200,214,219,74,31,26,1,181,83,49,165,240,221,75,80,241,122,221,3,176,208,169,214,179,114,159,138,237,141,208,85,233,167,226,254,152,234,190,17,143,159,8,156,11,86,57,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("731044fc-827f-47a1-af08-e646f558fb9f"));
		}

		#endregion

	}

	#endregion

}

