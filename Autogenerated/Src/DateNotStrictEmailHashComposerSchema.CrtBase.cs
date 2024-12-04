namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateNotStrictEmailHashComposerSchema

	/// <exclude/>
	public class DateNotStrictEmailHashComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateNotStrictEmailHashComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateNotStrictEmailHashComposerSchema(DateNotStrictEmailHashComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("24733d4d-8f04-4aad-aee5-3ff56062b864");
			Name = "DateNotStrictEmailHashComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,83,201,110,219,48,16,61,43,64,254,97,160,94,36,192,149,209,107,26,27,240,150,214,64,147,22,181,123,105,208,3,45,141,108,22,20,105,112,73,97,20,249,247,12,169,197,91,226,83,15,189,16,152,229,189,153,121,51,148,172,66,179,101,57,194,18,181,102,70,149,54,155,40,89,242,181,211,204,114,37,175,175,254,94,95,69,206,112,185,134,197,206,88,172,62,158,216,148,47,4,230,62,217,100,159,80,162,230,249,62,231,144,86,227,91,254,236,142,229,86,105,142,134,50,40,231,157,198,53,241,193,68,48,99,110,96,202,44,62,40,187,176,68,109,103,21,227,226,51,51,155,137,170,182,202,160,14,136,126,191,15,183,198,85,21,211,187,97,99,7,52,228,26,9,110,0,61,14,54,4,36,131,203,92,184,194,55,66,20,134,175,4,130,229,21,66,129,130,237,76,214,18,246,15,24,31,167,88,50,39,236,152,75,15,76,236,110,139,170,76,230,103,253,164,61,120,32,89,97,0,241,229,198,227,244,23,241,110,221,74,240,28,242,208,236,101,0,220,192,152,25,124,69,129,136,182,68,111,39,220,61,218,141,42,72,186,111,129,189,14,158,106,212,56,16,153,48,202,235,84,14,226,243,113,104,167,214,219,104,146,31,100,210,117,200,122,219,61,232,114,167,203,175,105,220,31,2,175,182,2,43,148,54,220,142,151,241,92,199,118,96,245,68,39,192,11,132,249,76,186,10,53,163,37,220,26,26,92,174,135,240,86,77,112,23,90,168,87,156,130,191,216,40,250,194,141,237,248,154,181,15,64,226,31,56,140,36,169,191,201,40,226,37,36,199,220,126,238,185,185,163,227,113,26,103,210,183,87,36,49,181,211,237,103,129,178,240,11,51,113,218,22,141,158,152,134,138,75,103,113,140,37,93,54,149,12,93,101,109,114,54,42,138,251,144,96,146,247,31,154,234,7,176,81,105,105,209,151,80,29,168,30,202,135,190,51,185,198,164,19,109,46,137,67,50,113,50,81,47,76,127,164,88,211,117,180,112,171,223,148,180,175,91,219,189,54,220,180,65,241,195,225,218,240,88,21,187,14,234,141,54,176,164,63,245,83,201,189,10,173,163,142,63,167,255,193,40,35,47,248,63,155,228,57,188,26,233,104,100,115,117,33,64,254,240,63,169,122,253,69,131,93,123,143,157,228,123,1,231,32,103,167,150,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("24733d4d-8f04-4aad-aee5-3ff56062b864"));
		}

		#endregion

	}

	#endregion

}

