namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapClientSchema

	/// <exclude/>
	public class IImapClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapClientSchema(IImapClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4eefcdc0-dfe1-496a-a1c1-f92ded0404ac");
			Name = "IImapClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,93,106,195,48,16,132,159,19,200,29,4,125,73,161,248,0,73,233,139,243,131,161,46,129,250,2,178,61,118,4,178,100,180,114,218,80,114,247,174,165,52,53,129,128,5,218,209,199,104,52,54,178,3,245,178,130,40,224,156,36,219,248,36,151,74,47,230,63,139,249,108,32,101,90,241,121,38,143,110,125,55,39,169,213,26,149,87,214,80,178,135,129,83,21,51,76,61,57,180,172,138,204,120,184,134,189,87,34,203,58,217,167,90,193,120,6,248,235,135,82,171,74,168,63,100,74,48,190,81,212,91,146,165,6,179,99,146,155,105,14,127,180,53,173,196,33,56,132,11,103,165,181,90,20,238,188,129,134,199,206,234,26,110,73,222,141,105,155,48,125,240,59,159,215,55,54,117,144,247,160,193,87,20,14,210,31,35,123,178,170,22,185,61,33,7,145,108,81,216,71,222,47,226,42,113,157,129,84,94,255,139,53,184,49,35,199,174,162,193,36,202,214,208,224,174,81,182,223,138,60,61,74,254,206,135,175,161,167,72,191,137,61,124,220,210,114,68,66,79,48,117,172,106,156,120,93,226,63,153,200,151,95,198,6,107,135,245,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4eefcdc0-dfe1-496a-a1c1-f92ded0404ac"));
		}

		#endregion

	}

	#endregion

}

