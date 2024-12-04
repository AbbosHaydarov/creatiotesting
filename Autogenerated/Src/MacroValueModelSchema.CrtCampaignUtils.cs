namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacroValueModelSchema

	/// <exclude/>
	public class MacroValueModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacroValueModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacroValueModelSchema(MacroValueModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e05ca81a-184e-4e98-bb5a-a27cf686c759");
			Name = "MacroValueModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,145,203,106,195,48,16,69,215,53,248,31,134,100,111,239,219,180,80,178,54,4,82,186,31,43,35,163,162,135,153,145,10,33,228,223,43,91,73,232,211,20,132,64,51,186,231,222,145,60,58,146,17,21,193,11,49,163,4,29,155,109,240,218,12,137,49,154,224,155,45,186,17,205,224,165,174,78,117,85,87,119,107,166,33,55,96,107,81,228,30,58,84,28,94,209,38,234,194,129,108,190,144,87,219,182,176,145,228,28,242,241,233,114,206,216,136,198,11,24,175,3,96,31,82,4,55,137,225,125,82,131,14,12,228,163,137,71,80,193,38,231,155,43,168,253,68,26,83,111,141,2,53,153,255,226,93,34,222,50,238,56,140,196,209,80,14,186,155,149,165,255,61,223,92,120,182,6,5,130,46,169,38,247,159,246,87,127,137,108,252,112,145,156,96,160,248,0,50,109,231,5,131,110,226,74,25,119,25,31,250,55,82,17,230,209,254,141,223,151,76,76,35,147,228,151,156,255,15,242,218,8,17,40,38,253,184,154,137,171,246,166,89,26,174,240,254,204,176,38,127,40,207,60,159,75,245,107,241,252,1,240,194,95,129,95,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e05ca81a-184e-4e98-bb5a-a27cf686c759"));
		}

		#endregion

	}

	#endregion

}

