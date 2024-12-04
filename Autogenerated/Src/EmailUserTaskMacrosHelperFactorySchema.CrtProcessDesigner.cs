namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskMacrosHelperFactorySchema

	/// <exclude/>
	public class EmailUserTaskMacrosHelperFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskMacrosHelperFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskMacrosHelperFactorySchema(EmailUserTaskMacrosHelperFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d18446c3-8f82-456b-8ac3-209c16faa243");
			Name = "EmailUserTaskMacrosHelperFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,82,203,110,194,48,16,60,27,137,127,216,170,151,32,161,124,0,136,3,165,180,229,64,133,10,253,0,227,44,193,106,98,71,246,166,20,85,252,123,237,132,132,4,40,234,169,23,43,251,152,153,221,201,42,158,162,205,184,64,88,161,49,220,234,13,133,19,109,48,92,24,45,208,90,23,168,141,140,115,195,73,106,213,237,124,119,59,44,183,82,197,176,220,91,194,116,88,199,77,124,3,82,17,61,162,149,177,66,227,0,14,114,111,48,118,69,152,36,220,218,1,76,83,46,147,119,139,102,197,237,199,156,11,163,237,11,38,25,154,39,46,72,155,125,129,201,242,117,34,5,88,114,188,2,132,71,254,1,200,220,196,238,173,21,231,72,91,29,57,205,69,65,87,22,219,212,179,43,172,110,139,79,25,161,129,103,164,166,78,224,225,140,21,136,21,166,89,194,9,43,36,228,199,143,62,248,148,179,69,161,240,158,20,133,83,216,3,239,42,99,107,173,19,95,26,71,169,84,111,50,222,146,133,81,77,18,46,81,69,165,206,62,67,184,27,65,32,21,245,90,217,112,156,147,246,191,132,49,187,147,36,182,16,4,15,58,218,87,147,249,158,94,77,120,81,57,206,193,4,183,8,231,213,176,181,227,160,236,100,6,41,55,10,20,238,224,170,7,45,175,42,229,90,136,177,51,99,202,117,79,137,126,163,239,194,150,70,226,216,118,24,222,90,224,120,137,55,86,88,148,29,191,94,213,255,109,16,225,134,231,9,85,51,210,214,232,93,49,226,171,166,153,155,31,83,84,132,209,244,75,96,230,101,130,94,9,60,248,215,61,197,201,187,211,40,175,190,136,203,108,59,121,248,1,49,122,11,178,0,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d18446c3-8f82-456b-8ac3-209c16faa243"));
		}

		#endregion

	}

	#endregion

}

