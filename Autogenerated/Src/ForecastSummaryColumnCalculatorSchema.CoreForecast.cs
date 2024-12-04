﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSummaryColumnCalculatorSchema

	/// <exclude/>
	public class ForecastSummaryColumnCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSummaryColumnCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSummaryColumnCalculatorSchema(ForecastSummaryColumnCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a035b29-b568-4d05-9c8e-eedb85b87ce2");
			Name = "ForecastSummaryColumnCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,89,221,111,219,54,16,127,118,129,253,15,172,87,108,10,96,40,197,30,155,196,69,154,38,157,129,110,43,210,180,123,40,138,64,181,232,88,152,44,121,36,149,46,205,252,191,239,142,228,81,36,37,217,94,191,94,130,152,228,29,143,191,251,62,85,217,138,203,117,54,231,236,138,11,145,201,122,161,210,179,186,90,20,55,141,200,84,81,87,233,69,45,248,60,147,234,237,47,63,60,184,255,225,193,168,145,69,117,195,94,223,73,197,87,71,209,111,32,45,75,62,71,58,153,190,224,21,23,197,188,115,230,101,81,253,221,46,250,215,174,86,117,213,191,35,248,208,122,122,145,205,85,45,10,46,225,4,156,249,81,240,27,184,158,205,42,197,197,2,30,246,132,205,232,9,175,155,213,42,19,119,32,100,179,170,206,178,114,222,148,25,208,106,186,195,195,67,118,44,205,129,169,253,77,116,204,174,179,185,166,148,108,238,104,83,34,61,244,104,215,205,135,178,152,179,130,68,216,67,130,17,66,219,17,66,47,156,230,185,236,72,160,106,182,32,233,156,84,14,124,148,170,43,150,89,89,103,34,91,177,10,244,126,50,110,36,23,160,237,202,80,141,167,111,224,55,176,161,133,244,248,80,159,238,39,182,215,142,167,14,38,187,210,37,19,92,53,162,146,157,147,236,99,161,150,241,219,128,156,206,35,131,219,186,200,217,233,122,93,222,5,224,201,228,77,32,60,11,223,50,97,179,214,22,143,175,178,15,37,55,116,83,186,230,192,216,203,62,152,243,178,148,44,207,84,134,176,243,127,10,169,208,14,225,41,181,200,127,150,150,33,187,205,202,134,203,239,2,61,169,126,150,123,232,23,57,175,84,177,40,184,216,78,108,228,6,189,105,84,236,51,66,165,117,48,127,14,143,223,5,248,139,6,136,90,201,64,3,231,85,179,226,2,111,57,190,18,156,235,251,144,211,12,194,192,148,46,70,61,140,54,198,119,121,149,27,247,13,92,249,172,204,164,124,194,190,183,23,191,123,206,23,89,83,170,103,69,149,131,190,19,117,183,230,245,34,217,229,203,7,7,239,219,16,48,71,209,119,73,206,158,236,25,32,80,53,14,20,8,177,42,171,20,0,243,74,20,183,153,226,102,127,109,126,160,41,225,147,149,208,145,151,184,230,156,157,176,177,125,228,248,104,144,32,18,7,126,174,64,144,11,158,129,95,106,22,253,7,144,163,22,50,84,164,19,250,162,224,101,62,36,113,100,94,215,161,125,237,224,252,74,212,107,46,20,164,1,228,94,43,32,226,121,200,223,97,108,192,189,228,235,90,22,128,237,29,187,158,71,43,22,24,203,102,11,101,103,225,68,251,207,168,195,145,61,125,202,146,238,234,137,49,110,147,195,238,32,101,170,227,193,203,166,137,102,61,170,248,71,163,125,209,32,213,169,184,1,47,171,84,18,135,148,73,12,225,193,1,197,60,31,18,212,27,217,71,107,146,215,139,129,157,30,104,250,57,12,110,16,68,67,55,24,168,6,119,7,32,235,61,252,13,32,179,87,189,81,69,89,160,185,57,164,220,74,132,80,135,160,179,16,1,210,110,248,64,120,199,187,0,196,44,167,137,147,123,47,135,209,193,202,190,211,4,46,63,118,135,6,57,117,193,193,38,98,118,207,110,184,58,98,18,255,108,182,223,250,27,87,203,122,48,2,228,53,92,206,25,234,207,240,182,10,77,130,76,162,115,57,164,100,202,228,111,117,222,157,68,98,217,205,9,69,180,69,83,105,141,98,12,60,96,186,218,26,221,102,194,36,247,171,26,239,4,100,1,76,100,45,159,217,8,156,132,87,152,95,58,99,141,70,166,72,49,210,26,154,11,123,71,226,95,54,241,175,48,164,155,240,217,58,219,226,174,85,99,248,246,129,103,237,3,137,49,254,129,147,54,9,104,209,125,64,72,118,105,224,160,208,79,171,73,128,1,166,251,108,190,100,9,237,207,170,5,84,166,254,143,162,106,89,210,61,163,232,81,120,192,254,107,116,160,255,239,1,20,57,218,171,71,26,49,2,26,94,17,233,202,127,223,196,187,193,252,79,204,82,226,96,185,110,122,244,19,248,130,71,59,237,197,167,87,95,62,192,224,39,88,63,34,190,102,19,93,216,234,220,110,145,67,219,223,224,206,71,173,126,204,22,80,19,163,212,154,138,126,57,6,13,183,225,86,48,0,90,158,88,124,189,123,252,254,168,87,225,113,32,65,209,218,167,217,171,67,251,119,228,219,77,219,87,212,94,238,188,135,217,78,118,24,211,196,127,179,19,148,116,225,152,250,60,141,253,81,34,65,97,135,236,200,162,208,19,94,128,7,253,52,26,176,39,91,70,206,234,164,222,255,45,91,163,58,183,238,91,37,62,47,244,58,156,59,54,55,79,108,212,116,54,98,131,168,238,70,48,87,116,130,105,8,115,159,99,232,24,185,135,208,239,124,130,247,112,153,190,180,207,14,6,148,137,194,121,88,203,164,211,67,116,250,6,219,54,4,14,229,113,0,33,94,9,14,157,12,15,248,90,162,40,104,233,248,111,140,6,162,84,148,214,92,172,42,22,44,153,201,32,54,83,16,116,103,70,131,225,155,226,181,145,0,7,36,3,49,138,194,218,134,241,82,114,199,248,179,172,52,136,209,161,18,223,14,218,69,175,132,36,190,243,95,106,59,48,232,56,145,219,208,169,209,138,144,76,79,171,187,24,193,22,58,47,166,161,76,175,176,9,69,53,122,33,203,74,104,183,8,25,186,101,150,163,195,181,54,99,183,47,235,143,196,230,221,123,168,81,240,159,174,53,17,179,145,230,98,33,104,153,140,46,245,138,191,73,43,238,136,15,88,232,198,210,30,217,24,104,70,27,139,23,98,20,21,154,24,104,1,34,211,96,157,87,40,99,158,108,237,194,60,227,235,192,135,67,59,92,185,228,178,46,111,97,176,112,194,18,155,20,160,218,164,252,16,228,141,80,151,163,161,138,58,245,12,157,12,167,115,61,241,138,28,179,43,38,234,40,189,40,132,84,201,65,96,120,233,85,253,18,198,44,20,211,52,98,15,191,38,100,190,104,233,159,75,46,120,2,245,31,228,32,43,134,142,227,15,79,216,163,241,61,45,205,242,205,53,252,120,33,234,102,141,219,155,241,1,153,0,226,125,14,33,165,135,7,36,121,173,141,118,201,212,230,177,223,216,108,234,203,213,23,72,17,21,63,130,246,5,187,207,136,153,232,28,17,107,194,62,118,102,247,84,91,175,77,9,211,0,82,24,160,37,218,227,92,248,34,228,181,47,217,194,167,245,162,0,49,196,43,28,132,32,108,54,168,133,20,253,220,156,142,96,211,155,125,184,208,48,232,212,86,47,84,12,134,149,206,46,221,180,179,147,30,233,183,150,133,246,2,52,54,243,20,109,95,215,247,158,236,155,241,255,200,171,157,54,230,243,27,168,225,94,201,39,38,23,210,185,201,180,179,35,252,225,121,66,250,90,101,66,201,63,97,226,155,56,133,129,159,191,214,168,129,83,132,96,123,119,245,61,60,146,181,175,103,232,109,73,130,231,104,138,63,160,13,206,170,220,47,218,236,146,11,77,70,48,93,155,24,26,109,58,104,222,184,102,95,99,137,76,130,245,235,117,191,183,233,56,19,94,240,135,176,147,70,10,31,200,158,240,157,129,219,62,125,106,16,85,75,81,127,212,247,210,4,227,252,159,57,95,235,215,62,26,211,123,217,189,123,8,45,25,161,54,108,153,185,105,117,102,57,48,181,204,20,212,144,144,187,170,90,153,233,118,58,238,150,248,70,226,62,85,180,46,30,213,36,67,70,103,106,148,173,214,102,93,137,60,110,239,224,208,53,33,171,67,107,153,122,45,8,207,109,194,118,139,189,77,250,135,186,46,89,92,6,110,125,67,216,195,125,73,219,167,239,198,105,181,57,126,74,82,0,171,47,207,137,236,223,127,109,252,166,174,17,6,177,51,170,10,67,64,141,220,87,48,8,55,38,218,190,31,170,66,87,117,24,41,237,169,159,126,234,147,220,71,120,143,89,81,52,207,165,209,218,109,33,84,147,149,193,220,40,154,196,120,237,153,25,198,108,51,74,103,125,240,89,10,251,3,162,130,40,245,102,13,238,13,65,138,210,24,188,154,247,23,197,79,108,146,9,140,16,214,67,19,12,106,174,1,102,167,183,55,189,204,78,161,162,203,110,248,22,134,185,137,39,17,245,227,238,136,99,55,246,222,104,80,127,33,41,42,136,244,133,202,107,248,184,33,248,226,100,188,235,211,69,218,243,237,110,124,56,245,102,141,223,236,11,159,85,86,228,34,103,75,62,255,139,2,232,239,13,4,42,252,46,6,95,118,226,209,175,129,11,75,79,250,50,57,147,231,171,181,186,75,208,105,220,231,74,236,110,92,221,103,66,138,151,183,91,147,49,90,240,116,16,20,98,148,33,218,162,201,172,88,226,193,98,230,44,211,241,31,246,186,145,224,101,13,174,87,124,66,110,54,203,186,239,54,47,231,159,176,57,104,196,156,75,24,123,143,93,161,175,185,141,169,202,58,91,22,37,24,72,213,45,17,13,212,137,41,129,109,99,99,222,243,129,230,194,20,232,100,122,94,114,4,251,84,37,143,161,206,183,60,163,102,220,127,116,219,148,183,236,130,126,252,33,85,16,242,87,248,236,217,45,235,109,21,101,111,138,170,209,0,88,31,65,42,190,204,130,215,224,153,58,190,45,205,220,86,88,126,82,187,215,87,223,59,107,1,81,2,41,131,108,243,21,92,12,139,254,29,254,245,45,191,230,126,21,159,163,111,210,131,100,116,155,231,163,68,227,124,116,139,227,69,89,179,227,60,189,157,15,14,77,162,79,114,169,75,225,122,56,106,177,138,199,76,67,253,24,218,119,4,155,169,75,173,98,121,78,237,89,103,78,230,43,38,152,109,89,232,194,102,26,108,238,50,171,48,99,132,156,123,102,222,81,66,232,251,46,15,107,255,1,228,101,219,201,54,36,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a035b29-b568-4d05-9c8e-eedb85b87ce2"));
		}

		#endregion

	}

	#endregion

}

