namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandResultSchema

	/// <exclude/>
	public class FacebookCommandResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandResultSchema(FacebookCommandResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fbe4dcf3-dfa9-4277-a9bc-ff9fbac967cf");
			Name = "FacebookCommandResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,142,49,10,195,48,12,69,231,4,114,7,67,247,28,32,221,106,232,212,169,233,5,20,71,49,166,182,148,90,246,16,74,238,94,167,129,12,165,139,224,127,222,227,139,32,160,204,96,80,61,48,70,16,158,82,171,153,38,103,115,132,228,152,218,158,141,3,223,212,239,166,174,178,56,178,234,90,240,129,249,121,62,154,126,145,132,161,189,57,122,149,178,212,167,136,182,200,74,123,16,233,14,67,115,8,64,227,29,37,251,244,5,231,60,120,103,148,217,184,255,152,234,212,5,4,127,212,170,188,83,238,186,175,33,141,251,224,22,215,15,21,245,248,172,212,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fbe4dcf3-dfa9-4277-a9bc-ff9fbac967cf"));
		}

		#endregion

	}

	#endregion

}

