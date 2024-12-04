namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMessageRecipientInfoSchema

	/// <exclude/>
	public class IMessageRecipientInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMessageRecipientInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMessageRecipientInfoSchema(IMessageRecipientInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e93974ca-bdd6-46d5-a877-c7093a88aaec");
			Name = "IMessageRecipientInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("956f026d-fde0-4edb-a4cc-83d98fd529ec");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,84,77,111,219,48,12,61,187,64,255,3,129,30,186,1,67,114,111,139,14,69,82,4,62,20,8,178,238,7,104,22,237,16,179,36,79,146,215,21,69,255,123,41,203,246,50,187,118,179,13,189,36,22,69,241,61,126,60,106,161,208,85,34,67,184,71,107,133,51,185,95,172,140,206,169,168,173,240,100,52,156,158,60,157,158,36,181,35,93,192,151,71,231,81,93,14,206,252,160,44,49,11,222,110,177,65,141,150,50,246,97,175,51,139,69,136,145,106,143,54,103,148,11,72,239,208,57,81,224,14,51,170,8,181,79,117,110,26,231,229,114,9,87,174,86,74,216,199,235,246,188,181,230,39,73,116,160,208,239,141,116,32,180,132,202,154,10,173,39,54,231,198,194,131,177,223,225,129,252,30,108,23,19,76,14,74,80,201,28,23,93,228,229,65,232,170,254,86,82,6,212,209,154,98,149,112,234,252,219,231,177,237,145,47,96,219,196,136,247,67,234,141,225,171,166,31,53,2,211,215,158,114,66,27,88,245,20,3,175,49,177,100,83,147,132,84,194,19,215,61,73,146,2,125,168,118,146,56,254,104,76,207,51,136,61,251,115,7,24,242,7,33,165,229,204,38,192,156,183,161,139,183,193,245,38,122,254,27,48,79,140,23,89,128,229,108,219,100,63,180,198,197,46,149,31,39,8,112,3,186,183,236,245,14,216,211,208,77,161,91,183,0,61,70,126,11,120,141,185,168,75,15,153,145,24,90,235,247,200,237,117,21,171,0,155,193,140,134,249,126,135,10,164,154,60,137,114,215,190,93,133,120,243,124,206,80,203,56,146,205,57,90,7,198,215,180,119,251,171,162,40,235,227,84,119,160,52,111,128,217,0,246,17,88,61,156,164,138,223,33,93,21,37,116,164,224,134,84,254,75,106,173,122,15,217,73,225,113,162,230,107,190,186,39,133,159,225,55,137,96,123,167,162,175,87,127,185,235,6,251,77,137,204,26,158,50,14,169,253,113,197,29,65,118,213,125,181,122,27,244,14,24,136,243,229,62,243,208,254,129,56,85,68,106,22,62,31,175,226,26,249,4,241,255,26,238,194,243,176,73,66,37,67,212,75,152,211,209,8,222,98,197,249,136,131,205,57,167,225,93,244,110,214,199,16,240,153,183,199,168,73,124,245,2,70,243,112,12,246,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e93974ca-bdd6-46d5-a877-c7093a88aaec"));
		}

		#endregion

	}

	#endregion

}

