namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IStartDeduplicationRequestFactorySchema

	/// <exclude/>
	public class IStartDeduplicationRequestFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IStartDeduplicationRequestFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IStartDeduplicationRequestFactorySchema(IStartDeduplicationRequestFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("317ae3ca-74ff-401a-9e48-5d31d65af269");
			Name = "IStartDeduplicationRequestFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,79,195,48,12,134,207,171,212,255,96,141,11,72,168,189,195,152,4,3,164,94,16,218,144,56,103,141,59,162,181,73,177,19,196,132,248,239,228,99,27,155,182,33,110,125,109,191,238,99,199,90,116,200,189,168,17,94,144,72,176,105,108,49,49,186,81,11,71,194,42,163,139,123,148,174,111,85,29,85,158,125,229,217,192,177,210,11,216,75,60,180,130,173,170,139,87,156,223,246,42,180,176,36,106,203,197,20,223,29,178,229,235,60,243,206,51,194,133,175,134,74,91,164,198,255,246,10,170,59,215,46,247,122,77,93,139,143,222,108,104,21,77,101,89,194,136,93,215,9,90,141,215,250,153,204,135,146,200,208,161,125,51,18,26,67,48,119,170,149,129,140,173,32,235,101,187,4,185,219,24,40,193,20,155,166,229,78,215,222,205,125,29,168,13,25,84,179,208,102,159,44,249,183,112,131,176,141,3,190,24,152,16,10,235,249,254,195,114,8,147,34,189,32,209,129,246,79,116,51,100,172,131,237,201,139,225,120,150,68,76,21,163,50,214,29,183,41,45,241,51,153,170,240,121,194,66,104,29,105,30,199,145,255,162,29,149,155,210,224,61,185,161,245,248,39,243,231,108,41,190,212,239,84,151,126,85,49,182,69,190,240,55,51,248,78,119,131,90,166,211,9,210,199,126,0,80,207,48,174,184,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("317ae3ca-74ff-401a-9e48-5d31d65af269"));
		}

		#endregion

	}

	#endregion

}

