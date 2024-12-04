﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TaggingServiceSchema

	/// <exclude/>
	public class TaggingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TaggingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TaggingServiceSchema(TaggingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db270a93-43b8-41ee-a0b7-a35950edf93c");
			Name = "TaggingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,86,203,110,219,48,16,60,59,64,254,129,112,46,50,144,202,247,188,0,199,105,90,23,112,26,216,110,115,8,122,160,165,181,77,68,34,21,146,114,224,6,249,247,46,31,178,37,197,207,244,212,94,12,137,220,89,205,236,174,135,228,52,5,149,209,8,200,8,164,164,74,76,116,216,21,124,194,166,185,164,154,9,30,142,232,116,202,248,244,248,232,245,248,168,145,43,124,36,195,133,210,144,134,131,156,107,150,66,56,4,201,104,194,126,219,248,243,122,20,238,206,89,4,125,17,67,178,117,51,236,68,154,205,119,39,9,31,96,188,10,216,68,123,0,9,213,16,15,32,18,50,86,235,227,37,108,90,15,111,105,164,133,100,96,144,24,115,34,97,138,89,73,55,161,74,157,17,95,19,207,106,0,207,57,40,109,3,219,237,54,185,80,121,154,82,185,184,242,239,22,68,196,132,72,23,104,30,181,203,64,148,75,17,22,208,118,9,251,120,67,53,69,85,90,34,153,95,184,144,229,227,132,69,36,178,249,214,114,32,103,164,87,85,94,231,216,192,54,226,239,59,162,118,161,232,36,196,4,176,183,122,65,84,52,131,148,18,4,203,133,231,173,12,217,247,108,29,221,62,164,99,144,193,29,142,21,185,36,77,19,254,89,61,175,242,54,79,73,79,25,50,76,226,71,46,137,150,57,180,140,182,66,156,210,210,212,165,79,25,247,10,42,120,242,74,166,160,207,177,110,248,243,246,87,82,164,75,127,128,26,143,248,144,160,106,87,62,168,201,41,224,134,142,235,5,97,220,235,56,172,41,61,95,92,151,209,108,212,117,76,104,162,182,9,233,241,82,139,86,105,246,214,130,227,75,34,145,228,41,183,122,14,163,223,181,192,131,104,175,216,174,192,123,147,117,64,199,247,112,194,174,65,31,224,92,153,153,61,104,51,62,195,161,210,177,136,72,123,35,155,24,38,52,79,244,79,154,160,33,236,77,229,166,140,170,19,104,56,18,39,192,99,231,147,187,61,115,163,89,222,75,49,103,49,126,227,5,198,159,188,59,146,137,144,228,69,200,39,242,194,244,108,233,65,239,13,211,39,47,123,230,99,71,101,119,160,187,34,205,240,96,24,179,4,173,192,11,78,209,24,84,80,126,49,231,11,86,97,7,196,68,133,69,209,90,59,140,25,29,249,154,42,88,107,202,43,55,94,214,74,112,44,120,110,206,30,44,217,189,77,235,34,252,39,170,201,131,22,182,226,109,91,192,15,44,33,38,229,128,103,43,230,207,43,175,45,131,107,156,145,49,18,12,106,91,171,196,181,182,46,185,246,65,207,68,108,104,74,161,17,5,241,182,81,204,138,32,34,230,120,212,98,139,235,39,213,87,202,227,4,36,249,2,122,237,134,17,107,9,75,208,185,244,115,229,206,233,69,136,160,139,158,215,238,227,175,2,14,47,229,138,118,228,52,55,13,12,154,85,173,248,39,168,150,169,213,50,247,130,198,222,250,75,109,90,107,31,157,56,86,118,106,137,22,59,142,29,187,146,81,73,83,235,50,151,104,30,246,224,110,94,141,170,55,134,226,50,17,94,180,109,248,10,237,202,163,214,0,84,134,197,0,68,20,33,214,35,190,103,224,238,76,229,191,77,227,17,111,89,61,62,23,79,16,56,161,198,59,238,191,15,71,166,90,146,141,32,205,76,143,204,42,202,195,111,25,47,185,22,241,98,168,23,137,89,70,124,31,148,162,83,88,174,134,15,146,102,153,233,171,165,126,106,187,233,95,110,133,76,169,174,224,220,82,248,77,9,126,138,94,232,216,111,143,171,88,215,134,139,144,203,67,60,235,96,253,61,202,87,183,54,114,136,169,38,13,138,184,242,192,108,56,66,82,28,124,63,6,19,41,210,255,112,16,156,198,127,112,22,6,80,16,63,104,28,28,108,143,137,168,89,200,186,227,242,237,248,232,15,149,163,126,59,140,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db270a93-43b8-41ee-a0b7-a35950edf93c"));
		}

		#endregion

	}

	#endregion

}

