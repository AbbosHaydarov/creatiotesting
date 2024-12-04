namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringExtentionsSchema

	/// <exclude/>
	public class StringExtentionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringExtentionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringExtentionsSchema(StringExtentionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57b5ada9-5411-44e8-a972-15aef76f4662");
			Name = "StringExtentions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,145,65,107,131,64,16,133,207,6,252,15,211,164,16,45,65,210,28,122,104,8,4,130,135,66,61,89,232,161,228,176,213,137,46,53,171,236,140,165,37,228,191,119,221,213,148,164,165,245,32,56,243,222,55,111,70,80,98,143,212,136,12,225,9,181,22,84,239,56,218,212,106,39,139,86,11,150,181,138,226,231,212,31,29,252,145,215,146,84,5,164,159,196,184,95,250,35,83,153,104,44,140,4,54,149,32,186,135,148,181,81,196,31,140,170,115,146,213,72,197,168,149,168,128,216,240,50,200,58,237,15,41,24,165,153,97,222,39,104,130,92,214,185,193,62,244,4,215,190,228,145,37,65,34,232,13,243,120,47,100,21,112,41,105,168,83,221,234,12,67,232,22,240,188,119,161,161,17,154,9,86,125,39,74,155,74,114,48,93,79,195,165,149,200,29,4,86,18,61,162,42,184,132,171,21,44,6,191,167,145,91,173,122,175,51,28,79,228,238,150,6,108,221,47,243,173,107,247,142,235,241,161,107,71,105,251,234,146,5,243,153,9,205,101,148,72,21,44,102,214,220,143,12,195,227,141,125,214,7,199,186,221,30,199,150,102,102,253,123,131,63,214,255,206,50,44,255,107,154,187,217,112,156,139,60,103,33,38,168,114,247,171,236,183,171,158,23,77,237,11,87,229,95,141,97,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57b5ada9-5411-44e8-a972-15aef76f4662"));
		}

		#endregion

	}

	#endregion

}

