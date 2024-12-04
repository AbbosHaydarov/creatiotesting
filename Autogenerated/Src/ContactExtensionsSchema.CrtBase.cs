﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactExtensionsSchema

	/// <exclude/>
	public class ContactExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactExtensionsSchema(ContactExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2db763e2-4a24-43ea-bf33-95f247428055");
			Name = "ContactExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("acb004d0-c421-4dff-b075-f4fdc1c90074");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,84,93,107,219,48,20,125,118,161,255,225,226,190,164,16,236,247,45,206,195,210,164,12,218,50,150,254,1,205,190,118,5,178,236,73,114,150,48,250,223,119,37,57,254,136,29,54,6,27,4,199,58,247,232,156,171,235,99,75,86,162,174,89,138,240,138,74,49,93,229,38,218,84,50,231,69,163,152,225,149,188,189,249,121,123,19,52,154,203,2,246,39,109,176,252,120,177,38,190,16,152,90,178,142,30,81,162,226,233,132,243,192,12,155,128,79,92,126,159,128,175,120,52,209,87,44,26,193,212,246,88,43,212,218,42,247,188,97,163,101,89,201,249,138,194,107,120,244,240,233,106,105,43,13,55,28,103,221,246,39,105,207,69,149,59,133,5,245,4,27,193,180,254,0,52,47,195,82,179,61,26,148,174,87,162,208,175,110,190,9,158,130,54,52,199,20,82,203,157,165,210,124,233,218,137,62,163,121,203,42,146,253,226,246,251,98,16,199,49,172,116,83,150,76,157,214,29,178,227,66,104,88,213,76,177,82,97,14,146,158,102,18,166,222,36,140,215,16,238,26,33,28,28,66,206,81,100,224,79,53,179,229,128,202,160,162,77,81,111,24,79,28,253,198,11,163,117,123,44,224,146,78,43,83,140,86,177,227,93,223,215,186,173,87,26,17,82,106,36,9,63,183,42,59,219,231,102,208,16,240,178,22,88,34,85,109,200,198,226,227,41,31,42,158,185,169,188,144,145,19,90,152,55,222,205,29,218,142,151,48,111,102,235,254,238,30,108,236,131,128,231,176,232,64,72,18,144,52,208,115,49,80,104,26,229,2,24,4,239,238,218,26,68,214,31,146,94,143,94,12,211,90,218,210,66,226,143,115,83,251,162,60,235,237,73,173,219,232,116,90,100,233,235,143,252,128,242,101,204,232,176,150,243,204,179,76,224,5,169,7,61,233,253,222,53,77,61,219,191,73,184,254,48,91,92,105,227,195,181,132,240,137,13,22,222,111,24,60,237,147,215,217,253,46,128,211,252,253,101,252,254,101,250,174,132,143,158,168,147,209,255,57,124,155,62,80,173,151,189,157,79,33,85,172,118,23,86,31,136,46,191,147,36,18,255,12,142,153,51,153,180,220,14,30,179,231,210,105,233,61,62,12,230,29,202,204,127,22,221,218,158,210,126,126,7,40,173,9,253,5,131,244,81,131,198,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2db763e2-4a24-43ea-bf33-95f247428055"));
		}

		#endregion

	}

	#endregion

}

