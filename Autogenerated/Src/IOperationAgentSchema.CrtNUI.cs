namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOperationAgentSchema

	/// <exclude/>
	public class IOperationAgentSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOperationAgentSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOperationAgentSchema(IOperationAgentSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("125ee0b8-83aa-4709-82ef-794af080f041");
			Name = "IOperationAgent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,148,207,110,194,48,12,198,207,67,218,59,88,236,194,164,137,222,129,85,154,16,66,61,176,77,251,243,0,161,113,75,164,54,233,156,4,49,77,123,247,57,45,173,70,25,140,83,91,231,251,236,159,99,171,90,148,104,43,145,34,188,33,145,176,38,115,227,185,209,153,202,61,9,167,140,134,235,193,215,245,224,202,91,165,115,120,253,180,14,203,105,239,155,13,69,129,105,80,219,241,18,53,146,74,89,195,170,27,194,60,228,72,180,67,202,184,202,4,146,167,10,155,204,15,57,106,87,203,162,40,130,153,245,101,41,232,51,222,127,119,22,48,25,184,13,63,90,31,136,96,28,183,190,232,151,177,242,235,66,165,160,58,111,175,26,112,43,44,235,184,158,41,100,117,10,237,4,158,27,111,35,232,19,213,129,23,116,158,180,5,71,30,65,101,80,26,66,16,91,161,10,177,46,48,0,29,19,93,173,141,41,96,197,202,135,173,40,84,16,194,23,228,232,166,240,29,142,107,26,212,178,1,58,164,91,161,219,24,217,161,93,64,166,113,231,32,237,166,209,94,157,215,234,35,32,75,190,2,149,41,36,123,2,182,142,80,147,44,158,95,146,103,22,181,242,224,79,22,218,151,124,225,220,229,108,233,149,140,97,137,238,145,161,18,94,19,59,186,157,158,233,225,189,146,194,161,229,225,101,134,74,241,187,46,97,106,72,158,99,174,4,137,18,52,47,243,253,176,81,39,114,24,191,247,121,25,183,86,254,109,196,93,138,85,168,59,140,23,237,235,129,99,107,148,220,115,190,52,69,152,117,20,26,221,35,38,242,14,58,43,116,249,206,246,253,138,206,254,63,179,84,56,67,188,122,166,62,228,19,127,106,225,78,222,135,29,94,58,210,94,199,11,93,215,27,29,79,183,75,29,58,252,115,153,121,201,195,127,224,32,88,199,126,0,31,102,114,116,121,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("125ee0b8-83aa-4709-82ef-794af080f041"));
		}

		#endregion

	}

	#endregion

}

