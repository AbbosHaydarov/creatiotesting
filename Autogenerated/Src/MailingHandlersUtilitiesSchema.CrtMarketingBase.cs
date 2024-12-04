﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingHandlersUtilitiesSchema

	/// <exclude/>
	public class MailingHandlersUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingHandlersUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingHandlersUtilitiesSchema(MailingHandlersUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81956123-ee55-4f78-a3d5-3f88f5d02b6c");
			Name = "MailingHandlersUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,86,219,110,219,56,16,125,86,129,254,3,87,251,34,3,134,220,231,54,10,80,164,78,107,32,89,100,145,118,247,177,96,165,177,77,172,68,185,36,229,212,40,242,239,59,188,74,148,101,39,237,110,17,32,176,200,225,204,153,153,51,23,78,27,144,59,90,2,249,8,66,80,217,174,85,126,213,242,53,219,116,130,42,214,242,151,47,190,191,124,145,116,146,241,77,36,34,224,205,137,243,124,201,21,83,12,100,47,112,127,144,10,154,241,55,74,215,53,148,218,138,204,223,3,7,193,202,35,153,27,198,191,158,180,116,77,75,213,10,107,74,255,37,191,11,216,160,58,114,85,83,41,95,147,91,202,106,124,246,129,242,170,6,33,63,41,252,212,200,80,114,177,88,144,11,217,53,13,21,135,75,247,29,238,201,186,21,132,113,5,2,13,104,125,15,76,109,73,99,181,145,173,83,151,123,53,139,129,158,93,247,165,102,37,145,10,163,87,146,82,227,56,7,3,131,139,255,123,220,24,10,69,185,66,236,119,130,237,169,2,123,191,179,31,164,212,247,168,92,104,28,55,237,230,142,42,4,201,73,65,210,83,70,242,239,175,30,211,55,206,12,240,202,90,138,205,222,130,218,182,213,41,163,206,23,103,245,61,168,235,86,52,218,112,117,11,82,210,13,100,238,170,177,159,115,178,138,193,248,136,205,136,230,82,146,56,113,117,216,193,31,200,63,68,239,4,144,5,234,35,158,102,179,92,95,232,188,39,137,0,213,161,139,83,118,131,65,175,106,102,158,60,254,87,252,35,128,30,183,187,71,188,86,32,183,138,78,193,240,200,99,225,62,107,115,111,240,28,234,125,203,42,157,233,165,16,173,120,110,160,231,100,249,173,132,157,161,46,132,95,5,225,93,93,31,59,115,54,178,62,117,214,163,0,36,220,7,245,63,239,196,40,218,255,35,248,81,62,126,9,250,167,193,178,53,201,6,119,241,101,226,50,216,215,43,90,202,35,152,14,253,35,129,90,194,243,159,29,121,167,221,123,202,199,21,95,183,63,90,206,63,197,164,73,252,198,250,51,138,194,76,152,67,63,62,180,225,81,255,203,62,73,16,216,78,185,147,232,162,79,15,125,79,5,1,249,85,39,12,30,156,218,251,114,11,13,253,179,3,113,200,226,87,249,80,224,150,114,68,137,165,150,226,164,138,141,167,206,71,212,156,191,173,42,196,217,53,60,75,53,19,79,92,153,121,53,188,215,192,202,222,191,66,163,212,221,113,236,249,8,97,220,120,122,5,62,150,73,114,42,247,111,81,78,31,134,248,173,150,188,107,112,0,126,169,225,98,68,128,203,48,2,231,228,89,97,198,113,10,180,220,102,218,43,247,20,199,107,208,18,106,65,137,131,255,153,248,145,112,133,79,21,172,204,92,44,97,218,95,83,218,134,60,169,23,36,237,154,224,228,35,165,121,94,229,233,152,128,88,79,37,85,229,150,100,131,10,14,72,250,94,145,142,35,147,19,3,73,87,8,27,25,91,99,152,228,192,20,150,96,176,22,85,224,100,30,206,70,220,250,165,216,169,20,217,154,237,51,19,24,21,162,123,195,164,58,157,73,87,2,147,66,153,115,194,167,209,245,7,179,220,152,1,62,200,229,177,93,195,229,135,86,252,99,246,76,61,222,239,68,187,103,21,114,160,176,139,154,93,227,14,154,223,23,171,191,167,36,3,132,68,159,90,203,230,87,49,173,57,44,18,1,163,127,175,155,113,255,252,183,81,51,142,24,104,128,55,113,235,43,124,161,180,71,204,12,90,103,132,202,113,207,244,60,245,180,150,186,250,179,88,121,32,243,121,102,14,168,57,65,138,156,92,163,82,168,136,106,29,247,199,44,213,252,12,97,25,48,212,81,116,200,84,223,72,60,232,97,75,126,122,151,52,155,176,189,28,111,219,230,96,201,53,115,101,79,65,196,167,182,64,244,206,189,135,176,110,239,124,78,131,162,225,190,109,79,118,84,208,134,112,116,168,72,227,14,145,94,14,59,130,190,211,75,180,111,232,23,11,243,210,40,138,55,119,211,20,45,66,147,241,64,173,31,27,48,71,147,42,78,185,46,187,137,217,53,217,228,166,170,221,134,202,191,51,101,71,10,155,198,145,161,252,30,52,132,236,51,41,46,201,103,95,31,110,0,253,69,235,46,40,141,166,209,44,127,135,29,129,113,124,57,1,227,168,155,196,120,208,185,169,182,53,1,218,233,62,26,66,177,232,124,28,228,158,143,147,156,180,76,141,15,241,236,95,80,79,177,134,244,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81956123-ee55-4f78-a3d5-3f88f5d02b6c"));
		}

		#endregion

	}

	#endregion

}

