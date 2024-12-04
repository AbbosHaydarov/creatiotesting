namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadQualificationHelperSchema

	/// <exclude/>
	public class LeadQualificationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadQualificationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadQualificationHelperSchema(LeadQualificationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0f5b581-b090-487e-b10f-878e77de698a");
			Name = "LeadQualificationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,219,106,227,48,16,125,246,66,255,97,112,94,90,216,214,239,105,19,8,133,237,6,186,176,183,124,128,106,143,83,129,44,155,145,92,8,75,255,125,71,242,165,150,19,167,105,75,243,148,25,105,206,156,57,199,35,45,10,52,149,72,17,254,34,145,48,101,110,175,110,75,157,203,109,77,194,202,82,195,191,179,47,81,109,164,222,194,159,157,177,88,92,247,241,176,130,144,243,124,50,35,220,186,170,181,182,72,57,227,206,97,125,143,34,251,85,11,37,115,153,122,204,239,168,42,36,127,63,73,18,184,49,117,81,8,218,45,219,120,214,253,224,209,95,188,156,185,84,159,126,57,239,131,171,14,41,25,64,85,245,131,146,41,200,142,201,36,17,55,34,223,223,227,18,144,25,118,133,125,30,77,228,120,236,19,105,50,149,32,81,128,102,189,23,177,98,34,235,44,94,142,33,67,176,155,196,215,120,136,167,82,102,176,74,29,233,85,206,3,173,51,212,182,159,227,252,174,230,227,6,245,194,25,244,220,152,129,58,107,252,8,188,73,149,48,102,14,239,178,165,181,228,35,134,248,246,83,221,231,175,186,212,77,241,77,42,204,120,140,159,84,90,76,45,102,39,152,56,146,121,156,153,176,175,234,58,0,49,181,82,171,29,108,12,18,175,137,230,180,227,18,134,215,71,152,108,126,223,195,123,26,26,75,110,229,86,85,165,90,85,54,164,218,70,35,155,123,133,152,17,151,213,169,45,201,233,228,213,63,69,164,131,223,120,251,143,203,16,33,37,204,23,241,132,81,113,178,60,117,15,234,64,183,193,62,188,226,211,112,51,246,64,69,160,81,188,28,73,62,172,109,191,200,137,65,206,71,46,135,108,191,118,158,132,253,46,252,131,25,69,163,218,197,168,218,45,105,20,133,118,242,165,16,203,95,122,62,110,242,15,180,143,101,246,22,127,225,136,203,125,244,121,47,89,171,249,147,36,203,146,195,27,30,182,70,217,195,122,28,122,240,56,247,31,147,68,247,57,223,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0f5b581-b090-487e-b10f-878e77de698a"));
		}

		#endregion

	}

	#endregion

}

