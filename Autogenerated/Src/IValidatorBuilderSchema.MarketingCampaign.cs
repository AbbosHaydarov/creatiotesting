namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IValidatorBuilderSchema

	/// <exclude/>
	public class IValidatorBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IValidatorBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IValidatorBuilderSchema(IValidatorBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69b4bd13-570c-4f3c-b839-d638ec3973a5");
			Name = "IValidatorBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,65,107,195,48,12,133,207,13,228,63,232,184,93,226,31,176,144,195,202,24,185,118,99,119,37,85,138,192,150,139,100,15,202,216,127,159,221,38,48,8,248,96,235,189,167,239,97,16,12,100,87,156,9,62,73,21,45,46,169,59,70,89,248,146,21,19,71,105,155,159,182,57,100,99,185,192,199,205,18,133,162,123,79,115,21,173,123,39,33,229,249,165,109,138,203,57,7,189,229,16,80,111,195,250,126,205,236,207,164,176,68,133,9,141,224,27,61,159,239,171,65,179,167,110,203,185,127,193,107,158,60,207,192,146,72,151,90,110,252,122,164,162,174,251,138,169,246,218,33,239,131,163,18,166,29,9,60,91,170,184,61,239,49,81,74,89,197,134,149,181,229,172,119,155,82,173,227,155,228,64,138,147,167,126,171,85,172,167,226,28,96,20,78,245,102,79,207,229,75,14,191,109,83,206,31,127,160,61,236,101,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69b4bd13-570c-4f3c-b839-d638ec3973a5"));
		}

		#endregion

	}

	#endregion

}

