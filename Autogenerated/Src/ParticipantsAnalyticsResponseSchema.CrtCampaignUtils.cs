namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsResponseSchema

	/// <exclude/>
	public class ParticipantsAnalyticsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsResponseSchema(ParticipantsAnalyticsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f53c9ec6-85b8-4636-8f98-86f86c8b298c");
			Name = "ParticipantsAnalyticsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,146,77,75,3,65,12,134,207,21,252,15,161,94,244,178,123,215,90,144,42,165,160,34,234,77,60,164,179,217,53,48,51,187,206,135,82,165,255,221,204,110,183,244,195,15,188,12,188,147,76,242,228,205,88,52,228,27,84,4,143,228,28,250,186,12,217,164,182,37,87,209,97,224,218,30,30,124,30,30,12,162,103,91,193,195,194,7,50,103,59,90,242,181,38,149,146,125,54,37,75,142,213,94,206,125,180,129,13,101,15,18,69,205,31,109,109,201,146,188,35,71,149,8,152,104,244,254,20,238,208,5,86,220,160,13,254,194,162,94,136,242,247,2,41,229,169,125,144,231,57,140,124,52,6,221,98,188,210,125,2,148,181,131,117,14,17,40,71,229,249,112,130,166,65,174,172,180,127,99,69,217,174,158,82,248,182,239,241,15,52,175,145,124,56,25,230,227,108,213,75,60,11,200,214,3,91,33,48,237,120,128,243,58,6,104,54,74,0,106,93,171,46,202,22,8,213,11,168,21,11,112,50,170,103,207,55,6,124,186,196,128,169,131,67,21,158,229,162,137,115,205,10,84,114,236,47,195,6,178,63,57,215,54,223,185,186,33,121,65,201,235,182,78,23,223,117,181,27,107,205,86,144,44,176,100,114,137,112,31,177,99,188,33,51,39,119,124,43,159,10,206,97,216,79,54,43,134,39,9,187,231,158,70,46,214,165,103,5,164,31,54,24,84,20,206,192,203,145,212,242,23,168,107,246,1,234,114,219,56,15,239,47,156,220,236,23,177,105,251,63,152,177,119,112,150,138,110,115,207,174,108,52,228,112,174,105,244,173,235,233,205,24,182,164,255,101,186,35,178,69,183,149,86,119,183,219,151,203,47,1,230,49,195,161,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f53c9ec6-85b8-4636-8f98-86f86c8b298c"));
		}

		#endregion

	}

	#endregion

}

