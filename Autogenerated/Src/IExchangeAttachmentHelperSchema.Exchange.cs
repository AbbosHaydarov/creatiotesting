﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IExchangeAttachmentHelperSchema

	/// <exclude/>
	public class IExchangeAttachmentHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IExchangeAttachmentHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IExchangeAttachmentHelperSchema(IExchangeAttachmentHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a10a6d20-ad3e-492b-842d-e9cb61fb4dd9");
			Name = "IExchangeAttachmentHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,86,77,107,219,64,16,61,55,144,255,48,56,23,7,140,116,79,28,65,156,186,169,160,129,80,55,244,80,122,88,73,35,123,65,90,137,221,85,82,81,242,223,59,210,234,211,150,85,57,180,1,99,236,153,217,183,243,222,155,93,9,4,139,81,165,204,71,248,134,82,50,149,132,218,186,75,68,200,183,153,100,154,39,226,252,236,247,249,217,135,76,113,177,133,77,174,52,198,148,143,34,244,139,164,178,238,81,160,228,254,117,83,243,192,125,153,148,48,235,95,254,142,137,45,90,223,209,219,160,124,230,62,42,235,35,211,172,45,238,238,41,145,226,148,185,144,184,37,104,112,133,70,25,82,103,87,224,214,80,183,90,51,127,23,163,208,159,49,74,81,82,57,125,108,219,134,165,202,226,152,201,220,169,254,215,43,128,53,75,20,236,202,69,192,107,100,171,41,166,128,96,17,4,152,162,8,80,248,57,188,72,70,181,117,197,210,238,224,167,153,23,113,191,133,25,237,143,212,163,239,134,213,3,234,93,18,168,43,120,44,65,76,114,159,64,25,184,147,200,52,42,74,32,130,47,49,188,153,53,138,214,63,42,89,103,182,67,221,40,205,132,225,116,216,178,137,164,76,178,24,10,203,111,102,153,66,73,70,11,99,228,204,233,108,243,212,79,117,193,151,118,137,113,28,114,29,51,30,221,6,129,68,165,102,206,166,80,83,2,22,65,96,38,122,136,33,81,103,82,40,231,84,166,75,187,94,89,64,237,85,86,250,237,69,231,125,110,208,87,97,1,74,203,98,46,247,153,92,94,143,25,197,162,72,129,199,69,0,177,113,23,194,68,14,251,86,96,62,16,32,219,150,84,94,184,222,85,26,82,97,37,35,167,51,230,6,148,158,106,165,170,180,121,131,128,35,110,86,109,12,130,186,117,139,19,177,82,153,208,105,208,28,213,48,222,163,201,231,27,212,227,160,181,225,171,36,35,185,167,72,124,108,90,58,101,176,97,33,174,200,191,130,214,124,127,142,42,117,23,96,72,131,209,101,1,157,158,161,229,55,58,41,95,77,3,7,142,199,109,187,221,235,202,111,238,217,169,147,80,3,57,39,42,115,236,64,158,220,103,95,100,119,45,178,24,37,243,34,92,182,87,163,3,247,168,205,233,106,65,230,61,67,170,141,254,143,152,16,242,136,110,110,12,192,203,15,86,183,75,78,58,130,255,72,248,46,100,175,19,167,149,10,120,112,220,177,79,53,181,119,180,110,149,187,193,160,125,205,117,218,165,50,225,42,29,210,144,136,117,158,174,214,151,132,5,243,203,130,141,185,114,167,250,212,118,50,108,85,127,155,163,102,61,39,60,128,162,135,182,118,222,95,218,225,252,166,41,102,189,38,252,132,222,53,136,246,251,178,180,199,238,130,225,6,251,67,228,229,26,127,252,44,102,166,221,141,158,182,69,229,223,229,186,160,119,7,243,210,84,254,127,53,47,135,189,224,235,31,103,69,48,188,191,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a10a6d20-ad3e-492b-842d-e9cb61fb4dd9"));
		}

		#endregion

	}

	#endregion

}

