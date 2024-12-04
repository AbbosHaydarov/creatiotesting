namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateReadOptionSchema

	/// <exclude/>
	public class DCTemplateReadOptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateReadOptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateReadOptionSchema(DCTemplateReadOptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f88a83ea-c4fe-4ac2-870c-f6abbd2f69d5");
			Name = "DCTemplateReadOption";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,79,75,195,64,16,197,207,9,228,59,12,120,149,68,61,170,45,72,91,241,164,80,235,73,60,76,147,73,88,216,127,236,204,130,65,250,221,157,36,21,122,240,178,236,155,247,230,55,187,227,209,17,71,108,9,14,148,18,114,232,165,222,4,223,155,33,39,20,19,124,189,29,61,58,211,106,81,200,75,85,254,84,101,145,217,248,1,222,71,22,114,15,85,169,149,171,68,131,166,97,231,179,187,135,237,230,64,46,90,20,218,19,118,111,113,2,205,177,166,105,224,145,179,115,152,198,245,89,47,54,3,105,43,244,33,65,210,30,6,69,207,132,26,62,152,24,144,161,183,56,112,253,71,105,46,48,159,207,147,245,165,183,152,143,214,180,11,235,255,87,20,250,1,61,139,215,224,9,86,112,115,61,137,221,119,107,115,71,79,34,201,28,179,232,188,21,220,94,58,123,138,202,197,23,113,246,188,9,77,220,205,164,211,178,0,242,221,178,131,73,158,126,1,110,193,244,64,88,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f88a83ea-c4fe-4ac2-870c-f6abbd2f69d5"));
		}

		#endregion

	}

	#endregion

}

