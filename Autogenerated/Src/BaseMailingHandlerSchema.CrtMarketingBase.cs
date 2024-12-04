namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMailingHandlerSchema

	/// <exclude/>
	public class BaseMailingHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMailingHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMailingHandlerSchema(BaseMailingHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c034f568-64d4-4b23-8e61-b1ebaf6fc883");
			Name = "BaseMailingHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,84,219,110,219,48,12,125,118,129,254,3,145,190,116,64,97,191,55,105,128,45,195,210,20,232,16,244,242,1,178,205,36,42,100,201,160,164,0,65,209,127,31,109,201,174,157,53,235,250,18,64,228,33,207,33,121,28,45,42,180,181,40,16,158,144,72,88,179,113,233,194,232,141,220,122,18,78,26,125,126,246,122,126,150,120,43,245,22,30,15,214,97,197,121,165,176,104,146,54,93,162,70,146,197,180,199,12,219,16,158,138,167,143,197,14,75,175,144,24,193,152,11,194,45,247,131,133,18,214,94,195,15,97,241,94,72,197,133,183,66,151,12,107,81,89,150,193,204,250,170,18,116,152,199,119,3,133,42,96,97,23,192,105,135,205,6,224,218,231,74,22,32,114,235,72,20,14,138,134,234,3,38,184,134,213,49,119,194,59,224,223,94,230,47,137,170,100,157,107,146,123,225,48,36,235,240,0,66,81,26,173,14,192,68,141,168,23,147,47,201,248,250,55,175,26,110,96,18,155,79,194,228,201,5,234,50,180,29,115,172,201,212,72,78,98,203,99,28,111,28,203,142,41,62,223,167,137,92,12,44,208,218,150,170,185,91,146,108,209,53,71,72,222,62,43,189,51,249,255,148,237,37,57,47,212,160,234,125,184,190,20,94,121,11,206,147,30,13,63,133,183,65,203,83,115,223,163,219,153,242,95,67,119,18,126,202,214,132,124,223,89,80,115,5,38,127,97,204,28,150,232,214,130,152,211,33,217,203,103,139,196,166,214,193,180,224,71,207,111,81,118,20,172,189,82,211,47,201,108,125,21,146,199,6,109,3,11,54,132,67,11,82,91,39,52,127,105,102,3,110,135,67,179,254,237,214,16,169,155,25,64,243,28,55,147,177,234,201,124,53,104,215,228,160,232,147,233,44,107,43,219,70,199,190,223,27,89,70,77,171,216,226,147,5,69,163,126,56,220,3,86,102,255,229,225,162,166,238,144,173,164,208,169,151,212,157,229,123,93,247,255,21,105,192,176,231,46,163,91,175,70,6,108,148,158,58,92,136,142,131,28,251,3,77,184,140,46,0,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c034f568-64d4-4b23-8e61-b1ebaf6fc883"));
		}

		#endregion

	}

	#endregion

}

