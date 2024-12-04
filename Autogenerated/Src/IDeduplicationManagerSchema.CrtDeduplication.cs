namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationManagerSchema

	/// <exclude/>
	public class IDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationManagerSchema(IDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3e391f5-bea4-4635-974c-b28b77b1e29d");
			Name = "IDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,83,193,110,131,48,12,61,83,169,255,96,117,151,77,154,224,222,50,46,99,157,122,168,52,181,251,129,20,12,139,68,2,115,146,73,213,212,127,159,9,208,142,110,213,122,216,5,176,253,158,253,252,72,180,80,104,26,145,33,188,34,145,48,117,97,195,199,90,23,178,116,36,172,172,117,152,98,238,154,74,102,62,154,78,62,167,147,192,25,169,75,216,238,141,69,181,56,139,153,93,85,152,181,96,19,62,163,70,146,25,99,24,117,67,88,114,22,86,218,34,21,60,114,14,171,81,243,181,208,162,68,242,224,40,138,32,54,78,41,65,251,164,143,71,96,80,29,58,28,192,209,55,116,227,118,140,3,57,76,186,52,40,224,109,248,121,148,182,70,251,86,231,102,14,47,190,65,87,60,151,226,19,75,169,115,3,67,79,52,192,108,35,62,176,149,243,83,79,151,105,4,9,5,154,29,127,152,21,204,79,143,236,13,190,59,52,118,150,244,31,97,28,121,240,137,75,104,29,105,147,156,56,144,29,141,102,248,80,111,9,171,39,237,20,146,216,85,24,167,210,35,88,71,108,44,241,111,186,135,238,157,36,126,135,83,191,219,113,216,43,129,95,133,222,45,254,180,198,72,37,43,65,64,152,213,196,113,65,181,226,209,53,97,14,168,173,180,251,107,173,162,171,205,217,246,51,125,127,249,95,22,245,93,55,221,34,75,222,99,235,215,240,134,93,42,14,246,245,226,91,195,130,192,31,53,212,121,119,218,188,133,135,238,106,140,146,135,47,23,195,156,8,149,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3e391f5-bea4-4635-974c-b28b77b1e29d"));
		}

		#endregion

	}

	#endregion

}

