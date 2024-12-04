namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingServiceSettingsSchema

	/// <exclude/>
	public class MailingServiceSettingsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingServiceSettingsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingServiceSettingsSchema(MailingServiceSettingsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aab368d1-5d3d-4df2-8f5a-686ab5543ad8");
			Name = "MailingServiceSettings";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,79,79,195,48,12,197,207,155,180,239,96,109,23,184,180,119,6,72,104,67,156,54,77,20,78,136,67,214,186,37,34,127,42,199,153,52,38,190,59,110,187,2,27,67,130,75,34,191,188,23,255,156,56,101,49,212,42,71,120,64,34,21,124,201,201,204,187,82,87,145,20,107,239,146,217,109,182,240,5,154,48,26,238,70,195,65,12,218,85,144,109,3,163,77,238,163,99,109,49,201,144,180,50,250,173,77,76,71,67,241,77,8,43,41,96,102,84,8,23,176,80,218,72,80,140,27,157,99,134,204,82,133,214,153,166,41,92,134,104,173,162,237,245,190,238,13,224,75,224,23,132,220,248,88,64,232,210,73,31,74,191,165,158,230,138,149,144,51,169,156,159,69,168,227,218,232,92,146,210,255,215,246,3,25,73,214,79,218,21,249,26,137,53,10,242,170,189,160,59,63,102,108,133,59,100,1,36,193,146,189,161,116,242,152,61,113,77,126,163,11,164,6,246,39,109,135,187,64,187,70,58,91,54,177,43,24,247,145,241,121,195,223,15,16,152,154,23,95,237,15,151,141,121,7,21,242,180,105,60,133,247,191,18,42,7,190,174,61,113,116,154,183,192,30,172,122,253,2,133,2,75,21,13,255,3,56,6,236,177,110,194,188,139,31,194,175,189,55,240,120,194,118,106,132,9,186,162,251,135,182,238,212,67,81,180,15,186,101,43,244,178,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aab368d1-5d3d-4df2-8f5a-686ab5543ad8"));
		}

		#endregion

	}

	#endregion

}

