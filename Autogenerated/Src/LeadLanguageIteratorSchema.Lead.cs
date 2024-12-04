namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadLanguageIteratorSchema

	/// <exclude/>
	public class LeadLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadLanguageIteratorSchema(LeadLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1252c774-91a4-464b-aa1f-d627521faa81");
			Name = "LeadLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,77,107,194,64,16,61,71,240,63,12,233,69,161,36,119,171,66,107,47,130,208,82,234,169,244,48,174,147,176,176,217,13,251,65,177,197,255,222,201,135,154,68,193,67,22,102,230,189,55,111,102,162,177,32,87,162,32,248,36,107,209,153,204,39,43,163,51,153,7,139,94,26,61,30,253,141,71,81,112,82,231,61,136,165,167,241,136,43,15,150,114,134,193,74,161,115,51,120,43,75,99,125,208,210,31,54,168,243,128,57,173,61,177,148,177,53,60,77,83,152,187,80,20,104,15,203,54,62,1,32,227,79,73,231,171,94,187,3,40,194,61,168,86,197,37,39,118,218,161,151,97,167,164,0,81,53,135,13,227,135,77,97,6,47,232,232,218,75,196,99,241,123,241,111,180,243,54,8,46,242,24,239,181,110,131,24,90,110,60,243,132,18,149,252,37,7,154,126,64,50,27,53,175,209,100,12,38,2,97,41,91,196,183,44,197,233,50,129,179,112,119,154,38,83,162,197,2,52,31,102,17,7,71,150,157,105,18,213,45,226,229,150,99,16,231,68,50,79,107,116,77,110,119,113,171,229,100,219,211,129,190,236,180,98,71,209,12,118,188,169,201,160,6,213,249,163,232,164,248,17,20,79,188,168,103,94,119,147,95,223,45,50,170,74,44,224,81,248,181,238,186,169,96,3,39,211,199,122,19,3,210,179,16,38,104,127,151,123,161,190,82,134,65,249,251,232,35,255,181,252,182,183,39,189,111,206,95,199,77,182,159,60,254,3,208,239,76,12,33,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1252c774-91a4-464b-aa1f-d627521faa81"));
		}

		#endregion

	}

	#endregion

}

