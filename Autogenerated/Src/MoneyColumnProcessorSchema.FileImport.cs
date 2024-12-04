namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoneyColumnProcessorSchema

	/// <exclude/>
	public class MoneyColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoneyColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoneyColumnProcessorSchema(MoneyColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ada78ef-dac1-4b3e-9c3b-95c44f2ee05b");
			Name = "MoneyColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,65,79,235,48,12,199,207,32,241,29,172,113,217,36,212,222,129,77,130,161,161,29,64,72,143,189,11,226,224,165,238,136,212,38,197,73,144,166,39,190,251,115,147,13,214,82,144,184,180,137,245,247,223,241,47,142,193,154,92,131,138,224,145,152,209,217,210,103,115,107,74,189,9,140,94,91,147,45,116,69,203,186,177,236,79,142,255,157,28,31,5,167,205,6,254,108,157,167,250,226,99,127,152,205,244,93,60,91,160,242,150,53,57,81,136,230,148,105,35,53,96,94,161,115,231,112,103,13,109,231,182,10,181,121,96,171,200,57,203,81,151,231,57,92,106,243,66,172,125,97,21,40,166,114,58,90,84,22,125,79,62,202,103,123,189,11,117,141,188,221,239,175,12,104,227,60,26,233,213,150,224,95,180,3,213,214,5,89,176,64,176,198,233,117,69,80,90,134,38,249,181,29,196,67,129,138,101,224,13,171,64,46,219,151,200,15,106,60,221,80,137,161,242,215,218,20,146,55,246,219,134,108,57,94,246,14,56,57,131,123,97,14,83,48,242,19,193,80,211,147,201,179,56,54,97,93,105,181,59,228,144,12,206,97,136,129,164,202,69,201,247,147,175,244,230,57,180,236,5,243,67,244,77,138,223,146,253,130,54,6,230,76,232,201,117,1,75,255,162,36,218,121,14,53,32,158,45,203,175,48,83,164,65,198,58,114,154,142,130,35,150,54,12,169,118,42,71,179,149,236,229,86,246,129,236,50,143,234,152,188,3,55,84,113,188,234,248,64,215,118,34,68,215,232,104,220,15,183,131,127,244,190,131,74,166,72,92,187,144,165,70,67,236,101,184,5,49,91,47,185,84,252,68,249,90,42,253,2,242,13,122,76,3,152,216,6,163,95,101,173,11,50,94,151,154,248,27,148,50,203,233,44,96,223,228,53,138,30,110,131,46,162,223,223,214,238,81,220,86,203,2,166,179,110,44,139,0,251,178,244,114,251,20,18,155,110,240,253,63,142,146,147,103,93,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ada78ef-dac1-4b3e-9c3b-95c44f2ee05b"));
		}

		#endregion

	}

	#endregion

}

