namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsItemSchema

	/// <exclude/>
	public class ParticipantsAnalyticsItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsItemSchema(ParticipantsAnalyticsItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f63154a0-be3b-4482-959d-f99cde09a649");
			Name = "ParticipantsAnalyticsItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,197,84,77,111,219,48,12,61,167,64,255,3,145,30,182,94,236,251,218,14,24,220,98,235,97,69,176,244,54,236,160,200,180,67,192,250,152,40,97,200,134,254,247,81,246,18,184,31,49,226,211,46,50,72,63,61,190,71,74,178,202,32,123,165,17,30,49,4,197,174,137,69,229,108,67,109,10,42,146,179,231,103,127,206,207,22,137,201,182,176,222,113,68,115,245,34,46,190,37,27,201,96,177,198,64,170,163,223,253,62,65,9,238,34,96,43,1,84,157,98,254,0,43,21,34,105,242,202,70,254,100,85,183,147,136,239,133,163,7,151,101,9,215,156,140,81,97,247,241,95,124,139,172,3,109,144,193,38,35,252,90,117,64,182,150,111,116,129,161,113,65,66,33,128,95,20,183,178,27,17,116,192,230,102,153,89,239,235,101,185,39,186,46,71,204,223,111,85,84,98,51,6,165,227,15,73,248,180,233,72,131,206,50,167,84,46,164,25,178,30,124,173,130,243,40,104,204,230,122,142,225,255,75,43,125,162,82,198,43,106,45,80,22,76,53,74,219,26,194,80,28,118,140,53,14,34,191,162,217,96,120,255,32,99,130,27,88,210,224,234,50,107,222,139,254,156,168,134,193,46,228,89,45,22,45,198,43,96,89,114,244,52,161,104,236,20,180,147,57,190,234,227,94,244,8,90,172,35,250,202,25,223,97,196,220,98,32,6,252,153,100,52,49,36,156,97,71,239,73,198,66,170,172,227,185,69,25,49,84,71,177,255,221,117,163,58,158,99,219,58,91,205,112,254,48,5,159,48,255,86,105,185,228,46,156,80,243,238,77,220,204,98,62,56,141,156,159,138,19,42,174,142,131,103,150,229,196,30,109,125,82,111,215,71,177,115,79,213,163,139,114,20,252,235,179,213,4,103,32,110,241,112,255,223,49,116,174,157,113,94,182,196,242,218,237,78,176,243,229,8,114,194,204,133,216,31,94,179,62,30,178,207,147,79,127,1,157,205,168,163,38,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f63154a0-be3b-4482-959d-f99cde09a649"));
		}

		#endregion

	}

	#endregion

}

