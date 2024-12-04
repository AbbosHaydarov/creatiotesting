namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsRequestSchema

	/// <exclude/>
	public class ParticipantsAnalyticsRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsRequestSchema(ParticipantsAnalyticsRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80");
			Name = "ParticipantsAnalyticsRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,84,77,111,219,48,12,61,167,64,255,3,145,93,218,139,115,95,63,128,34,69,63,14,27,138,166,59,13,59,48,50,237,16,144,37,87,162,55,100,67,255,251,40,59,78,226,180,107,97,96,23,35,20,159,200,247,158,200,56,172,40,214,104,8,158,40,4,140,190,144,108,238,93,193,101,19,80,216,187,227,163,63,199,71,147,38,178,43,97,177,142,66,213,217,65,156,61,54,78,184,162,108,65,129,209,242,239,246,158,162,20,247,41,80,169,1,204,45,198,248,25,30,48,8,27,174,209,73,188,114,104,215,26,197,71,122,110,40,74,139,159,205,102,112,30,155,170,194,176,190,220,196,155,60,212,24,148,172,80,128,194,135,45,150,8,76,160,226,98,58,199,170,70,46,157,178,248,201,134,178,195,248,150,228,205,246,39,239,145,58,157,206,46,179,77,47,181,69,144,93,220,17,137,137,9,24,180,166,177,40,20,245,103,215,51,65,182,53,1,251,162,125,165,243,217,158,196,239,215,40,152,106,7,52,242,67,15,234,102,105,217,128,73,150,125,224,216,68,223,70,191,91,155,31,130,175,73,47,80,242,186,45,211,229,15,109,237,244,244,100,57,39,125,192,130,59,103,225,215,138,205,106,168,192,17,229,113,39,116,168,232,181,164,78,211,23,170,150,20,78,190,170,87,112,1,211,222,155,251,124,122,154,100,246,58,111,27,206,183,92,238,115,72,227,54,153,148,36,103,16,245,147,162,151,119,84,44,68,137,66,193,54,13,70,142,235,17,140,186,75,109,1,205,210,144,86,58,121,210,169,134,155,33,106,44,191,235,134,118,236,132,70,211,211,251,31,146,219,96,198,82,187,177,88,130,172,80,128,93,206,166,157,224,38,210,254,82,29,136,215,109,208,183,207,95,35,122,150,154,31,110,68,223,43,10,138,254,91,232,200,180,51,38,43,210,57,243,150,64,231,149,125,62,194,22,101,152,164,119,125,227,208,151,165,247,22,190,13,0,240,95,76,193,146,192,23,187,253,182,190,76,207,137,227,120,223,113,20,31,214,41,249,54,239,61,192,63,121,111,54,158,92,222,45,125,27,119,138,134,135,47,127,1,166,14,228,254,220,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80"));
		}

		#endregion

	}

	#endregion

}

