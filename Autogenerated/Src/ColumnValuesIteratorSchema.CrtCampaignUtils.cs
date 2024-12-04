namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorSchema

	/// <exclude/>
	public class ColumnValuesIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorSchema(ColumnValuesIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f924bc20-2aaa-439a-84e8-9d39b2eb7fb7");
			Name = "ColumnValuesIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,75,79,227,48,16,62,167,82,255,195,168,92,194,37,185,47,109,37,84,16,170,180,72,171,101,181,119,227,76,82,75,142,29,217,78,217,46,234,127,103,236,196,33,64,27,224,18,37,227,121,124,143,113,20,171,209,54,140,35,252,65,99,152,213,165,203,54,90,149,162,106,13,115,66,171,108,195,234,134,137,74,217,249,236,121,62,75,90,43,84,5,15,7,235,176,166,76,41,145,251,52,155,221,161,66,35,248,213,124,70,89,23,6,43,138,194,70,50,107,127,0,229,181,181,250,203,100,139,118,235,144,58,107,19,242,242,60,135,165,109,235,154,153,195,186,255,238,18,208,194,227,129,206,16,129,27,44,87,139,83,61,110,37,214,168,220,34,95,103,177,89,62,234,214,180,143,82,112,224,30,196,25,12,9,113,162,231,0,248,151,209,13,26,39,144,80,211,187,35,118,88,116,41,239,177,134,64,143,192,2,31,164,128,82,27,16,29,9,15,235,35,174,164,137,157,225,167,176,110,57,65,109,253,58,225,25,42,116,87,96,253,227,8,43,80,248,244,121,121,122,217,25,146,92,160,42,58,142,111,9,147,217,214,153,150,83,141,167,28,20,155,224,123,131,37,107,165,35,186,67,25,60,237,4,223,129,80,194,9,38,197,127,236,201,211,201,171,40,231,132,232,28,58,197,32,189,4,191,111,73,178,165,198,129,70,146,28,167,185,220,163,219,233,226,139,206,109,7,188,197,216,60,93,2,70,197,71,219,23,93,232,87,109,210,211,189,48,174,101,18,246,90,20,97,204,64,37,118,201,174,139,34,245,254,141,137,223,160,165,11,20,16,17,249,142,240,199,138,123,198,141,14,5,191,177,145,116,113,167,114,201,41,17,10,236,201,138,47,203,249,217,86,144,222,28,233,142,33,163,69,232,229,131,210,232,250,123,18,230,62,210,48,195,106,80,244,95,90,45,104,203,28,254,115,139,53,109,169,127,9,87,139,132,246,195,252,111,40,58,149,45,243,80,54,222,169,160,126,15,44,61,181,96,177,103,63,36,122,68,35,2,141,116,207,204,192,69,168,225,30,198,188,164,63,203,226,140,216,167,51,131,180,61,39,112,23,125,27,60,190,0,236,112,243,128,137,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f924bc20-2aaa-439a-84e8-9d39b2eb7fb7"));
		}

		#endregion

	}

	#endregion

}

