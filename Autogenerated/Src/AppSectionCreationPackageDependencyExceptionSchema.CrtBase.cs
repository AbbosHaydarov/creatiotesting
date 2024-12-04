namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AppSectionCreationPackageDependencyExceptionSchema

	/// <exclude/>
	public class AppSectionCreationPackageDependencyExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AppSectionCreationPackageDependencyExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AppSectionCreationPackageDependencyExceptionSchema(AppSectionCreationPackageDependencyExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("11a7b02d-3f17-45e0-a8d6-807497e95249");
			Name = "AppSectionCreationPackageDependencyException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,144,193,10,131,48,12,134,207,10,190,67,97,23,119,217,3,184,211,112,187,15,28,187,140,29,98,141,82,166,109,105,42,204,13,223,125,169,50,241,234,33,133,191,201,255,133,252,26,58,36,11,18,197,13,157,3,50,181,63,228,70,215,170,233,29,120,101,116,18,127,147,56,234,73,233,70,20,3,121,236,142,139,94,91,186,206,104,238,112,111,231,176,97,163,200,91,32,202,196,201,218,2,101,64,229,14,39,228,21,228,11,26,60,163,69,93,161,150,195,229,45,209,206,203,216,255,40,208,41,104,213,7,202,22,211,253,147,191,108,95,182,74,10,25,136,155,128,34,19,119,70,85,224,113,181,36,10,39,253,161,91,112,41,121,23,14,231,204,136,39,246,140,47,129,48,93,244,4,30,249,225,10,81,48,96,78,35,200,241,7,136,42,84,9,109,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11a7b02d-3f17-45e0-a8d6-807497e95249"));
		}

		#endregion

	}

	#endregion

}

