namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AfterImportEntitiesSaveEventArgsSchema

	/// <exclude/>
	public class AfterImportEntitiesSaveEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AfterImportEntitiesSaveEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AfterImportEntitiesSaveEventArgsSchema(AfterImportEntitiesSaveEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("232e8c67-42ba-4203-936e-0c03b535963d");
			Name = "AfterImportEntitiesSaveEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,142,193,10,194,48,12,134,207,27,236,29,2,222,247,0,243,36,99,130,7,65,212,23,168,51,43,133,45,29,73,170,136,248,238,118,235,16,61,121,9,244,75,191,255,15,153,1,101,52,45,194,25,153,141,248,78,203,218,83,231,108,96,163,206,83,185,117,61,238,134,209,179,22,249,179,200,179,32,142,44,156,30,162,56,172,139,60,146,21,163,141,63,161,238,141,72,5,155,78,145,147,209,144,58,117,40,39,115,195,230,134,164,27,182,50,59,99,184,244,174,133,118,82,254,26,80,193,142,58,191,71,17,99,191,131,178,120,80,156,159,11,14,236,71,228,201,175,224,48,55,164,253,210,22,28,41,164,30,188,30,253,93,106,31,34,121,130,69,93,131,76,227,181,4,34,93,83,230,252,78,244,23,70,246,6,105,10,159,238,61,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("232e8c67-42ba-4203-936e-0c03b535963d"));
		}

		#endregion

	}

	#endregion

}

