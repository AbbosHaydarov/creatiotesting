namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingValidationResultSchema

	/// <exclude/>
	public class MailingValidationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingValidationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingValidationResultSchema(MailingValidationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("747cb118-3319-4f07-acbc-f9174f4e8cb1");
			Name = "MailingValidationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f5a6178-e602-42c0-b4d9-e7d8824941b4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,143,77,10,194,48,16,133,215,41,244,14,115,2,115,0,197,77,215,221,136,184,159,166,105,8,228,71,50,137,32,165,119,55,53,165,213,174,52,139,9,12,239,123,239,141,67,43,233,142,66,194,85,134,128,228,135,120,104,188,27,180,74,1,163,246,174,174,198,186,130,252,56,231,112,162,100,45,134,231,121,91,101,113,68,237,8,180,27,124,176,111,6,176,243,41,130,69,109,180,83,240,64,163,251,197,108,117,226,223,86,247,212,25,45,64,24,36,130,182,128,183,149,187,72,74,38,22,101,174,195,216,174,76,89,108,122,200,71,17,42,185,74,63,210,24,91,178,40,134,185,221,70,181,5,130,17,148,140,71,160,121,76,117,245,75,158,240,253,159,97,77,38,246,73,243,121,249,155,94,126,179,29,128,149,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("747cb118-3319-4f07-acbc-f9174f4e8cb1"));
		}

		#endregion

	}

	#endregion

}

