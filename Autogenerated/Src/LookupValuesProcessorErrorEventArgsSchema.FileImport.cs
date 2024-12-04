namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesProcessorErrorEventArgsSchema

	/// <exclude/>
	public class LookupValuesProcessorErrorEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesProcessorErrorEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesProcessorErrorEventArgsSchema(LookupValuesProcessorErrorEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dbe4f07-e89f-42d7-b44a-3c89f43c4a8f");
			Name = "LookupValuesProcessorErrorEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,144,193,74,3,49,16,134,207,187,208,119,24,232,69,161,244,1,90,60,200,178,74,65,165,80,245,30,211,233,26,220,77,150,153,68,44,197,119,55,201,166,219,109,81,217,75,200,76,230,255,255,201,167,69,131,220,10,137,240,140,68,130,205,206,206,11,163,119,170,114,36,172,50,122,126,167,106,92,53,173,33,59,201,15,147,60,115,172,116,5,155,61,91,108,150,147,220,119,166,132,149,159,4,40,106,193,188,128,7,99,62,92,251,42,106,135,188,38,35,145,217,80,73,228,143,79,212,246,150,42,142,186,214,189,213,74,130,12,170,49,34,88,192,192,32,11,203,244,217,126,103,182,228,164,53,228,55,88,71,231,24,114,76,25,225,127,117,239,212,22,124,161,236,126,35,223,177,17,47,171,237,12,188,111,248,177,52,181,107,244,147,231,213,183,26,197,1,70,52,157,65,249,37,177,13,200,66,106,150,225,177,188,134,184,105,86,158,27,195,205,101,212,50,142,21,125,142,159,56,133,118,143,143,131,68,255,60,92,160,27,232,151,8,246,199,123,124,250,238,112,76,81,111,59,102,169,78,0,61,147,22,201,42,252,29,95,217,251,158,110,7,168,208,46,65,105,139,164,69,13,28,170,20,147,100,145,232,229,199,255,210,245,170,132,247,236,179,35,194,146,108,0,240,63,209,16,68,130,51,108,249,206,15,82,29,196,209,28,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dbe4f07-e89f-42d7-b44a-3c89f43c4a8f"));
		}

		#endregion

	}

	#endregion

}

