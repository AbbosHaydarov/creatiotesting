namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImapSyncSessionSchema

	/// <exclude/>
	public class IImapSyncSessionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImapSyncSessionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImapSyncSessionSchema(IImapSyncSessionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5e207e3-b931-420a-8ad6-b7eb4a279b1a");
			Name = "IImapSyncSession";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,145,193,106,132,48,16,134,207,10,190,195,192,94,218,203,122,223,45,133,178,123,241,32,72,237,11,100,227,168,1,147,72,38,46,216,101,223,189,19,99,75,91,41,52,167,100,50,255,159,47,255,24,161,145,70,33,17,222,208,57,65,182,245,251,82,168,33,75,111,89,10,188,38,82,166,131,122,38,143,250,152,165,89,154,236,28,118,202,26,40,140,71,215,178,244,0,69,161,197,88,207,70,214,72,196,119,75,95,158,231,240,68,147,214,194,205,207,235,185,114,246,170,26,36,208,232,123,219,16,180,214,65,81,190,84,64,172,238,157,53,234,93,248,224,174,130,187,144,97,191,255,52,203,191,185,141,211,101,80,50,182,5,136,13,3,83,157,21,141,150,196,101,64,22,240,127,146,47,118,230,24,209,121,133,116,128,106,113,90,144,55,204,75,225,21,181,245,8,178,23,166,67,80,28,4,129,180,147,241,1,108,75,150,48,211,170,57,45,18,58,133,102,184,65,135,254,8,247,248,210,14,77,19,97,214,243,74,86,198,96,254,129,85,123,225,60,129,226,111,131,230,145,109,34,164,24,196,31,148,87,171,26,158,171,145,33,183,48,242,135,199,56,223,223,104,17,248,103,241,254,1,141,198,184,252,56,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5e207e3-b931-420a-8ad6-b7eb4a279b1a"));
		}

		#endregion

	}

	#endregion

}

