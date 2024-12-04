namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetCreatioUrlExceptionSchema

	/// <exclude/>
	public class GetCreatioUrlExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetCreatioUrlExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetCreatioUrlExceptionSchema(GetCreatioUrlExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8a131b9-bd91-423b-a0a8-1db8f77c784a");
			Name = "GetCreatioUrlException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e340cd47-dd91-41d9-9076-90ff98ffd14e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,81,177,78,195,48,16,157,19,41,255,112,10,11,44,201,94,218,14,68,8,117,67,106,153,16,131,147,94,82,75,142,29,157,109,149,82,245,223,57,199,41,180,168,100,112,228,231,123,119,239,189,211,162,71,59,136,6,97,131,68,194,154,214,21,149,209,173,236,60,9,39,141,46,158,134,222,104,37,53,86,202,248,237,74,59,236,226,75,150,30,179,52,241,86,234,14,214,7,235,176,127,204,210,44,5,254,238,8,59,174,128,74,9,107,103,240,130,174,34,12,164,55,82,207,159,13,14,145,31,139,203,178,132,185,245,125,47,232,176,252,133,54,59,4,60,215,130,219,9,7,210,242,159,204,94,195,126,135,1,67,194,0,10,13,44,222,16,116,232,92,144,195,47,48,77,4,79,170,184,24,84,94,79,122,95,35,73,161,228,151,168,21,126,176,159,193,215,74,54,208,4,229,255,8,135,25,92,152,72,56,5,62,147,31,207,70,91,71,190,113,134,216,250,235,216,46,86,252,49,26,129,149,150,110,20,128,236,3,52,238,65,50,95,104,222,136,105,71,35,115,139,8,13,97,187,200,111,235,201,203,101,212,203,62,167,41,23,46,39,100,16,36,122,208,188,238,69,206,43,183,162,195,124,25,50,158,46,49,225,45,218,134,100,205,90,194,228,49,212,98,94,142,220,177,213,148,206,109,29,247,236,59,164,63,117,124,8,132,100,6,181,176,120,127,198,224,8,167,41,47,212,219,24,217,120,143,232,53,120,202,210,111,215,199,84,50,160,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8a131b9-bd91-423b-a0a8-1db8f77c784a"));
		}

		#endregion

	}

	#endregion

}

