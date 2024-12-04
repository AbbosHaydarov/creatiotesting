namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandParameterSchema

	/// <exclude/>
	public class FacebookCommandParameterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandParameterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandParameterSchema(FacebookCommandParameterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55eedac6-1832-49bb-ada6-3ce9df23cd0c");
			Name = "FacebookCommandParameter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,142,61,10,131,64,16,133,107,5,239,176,144,126,15,96,186,8,169,82,132,232,5,198,117,148,33,238,172,217,159,34,9,222,61,163,130,141,164,25,120,143,143,239,13,131,197,48,129,65,213,160,247,16,92,31,117,229,184,167,33,121,136,228,88,215,206,16,140,69,254,45,242,44,5,226,65,93,5,111,157,123,158,247,166,126,135,136,86,223,136,95,135,242,145,56,146,69,93,163,23,15,125,86,171,80,194,157,60,14,18,84,53,66,8,229,238,173,156,181,192,221,29,188,60,23,209,175,236,148,218,145,140,50,11,250,151,84,165,186,64,192,163,32,147,239,229,206,219,44,114,183,45,47,113,254,1,179,225,244,151,3,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55eedac6-1832-49bb-ada6-3ce9df23cd0c"));
		}

		#endregion

	}

	#endregion

}

