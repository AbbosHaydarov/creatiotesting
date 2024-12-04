namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoSchema

	/// <exclude/>
	public class ISysCultureInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoSchema(ISysCultureInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8");
			Name = "ISysCultureInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,81,77,107,195,48,12,61,59,144,255,32,232,61,185,119,99,151,28,70,46,163,176,178,187,103,203,153,33,145,131,108,195,202,216,127,159,26,175,37,99,148,146,139,177,159,222,135,37,145,158,48,206,218,32,28,145,89,199,224,82,211,5,114,126,200,172,147,15,212,28,89,83,28,151,123,93,125,213,149,202,209,211,0,175,167,152,112,122,168,43,65,118,140,131,148,161,167,132,236,196,108,15,189,212,187,60,166,204,216,147,11,11,109,206,239,163,55,224,47,172,255,36,37,254,114,94,13,15,28,102,228,228,49,238,225,176,168,75,189,109,91,120,140,121,154,52,159,158,46,64,249,17,152,98,8,222,34,37,239,60,114,115,149,180,107,205,115,246,22,122,11,231,158,148,26,48,73,51,74,125,111,72,32,139,159,55,204,165,73,25,135,212,55,216,175,38,13,38,140,121,34,32,89,207,141,132,152,248,188,135,149,168,91,52,47,34,217,16,250,134,44,67,50,27,83,215,170,123,177,191,146,62,118,31,154,6,180,247,248,59,36,91,246,191,188,11,250,23,20,236,7,48,204,186,108,185,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8"));
		}

		#endregion

	}

	#endregion

}

