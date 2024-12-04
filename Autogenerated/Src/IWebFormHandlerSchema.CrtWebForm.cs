namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormHandlerSchema

	/// <exclude/>
	public class IWebFormHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormHandlerSchema(IWebFormHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85b340bd-4e82-4d09-9c7d-737d1496c5d3");
			Name = "IWebFormHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,49,107,195,48,16,133,231,24,252,31,142,100,105,23,107,119,211,44,45,77,60,20,66,27,232,172,88,39,71,96,75,230,36,25,74,233,127,175,36,59,198,105,233,34,238,30,223,187,123,58,205,59,180,61,175,17,78,72,196,173,145,174,120,50,90,170,198,19,119,202,232,60,251,202,179,149,183,74,55,255,33,197,30,53,134,18,197,7,158,95,12,117,239,72,131,170,241,33,207,130,117,67,216,4,8,42,237,144,100,216,84,66,53,113,7,174,69,139,148,48,198,24,108,173,239,58,78,159,187,169,63,146,25,148,64,11,234,234,133,43,201,22,104,239,207,173,170,23,208,175,249,229,44,188,161,245,173,171,180,52,193,22,255,53,167,123,69,119,49,194,150,112,76,195,82,164,63,153,146,48,14,181,224,46,8,50,204,4,193,29,47,102,124,25,108,84,122,78,188,3,29,14,253,184,142,134,231,192,175,119,167,27,251,150,37,42,153,6,163,196,180,37,102,190,139,79,244,36,60,22,247,227,97,87,27,212,98,140,159,250,239,241,220,55,98,208,126,0,54,255,177,51,226,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85b340bd-4e82-4d09-9c7d-737d1496c5d3"));
		}

		#endregion

	}

	#endregion

}

