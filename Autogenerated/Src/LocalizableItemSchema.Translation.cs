namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalizableItemSchema

	/// <exclude/>
	public class LocalizableItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalizableItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalizableItemSchema(LocalizableItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19dfea59-9b33-4952-b46b-b44061ba40b3");
			Name = "LocalizableItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,203,106,195,48,16,60,59,144,127,88,232,165,5,19,223,211,7,148,4,138,105,75,3,13,189,43,246,218,136,218,146,209,35,224,150,252,123,87,146,227,56,46,152,64,46,70,218,29,205,172,70,99,193,106,212,13,203,16,182,168,20,211,178,48,139,149,20,5,47,173,98,134,75,177,216,42,38,116,229,215,243,217,239,124,22,89,205,69,9,159,173,54,88,223,247,251,225,113,133,195,83,132,33,212,141,194,146,54,176,170,152,214,75,120,147,25,171,248,15,219,85,152,18,143,135,52,118,87,241,12,50,135,24,3,96,9,233,191,51,17,141,67,223,19,183,20,218,40,155,25,169,72,98,227,233,2,162,163,30,49,220,18,218,205,254,141,109,12,221,122,207,42,139,49,188,88,158,67,102,43,99,21,166,121,12,107,102,112,203,107,132,90,230,188,224,152,127,136,24,118,82,86,192,245,179,53,178,68,129,100,24,230,119,224,60,138,162,87,108,225,209,49,59,139,162,232,203,209,82,193,211,135,210,234,200,78,229,94,41,180,222,123,17,234,157,20,67,51,61,23,36,196,104,4,15,59,116,214,160,200,131,59,231,86,109,148,108,80,25,142,35,163,146,36,129,7,109,235,154,169,246,233,88,160,187,44,250,102,50,236,118,190,118,222,185,59,135,219,151,104,194,176,141,226,123,154,9,116,87,56,76,200,120,143,46,18,10,110,94,33,213,121,15,60,71,97,156,187,106,90,215,199,225,244,96,87,40,135,167,205,252,159,1,57,157,154,22,94,31,115,55,136,196,21,234,107,52,168,106,46,80,3,47,66,24,41,61,192,134,241,153,30,200,103,126,28,193,203,38,26,101,49,84,207,139,135,63,110,51,161,225,144,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19dfea59-9b33-4952-b46b-b44061ba40b3"));
		}

		#endregion

	}

	#endregion

}

