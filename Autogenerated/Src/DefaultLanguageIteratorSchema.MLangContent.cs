namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultLanguageIteratorSchema

	/// <exclude/>
	public class DefaultLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultLanguageIteratorSchema(DefaultLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aeeb29af-e2e5-4dd2-b9f3-3255567cf2c9");
			Name = "DefaultLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,147,77,111,194,48,12,134,207,69,226,63,88,229,2,18,162,119,6,28,198,46,72,211,52,109,227,52,237,96,130,91,34,181,9,202,199,166,109,226,191,207,73,131,160,99,236,82,37,246,27,251,241,155,84,97,67,118,143,130,224,133,140,65,171,75,55,89,106,85,202,202,27,116,82,171,126,239,187,223,203,188,149,170,234,72,12,221,244,123,156,25,24,170,88,6,203,26,173,157,194,29,149,232,107,119,143,170,242,88,209,202,17,151,209,38,74,139,162,128,153,245,77,131,230,115,145,246,73,15,117,58,0,50,157,24,131,219,161,131,189,209,239,114,75,167,124,105,116,3,66,43,135,194,181,18,75,14,164,2,43,118,212,224,228,216,167,56,107,180,247,155,90,10,16,1,241,26,33,76,225,22,45,93,130,103,97,254,211,152,90,89,103,188,224,20,79,251,24,11,199,225,46,166,139,129,149,146,78,98,45,191,200,130,162,15,230,180,14,21,187,173,75,22,19,129,48,84,206,243,43,76,121,177,8,243,92,14,212,70,246,104,176,1,197,55,56,207,189,37,195,108,138,68,184,180,124,177,230,125,176,41,5,38,179,34,170,255,62,220,90,247,192,235,124,241,28,215,227,214,98,198,13,19,7,175,59,21,146,161,87,176,135,235,14,12,116,217,198,192,6,134,215,116,234,58,10,53,179,41,108,248,2,134,93,245,8,162,253,217,177,199,147,175,217,202,121,52,115,117,30,124,125,75,202,44,164,18,89,98,63,215,253,130,99,154,19,198,248,162,192,63,39,91,232,3,255,5,252,109,159,192,128,212,182,125,39,113,223,70,187,193,195,15,238,118,137,120,113,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aeeb29af-e2e5-4dd2-b9f3-3255567cf2c9"));
		}

		#endregion

	}

	#endregion

}

