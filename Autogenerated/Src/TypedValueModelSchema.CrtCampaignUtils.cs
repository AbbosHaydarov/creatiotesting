namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TypedValueModelSchema

	/// <exclude/>
	public class TypedValueModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TypedValueModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TypedValueModelSchema(TypedValueModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e563da35-a0e4-4fae-aeed-9e1cbe43a1ed");
			Name = "TypedValueModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,144,65,107,195,48,12,133,207,13,228,63,8,122,79,238,235,216,37,189,22,122,40,189,43,142,146,121,196,118,144,236,65,40,251,239,179,157,100,172,235,232,69,32,233,249,189,207,178,104,72,38,84,4,23,98,70,113,189,175,26,103,123,61,4,70,175,157,173,26,52,19,234,193,74,89,220,202,98,23,68,219,225,78,204,116,40,139,184,217,51,13,241,1,52,35,138,188,192,101,158,168,187,226,24,232,228,58,26,179,164,174,107,120,149,96,12,242,252,182,246,71,18,197,186,37,1,147,116,208,59,6,181,102,2,89,175,253,12,162,222,201,32,24,84,236,224,51,121,86,155,91,253,203,110,10,237,168,21,168,4,240,152,191,139,248,177,254,112,158,217,77,196,94,83,132,61,231,151,203,254,47,100,30,100,35,112,253,83,180,4,245,72,181,97,185,246,131,148,95,157,110,48,144,63,128,164,242,245,36,247,148,124,101,11,83,110,12,198,66,135,30,151,51,128,143,191,124,30,123,140,226,156,153,14,146,175,242,95,248,158,108,183,220,37,247,203,244,126,24,103,223,227,77,157,246,46,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e563da35-a0e4-4fae-aeed-9e1cbe43a1ed"));
		}

		#endregion

	}

	#endregion

}

