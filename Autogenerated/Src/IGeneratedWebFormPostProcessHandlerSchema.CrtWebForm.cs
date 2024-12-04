namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGeneratedWebFormPostProcessHandlerSchema

	/// <exclude/>
	public class IGeneratedWebFormPostProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGeneratedWebFormPostProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGeneratedWebFormPostProcessHandlerSchema(IGeneratedWebFormPostProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42225206-bcb0-46e4-8cc2-2d5b3676a730");
			Name = "IGeneratedWebFormPostProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91507ba4-1e7b-4fdd-954f-ec66d764e88d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,77,79,195,48,12,61,131,196,127,176,224,2,210,88,239,124,236,2,108,236,128,168,180,33,14,136,67,72,220,45,82,155,20,39,157,152,16,255,29,39,105,55,86,62,196,173,118,222,179,223,179,93,35,42,116,181,144,8,115,36,18,206,22,126,120,101,77,161,23,13,9,175,173,129,247,131,253,189,198,105,179,128,217,218,121,172,206,123,49,195,203,18,101,192,186,225,4,13,146,150,91,204,149,37,220,70,241,89,120,84,143,248,50,182,84,205,144,86,90,6,0,67,142,8,23,161,225,212,120,164,130,37,157,193,180,79,200,173,243,57,89,137,206,221,10,163,74,164,72,205,178,12,46,92,83,85,130,214,163,54,102,216,74,43,116,80,161,95,90,5,133,37,168,153,14,117,226,7,61,182,0,191,68,144,132,161,7,160,241,218,175,161,32,91,65,201,229,3,164,22,11,28,118,45,178,47,61,234,230,165,212,18,116,167,246,63,98,127,114,180,3,8,211,230,218,155,89,220,69,237,238,12,242,216,45,61,246,221,198,196,205,27,202,198,179,221,96,168,239,51,120,119,53,74,93,104,182,217,183,246,221,91,202,212,130,68,5,134,47,228,242,176,113,72,124,23,38,45,250,112,52,231,46,33,7,114,147,28,94,100,145,241,115,129,182,233,84,37,110,167,129,55,196,67,103,89,244,55,189,224,81,93,11,47,18,59,68,160,56,76,187,202,239,103,243,83,194,215,6,157,255,187,76,218,112,39,162,221,247,47,26,86,86,171,110,172,199,15,59,254,163,245,109,56,128,73,195,216,141,197,1,132,205,142,53,150,202,5,209,79,207,81,113,248,108,161,157,142,147,116,250,123,71,104,84,90,121,140,63,210,15,177,147,228,220,39,250,97,64,113,173,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42225206-bcb0-46e4-8cc2-2d5b3676a730"));
		}

		#endregion

	}

	#endregion

}

