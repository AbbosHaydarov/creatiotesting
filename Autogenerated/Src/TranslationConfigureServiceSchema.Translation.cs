﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationConfigureServiceSchema

	/// <exclude/>
	public class TranslationConfigureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationConfigureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationConfigureServiceSchema(TranslationConfigureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53f3ae78-0e82-479a-84e5-de5828e991cf");
			Name = "TranslationConfigureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,85,77,111,218,64,16,61,59,82,254,195,200,189,128,132,204,157,0,18,165,105,132,20,162,10,168,122,136,122,88,214,3,89,201,94,59,187,107,90,26,229,191,119,118,109,99,27,176,147,11,98,231,227,205,199,123,12,146,197,168,83,198,17,54,168,20,211,201,206,4,243,68,238,196,62,83,204,136,68,6,27,197,164,142,220,247,219,155,183,219,27,47,211,66,238,97,125,212,6,227,187,179,55,229,70,17,114,27,172,131,7,148,168,4,191,136,121,20,242,245,194,184,202,164,17,49,6,107,74,97,145,248,231,10,94,68,145,247,32,56,46,147,16,163,96,70,117,14,103,113,245,41,20,6,223,25,55,137,18,168,175,69,252,194,45,69,197,177,203,39,255,23,133,123,2,131,121,196,180,30,65,109,240,162,172,139,122,158,233,244,9,13,37,166,228,219,138,72,152,227,10,95,51,161,48,70,105,116,175,254,176,141,194,4,62,72,177,81,65,97,8,251,191,169,72,154,109,35,193,129,219,78,234,141,148,212,96,209,17,140,224,43,211,229,107,0,139,142,88,130,37,250,232,243,52,232,18,205,75,18,210,168,63,148,93,100,62,159,151,230,15,88,220,203,44,70,197,182,17,142,27,176,81,22,87,224,83,120,64,67,236,92,68,232,83,72,216,235,131,21,142,231,29,152,2,211,26,200,136,42,90,150,91,127,78,220,145,52,100,198,139,78,120,155,53,237,57,120,79,226,31,32,187,54,42,179,233,51,181,167,9,164,233,249,153,70,69,14,153,75,211,31,192,207,134,161,223,183,250,240,60,133,38,83,242,131,22,109,79,221,211,58,176,247,98,215,40,195,124,221,109,187,119,84,231,206,225,112,8,99,157,197,49,83,199,105,101,64,4,174,112,55,241,187,232,245,135,85,198,176,142,81,104,169,171,229,21,221,0,90,27,90,46,43,235,213,181,55,184,84,101,222,4,236,234,63,83,162,216,142,103,212,177,0,162,173,231,174,160,145,68,152,159,81,86,176,73,30,133,54,37,236,59,112,102,248,75,239,254,47,199,212,166,0,246,47,234,84,206,9,96,145,87,231,191,12,236,224,49,183,158,25,219,15,72,235,58,92,222,57,237,246,125,162,132,39,146,244,200,13,236,232,215,193,11,128,226,36,214,42,144,203,149,8,74,188,186,6,158,191,49,195,230,5,80,247,125,105,83,198,8,26,127,11,235,92,116,213,24,246,182,180,8,184,145,8,33,181,50,168,139,186,253,182,144,164,237,56,87,52,237,6,90,98,188,69,213,123,162,191,48,34,210,111,244,238,187,51,90,206,105,21,210,121,195,154,202,123,131,61,154,59,208,246,195,10,227,26,217,100,251,15,131,15,160,222,60,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53f3ae78-0e82-479a-84e5-de5828e991cf"));
		}

		#endregion

	}

	#endregion

}

