namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESQueryBuilderSchema

	/// <exclude/>
	public class IESQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESQueryBuilderSchema(IESQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88313c62-0396-406c-abf5-3debda333fb2");
			Name = "IESQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,145,205,110,131,48,16,132,207,32,241,14,86,114,105,47,112,79,83,14,173,162,42,135,74,169,210,23,88,96,33,150,252,67,215,246,33,170,242,238,117,188,144,146,246,134,199,51,59,31,107,3,26,221,8,45,138,79,36,2,103,123,95,190,90,211,203,33,16,120,105,77,249,166,108,3,234,136,64,237,169,200,191,139,188,200,179,224,164,25,22,137,157,2,231,101,203,166,167,100,89,19,14,49,46,246,198,35,245,177,96,35,246,187,227,71,64,58,191,4,169,58,164,100,171,170,74,108,93,208,26,232,92,79,231,105,154,112,105,156,248,186,102,68,51,135,56,82,45,50,99,104,84,180,203,185,233,127,81,198,216,55,168,119,244,39,219,185,141,56,164,40,95,254,69,73,66,26,225,4,78,72,204,210,147,213,145,78,97,235,89,41,111,249,37,23,43,35,16,104,97,226,158,159,87,252,71,137,109,85,243,182,166,1,219,42,249,126,99,132,62,144,113,245,1,6,132,70,225,61,66,244,207,134,107,98,54,77,155,75,5,140,158,62,31,184,138,229,5,195,35,63,85,182,70,211,241,102,210,249,194,15,120,39,94,126,0,204,180,221,183,41,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88313c62-0396-406c-abf5-3debda333fb2"));
		}

		#endregion

	}

	#endregion

}

