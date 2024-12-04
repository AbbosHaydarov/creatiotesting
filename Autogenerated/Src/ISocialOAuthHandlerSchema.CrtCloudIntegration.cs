namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISocialOAuthHandlerSchema

	/// <exclude/>
	public class ISocialOAuthHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISocialOAuthHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISocialOAuthHandlerSchema(ISocialOAuthHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("517c4ae3-d962-4f43-be2d-326fee09fce3");
			Name = "ISocialOAuthHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,193,78,2,49,16,134,207,144,240,14,19,184,232,101,247,46,72,66,72,140,28,140,70,188,25,15,227,182,187,52,118,219,58,157,198,32,225,221,109,119,97,33,1,3,151,102,218,206,124,243,255,237,24,172,165,119,88,72,152,19,207,181,13,98,97,88,86,132,172,172,201,82,76,101,188,245,131,254,102,208,239,5,175,76,5,79,86,72,237,179,87,249,29,164,103,63,30,244,227,213,136,100,21,75,160,43,185,131,197,210,22,10,245,243,44,240,234,17,141,208,146,154,212,60,207,97,226,67,93,35,173,167,187,125,87,6,165,37,72,193,167,181,95,32,84,165,24,53,160,16,30,208,57,192,200,130,85,11,203,246,172,252,8,230,194,167,86,5,168,142,119,86,69,47,185,57,17,210,28,204,156,139,128,198,63,152,248,58,169,203,105,155,158,103,74,111,113,156,189,129,74,242,24,182,141,201,243,240,23,141,28,13,214,151,201,239,31,135,228,43,192,111,43,9,74,72,195,138,215,224,11,235,46,232,94,166,148,107,192,179,162,241,198,22,60,35,49,112,108,148,62,193,146,250,109,109,151,218,254,252,211,172,57,113,72,216,26,190,31,82,59,51,195,233,110,120,34,14,25,10,107,24,149,241,80,199,181,253,98,101,74,155,77,242,166,246,128,34,201,129,140,159,166,191,60,8,8,164,99,234,254,238,216,100,82,252,16,229,221,116,209,190,239,78,200,109,28,222,94,107,127,36,141,104,103,56,109,183,127,199,135,10,109,25,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("517c4ae3-d962-4f43-be2d-326fee09fce3"));
		}

		#endregion

	}

	#endregion

}

