namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCommandResultSchema

	/// <exclude/>
	public class BaseCommandResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCommandResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCommandResultSchema(BaseCommandResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2b8d1ca-42bf-4559-aeb0-b421b90c0d74");
			Name = "BaseCommandResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,80,205,110,194,48,12,62,23,137,119,136,224,2,151,62,0,19,151,177,43,19,106,123,155,166,201,164,166,138,212,36,149,227,148,177,137,119,159,155,150,49,180,75,229,248,251,117,29,88,12,29,104,84,21,18,65,240,39,206,119,222,157,76,19,9,216,120,151,151,94,27,104,231,179,239,249,44,139,193,184,70,149,151,192,104,243,34,58,54,22,243,18,73,8,230,43,209,159,230,51,225,45,9,27,121,168,93,11,33,108,212,51,4,220,121,107,193,213,5,134,216,114,34,189,189,0,131,100,49,129,230,119,89,116,241,216,26,173,244,32,250,175,81,27,245,80,76,98,123,163,81,192,206,187,128,162,151,134,242,253,13,63,144,239,144,216,160,52,56,36,235,17,79,185,123,180,71,164,213,171,156,175,182,106,193,248,201,139,245,80,226,214,34,48,13,183,86,2,168,225,244,44,107,144,229,58,25,194,52,92,71,191,142,76,15,140,170,190,56,176,162,252,32,56,39,124,114,186,237,11,56,223,157,166,41,35,228,72,238,174,25,76,199,136,27,99,128,164,98,15,109,196,145,146,165,82,219,36,202,43,95,166,166,171,245,31,253,212,108,137,174,30,127,70,122,143,219,199,229,245,7,97,172,35,147,1,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2b8d1ca-42bf-4559-aeb0-b421b90c0d74"));
		}

		#endregion

	}

	#endregion

}

