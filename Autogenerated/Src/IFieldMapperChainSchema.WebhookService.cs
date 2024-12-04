namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFieldMapperChainSchema

	/// <exclude/>
	public class IFieldMapperChainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFieldMapperChainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFieldMapperChainSchema(IFieldMapperChainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a18d0b8b-0554-48fe-80f3-0d61e8456086");
			Name = "IFieldMapperChain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,77,75,195,64,16,61,39,144,255,48,180,23,5,73,238,26,115,41,90,122,168,8,45,120,222,38,147,102,49,187,27,102,119,149,34,254,119,247,35,209,180,32,52,132,144,125,59,31,239,189,25,201,4,234,129,213,8,123,36,98,90,181,38,95,41,217,242,163,37,102,184,146,89,250,149,165,137,213,92,30,97,119,210,6,133,187,239,123,172,253,165,206,215,40,145,120,253,144,165,46,170,40,10,40,181,21,130,209,169,26,207,251,14,97,32,245,193,27,36,80,45,124,226,161,83,234,29,80,26,110,78,249,148,85,204,210,6,123,232,121,13,92,26,164,214,83,219,60,115,236,155,45,27,6,164,85,199,184,35,149,56,86,89,10,227,179,36,60,58,58,176,69,211,169,70,223,195,107,40,49,15,185,224,54,135,215,104,52,24,199,83,248,14,13,180,190,155,206,47,114,103,12,207,240,129,17,19,32,157,143,143,139,81,92,160,171,23,149,215,62,233,29,139,150,69,136,191,162,200,78,89,170,241,188,136,14,216,53,69,48,216,251,226,254,23,149,255,122,235,189,196,136,255,87,129,208,88,146,58,244,60,55,163,44,166,59,231,125,178,121,146,86,32,177,67,143,229,91,228,230,150,194,10,233,102,84,121,63,195,172,154,232,195,205,60,90,27,114,155,84,77,138,98,196,29,68,120,66,163,244,95,244,79,203,109,220,179,100,137,178,137,35,15,231,239,44,117,239,15,99,129,203,135,203,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a18d0b8b-0554-48fe-80f3-0d61e8456086"));
		}

		#endregion

	}

	#endregion

}

