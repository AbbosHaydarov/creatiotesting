﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AuditServiceSchema

	/// <exclude/>
	public class AuditServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AuditServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AuditServiceSchema(AuditServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd3e9212-9669-40ca-9941-18525c31b20e");
			Name = "AuditService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("43f796d0-2535-4ae5-88b4-0c05eb1809e5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,81,111,218,48,16,126,14,18,255,193,227,41,8,20,109,175,91,59,41,109,55,169,19,180,85,9,234,164,136,7,147,92,192,140,216,169,237,80,101,21,255,125,231,196,9,9,48,26,9,18,127,119,190,251,238,187,179,57,77,65,101,52,2,18,128,148,84,137,68,123,183,130,39,108,149,75,170,153,224,158,159,199,76,207,64,238,88,4,253,222,123,191,231,228,138,241,21,153,21,74,67,250,237,104,237,77,24,127,61,1,237,246,169,136,97,123,209,232,189,192,242,178,131,31,105,182,43,153,29,252,218,212,37,116,249,159,243,194,36,232,148,166,165,21,237,161,205,128,27,181,164,145,94,24,204,87,217,3,104,116,203,48,206,146,109,153,46,158,225,53,103,18,82,224,90,185,237,133,161,70,174,201,7,91,140,151,103,129,120,104,146,100,249,114,203,34,18,109,169,82,164,45,52,249,74,110,168,130,70,118,7,117,199,127,39,124,204,160,170,171,205,213,9,177,162,123,190,19,127,192,157,130,94,139,24,201,12,158,30,103,193,96,76,230,146,5,144,102,91,170,13,197,193,84,236,32,16,190,140,214,108,7,104,190,17,113,49,211,197,214,24,49,202,20,148,162,43,104,80,239,69,210,44,131,120,108,210,56,134,60,40,253,83,200,148,234,206,134,10,242,126,41,193,199,228,25,71,74,112,5,151,253,74,5,106,9,24,215,164,67,205,85,90,154,174,41,77,165,190,67,242,99,98,17,224,113,123,29,46,136,168,69,9,138,12,212,144,152,33,117,156,199,54,122,236,229,227,44,20,200,236,125,111,6,196,113,76,196,128,165,112,200,247,27,173,53,234,61,136,183,35,63,203,226,188,23,75,136,251,169,129,3,89,60,81,169,76,73,77,45,34,215,173,84,195,154,179,35,65,231,146,147,207,85,156,253,165,104,141,14,38,86,77,231,114,164,142,36,36,202,165,196,185,236,128,150,63,118,99,131,149,217,205,137,144,196,53,24,43,49,124,93,29,105,238,77,128,175,244,26,77,163,81,195,192,240,254,193,243,180,161,124,213,73,245,221,237,198,8,217,162,170,229,28,175,67,93,135,176,247,234,14,18,198,33,118,53,122,136,196,237,238,24,127,20,200,41,135,0,79,164,98,127,193,149,144,156,25,17,100,116,130,217,98,201,136,124,25,86,2,225,115,234,22,110,22,40,215,255,69,198,103,51,26,213,223,85,131,236,203,246,29,21,151,226,237,86,228,248,113,125,124,203,53,17,39,98,213,89,204,181,185,121,24,54,165,123,160,230,10,36,222,26,28,240,6,53,167,244,48,126,213,225,118,234,25,26,19,35,47,6,92,226,249,247,213,97,113,177,127,101,205,67,43,136,29,190,154,125,9,154,162,240,215,239,237,255,1,163,209,231,167,117,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd3e9212-9669-40ca-9941-18525c31b20e"));
		}

		#endregion

	}

	#endregion

}

