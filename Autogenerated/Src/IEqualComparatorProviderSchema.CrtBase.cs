namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEqualComparatorProviderSchema

	/// <exclude/>
	public class IEqualComparatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEqualComparatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEqualComparatorProviderSchema(IEqualComparatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16767ff9-f891-4a8b-8bb0-10d7f21c7208");
			Name = "IEqualComparatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,143,193,10,130,80,16,69,215,10,254,195,131,54,181,241,3,106,105,18,238,2,251,129,151,142,54,160,51,58,206,11,44,250,247,94,138,27,161,104,51,112,135,123,207,229,146,109,97,232,108,1,230,2,34,118,224,74,227,132,169,194,218,137,85,100,138,83,82,212,49,31,169,184,9,19,62,166,111,20,62,163,48,10,131,141,64,237,165,201,72,65,42,143,217,155,44,237,157,109,18,110,59,235,9,44,103,225,59,150,32,147,191,115,215,6,11,131,139,253,135,59,152,27,130,85,115,194,141,107,253,93,2,230,4,154,171,32,213,43,210,118,119,248,27,112,180,10,95,226,175,121,39,80,57,79,253,72,255,123,3,207,226,238,218,56,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16767ff9-f891-4a8b-8bb0-10d7f21c7208"));
		}

		#endregion

	}

	#endregion

}

