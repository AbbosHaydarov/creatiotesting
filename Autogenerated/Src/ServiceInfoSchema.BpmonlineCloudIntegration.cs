namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceInfoSchema

	/// <exclude/>
	public class ServiceInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceInfoSchema(ServiceInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e8ff62d-d15e-4cbb-bf69-9d73591e0c11");
			Name = "ServiceInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,193,110,194,48,12,134,207,32,241,14,86,185,140,75,123,31,131,11,76,211,14,76,104,221,109,218,33,180,78,23,169,77,144,227,78,98,104,239,62,55,13,140,78,92,184,52,246,31,255,246,231,212,170,6,253,94,21,8,111,72,164,188,211,156,174,156,213,166,106,73,177,113,54,93,61,230,27,87,98,237,39,227,227,100,60,106,189,177,21,228,7,207,216,164,175,173,101,211,96,154,35,25,85,155,239,224,152,79,198,82,55,37,172,36,129,85,173,188,191,7,169,248,50,5,62,91,237,194,117,150,101,240,224,219,166,81,116,88,198,124,141,218,88,211,181,0,237,8,138,218,181,37,248,222,120,178,100,23,158,247,181,98,37,176,76,170,224,15,17,246,237,174,54,133,24,101,228,112,226,72,208,229,123,166,218,146,219,35,177,65,65,219,6,87,127,255,31,43,8,79,200,30,4,200,119,39,127,34,88,121,52,112,58,196,145,47,61,187,47,9,123,196,13,54,59,164,187,151,206,181,128,36,58,186,52,153,117,216,39,110,207,20,222,246,239,30,142,80,33,207,187,201,115,248,185,5,81,2,150,102,34,14,49,197,138,8,5,161,94,36,27,101,106,169,137,243,242,232,72,178,229,77,203,68,215,96,147,235,157,101,179,24,92,89,107,138,182,236,127,78,200,123,117,40,138,246,11,17,64,250,219,175,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e8ff62d-d15e-4cbb-bf69-9d73591e0c11"));
		}

		#endregion

	}

	#endregion

}

