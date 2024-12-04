﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysQueryActionListenerSchema

	/// <exclude/>
	public class SysQueryActionListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysQueryActionListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysQueryActionListenerSchema(SysQueryActionListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7212a6e-0918-4845-a171-8318a9732c02");
			Name = "SysQueryActionListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da177164-c77f-4e70-8b5f-3d14e4f140b9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,86,93,79,219,48,20,125,46,18,255,225,46,188,180,210,148,190,51,138,212,150,238,67,130,177,81,120,154,246,96,146,155,212,91,98,119,182,211,45,154,248,239,187,182,19,104,210,166,12,141,109,240,82,213,215,215,247,227,248,248,220,8,150,163,94,178,8,225,18,149,98,90,38,38,156,74,145,240,180,80,204,112,41,194,143,5,170,114,246,3,163,194,46,47,138,12,245,254,222,207,253,189,94,161,185,72,97,94,106,131,249,171,214,154,98,100,25,70,246,132,14,223,160,64,197,163,13,159,83,46,190,109,24,231,148,72,113,83,222,109,172,23,150,231,82,108,223,81,216,101,15,79,38,157,91,51,97,184,225,168,239,117,8,103,43,20,166,219,239,53,139,140,84,187,34,109,193,145,124,201,251,64,97,74,22,152,102,76,235,67,139,131,115,29,59,244,78,57,161,66,240,57,207,225,112,8,71,186,200,115,166,202,227,106,77,151,101,148,204,52,152,5,66,146,201,239,32,19,136,20,210,229,81,13,76,196,144,203,152,39,101,5,241,90,232,176,142,56,108,133,60,210,136,44,211,210,134,73,70,193,110,68,194,9,211,232,108,165,51,212,5,7,48,180,241,62,109,217,234,207,163,5,230,236,61,81,15,70,16,52,171,10,6,159,233,216,178,184,206,120,4,145,133,164,3,17,56,132,142,212,116,158,248,73,191,183,208,158,161,89,200,152,192,253,160,248,138,25,244,187,75,191,128,149,228,49,76,23,24,125,29,199,57,23,231,75,244,212,191,224,233,194,232,254,149,70,69,40,11,79,103,40,26,203,1,216,167,208,235,173,152,130,248,186,38,239,76,164,92,216,230,154,206,196,196,166,135,37,75,175,199,19,232,191,104,31,166,87,99,166,76,120,194,224,109,77,253,128,140,103,76,176,20,231,50,115,84,10,6,117,17,189,141,32,174,171,221,97,28,180,142,142,193,192,215,115,99,67,217,127,55,93,56,189,19,212,151,217,130,214,19,4,203,215,74,4,81,165,89,208,43,88,131,171,251,206,91,117,87,184,236,196,228,106,25,147,225,121,96,226,107,253,251,152,156,96,134,207,5,19,95,235,99,99,114,128,34,246,34,212,165,72,78,233,252,102,91,223,157,225,45,105,56,61,206,150,10,194,156,173,48,6,180,186,103,133,124,83,201,189,101,201,20,203,65,144,212,142,2,77,181,144,48,31,59,177,4,191,10,143,134,206,101,251,9,12,142,47,105,172,216,129,80,15,131,195,206,113,224,132,120,156,24,84,46,193,88,165,218,14,1,224,66,27,38,232,11,35,162,81,197,184,176,147,136,134,85,157,208,181,0,196,71,214,168,165,154,0,146,238,67,241,184,34,213,121,245,154,41,68,95,94,127,33,212,171,54,94,130,79,63,193,132,138,186,205,15,72,119,88,137,153,99,83,11,196,17,244,155,150,129,15,231,239,113,39,71,233,108,107,156,54,221,125,136,123,212,178,77,159,166,238,62,132,14,238,69,91,100,159,28,35,90,87,210,69,137,58,155,253,140,121,24,37,234,214,127,159,17,255,151,14,221,131,226,241,232,224,196,236,223,208,161,182,255,33,45,30,36,20,119,253,220,203,142,26,137,231,194,142,238,145,185,155,29,173,65,227,173,77,35,217,126,1,31,246,5,210,239,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7212a6e-0918-4845-a171-8318a9732c02"));
		}

		#endregion

	}

	#endregion

}

