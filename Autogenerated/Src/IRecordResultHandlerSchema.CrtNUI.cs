namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRecordResultHandlerSchema

	/// <exclude/>
	public class IRecordResultHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRecordResultHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRecordResultHandlerSchema(IRecordResultHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("52df6bf9-2697-4d65-9203-47d8c0b2315b");
			Name = "IRecordResultHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,177,10,194,48,16,134,103,11,125,135,3,23,93,236,174,226,226,98,7,65,74,95,32,38,23,27,104,147,114,73,68,17,223,221,52,177,69,212,33,132,251,239,190,220,71,52,235,208,246,140,35,212,72,196,172,145,110,181,55,90,170,139,39,230,148,209,121,246,200,179,60,155,205,9,47,161,132,82,59,36,25,128,53,148,21,114,67,162,66,235,91,119,96,90,180,72,113,182,40,10,216,90,223,117,140,238,187,119,61,113,96,36,184,6,129,34,28,174,129,134,38,225,171,145,46,62,240,222,159,91,197,65,77,47,252,91,12,73,115,242,60,162,107,140,176,107,56,69,58,53,191,197,98,80,7,153,46,78,131,178,128,55,228,222,161,0,38,195,186,209,50,52,122,50,28,173,69,49,56,254,74,206,174,70,9,72,98,167,113,116,177,220,188,173,80,139,36,54,84,225,60,211,167,126,196,121,22,179,23,165,217,130,93,145,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52df6bf9-2697-4d65-9203-47d8c0b2315b"));
		}

		#endregion

	}

	#endregion

}

