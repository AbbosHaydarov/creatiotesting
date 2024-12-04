﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimelineDataCacheRepositorySchema

	/// <exclude/>
	public class TimelineDataCacheRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimelineDataCacheRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimelineDataCacheRepositorySchema(TimelineDataCacheRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20cfbbe5-d829-4a7e-982e-ca73eb1a5e87");
			Name = "TimelineDataCacheRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ef55f699-c757-427c-a5d6-6f8a0d355b0a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,149,77,79,219,64,16,134,207,65,226,63,76,77,15,65,170,156,59,36,169,84,104,81,250,137,8,237,165,170,232,98,143,97,91,123,55,154,93,7,82,148,255,222,241,250,131,181,113,2,237,133,75,34,175,119,230,157,121,230,221,181,18,25,154,133,136,16,206,145,72,24,157,216,240,72,171,68,94,229,36,172,212,42,60,151,25,166,82,225,238,206,221,238,206,32,55,82,93,193,103,188,177,90,185,205,239,141,86,135,205,139,249,202,88,204,56,67,154,98,84,132,155,240,4,21,146,140,238,247,248,66,132,188,206,111,246,8,175,120,55,28,165,194,152,3,168,53,143,133,21,71,34,186,198,51,92,104,35,173,166,149,219,62,26,141,96,108,242,44,19,180,154,86,207,117,12,196,28,4,81,17,5,212,132,133,117,212,200,11,91,228,151,169,140,32,42,68,183,107,14,184,119,254,189,175,147,59,179,66,89,174,245,148,228,82,88,44,223,47,202,7,136,138,247,96,44,185,134,171,204,46,235,7,92,157,18,38,242,22,38,16,248,154,23,65,137,98,176,135,42,46,101,218,154,167,164,23,72,86,162,19,213,150,1,99,92,203,86,143,240,213,32,113,113,170,164,223,121,124,68,192,53,69,121,196,45,23,18,14,78,185,163,203,219,45,204,148,180,82,164,242,15,26,16,160,240,6,164,131,194,94,210,9,88,198,63,54,200,40,184,219,73,176,133,110,48,154,150,35,8,27,169,133,32,145,129,98,111,78,130,188,213,66,48,157,109,22,105,119,203,121,195,241,200,165,106,106,110,141,191,158,255,150,218,134,29,158,237,98,246,161,56,18,131,65,103,211,164,179,173,176,254,96,189,157,253,39,180,215,58,126,10,246,19,180,149,187,127,227,10,18,77,96,125,231,135,253,173,62,192,154,9,62,169,116,134,145,166,120,22,7,211,230,248,144,91,2,25,163,178,50,145,72,45,136,21,50,30,129,117,127,206,224,92,82,237,237,97,181,212,78,95,131,34,180,57,41,120,25,220,245,159,137,245,197,93,59,112,29,248,240,54,242,120,163,115,21,215,41,223,114,221,118,245,211,64,66,58,43,81,253,47,148,89,3,161,112,155,75,21,87,128,30,90,203,79,68,104,242,212,186,74,248,188,122,116,221,229,228,21,214,195,246,82,235,20,206,105,197,141,249,206,124,199,65,142,86,63,226,87,160,115,11,31,165,177,227,30,26,83,104,87,84,15,100,41,168,44,228,155,72,115,100,231,182,173,28,206,209,24,254,119,186,223,253,49,119,230,251,3,132,169,220,112,88,77,218,151,227,196,158,202,139,9,168,60,77,225,53,20,31,15,86,91,242,181,22,30,35,75,151,247,201,151,203,95,172,63,222,216,204,116,120,159,109,31,14,92,182,67,223,96,29,245,74,240,81,43,205,55,90,201,234,103,50,18,246,91,168,207,55,75,45,227,162,133,7,215,217,38,195,108,54,75,173,218,127,193,253,131,43,38,173,17,207,219,3,30,54,50,143,78,230,12,51,189,196,103,63,231,11,143,116,89,210,19,97,63,1,100,88,38,28,110,225,217,226,212,249,146,148,171,254,226,26,224,47,189,112,194,110,222,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20cfbbe5-d829-4a7e-982e-ca73eb1a5e87"));
		}

		#endregion

	}

	#endregion

}

