namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventFeedDataProviderResponseSchema

	/// <exclude/>
	public class EventFeedDataProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventFeedDataProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventFeedDataProviderResponseSchema(EventFeedDataProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf4ac696-3045-4224-8196-29e9ed1c351b");
			Name = "EventFeedDataProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,81,77,111,194,48,12,61,131,196,127,176,224,222,222,129,113,97,31,151,73,32,198,31,200,82,167,139,214,38,200,118,145,24,218,127,159,219,180,8,109,8,237,18,197,206,123,207,207,47,193,212,200,7,99,17,246,72,100,56,58,201,214,49,56,95,54,100,196,199,144,237,201,216,79,31,202,201,248,60,25,143,26,214,43,188,157,88,176,86,96,85,161,109,81,156,189,96,64,242,118,49,25,43,106,70,88,106,23,214,149,97,158,195,211,17,131,60,35,22,143,70,204,150,226,209,23,72,59,157,171,68,236,8,121,158,195,146,155,186,54,116,90,245,245,0,0,219,170,128,139,164,16,212,146,208,61,76,245,53,54,100,241,90,114,154,175,192,132,2,124,248,80,47,130,69,162,34,103,189,228,227,126,3,54,6,49,62,48,16,218,72,69,18,62,122,110,76,229,191,80,185,9,97,5,156,58,30,152,203,252,202,221,161,121,175,188,237,125,221,93,14,230,112,123,231,145,134,169,231,37,41,69,28,144,196,163,198,181,237,228,211,251,239,96,186,198,198,57,70,129,232,134,29,90,151,127,109,14,62,89,168,253,180,158,117,134,18,101,1,122,93,192,247,157,33,237,74,255,211,127,245,44,203,75,12,187,142,178,74,185,240,173,113,51,12,69,90,187,171,83,247,186,169,157,31,121,154,18,206,152,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf4ac696-3045-4224-8196-29e9ed1c351b"));
		}

		#endregion

	}

	#endregion

}

