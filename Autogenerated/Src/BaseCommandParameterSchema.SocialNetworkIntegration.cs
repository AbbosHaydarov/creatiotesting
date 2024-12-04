namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCommandParameterSchema

	/// <exclude/>
	public class BaseCommandParameterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCommandParameterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCommandParameterSchema(BaseCommandParameterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a330adc7-9feb-43e7-b328-86d676594b41");
			Name = "BaseCommandParameter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,81,207,75,195,48,20,62,103,176,255,33,116,151,22,70,209,171,178,139,19,79,78,134,29,94,196,195,91,251,86,3,77,50,95,94,6,90,250,191,155,166,157,176,225,244,148,228,123,239,251,69,12,104,116,123,40,81,110,144,8,156,221,113,190,180,102,167,106,79,192,202,154,188,176,165,130,102,58,105,167,147,233,68,120,167,76,45,139,79,199,168,243,71,101,62,110,207,193,103,111,88,105,204,11,164,192,83,95,81,37,108,133,189,25,97,29,30,114,217,128,115,55,242,14,28,46,173,214,96,170,53,80,8,194,72,113,239,245,30,24,66,10,38,40,249,45,0,123,191,109,84,41,203,158,119,129,38,134,124,63,30,107,178,123,36,86,24,140,214,145,62,204,163,246,10,245,22,41,125,10,100,185,144,137,9,103,146,245,70,71,39,199,212,87,138,11,65,88,8,81,35,247,85,133,112,227,165,187,172,119,128,198,255,46,248,210,79,254,81,156,161,169,134,18,167,141,86,200,239,182,58,171,51,202,219,67,248,61,85,225,209,103,99,139,120,73,179,209,140,144,61,153,113,156,63,88,210,192,105,210,94,117,139,246,186,75,230,177,233,124,136,151,253,17,102,64,79,193,238,27,210,247,113,202,68,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a330adc7-9feb-43e7-b328-86d676594b41"));
		}

		#endregion

	}

	#endregion

}

