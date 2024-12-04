namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSynchronizationDataAccessExceptionSchema

	/// <exclude/>
	public class GoogleSynchronizationDataAccessExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSynchronizationDataAccessExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSynchronizationDataAccessExceptionSchema(GoogleSynchronizationDataAccessExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa6fe31b-4855-4a7a-adcc-c5b7fb65f30f");
			Name = "GoogleSynchronizationDataAccessException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,146,65,75,195,64,16,133,207,9,228,63,12,237,165,129,210,220,163,22,164,138,87,161,254,129,233,118,146,46,36,187,203,206,6,141,226,127,119,147,109,76,90,61,84,212,227,62,230,189,249,30,179,10,107,98,131,130,224,137,172,69,214,133,91,109,180,42,100,217,88,116,82,171,36,126,75,226,36,142,26,150,170,132,109,203,142,234,171,94,153,91,42,253,0,108,42,100,206,225,65,235,178,162,109,171,196,193,106,37,95,123,247,29,58,188,21,130,152,239,95,4,153,16,232,189,89,150,193,53,55,117,141,182,93,31,223,33,0,208,72,216,123,27,96,239,3,26,140,240,108,209,24,178,171,193,159,77,2,76,179,171,164,0,209,177,92,140,2,57,76,176,162,80,116,236,165,21,59,219,8,167,173,175,247,216,47,8,19,231,244,71,129,8,132,165,226,102,246,25,186,72,103,217,186,227,253,10,60,16,95,202,186,72,193,243,69,209,251,79,17,124,7,127,185,63,4,9,129,224,255,13,99,73,105,23,17,229,176,67,166,197,160,253,10,117,57,30,229,223,168,39,59,64,42,69,118,92,249,77,159,229,249,204,73,191,57,169,125,248,50,253,59,168,167,162,215,62,0,0,35,219,129,105,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa6fe31b-4855-4a7a-adcc-c5b7fb65f30f"));
		}

		#endregion

	}

	#endregion

}

