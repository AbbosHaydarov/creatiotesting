﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WizardServiceSchema

	/// <exclude/>
	public class WizardServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WizardServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WizardServiceSchema(WizardServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("467d8f7f-4fb4-4876-adaa-b5904a205d6f");
			Name = "WizardService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,81,111,218,48,16,126,14,82,255,195,137,190,4,137,133,173,213,94,216,58,169,165,155,202,186,66,69,168,120,168,166,202,36,7,88,77,236,204,118,168,40,226,191,239,108,167,37,116,45,235,11,224,207,223,221,125,119,159,15,193,114,212,5,75,16,198,168,20,211,114,102,162,158,20,51,62,47,21,51,92,138,131,198,250,160,17,148,154,139,57,196,43,109,48,143,98,84,75,158,224,149,76,49,251,178,239,50,58,77,12,95,186,52,251,121,19,156,110,9,91,33,4,147,152,60,175,135,215,101,42,140,98,67,159,116,75,247,135,10,231,84,9,122,25,211,186,11,19,254,200,84,90,149,113,132,78,167,3,95,117,153,231,76,173,190,85,231,27,195,51,110,86,160,61,15,18,27,12,51,169,224,65,170,123,91,240,129,155,69,149,44,122,74,210,169,101,185,173,74,208,212,140,98,137,249,109,177,83,93,12,208,144,246,130,186,159,186,18,35,252,83,114,133,57,10,163,195,250,193,142,0,78,224,63,33,150,21,85,64,218,178,69,138,114,154,241,164,82,188,211,45,116,225,140,105,124,238,61,176,22,110,231,35,133,54,140,82,118,225,90,89,123,252,116,130,194,31,32,177,247,160,141,178,221,127,23,75,174,164,176,18,250,130,27,206,50,254,136,170,199,146,5,94,226,106,140,121,145,217,152,19,104,190,198,116,214,199,137,226,133,185,91,127,220,220,173,63,109,154,222,172,224,16,69,234,5,217,83,93,223,21,154,133,76,173,58,215,160,167,191,244,206,1,189,12,153,178,122,183,207,21,180,171,6,51,37,115,72,152,94,88,207,254,53,45,184,29,22,232,35,234,190,5,183,244,228,250,98,41,239,49,244,50,108,103,215,195,120,220,108,195,153,76,87,177,89,101,182,91,162,93,161,214,108,142,207,104,52,81,172,40,48,109,219,60,129,117,10,181,249,33,85,206,204,78,128,135,162,159,90,138,54,140,104,249,104,220,184,159,231,236,126,242,123,41,121,234,59,223,217,83,63,229,176,5,228,181,83,64,45,143,135,231,195,46,140,6,231,31,142,143,142,63,31,57,184,242,53,169,28,164,146,30,137,124,189,240,125,134,183,225,134,54,134,4,8,164,21,151,34,234,149,74,81,136,69,233,119,102,74,218,205,1,253,183,248,105,4,47,216,49,181,72,223,253,180,101,23,59,8,250,46,191,219,101,192,183,222,209,5,19,105,86,73,241,212,147,125,201,29,47,154,208,246,254,146,9,203,236,145,218,12,223,126,167,85,254,102,165,233,253,58,104,45,115,185,196,240,105,166,85,130,93,123,188,184,11,204,232,221,69,222,62,75,15,119,197,251,208,205,43,43,226,177,58,116,208,32,236,47,211,223,45,65,192,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("467d8f7f-4fb4-4876-adaa-b5904a205d6f"));
		}

		#endregion

	}

	#endregion

}

