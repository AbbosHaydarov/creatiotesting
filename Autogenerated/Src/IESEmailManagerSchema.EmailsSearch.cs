namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESEmailManagerSchema

	/// <exclude/>
	public class IESEmailManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESEmailManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESEmailManagerSchema(IESEmailManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe");
			Name = "IESEmailManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92df5372-6a61-42f2-95f4-67c9e246a93f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,82,205,110,194,48,12,62,131,196,59,88,112,217,36,212,238,204,74,47,12,77,72,67,67,99,47,144,21,183,68,106,18,22,39,76,104,226,221,231,36,133,253,176,105,151,86,113,190,31,127,118,180,80,72,59,81,33,60,163,181,130,76,237,178,153,209,181,108,188,21,78,26,157,205,149,144,45,173,81,216,106,59,232,191,15,250,61,79,82,55,176,62,144,67,197,224,182,197,42,32,41,187,71,141,86,86,183,131,62,163,70,22,27,174,194,66,59,180,53,59,76,96,49,95,71,181,165,208,162,65,27,97,121,158,67,65,94,41,97,15,101,119,94,89,179,151,27,36,80,232,182,102,67,80,27,11,24,152,64,177,15,246,207,78,220,252,11,121,231,95,90,89,129,60,89,94,58,246,56,0,127,207,221,45,147,195,4,86,145,154,46,127,246,20,11,105,2,169,13,10,238,151,246,169,178,19,86,40,208,60,216,233,208,226,171,71,114,195,242,65,146,3,83,119,253,3,57,203,25,40,43,242,136,254,131,108,222,102,198,107,102,199,95,160,115,137,56,30,88,116,222,106,216,139,214,227,191,34,244,88,215,132,44,243,20,216,38,30,130,72,19,214,37,90,22,163,29,175,239,23,161,100,67,229,157,140,27,230,152,161,137,110,4,69,126,186,14,248,197,92,123,197,114,47,45,22,159,240,34,5,29,119,129,203,178,27,99,122,84,87,97,42,29,164,228,54,226,172,198,97,125,33,104,10,61,133,155,115,165,11,18,106,215,233,145,245,70,168,55,105,149,241,124,76,79,239,91,241,248,1,122,39,166,70,228,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe"));
		}

		#endregion

	}

	#endregion

}

