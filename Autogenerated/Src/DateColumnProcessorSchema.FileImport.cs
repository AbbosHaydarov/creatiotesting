namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateColumnProcessorSchema

	/// <exclude/>
	public class DateColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateColumnProcessorSchema(DateColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f8c37261-6156-4687-9016-d3e9e21442ee");
			Name = "DateColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,65,107,219,64,16,133,207,9,228,63,12,238,197,134,34,221,219,216,208,56,164,248,82,2,181,123,41,61,172,87,35,103,64,218,85,103,118,3,166,228,191,119,86,107,183,150,236,4,218,139,173,29,222,188,183,243,105,228,76,139,210,25,139,176,70,102,35,190,14,197,210,187,154,118,145,77,32,239,138,7,106,112,213,118,158,195,205,245,175,155,235,171,40,228,118,240,117,47,1,219,143,127,206,167,221,140,175,213,139,7,99,131,103,66,81,133,106,222,49,238,52,3,150,141,17,249,0,247,38,224,210,55,177,117,143,236,45,138,120,238,101,101,89,194,45,185,39,100,10,149,183,96,25,235,249,36,169,215,212,142,59,38,229,226,216,34,177,109,13,239,143,231,79,14,200,73,48,78,167,245,53,132,39,18,176,41,25,244,129,21,131,119,66,219,6,161,246,12,93,246,75,51,164,32,176,125,10,60,155,38,162,20,199,132,242,36,226,251,61,214,38,54,225,142,92,165,109,211,176,239,208,215,211,213,232,126,179,247,240,69,161,195,28,156,254,169,224,194,212,179,217,15,53,236,226,182,33,123,184,226,5,21,100,98,23,24,104,179,190,42,253,253,75,88,103,11,28,19,125,5,253,216,59,103,197,127,192,61,163,219,23,150,140,218,36,67,198,202,64,149,136,39,182,231,150,9,231,57,207,92,233,12,155,182,71,53,159,68,65,214,65,28,218,180,153,147,197,70,207,250,98,142,133,226,182,236,213,125,243,1,222,133,192,233,102,96,3,67,215,153,82,221,26,193,233,184,156,118,255,234,229,64,21,93,149,193,14,41,107,70,135,28,116,191,149,49,251,160,189,88,189,133,249,78,147,254,1,177,78,99,242,10,102,178,209,209,79,125,166,10,93,160,154,144,95,33,169,203,156,239,2,254,89,63,72,213,195,231,72,85,239,247,45,217,173,213,109,179,170,96,190,24,214,138,196,111,172,202,223,238,24,66,70,51,44,190,252,6,91,5,48,236,95,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f8c37261-6156-4687-9016-d3e9e21442ee"));
		}

		#endregion

	}

	#endregion

}

