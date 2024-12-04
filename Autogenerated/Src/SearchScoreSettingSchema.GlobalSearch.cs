namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SearchScoreSettingSchema

	/// <exclude/>
	public class SearchScoreSettingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SearchScoreSettingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SearchScoreSettingSchema(SearchScoreSettingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f808b42-28b6-4954-82ef-e995b5076254");
			Name = "SearchScoreSetting";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,81,205,106,195,48,12,62,39,144,119,16,61,109,48,146,7,88,215,203,126,10,61,148,177,12,118,24,59,120,174,146,26,18,59,72,10,37,140,190,251,228,36,29,43,101,135,29,140,45,125,250,126,108,123,211,34,119,198,34,188,34,145,225,80,73,126,31,124,229,234,158,140,184,224,225,43,75,179,52,233,217,249,26,202,129,5,91,29,104,26,180,17,229,124,141,30,201,217,219,159,153,45,30,68,129,40,180,225,224,21,80,168,40,10,88,114,223,182,134,134,213,92,191,96,71,200,232,133,1,27,195,226,44,48,26,178,123,96,27,8,181,16,81,65,206,79,252,226,151,64,215,127,54,74,176,74,100,40,71,90,25,89,229,68,210,9,205,157,92,248,142,141,71,47,78,6,56,160,171,247,18,213,47,229,147,247,152,253,153,66,135,36,195,213,233,176,213,215,130,59,88,76,212,197,245,71,28,157,163,56,47,240,54,246,227,91,36,127,186,63,57,108,118,124,118,187,127,251,87,163,198,185,255,131,27,127,68,5,150,44,164,210,55,48,237,171,217,50,198,58,234,202,210,227,55,198,3,250,128,246,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f808b42-28b6-4954-82ef-e995b5076254"));
		}

		#endregion

	}

	#endregion

}

