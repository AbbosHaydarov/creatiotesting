namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorCompatibilitySchema

	/// <exclude/>
	public class CalendarRemindCalculatorCompatibilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorCompatibilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorCompatibilitySchema(CalendarRemindCalculatorCompatibilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("345ec660-a348-4d2f-9454-ef31b83affd2");
			Name = "CalendarRemindCalculatorCompatibility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ccef5f7c-bb3c-488e-aeef-d23f70e5d985");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,83,77,111,194,48,12,61,23,105,255,193,98,23,144,16,135,29,153,216,5,33,196,97,211,52,182,93,166,29,178,212,116,145,218,180,114,18,16,98,253,239,115,250,193,218,162,78,208,3,197,78,252,222,179,253,10,90,36,104,50,33,17,94,145,72,152,116,107,167,139,84,111,85,228,72,88,149,234,155,1,28,111,6,129,51,74,71,176,57,24,139,201,253,41,110,214,16,114,158,79,50,247,21,43,9,50,22,198,192,66,196,168,67,65,47,152,40,29,114,36,93,44,108,74,179,222,147,247,59,198,240,140,193,45,97,196,2,128,229,24,75,78,242,161,153,193,51,165,22,165,197,176,32,11,178,58,236,5,28,189,25,36,198,208,124,205,195,185,86,56,134,25,124,9,131,163,110,250,152,151,4,183,12,90,10,169,226,74,21,235,200,144,172,194,66,147,218,9,139,181,162,34,128,14,109,39,60,130,191,27,68,104,253,52,131,192,84,127,174,98,237,157,132,193,242,167,98,169,37,49,27,204,31,138,163,165,182,202,30,64,248,21,25,60,105,232,28,207,97,39,98,135,151,40,123,68,251,157,134,109,89,65,208,22,102,44,91,74,150,210,88,203,31,209,255,59,154,192,202,169,16,36,95,95,135,19,70,33,246,222,199,39,200,52,118,137,54,79,108,97,222,87,209,2,161,117,164,97,213,2,239,162,213,64,173,250,230,36,242,90,122,179,217,42,115,214,110,97,247,106,5,165,245,171,54,53,238,123,77,9,11,66,222,200,154,157,45,180,196,43,250,175,59,221,9,42,50,167,77,69,23,245,172,113,207,147,59,194,112,131,180,83,18,215,252,61,175,195,225,4,134,108,226,148,184,148,35,200,199,165,35,212,118,212,228,152,131,118,113,12,63,63,13,230,233,95,157,191,224,149,78,151,73,102,15,181,208,122,39,190,180,68,45,198,123,74,255,51,165,243,143,178,244,206,188,217,121,222,231,78,159,3,255,240,43,255,5,8,139,162,172,233,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("345ec660-a348-4d2f-9454-ef31b83affd2"));
		}

		#endregion

	}

	#endregion

}

