namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IReportGeneratorSchema

	/// <exclude/>
	public class IReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IReportGeneratorSchema(IReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f7efd48-adaa-42e5-b285-f3efa252f7e7");
			Name = "IReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,107,195,48,12,61,183,208,255,32,210,203,6,35,190,119,89,46,27,140,30,6,165,219,126,128,231,40,169,161,177,131,108,23,202,216,127,159,63,154,172,73,179,139,141,158,245,164,167,103,41,222,162,233,184,64,248,64,34,110,116,109,243,103,173,106,217,56,226,86,106,181,90,126,175,150,11,103,164,106,254,75,201,247,216,105,178,239,72,39,41,240,113,54,157,2,238,95,214,132,141,167,192,86,89,164,218,247,221,192,54,209,95,81,161,175,167,41,230,49,198,160,48,174,109,57,157,203,75,188,35,125,146,21,26,160,72,128,38,49,66,171,218,41,17,164,240,163,180,231,188,231,179,171,2,157,251,58,74,1,178,239,59,211,118,225,39,245,231,160,241,13,237,65,87,102,3,187,200,77,143,83,97,17,184,20,25,164,5,5,183,18,18,210,113,226,45,40,239,251,83,230,12,146,183,82,97,20,159,149,159,62,6,49,0,121,193,98,246,60,89,92,255,65,86,14,238,140,112,168,53,77,252,210,116,91,151,208,58,82,166,220,167,27,58,79,225,132,85,63,79,193,250,140,64,73,206,189,112,203,135,201,239,130,244,191,81,96,60,217,3,76,204,30,237,207,88,241,125,90,148,197,26,85,149,62,34,198,63,105,125,70,160,199,126,1,236,248,221,151,192,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f7efd48-adaa-42e5-b285-f3efa252f7e7"));
		}

		#endregion

	}

	#endregion

}

