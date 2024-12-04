namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenericErrorSchema

	/// <exclude/>
	public class GenericErrorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenericErrorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenericErrorSchema(GenericErrorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("65750127-9831-4494-b88e-c337e322ffc7");
			Name = "GenericError";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,193,106,195,48,12,61,39,144,127,16,244,210,193,232,7,164,236,148,149,209,211,118,217,7,56,142,8,134,204,54,178,178,75,201,191,79,78,92,146,52,41,236,98,144,222,123,242,147,158,85,63,24,188,210,8,21,113,213,185,190,185,90,198,150,20,27,103,79,223,108,58,195,6,195,233,66,228,40,20,249,173,200,179,3,97,43,40,84,157,10,161,132,15,180,72,70,143,140,34,23,220,247,117,103,52,168,58,48,41,205,160,35,111,69,131,18,174,137,159,201,68,121,231,161,206,138,172,215,44,223,149,240,69,142,81,51,54,19,201,223,203,213,180,163,8,140,109,1,99,81,185,6,95,33,117,26,12,154,140,143,187,188,64,180,158,101,151,59,9,222,102,193,121,132,222,103,182,128,11,237,8,15,201,39,218,102,178,186,246,45,78,61,82,188,149,184,30,15,144,44,79,199,72,134,230,223,111,208,34,159,193,147,249,85,140,16,98,49,108,5,75,79,79,36,91,87,210,153,250,15,102,15,244,52,184,79,139,115,114,219,192,4,150,204,214,73,199,228,246,115,91,109,254,48,230,159,97,149,80,171,128,199,5,107,155,229,126,34,123,155,15,127,16,210,84,122,231,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65750127-9831-4494-b88e-c337e322ffc7"));
		}

		#endregion

	}

	#endregion

}

