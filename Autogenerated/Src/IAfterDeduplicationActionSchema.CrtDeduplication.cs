namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAfterDeduplicationActionSchema

	/// <exclude/>
	public class IAfterDeduplicationActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAfterDeduplicationActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAfterDeduplicationActionSchema(IAfterDeduplicationActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aec23552-782f-4407-a3bb-de7bbc336923");
			Name = "IAfterDeduplicationAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b7fcaef-4d0d-4f1c-b466-136a63eb8599");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,207,106,195,48,12,198,207,9,228,29,68,123,217,46,201,189,235,10,165,235,161,135,194,24,123,1,47,86,82,67,252,7,217,46,45,99,239,62,213,94,74,178,193,46,33,250,172,239,199,39,201,8,141,222,137,22,225,29,137,132,183,93,168,119,214,116,170,143,36,130,178,166,126,65,25,221,160,218,84,85,229,103,85,22,209,43,211,207,12,132,245,222,4,21,20,250,167,170,228,150,37,97,207,253,112,48,1,169,99,254,10,14,219,142,255,103,184,109,155,161,108,104,154,6,214,62,106,45,232,186,249,169,223,208,17,122,52,193,131,128,147,48,114,64,2,188,96,27,3,74,16,55,28,200,41,15,90,171,221,128,1,235,145,216,76,144,46,126,112,35,168,49,210,127,137,10,158,147,191,247,57,142,24,78,86,250,21,188,38,72,126,252,157,57,9,51,220,61,208,24,255,22,236,111,178,172,56,65,66,131,225,139,60,47,52,82,143,50,237,244,186,216,28,83,5,188,140,56,4,224,133,176,90,175,155,100,72,254,179,85,18,246,121,51,15,217,5,83,196,99,190,74,177,68,35,243,68,169,254,202,183,154,136,172,124,3,105,217,49,148,19,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aec23552-782f-4407-a3bb-de7bbc336923"));
		}

		#endregion

	}

	#endregion

}

