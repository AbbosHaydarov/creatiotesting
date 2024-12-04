namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LowerExpressionConverterSchema

	/// <exclude/>
	public class LowerExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LowerExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LowerExpressionConverterSchema(LowerExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b69b03e9-3983-48ee-b50b-7df2ea273c76");
			Name = "LowerExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("75f7d434-56de-4d62-8a8c-9fe090e3ebb1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,82,77,107,194,64,16,61,71,240,63,12,233,197,64,73,238,214,6,68,60,8,253,2,189,149,30,214,100,76,83,146,221,176,31,182,82,252,239,157,221,205,166,90,237,33,9,251,230,189,183,243,102,194,89,139,170,99,5,194,6,165,100,74,236,116,186,16,124,87,87,70,50,93,11,62,30,125,143,71,145,81,53,175,96,125,80,26,219,187,241,136,144,27,137,21,149,97,209,48,165,166,240,32,62,81,46,191,58,137,74,17,76,22,123,148,26,165,229,18,59,203,50,152,41,211,182,76,30,242,254,236,36,80,48,133,160,180,180,254,56,232,161,8,6,80,216,11,210,224,145,157,152,188,94,185,111,174,201,106,107,52,78,98,231,31,39,111,196,236,204,182,169,11,111,245,111,171,48,133,213,53,152,244,118,4,145,125,66,234,71,212,239,162,164,220,47,206,57,148,255,198,116,64,239,164,66,202,61,107,12,218,64,151,137,60,210,49,201,90,224,180,153,251,216,145,227,124,125,42,157,101,142,113,93,192,100,101,90,228,90,197,57,204,203,178,182,59,100,13,12,240,165,90,162,54,146,171,60,36,46,207,26,5,45,160,25,54,69,234,64,183,250,126,174,61,127,105,5,140,70,47,182,31,88,104,175,191,13,213,161,3,184,135,56,78,192,205,52,234,139,244,33,120,226,79,137,19,210,111,70,245,122,23,208,116,165,158,76,211,60,203,101,219,233,131,5,147,96,18,249,158,172,139,87,29,221,251,23,77,55,194,109,125,197,247,76,214,140,235,73,226,136,196,115,91,69,94,250,197,186,179,71,207,193,227,15,143,16,117,214,41,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b69b03e9-3983-48ee-b50b-7df2ea273c76"));
		}

		#endregion

	}

	#endregion

}

