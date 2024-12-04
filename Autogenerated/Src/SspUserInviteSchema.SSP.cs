namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserInviteSchema

	/// <exclude/>
	public class SspUserInviteSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserInviteSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserInviteSchema(SspUserInviteSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0da7f03-8582-4036-b93e-8094a1fe6e41");
			Name = "SspUserInvite";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,84,193,106,2,49,16,61,87,240,31,6,188,235,93,219,130,72,17,161,136,184,245,84,122,136,113,180,129,221,100,153,73,44,34,254,123,147,172,86,183,22,141,246,178,236,14,243,230,189,55,179,51,90,20,200,165,144,8,111,72,36,216,44,109,123,96,244,82,173,28,9,171,140,110,103,217,164,217,216,54,27,15,142,149,94,65,182,97,139,69,175,217,240,145,22,225,202,167,192,32,23,204,93,200,184,156,49,210,72,175,149,197,152,208,233,116,224,145,93,81,8,218,60,239,191,125,117,43,148,70,130,165,33,40,13,89,145,131,138,152,246,1,210,57,193,148,110,158,43,9,50,112,212,41,160,11,163,211,64,212,235,17,65,236,143,182,9,153,18,201,42,244,2,39,177,84,84,118,38,45,6,94,10,161,114,48,203,131,44,231,75,7,81,231,170,14,178,216,82,232,74,5,220,194,10,109,15,56,60,118,23,104,38,199,234,85,59,164,29,45,46,243,12,157,90,28,115,255,195,4,218,143,60,201,212,216,39,222,197,228,255,145,254,162,80,122,166,85,154,177,58,32,153,51,76,30,200,228,200,215,57,222,63,98,250,52,100,223,101,170,122,239,75,105,156,78,115,245,11,113,155,45,95,5,53,99,250,180,94,43,192,221,67,219,235,28,146,113,101,146,189,58,224,46,206,113,170,185,208,146,155,156,77,145,93,110,195,42,135,245,175,46,217,69,162,185,49,57,100,78,74,244,103,166,198,2,79,96,201,97,239,210,221,32,242,183,236,235,83,229,88,157,50,175,57,237,110,68,96,170,169,204,159,56,199,193,20,111,88,132,133,113,126,97,128,80,26,186,50,177,104,111,196,161,143,125,105,213,250,207,78,182,80,47,170,179,25,191,171,104,61,184,251,6,156,224,230,225,49,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0da7f03-8582-4036-b93e-8094a1fe6e41"));
		}

		#endregion

	}

	#endregion

}

