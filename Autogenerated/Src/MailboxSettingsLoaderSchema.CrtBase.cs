﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailboxSettingsLoaderSchema

	/// <exclude/>
	public class MailboxSettingsLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailboxSettingsLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailboxSettingsLoaderSchema(MailboxSettingsLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1745e006-0dd7-4498-9d93-610c2cbcffef");
			Name = "MailboxSettingsLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,85,203,110,219,48,16,60,219,128,255,129,200,73,1,12,33,247,84,5,242,106,123,136,83,23,114,219,67,81,4,140,188,118,8,80,164,194,71,18,33,240,191,119,41,82,207,216,170,123,232,65,134,73,206,14,135,203,217,165,213,76,108,73,90,106,3,249,249,108,106,59,195,248,150,137,167,225,220,10,94,205,112,238,74,114,14,153,97,82,232,248,51,8,80,44,27,66,174,169,161,195,185,59,48,241,130,50,222,204,175,64,41,170,229,198,32,163,130,189,211,121,46,197,1,124,124,125,121,104,229,70,24,102,24,104,92,159,77,5,205,65,23,52,131,30,74,108,216,214,42,234,14,49,155,190,205,166,147,194,62,112,150,145,140,83,173,137,147,249,32,95,83,48,6,233,245,173,164,107,80,196,193,250,184,52,55,69,13,242,203,245,186,54,202,9,251,34,181,33,111,100,11,230,156,104,247,179,235,130,152,48,100,41,213,8,34,208,124,215,160,238,240,28,71,1,151,168,236,69,170,245,97,240,131,148,220,65,211,244,118,92,92,10,234,25,212,138,229,32,237,30,149,59,76,240,100,82,101,69,177,103,106,128,40,160,107,41,120,89,9,193,44,11,239,19,114,111,123,227,54,206,239,181,55,223,209,128,163,79,113,26,242,205,54,36,234,175,144,36,33,194,114,94,35,38,230,81,201,23,34,224,133,92,168,173,205,65,152,59,92,190,121,205,160,112,248,232,164,31,127,114,90,201,155,236,240,171,254,12,196,147,100,32,165,130,239,6,71,234,89,195,29,168,30,92,150,55,57,30,55,10,55,6,110,80,75,125,166,138,184,241,197,122,173,0,253,149,84,170,23,237,76,228,225,231,13,26,244,83,64,85,166,47,211,236,17,33,223,44,168,50,26,232,142,187,136,5,21,116,11,106,78,78,234,220,151,34,171,37,214,25,64,242,24,55,198,122,183,57,166,169,118,225,200,114,237,189,3,16,183,151,247,84,156,46,86,75,255,55,28,237,184,16,87,46,127,71,122,111,111,164,74,65,172,241,68,255,34,39,184,189,10,105,210,204,153,54,159,24,55,216,5,14,100,219,175,182,173,49,194,189,230,120,241,91,150,81,254,181,0,223,107,82,188,244,204,196,23,98,29,20,181,196,78,152,11,138,175,176,136,12,248,201,159,204,60,46,169,194,164,227,64,71,245,38,121,65,21,211,82,172,202,2,92,51,51,148,9,188,202,230,130,230,93,23,185,108,168,211,255,177,223,232,117,246,53,184,70,88,107,112,155,122,102,93,137,104,53,117,140,157,97,139,74,156,189,241,137,49,62,219,157,228,14,172,29,226,92,47,192,56,84,104,177,121,97,27,56,107,122,128,2,99,149,168,250,66,168,238,182,132,42,114,220,12,67,127,157,253,110,37,160,112,203,77,184,240,110,61,87,136,64,92,117,248,36,144,56,173,46,71,193,97,63,40,183,240,193,23,250,199,174,221,238,247,184,127,238,249,170,247,96,148,15,27,243,123,50,95,23,129,163,121,46,142,211,213,214,117,39,190,121,69,146,163,57,218,226,111,121,220,19,51,202,224,222,162,254,113,222,23,111,160,235,191,70,163,172,123,115,52,168,111,111,131,186,202,131,65,252,157,55,29,29,191,221,31,48,191,69,93,51,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1745e006-0dd7-4498-9d93-610c2cbcffef"));
		}

		#endregion

	}

	#endregion

}

