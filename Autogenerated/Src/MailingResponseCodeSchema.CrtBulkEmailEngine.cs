﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingResponseCodeSchema

	/// <exclude/>
	public class MailingResponseCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingResponseCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingResponseCodeSchema(MailingResponseCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f16fb810-609b-4c01-9b2c-447b893d5c8f");
			Name = "MailingResponseCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c79d6b8e-4dfb-4af0-8a52-3dfabe5c47b0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,86,77,111,19,49,16,61,167,82,255,131,37,14,20,9,53,109,104,11,5,202,161,73,11,149,74,41,73,202,221,89,79,90,211,93,123,241,71,164,21,226,191,51,99,239,70,21,141,157,229,16,105,99,207,123,111,102,60,158,177,226,21,216,154,23,192,230,96,12,183,122,233,246,199,90,45,229,189,55,220,73,173,216,239,221,157,129,183,82,221,179,89,99,29,84,31,118,119,112,229,133,129,123,218,189,80,190,122,207,190,114,89,162,197,20,169,180,178,48,214,2,130,213,112,56,100,31,173,175,42,110,154,79,237,255,206,136,21,104,197,164,98,85,4,239,119,246,195,39,128,218,47,74,89,48,64,149,77,34,193,185,103,42,97,225,51,40,48,188,100,6,126,121,176,142,45,17,237,13,144,202,115,153,193,52,90,93,162,17,8,118,198,14,95,7,255,55,83,207,64,185,4,15,109,33,124,148,131,79,161,144,43,84,89,52,172,54,122,37,5,24,182,39,160,228,13,136,87,9,222,9,44,233,120,74,228,126,147,231,254,9,133,3,145,12,51,110,35,205,17,210,12,6,73,162,43,85,104,99,208,152,113,33,12,88,11,169,212,93,169,21,47,37,81,30,231,41,55,198,141,105,247,233,176,191,135,93,164,62,201,83,135,180,59,189,230,77,208,221,106,44,96,113,219,137,159,177,183,185,92,126,225,70,176,115,237,85,145,10,157,44,162,1,114,189,203,150,76,205,171,84,201,224,22,194,79,115,240,59,101,253,66,218,194,200,69,202,151,96,66,149,123,144,35,186,150,234,145,233,26,84,130,101,140,183,237,49,222,128,108,13,207,176,79,228,115,67,22,235,220,28,102,139,246,182,228,74,37,107,182,221,37,150,163,28,203,55,140,42,73,18,55,137,227,56,199,49,230,232,47,117,128,61,79,233,140,9,23,172,148,214,165,74,180,131,76,244,141,118,119,22,46,168,157,145,208,105,63,33,217,94,31,32,220,54,145,246,174,117,26,163,131,190,26,221,101,238,169,210,154,175,117,14,251,233,44,240,168,30,251,105,156,147,233,154,127,212,143,223,61,128,193,145,97,153,210,12,39,81,93,114,7,216,224,107,44,90,206,150,218,224,119,33,107,137,205,96,155,252,188,69,227,153,93,98,145,82,101,140,122,86,134,5,133,205,227,165,101,66,163,251,10,125,113,108,5,70,46,37,246,177,188,234,44,64,237,36,0,81,250,71,11,35,245,147,255,84,87,56,184,163,54,85,68,63,225,27,196,144,108,219,175,71,217,246,55,15,201,230,244,43,13,112,209,48,235,139,135,120,186,52,182,201,19,122,21,112,47,48,227,201,62,48,241,225,120,218,161,147,111,42,145,49,61,90,131,30,178,100,187,201,56,196,28,146,85,232,170,242,138,212,233,169,82,202,74,186,45,137,26,63,69,92,19,128,174,50,149,127,102,250,116,224,127,186,6,230,40,38,171,93,171,137,211,210,248,139,203,174,169,97,139,59,161,169,183,124,231,205,28,1,20,254,81,136,254,79,124,135,97,86,226,83,108,119,7,87,254,2,116,119,127,156,207,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f16fb810-609b-4c01-9b2c-447b893d5c8f"));
		}

		#endregion

	}

	#endregion

}

