namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalculateAgeHelperSchema

	/// <exclude/>
	public class CalculateAgeHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalculateAgeHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalculateAgeHelperSchema(CalculateAgeHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7036e87b-0dda-4a95-ba07-111b121eb842");
			Name = "CalculateAgeHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1fca9dd8-7af0-4ded-b1a3-aead7ca3b750");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,84,77,111,19,49,16,61,111,164,252,135,33,149,170,228,144,93,184,150,52,168,10,80,56,180,170,68,169,212,163,235,157,108,45,188,246,226,143,160,8,245,191,51,182,247,139,54,165,92,16,23,107,61,126,111,230,121,230,121,21,171,209,54,140,35,92,163,49,204,234,173,203,55,90,109,69,229,13,115,66,171,233,228,231,116,146,121,43,84,5,95,246,214,97,253,118,58,161,200,145,193,138,142,1,54,146,89,123,2,27,38,185,151,204,225,89,133,159,80,54,104,34,172,40,10,88,89,95,215,204,236,215,237,62,50,96,171,13,240,142,4,92,43,199,184,3,86,97,14,208,17,139,17,179,241,119,82,112,224,145,124,168,90,22,132,246,186,46,208,221,235,146,132,93,25,177,35,96,84,243,68,78,210,115,143,252,27,148,65,134,210,14,42,131,244,73,226,188,49,168,92,60,200,123,242,88,82,138,52,204,176,26,20,53,242,116,38,84,227,221,123,34,204,214,249,170,136,39,3,208,160,243,70,217,181,51,30,97,9,98,155,106,238,152,20,229,170,232,78,3,188,73,154,225,78,107,9,159,237,165,118,231,73,212,38,105,10,21,230,97,185,22,53,66,95,116,1,177,5,89,74,53,196,243,176,192,234,20,58,74,254,213,241,75,253,35,198,105,156,89,246,240,247,237,193,239,158,73,152,93,8,117,195,164,199,89,14,255,187,55,31,130,162,78,207,203,109,121,53,244,37,50,109,79,201,187,36,139,113,83,142,80,149,201,84,237,190,117,24,61,19,75,114,185,211,38,216,44,218,51,33,90,171,62,53,233,188,149,242,66,230,193,187,163,164,7,103,115,142,14,182,94,74,216,35,51,244,166,140,174,255,157,111,233,26,143,70,145,238,185,19,198,5,79,8,42,74,130,62,146,30,130,222,6,69,127,152,6,141,120,254,156,181,71,224,227,227,67,67,22,61,160,75,151,245,149,218,251,71,207,143,44,255,155,223,169,60,137,165,159,13,33,70,248,60,136,14,246,235,29,18,2,45,163,181,207,24,126,86,150,233,154,75,74,181,104,159,217,227,119,247,14,230,161,208,18,222,44,224,36,212,76,249,200,3,67,210,215,207,25,46,194,198,129,135,95,80,164,120,197,178,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7036e87b-0dda-4a95-ba07-111b121eb842"));
		}

		#endregion

	}

	#endregion

}

