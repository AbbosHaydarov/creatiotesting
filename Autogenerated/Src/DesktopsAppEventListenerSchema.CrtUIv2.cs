﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DesktopsAppEventListenerSchema

	/// <exclude/>
	public class DesktopsAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DesktopsAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DesktopsAppEventListenerSchema(DesktopsAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c3c0cf2-7b13-4644-8719-01a4b4bc1b70");
			Name = "DesktopsAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f4e67bb8-a45c-4fad-9829-cd5fbcd9c40f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,86,81,111,218,48,16,126,166,82,255,131,69,95,130,214,134,247,66,168,24,109,39,164,117,173,198,208,30,166,169,50,201,17,188,38,78,100,59,108,104,218,127,223,57,118,2,73,8,109,183,110,82,95,2,62,127,247,221,221,231,187,196,132,211,24,100,74,125,32,159,64,8,42,147,165,114,39,9,95,178,48,19,84,177,132,187,151,32,31,84,146,142,211,244,106,13,92,189,103,82,1,7,113,124,244,243,248,168,147,73,198,195,138,107,28,39,124,176,119,103,15,233,92,177,136,41,6,114,191,135,128,54,187,123,77,125,149,136,22,207,207,176,216,102,130,251,39,2,66,140,74,38,17,149,242,156,180,86,132,208,52,91,68,204,39,190,70,182,1,201,57,169,155,222,82,9,232,141,146,224,179,140,119,205,32,10,48,224,157,96,107,170,192,108,166,102,81,82,160,48,10,126,40,114,79,171,6,147,122,231,4,120,96,232,170,220,119,34,73,65,104,237,90,248,231,18,4,82,113,240,181,226,228,62,171,172,7,7,160,181,165,55,170,59,147,139,11,226,212,109,158,174,104,187,118,103,27,148,38,174,114,245,6,13,13,118,83,68,5,90,50,172,2,171,43,221,135,157,78,8,202,254,235,176,37,102,87,225,34,158,71,120,22,69,189,2,210,169,171,237,78,86,224,63,140,69,152,197,104,252,128,88,167,91,59,161,174,206,190,116,174,84,222,96,67,87,108,163,188,215,191,104,158,45,186,251,149,80,89,173,192,210,254,50,63,2,84,38,246,138,97,16,248,216,85,102,90,31,37,114,31,236,25,174,3,248,134,193,27,229,209,26,60,230,216,27,86,207,204,149,153,200,141,251,14,212,176,17,100,228,152,226,56,124,39,88,149,84,34,211,232,66,111,167,91,109,166,238,105,173,9,123,61,237,223,123,100,38,110,64,173,146,214,129,91,39,44,32,183,124,18,49,140,56,231,76,205,252,21,196,116,28,4,16,56,201,226,27,70,34,18,153,65,156,18,179,117,67,57,13,65,76,177,143,199,75,5,2,161,249,41,99,218,146,64,241,175,104,170,53,21,36,222,122,160,46,37,196,205,13,120,238,211,6,241,176,158,207,200,156,181,110,226,186,138,90,219,169,180,86,131,118,118,34,246,202,246,110,56,98,230,214,86,113,104,111,171,22,177,38,43,202,195,167,202,53,163,107,120,165,122,205,211,0,85,120,17,201,62,66,156,172,159,42,153,1,191,82,209,46,33,130,63,18,109,150,45,164,47,216,2,110,185,77,58,87,64,58,69,172,234,203,192,173,87,99,157,114,1,242,113,38,111,188,182,73,31,60,151,80,119,113,11,161,157,134,103,83,218,150,216,79,106,55,7,109,98,205,185,124,113,185,206,94,90,174,179,127,33,215,217,19,229,122,252,243,144,95,242,204,102,191,223,39,67,153,197,49,21,155,81,97,216,249,124,19,169,168,80,4,83,15,34,204,167,116,233,215,125,134,41,21,52,38,250,66,237,117,125,123,101,24,237,50,89,163,59,236,231,208,220,211,222,55,177,4,33,88,80,190,68,208,109,166,227,58,245,91,162,229,40,78,186,126,241,192,247,129,69,24,149,27,51,58,219,112,223,26,177,95,12,168,125,252,118,85,125,84,40,84,157,252,127,153,174,120,240,183,34,29,154,168,3,125,101,172,85,35,218,126,3,31,159,182,9,83,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c3c0cf2-7b13-4644-8719-01a4b4bc1b70"));
		}

		#endregion

	}

	#endregion

}

