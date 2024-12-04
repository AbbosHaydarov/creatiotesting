﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityServiceSchema

	/// <exclude/>
	public class EntityServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityServiceSchema(EntityServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aaa2b318-5c4c-4b46-863a-16d2305368f0");
			Name = "EntityService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,88,89,111,220,54,16,126,222,0,249,15,140,252,162,69,13,57,73,223,124,1,62,54,173,219,248,72,214,105,30,12,63,208,90,174,173,70,43,109,72,201,217,173,177,64,156,32,61,131,230,165,175,109,209,127,224,184,49,234,196,137,243,23,164,127,212,25,146,58,247,240,166,118,13,120,37,13,135,51,223,28,28,14,233,209,22,19,109,106,51,178,201,56,167,194,111,6,214,146,239,53,157,221,144,211,192,241,189,235,215,14,174,95,171,132,194,241,118,73,189,43,2,214,154,41,125,3,191,235,50,27,153,133,245,5,243,24,119,236,62,158,187,142,247,184,143,120,63,244,2,167,197,172,58,76,161,174,243,157,84,216,199,5,163,251,142,205,86,253,6,115,71,14,90,11,0,98,255,98,33,214,67,182,147,49,228,237,230,108,24,221,170,1,212,192,97,98,16,3,200,3,166,86,75,234,133,241,9,206,118,1,4,89,114,169,16,211,68,78,237,106,4,146,97,75,127,128,167,3,78,237,96,27,105,11,162,189,198,2,144,211,6,19,118,28,23,230,220,103,143,67,135,179,22,243,2,97,230,63,208,14,50,71,46,152,130,92,150,38,52,170,168,164,29,238,184,142,77,108,4,86,196,69,166,201,34,21,44,69,89,129,176,195,111,106,203,42,11,246,252,6,88,179,33,69,168,193,169,169,41,50,43,194,86,139,242,238,124,66,32,19,19,19,248,175,255,146,215,210,147,224,75,42,99,170,44,100,182,77,57,109,17,15,210,115,206,96,18,40,58,139,58,144,94,198,252,129,161,176,175,193,176,1,200,13,99,146,104,210,122,155,169,196,45,209,235,1,15,237,32,228,204,152,38,91,7,196,248,154,117,141,105,57,254,13,117,67,160,26,6,233,77,146,97,35,219,189,217,41,9,41,67,200,25,136,243,196,252,236,84,242,134,67,91,41,128,124,112,43,91,144,35,43,222,190,255,136,153,202,147,16,61,99,99,189,190,9,122,30,112,103,147,181,218,46,13,48,166,70,173,195,108,12,26,19,1,12,46,250,13,192,222,117,113,8,100,172,50,33,232,46,75,169,214,34,229,108,18,53,84,42,68,207,186,227,243,22,13,10,252,138,100,125,37,124,111,18,216,68,27,214,42,27,205,39,243,37,73,152,92,170,8,150,204,39,57,164,102,173,24,35,82,138,89,149,96,25,169,84,246,41,39,156,137,208,69,189,30,123,50,88,178,89,197,101,86,169,4,188,171,231,201,137,194,222,99,45,186,190,243,45,84,27,152,254,64,48,14,10,60,85,123,212,10,237,214,37,207,42,245,192,26,14,229,40,88,129,229,47,204,170,117,199,225,34,88,231,203,172,73,65,187,217,33,115,243,164,99,45,209,182,156,44,67,77,230,230,202,184,173,44,209,52,166,138,211,36,102,17,9,88,18,186,110,98,34,192,222,227,254,19,101,93,199,102,82,129,41,2,14,69,195,82,14,54,141,232,175,248,69,116,18,189,143,142,72,124,72,162,15,209,81,244,79,116,12,191,31,162,83,164,147,131,155,61,36,159,168,177,183,209,27,160,194,155,5,41,49,2,98,130,177,87,118,218,120,238,186,227,120,141,21,79,4,212,179,217,98,247,193,74,163,96,168,5,132,188,19,6,227,72,243,31,253,82,34,9,11,164,51,30,172,52,215,252,160,214,113,68,144,57,13,177,182,185,131,85,96,217,17,176,26,64,178,27,182,60,180,11,208,43,32,24,208,141,33,76,73,210,12,23,165,131,157,73,67,123,149,7,20,195,98,119,131,6,123,230,48,24,213,98,186,36,234,208,23,55,6,59,35,173,58,150,30,17,80,93,6,202,215,146,171,153,67,198,74,163,223,33,67,226,231,209,59,153,63,152,61,231,36,250,24,157,71,103,64,135,20,154,148,95,4,198,207,227,103,240,255,20,134,222,199,207,73,116,28,255,162,249,62,196,175,162,147,248,89,124,24,191,2,102,201,113,12,132,167,40,19,114,51,126,30,255,4,159,135,48,253,88,14,201,20,69,94,212,247,17,94,15,163,83,204,202,145,70,37,174,234,229,34,148,120,44,105,30,32,44,24,15,229,56,136,68,65,158,78,196,97,201,159,250,121,107,4,140,237,20,70,62,123,19,245,16,33,104,71,200,60,185,153,11,129,42,85,86,61,180,109,40,144,128,16,244,164,113,175,168,186,175,235,89,201,68,120,100,107,80,233,202,242,110,137,51,40,246,10,186,89,92,151,9,70,53,5,250,150,0,42,150,50,67,38,29,148,50,205,209,132,182,132,218,123,196,68,13,77,135,185,13,226,120,23,249,39,179,77,150,49,149,77,43,98,13,234,215,58,175,181,218,128,71,138,82,25,158,207,70,27,68,58,94,102,125,62,148,202,44,133,50,103,165,252,22,227,86,94,165,23,214,71,33,76,5,209,55,202,149,182,143,5,108,185,235,251,143,194,246,102,183,157,51,54,217,120,154,140,51,168,109,106,205,167,72,245,212,251,197,225,153,194,92,7,119,108,220,78,26,125,169,89,18,59,73,242,30,204,164,100,17,205,133,179,8,62,55,128,245,102,18,180,102,2,122,132,185,176,233,246,89,188,76,3,42,167,160,201,74,43,190,161,75,3,120,250,77,19,56,216,38,52,218,249,112,142,3,71,97,128,92,218,135,154,109,109,250,137,156,98,138,92,1,192,69,223,119,25,245,46,139,79,139,185,114,120,43,94,240,249,237,203,130,147,66,174,28,218,50,179,33,23,221,75,71,86,137,185,114,120,117,89,96,46,139,78,73,25,6,46,169,71,10,228,39,237,158,127,234,157,18,91,176,83,104,198,176,197,74,155,175,55,209,25,110,115,231,209,235,248,103,160,190,131,29,240,136,28,220,26,212,150,193,14,123,140,123,165,106,233,78,112,59,76,171,217,88,253,90,110,215,200,249,8,76,117,26,176,230,210,146,159,237,91,201,24,88,165,91,119,97,125,73,69,141,115,159,195,22,81,108,171,152,164,66,253,26,62,183,206,112,27,76,106,243,38,235,4,85,107,97,119,23,14,127,168,223,132,162,182,83,197,49,74,62,35,198,12,49,224,177,147,130,31,199,213,127,196,63,130,139,95,203,174,66,182,25,167,224,51,112,225,25,80,223,68,71,241,247,240,60,45,52,21,211,24,6,217,239,74,248,229,222,54,215,117,89,117,186,15,78,250,180,6,124,0,32,208,122,30,191,128,87,236,113,48,174,0,201,50,202,138,71,244,4,61,98,211,0,183,228,84,45,97,157,20,86,223,196,38,133,140,157,41,12,202,0,46,51,97,115,39,233,85,89,199,210,97,210,74,228,111,127,239,161,59,142,9,230,53,212,153,125,216,1,158,227,37,137,186,136,168,180,213,7,249,34,132,13,110,240,246,150,63,40,232,12,74,54,58,229,211,82,235,167,22,232,160,243,30,42,177,100,147,161,44,249,244,46,176,168,126,144,94,37,121,68,131,7,197,41,235,240,198,73,148,223,100,29,128,220,192,36,57,194,46,56,254,1,215,124,244,119,218,108,99,157,232,63,171,97,69,56,132,62,251,12,210,251,87,232,162,143,10,93,115,252,82,230,27,82,128,23,68,170,132,211,229,167,191,163,46,212,189,92,69,30,218,199,222,250,127,172,44,84,61,48,26,166,188,147,163,47,241,89,182,249,20,214,147,60,89,100,11,251,36,122,123,121,203,11,75,42,173,108,153,23,182,110,110,91,58,119,114,219,204,88,11,40,89,18,181,114,102,142,200,203,75,175,145,90,253,94,241,66,68,206,190,23,50,94,76,122,237,5,96,79,204,147,60,105,243,187,224,62,161,93,161,170,121,161,52,225,140,133,70,67,49,22,68,38,130,10,71,38,185,7,231,148,221,113,220,128,113,129,34,76,252,86,39,24,69,125,232,4,123,27,120,55,198,144,197,84,68,121,41,201,29,184,72,146,205,65,237,113,72,221,100,43,188,72,239,200,4,24,82,52,16,20,212,175,114,208,6,159,174,116,236,203,98,70,148,81,69,45,17,75,247,188,216,14,37,151,126,234,154,55,79,25,114,253,154,221,152,233,11,87,57,105,149,181,118,24,55,215,121,3,6,176,96,229,47,227,116,70,101,109,132,206,163,93,166,15,161,66,191,244,134,75,188,53,224,122,47,187,166,41,19,254,131,130,219,5,5,203,142,116,48,132,116,86,161,79,214,197,60,41,29,80,71,171,234,141,237,215,242,93,229,216,222,221,129,67,4,73,246,232,203,58,54,9,85,121,87,31,195,72,45,129,121,97,171,63,62,114,190,186,75,67,157,242,2,184,124,181,134,65,24,152,185,32,255,95,243,211,20,6,247,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aaa2b318-5c4c-4b46-863a-16d2305368f0"));
		}

		#endregion

	}

	#endregion

}

