﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueueMessageNotifierSchema

	/// <exclude/>
	public class BaseQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueueMessageNotifierSchema(BaseQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26232705-edfd-4420-a62d-2624a06495f2");
			Name = "BaseQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0feb11c-442a-4bb5-a527-aa32bcda81de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,86,75,111,26,49,16,62,19,41,255,193,165,151,69,66,203,189,9,68,9,109,35,14,164,105,72,148,99,229,44,3,184,89,108,106,123,105,81,149,255,222,241,99,119,189,15,30,233,33,15,143,231,249,205,55,227,229,116,13,106,67,19,32,143,32,37,85,98,161,227,177,224,11,182,204,36,213,76,240,243,179,191,231,103,157,76,49,190,36,179,157,210,176,190,40,206,161,137,132,125,242,248,43,77,180,144,12,20,106,160,206,71,9,75,116,76,198,41,85,234,19,185,161,10,190,103,144,193,20,148,162,75,184,19,154,45,24,72,171,59,24,12,200,165,202,214,107,42,119,35,127,182,202,100,237,180,201,70,138,4,255,53,97,185,183,140,115,195,65,96,185,201,94,82,150,16,250,162,180,196,124,72,98,162,31,8,222,193,178,241,119,153,173,224,104,153,153,74,48,233,123,235,205,105,212,115,180,130,64,157,44,240,231,82,1,144,68,194,98,216,221,23,179,59,24,185,172,76,254,205,2,156,100,67,37,93,19,142,93,27,118,51,5,18,227,112,72,76,163,186,163,203,129,189,181,202,190,220,125,177,162,167,138,45,169,186,234,17,211,243,78,167,166,52,172,169,153,134,119,222,60,76,192,231,14,169,42,108,247,82,108,64,106,108,62,130,38,133,70,75,152,31,192,237,14,43,35,98,65,244,10,225,202,164,4,174,43,125,109,193,101,147,187,45,155,139,127,12,33,242,106,173,211,191,100,9,250,130,188,157,24,92,194,154,241,185,241,130,41,48,189,35,42,89,193,154,190,59,135,135,220,207,204,218,183,164,114,18,116,199,248,118,205,9,67,198,81,158,20,21,4,148,171,54,242,24,209,60,119,106,221,175,29,125,13,234,24,166,181,196,130,164,10,100,158,52,75,153,169,179,72,140,104,97,148,168,14,250,176,55,91,201,182,70,177,233,142,252,144,13,217,69,80,96,139,69,139,200,141,2,22,75,134,163,54,143,228,234,138,68,109,242,161,219,112,110,251,237,226,91,208,151,77,247,163,168,215,179,57,117,212,254,8,67,178,165,105,6,167,204,219,20,244,74,204,237,176,89,88,220,109,142,209,86,176,57,25,91,96,139,84,162,219,12,133,42,123,249,137,157,157,204,251,196,158,19,193,53,117,103,79,228,57,168,68,178,77,184,31,182,84,250,233,112,228,126,154,204,49,215,42,81,226,47,129,194,148,114,92,66,210,96,49,193,151,228,102,103,198,33,106,25,145,94,140,190,46,138,32,126,19,140,243,164,154,81,198,78,195,72,227,66,173,116,80,128,234,222,54,180,231,240,187,236,182,147,70,181,90,242,50,59,215,25,130,42,109,216,122,38,125,167,17,102,150,212,238,102,57,180,120,87,194,236,238,62,151,160,226,109,0,177,189,126,115,5,52,89,19,215,123,88,69,163,95,175,183,247,78,234,84,246,116,203,110,179,20,193,38,22,165,69,230,161,121,164,234,53,124,108,242,55,218,68,63,188,36,209,149,219,213,137,253,230,8,80,57,232,184,224,166,89,148,214,242,1,84,150,234,102,192,45,147,58,163,169,27,0,27,106,247,204,244,170,4,240,191,194,4,99,80,52,22,219,88,1,38,192,192,171,6,93,118,202,251,74,47,194,183,148,103,56,87,227,64,48,194,222,50,54,180,48,231,112,118,67,42,236,1,104,134,12,121,134,151,153,72,94,65,123,48,14,119,56,68,34,180,194,2,243,92,30,197,204,162,24,249,244,167,106,57,94,81,164,108,90,210,250,94,168,220,242,81,92,167,105,20,190,224,253,170,235,119,114,250,216,3,234,35,41,228,166,200,52,249,181,239,35,83,218,22,156,250,137,230,29,116,71,147,246,55,176,13,84,243,10,154,79,70,30,208,34,14,191,237,26,81,92,78,221,209,189,75,19,219,89,48,198,231,75,52,252,209,21,39,254,13,220,54,7,227,200,44,132,82,31,208,209,210,135,202,185,192,22,36,250,224,209,154,177,20,151,102,177,79,219,6,176,240,239,77,190,181,114,30,219,109,54,106,27,63,43,131,214,78,11,39,173,10,81,246,15,221,211,137,238,4,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26232705-edfd-4420-a62d-2624a06495f2"));
		}

		#endregion

	}

	#endregion

}

