﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeTaskSynchronizationUCManagerSchema

	/// <exclude/>
	public class ExchangeTaskSynchronizationUCManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeTaskSynchronizationUCManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeTaskSynchronizationUCManagerSchema(ExchangeTaskSynchronizationUCManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("def1f254-10a4-4b65-b425-9f6a3937bd73");
			Name = "ExchangeTaskSynchronizationUCManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,86,81,111,218,48,16,126,166,210,254,195,45,123,9,18,10,239,93,65,162,148,78,76,234,134,154,117,123,152,246,224,38,7,177,230,216,153,237,180,165,83,255,251,206,113,18,18,6,108,210,198,3,196,231,243,119,223,221,125,190,0,146,229,104,10,150,32,124,66,173,153,81,107,27,205,149,92,243,77,169,153,229,74,190,58,251,249,234,108,80,26,46,55,16,111,141,197,252,109,187,238,30,201,115,37,15,239,104,60,102,143,174,46,143,110,45,164,229,150,163,57,234,112,205,18,171,180,247,32,159,55,26,55,68,23,230,130,25,115,14,139,167,36,99,114,131,159,152,249,30,111,101,146,105,37,249,115,149,209,221,252,134,73,182,65,93,157,27,143,199,112,97,202,60,103,122,59,173,215,21,6,20,90,61,240,20,13,148,6,181,1,155,49,11,25,51,128,146,221,11,76,1,235,16,144,48,129,50,101,228,99,250,145,64,112,99,163,38,200,184,19,229,235,21,174,89,41,236,37,151,41,229,22,218,109,129,106,29,46,143,81,29,142,224,3,117,10,38,16,116,51,11,134,223,8,172,40,239,5,79,32,169,88,255,77,226,176,171,207,188,230,126,188,70,3,234,63,125,183,5,94,105,85,160,118,173,57,135,85,21,217,239,239,23,178,54,32,213,71,227,122,18,28,205,45,218,219,32,249,89,173,132,64,237,82,14,198,59,176,110,5,155,172,213,3,201,130,218,4,198,106,175,209,19,96,48,153,246,11,120,131,150,93,49,203,102,137,45,153,224,207,168,3,47,167,193,27,42,139,207,248,68,122,183,104,75,45,13,104,20,204,146,36,172,130,139,130,105,150,83,198,224,174,214,36,64,167,227,45,101,1,164,87,254,64,207,80,74,254,163,68,32,210,180,183,230,84,129,195,25,86,150,10,174,143,53,237,84,117,209,194,115,105,44,147,9,70,23,227,234,204,14,66,123,150,211,219,127,100,121,49,110,144,170,250,107,101,49,113,120,109,11,222,149,60,133,119,104,235,64,158,219,50,13,253,3,93,28,247,51,4,55,80,6,3,243,200,109,146,65,232,173,81,156,100,152,51,215,164,198,97,144,48,131,16,204,106,66,193,185,183,14,60,137,26,45,90,105,238,10,54,87,162,204,229,103,38,202,106,218,208,39,245,55,108,239,148,163,24,45,242,194,110,189,219,139,251,126,233,43,156,68,145,169,212,201,187,73,241,132,4,98,100,154,168,247,166,68,194,100,103,20,224,145,106,47,83,87,111,106,70,59,72,44,41,210,180,67,227,111,20,225,130,146,196,37,177,36,230,61,101,220,245,183,78,42,228,119,145,17,185,105,83,249,246,224,65,77,28,17,219,221,127,45,199,31,165,23,163,32,139,19,95,21,216,47,195,126,13,170,22,237,150,35,175,215,38,122,35,59,190,134,240,245,60,195,228,123,147,255,181,86,121,51,39,195,125,140,230,248,8,214,76,24,28,182,234,173,5,39,75,33,58,82,107,205,248,88,115,222,67,28,214,122,141,188,162,195,224,38,142,131,17,4,115,141,238,78,93,186,58,213,62,145,35,22,238,46,200,48,154,25,90,182,219,75,194,212,239,21,119,32,140,139,123,245,228,134,99,140,214,210,160,52,181,187,131,31,70,31,201,103,230,194,124,124,164,51,46,68,180,52,139,31,52,19,79,18,232,68,104,88,28,8,49,219,133,240,80,7,216,28,12,217,137,244,37,67,141,53,199,158,175,47,83,180,114,146,66,139,186,158,39,212,207,230,232,76,166,109,228,197,83,161,180,173,185,210,43,236,20,144,213,37,181,179,11,82,211,218,123,197,196,86,21,5,158,228,212,72,131,254,61,248,166,87,138,104,198,78,255,77,227,173,125,35,217,126,1,14,235,223,209,170,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("def1f254-10a4-4b65-b425-9f6a3937bd73"));
		}

		#endregion

	}

	#endregion

}

