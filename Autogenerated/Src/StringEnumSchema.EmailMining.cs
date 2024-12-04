namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringEnumSchema

	/// <exclude/>
	public class StringEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringEnumSchema(StringEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d732c7c-0f8d-47a1-85af-96c11b6df501");
			Name = "StringEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,147,61,111,219,64,12,134,103,25,240,127,32,220,197,25,98,237,173,109,160,13,82,160,67,128,160,245,94,176,18,101,31,160,187,19,120,148,11,183,232,127,47,125,39,201,82,18,123,202,36,136,159,47,31,242,28,90,10,13,22,4,59,98,198,224,43,89,61,120,87,153,125,203,40,198,187,213,163,69,83,63,25,103,220,126,62,251,59,159,205,103,217,7,166,189,186,224,161,198,16,62,194,15,97,117,62,186,214,70,111,158,231,176,14,173,181,200,167,109,247,255,5,3,65,113,14,135,202,51,132,152,1,114,106,232,62,96,69,247,164,201,208,160,8,177,75,113,20,86,125,173,124,84,172,105,127,213,166,232,74,141,27,103,73,218,160,237,171,161,186,84,113,207,108,142,40,148,156,47,165,69,195,238,64,112,196,186,165,115,195,215,29,179,38,85,0,38,44,189,171,79,189,250,159,49,233,83,215,150,92,153,58,79,101,40,75,13,111,11,241,28,197,120,161,66,168,188,33,231,155,51,98,176,54,127,40,0,130,163,223,96,180,4,58,93,145,175,64,84,236,58,144,194,100,170,54,139,11,129,69,190,77,84,174,76,17,45,13,50,90,112,186,243,205,34,170,95,108,47,211,175,243,232,238,102,238,132,142,24,47,187,185,99,244,29,40,239,44,203,18,4,216,64,15,35,203,254,221,38,242,68,114,240,113,51,113,149,55,72,60,19,235,177,88,197,224,192,216,70,131,141,64,225,221,145,56,156,43,85,236,237,117,24,226,39,190,83,16,178,171,20,162,238,119,161,20,163,153,164,101,23,38,231,196,20,218,90,250,125,93,36,143,186,142,211,186,163,214,45,139,126,134,81,125,67,250,6,135,231,178,188,204,55,221,65,42,213,233,219,249,20,182,188,27,47,227,77,190,223,147,4,189,178,171,160,224,12,242,128,162,19,53,58,20,57,9,250,111,194,112,147,183,56,190,36,243,249,125,250,188,65,206,43,95,54,37,245,79,243,2,97,138,104,120,178,215,174,52,89,167,70,181,253,7,185,104,1,177,38,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d732c7c-0f8d-47a1-85af-96c11b6df501"));
		}

		#endregion

	}

	#endregion

}

