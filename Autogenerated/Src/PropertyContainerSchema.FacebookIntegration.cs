namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PropertyContainerSchema

	/// <exclude/>
	public class PropertyContainerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PropertyContainerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PropertyContainerSchema(PropertyContainerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("593ff365-923f-4ae6-ac7a-a20ebaa261c5");
			Name = "PropertyContainer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,143,77,10,131,48,16,133,215,10,222,33,224,222,3,180,75,65,232,162,32,181,23,24,227,68,66,99,18,38,113,33,197,187,55,241,15,10,165,237,38,204,204,123,243,229,141,134,1,157,5,142,236,142,68,224,140,240,69,105,180,144,253,72,224,165,209,69,99,184,4,149,165,207,44,77,70,39,117,207,154,201,121,28,138,27,10,133,60,122,206,89,26,196,156,176,15,13,43,21,56,119,98,53,25,139,228,167,64,243,32,53,210,98,178,99,171,36,103,60,122,62,89,146,240,77,120,15,216,102,145,24,137,203,238,170,111,28,231,41,38,170,194,1,173,49,143,74,162,234,88,76,154,36,61,250,144,43,20,110,43,230,111,155,53,16,106,255,223,234,30,251,162,133,57,0,87,176,22,187,93,250,1,202,81,119,235,129,75,191,78,223,135,243,11,19,105,152,235,154,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("593ff365-923f-4ae6-ac7a-a20ebaa261c5"));
		}

		#endregion

	}

	#endregion

}

