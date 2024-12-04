﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeEventsProcessorSchema

	/// <exclude/>
	public class ExchangeEventsProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeEventsProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeEventsProcessorSchema(ExchangeEventsProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5918b317-f3eb-4f95-90fb-5f4a75c9d44e");
			Name = "ExchangeEventsProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,86,209,110,219,58,12,125,206,128,253,3,225,189,184,128,225,188,119,141,135,172,203,186,0,91,49,32,237,6,220,139,251,160,216,116,162,205,150,60,73,78,155,14,249,247,81,146,147,216,137,221,91,96,47,129,45,145,135,135,228,33,29,16,172,68,93,177,20,225,14,149,98,90,230,38,190,150,34,231,171,90,49,195,165,120,253,234,247,235,87,163,90,115,177,130,197,86,27,44,223,158,188,147,125,81,96,106,141,117,124,131,2,21,79,143,54,115,97,112,229,161,166,21,143,103,37,227,197,241,182,29,180,44,165,232,191,81,56,116,30,127,100,169,145,138,163,238,179,248,142,203,248,147,49,85,60,93,106,163,152,167,72,134,100,250,70,225,138,222,224,186,96,90,95,194,236,49,93,51,177,194,217,6,133,209,95,149,76,81,107,169,156,233,120,60,134,43,93,151,37,83,219,164,121,119,110,80,41,185,225,25,106,40,209,172,101,166,33,151,10,176,129,2,116,88,214,200,130,17,179,120,15,54,110,161,253,251,1,115,86,23,230,61,23,25,217,132,102,91,161,204,195,249,0,163,139,8,110,169,101,48,129,96,192,34,184,248,143,96,171,122,89,240,20,82,199,115,192,18,46,225,61,211,232,90,114,114,21,193,16,1,194,38,65,208,239,177,132,84,84,163,106,219,7,170,228,87,23,216,91,52,36,6,144,194,105,85,145,175,240,210,1,214,126,187,32,110,102,205,117,216,57,141,192,118,147,222,13,62,26,215,217,230,121,154,54,213,1,43,214,209,206,135,63,109,156,59,152,11,110,56,43,248,19,130,192,7,224,196,157,9,146,191,204,201,22,17,82,133,249,100,176,182,48,78,108,23,207,219,232,79,42,166,88,9,118,166,38,65,135,121,144,180,192,59,121,7,227,228,64,34,190,26,59,132,228,239,138,71,205,235,169,13,176,125,145,46,97,73,109,63,45,45,235,173,225,27,20,153,239,115,183,233,95,188,226,169,223,74,26,130,192,236,153,154,47,12,83,52,9,104,133,166,65,111,69,186,86,82,240,39,183,21,94,90,207,90,163,26,40,232,125,247,106,168,162,103,144,238,25,13,42,29,36,139,46,43,56,222,117,187,178,79,23,54,92,153,154,21,176,145,60,243,25,158,64,132,93,90,208,77,128,154,244,129,187,39,202,248,138,6,136,134,63,2,185,252,65,215,73,43,122,211,142,209,55,210,108,198,140,215,65,120,138,213,178,183,139,112,52,58,89,147,119,76,255,212,238,55,118,84,111,241,225,59,55,235,46,195,171,131,214,14,27,97,246,136,105,77,131,253,44,219,36,60,13,255,98,241,180,150,69,175,114,26,189,211,138,181,195,122,92,173,150,160,95,176,7,249,92,43,164,242,232,222,41,62,203,167,173,17,96,34,35,104,123,65,238,15,84,150,70,37,132,177,215,158,224,191,106,156,103,228,246,82,185,226,33,102,144,220,14,113,239,153,119,39,167,38,109,242,115,212,195,243,68,60,140,123,220,43,100,195,148,211,88,243,125,56,26,196,244,157,158,102,37,23,247,180,251,236,173,151,200,77,77,145,172,209,82,62,90,233,46,208,24,106,171,158,103,228,109,203,109,13,194,22,204,60,107,196,181,143,212,18,247,164,169,127,87,81,78,167,54,98,212,166,115,199,75,252,71,10,170,103,212,31,191,9,227,101,6,154,84,132,202,165,62,205,72,79,244,65,155,192,13,154,47,222,181,57,59,27,137,231,144,109,2,71,205,54,233,62,51,142,190,192,163,223,16,44,206,200,4,81,31,195,93,116,112,153,211,127,164,121,102,237,90,53,184,111,20,165,219,150,238,202,86,135,132,89,86,93,135,195,29,205,111,89,1,77,24,249,236,124,58,70,109,247,20,123,23,209,255,110,139,29,228,92,176,162,56,192,116,61,222,197,215,133,164,47,198,194,254,143,145,98,38,50,63,193,241,103,185,146,181,137,32,103,133,198,61,214,240,2,240,167,221,195,221,31,44,167,221,148,131,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5918b317-f3eb-4f95-90fb-5f4a75c9d44e"));
		}

		#endregion

	}

	#endregion

}

