namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFailoverHandlerSchema

	/// <exclude/>
	public class IFailoverHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFailoverHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFailoverHandlerSchema(IFailoverHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99cf0342-6c2a-4b19-8aa0-db2b06c2b200");
			Name = "IFailoverHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0feb11c-442a-4bb5-a527-aa32bcda81de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,81,205,78,195,48,12,62,183,82,223,193,218,46,112,105,239,99,236,50,129,24,18,210,14,227,1,210,214,109,51,53,113,229,36,19,8,241,238,120,233,86,86,144,146,131,191,248,251,177,99,149,65,55,168,10,225,128,204,202,81,227,243,45,217,70,183,129,149,215,100,179,244,43,75,147,224,180,109,103,45,140,15,89,42,47,75,198,86,218,96,103,61,114,35,66,43,216,61,43,221,211,9,249,69,217,186,71,142,125,69,81,192,218,5,99,20,127,110,46,245,158,233,164,107,116,96,208,119,84,59,240,4,134,172,246,196,32,84,232,34,31,26,145,115,249,85,163,184,17,25,66,217,235,10,244,213,251,159,53,72,154,87,42,159,62,176,10,162,42,20,153,38,75,147,41,246,219,232,188,130,125,148,26,31,255,102,141,192,150,81,121,201,122,164,242,54,231,20,110,100,13,138,149,1,43,91,125,92,4,135,44,187,180,88,157,23,185,216,28,58,132,51,6,213,4,230,235,34,50,38,151,217,120,201,137,116,125,49,150,41,238,222,103,130,81,235,183,188,31,255,35,89,162,173,199,225,98,253,45,87,206,28,21,240,7,176,48,181,17,249,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99cf0342-6c2a-4b19-8aa0-db2b06c2b200"));
		}

		#endregion

	}

	#endregion

}

