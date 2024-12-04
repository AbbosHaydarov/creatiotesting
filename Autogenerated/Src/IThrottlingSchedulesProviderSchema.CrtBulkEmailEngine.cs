namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IThrottlingSchedulesProviderSchema

	/// <exclude/>
	public class IThrottlingSchedulesProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IThrottlingSchedulesProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IThrottlingSchedulesProviderSchema(IThrottlingSchedulesProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9ef08c3-4687-47dc-a929-945b22c2edc9");
			Name = "IThrottlingSchedulesProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,207,110,194,48,12,198,207,32,241,14,22,92,182,75,123,103,140,11,154,38,14,147,16,240,2,161,117,219,72,109,194,108,135,169,154,246,238,51,45,133,241,111,211,46,85,98,187,63,251,251,98,103,42,228,173,73,16,214,72,100,216,103,18,205,188,203,108,30,200,136,245,110,208,255,28,244,123,129,173,203,239,149,68,179,151,213,82,41,222,49,242,211,160,175,245,35,194,92,51,48,119,130,148,41,126,12,243,117,65,94,164,84,208,42,41,48,13,37,242,130,252,206,166,72,205,63,113,28,195,132,67,85,25,170,167,135,251,161,128,33,11,46,217,247,50,165,149,26,196,67,142,2,114,36,2,119,72,200,60,65,18,136,208,9,4,70,138,58,116,252,131,189,13,155,210,38,96,187,241,254,152,174,167,30,232,247,40,235,13,165,240,41,143,97,209,112,218,228,229,252,77,224,21,133,239,207,41,5,158,205,10,155,186,137,17,190,7,75,152,2,139,90,140,121,189,23,113,173,162,141,108,13,153,10,156,62,228,243,80,93,185,22,178,84,26,178,12,167,135,131,202,102,49,78,85,127,88,41,46,26,34,237,172,102,108,26,77,226,134,124,106,68,40,129,28,79,79,29,254,41,98,18,119,136,61,83,173,185,97,122,183,72,123,231,110,164,31,110,134,59,97,191,201,127,108,55,179,55,66,151,182,207,216,220,191,218,125,61,11,106,236,27,254,7,229,75,24,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9ef08c3-4687-47dc-a929-945b22c2edc9"));
		}

		#endregion

	}

	#endregion

}

