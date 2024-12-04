﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityUtilsWrapSchema

	/// <exclude/>
	public class ActivityUtilsWrapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityUtilsWrapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityUtilsWrapSchema(ActivityUtilsWrapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fb6ffdd-6e4c-4c0a-9f67-c80a30991ee0");
			Name = "ActivityUtilsWrap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,86,223,111,218,48,16,126,102,210,254,7,171,125,1,169,10,239,93,87,169,107,105,135,212,110,149,160,154,180,105,15,110,114,1,111,198,70,246,5,149,77,253,223,123,78,66,126,56,161,41,148,39,184,227,238,187,239,62,223,25,43,190,0,187,228,33,176,41,24,195,173,142,49,184,212,42,22,179,196,112,20,90,177,255,31,63,244,18,43,212,140,77,214,22,97,241,201,179,41,92,74,8,93,172,13,110,64,129,17,97,25,51,86,8,179,12,233,98,41,130,75,46,65,69,220,4,87,211,239,91,131,156,105,98,226,100,203,144,42,59,3,219,252,193,72,161,64,177,61,49,184,230,33,106,147,69,80,204,177,129,153,107,242,82,114,107,79,217,5,181,177,18,184,126,64,33,237,15,195,151,105,208,175,43,136,121,34,241,139,80,17,65,246,113,189,4,29,247,199,181,232,193,224,55,133,46,147,71,41,66,22,58,184,38,26,59,101,245,36,39,46,101,21,52,238,0,231,58,34,34,247,41,78,246,227,112,56,100,103,66,205,73,88,140,52,129,27,136,63,31,213,129,130,107,241,180,113,76,5,74,232,91,52,196,245,132,61,88,48,116,160,42,59,161,193,209,240,220,97,230,60,179,32,182,37,153,173,184,76,192,135,96,73,29,49,29,144,94,207,0,38,70,177,14,86,57,162,7,225,78,171,247,188,67,183,55,128,23,136,60,156,47,64,225,55,26,225,126,157,227,73,222,89,123,187,93,217,30,189,13,24,227,181,164,87,27,111,150,240,49,61,176,125,36,24,61,9,139,68,108,180,224,194,142,35,219,16,225,138,35,76,197,130,4,223,76,195,230,211,121,127,106,5,99,21,107,79,164,91,2,61,187,73,68,116,206,186,107,52,164,218,148,100,150,246,220,25,133,122,54,121,252,67,81,133,253,168,163,245,73,170,96,175,202,134,97,149,90,135,198,13,118,141,147,43,89,108,202,167,117,235,85,246,18,159,74,202,175,220,206,15,163,122,57,154,219,128,27,82,191,162,53,93,130,18,14,171,116,193,106,187,196,121,213,3,9,60,201,113,175,141,94,76,69,248,183,57,222,82,55,54,188,144,228,13,0,13,65,29,30,241,166,200,46,53,154,208,62,86,6,243,158,190,219,123,78,255,224,214,94,215,41,241,142,212,70,183,25,18,227,121,253,183,182,220,222,110,129,178,215,85,158,59,210,241,242,119,166,220,166,242,155,187,157,118,220,170,150,26,222,150,72,29,114,255,14,67,110,48,155,237,194,23,37,144,121,28,9,182,52,130,94,19,184,30,23,124,152,210,8,246,189,235,86,163,155,243,44,9,86,120,21,116,170,76,50,10,239,95,193,26,139,170,65,37,249,4,240,109,106,183,36,22,243,82,5,219,69,146,182,252,125,58,188,13,255,221,27,177,34,5,239,0,220,63,137,183,53,131,214,246,186,178,118,121,34,181,194,189,242,62,58,166,61,204,94,139,169,157,121,171,206,231,23,184,249,236,120,211,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fb6ffdd-6e4c-4c0a-9f67-c80a30991ee0"));
		}

		#endregion

	}

	#endregion

}

