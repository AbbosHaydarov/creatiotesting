﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchModelSchema

	/// <exclude/>
	public class TouchModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchModelSchema(TouchModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("deb8c021-0b2e-4228-b41f-437eeb8fbc4b");
			Name = "TouchModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,85,221,107,219,48,16,127,118,161,255,195,145,66,73,96,216,239,109,146,81,154,177,101,172,163,144,208,61,140,61,40,246,37,17,200,146,39,157,90,178,182,255,251,78,86,98,199,77,90,24,140,190,24,235,62,126,247,161,251,157,180,40,209,85,34,71,152,163,181,194,153,37,165,215,70,47,229,202,91,65,210,232,211,147,199,211,147,196,59,169,87,240,29,31,200,232,218,230,171,51,250,178,81,204,54,142,176,108,207,251,88,101,105,244,206,156,13,206,44,174,24,22,174,149,112,238,2,230,198,231,235,27,83,160,170,181,89,150,193,208,249,178,20,118,51,222,158,107,75,32,3,22,43,139,14,53,193,66,56,4,135,86,10,37,255,136,133,66,86,51,14,148,1,40,152,86,214,228,232,92,186,131,204,246,48,43,191,80,50,135,188,134,109,227,95,192,244,211,111,47,40,192,13,91,113,240,224,14,240,183,73,253,214,154,10,45,73,228,252,111,107,176,168,255,25,170,156,174,180,177,248,43,156,183,129,62,123,89,192,180,128,71,88,33,93,114,218,252,121,126,211,67,114,137,147,109,255,255,193,109,34,8,231,178,68,248,38,28,93,229,193,187,17,189,134,178,173,101,211,159,224,82,120,69,119,66,121,252,34,116,161,194,61,142,224,152,56,141,161,7,251,177,29,217,224,112,39,157,36,99,223,168,246,127,5,172,187,202,147,74,34,167,247,10,247,3,23,87,90,168,13,201,220,189,115,165,51,178,40,202,227,209,206,80,23,113,52,187,115,122,131,180,54,197,139,33,125,201,176,72,49,83,86,130,185,5,185,183,54,16,76,106,71,66,243,86,120,144,180,6,161,13,173,209,130,209,204,186,10,115,185,148,88,4,110,29,146,43,74,24,76,148,160,121,183,140,122,181,107,111,60,221,33,154,37,176,4,34,226,208,33,66,110,113,57,234,181,148,235,101,227,192,225,60,38,149,14,179,26,174,69,183,72,222,106,55,142,89,75,110,53,175,6,199,173,100,211,157,110,175,127,247,210,146,23,10,22,198,40,8,20,87,174,223,6,139,137,12,96,52,102,142,166,91,117,45,75,167,197,32,192,36,231,231,13,27,187,6,59,105,99,118,72,188,174,195,161,190,113,237,55,179,220,117,105,196,3,120,122,58,62,129,93,135,163,38,131,38,206,110,144,186,78,51,138,210,54,157,118,190,71,35,208,94,241,126,102,77,242,49,246,43,125,69,125,209,110,128,110,128,189,76,226,59,16,175,82,106,86,74,42,76,158,237,95,153,185,231,7,68,22,60,109,113,173,204,13,39,200,63,253,1,132,215,40,73,226,53,67,160,89,58,219,190,3,216,167,181,116,31,128,172,199,16,36,73,142,243,35,74,187,194,231,191,153,118,124,163,8,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deb8c021-0b2e-4228-b41f-437eeb8fbc4b"));
		}

		#endregion

	}

	#endregion

}

