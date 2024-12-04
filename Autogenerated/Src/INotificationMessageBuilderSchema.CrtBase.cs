namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationMessageBuilderSchema

	/// <exclude/>
	public class INotificationMessageBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationMessageBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationMessageBuilderSchema(INotificationMessageBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0a82eba-e0ad-4ba7-bced-e8d42f2a5640");
			Name = "INotificationMessageBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,193,106,2,49,16,134,207,17,124,135,129,94,218,139,123,215,82,168,61,216,61,88,132,182,15,16,205,236,110,192,36,146,73,10,82,250,238,157,36,106,213,178,162,151,221,100,50,255,63,223,76,98,165,65,218,200,21,194,7,122,47,201,53,97,244,226,108,163,219,232,101,208,206,14,7,223,195,129,136,164,109,11,239,91,10,104,38,135,253,159,100,142,68,178,229,24,139,141,113,150,115,56,235,206,99,203,22,80,219,128,190,225,34,99,168,223,92,208,141,94,101,239,162,194,105,212,107,133,62,75,170,170,130,71,138,198,72,191,125,218,237,23,222,125,105,133,4,6,67,231,20,65,112,176,76,26,176,71,102,124,154,221,70,123,151,234,200,102,19,151,107,189,2,189,7,185,204,33,184,101,254,30,248,25,96,131,62,104,164,49,44,178,83,57,63,135,205,129,25,6,2,231,129,210,159,177,109,170,131,30,92,3,161,67,144,202,104,11,209,234,144,64,255,147,138,89,212,42,77,250,57,37,126,114,94,173,32,93,129,16,45,134,52,123,33,104,183,248,217,97,162,85,133,244,20,123,94,198,117,5,115,238,156,64,238,103,120,196,125,137,50,203,106,117,255,48,185,197,187,67,169,122,125,235,57,181,175,57,161,8,203,250,198,10,75,167,182,61,254,20,124,122,185,89,50,229,180,43,157,251,30,90,79,7,69,120,240,62,187,160,114,109,167,65,142,253,2,84,83,243,229,139,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0a82eba-e0ad-4ba7-bced-e8d42f2a5640"));
		}

		#endregion

	}

	#endregion

}

