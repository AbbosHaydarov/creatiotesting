﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningAppListenerSchema

	/// <exclude/>
	public class EmailMiningAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningAppListenerSchema(EmailMiningAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0959799-ae1d-49da-8545-91b1964505ff");
			Name = "EmailMiningAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e20436f2-80ed-4182-a2cd-94f2d77ff547");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,86,91,79,219,48,20,126,14,18,255,225,40,60,172,72,40,125,135,166,136,149,139,152,198,69,98,136,135,105,66,110,114,218,122,36,118,100,59,29,104,234,127,223,137,147,172,177,155,0,82,21,213,199,223,185,159,243,37,130,229,168,11,150,32,252,64,165,152,150,11,19,205,164,88,240,101,169,152,225,82,68,23,57,227,217,13,23,92,44,247,247,254,238,239,5,165,166,191,14,60,207,165,56,233,189,81,56,36,119,189,12,162,46,89,98,164,226,168,251,16,79,56,223,122,167,251,3,133,75,50,6,179,140,105,125,12,157,200,207,138,226,59,215,6,5,42,139,28,143,199,48,209,101,158,51,245,54,109,206,15,104,202,66,3,86,90,144,91,53,40,80,113,153,242,132,101,240,91,206,163,86,115,220,81,45,202,121,198,19,72,42,159,3,46,143,129,14,23,107,20,166,149,124,101,26,73,151,202,73,207,109,220,82,104,195,132,161,216,239,173,213,250,186,245,80,221,130,54,202,22,129,169,37,154,111,114,126,165,100,89,220,82,23,33,134,176,227,158,174,194,186,42,193,1,138,180,246,224,186,187,228,152,165,149,47,197,215,204,96,227,172,62,128,66,150,74,145,189,193,53,197,254,144,172,48,45,51,84,79,138,81,73,224,89,123,130,184,174,121,221,173,183,232,10,205,164,71,111,58,58,60,233,250,104,171,66,121,27,124,53,240,204,92,129,15,38,177,192,164,154,23,11,221,30,29,224,163,70,213,69,150,206,249,131,154,220,43,73,129,26,26,184,129,186,120,214,189,99,181,31,65,64,157,105,254,5,138,134,74,237,4,1,167,167,48,242,101,177,155,98,244,240,70,179,146,187,14,234,250,5,27,251,212,91,55,187,182,214,44,43,177,131,166,199,112,53,221,211,78,18,124,65,209,58,5,135,56,6,81,102,217,97,11,9,252,222,69,179,21,38,47,103,106,89,230,36,188,37,236,40,244,250,29,54,217,212,202,78,244,59,214,72,149,118,192,114,197,207,202,206,22,29,254,2,166,221,12,26,179,27,183,5,187,19,211,83,71,63,144,129,50,14,141,143,221,96,85,86,91,224,45,177,207,56,86,112,142,11,86,102,166,33,143,100,171,124,4,248,138,73,105,80,3,43,141,204,41,113,226,32,218,198,57,253,138,252,11,109,38,23,8,20,45,144,87,34,13,101,42,114,218,101,167,150,60,250,137,105,212,244,111,243,78,140,13,45,114,75,77,244,158,144,11,194,32,66,162,112,17,135,253,118,195,241,20,254,112,179,130,164,212,20,61,84,211,89,165,215,142,118,127,168,86,82,48,197,114,16,68,104,113,232,14,117,56,125,244,204,76,198,22,253,137,60,189,53,117,13,183,67,236,129,98,15,86,79,129,187,42,62,166,154,83,79,227,131,137,185,65,179,146,131,44,188,150,60,133,150,69,93,118,111,123,23,252,39,217,71,195,51,29,157,99,134,6,239,178,148,48,122,180,251,158,104,150,142,216,165,202,247,90,44,36,117,73,41,218,53,91,222,216,163,180,104,182,189,172,53,125,242,143,218,0,174,243,28,83,78,97,147,187,137,27,236,180,39,144,35,223,211,147,84,47,246,91,36,178,215,245,70,118,98,171,197,150,119,142,128,22,165,73,229,211,5,254,104,27,59,28,83,175,20,172,152,72,41,207,207,206,43,141,166,229,181,105,215,82,35,236,27,86,185,166,79,25,158,54,109,190,19,213,27,179,242,59,242,95,140,141,141,182,227,62,59,82,211,26,68,211,219,129,129,121,167,92,181,212,21,110,254,1,104,69,67,37,29,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0959799-ae1d-49da-8545-91b1964505ff"));
		}

		#endregion

	}

	#endregion

}

