namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISearchColumnNameProviderSchema

	/// <exclude/>
	public class ISearchColumnNameProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISearchColumnNameProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISearchColumnNameProviderSchema(ISearchColumnNameProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90958362-e618-422a-ad51-19a35fdf8930");
			Name = "ISearchColumnNameProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,177,142,194,48,12,134,231,86,234,59,88,176,192,210,236,80,186,48,32,134,59,161,227,94,32,180,110,137,68,146,202,73,144,208,137,119,191,146,180,40,189,67,140,249,237,223,255,231,24,20,151,104,58,94,33,124,35,17,55,186,177,249,86,171,70,180,142,184,21,90,101,41,252,100,105,150,38,115,194,182,127,195,94,89,164,166,119,172,96,127,68,78,213,121,171,47,78,170,207,126,210,129,244,85,212,72,222,0,140,49,40,140,147,146,211,173,28,133,96,129,202,123,192,88,77,66,181,240,192,128,110,112,231,79,51,139,221,157,59,93,68,5,98,204,127,23,159,12,208,79,234,15,180,103,93,27,88,193,193,143,9,213,127,136,137,87,190,208,58,82,230,21,228,131,45,52,77,224,6,169,227,196,165,239,219,204,76,4,55,43,39,107,231,5,243,157,145,147,66,100,121,140,179,10,54,202,190,209,88,95,218,161,253,187,248,34,22,32,78,94,174,135,77,231,168,234,240,23,225,56,247,112,212,137,122,255,5,244,102,181,136,15,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90958362-e618-422a-ad51-19a35fdf8930"));
		}

		#endregion

	}

	#endregion

}

