namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactLanguageIteratorSchema

	/// <exclude/>
	public class ContactLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactLanguageIteratorSchema(ContactLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0cad4a31-9d11-4174-aee6-2df7a00ccdc7");
			Name = "ContactLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,61,107,195,64,12,134,103,7,242,31,132,179,36,80,236,61,77,50,52,93,2,29,74,105,167,210,65,185,202,230,224,44,135,251,160,164,37,255,189,186,179,243,77,32,67,12,39,189,122,244,74,10,99,67,110,131,138,224,157,172,69,215,86,190,88,182,92,233,58,88,244,186,229,225,224,111,56,200,130,211,92,159,73,44,61,14,7,146,25,89,170,69,6,75,131,206,77,65,106,61,42,255,130,92,7,172,105,229,73,48,173,77,210,178,44,97,230,66,211,160,221,46,250,247,94,0,149,252,140,118,62,246,89,111,65,117,28,48,61,200,21,123,64,121,66,216,132,181,209,10,84,236,125,171,53,76,225,9,29,93,59,202,226,96,71,255,45,59,111,131,146,148,140,241,154,192,201,245,149,237,206,55,107,175,209,232,95,114,192,244,3,90,170,145,101,141,109,37,98,34,80,150,170,121,126,195,83,94,46,10,56,176,79,39,234,34,27,180,216,0,203,109,230,121,112,100,5,195,164,226,57,242,197,135,188,227,122,250,64,49,43,147,58,21,247,251,184,209,117,28,75,143,40,56,39,79,34,32,155,194,90,150,53,190,72,65,90,85,182,7,190,5,35,99,207,211,224,171,211,224,231,87,175,204,98,234,208,159,47,12,69,233,133,153,201,195,177,238,153,42,12,230,14,245,78,254,130,242,237,206,52,34,254,238,110,153,222,93,244,60,184,251,7,46,248,66,101,238,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cad4a31-9d11-4174-aee6-2df7a00ccdc7"));
		}

		#endregion

	}

	#endregion

}

