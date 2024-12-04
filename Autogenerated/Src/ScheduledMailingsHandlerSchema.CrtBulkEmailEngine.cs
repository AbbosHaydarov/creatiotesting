﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ScheduledMailingsHandlerSchema

	/// <exclude/>
	public class ScheduledMailingsHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ScheduledMailingsHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ScheduledMailingsHandlerSchema(ScheduledMailingsHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f6a0d4f-2e18-43fb-83dc-32cbcf7152a3");
			Name = "ScheduledMailingsHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4de4a012-9259-439f-964b-fe58905ea24f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,77,111,219,48,12,61,187,64,255,3,225,94,18,44,72,182,29,251,117,88,209,117,29,150,161,64,218,93,134,97,80,109,38,214,96,75,6,69,167,11,130,252,247,209,178,236,218,105,139,110,187,8,18,37,146,143,143,79,52,170,64,87,170,4,225,22,137,148,179,75,158,94,88,179,212,171,138,20,107,107,14,15,182,135,7,81,229,180,89,13,158,16,158,116,246,197,198,49,22,114,22,203,17,225,74,220,224,34,87,206,29,195,34,201,48,173,114,76,231,74,231,242,214,125,82,38,205,145,252,219,217,108,6,167,174,42,10,69,155,243,112,14,247,176,180,4,156,33,184,54,0,20,33,194,180,245,156,245,92,203,234,62,215,9,36,117,214,23,147,194,49,124,80,14,131,181,67,18,73,133,178,118,208,111,200,150,72,172,81,240,203,158,49,97,76,155,39,37,233,181,98,4,66,149,90,147,111,192,49,213,12,252,44,201,38,232,220,87,161,19,206,32,110,17,204,5,78,72,23,159,52,1,66,60,176,107,97,83,167,216,134,184,233,69,168,41,143,162,21,114,216,69,132,92,145,25,164,241,225,162,93,189,238,94,1,247,203,222,183,192,230,82,52,233,60,223,167,232,53,116,159,67,136,23,145,133,28,79,81,29,161,100,244,196,14,89,158,35,103,54,245,20,123,216,195,26,180,97,184,66,190,54,140,180,86,249,232,206,33,137,46,141,160,171,157,171,193,113,28,192,4,44,35,113,30,15,181,58,212,244,84,4,187,64,102,175,38,201,242,77,229,21,142,134,49,39,61,174,26,170,232,86,23,184,96,44,227,241,201,63,213,231,165,217,92,238,43,222,27,46,164,97,140,78,106,118,172,140,124,69,187,244,210,207,26,129,214,122,127,42,248,198,82,42,82,5,24,33,254,44,30,226,143,207,175,123,225,234,59,72,186,203,233,233,204,123,250,64,225,235,116,29,95,91,157,6,76,109,136,191,163,159,105,211,170,162,110,159,14,189,19,217,245,59,185,231,219,8,38,10,50,108,101,73,119,44,231,250,11,78,27,36,162,191,39,13,10,154,244,155,43,178,85,217,156,122,31,105,210,129,152,52,105,34,83,229,249,4,152,42,185,171,215,189,252,143,105,191,216,213,244,218,44,237,71,75,133,226,81,252,253,165,161,50,29,82,245,227,184,134,3,219,183,59,63,194,98,120,19,50,199,225,239,194,246,221,14,30,52,103,143,4,109,223,239,30,231,92,220,43,236,217,82,198,225,143,65,162,56,201,96,116,249,59,193,210,183,5,219,93,219,145,231,203,186,36,178,244,31,117,121,63,120,200,116,222,141,229,122,52,244,74,148,33,80,87,46,37,116,80,186,106,2,236,136,51,178,15,175,142,137,198,58,52,138,237,15,218,199,232,204,175,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f6a0d4f-2e18-43fb-83dc-32cbcf7152a3"));
		}

		#endregion

	}

	#endregion

}

