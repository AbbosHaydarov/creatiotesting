﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPrimaryEntityFinderSchema

	/// <exclude/>
	public class IPrimaryEntityFinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPrimaryEntityFinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPrimaryEntityFinderSchema(IPrimaryEntityFinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ef9a048-2ae1-43c0-b555-ed097820e198");
			Name = "IPrimaryEntityFinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,193,78,195,48,16,68,207,137,148,127,88,149,11,72,40,185,67,200,5,181,40,130,67,37,248,1,55,217,68,171,198,118,180,182,17,17,234,191,99,215,180,77,21,184,101,54,51,243,108,175,18,18,205,40,26,132,15,100,22,70,119,54,127,214,170,163,222,177,176,164,85,190,161,1,107,57,106,182,89,250,157,165,137,51,164,122,120,159,140,69,233,173,195,128,77,240,153,252,5,21,50,53,143,89,234,93,55,140,189,159,66,173,44,114,231,251,31,160,222,50,73,193,211,90,89,178,211,134,84,139,28,188,222,93,20,5,148,198,201,240,187,250,213,193,0,248,69,198,2,121,148,1,225,181,65,11,157,102,136,7,138,77,249,169,160,152,53,140,110,55,80,3,116,194,255,67,79,194,141,22,248,11,127,140,33,192,51,41,89,160,226,100,20,44,36,40,255,156,79,171,227,55,122,178,89,85,241,164,112,25,229,101,113,20,127,71,247,56,153,24,241,79,235,164,242,13,175,56,65,19,197,85,246,83,83,11,111,90,180,87,55,187,141,233,237,153,55,67,223,67,189,86,78,34,139,221,128,229,28,83,193,2,124,231,23,153,28,226,50,81,181,113,159,65,30,126,0,17,47,213,110,52,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ef9a048-2ae1-43c0-b555-ed097820e198"));
		}

		#endregion

	}

	#endregion

}

