namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StatisticEventTypeSchema

	/// <exclude/>
	public class StatisticEventTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StatisticEventTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StatisticEventTypeSchema(StatisticEventTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f9f834a-d6b3-457b-ba8a-e93406998209");
			Name = "StatisticEventType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,203,74,196,48,20,134,215,45,244,29,194,184,81,144,41,94,23,234,184,209,130,27,55,206,184,18,145,182,115,166,6,155,11,185,8,69,124,119,79,210,105,157,210,82,102,186,76,250,253,255,249,66,19,158,50,208,50,205,129,172,64,169,84,139,141,153,63,8,190,161,133,85,169,161,130,71,225,79,20,6,86,83,94,144,101,165,13,48,252,206,164,224,192,205,179,88,67,121,27,133,8,28,41,40,144,38,9,183,236,134,44,13,102,181,161,121,242,141,216,170,146,224,161,56,142,201,157,182,140,165,170,186,223,174,91,148,24,196,244,188,193,226,29,78,218,172,68,0,176,123,176,58,112,138,189,118,191,145,176,148,150,68,55,33,87,223,239,15,222,30,65,231,138,74,119,224,227,25,184,204,71,155,209,179,147,119,7,249,170,118,188,38,11,114,118,234,143,53,60,249,5,114,42,41,58,30,56,93,53,185,190,65,91,217,177,56,223,207,226,83,88,85,86,147,101,234,248,136,211,147,7,58,102,23,123,154,225,79,84,37,229,95,211,229,154,134,49,191,134,233,40,94,142,41,214,151,103,170,94,125,141,70,212,124,253,176,214,213,152,214,43,215,54,115,131,50,56,80,201,254,39,183,14,187,93,11,114,141,91,191,245,123,6,190,174,159,180,91,226,222,31,21,83,160,185,41,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f9f834a-d6b3-457b-ba8a-e93406998209"));
		}

		#endregion

	}

	#endregion

}

