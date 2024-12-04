namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CompilationHistoryEventListenerSchema

	/// <exclude/>
	public class CompilationHistoryEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CompilationHistoryEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CompilationHistoryEventListenerSchema(CompilationHistoryEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("043de0df-b9d3-4d42-8dee-a5975e1a3279");
			Name = "CompilationHistoryEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,82,205,75,195,48,20,63,119,176,255,225,49,47,43,72,123,159,31,224,230,192,129,58,113,243,36,30,178,246,173,141,180,73,73,178,206,33,251,223,125,73,170,88,221,24,30,132,93,74,154,247,203,239,139,7,130,149,168,43,150,32,204,81,41,166,229,210,68,35,41,150,60,91,41,102,184,20,221,206,123,183,19,172,52,23,89,11,82,150,82,156,237,156,40,140,198,194,112,195,81,31,4,68,227,26,133,177,56,66,158,40,204,72,17,70,5,211,122,0,164,81,241,194,153,184,225,218,72,181,113,224,91,58,163,64,229,158,60,59,162,246,160,63,75,114,44,217,61,37,131,11,232,253,166,233,133,47,244,180,90,45,10,158,64,98,197,14,105,193,0,134,76,227,14,49,34,162,126,232,251,229,254,14,77,46,83,242,255,160,120,205,12,250,105,229,127,64,27,18,73,160,150,60,133,121,174,228,250,17,89,42,69,177,25,191,37,88,89,253,190,92,188,98,98,64,163,72,81,133,96,235,15,130,154,41,208,46,215,136,57,24,69,235,247,189,161,176,129,70,62,120,212,32,108,249,65,96,172,8,8,92,195,212,241,78,180,85,156,238,80,180,133,13,218,34,161,227,216,54,1,73,197,103,220,23,216,53,234,135,113,28,195,57,23,57,42,110,82,153,64,124,233,90,240,157,203,154,182,129,167,232,107,152,138,107,44,208,208,150,180,163,159,130,143,55,196,37,173,140,107,253,74,101,26,240,179,147,61,253,53,109,124,183,254,39,55,19,161,81,29,143,157,167,42,101,199,227,102,198,234,255,244,242,99,199,252,109,251,114,251,1,134,49,135,215,180,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("043de0df-b9d3-4d42-8dee-a5975e1a3279"));
		}

		#endregion

	}

	#endregion

}

