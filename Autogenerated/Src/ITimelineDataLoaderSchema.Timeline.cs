namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITimelineDataLoaderSchema

	/// <exclude/>
	public class ITimelineDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITimelineDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITimelineDataLoaderSchema(ITimelineDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64fda8d7-1a00-44a6-879f-e69e891738f1");
			Name = "ITimelineDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ef55f699-c757-427c-a5d6-6f8a0d355b0a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,81,203,78,195,48,16,60,39,82,254,97,21,46,32,85,201,7,16,114,40,84,8,169,39,232,15,24,103,19,173,20,175,131,31,135,8,245,223,177,227,164,2,181,23,142,222,153,241,236,236,176,80,104,39,33,17,78,104,140,176,186,119,213,179,230,158,6,111,132,35,205,213,137,20,142,196,88,228,223,69,158,121,75,60,192,199,108,29,170,64,28,71,148,145,101,171,87,100,52,36,31,139,60,176,238,12,14,97,10,111,155,248,69,56,113,212,162,67,179,224,117,93,67,99,189,82,194,204,237,250,142,176,133,77,0,93,80,64,175,13,216,9,37,245,36,1,217,145,155,171,77,94,255,210,79,254,115,12,12,98,135,166,143,97,110,26,103,49,192,149,247,127,205,179,43,247,52,153,132,17,10,56,220,243,169,76,236,178,61,36,85,83,47,224,109,174,92,174,93,182,23,243,49,236,2,105,250,71,121,36,235,154,189,246,220,109,212,244,125,187,108,31,131,222,111,192,194,74,232,186,249,238,18,238,29,191,60,90,151,74,94,125,30,82,109,231,84,30,114,151,250,139,207,243,15,69,16,162,172,34,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64fda8d7-1a00-44a6-879f-e69e891738f1"));
		}

		#endregion

	}

	#endregion

}

