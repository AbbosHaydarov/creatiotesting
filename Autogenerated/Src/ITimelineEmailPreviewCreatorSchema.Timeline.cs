namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITimelineEmailPreviewCreatorSchema

	/// <exclude/>
	public class ITimelineEmailPreviewCreatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITimelineEmailPreviewCreatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITimelineEmailPreviewCreatorSchema(ITimelineEmailPreviewCreatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("437742ef-1987-4d72-ba0d-753a57b1a47f");
			Name = "ITimelineEmailPreviewCreator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7a90b74c-4b62-4974-bba4-023527b96ef3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,221,106,195,48,12,133,175,91,232,59,136,238,102,133,146,220,111,93,161,148,49,122,55,104,95,192,181,149,70,144,88,153,236,164,132,209,119,159,227,252,176,209,209,75,9,235,211,57,71,182,170,68,87,41,141,112,66,17,229,56,243,201,158,109,70,151,90,148,39,182,201,137,74,44,200,226,98,254,189,152,47,230,179,39,193,75,232,195,193,122,148,44,76,190,192,225,189,84,84,140,15,63,5,27,194,235,94,80,121,150,56,147,166,41,108,92,93,150,74,218,237,80,79,243,144,177,128,238,94,147,189,64,68,65,213,51,64,23,202,185,100,36,164,191,16,85,125,46,72,3,77,148,199,34,102,65,252,236,78,71,108,28,171,130,188,3,159,35,96,92,174,57,64,173,239,216,12,95,53,123,116,107,80,214,128,83,13,2,121,80,174,181,58,23,182,92,187,162,237,228,221,235,235,59,149,18,85,130,13,33,191,45,35,252,96,150,219,157,246,212,144,111,129,76,88,67,25,161,0,103,253,242,100,147,198,153,255,17,130,154,197,116,140,83,80,91,42,23,204,67,223,140,41,94,115,210,121,116,50,6,72,110,138,246,49,122,48,189,220,134,235,71,247,163,34,56,179,105,255,204,54,76,6,62,208,239,172,57,134,68,134,168,159,157,151,238,128,131,205,53,12,245,168,121,106,12,155,86,175,129,117,235,191,20,90,211,255,170,174,188,253,0,146,155,67,124,148,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("437742ef-1987-4d72-ba0d-753a57b1a47f"));
		}

		#endregion

	}

	#endregion

}

