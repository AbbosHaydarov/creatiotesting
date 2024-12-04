﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UINotifierSchema

	/// <exclude/>
	public class UINotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UINotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UINotifierSchema(UINotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5704b7fa-4c80-4bce-881c-4cb0fa3ceeb6");
			Name = "UINotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,87,75,111,227,54,16,62,59,64,254,3,225,189,56,64,32,223,243,112,209,122,55,133,10,196,13,106,7,123,92,48,210,216,38,42,137,2,73,37,112,23,249,239,29,14,41,137,146,21,217,61,44,176,40,144,56,230,60,200,153,249,102,62,50,5,207,65,151,60,1,182,84,102,153,201,42,141,11,3,59,197,141,144,69,244,108,68,38,140,0,125,121,241,253,242,98,82,105,81,236,6,13,63,27,121,59,106,208,236,20,125,81,74,42,221,90,175,224,205,200,66,203,173,137,254,208,178,104,21,27,80,138,147,124,41,243,124,76,51,226,168,224,35,121,244,192,19,35,21,134,132,22,104,243,73,193,14,35,101,54,106,181,197,138,220,176,248,57,94,73,35,182,2,20,153,204,231,115,118,167,171,60,231,234,176,240,235,198,156,109,165,98,102,15,172,32,151,132,242,102,248,243,28,71,181,239,60,112,46,171,151,76,36,76,52,254,157,211,38,88,111,252,108,162,122,4,179,151,169,190,97,79,228,230,148,253,120,72,176,134,34,237,198,240,38,204,158,34,211,37,36,118,255,148,37,88,55,142,118,246,55,5,157,40,81,18,76,205,174,97,164,78,82,114,197,115,86,96,191,220,79,189,251,10,23,211,133,253,100,114,75,39,120,69,116,55,39,243,97,239,224,192,233,98,131,94,97,4,163,158,101,198,13,150,57,159,46,126,77,89,189,32,221,168,91,82,105,35,115,91,24,80,46,230,37,73,72,93,135,174,73,141,120,104,3,60,181,210,214,129,149,74,150,160,204,97,60,188,55,120,209,50,249,27,204,26,180,198,100,226,212,229,215,200,241,16,82,48,145,66,225,160,238,236,248,42,69,202,168,9,14,51,109,148,109,218,160,212,215,204,203,154,204,239,217,116,218,72,131,42,118,21,253,244,157,214,158,55,241,22,199,129,147,205,213,237,72,159,253,5,165,84,70,83,237,112,176,164,58,183,121,200,216,21,198,249,253,143,176,115,69,33,138,155,197,244,199,229,120,2,11,118,30,14,159,208,205,241,1,173,223,29,111,117,132,1,145,45,51,174,145,48,90,86,249,141,107,248,144,199,48,114,5,88,71,143,168,200,203,12,114,92,122,26,219,226,62,158,85,48,239,33,62,115,155,2,240,76,75,150,40,216,222,79,199,47,130,128,239,166,108,30,80,34,127,193,114,32,57,179,196,102,208,75,224,230,152,39,91,150,124,16,144,17,73,42,241,202,141,75,118,82,186,5,83,216,26,178,200,14,44,126,212,187,229,158,23,5,100,77,52,236,91,126,44,188,29,116,127,214,160,150,18,13,19,42,205,183,170,179,30,134,170,137,240,201,53,35,110,110,163,148,6,157,32,173,227,244,203,182,0,190,45,130,118,249,206,118,96,110,217,251,248,41,24,14,186,86,246,126,59,231,202,136,11,76,151,103,226,31,172,3,103,5,188,209,36,241,34,105,6,204,2,235,65,237,194,49,157,47,28,76,31,76,191,135,180,235,52,187,98,4,219,100,168,232,216,241,212,185,238,122,62,68,191,131,185,27,66,108,49,179,99,97,55,233,2,48,228,223,133,172,246,60,81,196,246,202,13,187,105,176,128,79,82,251,185,193,215,148,230,59,56,151,11,113,224,215,52,240,248,128,106,248,134,121,194,73,141,28,231,44,71,123,199,183,176,147,119,124,235,46,38,150,178,225,62,186,64,103,95,131,8,236,225,205,162,33,165,246,148,26,182,86,130,197,110,23,81,172,87,85,150,253,169,190,228,165,57,32,200,191,132,157,123,19,88,250,33,25,196,63,10,163,35,171,62,194,215,193,78,238,26,155,216,7,96,244,128,87,34,55,246,235,154,34,159,145,116,13,202,245,246,44,204,238,234,154,57,115,131,134,81,140,219,33,71,165,87,180,219,127,236,142,254,116,137,98,143,71,154,84,38,126,98,2,194,138,220,229,142,83,19,12,199,171,80,166,226,25,251,217,110,127,143,246,43,87,157,198,64,165,165,136,78,227,56,203,73,172,215,85,146,224,46,104,131,252,83,163,99,95,233,246,165,121,223,201,199,233,62,119,226,14,178,240,250,167,54,219,58,113,175,249,58,20,246,113,46,100,252,238,168,34,108,173,110,175,247,171,212,233,129,211,176,6,247,254,8,182,63,232,117,16,224,132,215,70,161,177,76,174,154,22,38,58,102,35,87,193,63,4,27,111,132,81,244,38,203,51,234,0,226,193,198,209,198,127,7,151,9,165,224,61,67,175,232,76,128,218,51,253,51,14,219,164,87,135,83,204,210,183,63,133,182,59,104,108,206,135,222,86,239,151,23,255,2,140,27,128,136,47,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5704b7fa-4c80-4bce-881c-4cb0fa3ceeb6"));
		}

		#endregion

	}

	#endregion

}

