﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactNotificationProviderSchema

	/// <exclude/>
	public class ContactNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactNotificationProviderSchema(ContactNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d8f5588-f7e1-420d-983e-1e31a80a9207");
			Name = "ContactNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50f7fa08-b85d-45ef-968c-2461f941f235");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,88,75,111,219,56,16,62,187,64,254,3,161,189,200,216,64,217,189,230,97,32,15,39,208,34,105,178,182,211,30,218,162,96,36,58,225,86,162,84,146,74,215,27,228,191,239,240,33,153,148,37,197,89,116,129,30,122,73,204,225,188,135,243,113,40,134,115,34,74,156,16,180,32,156,99,81,44,101,116,90,176,37,189,175,56,150,180,96,59,111,158,118,222,140,42,65,217,189,199,194,73,116,118,114,208,179,213,77,207,243,130,173,119,230,43,33,73,222,94,71,103,88,226,13,226,105,145,101,36,81,238,136,161,189,232,130,48,194,105,178,193,115,73,217,87,32,2,249,23,78,238,129,21,157,102,88,136,125,4,161,74,156,200,183,133,164,75,154,232,128,111,120,241,72,83,194,53,123,89,221,101,52,65,137,226,30,98,70,251,232,4,11,210,181,181,139,98,151,12,74,85,66,215,142,128,223,18,51,9,206,220,112,250,136,37,209,134,71,165,89,160,68,237,35,33,185,10,231,98,118,125,123,243,249,237,241,213,20,29,161,192,85,27,28,244,10,213,236,214,125,197,169,29,32,44,53,62,216,181,117,232,156,146,44,109,123,243,103,69,248,10,50,93,229,108,250,119,201,137,16,138,53,49,26,231,201,3,201,241,109,156,190,160,89,135,202,171,68,22,92,233,215,169,181,193,154,52,15,36,56,188,21,132,195,62,51,165,70,149,183,28,43,37,163,125,116,7,53,8,91,91,72,167,123,52,39,242,212,115,151,166,225,88,39,237,121,107,31,206,168,86,137,249,234,208,228,118,23,21,119,127,129,157,9,42,49,135,78,146,132,11,207,23,135,188,173,31,125,217,3,47,74,194,37,37,173,220,237,237,237,161,67,81,229,57,184,53,169,9,23,188,168,74,196,192,118,212,240,236,185,76,54,218,250,92,105,118,227,224,61,145,246,215,136,19,89,113,230,156,58,237,167,114,180,241,182,211,122,211,21,91,59,240,22,24,123,237,119,91,238,203,211,21,145,15,133,119,128,71,35,183,55,30,11,154,162,206,42,88,179,143,152,163,28,51,124,15,1,28,33,255,220,1,194,88,137,43,195,17,6,83,38,169,92,121,196,192,20,84,107,178,61,2,154,172,206,232,156,178,52,6,84,58,89,169,168,195,166,47,173,80,187,169,64,210,52,94,116,83,31,166,208,242,68,176,221,156,29,19,229,22,89,41,36,196,66,210,26,102,236,18,21,143,0,213,80,53,147,160,227,52,53,86,69,56,39,10,95,145,208,255,234,36,153,149,41,83,100,56,195,96,70,114,136,13,234,25,236,162,32,78,131,113,116,44,66,253,99,136,209,44,22,52,39,86,192,37,12,9,218,196,53,134,156,245,144,216,188,210,61,219,136,57,235,33,177,51,34,18,78,75,13,182,70,208,163,180,68,223,125,131,171,199,212,48,102,239,11,254,69,95,178,74,143,42,186,85,112,89,96,232,18,67,216,194,227,83,236,90,111,19,61,44,235,169,234,31,5,101,11,124,151,145,109,170,122,73,150,242,186,130,227,166,164,192,222,74,28,167,224,212,45,163,112,86,163,235,161,106,196,98,250,181,194,89,75,200,103,234,182,226,226,238,98,85,146,46,75,109,30,223,228,134,6,123,22,187,237,245,212,169,195,170,41,150,111,171,191,202,183,142,201,99,150,14,177,2,189,89,123,234,55,218,190,133,69,141,84,4,48,160,234,191,197,9,208,125,13,49,233,121,169,251,16,168,139,43,242,249,44,131,1,40,11,217,172,149,103,13,225,71,168,235,226,84,219,145,187,17,45,138,185,214,98,175,62,255,224,233,124,117,149,209,182,78,111,126,186,92,26,123,85,240,219,106,37,92,240,246,114,223,70,225,151,218,203,155,241,98,182,44,16,220,20,51,146,20,60,109,239,116,141,17,230,255,4,165,205,150,9,238,29,206,42,210,204,14,23,21,84,80,212,112,101,50,7,243,50,81,80,137,82,251,227,160,97,141,22,124,5,201,129,49,164,91,237,7,7,250,62,193,40,83,193,73,168,9,99,95,251,203,170,28,208,182,186,106,135,172,42,123,153,51,242,13,109,100,164,14,112,180,160,50,83,167,168,207,138,11,185,159,118,141,204,73,145,174,6,68,90,56,89,75,197,57,92,198,250,118,213,169,154,230,165,92,217,45,115,40,244,94,147,15,111,203,156,10,123,224,155,251,219,178,92,193,112,92,171,86,193,42,245,189,89,83,153,31,91,65,23,43,183,145,117,249,93,61,122,152,179,206,233,223,150,190,190,109,6,178,229,92,73,117,166,214,149,85,114,182,168,102,28,219,102,110,93,79,30,47,13,173,51,125,66,132,135,44,61,211,163,166,152,19,37,38,30,178,28,238,213,100,103,202,140,167,172,202,9,87,55,223,225,70,167,78,84,171,186,68,209,156,199,122,0,110,237,43,41,209,249,122,240,193,86,79,153,102,136,186,164,66,218,110,159,192,76,168,137,181,21,187,84,152,107,166,165,131,77,178,115,113,118,236,186,19,83,199,182,59,103,116,108,119,78,18,157,44,61,230,189,65,104,40,43,245,115,163,134,198,25,17,85,38,255,59,32,90,125,242,53,168,225,93,98,80,164,126,49,213,84,30,183,189,20,226,33,161,117,161,124,89,238,117,209,22,32,234,73,103,175,237,93,79,250,238,117,8,233,201,54,8,248,178,2,27,179,43,253,133,40,195,144,229,95,81,240,57,128,191,235,52,172,159,72,101,81,194,235,211,32,222,141,250,173,190,1,109,222,9,186,202,62,230,171,192,54,240,220,152,254,142,136,238,1,231,186,18,14,4,234,48,96,56,163,56,163,255,16,29,3,176,234,184,162,121,77,174,103,29,11,42,214,205,243,130,231,88,134,193,199,224,233,183,231,143,193,62,122,250,253,25,134,19,72,220,110,75,227,96,103,217,73,14,58,75,7,4,95,9,12,37,244,103,7,239,202,0,23,67,69,30,203,7,42,162,245,167,138,15,129,207,215,58,17,223,117,240,243,198,23,229,80,77,216,116,42,173,136,218,172,189,49,41,215,81,155,163,99,3,246,135,228,193,119,213,207,39,234,255,246,68,181,188,103,112,237,81,166,142,161,37,156,243,34,119,69,123,158,101,63,31,155,63,246,99,211,26,123,255,64,56,124,193,242,190,224,196,226,18,38,224,107,222,163,86,245,57,160,0,32,11,64,151,192,153,146,10,199,254,43,173,253,213,96,216,81,31,172,124,77,63,218,43,114,167,79,75,44,102,4,15,134,185,196,153,0,63,16,22,22,233,252,219,100,77,234,152,199,45,205,37,1,229,95,159,15,206,192,252,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d8f5588-f7e1-420d-983e-1e31a80a9207"));
		}

		#endregion

	}

	#endregion

}

