namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorElementSchema

	/// <exclude/>
	public class ColumnValuesIteratorElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorElementSchema(ColumnValuesIteratorElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e");
			Name = "ColumnValuesIteratorElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,81,59,79,195,48,16,158,19,169,255,225,20,22,88,226,29,218,72,40,98,96,168,212,1,177,95,157,75,106,53,182,35,159,83,64,168,255,29,199,78,16,173,42,54,223,227,123,220,103,131,154,120,64,73,240,70,206,33,219,214,151,181,53,173,234,70,135,94,89,83,214,168,7,84,157,225,85,254,189,202,87,121,118,231,168,11,3,168,123,100,126,132,218,246,163,54,239,216,143,196,175,158,2,202,186,151,158,52,25,31,215,133,16,176,230,81,107,116,95,213,92,63,239,217,59,148,30,40,45,66,107,93,88,34,2,233,168,221,20,183,56,11,81,149,11,157,248,195,55,140,251,94,73,192,133,82,78,182,254,119,149,165,67,126,47,217,146,63,216,38,220,178,139,92,105,120,237,59,155,26,91,60,18,67,144,153,96,31,202,31,64,163,116,150,225,20,149,0,77,3,50,74,207,157,201,114,68,94,120,78,157,1,29,106,48,225,7,54,133,180,198,211,167,47,170,16,254,244,136,137,12,206,74,98,86,166,91,130,226,114,45,34,44,178,92,159,126,178,170,129,93,2,221,223,74,96,33,159,213,30,158,230,28,200,52,41,138,88,159,211,55,95,52,207,63,148,145,250,14,41,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e"));
		}

		#endregion

	}

	#endregion

}

