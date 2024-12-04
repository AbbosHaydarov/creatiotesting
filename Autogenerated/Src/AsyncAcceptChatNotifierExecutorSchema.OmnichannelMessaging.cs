namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncAcceptChatNotifierExecutorSchema

	/// <exclude/>
	public class AsyncAcceptChatNotifierExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncAcceptChatNotifierExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncAcceptChatNotifierExecutorSchema(AsyncAcceptChatNotifierExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de6fad3b-1ad3-c490-fb1b-04c758b887d2");
			Name = "AsyncAcceptChatNotifierExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,83,201,138,219,64,16,61,107,96,254,161,80,14,145,193,200,247,196,54,24,199,12,14,153,133,36,206,189,45,149,237,14,82,181,232,197,51,34,204,191,167,186,181,79,38,23,209,181,189,87,203,19,137,18,77,37,50,132,159,168,181,48,234,100,211,173,162,147,60,59,45,172,84,148,62,150,36,179,139,32,194,34,189,71,99,196,89,210,249,246,230,207,237,77,228,12,63,225,71,109,44,150,159,223,216,140,82,20,152,121,8,147,222,33,161,150,217,144,51,38,43,75,69,239,71,52,178,159,35,31,52,158,25,7,182,133,48,6,62,193,198,212,148,109,178,12,43,187,189,8,251,160,172,60,73,212,33,119,177,88,192,210,184,178,20,186,94,183,246,119,172,52,26,36,107,64,16,8,95,125,209,138,148,51,192,147,89,160,22,32,237,234,23,35,128,202,29,11,153,65,22,184,255,195,188,123,193,204,89,165,185,183,253,87,117,236,76,174,230,53,241,183,159,224,30,237,69,229,126,134,167,0,219,68,223,246,28,28,45,182,1,85,33,159,66,105,110,254,168,156,13,45,115,227,202,145,157,204,82,212,190,255,127,7,104,60,149,208,162,4,226,115,175,98,103,80,243,145,169,57,79,188,62,176,205,128,157,35,93,46,66,246,251,197,225,141,22,181,137,215,79,253,123,82,211,174,236,42,181,117,162,128,171,146,57,52,59,193,228,48,225,134,105,43,115,216,127,145,225,197,189,47,141,213,172,136,57,168,227,111,14,175,97,96,158,129,151,95,20,201,19,36,131,23,86,43,32,87,20,93,52,178,188,153,103,32,124,134,141,62,187,146,5,240,192,225,71,189,43,43,91,239,94,252,21,153,42,25,141,4,153,160,143,22,142,24,128,226,153,215,101,20,189,134,239,55,105,236,242,206,201,124,61,58,201,106,212,21,203,220,254,18,133,195,36,238,19,226,121,224,31,106,147,89,11,122,21,186,23,30,195,248,44,47,169,199,182,178,147,86,50,221,80,91,124,226,127,67,100,23,72,60,74,71,182,207,65,210,208,91,191,134,94,222,7,226,170,220,179,152,173,151,79,224,168,147,161,126,60,47,127,130,114,145,242,70,188,193,110,188,83,231,235,95,157,250,151,138,69,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de6fad3b-1ad3-c490-fb1b-04c758b887d2"));
		}

		#endregion

	}

	#endregion

}

