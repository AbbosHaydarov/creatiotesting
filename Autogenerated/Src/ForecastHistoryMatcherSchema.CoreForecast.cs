﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryMatcherSchema

	/// <exclude/>
	public class ForecastHistoryMatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryMatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryMatcherSchema(ForecastHistoryMatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2663de06-d978-7844-8986-9c48b9483ba2");
			Name = "ForecastHistoryMatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,237,150,207,111,218,48,20,199,207,169,212,255,225,141,73,85,144,170,32,237,216,2,83,215,142,14,169,213,166,130,122,153,118,112,147,23,176,230,216,204,118,168,208,180,255,125,182,227,132,64,146,178,170,219,46,91,15,20,236,175,223,79,127,94,194,73,134,106,69,98,132,57,74,73,148,72,117,116,41,120,74,23,185,36,154,10,30,77,132,196,152,40,125,255,230,248,232,251,241,81,144,43,202,23,48,219,40,141,153,145,50,134,177,213,169,232,26,57,74,26,159,239,107,110,40,255,182,93,172,187,145,24,77,72,172,133,164,168,140,194,104,94,75,92,24,99,48,229,26,101,106,194,58,131,105,25,192,7,170,140,116,115,75,116,188,68,233,228,131,193,0,134,42,207,50,34,55,99,255,251,147,20,107,154,160,130,12,245,82,36,10,180,128,140,124,69,72,189,29,80,156,172,212,82,104,21,149,38,6,53,27,171,252,129,209,24,104,25,65,119,0,129,45,71,35,6,183,224,52,160,37,34,104,242,192,16,18,162,137,117,215,244,87,172,172,136,36,25,112,211,141,81,143,97,170,183,133,237,141,231,75,52,25,152,90,74,136,171,101,155,86,44,50,115,14,35,99,208,157,111,55,39,233,98,217,176,167,24,89,227,47,155,147,168,115,201,213,120,168,76,66,177,196,116,212,155,45,17,117,111,48,30,14,202,77,171,158,190,231,121,134,210,166,60,244,229,154,155,34,204,237,194,149,41,193,212,92,136,113,81,157,176,174,109,17,237,86,225,212,90,15,14,28,217,203,180,95,220,169,39,59,228,154,99,202,144,103,92,253,139,77,114,21,188,116,249,183,246,165,190,125,176,35,117,113,75,47,130,31,5,227,200,147,2,243,29,228,47,25,81,234,12,74,216,102,30,210,91,194,201,226,217,184,219,222,86,188,219,182,2,225,9,20,69,0,2,9,77,211,86,248,11,15,136,132,41,225,107,216,129,127,15,6,246,192,231,43,76,73,206,244,59,202,19,51,222,66,189,89,161,72,195,142,67,253,254,151,237,132,137,109,194,208,46,60,123,122,234,216,210,151,117,187,45,242,62,51,149,160,107,162,177,216,93,21,63,96,45,104,2,19,202,88,209,151,123,194,114,84,97,23,154,192,241,241,78,60,158,66,115,199,54,223,126,41,218,222,220,119,253,182,223,250,224,198,98,80,152,138,234,126,97,100,29,192,141,241,94,77,7,119,103,144,177,113,232,174,72,16,216,182,17,211,190,176,218,170,124,215,108,153,249,92,45,239,248,40,221,7,107,34,173,55,103,160,240,187,239,50,108,177,235,131,112,167,171,148,234,126,71,219,229,183,59,142,163,9,149,74,127,148,254,66,132,241,26,70,14,55,243,23,175,189,116,154,192,104,212,150,207,118,255,228,4,140,252,90,138,124,213,173,246,219,101,180,52,133,176,53,218,87,38,243,156,177,170,40,182,43,54,245,232,34,214,57,97,141,148,234,62,220,167,119,96,200,13,218,123,26,93,36,73,232,173,250,112,156,184,96,125,31,246,150,91,235,96,56,60,168,255,206,163,20,60,26,52,38,172,255,155,71,54,132,69,209,251,47,153,221,126,118,252,225,231,236,115,31,180,254,122,57,104,196,99,43,231,13,35,77,222,59,103,78,9,123,211,99,73,185,185,149,123,144,239,27,171,96,47,153,177,129,150,151,215,28,111,5,191,68,99,235,120,159,114,234,84,99,176,255,163,59,140,133,76,118,169,173,22,91,89,181,202,6,160,22,49,159,198,76,219,33,62,130,250,207,232,10,25,106,76,118,209,108,204,248,114,148,87,131,187,54,162,107,156,6,254,161,104,203,113,94,3,247,255,75,211,240,16,120,47,120,119,234,182,211,129,150,239,82,133,85,253,140,39,169,125,226,182,189,115,153,181,159,161,189,162,167,248,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2663de06-d978-7844-8986-9c48b9483ba2"));
		}

		#endregion

	}

	#endregion

}

