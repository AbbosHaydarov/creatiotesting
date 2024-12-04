﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChangeChatSettingsEventListenerSchema

	/// <exclude/>
	public class ChangeChatSettingsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChangeChatSettingsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChangeChatSettingsEventListenerSchema(ChangeChatSettingsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba4b43c8-f982-4731-bcc4-789f93b7df6e");
			Name = "ChangeChatSettingsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,148,223,79,219,48,16,199,159,139,196,255,112,42,18,74,37,148,190,51,90,169,43,8,85,130,177,169,192,203,180,7,55,185,182,158,18,59,216,78,166,104,240,191,239,98,39,212,233,15,186,178,241,146,54,206,221,247,238,62,119,62,193,82,212,25,139,16,238,81,41,166,229,220,132,99,41,230,124,145,43,102,184,20,225,93,42,120,180,100,66,96,18,222,162,214,108,193,197,226,248,232,247,241,81,39,215,244,23,166,165,54,152,126,90,123,15,111,184,120,90,29,250,234,10,119,157,135,87,194,112,195,81,239,53,8,175,10,20,166,178,35,203,19,133,11,74,21,198,9,211,250,28,198,148,237,2,233,105,166,104,12,137,104,107,124,195,41,47,129,202,186,244,251,125,184,208,121,154,50,85,14,235,119,235,14,153,146,5,143,81,87,50,230,91,142,57,222,101,72,44,164,2,18,225,166,4,180,161,129,162,196,9,169,135,141,92,223,211,251,110,19,45,91,129,131,105,180,196,148,125,33,228,48,128,238,134,126,183,247,227,175,61,171,118,56,251,44,159,37,60,130,200,38,191,167,116,56,135,207,76,227,150,8,36,68,29,165,231,43,204,91,52,75,25,19,206,175,74,26,140,12,198,238,251,58,185,26,29,50,165,129,230,196,128,172,203,209,160,48,147,154,211,223,146,60,16,33,82,56,31,116,39,99,70,213,76,233,24,187,253,33,112,161,13,19,17,86,24,55,57,186,147,140,41,150,130,160,242,7,221,60,234,14,61,181,7,141,138,6,86,80,134,148,117,75,240,162,111,253,172,76,214,20,1,133,228,177,203,183,225,174,109,66,65,91,9,242,168,7,213,144,119,58,5,83,16,85,38,196,94,224,47,59,24,141,175,115,37,219,106,98,59,29,107,22,90,117,247,165,62,95,119,187,87,76,232,57,42,75,161,114,223,244,121,121,3,247,37,117,77,241,89,110,136,2,169,106,48,210,195,62,43,93,35,158,170,225,250,88,172,27,50,81,51,212,147,184,59,28,191,102,145,3,93,41,154,186,57,71,245,86,95,172,235,170,186,205,158,156,193,117,78,118,94,24,191,75,79,45,247,202,99,213,177,182,180,84,171,166,109,120,133,94,6,126,36,191,47,39,40,98,119,83,118,93,27,123,47,189,38,114,177,68,197,77,44,163,154,241,142,171,24,222,137,137,160,186,9,10,113,183,144,220,21,151,5,237,66,226,232,80,173,172,2,57,251,73,128,64,83,74,168,206,192,105,142,230,6,149,21,30,169,133,6,108,56,205,40,170,23,34,104,188,176,166,81,113,172,23,221,0,2,167,213,115,70,206,96,219,221,113,14,97,187,93,181,224,122,79,183,218,82,124,119,124,141,230,190,204,48,30,203,36,79,197,35,75,114,188,168,90,62,12,86,11,147,102,171,183,121,73,14,224,251,144,197,108,47,222,218,232,93,116,27,223,131,225,242,57,52,128,252,157,239,45,125,56,61,245,88,185,133,239,211,210,65,47,28,137,50,136,162,2,6,67,160,159,240,85,99,162,71,68,187,64,194,87,231,123,112,55,95,254,95,154,46,129,206,206,108,253,126,195,243,51,4,219,107,169,34,5,51,41,147,94,245,221,138,247,86,245,125,228,244,57,24,239,156,193,75,76,112,239,12,214,70,239,154,193,198,247,224,25,44,200,32,111,47,222,65,3,168,205,109,247,66,104,251,239,216,4,109,163,127,91,1,107,251,184,234,76,251,232,229,15,61,145,89,106,235,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba4b43c8-f982-4731-bcc4-789f93b7df6e"));
		}

		#endregion

	}

	#endregion

}

