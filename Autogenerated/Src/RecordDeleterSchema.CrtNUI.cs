namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordDeleterSchema

	/// <exclude/>
	public class RecordDeleterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordDeleterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordDeleterSchema(RecordDeleterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a61c9bf9-deb2-46d9-9e0b-bc4b5a27b8cc");
			Name = "RecordDeleter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,221,110,194,48,12,133,175,131,196,59,88,236,166,72,168,15,192,126,46,248,217,52,105,108,8,54,237,58,164,166,205,84,146,202,73,17,104,226,221,231,38,140,181,147,184,169,90,31,251,243,241,169,145,59,116,149,84,8,239,72,36,157,221,250,116,106,205,86,231,53,73,175,173,129,239,126,79,212,78,155,28,214,71,231,113,199,114,89,162,106,52,151,62,161,65,210,234,246,210,211,166,16,94,171,167,179,9,75,44,222,16,230,205,146,105,41,157,27,195,10,149,165,108,134,37,122,164,208,80,213,155,82,43,80,141,222,149,97,12,19,233,48,214,230,7,84,181,183,60,35,216,47,63,255,200,108,211,83,173,88,228,5,203,128,139,29,103,116,7,154,124,56,36,30,49,241,64,168,59,159,35,120,158,233,240,38,233,120,199,88,190,108,4,118,243,197,242,3,84,146,56,76,134,184,97,131,23,98,12,27,54,152,252,103,180,250,66,184,66,68,11,43,157,23,254,173,194,115,238,247,176,86,5,238,100,75,124,193,61,150,46,157,74,19,237,54,241,242,116,35,205,15,10,171,102,110,129,206,201,28,121,124,48,55,94,251,99,164,164,151,134,244,213,134,137,71,75,105,196,12,2,231,116,206,13,77,22,163,235,230,184,64,95,216,172,21,161,16,33,68,178,158,15,195,12,236,158,127,177,206,16,246,86,103,16,201,151,107,146,223,83,163,167,243,226,79,237,11,62,70,97,185,36,171,216,120,50,188,102,37,108,139,245,78,185,223,59,253,0,101,129,157,100,195,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a61c9bf9-deb2-46d9-9e0b-bc4b5a27b8cc"));
		}

		#endregion

	}

	#endregion

}

