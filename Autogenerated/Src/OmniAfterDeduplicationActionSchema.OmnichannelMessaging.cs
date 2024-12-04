namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmniAfterDeduplicationActionSchema

	/// <exclude/>
	public class OmniAfterDeduplicationActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmniAfterDeduplicationActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmniAfterDeduplicationActionSchema(OmniAfterDeduplicationActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a70187d1-6bbf-4710-ba7a-8c8f800e7324");
			Name = "OmniAfterDeduplicationAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,203,106,195,48,16,60,59,144,127,216,186,151,228,98,223,243,130,144,166,144,67,218,64,219,15,80,229,181,45,176,100,179,146,66,67,233,191,87,146,29,26,155,36,244,98,216,209,236,204,104,44,171,133,42,224,29,137,152,174,115,147,108,106,149,139,194,18,51,162,86,201,19,102,182,169,4,15,211,124,60,178,119,217,175,82,9,94,50,165,176,74,246,168,53,43,28,251,234,22,225,13,56,217,42,35,140,64,237,206,199,163,71,194,194,9,195,166,98,90,207,192,235,175,115,131,212,139,181,230,254,235,233,141,253,116,32,112,207,190,75,134,25,236,110,11,125,123,173,232,236,125,160,186,65,242,145,102,112,8,6,225,184,243,250,208,72,174,4,133,173,238,96,116,74,81,84,160,153,67,67,226,200,12,130,118,131,3,127,90,11,84,89,235,226,199,11,79,39,161,13,89,110,106,186,234,122,239,110,147,65,6,219,27,167,109,166,1,103,57,96,253,35,226,30,77,89,103,253,116,105,154,194,66,91,41,25,157,86,221,220,75,8,188,150,77,133,174,7,247,74,178,10,41,57,111,165,131,181,69,195,136,73,80,76,226,50,150,72,5,102,225,101,156,226,213,62,76,64,168,109,101,0,3,154,44,210,176,224,215,187,142,142,181,200,96,251,133,220,26,156,180,187,112,41,212,53,33,114,152,92,194,201,27,47,81,178,23,103,12,15,75,136,93,41,134,113,19,119,244,136,208,88,10,5,249,134,162,232,226,205,119,212,93,230,51,229,194,221,238,185,178,186,236,96,189,97,78,121,240,119,166,183,154,14,216,31,244,11,98,46,210,84,166,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a70187d1-6bbf-4710-ba7a-8c8f800e7324"));
		}

		#endregion

	}

	#endregion

}

