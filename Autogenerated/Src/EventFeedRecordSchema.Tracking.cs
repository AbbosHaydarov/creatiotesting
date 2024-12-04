namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventFeedRecordSchema

	/// <exclude/>
	public class EventFeedRecordSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventFeedRecordSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventFeedRecordSchema(EventFeedRecordSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("effa70fc-e7f0-40c3-a8f5-cf38bfc84003");
			Name = "EventFeedRecord";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,148,77,111,212,48,16,134,207,173,212,255,48,42,23,184,100,239,148,15,149,93,80,145,248,88,237,70,112,64,61,56,201,36,49,56,118,52,158,108,89,42,254,59,147,100,219,221,150,36,120,185,36,177,223,215,207,235,25,197,182,170,66,95,171,20,33,70,34,229,93,206,209,220,217,92,23,13,41,214,206,70,49,169,244,135,182,197,217,233,237,217,233,73,227,229,19,214,91,207,88,93,60,26,71,171,198,178,174,48,90,35,105,101,244,175,14,32,46,241,61,33,44,100,0,115,163,188,127,14,111,55,104,249,29,98,182,194,212,81,214,89,102,179,25,188,240,77,85,41,218,190,218,141,23,241,103,112,201,119,76,25,110,74,157,150,144,58,203,74,91,15,218,230,142,170,46,1,114,114,21,164,198,53,25,168,196,53,12,206,34,80,71,238,23,200,242,92,194,162,187,148,217,65,204,183,133,98,37,37,179,212,201,215,50,81,55,137,209,169,240,100,167,127,111,244,68,186,32,207,251,130,150,228,106,36,214,40,85,45,187,149,189,222,97,63,98,149,32,61,253,36,77,134,151,112,174,179,243,103,109,194,93,132,103,106,187,215,101,188,207,224,22,10,228,11,240,237,227,247,56,133,183,53,142,115,98,81,67,73,86,222,227,164,206,21,72,218,40,211,76,160,190,180,114,40,43,117,158,199,81,115,81,67,73,153,226,225,77,197,242,151,122,86,85,29,74,42,9,243,65,210,149,8,161,16,177,202,25,67,26,4,173,118,98,40,204,40,91,52,170,24,174,239,195,78,12,133,213,70,113,123,156,6,97,203,157,24,10,75,200,221,248,145,42,223,244,218,177,69,250,201,42,125,40,206,167,132,104,191,234,140,203,135,64,109,249,53,172,247,234,113,192,43,212,69,201,163,196,94,62,14,185,212,63,209,44,176,158,216,232,222,114,28,250,114,163,180,153,238,193,229,189,229,63,208,255,232,198,129,231,56,248,220,25,71,211,45,217,91,30,163,229,190,70,155,245,87,118,23,212,199,29,78,202,204,31,219,222,177,252,13,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("effa70fc-e7f0-40c3-a8f5-cf38bfc84003"));
		}

		#endregion

	}

	#endregion

}

