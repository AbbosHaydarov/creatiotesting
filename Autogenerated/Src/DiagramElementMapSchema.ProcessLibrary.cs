﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DiagramElementMapSchema

	/// <exclude/>
	public class DiagramElementMapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DiagramElementMapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DiagramElementMapSchema(DiagramElementMapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2433ee1c-d882-476a-aa3e-688dee2b58c1");
			Name = "DiagramElementMap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,87,223,79,227,70,16,126,246,73,247,63,108,83,233,206,17,150,213,123,45,133,138,114,232,10,186,3,4,168,47,28,173,140,51,9,190,58,107,119,119,29,136,16,255,123,103,119,103,189,222,196,206,37,165,60,144,196,51,251,205,204,55,63,118,204,179,57,200,58,203,129,221,128,16,153,172,166,42,61,174,248,180,152,53,34,83,69,197,223,190,121,126,251,38,106,100,193,103,236,122,41,21,204,247,87,126,163,126,89,66,174,149,101,250,9,56,136,34,95,211,185,130,41,233,172,137,110,224,73,161,124,214,148,153,56,121,170,5,72,169,161,188,222,57,60,42,124,160,93,59,147,21,79,63,23,252,31,47,237,250,45,32,61,225,170,80,5,232,227,168,242,163,128,25,130,177,227,50,147,242,103,246,177,200,102,34,155,159,148,48,7,174,190,100,181,81,170,155,251,178,200,89,174,117,250,84,34,100,0,255,123,48,116,70,137,38,87,149,64,204,75,115,218,106,16,210,26,70,140,250,218,87,153,63,192,60,59,71,206,19,118,122,194,155,57,136,236,190,132,95,214,14,92,86,5,87,32,14,89,109,191,200,132,105,252,136,112,4,76,65,0,207,1,169,111,230,252,143,172,108,64,163,178,3,54,26,141,153,206,88,20,17,134,196,135,14,69,179,22,69,215,173,23,40,242,46,89,225,213,48,244,144,85,115,240,133,56,2,62,177,52,133,156,93,138,170,6,161,19,211,203,216,118,100,180,17,61,179,25,168,125,86,139,98,145,41,96,82,255,120,9,0,137,168,78,168,91,159,25,100,96,3,194,80,216,95,64,61,84,19,29,179,61,68,246,28,130,194,22,203,217,217,77,245,55,112,246,9,148,249,66,197,114,123,199,234,76,61,72,151,206,98,202,98,243,32,253,12,124,166,30,216,33,251,192,222,189,35,175,211,83,121,222,148,229,133,56,153,215,106,105,21,111,63,220,141,221,233,72,128,106,4,103,28,30,217,217,17,118,204,50,30,219,132,99,4,43,226,139,251,111,216,170,40,223,38,177,62,194,245,172,18,161,24,152,13,209,80,249,219,242,18,157,139,41,232,111,230,35,113,170,11,173,161,229,206,239,144,11,44,194,86,35,189,174,203,66,197,239,211,247,20,8,33,242,106,162,139,213,2,167,31,1,234,227,178,226,224,194,157,226,144,200,242,7,230,90,82,227,178,130,135,92,27,178,7,137,245,164,26,61,109,48,189,89,214,104,245,128,114,169,127,165,134,101,157,33,163,240,123,38,77,248,222,70,20,145,171,250,227,246,167,59,235,31,254,229,21,206,48,222,80,67,186,12,121,117,116,135,68,36,113,94,104,7,180,212,155,160,180,82,40,38,132,254,163,125,1,216,58,240,96,93,119,53,15,206,227,23,6,165,132,221,109,238,238,110,88,171,198,237,234,218,40,83,122,195,134,94,84,197,132,93,99,245,217,72,118,40,191,132,85,230,136,125,210,202,241,114,90,104,113,48,103,7,107,197,23,243,74,23,118,27,111,135,2,39,39,242,70,224,120,82,228,135,237,116,87,61,139,76,224,152,158,193,147,206,19,246,50,94,171,240,20,143,254,28,177,189,224,220,30,27,197,95,191,166,123,227,95,71,33,184,192,113,89,112,252,70,240,6,12,111,231,186,196,29,193,71,148,4,57,34,136,65,34,2,80,79,134,214,167,54,29,106,31,95,26,58,178,111,182,165,14,88,108,71,216,216,158,118,125,98,197,233,209,100,18,7,115,108,220,42,216,164,227,112,48,154,190,231,168,48,173,252,182,67,212,29,241,120,102,106,199,198,239,224,214,115,233,38,16,60,58,67,237,76,183,227,37,28,84,184,247,116,252,223,133,13,173,251,3,41,247,12,150,157,185,50,162,113,72,70,235,94,59,76,91,190,194,134,239,81,236,50,216,37,200,116,190,87,95,105,255,65,250,187,158,239,96,173,191,243,91,128,36,44,246,196,245,122,7,110,112,168,28,213,117,185,140,205,174,185,100,42,19,184,24,36,238,30,151,85,35,114,112,81,181,247,205,208,90,227,150,51,125,9,185,5,167,165,164,59,151,108,57,173,223,164,214,94,226,112,236,6,188,92,89,94,92,114,205,22,65,138,70,232,106,77,225,103,53,165,254,237,220,112,54,184,20,185,236,32,182,16,150,94,90,238,150,29,26,219,158,91,185,204,58,87,192,240,204,124,149,121,83,82,155,173,211,108,175,51,33,97,98,16,195,107,213,202,205,76,198,140,1,45,209,122,14,180,146,103,87,45,93,144,23,58,127,95,85,165,21,92,129,108,74,165,187,80,63,27,59,191,111,4,58,139,98,187,60,165,167,124,129,73,141,181,7,73,199,102,144,51,143,230,201,9,3,240,7,113,241,219,255,207,252,117,64,195,137,240,178,177,23,168,211,218,102,160,222,248,63,155,129,210,102,33,93,212,246,23,190,119,110,25,96,151,212,0,105,117,23,89,49,51,184,205,244,79,25,71,195,198,166,196,91,212,27,9,214,113,10,21,217,29,138,112,116,58,113,87,247,102,15,70,28,45,141,18,196,106,167,89,20,245,108,244,54,179,43,15,191,247,254,76,57,218,226,53,186,213,124,253,219,52,65,185,13,30,6,168,181,210,170,167,196,205,204,51,253,171,191,185,148,247,166,8,249,239,197,183,204,175,151,23,234,175,91,180,202,157,113,235,141,91,209,95,42,24,8,168,208,42,235,188,219,167,241,200,141,13,74,252,235,94,185,137,159,254,168,183,126,89,190,88,103,224,251,103,13,9,158,142,77,7,232,153,101,224,148,79,43,182,194,149,97,130,112,59,90,225,132,101,7,135,61,231,182,108,2,116,229,95,113,67,27,44,38,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2433ee1c-d882-476a-aa3e-688dee2b58c1"));
		}

		#endregion

	}

	#endregion

}

