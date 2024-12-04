namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFormDataToEntityMapperSchema

	/// <exclude/>
	public class IFormDataToEntityMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFormDataToEntityMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFormDataToEntityMapperSchema(IFormDataToEntityMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c20ea6f3-be52-42d0-824d-0e9ad343f8f2");
			Name = "IFormDataToEntityMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,205,106,195,48,12,62,167,208,119,16,61,109,48,146,7,88,215,203,182,142,29,122,106,97,103,215,81,18,67,98,7,217,110,9,99,239,62,201,73,187,150,82,6,198,216,70,223,143,62,217,170,14,125,175,52,194,14,137,148,119,85,200,95,157,173,76,29,73,5,227,108,254,129,22,249,136,229,23,238,215,142,186,45,210,193,104,156,207,190,231,179,44,122,99,235,43,40,97,254,110,131,9,6,253,51,23,240,42,138,2,150,62,118,157,162,97,53,221,119,164,172,175,152,205,131,236,80,170,160,32,56,64,129,14,57,156,96,197,5,174,143,251,214,104,48,54,32,85,226,248,83,236,188,49,114,231,146,228,176,81,125,143,196,165,98,237,70,55,61,172,91,85,67,104,84,96,158,210,104,238,203,195,177,193,208,32,65,199,112,105,135,57,196,20,150,224,163,214,232,125,21,219,118,200,207,156,151,166,178,189,115,45,108,199,58,72,186,89,141,65,90,207,126,230,179,187,62,54,92,174,106,156,172,120,112,90,71,98,197,50,146,88,152,172,220,209,244,33,21,157,56,254,84,225,63,217,87,194,212,242,152,51,84,228,58,104,21,39,113,87,43,189,244,138,84,7,150,255,202,203,66,162,145,208,23,43,217,175,41,150,69,170,60,3,111,192,163,238,98,53,206,11,156,229,153,31,27,163,155,241,7,92,146,73,42,18,3,150,87,180,7,103,74,224,65,63,156,134,159,62,144,28,158,96,98,29,69,30,101,6,156,5,175,95,129,214,231,65,229,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c20ea6f3-be52-42d0-824d-0e9ad343f8f2"));
		}

		#endregion

	}

	#endregion

}

