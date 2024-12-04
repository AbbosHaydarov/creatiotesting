namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationSearchQueryBuilderSchema

	/// <exclude/>
	public class IDeduplicationSearchQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationSearchQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationSearchQueryBuilderSchema(IDeduplicationSearchQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d41dcdd7-e798-4db1-b723-80024a0e025a");
			Name = "IDeduplicationSearchQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,203,110,194,48,16,60,39,82,254,97,5,151,86,170,146,59,165,57,180,180,21,135,170,15,248,1,147,108,192,82,236,164,187,246,1,85,252,123,29,155,32,183,112,224,18,101,199,51,179,179,107,107,161,144,123,81,33,172,145,72,112,215,152,252,169,211,141,220,90,18,70,118,58,95,96,109,251,86,86,190,202,210,159,44,77,44,75,189,133,213,158,13,42,199,110,91,172,134,67,206,95,81,35,201,234,62,75,29,107,74,184,117,40,44,181,65,106,92,139,25,44,255,152,173,80,80,181,251,180,72,251,71,43,219,26,201,235,138,162,128,57,91,165,4,237,203,99,29,168,240,61,112,97,19,200,208,116,4,117,108,8,132,142,193,38,31,93,138,200,166,183,27,199,3,57,166,185,34,76,226,134,117,223,211,36,111,104,118,93,205,51,248,240,94,225,240,127,92,15,120,11,6,142,99,55,212,41,24,59,34,3,217,22,121,136,122,158,53,32,189,32,161,64,187,27,122,152,120,242,164,92,140,242,163,122,94,120,210,101,77,35,117,125,18,240,87,216,205,164,60,254,156,107,9,141,37,205,101,188,108,199,26,225,129,23,109,41,204,24,1,55,203,103,109,21,146,216,180,56,143,250,186,160,139,245,123,25,18,223,13,46,73,242,114,41,26,92,12,124,27,94,83,50,69,93,135,123,112,213,33,188,176,8,202,210,195,47,82,38,233,190,204,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d41dcdd7-e798-4db1-b723-80024a0e025a"));
		}

		#endregion

	}

	#endregion

}

