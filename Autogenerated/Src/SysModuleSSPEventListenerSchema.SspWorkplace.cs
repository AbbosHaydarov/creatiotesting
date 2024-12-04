﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleSSPEventListenerSchema

	/// <exclude/>
	public class SysModuleSSPEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleSSPEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleSSPEventListenerSchema(SysModuleSSPEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8");
			Name = "SysModuleSSPEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,111,219,48,12,61,187,64,255,3,235,93,108,160,115,238,109,18,32,43,178,33,64,187,22,75,187,203,176,131,106,211,169,6,91,242,36,57,155,177,246,191,151,150,108,199,78,147,118,193,118,201,135,196,247,72,62,242,73,176,28,117,193,98,132,91,84,138,105,153,154,232,66,138,148,175,74,197,12,151,34,90,98,92,127,31,31,253,57,62,242,74,205,197,106,16,170,48,154,11,195,13,71,125,254,86,64,52,211,149,136,175,11,116,212,135,3,162,133,48,168,82,42,247,47,176,243,53,10,179,63,238,35,139,141,84,174,108,138,121,167,112,69,41,224,34,99,90,159,193,178,210,87,50,41,51,92,46,111,44,209,37,215,6,5,42,27,60,26,141,96,172,203,60,103,170,154,54,255,45,16,10,37,215,60,65,189,33,0,2,115,83,1,218,114,224,129,137,36,163,114,162,150,102,212,227,249,102,139,175,6,9,131,101,252,128,57,251,76,131,130,9,248,29,175,31,126,39,68,81,222,103,60,134,216,38,223,91,52,156,193,7,166,113,7,59,81,208,92,233,179,19,224,10,205,131,76,72,130,27,37,13,205,30,19,119,191,221,179,61,248,66,24,34,82,26,180,91,19,96,245,207,44,125,175,81,173,57,173,85,33,149,97,25,240,20,198,5,83,44,87,152,130,160,94,38,190,238,58,25,77,193,84,5,41,245,179,100,153,166,44,136,16,83,224,196,111,150,239,150,110,235,40,234,171,214,237,165,112,238,196,38,120,193,62,237,241,57,5,106,42,46,180,97,34,198,104,60,178,176,221,44,53,250,181,178,237,80,129,169,85,153,219,233,238,100,45,90,33,97,45,121,210,105,214,244,54,211,75,93,4,174,48,232,200,79,193,157,204,82,138,180,19,155,169,149,6,12,161,182,161,231,173,153,130,146,52,38,175,138,70,249,201,6,29,221,13,174,106,15,120,30,141,32,56,217,132,124,66,179,208,23,50,43,115,241,149,101,37,94,74,150,96,18,248,86,235,16,30,31,45,200,243,6,136,250,50,233,129,198,92,152,105,135,57,153,64,64,7,97,111,106,17,141,172,173,217,83,104,74,213,84,243,212,181,193,106,143,207,127,99,92,146,31,169,11,107,36,231,206,170,206,57,94,244,246,118,214,15,158,6,2,127,1,245,169,141,42,235,248,89,51,136,192,31,106,227,159,110,137,21,134,231,93,126,217,62,47,86,225,9,212,156,219,25,175,251,49,65,111,74,216,16,13,154,136,220,15,180,208,241,11,87,14,25,167,193,160,0,199,247,212,120,18,69,226,108,185,207,163,214,254,175,24,180,183,251,123,94,128,232,90,44,4,137,67,251,73,27,189,219,93,205,43,35,215,244,132,210,235,230,246,120,131,11,228,253,15,210,149,140,47,18,84,111,173,238,61,213,209,75,26,180,168,86,202,157,254,104,12,18,110,5,63,253,107,235,119,69,194,54,29,236,46,61,60,84,151,33,233,97,178,180,216,255,160,202,214,246,184,211,225,33,157,61,3,252,87,26,74,2,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8"));
		}

		#endregion

	}

	#endregion

}

