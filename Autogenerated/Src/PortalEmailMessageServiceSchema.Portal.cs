﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalEmailMessageServiceSchema

	/// <exclude/>
	public class PortalEmailMessageServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalEmailMessageServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalEmailMessageServiceSchema(PortalEmailMessageServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2da881e-69a0-4267-8efc-c499e036bc63");
			Name = "PortalEmailMessageService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("221a1177-e530-45e1-8abc-49575f2d8a6d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,86,77,111,219,56,16,61,187,64,255,3,225,189,200,128,65,223,219,196,128,227,166,173,219,117,227,181,179,155,67,208,3,45,141,29,162,146,168,144,84,178,218,34,255,125,135,31,178,36,91,242,199,69,128,200,153,55,143,195,153,55,76,89,2,42,99,33,144,123,144,146,41,177,209,116,42,210,13,223,230,146,105,46,210,247,239,126,191,127,215,203,21,79,183,100,85,40,13,201,199,189,127,186,204,83,205,19,160,43,144,156,197,252,63,235,119,96,133,187,47,60,132,185,136,32,62,186,73,39,161,230,47,167,65,232,3,172,43,131,58,253,36,169,187,214,119,36,116,173,211,79,55,157,91,183,120,62,205,65,181,25,32,137,35,17,171,221,146,250,82,228,26,109,208,24,205,255,144,176,197,99,146,105,204,148,250,64,22,66,106,22,223,38,140,199,115,80,138,109,193,59,89,227,209,104,68,174,84,158,36,76,22,99,255,239,247,201,70,72,242,42,228,47,19,253,149,235,39,146,89,40,2,6,139,36,14,76,209,18,101,84,131,121,244,24,120,235,90,178,80,255,180,107,42,171,241,5,187,54,81,217,15,208,120,154,12,239,102,205,99,174,139,37,60,231,92,66,2,169,86,65,253,199,92,16,185,38,39,92,140,21,245,11,209,192,4,201,242,117,204,67,18,154,124,116,167,131,124,32,55,76,85,201,233,97,137,226,119,151,206,57,232,39,17,153,132,74,83,72,46,125,189,204,253,96,206,98,8,53,249,2,186,45,128,217,11,190,228,60,34,33,134,240,203,95,185,210,66,22,179,104,64,76,55,244,122,47,76,18,80,207,120,196,20,94,137,173,143,98,21,62,97,186,255,202,65,22,193,223,10,36,38,52,69,48,36,68,235,6,115,150,34,162,28,146,254,244,32,64,127,96,138,168,215,67,104,138,220,205,21,89,188,169,136,243,36,165,51,53,137,95,89,161,252,9,174,137,150,185,45,104,71,40,115,30,223,161,248,204,99,13,18,13,12,208,84,2,30,219,45,61,96,109,44,152,196,166,199,31,21,184,69,123,63,146,43,145,222,23,25,86,251,115,206,226,161,69,181,68,150,66,104,71,157,154,156,185,32,142,209,15,4,10,6,195,246,84,85,71,113,97,20,157,68,81,176,79,114,80,241,63,68,217,29,212,160,96,112,247,223,150,98,15,211,5,65,29,223,160,191,184,157,247,49,245,75,8,121,198,177,6,251,23,58,174,32,141,64,94,234,229,109,76,122,103,209,217,206,83,227,186,120,18,90,156,118,114,215,69,103,152,15,249,77,112,19,250,160,184,251,3,58,81,142,211,192,217,247,232,93,69,242,176,28,77,216,210,112,166,108,93,4,109,85,139,206,149,105,157,131,85,114,172,124,31,121,210,140,59,105,58,158,140,129,151,38,100,84,139,244,39,108,244,29,202,147,143,102,20,12,5,204,7,155,54,131,77,59,131,77,170,123,245,8,85,186,37,232,92,166,157,149,105,141,222,188,248,32,130,211,159,46,49,178,218,230,54,247,181,220,46,96,129,171,86,225,38,161,171,115,136,136,22,228,10,155,149,37,18,54,36,197,246,187,238,183,53,95,127,180,67,109,136,189,91,177,0,199,188,199,135,23,64,120,132,237,194,55,28,36,189,26,89,132,10,208,165,73,141,23,45,228,209,186,220,54,246,143,119,25,184,151,69,125,224,244,30,113,82,206,210,23,241,11,2,151,48,108,250,254,226,110,117,143,151,99,38,4,40,253,89,200,132,25,49,64,83,207,205,45,209,111,40,93,67,114,35,162,98,165,139,24,26,38,187,85,250,32,89,150,65,228,148,109,137,175,30,145,42,56,14,106,103,82,57,148,58,199,81,137,213,62,82,78,15,19,175,114,170,20,187,99,147,233,136,210,58,127,122,251,47,132,216,19,43,124,10,196,224,90,38,192,9,128,213,77,174,199,118,92,157,62,136,227,213,107,200,22,18,115,48,70,136,157,68,253,195,226,28,174,204,249,198,193,190,198,249,1,178,19,218,78,119,165,37,82,69,128,154,38,123,103,215,148,167,61,75,81,110,184,149,189,156,32,169,211,236,119,50,107,33,222,134,4,159,61,103,36,42,59,176,104,10,199,225,254,17,201,112,171,123,139,165,140,28,114,41,73,116,62,14,151,144,73,80,230,161,133,103,247,132,237,227,144,167,27,91,227,6,151,173,205,73,47,120,46,126,98,154,213,91,247,188,39,91,69,214,60,214,58,4,208,250,97,31,152,235,163,237,250,101,195,207,33,89,131,12,204,235,195,200,132,115,232,55,154,213,213,6,241,21,244,155,108,65,127,68,100,252,248,220,31,33,32,203,66,188,128,195,206,167,149,70,213,5,151,49,41,245,95,99,83,213,5,248,124,94,73,179,43,127,214,184,89,93,106,182,248,185,236,108,183,212,8,17,177,241,181,227,238,194,12,44,211,124,23,95,98,179,105,91,248,182,246,246,30,237,214,70,122,251,31,216,180,30,152,234,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2da881e-69a0-4267-8efc-c499e036bc63"));
		}

		#endregion

	}

	#endregion

}

