namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationConfigureServiceSchema

	/// <exclude/>
	public class ITranslationConfigureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationConfigureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationConfigureServiceSchema(ITranslationConfigureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2811bd82-3edc-4fba-a9ab-749eda63fb70");
			Name = "ITranslationConfigureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,75,75,195,64,16,62,167,208,255,176,196,75,11,37,185,107,237,65,65,169,80,43,77,161,135,226,97,155,76,98,48,217,141,59,187,133,32,254,119,103,179,217,62,40,84,47,73,246,203,124,143,157,25,193,107,192,134,167,192,214,160,20,71,153,235,232,81,138,188,44,140,226,186,148,34,90,43,46,176,234,190,135,131,239,225,32,48,88,138,130,37,45,106,168,163,4,212,190,76,97,33,51,168,238,174,253,140,54,176,163,2,42,185,81,80,144,24,155,11,13,42,39,235,91,54,63,49,241,238,208,179,59,78,28,199,108,138,166,174,185,106,103,253,153,76,78,104,44,149,142,198,208,241,34,79,139,79,120,219,94,148,76,180,226,169,30,189,210,253,217,61,11,175,4,8,199,239,196,108,204,174,42,83,86,250,208,127,100,14,168,83,244,188,8,222,1,207,160,209,199,63,164,175,76,45,144,222,189,146,141,127,153,223,33,10,180,81,2,103,83,4,96,169,130,252,254,60,127,39,117,200,148,173,104,194,82,32,132,241,108,26,123,174,21,219,46,27,112,83,246,253,176,55,13,182,52,170,185,216,203,79,24,45,64,127,200,204,54,232,109,153,172,195,9,91,193,151,1,212,79,82,213,92,19,78,165,11,64,228,5,56,40,122,65,41,38,236,65,102,109,162,219,202,246,246,88,114,64,163,141,226,77,3,217,196,218,5,62,223,117,209,110,10,193,127,238,105,251,123,68,207,215,164,39,141,198,110,23,127,220,70,130,200,220,82,218,35,97,191,10,4,116,11,22,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2811bd82-3edc-4fba-a9ab-749eda63fb70"));
		}

		#endregion

	}

	#endregion

}

