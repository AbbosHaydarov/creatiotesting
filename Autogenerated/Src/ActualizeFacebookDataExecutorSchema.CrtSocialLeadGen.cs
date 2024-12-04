namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualizeFacebookDataExecutorSchema

	/// <exclude/>
	public class ActualizeFacebookDataExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualizeFacebookDataExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualizeFacebookDataExecutorSchema(ActualizeFacebookDataExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("51b4a1a5-af97-48c5-87ce-ae38f382ae8f");
			Name = "ActualizeFacebookDataExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c2a63f41-8805-4b8b-b1f1-2cbca683addf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,95,79,194,48,16,127,30,137,223,225,50,94,32,49,251,0,51,60,24,4,67,34,209,4,140,143,166,235,142,81,237,218,229,218,33,104,248,238,94,55,6,162,70,95,110,189,235,221,239,207,117,70,148,232,42,33,17,150,72,36,156,93,249,100,108,205,74,21,53,9,175,172,185,232,125,92,244,162,218,41,83,192,98,231,60,150,87,199,252,235,8,225,169,94,104,155,9,157,166,99,91,150,214,36,119,182,40,184,204,247,220,209,39,44,24,22,198,90,56,151,194,181,244,181,208,234,29,167,172,33,179,246,245,70,120,49,217,162,172,189,165,102,160,170,51,173,36,200,208,255,119,59,164,48,155,25,231,133,214,11,73,170,242,39,156,136,77,112,60,178,79,21,234,156,233,31,72,109,132,199,246,178,106,19,96,4,207,140,132,34,183,70,239,96,198,6,224,89,115,24,1,31,231,194,136,2,41,185,69,31,156,33,13,226,39,204,150,246,62,123,65,233,227,97,235,51,234,163,201,91,182,115,234,57,250,181,109,184,27,99,7,234,214,228,198,170,28,90,213,56,120,116,72,252,20,134,65,195,92,125,150,14,33,60,75,20,121,218,29,78,209,70,16,96,183,138,17,24,124,251,185,46,22,58,181,84,186,110,51,131,160,54,12,119,131,73,199,254,141,174,109,219,131,20,94,174,97,48,217,74,172,26,89,184,237,164,68,97,69,201,132,136,97,227,230,3,124,79,181,49,225,159,248,87,74,124,25,176,14,60,33,114,248,101,143,109,245,188,184,255,4,19,142,68,228,198,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51b4a1a5-af97-48c5-87ce-ae38f382ae8f"));
		}

		#endregion

	}

	#endregion

}

