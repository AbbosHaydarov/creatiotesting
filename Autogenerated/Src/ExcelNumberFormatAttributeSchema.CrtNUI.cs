﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelNumberFormatAttributeSchema

	/// <exclude/>
	public class ExcelNumberFormatAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelNumberFormatAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelNumberFormatAttributeSchema(ExcelNumberFormatAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5641821c-39ed-4a72-847f-ca3f93100c38");
			Name = "ExcelNumberFormatAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,111,218,64,16,61,27,137,255,48,82,46,70,162,38,105,111,73,93,9,5,80,115,105,169,2,77,165,170,135,197,30,155,149,214,187,206,126,180,208,40,255,189,235,93,236,24,112,32,135,30,48,218,157,143,247,222,204,179,57,41,80,149,36,65,88,160,148,68,137,76,71,183,130,103,52,55,146,104,42,120,52,221,148,66,234,133,152,110,18,100,253,222,83,191,215,239,5,70,81,158,195,253,86,105,44,110,154,243,68,36,166,64,174,103,66,22,68,71,95,75,228,63,10,118,46,30,221,151,18,73,170,214,136,218,230,218,236,11,137,185,133,134,91,70,148,186,6,135,252,197,20,43,148,190,114,172,181,164,43,163,209,101,143,70,35,248,168,76,81,16,185,253,180,59,55,25,144,9,9,41,38,162,82,99,41,96,213,11,236,143,85,17,219,11,144,155,2,50,138,44,141,234,102,163,86,183,159,77,171,165,34,57,134,205,113,65,100,142,90,69,179,170,116,240,203,166,150,102,197,104,2,73,197,250,4,105,184,126,161,103,171,252,64,27,205,115,41,74,148,154,162,21,62,119,13,125,252,80,165,187,112,32,192,29,74,173,135,58,29,199,66,106,122,203,59,174,63,188,135,54,53,120,2,43,229,6,158,207,66,101,140,228,67,80,107,97,88,10,70,225,14,219,67,211,244,36,240,74,8,6,227,178,100,219,255,132,221,218,229,111,194,12,194,163,17,118,188,214,77,25,221,156,167,242,173,202,158,187,228,183,147,72,4,51,5,135,63,52,213,235,211,115,158,8,251,143,223,29,177,135,42,253,237,32,94,205,90,72,250,87,112,77,24,16,70,115,94,189,57,167,33,63,55,21,227,186,192,225,171,174,200,1,157,11,228,169,183,224,190,31,237,199,64,105,105,18,45,228,129,35,119,160,175,27,61,116,99,38,135,27,31,66,85,29,4,59,35,242,182,25,98,184,92,214,241,212,13,208,143,218,6,174,46,39,67,31,160,150,252,186,67,80,12,239,174,234,98,7,253,216,218,112,12,25,97,10,7,96,223,55,27,223,179,96,188,71,162,250,94,5,193,177,81,227,99,41,62,213,111,55,110,111,60,154,73,81,248,115,232,4,12,124,106,219,115,113,155,159,15,211,12,194,169,229,18,221,169,137,189,229,152,134,122,91,162,200,194,87,87,59,24,118,205,98,80,235,12,186,54,31,195,137,126,29,221,60,57,107,20,247,232,112,139,191,221,191,124,254,7,189,207,222,174,91,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5641821c-39ed-4a72-847f-ca3f93100c38"));
		}

		#endregion

	}

	#endregion

}

