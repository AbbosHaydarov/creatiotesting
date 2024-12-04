namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateBasedSyncStrategySchema

	/// <exclude/>
	public class DateBasedSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateBasedSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateBasedSyncStrategySchema(DateBasedSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9268c52e-f894-4e71-8c25-639c288db644");
			Name = "DateBasedSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,85,223,79,219,48,16,126,14,18,255,195,173,188,180,82,73,209,196,246,0,43,18,180,5,85,162,133,53,101,47,211,132,76,114,41,214,28,59,178,29,32,67,253,223,119,110,82,218,132,70,99,125,72,227,251,241,249,238,187,207,142,100,9,154,148,133,8,115,212,154,25,21,91,127,194,184,216,223,123,221,223,243,50,195,229,2,130,220,88,76,78,107,107,255,74,168,7,38,248,31,102,185,146,27,239,6,103,160,146,164,201,163,177,201,238,143,164,229,150,163,105,12,184,100,161,85,186,136,160,152,3,141,11,170,0,6,130,25,115,2,67,102,241,130,25,140,130,92,134,129,213,180,92,228,171,192,94,175,7,223,76,150,36,76,231,103,111,107,68,8,53,198,253,214,120,59,161,213,59,3,158,164,2,19,148,150,113,171,100,23,34,20,252,9,53,70,16,107,149,108,167,214,50,253,53,120,175,190,155,70,90,254,54,235,245,206,90,33,35,3,88,5,6,5,134,22,152,16,32,149,61,140,52,139,109,183,120,37,143,165,32,154,157,97,11,52,221,18,143,216,162,73,110,21,182,115,3,255,158,152,178,206,226,220,149,122,183,234,251,57,196,152,101,194,94,112,25,209,16,218,54,79,81,197,237,10,75,157,46,76,73,64,208,135,221,59,181,58,191,8,41,205,30,4,15,33,116,243,105,104,249,4,170,211,242,72,125,244,124,155,237,173,86,41,106,155,159,184,55,75,172,96,84,4,212,103,186,50,4,200,116,248,8,248,146,106,34,200,229,147,94,83,65,216,174,211,247,163,241,210,53,40,60,113,109,51,38,192,88,237,148,119,39,13,213,53,49,139,2,242,123,134,58,7,119,50,60,111,129,182,124,243,52,218,76,75,104,221,77,135,179,243,203,57,208,255,232,122,52,31,13,33,24,79,7,35,120,61,90,182,156,154,61,111,233,158,203,178,55,148,81,209,94,181,215,129,146,180,123,230,52,78,114,190,93,145,87,68,148,68,238,164,176,125,103,80,83,170,164,62,28,74,86,89,118,97,117,170,114,112,237,4,104,45,53,103,58,101,253,60,134,246,182,29,250,125,144,153,16,43,255,1,121,63,77,71,243,96,126,62,29,158,207,134,159,239,143,128,248,155,223,12,111,96,48,155,28,30,127,254,114,252,181,160,193,62,106,245,12,18,159,97,156,176,116,244,18,98,234,246,110,59,203,181,10,87,119,197,131,64,170,216,233,169,90,160,63,67,163,50,29,146,87,105,146,116,183,73,81,78,234,238,215,122,135,104,124,50,77,213,186,11,255,7,19,25,182,58,254,92,149,59,118,58,52,132,3,20,6,235,245,78,149,29,175,15,59,70,155,202,139,4,210,127,188,153,158,87,35,186,95,163,186,24,116,80,225,179,66,251,233,7,52,48,65,251,168,162,218,248,43,90,111,186,184,252,43,180,187,84,75,199,188,166,249,66,76,138,110,52,205,35,92,43,190,33,189,189,22,203,19,211,69,55,238,170,113,35,162,238,40,39,216,54,173,120,219,156,11,114,95,210,39,197,237,84,3,173,0,117,182,137,249,112,175,13,200,67,10,152,243,4,59,255,209,247,63,160,138,219,213,173,214,92,148,253,21,8,254,165,210,9,179,237,93,236,149,162,125,3,216,104,242,158,211,81,113,166,34,187,11,3,186,114,51,141,99,25,43,127,44,137,109,206,164,45,141,43,1,55,105,167,176,110,27,151,127,1,50,118,53,65,221,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLocNoSettingsLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLocNoSettingsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ae34ce39-8021-4700-a745-d8b45529f0a2"),
				Name = "LocNoSettings",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9268c52e-f894-4e71-8c25-639c288db644"),
				ModifiedInSchemaUId = new Guid("9268c52e-f894-4e71-8c25-639c288db644")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9268c52e-f894-4e71-8c25-639c288db644"));
		}

		#endregion

	}

	#endregion

}

