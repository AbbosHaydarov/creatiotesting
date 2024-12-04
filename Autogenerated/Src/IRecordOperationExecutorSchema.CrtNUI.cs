namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordOperationExecutorSchema

	/// <exclude/>
	public class IRecordOperationExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordOperationExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordOperationExecutorSchema(IRecordOperationExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca04445c-be77-4cfb-a8da-af3e457c1459");
			Name = "IRecordOperationExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,81,203,110,194,48,16,60,131,196,63,172,224,210,94,226,59,165,92,42,14,28,170,34,212,31,112,147,117,176,132,237,104,189,174,26,33,254,189,126,36,81,1,245,96,89,30,207,140,103,199,86,26,244,157,172,17,62,145,72,122,167,184,122,115,86,233,54,144,100,237,44,92,22,243,89,240,218,182,55,12,194,106,103,89,179,70,255,178,152,71,202,138,176,77,244,189,101,36,21,13,215,176,63,98,237,168,249,232,176,88,237,126,176,14,236,40,243,133,16,176,241,193,24,73,253,118,56,79,90,112,10,248,20,183,81,10,56,104,65,197,69,217,183,26,93,196,31,155,46,124,157,117,13,122,114,250,47,4,196,185,34,127,202,253,142,124,114,141,95,195,33,59,148,203,251,144,25,40,14,232,239,18,166,96,152,42,233,83,176,199,100,5,233,36,73,3,54,182,254,186,212,140,102,185,205,53,246,15,19,87,27,145,185,89,250,237,116,51,190,251,52,8,146,250,185,116,63,91,161,109,202,28,249,124,45,63,114,3,70,236,23,40,178,17,166,236,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca04445c-be77-4cfb-a8da-af3e457c1459"));
		}

		#endregion

	}

	#endregion

}

