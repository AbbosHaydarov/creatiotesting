namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoAppEventListenerSchema

	/// <exclude/>
	public class SsoAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoAppEventListenerSchema(SsoAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aebf3d9a-9819-4190-84a0-91aa0f7bd750");
			Name = "SsoAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,82,193,110,219,48,12,61,187,64,255,129,200,46,41,48,216,247,46,13,176,6,219,128,97,91,7,184,69,207,138,76,167,66,109,209,32,169,108,197,208,127,31,37,39,197,154,245,66,65,164,222,227,35,159,162,27,81,38,231,17,110,145,217,9,245,90,111,40,246,97,151,216,105,160,120,126,246,231,252,172,74,18,226,238,213,19,198,15,111,228,239,113,107,181,113,164,104,85,171,191,99,220,25,9,108,6,39,114,9,173,208,199,105,250,180,199,168,223,130,40,70,228,242,172,105,26,88,73,26,71,199,79,235,195,189,64,96,98,218,135,14,5,12,194,79,48,81,136,10,61,49,180,237,13,56,159,21,10,88,131,36,200,32,40,146,187,137,58,214,250,200,219,252,67,60,165,237,16,60,248,194,253,134,26,184,132,211,212,181,19,52,164,109,193,226,203,64,223,81,31,168,179,145,126,22,198,185,120,58,70,73,180,89,140,64,154,58,167,8,34,4,158,162,154,116,80,39,143,89,229,255,50,231,204,228,216,141,16,205,161,171,69,198,224,111,93,172,87,130,8,158,177,191,90,28,149,110,14,181,102,13,33,218,236,209,99,189,106,10,186,144,29,134,166,189,217,100,187,132,61,133,14,110,98,59,111,171,232,91,158,112,21,141,118,94,64,118,191,170,66,15,203,47,3,109,221,96,15,91,84,53,219,165,254,140,78,19,163,237,241,107,208,251,96,27,73,218,250,7,236,210,128,124,132,86,249,175,212,183,54,171,148,88,151,134,63,240,87,6,220,153,109,214,50,98,113,114,117,87,150,100,124,89,134,173,232,218,249,199,29,83,138,93,70,190,135,45,209,176,94,42,39,188,200,191,175,170,158,115,180,80,172,193,216,205,238,148,251,156,125,157,124,254,11,130,218,73,143,239,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aebf3d9a-9819-4190-84a0-91aa0f7bd750"));
		}

		#endregion

	}

	#endregion

}

