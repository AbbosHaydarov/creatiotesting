namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorContextSchema

	/// <exclude/>
	public class ColumnValuesIteratorContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorContextSchema(ColumnValuesIteratorContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c11e73b-d8b2-4159-8639-b9b25cb1fe29");
			Name = "ColumnValuesIteratorContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,77,79,227,64,12,134,207,32,241,31,44,184,44,210,42,185,211,146,75,87,66,72,139,64,192,238,97,111,211,137,19,70,154,143,104,60,67,41,168,255,29,103,166,13,41,148,170,123,73,226,201,107,231,121,109,199,10,131,212,9,137,240,136,222,11,114,77,40,102,206,54,170,141,94,4,229,108,49,19,166,19,170,181,116,114,252,118,114,124,20,73,217,22,30,150,20,208,76,62,197,156,169,53,202,62,141,138,43,180,232,149,252,208,140,63,224,113,168,203,2,150,156,121,108,57,13,102,90,16,93,0,23,138,198,254,21,58,34,93,7,100,20,231,25,43,224,75,72,242,178,44,97,74,209,24,225,151,213,58,94,191,135,197,147,146,79,32,57,18,202,18,40,219,197,0,157,240,236,148,43,17,52,206,115,46,34,72,143,205,229,233,174,79,157,150,21,8,91,131,71,138,58,112,138,119,6,80,112,89,212,104,208,134,98,195,80,142,32,186,56,215,74,130,236,45,236,119,112,196,157,228,235,224,250,206,187,14,125,80,200,214,239,82,149,252,254,179,205,236,115,221,56,8,202,32,188,58,139,61,205,87,156,13,207,35,203,254,177,234,218,54,110,8,110,155,134,48,192,27,180,24,38,192,143,19,88,193,229,150,182,248,19,250,233,125,207,49,12,27,92,3,70,72,239,8,140,171,81,211,126,160,223,138,194,244,166,215,167,246,220,244,41,21,164,3,202,13,219,112,245,72,22,23,187,51,126,156,31,78,39,211,52,224,57,87,207,27,178,80,90,195,28,121,65,136,123,143,53,63,0,143,86,133,229,1,248,163,241,86,91,179,222,137,62,27,169,255,7,123,216,63,94,217,188,126,137,111,109,103,63,230,47,149,202,240,233,244,42,170,250,231,152,242,62,213,173,32,223,191,48,31,144,58,184,56,67,91,231,45,78,241,42,255,205,91,135,171,119,110,124,156,29,101,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c11e73b-d8b2-4159-8639-b9b25cb1fe29"));
		}

		#endregion

	}

	#endregion

}

