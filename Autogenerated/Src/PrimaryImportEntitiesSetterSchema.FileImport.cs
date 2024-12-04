﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PrimaryImportEntitiesSetterSchema

	/// <exclude/>
	public class PrimaryImportEntitiesSetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PrimaryImportEntitiesSetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PrimaryImportEntitiesSetterSchema(PrimaryImportEntitiesSetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0015edbc-7f2c-44cd-8e97-b3d34bab3466");
			Name = "PrimaryImportEntitiesSetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,88,219,110,219,56,16,125,118,129,254,3,215,5,10,25,48,228,247,38,81,224,56,201,194,104,182,13,234,100,95,138,162,96,100,218,209,70,38,93,146,74,107,180,254,247,29,222,36,82,55,39,187,221,98,95,18,153,26,206,229,204,156,225,80,20,111,136,216,226,148,160,27,194,57,22,108,37,227,25,163,171,108,93,112,44,51,70,227,203,44,39,243,205,150,113,249,242,197,247,151,47,6,133,200,232,26,45,118,66,146,205,81,237,55,108,205,115,146,170,125,34,254,157,80,194,179,180,33,115,149,209,47,141,197,27,242,77,86,139,190,47,156,116,173,199,23,84,102,50,35,162,83,224,18,167,146,113,35,1,50,175,56,89,131,107,104,150,99,33,222,160,107,158,109,48,223,153,224,156,174,5,145,146,112,45,62,153,76,208,177,40,54,74,40,177,191,167,20,101,84,72,76,1,49,182,66,242,62,19,40,85,234,16,60,112,128,18,34,207,238,114,130,86,140,35,1,186,148,87,91,99,8,101,218,18,34,214,84,236,108,76,60,35,31,207,201,10,23,185,60,203,232,18,246,70,114,183,37,108,21,205,123,156,29,141,209,59,72,35,58,65,20,254,129,112,159,236,232,19,24,217,22,119,121,150,90,199,123,164,209,27,212,103,24,52,65,69,192,223,10,89,8,95,242,66,161,174,0,214,102,140,68,29,76,189,48,227,4,75,34,66,72,33,96,144,36,4,165,156,172,78,134,61,246,135,147,68,97,216,4,209,172,108,49,199,27,141,201,201,48,101,121,177,161,226,154,179,148,8,193,248,48,153,153,21,72,142,93,138,143,39,122,135,86,96,17,234,49,30,205,223,49,122,77,184,200,160,128,169,180,234,166,235,53,64,129,33,126,84,55,57,66,138,62,131,193,172,182,14,121,171,139,170,130,30,236,255,23,192,21,130,112,200,42,53,172,30,38,183,240,27,252,117,11,1,104,191,2,245,219,192,31,20,186,55,214,0,63,63,49,111,52,145,163,174,140,125,14,173,64,194,194,5,63,93,175,8,93,26,50,132,204,0,165,91,194,85,32,170,241,48,9,59,201,210,136,64,123,120,132,108,162,90,104,53,171,71,61,229,80,79,74,123,110,183,206,108,221,82,237,231,73,82,183,141,78,79,53,16,81,19,9,221,75,77,159,221,65,203,151,199,161,178,36,26,141,250,60,111,214,195,33,223,15,101,183,65,175,239,104,77,228,17,122,86,126,116,66,194,236,204,171,131,208,214,167,174,204,221,21,195,75,64,255,243,170,239,245,209,51,52,245,191,85,201,233,53,85,229,170,95,172,37,117,253,142,37,145,214,75,201,87,191,205,79,249,186,216,64,34,162,122,167,24,215,202,106,84,22,66,87,10,254,32,242,158,45,235,248,183,150,13,120,43,204,57,186,67,15,100,247,212,102,102,118,12,19,19,86,179,119,113,34,11,78,133,125,175,53,31,79,220,162,159,66,136,94,29,236,224,134,17,125,75,118,145,221,100,108,140,209,252,130,2,48,28,195,48,112,108,196,19,215,121,212,105,45,76,175,186,44,104,106,95,143,17,187,251,11,176,114,255,157,248,159,56,47,200,53,19,210,150,52,136,78,29,251,104,145,231,174,75,45,180,150,179,34,203,85,122,197,157,122,13,185,10,150,35,149,3,144,53,190,46,210,123,178,193,134,48,213,228,134,132,183,44,64,139,137,40,54,210,177,93,55,122,96,202,33,56,189,71,145,5,196,120,172,167,145,140,6,225,58,47,91,76,7,6,193,94,96,95,21,230,217,78,169,176,237,89,61,218,40,6,6,40,31,39,251,34,91,161,232,32,122,33,124,131,129,183,161,138,26,204,207,170,245,200,247,205,121,177,71,36,23,164,67,205,1,47,188,160,198,79,49,89,218,52,255,196,93,60,221,110,129,79,126,180,86,198,136,152,234,133,114,136,111,152,41,133,104,4,143,87,236,107,89,13,251,67,68,3,30,56,178,217,148,106,62,137,167,210,78,63,19,56,189,197,48,49,237,5,85,75,253,19,4,152,182,133,48,76,128,100,206,126,55,117,223,118,249,218,78,228,54,150,66,204,160,197,212,233,204,43,225,200,182,198,210,117,47,10,59,121,120,218,140,176,217,159,40,8,173,42,87,111,87,112,128,181,54,6,203,91,255,189,163,109,73,55,95,185,221,172,8,215,180,210,190,229,156,8,184,152,232,251,29,90,122,207,37,103,99,79,162,210,165,105,245,155,183,193,246,132,219,249,50,190,248,82,224,92,68,94,94,63,48,38,203,247,35,244,227,7,10,182,206,5,128,92,169,6,218,0,224,180,100,176,171,240,129,15,77,60,93,46,35,95,201,172,209,18,246,205,218,247,53,28,44,248,133,62,89,190,1,248,170,159,185,171,26,146,172,237,246,246,31,23,191,51,5,7,86,221,161,159,196,154,230,176,222,217,169,220,236,142,30,117,103,219,130,136,155,218,148,99,184,121,29,112,28,123,100,217,82,225,234,207,20,217,1,58,5,196,52,84,76,202,224,13,217,158,196,182,49,250,137,39,108,64,89,27,59,89,186,120,0,232,62,238,182,117,154,135,182,54,3,58,58,59,144,143,144,71,246,90,119,8,38,17,69,106,7,92,73,55,123,92,27,9,85,33,39,225,44,227,134,152,86,7,199,135,96,115,92,84,237,162,21,38,245,137,73,98,184,188,90,67,170,19,248,231,112,208,9,246,173,141,204,198,104,72,233,126,80,159,90,206,96,165,216,70,237,239,49,177,251,43,234,248,85,16,180,67,61,110,220,47,108,49,6,231,126,31,40,26,149,154,11,174,123,86,104,160,215,175,67,175,130,129,188,57,187,12,250,132,109,158,157,3,131,59,64,242,161,214,103,237,191,246,116,169,182,91,249,230,141,23,182,147,58,166,195,91,19,63,206,120,201,185,115,44,177,94,189,129,15,20,201,199,79,170,210,44,136,193,171,176,108,93,104,182,135,155,197,211,218,16,26,47,136,26,90,213,240,163,46,70,138,122,79,112,65,137,199,102,226,82,79,193,203,145,26,142,166,240,17,113,23,14,71,135,239,44,245,111,93,25,189,135,207,159,114,201,82,251,61,102,222,255,65,198,251,254,225,26,230,47,233,144,14,232,71,204,109,197,105,48,46,25,223,96,243,249,178,237,166,216,38,152,68,29,119,67,200,185,173,211,206,203,163,61,161,84,10,224,230,216,85,33,229,233,119,153,113,33,223,115,251,173,20,190,49,140,76,77,218,218,108,57,108,124,228,74,148,2,98,183,6,175,162,13,217,236,4,22,248,145,252,11,115,6,143,96,252,247,71,120,85,206,255,192,161,40,237,208,119,26,140,255,224,172,249,46,227,154,116,213,53,213,93,255,61,205,119,54,32,239,34,34,230,244,188,216,66,125,2,211,23,4,243,244,190,108,63,189,223,13,180,202,22,96,90,250,136,207,50,187,22,18,111,255,55,175,64,16,196,176,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0015edbc-7f2c-44cd-8e97-b3d34bab3466"));
		}

		#endregion

	}

	#endregion

}

