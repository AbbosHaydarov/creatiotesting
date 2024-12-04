namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountLanguageIteratorSchema

	/// <exclude/>
	public class AccountLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountLanguageIteratorSchema(AccountLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e46324f1-8f69-4be3-9d3a-1af95158ae46");
			Name = "AccountLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,107,2,65,12,134,207,43,248,31,194,122,81,40,187,119,171,66,107,47,66,15,82,218,83,233,33,78,179,203,192,108,86,230,131,98,139,255,189,153,217,245,179,8,61,184,48,201,155,39,111,18,25,27,114,91,84,4,175,100,45,186,182,242,197,178,229,74,215,193,162,215,45,15,7,63,195,65,22,156,230,250,66,98,233,126,56,144,204,200,82,45,50,88,26,116,110,10,15,74,181,129,253,51,114,29,176,166,149,39,193,180,54,73,203,178,132,153,11,77,131,118,183,232,223,7,1,84,242,51,218,249,216,103,179,3,236,56,96,122,144,43,14,128,242,140,176,13,27,163,21,168,216,251,86,107,152,194,35,58,250,235,40,139,131,157,252,183,236,188,13,74,82,50,198,58,129,147,235,63,182,59,223,172,189,70,163,191,201,1,211,23,104,169,70,150,53,182,149,136,137,64,89,170,230,249,13,79,121,185,40,224,200,62,159,168,139,108,209,98,3,44,183,153,231,193,145,21,115,76,42,158,35,95,188,201,27,212,49,80,204,202,164,78,197,253,62,110,116,29,199,210,19,10,46,201,147,8,200,166,176,145,101,141,175,82,144,86,149,29,128,47,193,200,216,243,52,248,234,60,248,254,209,43,179,152,90,91,221,144,80,60,42,191,226,43,83,81,126,101,104,114,119,170,125,162,10,131,249,135,122,47,127,67,249,118,167,26,17,127,118,247,76,239,46,122,25,220,255,2,132,211,208,138,242,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e46324f1-8f69-4be3-9d3a-1af95158ae46"));
		}

		#endregion

	}

	#endregion

}

