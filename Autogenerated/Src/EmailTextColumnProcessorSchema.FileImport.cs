namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTextColumnProcessorSchema

	/// <exclude/>
	public class EmailTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTextColumnProcessorSchema(EmailTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70d219b6-f9e4-471d-9053-15d73a72c898");
			Name = "EmailTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,139,125,111,155,64,155,110,151,192,178,20,154,236,165,236,65,145,199,233,128,61,242,142,164,210,176,244,191,239,216,74,186,117,90,23,122,177,165,225,233,61,205,39,137,77,141,190,49,22,97,133,34,198,187,50,100,11,199,37,109,163,152,64,142,179,27,170,112,89,55,78,194,233,201,223,211,147,81,244,196,91,184,219,249,128,245,249,203,252,245,106,193,161,122,118,99,108,112,66,232,85,161,154,47,130,91,205,128,69,101,188,63,131,111,181,161,106,133,79,97,225,170,88,243,173,56,139,222,59,233,180,121,158,195,5,241,3,10,133,194,89,176,130,229,108,252,142,122,156,207,15,114,31,235,218,200,238,48,191,100,32,246,193,176,182,235,74,8,15,228,193,182,209,160,3,81,14,142,61,109,42,132,210,9,52,201,175,109,226,135,227,109,27,4,182,75,130,71,83,69,244,217,33,37,127,21,115,127,141,165,137,85,184,34,46,116,233,36,236,26,116,229,100,121,180,199,233,87,248,169,228,97,6,172,63,21,12,181,62,157,254,86,215,38,110,42,178,251,189,14,73,225,12,222,101,55,210,83,211,239,127,216,218,101,144,216,30,132,50,191,237,172,147,226,147,136,223,48,238,10,11,65,19,208,247,73,43,5,85,34,238,45,135,90,80,223,150,234,91,172,169,210,24,49,117,71,108,54,142,30,69,59,97,180,237,45,29,207,215,58,215,243,57,20,178,139,188,83,119,139,247,248,134,82,39,235,158,23,244,173,167,202,117,99,60,78,142,203,237,99,24,61,239,217,34,23,9,111,159,181,102,52,40,65,47,188,146,22,23,116,45,22,31,193,190,210,164,79,192,190,54,193,164,235,152,24,71,166,63,58,166,2,57,80,73,40,3,56,245,114,167,189,128,123,212,23,170,122,248,30,169,232,252,126,181,118,43,117,91,47,11,152,205,251,181,236,5,226,177,52,189,232,99,18,137,79,191,168,181,127,239,101,157,198,119,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70d219b6-f9e4-471d-9053-15d73a72c898"));
		}

		#endregion

	}

	#endregion

}

