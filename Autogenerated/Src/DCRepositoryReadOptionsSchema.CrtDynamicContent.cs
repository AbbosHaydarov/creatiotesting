namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCRepositoryReadOptionsSchema

	/// <exclude/>
	public class DCRepositoryReadOptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCRepositoryReadOptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCRepositoryReadOptionsSchema(DCRepositoryReadOptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1294a92-73db-463a-b908-32d204d88db2");
			Name = "DCRepositoryReadOptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,207,110,194,48,12,198,207,84,226,29,172,114,157,90,149,227,40,189,192,117,27,66,125,1,175,184,37,82,154,68,73,186,169,66,188,251,220,127,32,80,145,118,137,20,219,95,252,249,23,43,172,201,25,44,8,114,178,22,157,46,125,180,211,170,20,85,99,209,11,173,162,125,171,176,22,5,7,61,41,191,12,46,203,96,209,56,161,170,127,42,162,15,125,34,233,54,203,128,133,43,75,21,151,192,78,162,115,239,176,223,29,201,104,39,188,182,237,145,240,244,101,186,7,92,95,26,199,49,164,174,169,107,180,109,54,222,239,213,160,135,82,40,181,5,203,82,7,158,106,35,209,83,52,137,227,39,117,234,91,67,6,45,214,192,6,105,27,230,73,152,229,163,10,138,206,82,148,198,183,162,215,178,117,152,177,19,41,10,156,87,153,230,155,147,67,238,213,140,105,158,188,65,190,206,224,247,76,150,233,39,29,141,201,76,143,108,202,172,71,78,93,191,62,193,29,248,19,248,188,225,60,88,109,200,122,65,204,244,208,55,31,242,207,12,23,93,96,52,0,165,196,106,150,31,236,169,196,70,122,248,65,217,16,8,199,111,16,3,178,84,110,195,187,201,251,48,209,167,86,20,198,183,14,15,228,39,26,115,66,94,161,231,144,131,11,84,228,55,224,186,227,10,219,89,97,223,113,88,169,197,138,212,105,224,208,223,175,195,162,61,4,175,127,94,232,137,73,231,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1294a92-73db-463a-b908-32d204d88db2"));
		}

		#endregion

	}

	#endregion

}

