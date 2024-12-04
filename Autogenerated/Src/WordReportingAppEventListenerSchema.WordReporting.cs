namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WordReportingAppEventListenerSchema

	/// <exclude/>
	public class WordReportingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WordReportingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WordReportingAppEventListenerSchema(WordReportingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c074c284-2329-406d-b902-b8e6677ad447");
			Name = "WordReportingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,201,78,195,48,16,61,167,82,255,193,82,47,201,37,31,80,74,37,90,22,33,129,168,88,212,179,147,76,131,69,51,182,198,78,0,33,254,157,113,77,23,87,105,47,118,230,205,155,229,61,7,101,3,214,200,18,196,43,16,73,171,87,46,159,107,92,169,186,37,233,148,198,252,25,140,38,167,176,206,151,154,170,93,52,28,252,12,7,73,107,249,51,42,109,26,141,23,189,153,211,77,253,241,1,212,95,70,112,10,207,111,101,233,52,41,176,125,140,37,20,251,117,56,63,34,168,121,180,152,175,165,181,99,17,137,185,50,230,166,3,116,15,202,58,64,160,77,129,105,139,181,42,69,233,249,231,233,98,44,142,161,153,180,192,61,216,35,62,119,179,23,164,13,112,11,224,5,22,164,58,233,32,16,76,8,196,155,5,98,167,16,74,111,211,113,120,57,13,219,7,221,223,249,29,184,73,76,153,166,89,80,155,140,0,171,48,245,104,133,214,171,26,139,71,112,239,186,178,255,227,55,160,208,29,187,167,42,16,157,86,149,120,66,22,245,226,36,185,116,171,142,7,57,248,114,162,12,119,38,252,63,144,36,5,139,205,15,232,219,180,127,150,36,137,86,158,41,172,38,247,123,55,175,193,170,26,195,251,79,211,52,243,26,17,62,99,191,15,73,105,44,56,11,67,126,123,69,7,52,6,25,251,3,69,124,60,113,244,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c074c284-2329-406d-b902-b8e6677ad447"));
		}

		#endregion

	}

	#endregion

}

