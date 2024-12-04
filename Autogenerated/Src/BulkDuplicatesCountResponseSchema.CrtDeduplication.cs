namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDuplicatesCountResponseSchema

	/// <exclude/>
	public class BulkDuplicatesCountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDuplicatesCountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDuplicatesCountResponseSchema(BulkDuplicatesCountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b8e96c8-ec0b-4b5d-87fb-133c37e8eac7");
			Name = "BulkDuplicatesCountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,77,79,195,48,12,134,207,157,212,255,96,109,23,184,180,119,86,118,160,147,122,26,76,219,110,136,67,218,186,37,144,38,85,62,144,198,180,255,142,211,106,43,42,3,164,157,18,59,239,107,251,137,37,107,208,180,172,64,216,161,214,204,168,202,70,169,146,21,175,157,102,150,43,25,78,14,225,36,112,134,203,26,182,123,99,177,153,143,98,210,11,129,133,23,155,40,67,137,154,23,127,106,158,242,55,186,174,84,137,226,135,110,227,164,229,13,70,91,170,194,4,255,236,102,32,21,233,102,26,107,10,32,21,204,152,59,120,112,226,125,233,90,193,11,102,209,100,90,185,118,67,40,212,0,59,249,243,146,89,70,40,86,179,194,190,80,162,117,57,137,161,240,246,145,59,85,212,118,112,7,30,249,220,111,173,85,139,218,114,164,166,235,174,70,87,63,136,227,24,18,227,154,134,233,253,226,148,200,208,26,80,26,140,63,237,43,130,116,77,142,26,84,5,181,31,209,68,103,107,60,246,38,31,76,56,92,236,46,185,146,184,127,244,218,142,108,133,94,113,243,72,251,131,123,152,246,178,142,99,122,235,105,79,184,66,209,231,102,195,43,28,160,70,59,247,3,206,225,120,29,73,121,254,56,224,242,74,174,139,53,254,163,28,76,191,145,142,118,122,137,118,134,178,236,87,75,81,159,251,158,10,39,199,47,16,247,61,82,21,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b8e96c8-ec0b-4b5d-87fb-133c37e8eac7"));
		}

		#endregion

	}

	#endregion

}

