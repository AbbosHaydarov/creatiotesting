namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingAppEventListenerSchema

	/// <exclude/>
	public class MailingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingAppEventListenerSchema(MailingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f77b591-a8a7-4600-8f2b-2803c4f5ce85");
			Name = "MailingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,193,106,220,64,12,61,59,144,127,16,206,101,123,177,239,105,118,33,9,73,19,104,104,104,26,122,40,165,104,109,121,59,116,60,51,104,198,166,219,210,127,175,236,177,147,204,238,150,230,98,163,39,233,73,122,210,24,108,201,59,172,8,62,17,51,122,219,132,226,210,154,70,109,58,198,160,172,57,62,250,125,124,148,117,94,153,77,18,194,244,246,0,254,153,214,226,107,91,107,196,43,254,19,166,141,144,192,165,70,239,79,225,14,149,150,132,115,231,174,122,50,225,189,242,129,12,241,24,90,150,37,156,249,174,109,145,183,171,201,254,72,142,201,75,164,135,150,194,119,91,123,8,22,148,81,65,161,86,191,8,164,243,31,184,161,98,206,47,95,16,184,110,173,85,5,213,80,250,95,149,225,20,118,161,11,244,36,217,50,181,124,159,6,184,86,164,107,153,224,158,85,143,129,162,211,69,3,30,61,177,136,102,168,26,20,131,111,93,98,71,37,178,19,50,117,36,75,153,239,226,96,175,163,126,71,33,69,22,115,251,2,5,250,25,160,138,255,55,48,172,45,203,84,3,139,157,126,96,185,4,211,105,61,135,100,61,50,160,115,18,49,7,204,44,133,176,139,134,227,33,124,201,197,120,102,201,191,2,250,65,188,100,208,129,110,175,92,66,94,60,108,69,231,54,157,34,102,254,25,191,76,161,227,67,34,142,1,175,83,114,220,124,116,238,158,213,8,92,40,35,167,52,29,143,23,63,17,84,76,205,50,31,15,245,26,171,96,121,155,151,43,80,210,171,31,206,107,255,190,34,226,144,177,5,35,207,104,153,79,170,229,171,91,227,3,26,121,84,182,121,73,190,179,171,188,92,21,103,229,72,48,242,77,7,107,123,121,78,170,38,232,173,170,225,131,145,172,135,128,28,254,183,234,97,141,123,210,239,31,204,156,21,53,159,222,197,13,154,90,19,251,199,32,102,80,228,139,43,131,107,77,231,146,211,211,61,219,94,26,226,57,106,145,150,137,84,135,151,19,209,20,20,236,47,213,29,208,228,119,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f77b591-a8a7-4600-8f2b-2803c4f5ce85"));
		}

		#endregion

	}

	#endregion

}

