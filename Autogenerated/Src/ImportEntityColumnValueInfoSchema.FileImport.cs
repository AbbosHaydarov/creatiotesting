namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntityColumnValueInfoSchema

	/// <exclude/>
	public class ImportEntityColumnValueInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntityColumnValueInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntityColumnValueInfoSchema(ImportEntityColumnValueInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9fbcde3-0880-48e4-b9ce-ae5b644669f4");
			Name = "ImportEntityColumnValueInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,82,75,107,2,49,16,62,43,248,31,6,188,187,247,90,122,209,22,188,20,161,210,251,152,157,221,166,100,147,48,51,41,136,248,223,155,205,106,209,22,44,182,151,192,60,190,215,16,143,29,73,68,67,176,33,102,148,208,232,108,17,124,99,219,196,168,54,248,217,147,117,180,234,98,96,157,140,247,147,241,40,137,245,237,197,54,211,124,50,206,147,41,83,155,17,176,112,40,114,7,3,232,209,171,213,221,34,184,212,249,87,116,137,86,190,9,101,189,170,42,184,151,212,117,200,187,135,99,189,36,177,173,167,26,52,0,121,131,81,146,67,37,176,25,196,93,49,4,184,13,73,1,65,34,25,219,88,3,166,144,195,71,207,14,117,226,222,159,190,101,80,49,0,145,131,33,145,217,73,178,58,211,180,94,137,61,58,48,189,231,235,150,71,57,125,126,191,98,174,57,68,98,181,148,179,174,211,214,89,51,204,191,231,42,141,129,57,103,234,169,79,142,125,62,126,111,235,167,175,81,44,132,32,90,210,12,94,158,243,58,236,161,37,157,131,244,207,225,86,193,114,162,235,138,97,251,78,70,225,44,253,255,36,107,84,4,221,197,95,100,151,168,88,212,54,121,245,168,222,247,74,249,55,3,18,18,231,127,125,235,173,95,10,236,250,197,167,228,235,225,23,148,122,232,94,54,15,159,205,148,152,88,90,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9fbcde3-0880-48e4-b9ce-ae5b644669f4"));
		}

		#endregion

	}

	#endregion

}

