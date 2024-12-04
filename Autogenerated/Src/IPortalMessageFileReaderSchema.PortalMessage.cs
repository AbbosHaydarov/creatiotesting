﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPortalMessageFileReaderSchema

	/// <exclude/>
	public class IPortalMessageFileReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPortalMessageFileReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPortalMessageFileReaderSchema(IPortalMessageFileReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("036d92f0-de76-43ba-9d4d-3a87133b254f");
			Name = "IPortalMessageFileReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,85,77,79,227,48,16,61,131,196,127,24,149,11,72,168,189,67,233,97,129,237,70,2,138,104,197,101,181,7,55,158,180,214,38,118,214,118,144,2,226,191,239,216,73,250,145,184,221,236,165,173,103,230,189,121,158,25,79,37,203,208,228,44,70,88,160,214,204,168,196,14,239,148,76,196,170,208,204,10,37,207,78,63,207,78,79,10,35,228,10,230,165,177,152,221,180,206,20,159,166,24,187,96,51,156,162,68,45,226,78,76,52,235,152,94,11,105,69,134,195,57,1,88,42,62,124,186,109,212,86,207,115,33,92,208,187,136,241,73,113,76,135,247,204,50,18,105,53,139,45,1,8,114,174,113,69,104,128,187,148,25,115,13,47,74,91,150,62,161,49,108,133,223,69,138,247,139,153,15,252,185,139,253,69,134,188,88,166,34,134,216,225,14,192,78,92,5,54,41,94,180,202,81,91,129,46,141,7,123,226,138,249,9,179,37,234,139,103,170,42,220,194,32,226,131,75,151,164,201,50,45,4,135,136,195,39,172,208,222,128,113,31,95,135,225,119,26,153,69,254,173,12,176,108,124,255,73,54,147,251,100,198,106,87,237,141,183,47,157,251,14,50,249,128,158,36,115,241,209,34,17,210,130,179,246,150,161,44,154,176,14,231,233,75,179,40,243,150,144,71,165,126,23,57,141,118,145,73,112,238,190,84,111,168,13,205,73,247,90,181,35,196,115,142,146,87,227,69,167,202,182,107,10,12,248,174,60,31,48,26,141,96,108,138,44,99,186,156,212,103,31,11,118,205,44,104,204,53,26,36,25,169,71,66,236,161,195,6,57,218,129,30,127,35,251,153,171,183,17,170,3,23,38,79,89,249,198,210,34,60,40,247,59,1,237,162,132,41,115,45,156,198,40,163,215,121,152,247,165,29,213,143,252,189,75,232,31,90,152,226,104,147,34,105,81,39,180,84,175,33,234,172,148,87,100,28,245,193,158,109,176,144,40,237,146,90,119,167,220,179,64,86,209,64,66,60,192,233,14,193,254,109,103,174,102,58,36,2,168,121,238,186,109,29,222,240,168,24,55,144,10,99,65,37,33,1,6,150,101,203,238,228,116,245,84,150,156,105,150,129,164,106,223,14,242,93,61,180,36,39,17,167,209,20,137,32,77,157,100,195,241,200,99,195,84,180,183,56,85,104,150,251,255,159,193,228,193,252,129,218,6,170,50,118,9,52,218,66,75,51,25,143,154,95,206,21,61,200,34,67,205,150,41,142,67,255,4,19,152,162,237,56,204,69,61,119,173,75,93,193,235,158,180,70,85,125,188,188,249,103,237,89,28,19,153,32,57,190,222,125,139,187,166,150,41,93,206,227,53,102,204,175,233,137,159,113,42,172,241,54,63,89,117,84,53,69,71,43,92,183,225,71,5,232,118,75,99,172,52,7,154,251,134,179,74,115,156,213,221,200,113,185,18,130,216,18,90,5,75,164,37,69,243,201,15,55,110,110,169,154,153,203,190,125,10,251,205,172,35,66,29,107,26,214,41,212,85,179,66,246,60,174,149,181,189,18,237,90,23,92,0,95,127,1,144,240,22,71,78,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("036d92f0-de76-43ba-9d4d-3a87133b254f"));
		}

		#endregion

	}

	#endregion

}

