namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SecureTextColumnProcessorSchema

	/// <exclude/>
	public class SecureTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SecureTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SecureTextColumnProcessorSchema(SecureTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("327ab3d6-e22f-4c90-99c4-1e825c0a5c40");
			Name = "SecureTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,197,190,183,77,96,155,210,18,88,150,66,147,94,202,30,20,121,156,10,236,145,119,70,42,27,74,255,251,142,173,100,91,167,245,66,47,182,52,60,189,167,249,36,145,169,81,26,99,17,86,200,108,196,151,33,91,120,42,221,54,178,9,206,83,118,227,42,92,214,141,231,112,122,242,114,122,50,138,226,104,11,247,59,9,88,95,252,155,191,95,205,56,84,207,110,140,13,158,29,138,42,84,243,141,113,171,25,176,168,140,200,57,220,163,141,140,43,252,19,22,190,138,53,221,177,183,40,226,185,19,231,121,14,151,142,158,144,93,40,188,5,203,88,206,198,159,168,199,249,252,32,151,88,215,134,119,135,249,119,2,71,18,12,105,191,190,132,240,228,4,108,155,13,58,96,5,225,73,220,166,66,40,61,67,147,252,218,46,126,120,218,182,65,96,187,36,120,54,85,68,201,14,41,249,187,152,199,107,44,77,172,194,149,163,66,151,78,194,174,65,95,78,150,71,123,156,158,193,79,69,15,51,32,253,169,96,176,247,233,244,151,218,54,113,83,57,187,223,236,160,22,206,225,83,122,35,61,56,253,190,241,214,62,3,199,246,44,20,251,93,231,157,20,95,132,252,129,114,87,88,48,154,128,210,103,173,28,84,137,184,183,28,236,65,141,91,176,31,201,166,74,99,216,212,29,180,217,56,10,178,182,66,104,219,155,58,158,175,117,174,71,116,40,100,151,121,167,238,22,239,1,14,198,78,214,61,51,232,123,79,149,236,198,8,78,142,203,237,139,24,189,238,233,34,21,9,112,159,182,102,52,200,65,111,189,178,102,31,116,45,22,255,195,125,165,73,95,192,125,109,130,73,87,50,81,142,228,126,235,216,21,72,193,149,14,121,128,167,94,240,180,23,240,207,250,76,85,15,183,209,21,157,223,67,107,183,82,183,245,178,128,217,188,95,203,222,40,30,107,211,187,62,70,145,0,245,139,175,127,1,184,92,121,190,123,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("327ab3d6-e22f-4c90-99c4-1e825c0a5c40"));
		}

		#endregion

	}

	#endregion

}

