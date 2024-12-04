namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailContextSchema

	/// <exclude/>
	public class BulkEmailContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailContextSchema(BulkEmailContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20559898-5818-4bc5-ac24-30a5cda72c44");
			Name = "BulkEmailContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,193,110,194,48,12,61,15,137,127,176,224,222,222,199,134,196,42,52,245,48,9,141,237,52,237,16,82,183,179,214,38,85,226,76,67,104,255,62,183,5,70,17,48,46,81,236,188,231,247,242,18,163,42,244,181,210,8,47,232,156,242,54,231,40,177,38,167,34,56,197,100,205,112,176,25,14,110,130,39,83,192,114,237,25,171,201,190,62,67,137,146,249,242,52,200,161,244,229,100,236,176,16,32,36,165,242,254,22,30,66,249,57,175,20,149,50,134,241,155,91,76,28,199,112,231,67,85,41,183,158,110,235,212,228,214,85,173,8,168,149,13,12,43,161,2,54,220,29,37,62,224,212,97,85,146,6,221,200,156,80,185,145,171,201,186,183,179,112,182,70,199,132,226,105,209,82,187,243,99,43,91,47,158,149,145,224,108,14,252,129,2,64,4,237,48,191,31,245,175,28,189,122,116,162,105,80,55,198,71,241,20,120,93,99,180,159,124,232,120,103,185,207,57,46,55,80,32,79,192,55,203,207,69,143,236,108,22,52,122,152,45,82,144,240,36,114,27,50,104,115,128,37,186,47,210,255,56,73,229,53,103,53,237,192,205,246,90,249,196,150,229,214,177,132,36,31,205,171,2,129,50,15,100,250,47,119,94,254,49,80,246,246,14,79,29,57,21,238,245,234,193,112,35,252,167,4,14,53,213,132,134,253,69,81,18,226,243,14,218,205,57,161,58,70,147,117,63,167,173,187,110,191,41,189,95,212,49,218,119,98,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20559898-5818-4bc5-ac24-30a5cda72c44"));
		}

		#endregion

	}

	#endregion

}

