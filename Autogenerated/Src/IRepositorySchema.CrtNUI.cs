namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRepositorySchema

	/// <exclude/>
	public class IRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRepositorySchema(IRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb47eba1-93f4-4a26-a75c-b68259fb6949");
			Name = "IRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,75,195,64,16,61,87,240,63,12,241,82,65,146,187,198,128,138,150,222,164,13,120,222,36,211,118,97,179,27,246,163,18,196,255,238,236,110,19,75,213,90,193,227,78,222,188,121,239,237,108,36,107,209,116,172,70,40,81,107,102,212,202,166,15,74,174,248,218,105,102,185,146,231,103,111,231,103,19,103,184,92,195,178,55,22,219,155,131,51,225,133,192,218,131,77,58,67,137,154,215,132,33,212,133,198,53,85,97,46,45,234,21,13,185,134,249,2,59,101,184,85,186,15,144,44,203,32,55,174,109,153,238,139,221,185,196,182,19,204,98,3,122,4,131,85,192,42,99,53,171,45,24,170,176,53,166,67,127,118,64,144,219,190,195,142,105,214,130,36,127,183,73,153,20,75,234,33,70,148,150,91,98,35,64,154,103,35,206,119,118,174,18,188,6,62,136,221,215,154,151,5,188,110,80,83,76,112,13,247,204,160,231,99,149,192,199,64,72,237,62,166,47,118,66,97,129,214,105,105,134,217,85,15,188,241,218,191,138,143,149,125,229,188,73,138,56,194,55,229,217,168,54,66,117,164,222,65,232,251,80,240,136,18,158,184,108,166,51,199,27,106,190,140,119,242,189,196,7,141,20,248,40,145,203,33,99,96,210,95,67,52,192,173,249,131,244,200,149,20,129,219,175,75,44,252,102,34,250,220,247,17,12,68,133,211,114,199,114,212,205,2,91,181,197,255,14,124,171,72,70,164,62,37,211,201,18,153,174,55,36,131,211,35,49,94,69,71,27,200,107,178,145,194,137,106,134,142,208,149,20,207,35,193,143,33,46,195,84,186,50,227,132,61,8,114,254,40,93,139,97,109,253,66,191,248,133,158,62,57,89,231,229,21,84,74,137,98,148,24,166,252,18,242,231,86,211,187,216,123,147,63,25,27,37,238,86,43,228,114,92,226,12,237,157,16,83,47,100,242,30,255,41,40,155,248,91,241,199,247,15,183,89,138,218,192,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb47eba1-93f4-4a26-a75c-b68259fb6949"));
		}

		#endregion

	}

	#endregion

}

