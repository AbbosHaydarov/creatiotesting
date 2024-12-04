namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Office365OAuthClientSchema

	/// <exclude/>
	public class Office365OAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Office365OAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Office365OAuthClientSchema(Office365OAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("455c7107-3388-47b8-bf89-0df39b6d2de3");
			Name = "Office365OAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,77,79,194,64,16,61,67,194,127,152,148,75,73,72,123,48,122,64,32,81,140,198,68,197,160,158,140,135,101,59,133,77,96,183,217,15,13,49,252,119,103,183,128,5,10,135,166,157,143,247,102,223,155,45,72,182,68,83,48,142,240,142,90,51,163,114,155,140,148,204,197,204,105,102,133,146,173,230,111,171,217,112,70,200,217,94,139,198,235,19,249,228,158,113,171,180,64,83,215,241,166,184,96,139,100,124,227,236,156,234,212,145,166,41,244,141,91,46,153,94,13,55,241,4,11,141,6,165,53,192,36,140,243,92,112,188,184,186,132,0,3,190,16,84,74,182,216,180,2,254,188,195,156,185,133,189,21,50,163,193,177,93,21,168,242,56,224,70,1,214,233,194,11,137,134,1,68,59,222,74,57,234,124,17,77,225,166,11,193,105,16,51,6,234,218,160,7,149,136,16,222,165,70,91,227,140,60,3,114,208,88,237,188,13,166,7,175,129,44,104,61,18,27,18,149,118,47,234,88,85,153,41,152,102,75,240,27,27,68,206,160,126,82,51,33,163,97,63,13,133,208,183,57,119,221,137,99,26,225,87,177,67,118,225,131,62,105,182,68,238,55,29,42,255,97,199,243,53,122,48,101,6,227,10,232,160,11,130,240,117,169,174,141,50,43,45,216,196,27,63,158,209,206,85,230,173,208,202,18,16,179,51,110,76,208,58,45,105,241,116,116,58,183,224,140,124,129,156,30,138,207,220,133,83,182,233,146,111,216,55,136,192,53,230,131,168,254,58,38,143,225,229,159,221,220,40,29,130,160,237,48,201,49,233,167,91,174,224,245,86,11,168,111,226,19,25,66,13,1,60,160,221,75,196,231,93,47,253,108,148,131,64,226,207,193,50,247,185,14,192,254,135,171,219,133,207,173,255,0,26,184,157,157,236,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("455c7107-3388-47b8-bf89-0df39b6d2de3"));
		}

		#endregion

	}

	#endregion

}

