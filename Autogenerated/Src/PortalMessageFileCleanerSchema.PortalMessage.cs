namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFileCleanerSchema

	/// <exclude/>
	public class PortalMessageFileCleanerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFileCleanerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFileCleanerSchema(PortalMessageFileCleanerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("58b34129-eda1-43f6-b441-329cc91b3415");
			Name = "PortalMessageFileCleaner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,193,110,219,48,12,61,187,64,255,129,112,47,14,208,217,59,119,137,135,213,109,134,28,10,20,88,139,29,7,197,166,83,1,178,228,81,82,179,108,232,191,143,182,146,44,113,147,44,23,3,34,159,30,31,31,41,107,209,160,109,69,137,240,132,68,194,154,218,165,133,209,181,92,120,18,78,26,125,121,241,231,242,34,242,86,234,5,124,91,89,135,205,167,237,121,247,10,225,177,120,122,119,203,41,78,94,17,46,152,17,10,37,172,189,129,71,67,78,168,7,180,86,44,112,42,21,22,10,133,70,234,177,173,159,43,89,66,217,65,79,32,35,22,199,223,45,245,84,162,170,58,110,146,175,194,97,72,182,225,0,132,162,50,90,173,224,217,34,113,147,26,203,174,67,248,225,247,206,65,108,116,133,186,10,172,251,37,24,104,29,249,210,25,234,10,245,58,3,34,203,50,24,91,223,52,130,86,249,38,48,211,210,73,161,228,111,180,160,113,9,146,111,11,205,126,155,154,193,136,80,18,214,147,248,88,139,113,150,167,91,238,108,72,62,110,5,137,6,52,15,113,18,239,119,17,231,93,151,80,110,3,233,56,235,209,253,229,181,189,199,170,38,3,135,246,169,71,208,173,68,20,13,124,131,201,0,215,45,68,244,118,218,205,7,116,47,166,58,199,200,59,84,232,216,196,182,215,12,77,16,13,53,171,134,249,10,22,242,21,53,200,10,181,147,181,228,206,217,223,3,208,115,205,108,135,206,204,170,56,159,253,151,125,215,227,158,147,208,121,210,54,127,34,143,215,32,235,160,119,41,44,84,125,63,213,53,24,247,130,180,148,22,225,3,212,66,217,142,101,115,109,103,86,115,99,212,218,132,119,99,75,190,122,89,193,1,205,155,81,5,190,126,1,3,69,50,24,222,168,135,69,233,148,76,147,188,223,198,120,157,143,210,239,44,22,147,152,237,216,132,162,116,102,239,127,122,161,146,194,40,223,232,244,177,179,128,107,80,114,72,209,150,233,139,174,146,184,224,71,201,46,220,174,206,35,28,168,78,11,79,196,51,233,214,181,251,109,57,81,186,127,37,210,251,95,88,122,238,117,4,57,124,132,207,192,207,22,225,38,152,124,98,57,67,116,63,248,246,23,167,26,48,111,41,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58b34129-eda1-43f6-b441-329cc91b3415"));
		}

		#endregion

	}

	#endregion

}

