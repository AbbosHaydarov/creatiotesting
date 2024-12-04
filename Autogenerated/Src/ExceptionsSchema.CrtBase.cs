namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExceptionsSchema

	/// <exclude/>
	public class ExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExceptionsSchema(ExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec");
			Name = "Exceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,81,219,74,195,64,16,125,78,193,127,24,146,151,20,66,170,130,136,245,73,74,11,130,55,90,47,15,226,195,102,59,13,171,155,221,176,23,188,225,191,59,187,105,99,139,13,33,97,206,156,153,115,102,70,177,6,109,203,56,194,61,26,195,172,94,185,114,162,213,74,212,222,48,39,180,58,24,124,31,12,18,111,133,170,97,241,105,29,54,231,125,188,93,210,52,90,237,207,24,36,156,50,207,11,52,130,73,241,197,42,137,47,4,180,190,146,130,3,151,204,90,184,164,206,55,218,205,180,87,203,233,7,199,54,136,195,24,46,218,150,72,209,74,15,83,109,48,149,100,6,235,192,34,195,214,25,207,157,54,118,12,119,177,109,148,76,70,163,44,203,10,160,79,120,54,255,157,8,50,120,210,230,173,91,194,100,126,116,122,124,114,120,22,106,215,246,246,26,203,31,44,26,146,85,200,163,79,191,19,22,64,118,194,26,68,168,165,13,23,27,64,87,175,68,9,208,48,72,36,99,168,152,197,188,203,150,51,109,26,230,114,133,239,112,165,249,102,85,139,152,204,119,37,202,222,115,57,71,171,189,225,196,211,134,213,88,196,198,73,218,123,181,105,1,233,191,126,182,220,30,236,26,173,165,218,169,196,6,149,187,93,77,180,148,107,161,71,38,61,166,195,117,219,191,137,182,70,25,66,60,199,79,71,137,151,65,181,236,142,67,17,225,244,254,2,22,244,186,58,106,2,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateItemNotFoundMessageElementOfCollectionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateItemNotFoundMessageElementOfCollectionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ea6e1d20-4f48-49c8-b0b9-9625dfbcff06"),
				Name = "ItemNotFoundMessageElementOfCollection",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec"),
				ModifiedInSchemaUId = new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c2eb97d-52a5-4c3d-8c66-7c7e74fc11ec"));
		}

		#endregion

	}

	#endregion

}

