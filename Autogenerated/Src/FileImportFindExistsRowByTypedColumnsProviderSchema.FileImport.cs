﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportFindExistsRowByTypedColumnsProviderSchema

	/// <exclude/>
	public class FileImportFindExistsRowByTypedColumnsProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportFindExistsRowByTypedColumnsProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportFindExistsRowByTypedColumnsProviderSchema(FileImportFindExistsRowByTypedColumnsProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e7d9dbf-fdf3-4e69-9275-6abcc3e79b72");
			Name = "FileImportFindExistsRowByTypedColumnsProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,87,81,111,227,54,12,126,246,1,247,31,132,236,197,6,2,231,110,219,195,161,109,58,92,154,164,8,214,236,138,38,183,62,20,197,160,216,116,34,156,45,101,146,220,214,43,250,223,71,89,118,108,39,78,187,12,205,75,98,73,228,71,234,35,69,81,156,38,160,214,52,0,50,7,41,169,18,145,246,47,4,143,216,50,149,84,51,193,253,49,139,97,146,172,133,212,31,63,60,127,252,224,164,138,241,37,153,101,74,67,114,186,53,70,213,56,134,192,232,41,255,18,56,72,22,236,200,92,49,254,119,53,89,55,155,36,130,183,175,72,216,55,239,143,184,102,154,129,218,43,48,166,129,22,210,74,160,204,79,18,150,232,31,153,112,13,50,194,157,159,144,73,181,199,49,227,225,232,137,41,173,110,196,227,32,155,103,107,8,113,83,105,194,213,181,20,15,44,4,153,163,244,122,61,114,166,210,36,161,50,59,47,198,133,128,34,81,202,115,14,104,204,116,70,180,32,9,229,116,9,36,200,129,8,55,156,147,72,72,162,128,202,96,101,124,6,99,211,124,72,241,168,200,2,181,140,229,82,35,76,165,89,139,208,77,194,114,63,253,210,135,94,205,137,117,186,136,89,64,88,185,179,3,55,70,246,51,97,37,55,130,207,47,150,74,224,161,101,179,193,236,69,76,149,58,33,255,147,84,198,87,152,54,58,20,1,9,36,68,253,206,97,155,232,244,12,19,119,67,136,104,26,235,1,42,32,115,174,97,83,68,238,97,80,158,119,95,145,26,152,77,145,67,249,28,80,5,255,137,210,46,90,114,14,205,67,7,207,163,209,219,16,143,199,78,83,174,145,252,107,201,30,168,6,187,190,182,3,204,38,92,55,233,65,234,120,23,34,197,153,62,249,252,201,30,144,237,176,110,224,199,12,226,112,31,182,4,26,10,30,103,100,200,108,238,203,236,236,50,101,97,151,152,223,115,242,151,77,229,33,213,244,79,26,167,96,60,152,210,245,218,228,117,159,112,120,220,167,104,106,142,227,60,147,134,166,127,37,196,143,116,221,152,251,62,65,157,166,148,65,216,150,33,47,221,86,196,113,44,168,254,252,22,98,46,245,229,32,204,159,143,128,249,203,17,48,127,61,2,230,251,66,206,86,120,50,230,240,244,38,236,148,62,205,216,63,208,38,186,15,251,72,176,83,8,89,154,28,9,252,74,240,229,145,160,71,9,101,241,145,176,177,238,8,121,4,220,235,149,224,173,10,239,128,125,195,130,213,145,160,111,97,241,62,200,47,111,212,239,252,122,144,169,233,134,76,21,207,239,181,162,136,219,59,238,160,235,199,253,174,64,34,36,183,253,30,73,27,67,239,132,44,240,238,115,183,102,109,53,127,121,221,207,41,232,149,216,123,209,152,154,78,46,65,91,119,182,169,112,173,255,118,145,252,128,204,126,21,134,157,92,185,229,38,194,43,104,35,235,15,193,180,98,121,247,171,176,253,149,74,187,30,254,243,130,129,210,146,103,58,78,199,145,160,83,201,95,187,223,252,185,204,208,225,124,218,109,17,235,18,145,106,187,175,112,107,59,94,110,194,249,109,103,193,206,159,180,237,229,180,70,113,73,218,206,221,122,133,177,61,195,108,64,247,206,207,43,58,213,31,166,55,181,1,87,110,201,90,222,98,103,179,96,5,9,37,80,31,244,73,51,11,108,55,94,172,78,243,174,87,226,67,64,79,242,198,36,128,65,102,12,184,157,65,26,69,32,33,180,209,178,74,157,38,161,117,59,126,225,157,127,139,189,97,201,33,233,159,23,219,247,13,168,63,211,84,106,117,203,244,202,237,88,249,142,87,240,231,95,74,145,174,7,217,174,102,243,140,85,140,251,115,81,113,230,46,141,186,209,202,63,252,223,33,179,71,217,113,182,86,102,96,158,63,237,14,122,136,105,104,119,61,175,45,68,15,2,227,63,43,3,145,211,244,70,212,130,221,144,117,201,235,249,95,7,32,244,1,107,60,93,196,80,153,84,24,209,22,216,187,253,231,173,50,113,111,195,103,209,11,20,3,130,144,109,150,236,201,250,38,139,78,189,60,78,44,34,110,93,23,123,195,52,142,75,255,157,249,10,31,72,88,153,52,132,95,75,80,12,71,145,31,87,44,97,218,237,140,164,20,114,10,74,97,250,205,33,89,199,200,239,88,200,122,21,235,116,119,123,224,194,3,140,11,254,182,186,124,3,137,120,128,175,218,253,84,200,86,69,163,81,49,213,112,80,169,109,40,53,131,211,131,234,95,189,68,75,161,49,181,240,77,136,30,72,137,21,216,102,76,254,140,197,151,230,132,51,61,92,212,156,117,39,181,76,184,187,47,222,141,21,87,37,165,135,39,25,110,104,95,193,40,98,184,101,202,71,242,71,52,88,85,201,98,142,70,51,215,91,147,185,74,174,198,145,217,34,174,237,49,250,242,47,98,196,77,79,217,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e7d9dbf-fdf3-4e69-9275-6abcc3e79b72"));
		}

		#endregion

	}

	#endregion

}

