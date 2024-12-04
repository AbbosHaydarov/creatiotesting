namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Base64ImageSchema

	/// <exclude/>
	public class Base64ImageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Base64ImageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Base64ImageSchema(Base64ImageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efe46806-614f-4213-8fdf-a9bbacc250fd");
			Name = "Base64Image";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,82,203,110,194,48,16,60,7,137,127,88,133,75,43,209,228,82,245,192,35,135,34,14,28,82,113,224,7,76,88,82,75,248,33,219,57,160,138,127,175,227,7,77,219,80,104,47,149,34,203,217,221,153,157,89,47,39,12,181,36,21,194,6,149,34,90,236,77,182,16,124,79,235,70,17,67,5,207,74,66,15,148,215,195,193,219,112,144,140,20,214,54,8,139,3,209,122,2,207,68,227,211,227,138,145,26,109,210,126,121,158,195,76,55,140,17,117,44,194,191,75,131,66,169,80,35,55,184,3,162,97,235,144,160,141,178,220,89,68,230,29,168,108,182,7,90,65,213,118,250,210,168,85,242,33,69,112,203,210,84,70,40,171,104,237,80,94,140,231,148,68,17,6,220,250,156,167,140,50,220,28,37,166,69,185,42,151,15,198,94,65,236,193,188,34,208,150,59,155,229,174,188,232,69,87,194,170,231,38,45,22,254,114,25,26,180,119,84,223,121,167,16,21,140,131,117,8,164,247,45,44,153,88,62,170,67,109,182,100,210,28,199,29,72,172,5,55,128,211,37,151,237,153,22,47,246,252,133,185,255,31,77,203,116,30,203,197,57,121,239,137,115,55,119,152,169,11,148,1,96,131,17,235,19,81,209,60,82,76,187,195,27,33,223,249,69,138,129,176,86,107,37,36,42,67,177,119,169,58,123,234,2,223,135,125,46,237,238,116,116,31,60,57,148,247,83,163,215,149,232,112,57,253,212,174,180,14,123,158,232,150,158,45,212,205,233,47,125,123,95,247,150,174,17,120,165,233,167,215,8,193,110,236,244,14,183,204,152,210,175,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efe46806-614f-4213-8fdf-a9bbacc250fd"));
		}

		#endregion

	}

	#endregion

}

