namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationConstsSchema

	/// <exclude/>
	public class DeduplicationConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationConstsSchema(DeduplicationConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f63d953-bd1e-490d-81f5-9a26e360c7c0");
			Name = "DeduplicationConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,203,78,195,48,16,69,215,173,212,127,24,149,13,44,220,60,154,54,9,47,137,154,8,177,64,44,202,15,56,241,36,88,106,156,200,118,132,42,196,191,99,187,173,40,84,44,96,101,205,227,222,123,100,141,100,45,234,158,85,8,47,168,20,211,93,109,102,180,147,181,104,6,197,140,232,36,188,79,198,163,65,11,217,192,122,171,13,182,87,147,177,237,156,41,108,220,148,110,152,214,151,112,143,124,40,55,162,242,18,171,215,70,251,181,32,8,224,90,15,109,203,212,246,118,95,219,177,97,66,106,168,220,30,147,70,67,173,186,214,149,71,177,92,84,238,101,74,160,158,29,156,130,35,171,222,7,130,117,48,246,169,28,135,199,232,191,99,56,126,187,125,66,226,27,95,251,8,93,143,251,104,2,107,100,170,122,117,177,167,185,63,130,21,50,222,201,205,22,30,6,193,247,194,231,131,213,35,135,27,144,248,230,135,231,211,34,74,231,105,72,41,161,203,34,35,73,148,196,228,174,88,229,36,91,197,69,180,88,209,48,163,217,244,194,126,240,104,244,103,228,39,84,13,254,131,216,235,126,3,78,114,30,46,243,56,38,139,144,33,73,120,206,73,201,121,73,162,100,201,231,49,171,163,50,77,61,176,77,249,216,221,5,74,190,59,13,87,218,222,39,173,154,96,89,97,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f63d953-bd1e-490d-81f5-9a26e360c7c0"));
		}

		#endregion

	}

	#endregion

}

