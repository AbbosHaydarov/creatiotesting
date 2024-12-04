﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessagePublisherSchema

	/// <exclude/>
	public class BaseMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessagePublisherSchema(BaseMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69dcb355-a236-4771-bc8a-b1e104c699ab");
			Name = "BaseMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,85,219,106,219,64,16,125,150,193,255,48,77,95,20,48,242,123,110,165,182,147,96,74,74,136,147,190,150,141,52,178,23,164,149,217,139,139,8,249,247,206,94,228,72,178,148,82,8,142,118,119,116,230,204,153,51,90,163,184,216,194,166,86,26,203,203,233,196,180,150,201,178,42,10,76,53,175,132,74,238,81,160,228,233,49,228,25,165,100,170,202,53,69,73,28,217,78,110,133,230,154,163,162,243,233,68,176,18,213,158,165,216,137,18,57,223,26,201,108,150,233,228,109,58,137,232,239,171,196,45,173,97,89,48,165,46,96,193,20,62,160,82,108,139,143,230,181,224,106,135,210,2,70,123,187,74,129,189,42,45,89,170,33,181,241,131,225,112,1,235,83,136,136,242,209,239,49,223,29,199,34,163,132,143,146,31,152,70,127,56,159,207,225,74,153,178,100,178,190,105,54,86,220,233,66,91,80,229,224,42,3,38,50,56,176,194,208,35,237,229,14,43,57,34,204,219,16,123,159,0,36,178,172,18,69,221,198,187,162,98,72,202,25,248,255,55,240,27,173,138,181,39,183,98,154,93,6,214,40,50,79,124,172,138,74,83,251,48,243,199,251,102,25,128,193,53,167,222,164,59,44,217,79,170,0,174,195,73,114,91,238,117,77,89,162,168,251,226,145,238,139,66,73,173,19,222,29,189,229,63,232,17,173,61,74,235,138,79,40,222,27,158,5,130,79,152,86,50,91,103,240,6,91,212,151,160,236,207,123,67,110,44,11,209,161,98,76,170,43,249,73,154,33,171,196,189,226,76,103,57,107,181,234,164,83,253,70,157,131,53,116,20,245,16,175,123,152,78,233,232,164,205,20,55,208,121,138,236,233,114,13,247,168,201,178,37,211,53,141,172,41,197,47,235,194,248,220,69,147,82,125,157,130,114,65,169,7,212,187,170,227,250,166,237,222,163,174,21,35,25,124,121,193,79,244,130,53,120,43,128,168,9,83,20,35,245,37,207,178,38,92,15,117,182,206,206,102,80,25,61,0,227,11,137,36,106,35,197,96,26,159,7,190,57,178,222,190,52,241,2,255,184,141,120,12,114,208,69,163,234,140,120,200,119,195,42,228,159,226,166,235,7,38,65,185,233,34,29,186,22,72,218,179,247,192,4,249,79,210,39,86,175,201,180,76,164,184,168,237,64,198,253,9,13,66,88,96,47,166,29,89,119,154,44,105,54,53,6,6,221,100,225,45,255,70,66,103,223,179,146,139,39,190,221,105,69,0,57,43,20,250,16,158,67,252,37,196,221,161,78,119,119,178,42,87,139,184,107,184,243,166,192,232,255,73,52,44,54,168,87,152,183,26,162,130,93,125,79,70,201,210,72,7,174,57,221,47,44,221,65,252,161,134,179,150,155,28,46,78,191,154,61,214,150,66,219,203,61,136,228,7,214,179,62,110,210,182,227,123,219,148,62,112,108,224,134,13,101,236,229,21,220,228,158,225,192,165,54,172,128,67,69,35,23,62,72,29,59,29,5,111,185,173,211,221,13,59,124,50,248,180,246,187,189,205,134,219,90,104,148,57,221,208,131,183,229,199,133,203,155,184,177,75,149,216,118,74,176,132,134,50,191,255,5,206,123,152,143,127,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69dcb355-a236-4771-bc8a-b1e104c699ab"));
		}

		#endregion

	}

	#endregion

}

