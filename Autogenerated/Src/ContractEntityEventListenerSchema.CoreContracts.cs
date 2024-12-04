namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContractEntityEventListenerSchema

	/// <exclude/>
	public class ContractEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContractEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContractEntityEventListenerSchema(ContractEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dc1c550-b00c-4bed-b991-26641e373489");
			Name = "ContractEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,83,193,110,219,48,12,61,187,64,255,129,112,47,14,16,56,247,46,45,176,6,65,81,96,107,11,52,219,101,216,65,177,153,68,155,45,121,164,236,33,24,246,239,163,45,57,139,211,58,61,74,34,31,31,223,123,50,170,68,174,84,134,176,66,34,197,118,227,210,133,53,27,189,173,73,57,109,205,229,197,159,203,139,168,102,109,182,131,18,194,116,105,156,118,26,249,195,123,5,233,178,65,227,198,235,158,201,102,200,60,28,44,213,82,127,69,184,149,3,44,10,197,124,13,82,225,72,101,174,67,222,119,176,159,52,59,52,72,93,249,108,54,131,57,215,101,169,104,127,27,206,93,43,84,100,27,157,35,67,22,32,0,3,59,192,142,29,236,148,201,11,97,151,246,56,179,19,160,57,35,170,130,45,100,132,155,155,248,252,178,233,157,98,124,131,102,12,179,22,239,219,27,79,201,75,182,195,82,61,138,37,112,3,113,191,107,60,249,46,13,85,189,46,116,6,89,183,204,25,25,224,26,70,38,131,24,41,64,7,73,63,163,219,217,92,68,125,38,221,40,135,254,181,242,7,176,235,31,40,34,221,183,157,114,126,193,95,53,26,198,199,186,92,11,83,15,239,37,220,79,90,228,40,138,26,69,176,69,106,235,45,201,6,6,127,143,244,127,97,164,149,226,159,137,7,72,219,179,236,100,100,162,48,155,180,65,137,34,66,87,147,249,143,152,142,112,9,24,94,188,41,156,129,252,59,92,113,109,109,1,15,236,97,150,101,229,246,227,123,17,114,93,56,89,42,192,223,163,91,237,43,204,23,182,168,75,243,85,21,53,206,217,145,196,231,54,137,61,98,60,220,195,191,166,237,188,162,120,10,243,60,236,128,221,21,154,220,59,52,102,87,151,4,255,120,154,247,67,78,67,70,71,162,144,62,153,7,17,144,156,48,138,187,60,190,78,124,159,56,219,72,206,229,231,64,99,117,14,71,141,73,136,8,11,97,164,41,248,57,119,184,145,223,208,77,251,72,91,249,92,189,138,107,161,114,60,55,233,251,48,232,212,202,236,213,21,153,131,19,19,95,228,11,244,6,146,161,93,193,167,126,68,7,193,131,116,8,212,217,216,132,217,81,31,34,116,71,142,30,156,156,158,160,134,46,113,108,204,54,127,59,188,148,187,127,55,156,54,193,111,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dc1c550-b00c-4bed-b991-26641e373489"));
		}

		#endregion

	}

	#endregion

}

