namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidIdentityServerSettingsExceptionSchema

	/// <exclude/>
	public class InvalidIdentityServerSettingsExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidIdentityServerSettingsExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidIdentityServerSettingsExceptionSchema(InvalidIdentityServerSettingsExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45eac23e-2e39-4284-bb79-03c123cf30e3");
			Name = "InvalidIdentityServerSettingsException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,82,205,106,194,64,16,62,27,200,59,12,122,81,176,62,128,98,15,13,30,114,40,8,233,173,20,89,147,49,44,172,179,97,118,35,181,226,187,119,204,38,26,108,15,82,122,219,157,111,231,251,99,73,237,209,85,42,71,120,67,102,229,236,206,207,18,75,59,93,214,172,188,182,52,123,169,246,150,140,38,76,140,173,139,148,60,150,1,137,163,83,28,13,106,167,169,132,236,232,60,238,23,113,36,147,17,99,41,48,36,70,57,55,135,148,14,202,232,34,45,144,188,246,199,12,249,128,156,161,247,178,231,86,159,57,86,129,76,54,223,5,212,242,248,75,109,13,142,39,31,50,170,234,173,209,57,228,23,174,7,169,96,14,61,218,193,197,228,205,147,37,231,185,206,189,101,177,182,110,200,27,233,78,232,49,137,241,4,26,218,243,95,118,197,192,165,50,233,221,169,18,39,98,119,171,28,142,175,247,255,98,158,222,106,0,77,132,124,189,222,107,78,127,224,125,15,35,164,34,212,23,71,253,46,215,108,43,100,175,241,247,38,173,88,100,93,32,180,174,94,131,22,44,159,97,216,5,129,144,4,92,27,5,180,3,178,30,154,180,240,36,243,6,174,217,76,229,11,104,89,74,11,176,220,158,51,204,25,253,48,252,186,78,182,85,91,49,91,78,172,200,159,160,68,191,128,51,44,97,40,118,26,221,141,14,133,110,58,225,142,228,46,107,104,160,63,60,127,3,117,18,233,26,49,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45eac23e-2e39-4284-bb79-03c123cf30e3"));
		}

		#endregion

	}

	#endregion

}

