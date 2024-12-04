namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMessagePublisherSchema

	/// <exclude/>
	public class SocialMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMessagePublisherSchema(SocialMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("338fe51c-5d19-4505-9d2c-889953ea22f6");
			Name = "SocialMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("203eb078-3e33-4e60-b9e9-a0b134c55d99");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,80,203,106,195,48,16,60,203,224,127,88,210,75,10,33,31,224,62,14,73,154,156,90,10,110,63,96,163,108,28,129,44,135,93,233,96,74,254,189,43,59,80,220,180,32,36,205,104,118,86,59,73,92,104,160,238,37,82,187,92,119,222,147,141,174,11,178,220,81,32,118,246,161,44,210,32,249,32,102,148,238,24,85,197,164,116,89,4,108,73,206,104,105,242,24,142,174,73,140,217,165,44,190,202,194,232,186,99,106,20,195,218,163,72,5,117,103,29,250,87,18,193,134,222,211,222,59,57,17,103,75,115,206,200,130,205,194,127,116,80,193,10,133,110,203,141,118,211,253,167,155,206,17,57,217,216,113,5,131,206,142,130,107,147,191,237,231,159,66,172,165,97,76,2,210,4,46,96,227,134,11,114,255,168,238,26,205,2,198,243,25,40,68,23,251,173,35,127,144,13,70,188,207,205,76,5,123,253,238,252,183,207,141,24,114,88,198,188,12,124,109,79,212,226,155,38,12,79,48,155,252,116,166,225,27,115,185,206,74,225,48,142,59,224,145,157,146,151,111,153,210,9,18,228,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("338fe51c-5d19-4505-9d2c-889953ea22f6"));
		}

		#endregion

	}

	#endregion

}

