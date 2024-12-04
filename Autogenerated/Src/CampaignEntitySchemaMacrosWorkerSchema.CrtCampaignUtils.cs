﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEntitySchemaMacrosWorkerSchema

	/// <exclude/>
	public class CampaignEntitySchemaMacrosWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEntitySchemaMacrosWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEntitySchemaMacrosWorkerSchema(CampaignEntitySchemaMacrosWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79abe05c-8343-4375-9028-d7e66f2cdf76");
			Name = "CampaignEntitySchemaMacrosWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,85,75,111,219,56,16,62,171,64,255,195,192,189,200,128,35,55,77,218,4,105,98,35,235,56,69,208,6,40,26,183,5,118,177,7,154,30,219,220,72,164,74,82,78,140,192,255,189,124,201,146,108,199,57,236,105,247,34,136,243,248,230,193,153,143,156,100,168,114,66,17,70,40,37,81,98,170,147,129,224,83,54,43,36,209,76,240,215,175,158,94,191,138,10,197,248,12,238,150,74,99,246,113,227,108,236,211,20,169,53,86,201,39,228,40,25,221,178,249,194,248,175,74,88,143,149,101,130,239,214,212,178,72,6,36,203,9,155,113,245,178,233,119,205,210,103,204,36,62,39,79,134,92,51,205,208,58,26,147,55,18,103,6,11,6,41,81,234,12,202,232,206,104,121,71,231,152,145,91,66,165,80,63,133,188,71,233,124,186,221,46,156,171,34,203,136,92,246,194,249,10,21,149,108,140,10,104,128,128,204,249,193,131,115,4,45,96,134,186,20,46,72,90,24,219,169,144,128,46,20,40,23,43,232,147,50,74,183,22,230,175,122,34,113,235,233,195,241,224,250,242,244,221,229,193,241,224,240,221,193,241,213,225,209,193,233,96,120,114,240,118,248,254,244,232,112,120,242,254,195,201,219,85,171,253,183,113,205,139,113,202,40,80,91,228,139,53,194,25,252,65,20,122,117,179,248,200,140,136,249,174,187,118,139,122,46,38,166,111,95,37,91,16,141,94,155,251,3,136,241,63,102,90,224,90,200,140,232,59,81,72,138,63,108,221,177,135,54,211,84,100,220,73,128,86,255,109,176,115,24,69,108,10,113,77,108,135,207,252,39,87,68,19,39,24,45,115,4,166,192,8,112,196,50,108,42,38,65,106,15,37,98,36,81,23,146,135,132,74,63,159,82,61,146,251,118,26,16,201,103,198,39,109,59,83,81,180,114,223,128,181,229,231,108,86,123,26,209,140,27,84,110,30,58,208,208,217,144,112,111,227,134,252,23,68,174,147,242,109,187,240,142,182,13,86,120,151,19,238,43,237,3,199,135,53,92,28,199,165,186,237,28,218,201,136,209,123,213,246,198,103,16,151,150,94,237,235,84,15,76,211,57,196,245,20,34,106,38,99,59,77,123,43,120,230,45,202,206,52,50,117,6,31,95,132,176,146,18,198,86,75,11,105,214,227,187,66,105,53,127,10,110,75,182,71,67,4,220,51,81,50,40,100,105,148,172,173,250,125,40,255,111,248,84,24,170,112,76,85,75,175,161,54,112,11,148,218,221,182,48,182,113,35,249,206,142,60,218,251,139,169,21,50,193,41,41,82,189,175,59,181,185,10,147,243,6,249,196,239,216,115,11,231,54,218,43,55,249,200,9,190,185,56,106,131,112,232,154,193,45,197,108,115,140,151,228,68,146,12,184,121,49,46,90,222,191,98,254,86,175,250,7,49,53,129,209,172,175,196,233,69,203,115,133,109,104,171,219,75,206,187,14,102,55,42,145,179,34,51,45,85,173,222,87,41,40,226,4,214,162,253,158,102,40,231,126,145,180,33,247,86,239,58,37,51,75,174,36,207,211,165,37,212,160,217,70,241,157,87,27,249,107,203,22,181,34,174,152,83,153,126,60,93,166,140,168,14,216,253,159,184,123,186,21,19,76,87,190,184,18,205,237,185,167,215,5,147,186,32,41,84,16,231,74,75,147,203,22,70,15,62,161,246,237,114,66,21,223,12,185,169,94,146,113,138,231,85,31,123,225,250,170,148,59,126,140,2,109,172,123,214,129,177,16,41,52,155,83,231,141,172,22,204,236,208,13,215,40,57,73,67,243,227,173,48,21,116,152,116,75,199,187,225,163,58,118,63,49,6,67,66,231,241,35,92,244,74,139,232,209,147,163,255,154,248,219,111,66,176,40,247,106,181,139,108,155,129,70,162,106,116,92,198,177,65,31,147,207,184,12,141,138,150,86,98,201,112,227,10,214,169,69,101,78,203,122,142,165,123,228,94,147,74,185,235,21,10,166,171,64,167,253,64,190,47,79,65,236,139,92,253,139,53,118,87,94,31,251,255,208,90,255,159,23,178,109,199,110,19,115,207,150,117,64,75,63,253,59,232,223,15,72,83,104,100,191,1,112,80,176,202,211,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79abe05c-8343-4375-9028-d7e66f2cdf76"));
		}

		#endregion

	}

	#endregion

}

