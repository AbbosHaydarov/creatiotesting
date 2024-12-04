namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SyncConstsSchema

	/// <exclude/>
	public class SyncConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SyncConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SyncConstsSchema(SyncConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46b057b7-14b5-4c05-b912-248362985d2b");
			Name = "SyncConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,207,106,220,48,16,198,207,107,240,59,136,244,210,28,166,241,234,159,101,66,15,178,70,42,129,64,75,211,62,128,235,85,130,97,215,94,36,187,37,148,188,123,229,236,134,197,176,133,205,160,131,196,140,230,247,49,159,52,197,174,127,34,15,207,113,244,187,219,60,203,179,190,217,249,184,111,90,79,126,248,16,154,56,60,142,159,204,208,63,118,79,83,104,198,110,232,243,236,111,158,173,246,211,175,109,215,146,118,219,196,152,174,247,109,170,137,99,36,41,53,167,87,55,55,31,142,65,222,54,199,19,185,71,253,109,46,57,182,136,99,106,219,146,224,155,205,208,111,159,201,151,169,219,144,251,77,179,159,187,126,221,251,3,245,110,67,62,147,222,255,121,77,127,188,50,156,105,38,106,3,140,57,13,28,101,1,213,218,88,48,53,82,81,81,164,37,87,87,215,183,171,153,115,144,115,9,241,103,244,225,193,135,223,93,235,239,118,251,33,140,255,195,99,89,35,170,90,130,112,44,225,165,51,160,41,55,192,29,117,101,197,120,97,108,153,240,39,250,98,2,175,113,137,158,131,8,236,130,111,103,17,11,9,154,57,65,149,46,65,105,202,128,115,38,64,89,230,160,166,181,226,232,184,213,204,46,39,112,82,0,111,158,92,100,195,212,182,62,198,239,62,78,219,113,33,193,217,74,8,35,37,216,170,176,192,53,26,168,49,217,193,100,193,156,43,75,109,185,57,63,133,247,41,176,33,12,225,12,31,37,117,180,178,20,52,23,18,184,194,53,84,150,73,168,139,53,106,102,168,54,136,231,248,137,126,249,27,156,63,198,130,170,10,153,22,10,48,198,42,224,194,36,11,144,174,1,165,224,105,240,170,146,198,157,168,47,121,246,242,15,27,47,248,54,100,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46b057b7-14b5-4c05-b912-248362985d2b"));
		}

		#endregion

	}

	#endregion

}

