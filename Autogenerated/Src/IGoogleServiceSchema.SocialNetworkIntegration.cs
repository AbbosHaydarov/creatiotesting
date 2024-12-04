namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGoogleServiceSchema

	/// <exclude/>
	public class IGoogleServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGoogleServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGoogleServiceSchema(IGoogleServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("956a9445-e36a-4d6f-9741-e5836ee6b58c");
			Name = "IGoogleService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,77,107,194,64,16,61,71,240,63,12,122,81,144,228,110,173,208,10,149,20,172,210,8,30,196,195,154,76,226,210,100,55,221,221,8,161,248,223,59,217,53,162,253,240,178,48,111,222,188,153,55,179,130,21,168,75,22,35,172,81,41,166,101,106,252,153,20,41,207,42,197,12,151,194,143,100,204,89,222,237,124,117,59,94,165,185,200,32,170,181,193,194,143,80,29,121,140,11,153,96,254,112,47,233,63,197,134,31,173,218,125,222,6,247,68,32,74,95,97,70,108,8,133,65,149,210,116,99,8,231,82,102,57,158,249,150,181,61,7,52,175,81,44,54,131,55,50,3,143,208,187,161,246,134,59,226,150,213,62,231,49,240,86,240,151,158,71,254,232,189,180,94,160,57,200,68,143,97,101,43,93,50,8,2,152,232,170,40,152,170,167,45,240,142,166,82,66,67,44,5,165,80,81,147,84,170,194,250,5,182,151,149,129,204,246,2,125,96,10,19,96,101,73,138,110,187,23,213,224,167,236,68,57,221,233,236,15,93,127,18,180,233,134,191,93,150,232,206,213,238,162,241,236,109,105,161,161,56,202,15,28,56,59,205,114,86,203,104,221,27,209,212,159,21,106,243,98,21,9,39,234,2,181,102,25,58,200,127,213,82,140,224,89,38,117,100,106,26,254,154,114,65,253,141,34,55,152,52,122,186,164,65,207,213,255,9,218,91,120,110,245,173,175,144,108,181,213,48,71,115,141,15,134,238,67,120,125,20,137,187,140,141,79,238,155,220,128,167,111,9,13,135,131,204,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("956a9445-e36a-4d6f-9741-e5836ee6b58c"));
		}

		#endregion

	}

	#endregion

}

