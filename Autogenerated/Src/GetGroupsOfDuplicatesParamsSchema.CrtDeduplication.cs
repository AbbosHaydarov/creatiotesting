namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetGroupsOfDuplicatesParamsSchema

	/// <exclude/>
	public class GetGroupsOfDuplicatesParamsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetGroupsOfDuplicatesParamsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetGroupsOfDuplicatesParamsSchema(GetGroupsOfDuplicatesParamsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7f703a5-c87f-41f4-8e13-77635795a696");
			Name = "GetGroupsOfDuplicatesParams";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,61,111,194,48,16,134,103,144,248,15,39,88,218,37,217,75,219,37,180,76,45,168,176,33,6,19,206,145,165,216,142,206,231,129,34,254,123,109,7,42,80,83,20,201,178,116,119,175,159,251,178,17,26,93,35,74,132,53,18,9,103,37,103,133,53,82,85,158,4,43,107,178,25,238,125,83,171,50,89,163,225,113,52,28,120,167,76,5,171,131,99,212,217,151,55,172,52,102,43,36,37,106,245,157,116,211,209,48,232,38,132,85,48,160,168,133,115,79,48,71,158,147,245,141,91,200,217,25,137,110,41,72,104,151,228,225,228,121,14,207,206,107,45,232,240,122,182,147,2,25,201,129,182,123,172,65,90,186,199,202,46,156,252,10,180,153,9,22,161,49,38,81,242,54,56,26,191,11,175,160,140,165,221,175,108,16,90,14,247,111,55,75,178,13,18,43,12,45,45,19,165,141,167,20,31,168,119,72,15,159,161,98,120,129,49,134,217,240,33,90,227,199,152,245,146,214,49,197,17,190,253,134,225,8,21,242,20,92,188,78,255,3,75,91,123,109,92,23,109,179,133,162,141,246,133,89,41,131,228,150,165,12,195,34,249,251,151,228,77,7,164,136,238,190,12,182,205,213,224,145,210,54,254,50,215,93,178,190,57,164,170,227,39,234,92,196,123,27,235,66,77,208,236,219,205,39,187,245,222,58,79,63,163,135,107,91,70,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7f703a5-c87f-41f4-8e13-77635795a696"));
		}

		#endregion

	}

	#endregion

}

