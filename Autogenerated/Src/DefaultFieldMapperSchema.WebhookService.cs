namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultFieldMapperSchema

	/// <exclude/>
	public class DefaultFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultFieldMapperSchema(DefaultFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd14c32f-0ced-492a-9501-56c2b7f9064c");
			Name = "DefaultFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,209,106,194,48,20,125,110,193,127,184,184,23,5,105,223,93,21,134,115,67,152,219,96,131,61,167,205,173,205,150,38,37,73,21,25,254,251,110,154,41,237,16,246,114,67,206,61,231,220,147,92,197,106,180,13,43,16,222,209,24,102,117,233,146,149,86,165,216,181,134,57,161,213,40,254,30,197,81,107,133,218,193,219,209,58,172,169,47,37,22,190,105,147,71,84,104,68,113,59,138,137,117,99,112,71,40,172,36,179,118,14,247,88,178,86,186,7,129,146,111,89,211,160,233,88,105,154,66,38,84,69,58,199,117,1,133,193,114,49,222,244,104,227,116,73,188,166,205,165,160,182,55,187,226,5,115,232,107,72,64,65,169,94,82,108,209,85,154,83,142,215,206,40,52,255,31,158,208,209,93,109,136,113,206,177,215,130,195,165,55,217,172,85,91,163,97,185,196,204,58,67,223,179,132,3,230,149,214,95,129,49,131,39,97,93,246,17,48,250,179,182,86,36,95,66,237,199,240,64,154,130,255,221,40,42,181,65,86,84,48,9,86,3,39,16,106,232,124,22,69,123,102,188,219,75,254,73,235,128,5,40,60,192,223,121,103,110,180,86,78,184,99,192,159,105,235,196,239,187,206,126,105,3,253,21,94,160,157,104,225,254,236,191,37,185,227,124,114,137,51,13,140,147,175,84,186,197,160,226,97,55,221,61,160,67,144,176,31,72,99,10,66,146,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd14c32f-0ced-492a-9501-56c2b7f9064c"));
		}

		#endregion

	}

	#endregion

}

