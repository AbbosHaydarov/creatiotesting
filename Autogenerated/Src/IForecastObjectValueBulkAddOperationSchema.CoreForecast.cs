namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueBulkAddOperationSchema

	/// <exclude/>
	public class IForecastObjectValueBulkAddOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueBulkAddOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueBulkAddOperationSchema(IForecastObjectValueBulkAddOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("949d29b4-32dc-fbc9-0241-7774107a898a");
			Name = "IForecastObjectValueBulkAddOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,77,107,131,64,16,134,207,10,249,15,131,189,180,80,20,122,108,83,161,223,120,10,52,37,247,137,59,154,109,117,87,246,35,32,165,255,189,179,126,132,64,114,40,189,136,251,250,206,51,239,142,163,176,37,219,97,73,240,65,198,160,213,149,75,159,180,170,100,237,13,58,169,85,250,170,13,149,104,221,230,102,17,127,47,226,200,91,169,106,88,247,214,81,203,214,166,161,50,248,108,250,70,138,140,44,239,22,49,187,46,12,213,172,66,161,28,153,138,249,183,80,204,164,213,246,147,107,54,216,120,122,244,205,215,131,16,171,142,198,110,67,109,150,101,176,180,190,109,209,244,249,116,62,112,160,210,6,80,136,16,130,113,218,8,11,78,7,117,96,195,78,90,167,77,15,122,104,2,251,208,101,50,166,51,59,59,130,119,126,219,200,18,228,129,255,183,152,17,143,130,159,39,89,7,129,173,255,201,22,157,132,27,149,14,13,182,160,248,79,221,39,86,97,103,119,218,37,249,28,19,102,105,153,13,198,243,117,83,156,36,127,31,95,142,205,123,45,69,200,60,125,186,156,201,235,9,252,140,14,15,93,174,161,120,81,190,229,65,108,27,90,30,205,104,172,206,231,139,95,241,30,68,63,227,46,144,18,227,58,132,35,107,191,5,241,27,223,117,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("949d29b4-32dc-fbc9-0241-7774107a898a"));
		}

		#endregion

	}

	#endregion

}

