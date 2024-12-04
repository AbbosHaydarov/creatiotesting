namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichatEsqColumnsAppenderSchema

	/// <exclude/>
	public class OmnichatEsqColumnsAppenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichatEsqColumnsAppenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichatEsqColumnsAppenderSchema(OmnichatEsqColumnsAppenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5322e155-583b-42c4-86ac-8bbc2f6dad98");
			Name = "OmnichatEsqColumnsAppender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f05d58c-8c35-4460-8cdc-92bf987e5f26");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,219,78,195,48,12,125,71,226,31,12,72,104,188,164,239,192,38,141,49,36,36,198,117,63,16,82,175,139,104,146,46,78,209,42,180,127,39,73,91,8,163,224,167,204,62,231,248,216,245,52,87,72,21,23,8,75,180,150,147,89,57,54,51,122,37,139,218,114,39,141,102,15,74,75,177,230,90,99,201,22,72,196,11,169,139,195,131,143,195,3,240,81,147,255,5,47,13,57,84,236,78,234,205,69,154,79,53,149,50,250,207,162,197,127,74,108,174,157,116,18,201,99,90,212,137,197,194,123,131,89,201,137,206,161,179,232,230,180,153,153,178,86,154,166,85,133,58,71,219,19,178,44,131,75,170,149,226,182,153,124,167,34,31,156,1,158,231,161,111,105,138,2,115,16,173,72,40,244,210,44,209,201,126,10,85,245,107,41,5,144,243,251,18,32,162,228,127,142,2,199,111,175,125,164,211,44,208,173,77,238,231,121,140,138,41,100,192,127,159,158,230,57,13,24,71,218,116,158,255,242,253,149,175,184,229,10,180,191,132,241,177,167,29,79,122,247,81,228,50,139,245,132,244,115,224,119,35,243,96,226,46,90,232,166,29,197,79,214,188,136,53,42,254,84,163,109,130,214,89,152,187,87,9,33,87,48,10,61,158,141,113,45,150,221,210,210,114,241,54,243,23,87,32,221,234,235,171,95,172,16,123,172,174,45,187,49,118,206,197,122,36,96,60,25,162,245,77,197,64,31,56,61,133,163,160,219,139,77,117,51,218,6,161,45,187,247,203,129,241,24,68,124,157,13,90,234,35,72,248,125,180,42,190,83,100,116,231,189,31,187,223,233,221,62,54,193,248,103,114,54,254,158,218,203,105,115,29,174,251,135,36,197,29,124,2,239,31,146,150,230,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5322e155-583b-42c4-86ac-8bbc2f6dad98"));
		}

		#endregion

	}

	#endregion

}

