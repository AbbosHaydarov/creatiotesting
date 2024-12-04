namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateModelExtensionsSchema

	/// <exclude/>
	public class DCTemplateModelExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateModelExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateModelExtensionsSchema(DCTemplateModelExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("889db59a-a550-4a40-8bed-d98e58a15c58");
			Name = "DCTemplateModelExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69e28147-db31-49df-9976-b6fb9eb762c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,84,77,111,226,48,16,61,83,169,255,97,212,94,130,180,114,238,93,202,1,88,85,43,129,22,21,164,61,59,206,16,172,250,35,107,59,42,209,138,255,190,254,136,83,160,213,114,0,229,249,189,55,111,102,98,20,149,104,91,202,16,246,104,12,181,250,224,200,82,171,3,111,58,67,29,215,138,172,122,69,37,103,30,116,168,28,217,232,26,133,189,191,251,123,127,55,233,44,87,13,236,122,235,80,122,149,16,200,130,196,146,23,84,104,56,251,126,203,89,115,245,199,131,30,126,52,216,120,42,44,5,181,22,158,96,181,220,163,108,5,117,24,11,252,56,249,98,54,120,69,118,89,150,48,179,157,148,212,244,243,225,57,4,162,92,89,192,204,5,137,238,168,107,11,7,109,192,13,118,32,169,226,109,39,82,51,217,171,188,48,107,187,74,112,6,214,121,10,3,22,3,253,39,206,196,119,238,191,199,14,54,169,232,19,108,163,79,58,188,13,28,129,87,116,157,241,129,173,54,14,107,16,220,58,208,7,48,216,122,29,245,177,141,150,192,58,99,252,156,97,214,82,67,165,193,3,248,241,227,243,67,238,231,161,156,135,46,62,183,145,144,168,186,149,204,135,29,2,75,75,28,135,67,102,101,20,124,232,77,202,56,223,165,140,85,15,173,225,218,112,215,127,228,100,227,166,9,108,169,241,83,227,45,85,206,194,59,23,2,42,4,139,141,12,101,184,2,119,228,22,180,169,209,248,90,217,60,84,187,158,250,218,207,98,182,90,190,166,18,113,230,115,120,65,151,98,12,176,93,244,219,33,76,17,125,111,182,52,182,53,133,231,88,99,50,246,153,29,34,58,33,59,12,13,20,39,207,3,133,239,16,94,230,240,25,104,240,12,167,111,3,180,16,154,189,253,84,53,158,208,174,81,53,238,24,78,201,37,76,18,126,165,176,57,233,174,147,94,48,6,73,135,228,247,17,13,22,85,168,127,227,149,95,235,162,34,17,154,78,137,183,72,212,138,100,215,105,170,117,30,126,201,175,48,225,69,191,66,203,80,213,254,198,21,77,16,52,185,241,175,242,102,237,254,136,106,209,23,58,8,244,16,240,34,253,215,180,236,187,161,246,45,51,46,167,122,202,140,81,174,195,142,139,105,186,254,147,71,31,51,93,160,248,124,78,127,10,87,224,249,31,200,121,101,31,156,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("889db59a-a550-4a40-8bed-d98e58a15c58"));
		}

		#endregion

	}

	#endregion

}

