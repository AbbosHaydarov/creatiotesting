﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FullPipelineQueryBuilderSchema

	/// <exclude/>
	public class FullPipelineQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FullPipelineQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FullPipelineQueryBuilderSchema(FullPipelineQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1");
			Name = "FullPipelineQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,90,89,115,219,54,16,126,86,102,242,31,80,183,15,212,140,135,105,95,227,56,29,249,74,213,177,99,39,114,155,135,78,167,67,147,144,196,41,15,5,32,237,168,25,255,247,238,226,32,14,130,162,114,190,216,34,128,61,176,199,183,11,144,85,82,82,190,73,82,74,110,41,99,9,175,151,77,124,90,87,203,124,213,178,164,201,235,234,233,147,143,79,159,76,90,158,87,43,178,216,242,134,150,71,222,51,172,47,10,154,226,98,30,191,162,21,101,121,218,91,115,153,87,239,205,224,105,93,150,117,101,63,51,234,62,197,103,39,222,192,121,213,228,77,78,185,25,126,221,230,241,130,178,251,60,165,87,117,70,139,248,252,67,67,43,142,122,152,69,246,182,128,203,69,146,54,53,147,108,96,205,143,140,174,96,61,57,45,18,206,159,147,139,182,40,110,242,13,45,242,138,190,105,41,219,158,180,121,145,81,38,214,62,123,246,140,188,224,109,89,38,108,251,82,61,223,176,250,62,207,40,39,37,109,214,117,70,234,37,121,143,116,228,14,9,201,178,102,100,9,60,201,70,49,37,89,210,36,177,102,246,204,226,246,215,25,93,38,109,209,156,228,85,6,122,71,205,118,67,235,101,52,31,82,105,58,253,27,168,54,237,93,145,167,36,69,245,7,181,39,207,201,32,27,224,1,254,133,191,157,41,46,114,90,100,96,139,27,150,223,39,13,149,147,27,249,64,24,77,178,186,42,182,228,15,78,25,196,73,37,253,78,254,105,157,231,163,32,205,252,21,109,222,210,77,205,115,112,193,86,122,98,251,66,198,194,162,73,86,244,12,140,243,146,252,195,241,119,111,225,0,79,136,47,112,126,91,80,193,225,183,156,227,90,67,172,184,45,104,211,128,85,185,153,112,216,205,207,171,182,164,44,185,43,232,11,219,82,34,230,182,50,31,64,177,77,96,152,59,140,108,37,148,76,165,129,59,56,40,125,192,26,174,20,222,48,201,56,93,211,50,121,13,41,44,163,121,242,35,173,50,233,70,215,167,16,166,27,202,48,123,208,175,117,3,94,162,153,92,50,166,125,104,236,88,171,229,141,255,250,43,65,118,147,40,56,123,76,192,255,1,118,209,162,219,198,116,170,54,226,237,212,172,32,136,70,147,201,138,54,82,11,219,2,48,206,97,92,174,152,12,232,80,129,123,143,236,21,220,31,52,178,142,201,125,82,180,138,245,35,254,133,63,123,123,78,252,228,150,194,74,177,124,73,162,78,180,148,61,213,115,147,251,132,17,47,254,65,141,129,148,136,157,132,138,2,182,69,123,78,220,189,122,172,144,199,172,40,34,189,82,108,115,50,97,180,105,89,229,68,159,99,129,161,72,131,164,0,159,181,168,30,198,154,128,39,101,51,9,85,67,64,20,121,136,226,2,202,161,212,106,79,4,9,91,75,243,24,67,140,1,192,208,62,114,21,139,79,215,52,253,119,198,86,16,7,85,243,26,54,23,85,16,58,128,220,238,58,17,217,24,160,97,71,14,114,9,175,119,184,245,85,29,97,23,216,155,226,231,193,56,68,75,0,215,85,44,245,148,234,199,150,141,220,138,170,47,91,147,13,64,244,72,188,93,137,186,59,84,174,66,224,53,0,66,10,105,76,246,107,127,59,153,16,176,53,240,139,44,42,91,105,173,198,125,157,103,100,182,217,20,219,27,104,142,234,236,34,47,26,136,248,5,197,182,137,112,241,239,208,201,12,187,194,116,205,131,61,168,130,57,180,193,0,238,233,189,32,244,132,184,197,192,135,53,144,60,148,252,224,33,18,2,146,104,105,96,101,150,171,168,168,232,3,121,227,12,70,238,227,45,116,47,241,43,168,210,176,207,107,118,254,190,77,44,140,187,164,203,230,252,195,134,81,206,123,236,138,182,172,204,92,20,216,11,234,106,198,58,195,31,202,210,163,147,98,23,141,222,171,148,38,188,166,176,79,97,160,187,223,120,206,221,157,68,146,48,190,73,24,208,162,39,145,219,109,94,82,28,226,116,196,196,83,157,109,19,233,249,120,150,101,198,142,174,236,67,114,89,175,242,52,41,174,161,126,139,126,60,158,85,153,162,127,220,237,211,179,150,126,109,143,94,130,91,190,147,59,191,161,55,173,93,124,158,43,149,101,191,174,35,61,204,80,224,112,70,211,26,214,211,119,121,179,150,176,193,191,12,55,200,103,1,71,31,188,180,244,176,144,16,171,163,221,225,170,118,7,254,193,130,117,205,222,173,243,134,46,240,104,26,77,187,96,83,96,44,133,219,89,128,65,189,148,28,32,2,131,2,0,168,181,5,149,46,72,68,249,251,139,142,78,113,136,69,79,114,174,103,130,97,43,89,203,128,253,99,158,169,120,245,10,168,37,71,132,131,228,103,206,203,32,210,146,159,112,98,115,125,19,162,48,70,12,50,132,67,110,91,65,107,124,76,126,222,207,102,32,94,101,108,79,116,228,109,198,217,242,85,82,129,77,88,208,211,206,66,187,148,78,160,199,155,101,101,94,189,205,87,235,70,24,60,41,56,212,108,147,173,160,79,12,165,28,79,197,22,132,64,80,204,138,135,100,203,85,232,31,19,232,49,233,136,45,122,192,135,188,117,148,249,217,8,44,195,6,245,23,30,245,121,65,196,214,205,32,3,49,171,168,224,62,128,38,233,154,68,243,1,71,207,225,174,68,69,33,201,171,48,71,131,188,182,18,128,61,145,36,116,59,249,71,66,193,196,33,19,32,133,137,190,105,56,155,58,131,35,37,182,78,226,57,24,31,86,176,167,86,101,177,249,224,213,146,156,144,107,187,117,177,83,103,128,42,80,124,78,138,58,253,87,210,57,33,237,194,110,58,130,184,152,101,82,153,80,167,38,197,38,96,176,83,81,242,103,171,21,52,154,130,186,155,138,130,181,141,72,157,254,196,3,163,246,144,169,180,200,209,46,140,200,198,6,161,42,3,64,110,192,158,152,20,242,224,24,191,91,83,70,35,160,123,73,40,68,209,57,40,47,157,24,75,253,187,41,93,70,58,81,104,17,160,174,48,154,162,253,42,187,68,221,46,180,62,161,166,47,62,185,166,143,81,168,242,234,23,244,199,67,199,198,38,251,45,235,129,139,183,86,185,80,167,105,49,245,233,221,206,220,74,181,111,106,144,159,14,62,142,18,225,111,99,145,199,121,118,224,181,57,189,125,198,2,101,141,98,34,227,173,199,183,73,181,162,189,6,136,219,230,236,26,156,112,104,245,68,134,60,36,17,197,48,128,221,157,3,34,89,6,83,42,136,171,131,232,103,45,83,229,120,71,24,74,87,133,78,178,92,127,0,75,113,137,102,18,159,62,169,49,178,115,214,185,2,10,55,243,222,189,19,82,173,247,188,238,242,15,139,82,164,198,89,140,43,149,223,62,190,170,236,191,96,117,57,112,196,48,156,213,90,105,90,215,194,191,76,245,236,28,88,179,223,235,188,138,214,251,132,171,38,187,222,115,253,33,129,192,222,177,242,42,201,43,173,127,32,176,17,243,68,143,62,178,215,67,114,128,68,30,176,235,248,9,53,208,187,123,87,87,227,224,129,62,208,156,223,48,122,159,215,45,151,188,130,39,124,185,173,193,168,44,193,28,122,162,31,147,105,23,7,214,101,232,113,128,8,189,140,43,105,134,106,233,39,135,206,132,221,70,105,13,44,12,7,188,112,12,94,117,235,0,204,25,111,174,153,122,97,17,149,180,188,131,118,5,106,145,252,101,185,38,22,14,228,88,148,123,74,76,237,250,39,114,87,100,45,8,31,72,231,160,174,246,169,34,52,239,90,163,223,18,58,130,71,253,105,45,135,232,217,161,143,57,154,143,58,72,52,60,160,151,29,23,210,74,198,117,162,28,65,203,189,189,173,241,111,72,125,85,74,176,199,9,201,12,156,172,199,67,103,13,126,208,170,120,135,107,43,59,131,102,15,200,3,48,24,21,9,101,8,110,44,125,153,2,20,142,2,237,108,179,102,245,131,128,76,232,177,231,229,166,160,120,225,73,33,120,82,186,17,101,221,241,135,215,54,130,165,166,240,206,16,77,104,123,118,164,69,84,57,45,176,83,68,170,140,78,167,126,104,48,135,10,128,32,167,240,220,10,120,101,136,111,153,115,225,76,171,239,161,25,46,10,113,76,84,93,233,142,78,215,175,27,250,37,139,234,229,69,109,249,206,237,78,60,227,78,97,215,125,27,120,79,114,152,103,86,176,134,20,190,104,171,84,158,147,123,251,155,238,226,126,45,77,167,84,67,251,237,33,103,209,58,29,184,215,42,250,222,0,13,198,119,121,218,50,76,146,121,181,67,19,60,18,37,69,218,22,224,89,101,15,83,246,122,193,103,129,104,111,110,4,64,71,33,115,76,232,227,190,197,186,199,224,48,116,189,191,227,254,61,100,146,47,185,74,227,218,8,221,169,94,36,88,119,163,0,231,247,32,89,108,212,232,142,166,29,47,225,132,142,71,108,206,174,183,245,101,253,0,246,244,47,101,84,52,224,219,51,248,93,128,25,233,84,67,192,65,82,98,116,28,152,3,17,6,198,76,12,162,18,42,80,245,238,59,177,222,13,194,14,139,246,120,121,6,13,108,213,18,227,180,55,222,113,122,215,9,75,93,97,90,29,160,177,216,109,194,224,93,107,47,33,80,134,180,198,56,234,249,186,124,110,118,27,121,10,89,2,126,221,213,94,122,213,195,46,48,65,124,213,87,7,123,129,177,73,249,31,212,125,67,255,232,12,23,46,73,145,255,135,175,183,187,138,122,5,155,131,229,88,175,188,72,4,117,47,13,193,66,188,79,139,14,134,222,247,30,232,106,112,240,186,150,10,220,214,139,117,253,48,239,26,4,93,242,157,42,31,94,106,234,189,124,141,23,95,212,172,76,154,104,199,6,0,61,122,5,242,241,179,143,99,97,135,244,207,89,189,57,113,154,226,195,199,167,49,135,142,156,161,76,155,214,59,47,41,221,228,45,211,144,6,99,226,229,63,188,101,219,209,33,246,222,177,136,91,95,93,234,100,203,250,5,38,8,245,10,96,114,221,118,6,110,56,84,192,247,174,209,186,234,251,138,213,237,230,100,251,181,181,26,56,162,90,55,243,123,191,237,238,127,88,97,223,133,200,150,116,191,175,154,82,89,149,240,38,127,224,13,184,25,233,127,88,224,188,167,209,31,25,244,18,75,201,24,254,46,65,45,208,235,29,76,243,191,241,9,247,201,176,80,49,113,108,219,107,211,119,152,89,142,122,131,222,23,130,163,8,244,20,137,156,207,242,70,73,158,139,111,3,32,137,240,193,98,228,127,153,55,250,109,205,190,240,8,135,6,129,129,211,231,228,14,11,158,126,36,31,201,190,150,129,117,255,3,107,21,20,159,59,42,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoStagesToShowInPipelineLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoStagesToShowInPipelineLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("86098e23-8c70-4d26-bad8-b983bdebbc16"),
				Name = "NoStagesToShowInPipeline",
				CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7"),
				CreatedInSchemaUId = new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1"),
				ModifiedInSchemaUId = new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1"));
		}

		#endregion

	}

	#endregion

}

