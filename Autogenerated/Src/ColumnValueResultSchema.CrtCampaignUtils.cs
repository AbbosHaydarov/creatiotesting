namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValueResultSchema

	/// <exclude/>
	public class ColumnValueResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValueResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValueResultSchema(ColumnValueResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3673988a-b579-40b7-b4e0-255d21d4b2d7");
			Name = "ColumnValueResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,147,201,78,195,48,16,134,207,169,212,119,24,133,11,92,154,59,93,46,81,133,122,171,128,114,119,157,73,48,74,108,227,165,80,170,190,59,94,146,134,110,192,197,138,199,51,243,127,243,219,225,164,65,45,9,69,120,70,165,136,22,165,25,229,130,151,172,178,138,24,38,248,40,39,141,36,172,226,122,56,216,13,7,137,213,140,87,240,180,213,6,155,241,112,224,34,55,10,43,151,8,121,77,180,190,135,92,212,182,225,47,164,182,248,136,218,214,38,36,101,89,6,19,109,155,134,168,237,172,221,199,99,16,37,208,80,3,27,95,4,140,27,84,82,161,91,161,20,10,188,96,141,109,206,168,235,149,253,104,38,237,186,102,20,168,7,184,164,159,56,112,183,246,164,130,107,163,44,53,66,57,224,101,168,142,25,167,152,33,176,224,204,48,82,179,47,116,103,232,72,20,150,211,244,76,39,205,102,142,93,27,194,41,122,204,115,206,24,145,68,145,6,184,51,126,154,198,161,86,139,34,157,173,56,123,247,211,23,200,13,43,153,27,222,25,99,94,15,131,79,178,80,24,250,180,3,159,33,220,62,88,86,192,161,233,29,248,27,75,146,188,11,192,180,63,116,151,151,36,251,214,24,228,69,244,230,216,168,165,18,18,149,97,248,31,155,230,142,219,108,187,187,116,10,87,76,104,225,3,106,79,182,131,10,205,24,164,98,27,98,16,180,223,180,116,23,213,98,101,124,50,191,11,137,245,27,82,3,193,166,78,230,207,246,110,114,138,58,188,117,252,164,40,253,175,0,204,95,136,18,31,225,21,94,23,156,31,10,250,175,11,186,39,166,199,232,113,112,255,13,49,172,232,101,159,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3673988a-b579-40b7-b4e0-255d21d4b2d7"));
		}

		#endregion

	}

	#endregion

}

