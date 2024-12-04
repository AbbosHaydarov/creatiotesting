namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkplaceContentChangedNotifierSchema

	/// <exclude/>
	public class WorkplaceContentChangedNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkplaceContentChangedNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkplaceContentChangedNotifierSchema(WorkplaceContentChangedNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e1eb09a-725e-40f7-b51f-b222d3dfeaee");
			Name = "WorkplaceContentChangedNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9229ed18-5614-47df-8744-72b0c7198840");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,205,106,220,48,16,62,59,144,119,24,182,23,47,4,251,158,38,11,173,211,132,61,100,19,72,74,15,33,4,213,30,123,69,100,201,140,164,45,38,236,187,119,108,121,55,46,41,118,123,49,104,70,154,239,103,102,12,160,69,141,182,17,57,194,35,18,9,107,74,151,100,70,151,178,242,36,156,52,250,244,228,237,244,36,242,86,234,10,30,90,235,176,254,124,60,103,134,48,185,22,185,51,36,209,190,199,199,165,234,218,232,191,101,110,209,90,81,113,236,253,14,223,74,211,20,46,172,175,107,65,237,106,56,175,235,70,97,141,218,89,78,33,66,78,88,94,46,214,63,12,189,54,138,153,51,93,199,217,108,43,116,133,197,198,56,89,74,164,69,186,74,14,5,211,81,197,167,43,44,133,87,238,171,212,5,163,199,174,109,208,148,241,92,185,229,25,108,216,42,184,132,197,28,240,242,153,97,26,255,83,201,28,114,37,172,133,153,23,112,14,115,240,92,145,219,192,223,232,19,97,197,109,129,107,137,170,176,231,112,79,114,39,28,134,100,19,14,64,40,10,163,85,11,235,7,164,29,82,166,36,215,188,107,48,244,244,8,252,98,167,210,93,219,162,30,19,117,17,96,255,228,192,92,173,35,223,245,159,137,244,138,7,30,65,253,140,168,120,9,221,108,69,209,52,13,246,60,235,108,12,131,214,38,55,232,46,166,117,173,226,101,207,125,255,95,108,102,188,154,228,248,207,74,230,13,223,207,185,126,139,110,107,250,214,143,28,239,231,92,234,45,146,116,133,201,33,93,141,148,239,140,44,160,7,105,227,27,47,139,167,103,240,76,100,93,216,3,239,225,152,100,91,204,95,191,80,229,187,125,219,120,165,238,232,91,221,184,54,238,254,19,188,38,135,103,193,223,104,39,8,248,255,193,139,220,109,134,198,95,48,246,48,200,202,123,137,87,194,137,1,43,58,234,126,228,221,155,216,168,197,89,184,255,61,128,242,205,1,190,15,239,3,133,105,199,147,65,245,64,242,56,22,31,29,238,162,156,248,13,193,94,214,232,18,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e1eb09a-725e-40f7-b51f-b222d3dfeaee"));
		}

		#endregion

	}

	#endregion

}

