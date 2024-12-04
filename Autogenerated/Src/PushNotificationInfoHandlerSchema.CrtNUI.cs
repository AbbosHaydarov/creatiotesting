﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PushNotificationInfoHandlerSchema

	/// <exclude/>
	public class PushNotificationInfoHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PushNotificationInfoHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PushNotificationInfoHandlerSchema(PushNotificationInfoHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3037a631-ccbb-429d-a654-1d0d334df66d");
			Name = "PushNotificationInfoHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,86,109,107,219,48,16,254,236,66,255,195,145,65,113,32,56,108,31,54,104,147,140,54,117,219,64,223,104,218,125,25,35,40,246,165,209,166,72,65,146,51,194,214,255,190,147,237,36,126,137,91,10,251,226,32,221,233,209,221,243,220,157,34,217,2,205,146,69,8,143,168,53,51,106,102,131,161,146,51,254,156,104,102,185,146,135,7,127,14,15,188,196,112,249,12,227,181,177,184,56,169,172,201,95,8,140,156,179,9,46,81,162,230,209,206,167,8,171,145,246,201,242,65,227,51,121,195,80,48,99,142,225,62,49,243,91,101,249,140,71,233,149,35,57,83,87,76,198,2,117,234,222,237,118,161,103,146,197,130,233,245,32,95,167,71,193,206,153,5,131,50,54,176,36,16,144,5,20,3,115,135,225,98,40,109,7,27,196,110,1,242,251,221,212,40,129,22,253,214,151,224,227,231,224,19,252,205,175,224,6,84,110,235,64,98,26,121,10,170,89,140,41,44,212,192,37,113,196,226,160,213,254,65,247,44,147,169,224,17,68,41,244,43,121,195,49,156,49,131,13,214,14,140,138,150,45,87,30,73,69,223,29,191,148,174,101,210,58,142,53,95,49,139,153,125,153,45,32,114,118,48,86,59,146,194,219,211,179,235,112,114,255,52,190,26,135,15,223,70,195,112,114,17,158,62,62,61,132,147,225,221,121,8,125,104,61,25,188,81,83,46,176,26,185,105,157,188,133,123,117,122,123,126,29,62,212,48,29,77,14,238,108,93,3,76,83,33,115,150,77,57,181,11,142,34,110,202,107,170,148,248,10,19,110,46,144,217,68,99,40,217,84,96,92,138,81,147,40,74,138,53,52,232,54,89,238,221,127,35,172,148,113,157,24,171,116,90,216,78,237,60,182,76,249,87,52,247,137,94,77,0,50,235,37,87,108,133,101,219,129,120,199,84,242,220,248,101,83,7,100,34,68,27,92,163,122,47,255,231,186,78,122,157,55,58,231,233,146,218,164,151,233,217,161,118,248,73,62,3,88,50,77,195,195,162,54,155,216,166,84,178,181,216,10,110,89,132,94,3,181,84,13,18,127,55,232,81,131,189,68,91,245,108,159,20,8,104,82,232,6,237,92,189,90,57,14,122,84,41,29,127,19,59,159,129,95,43,44,232,247,139,18,80,134,117,15,152,148,51,8,246,221,242,70,15,182,225,232,40,187,192,123,7,218,190,206,203,168,114,92,209,87,35,157,146,176,55,45,42,102,124,39,173,202,82,76,24,111,136,205,151,176,226,218,38,76,212,244,221,167,228,150,238,60,180,125,117,225,87,40,40,169,191,187,86,173,104,94,243,24,97,165,120,12,89,237,187,46,40,41,186,87,241,173,154,66,69,191,72,117,247,131,122,187,235,205,232,61,99,209,28,252,210,48,118,216,52,244,211,15,76,100,197,178,59,221,212,5,193,102,32,150,114,117,128,185,102,27,213,242,159,151,119,137,83,24,72,213,87,53,221,32,245,34,52,6,77,253,205,244,106,143,102,182,147,246,55,72,234,241,126,171,116,168,53,216,253,49,0,53,163,201,133,21,212,94,55,61,156,98,229,3,171,160,146,63,10,101,178,64,237,228,232,213,56,30,148,177,222,152,45,65,14,89,62,179,169,24,207,171,178,151,51,90,38,148,246,254,1,124,130,48,167,47,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3037a631-ccbb-429d-a654-1d0d334df66d"));
		}

		#endregion

	}

	#endregion

}

