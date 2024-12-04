﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseSysSettingsEventListenerSchema

	/// <exclude/>
	public class BaseSysSettingsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseSysSettingsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseSysSettingsEventListenerSchema(BaseSysSettingsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d60ddd2-9b0e-424d-b70f-0c08ecaab2fc");
			Name = "BaseSysSettingsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,111,219,48,12,61,187,64,255,3,209,93,28,192,112,238,107,19,32,203,218,162,67,247,1,36,217,206,138,77,59,26,108,201,147,228,172,217,144,255,62,201,146,99,203,105,186,34,219,197,144,72,190,71,62,154,34,35,37,202,138,36,8,75,20,130,72,158,169,120,206,89,70,243,90,16,69,57,187,188,248,125,121,17,212,146,178,28,22,59,169,176,188,30,220,227,71,202,126,116,198,62,79,89,114,246,188,71,224,41,123,124,203,20,85,20,229,95,3,226,219,45,50,101,226,116,228,27,129,185,46,23,230,5,145,242,45,188,35,18,117,121,11,84,74,51,200,38,242,145,234,114,25,138,38,126,60,30,195,141,172,203,146,136,221,212,221,27,44,84,130,111,105,138,18,214,154,3,10,158,211,4,120,6,104,40,96,67,88,90,152,154,50,46,64,54,250,65,186,36,113,75,59,238,241,86,245,186,208,4,100,45,149,32,137,130,164,201,241,82,121,55,75,163,178,17,185,155,130,149,98,111,3,21,65,240,115,131,66,255,185,46,94,135,219,131,246,234,255,102,98,218,198,124,68,181,225,169,110,205,23,65,183,68,161,245,86,246,2,91,78,83,152,37,170,38,5,253,133,33,95,127,71,93,172,228,181,72,48,114,156,115,45,62,199,229,174,66,192,129,97,4,102,74,130,128,102,16,222,23,124,77,138,89,85,181,234,226,59,36,170,22,184,242,53,179,156,178,3,48,216,18,225,210,57,37,19,8,237,105,100,205,215,93,92,45,81,232,33,101,186,68,163,108,226,1,227,149,231,117,176,126,143,146,238,56,129,185,208,197,97,231,13,125,242,145,195,123,25,238,81,205,121,81,151,236,43,41,106,252,100,158,80,56,178,113,65,252,205,252,147,48,105,252,198,5,147,169,95,223,131,236,129,31,57,73,49,237,133,143,14,68,31,56,101,218,33,94,204,26,193,147,73,240,20,129,22,51,133,93,4,161,57,143,26,227,129,234,142,139,91,146,108,6,85,245,184,23,30,119,47,46,242,107,247,107,240,202,110,59,117,24,162,147,61,141,122,153,163,227,81,178,60,123,243,221,187,17,70,150,218,41,54,183,19,67,205,149,102,199,180,29,107,119,237,30,94,127,2,142,126,186,63,51,131,1,51,21,157,32,245,159,205,107,9,35,104,36,62,63,147,175,121,109,215,199,125,121,190,43,205,242,177,206,225,194,115,6,68,72,4,102,147,171,19,107,38,254,204,30,152,174,94,203,190,26,119,184,254,138,107,119,28,223,234,61,173,55,167,237,74,135,59,108,19,93,46,138,86,223,44,83,40,154,84,51,145,75,56,108,2,179,117,123,73,195,22,213,14,70,183,164,124,190,174,61,113,139,181,136,253,191,234,95,85,41,57,67,190,131,157,165,190,197,158,33,222,65,255,147,246,247,88,224,25,218,29,236,44,237,45,246,12,237,14,234,105,31,60,18,107,245,141,218,6,127,0,252,90,31,89,9,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d60ddd2-9b0e-424d-b70f-0c08ecaab2fc"));
		}

		#endregion

	}

	#endregion

}

