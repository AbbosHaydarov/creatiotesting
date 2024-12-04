namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SubjectEmailHashComposerSchema

	/// <exclude/>
	public class SubjectEmailHashComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SubjectEmailHashComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SubjectEmailHashComposerSchema(SubjectEmailHashComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ab466a0-81cf-410f-864e-38ae3b3a01c4");
			Name = "SubjectEmailHashComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,93,107,219,64,16,124,86,32,255,97,73,95,36,48,242,123,154,4,98,59,73,13,253,162,113,40,180,228,225,44,173,229,11,167,59,179,123,231,86,148,252,247,238,73,103,213,105,8,8,193,206,236,205,206,205,158,85,45,242,78,85,8,43,36,82,236,54,190,156,59,187,209,77,32,229,181,179,167,39,127,78,79,178,192,218,54,112,223,177,199,86,120,99,176,138,36,151,119,104,145,116,245,126,236,57,150,33,124,11,47,111,85,229,29,105,100,233,144,158,233,116,10,23,28,218,86,81,119,149,234,185,81,204,80,17,42,143,12,216,42,109,96,171,120,43,133,182,149,9,117,148,221,57,102,189,54,8,149,179,123,36,31,49,209,109,180,85,6,56,172,159,196,104,121,24,48,61,154,240,115,129,27,21,140,159,105,27,133,114,223,237,208,109,242,229,77,156,243,65,198,204,93,43,226,72,197,4,62,75,72,112,9,103,247,131,222,171,150,179,226,81,20,119,97,109,116,5,85,111,251,173,86,56,135,153,98,124,133,203,121,201,89,254,217,59,194,70,162,133,79,232,183,174,230,115,248,218,235,14,100,154,225,228,170,164,107,132,229,141,13,45,146,146,4,46,216,147,92,228,10,238,208,71,101,228,252,65,132,101,153,118,88,22,132,23,229,4,70,19,139,213,151,33,223,2,226,178,179,236,163,102,63,234,165,204,47,193,226,47,56,102,242,34,174,55,203,246,138,14,81,75,215,181,168,239,181,239,30,188,54,92,222,234,223,223,183,218,15,111,140,243,126,74,153,194,73,199,7,253,242,186,174,191,41,219,96,62,250,95,90,143,36,123,204,255,55,30,141,188,48,63,184,206,146,174,152,72,118,38,9,71,91,47,228,21,9,145,12,36,32,241,51,87,119,35,23,139,132,175,116,139,63,156,253,119,238,0,244,244,115,145,46,64,232,3,217,148,83,15,61,167,85,202,152,97,155,125,45,168,124,127,1,208,32,73,209,114,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ab466a0-81cf-410f-864e-38ae3b3a01c4"));
		}

		#endregion

	}

	#endregion

}

