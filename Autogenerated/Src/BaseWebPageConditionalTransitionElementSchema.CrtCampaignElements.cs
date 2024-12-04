namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseWebPageConditionalTransitionElementSchema

	/// <exclude/>
	public class BaseWebPageConditionalTransitionElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseWebPageConditionalTransitionElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseWebPageConditionalTransitionElementSchema(BaseWebPageConditionalTransitionElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36372916-75d5-4795-9e9e-e90f800f6991");
			Name = "BaseWebPageConditionalTransitionElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1ad4dcfb-cad4-4faf-a986-0ecc7b2cc583");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,85,77,143,218,48,16,61,7,137,255,48,202,30,10,18,74,238,44,228,208,108,187,234,161,18,42,72,61,59,206,4,92,37,118,234,143,34,84,237,127,175,237,16,72,216,45,141,104,187,237,37,138,39,227,55,111,102,222,76,56,169,80,213,132,34,108,80,74,162,68,161,163,84,240,130,109,141,36,154,9,62,30,125,31,143,2,163,24,223,194,250,160,52,86,247,23,103,235,95,150,72,157,179,138,30,145,163,100,244,236,147,10,137,41,169,106,194,182,124,77,119,88,17,88,122,99,212,90,163,254,103,123,213,94,190,147,184,181,128,144,150,68,169,57,188,37,10,63,99,182,34,91,180,236,114,230,130,145,114,35,9,87,254,253,93,137,21,114,237,175,198,113,12,11,101,170,138,200,67,114,60,31,35,99,227,6,133,144,144,89,72,216,99,6,181,5,5,122,70,5,125,130,141,90,184,184,131,87,155,172,100,20,168,99,54,148,24,204,161,243,121,141,95,13,114,138,239,75,177,63,49,15,108,157,237,243,156,185,45,167,150,134,106,33,109,1,86,62,104,227,113,153,160,55,60,96,65,76,169,93,34,170,185,229,200,63,103,223,210,31,72,124,50,5,215,255,224,233,74,232,14,83,16,5,232,157,45,103,41,56,254,132,128,183,212,68,146,10,184,85,223,50,84,194,72,138,97,242,193,194,16,91,22,7,178,80,104,81,36,22,203,112,32,211,48,78,162,69,236,113,111,201,115,104,35,27,178,83,23,33,152,219,92,153,154,52,166,25,112,83,150,205,243,198,162,137,250,240,111,107,246,44,76,206,168,222,136,79,152,49,158,135,201,131,61,57,32,121,0,45,64,122,43,168,222,104,169,55,192,114,117,29,212,190,91,207,102,36,195,100,229,79,64,143,75,224,136,247,122,173,156,249,86,6,231,220,22,143,134,229,51,112,207,4,186,5,152,189,180,204,186,201,52,170,112,186,112,203,229,164,139,62,70,239,66,79,39,119,200,243,102,248,251,155,224,35,234,157,200,135,44,129,84,34,209,168,128,0,199,61,176,86,27,122,71,52,48,103,118,18,59,201,205,72,95,249,214,237,154,244,36,106,35,185,74,82,55,215,249,25,249,8,117,171,242,90,216,78,147,197,55,251,31,98,185,133,206,190,216,159,10,248,136,237,22,10,154,11,62,187,161,106,112,35,58,189,255,229,56,254,173,202,253,127,211,212,111,168,168,217,43,55,84,212,135,201,31,153,182,223,211,196,213,185,236,234,229,98,44,27,107,223,248,52,30,253,0,99,177,227,119,73,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36372916-75d5-4795-9e9e-e90f800f6991"));
		}

		#endregion

	}

	#endregion

}

