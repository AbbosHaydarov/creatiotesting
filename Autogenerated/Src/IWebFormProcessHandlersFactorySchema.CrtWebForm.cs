namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormProcessHandlersFactorySchema

	/// <exclude/>
	public class IWebFormProcessHandlersFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormProcessHandlersFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormProcessHandlersFactorySchema(IWebFormProcessHandlersFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30248ea6-6ed0-4ae8-b005-c4b54f120925");
			Name = "IWebFormProcessHandlersFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,83,193,106,195,48,12,61,183,176,127,16,237,101,131,145,220,219,44,151,177,118,57,12,10,235,216,217,141,149,212,16,219,65,182,25,97,236,223,103,59,109,218,46,131,13,118,219,205,122,146,158,158,158,109,197,36,154,150,149,8,91,36,98,70,87,54,185,215,170,18,181,35,102,133,86,87,211,247,171,233,196,25,161,106,120,238,140,69,185,252,18,251,250,166,193,50,20,155,100,141,10,73,148,167,154,115,90,66,143,251,204,156,176,246,213,80,40,139,84,249,225,11,40,94,113,183,210,36,55,164,75,52,230,145,41,222,32,153,21,43,173,166,46,118,165,105,10,153,113,82,50,234,242,67,124,200,67,165,9,106,180,54,76,108,123,10,216,31,56,128,99,139,138,135,148,159,217,120,52,86,177,26,1,149,21,182,75,142,228,233,25,123,235,118,141,40,65,28,37,254,168,112,18,124,26,86,123,66,187,215,220,44,96,19,121,226,2,163,13,34,176,70,107,192,238,209,235,198,145,246,32,109,172,173,71,90,70,76,130,242,23,120,55,115,6,201,95,155,234,175,97,150,111,61,95,192,160,28,192,36,75,99,199,247,4,111,253,114,5,239,123,125,24,60,149,32,120,240,168,18,72,227,126,66,235,72,153,60,75,143,167,144,42,30,148,147,72,108,215,96,86,196,231,192,44,242,193,60,188,244,47,15,251,143,80,115,253,114,177,80,220,229,20,222,134,57,147,181,19,28,6,221,55,203,95,121,172,141,253,255,38,107,227,45,29,187,60,130,255,96,243,220,255,168,254,169,199,248,163,255,215,23,160,199,62,1,178,190,216,134,94,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30248ea6-6ed0-4ae8-b005-c4b54f120925"));
		}

		#endregion

	}

	#endregion

}

