namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RequestTokenExceptionSchema

	/// <exclude/>
	public class RequestTokenExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RequestTokenExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RequestTokenExceptionSchema(RequestTokenExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7333162c-1720-409d-8f39-077934931a56");
			Name = "RequestTokenException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,82,77,107,194,64,16,61,71,240,63,12,122,81,144,252,0,197,30,26,60,244,80,144,234,173,244,176,38,99,88,186,153,77,103,54,109,173,248,223,187,235,174,86,196,131,244,144,192,124,188,247,230,61,150,84,131,210,170,18,97,141,204,74,236,214,229,133,165,173,174,59,86,78,91,202,31,219,198,146,209,132,133,177,93,245,68,14,235,56,233,247,246,253,94,214,137,166,26,86,59,113,216,204,250,61,223,25,50,214,126,12,133,81,34,83,120,193,143,14,197,173,237,59,210,226,187,196,54,98,253,226,235,10,89,43,163,127,212,198,224,104,252,230,91,109,183,49,186,132,50,64,111,35,97,10,23,44,89,56,33,11,223,89,213,146,56,238,74,103,217,139,47,143,124,71,181,19,247,77,214,209,24,142,76,135,59,86,61,125,176,236,115,19,85,227,216,31,180,81,130,163,115,253,79,162,201,159,47,208,68,200,231,242,90,98,2,215,243,125,22,67,72,170,67,164,42,198,145,234,148,205,146,109,139,236,52,222,78,198,126,250,39,160,43,132,116,216,115,148,131,249,3,12,10,163,145,28,184,224,0,56,218,129,47,37,192,74,11,86,160,8,60,216,114,62,136,143,224,196,153,168,22,97,86,88,207,189,135,26,221,12,36,252,14,48,79,11,249,162,105,221,46,65,47,207,15,150,130,181,203,222,225,23,189,192,215,43,181,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7333162c-1720-409d-8f39-077934931a56"));
		}

		#endregion

	}

	#endregion

}

