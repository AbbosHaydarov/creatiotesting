namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddSenderDomainsInfoRequestSchema

	/// <exclude/>
	public class AddSenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddSenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddSenderDomainsInfoRequestSchema(AddSenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cef863d-9684-4a82-a74b-e9746da57616");
			Name = "AddSenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,77,79,195,48,12,134,207,84,234,127,176,186,11,92,218,251,62,144,96,67,136,195,208,180,238,134,56,120,173,91,34,181,73,137,211,161,49,237,191,147,38,108,192,54,13,237,148,218,125,253,198,143,29,137,53,113,131,25,193,130,180,70,86,133,137,199,74,22,162,108,53,26,161,100,60,126,72,167,42,167,138,195,96,19,6,97,112,213,178,144,37,164,107,54,84,199,243,86,26,81,83,156,146,22,88,137,79,87,51,112,186,158,166,210,6,48,174,144,185,15,119,121,158,146,204,73,79,84,141,66,242,147,44,212,156,222,91,98,227,228,73,146,192,144,219,186,70,189,190,253,142,93,41,20,74,131,246,74,48,10,48,207,65,210,7,176,115,131,220,217,197,59,135,228,192,98,200,68,88,177,130,76,83,49,138,238,145,201,246,186,18,25,125,95,30,65,210,105,95,38,104,208,146,27,141,153,121,181,137,166,93,86,34,131,204,181,112,166,121,232,195,177,169,173,247,195,218,79,97,166,85,67,218,8,178,163,152,57,107,255,255,16,219,37,30,201,48,88,106,238,78,243,70,191,32,143,41,125,102,133,85,75,251,112,113,170,230,71,226,96,167,84,47,73,95,63,219,23,0,35,136,188,60,186,233,216,119,240,108,116,183,107,15,13,27,40,201,12,186,166,6,176,189,164,123,137,246,10,85,184,239,70,171,149,176,131,188,140,229,31,135,243,100,187,130,46,62,201,103,119,179,23,156,162,236,217,213,251,53,186,216,103,255,38,183,97,240,5,154,99,32,102,75,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cef863d-9684-4a82-a74b-e9746da57616"));
		}

		#endregion

	}

	#endregion

}

