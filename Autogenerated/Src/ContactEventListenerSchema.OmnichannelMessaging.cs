namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactEventListenerSchema

	/// <exclude/>
	public class ContactEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactEventListenerSchema(ContactEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7bbed3c8-78ef-49dc-a0ac-f1c79bd9a80b");
			Name = "ContactEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3e2142cb-b5f1-4ce8-8571-f789e137e2ae");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,193,106,220,48,16,61,59,144,127,24,220,67,188,16,236,251,118,189,144,110,211,52,208,52,165,217,230,82,122,152,181,198,182,138,45,45,146,188,96,74,255,189,99,201,222,118,19,47,189,24,102,244,158,222,155,167,177,194,150,236,30,11,130,45,25,131,86,151,46,221,104,85,202,170,51,232,164,86,151,23,191,46,47,162,206,74,85,193,83,111,29,181,111,143,245,25,74,250,216,42,89,212,168,20,53,233,3,89,139,21,163,231,105,134,210,91,229,164,147,100,255,11,72,111,15,164,220,128,99,228,27,67,21,107,193,166,65,107,151,192,6,28,22,206,35,62,73,182,169,200,120,92,150,101,176,178,93,219,162,233,215,99,61,1,160,212,6,174,70,234,21,48,85,186,30,200,171,164,19,55,123,65,94,89,34,108,172,134,194,80,153,199,239,208,146,55,216,159,104,199,144,13,132,239,51,71,201,83,81,83,139,159,57,121,200,33,30,229,227,197,15,198,239,187,93,35,11,40,134,161,102,103,130,37,156,81,100,54,191,20,127,143,209,60,144,171,181,224,112,190,248,91,195,225,203,60,124,227,35,42,209,144,157,18,120,79,13,57,18,33,137,33,136,215,73,132,206,30,13,182,160,120,146,60,182,164,4,207,189,246,166,32,84,233,42,243,144,121,6,197,235,109,77,62,208,49,204,237,242,236,211,123,103,55,165,35,227,5,110,76,101,135,140,65,42,235,80,241,254,22,67,90,82,13,251,227,106,154,4,253,8,32,208,225,137,151,49,103,125,96,57,41,8,14,90,10,120,84,227,224,137,222,253,164,98,26,226,26,230,196,129,22,48,252,25,81,180,227,247,72,255,114,39,18,45,134,133,142,162,64,14,246,248,206,28,146,208,89,4,96,0,29,208,0,59,200,39,88,122,71,110,219,239,73,108,116,211,181,234,25,155,142,86,119,157,20,235,36,190,23,241,120,245,63,255,217,184,43,247,98,120,194,82,114,244,95,169,229,241,66,195,245,31,140,110,55,200,139,151,72,113,125,84,249,102,201,48,83,241,176,188,48,225,214,223,227,18,177,187,176,71,190,14,221,211,38,247,254,0,252,76,44,119,63,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7bbed3c8-78ef-49dc-a0ac-f1c79bd9a80b"));
		}

		#endregion

	}

	#endregion

}

