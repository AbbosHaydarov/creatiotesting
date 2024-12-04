namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailWithMacrosManagerSchema

	/// <exclude/>
	public class EmailWithMacrosManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailWithMacrosManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailWithMacrosManagerSchema(EmailWithMacrosManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85799d52-f024-4688-af50-53556a8e81b7");
			Name = "EmailWithMacrosManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,77,107,227,48,16,61,167,208,255,48,180,151,20,22,251,158,77,3,219,244,131,66,3,133,22,246,60,177,199,174,64,150,130,36,187,132,165,255,125,71,82,20,199,110,92,31,108,105,230,205,155,209,123,178,194,134,236,14,11,130,119,50,6,173,174,92,182,214,170,18,117,107,208,9,173,46,47,254,93,94,204,90,43,84,13,111,123,235,168,249,61,218,51,94,74,42,60,216,102,79,164,200,136,162,199,172,13,121,158,236,145,63,173,161,119,93,215,146,227,61,224,180,111,211,104,117,62,99,104,42,158,61,40,39,156,32,59,9,184,191,235,83,181,212,91,148,139,69,236,149,189,240,56,131,105,226,145,222,200,57,222,89,184,29,115,13,180,201,24,157,160,76,193,36,215,134,106,78,192,90,162,181,11,120,104,80,200,191,194,125,108,176,48,218,110,80,97,77,198,35,25,187,107,183,82,20,176,67,227,4,74,40,124,201,68,5,76,81,221,161,37,166,98,139,248,125,236,190,33,247,161,75,238,255,106,180,99,103,168,140,249,60,207,97,105,219,166,65,179,95,165,64,48,136,44,160,2,100,19,59,225,246,188,46,161,18,82,90,16,14,62,185,41,148,84,97,43,29,116,40,91,178,217,145,45,31,211,45,13,177,207,202,174,254,36,50,242,254,236,179,101,158,50,30,186,75,147,129,238,88,97,81,18,88,66,201,251,96,231,254,48,86,34,137,193,249,13,248,203,56,155,69,166,17,102,126,227,109,156,125,197,179,246,13,58,97,92,203,2,31,7,26,151,13,73,183,44,105,54,209,29,237,145,37,245,130,195,51,169,239,99,208,145,213,93,178,211,216,24,170,64,241,79,119,123,149,212,190,202,87,81,227,90,116,244,29,86,162,67,134,252,36,121,168,24,179,158,49,32,224,206,151,133,46,171,53,159,29,252,114,0,254,46,101,167,69,25,14,150,122,248,139,233,139,239,185,118,126,108,140,69,92,252,130,148,11,228,73,240,160,180,103,137,250,14,56,250,210,80,241,179,179,97,156,87,67,124,221,11,178,246,220,0,79,45,67,10,102,127,46,15,27,183,147,207,229,96,148,19,134,190,48,213,68,248,233,28,215,164,202,248,195,133,125,140,14,131,95,255,1,103,81,53,43,95,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85799d52-f024-4688-af50-53556a8e81b7"));
		}

		#endregion

	}

	#endregion

}

