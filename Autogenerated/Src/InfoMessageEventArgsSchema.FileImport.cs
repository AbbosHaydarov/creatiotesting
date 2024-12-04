namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InfoMessageEventArgsSchema

	/// <exclude/>
	public class InfoMessageEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InfoMessageEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InfoMessageEventArgsSchema(InfoMessageEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("581d1ca8-4c25-474e-9e2b-79fe22e7b14e");
			Name = "InfoMessageEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,145,65,10,194,48,16,69,215,45,244,14,3,221,123,0,93,73,169,210,133,80,208,11,196,118,26,2,109,18,102,82,81,138,119,55,105,85,170,118,229,38,36,195,155,255,231,79,180,232,144,173,168,16,78,72,36,216,52,110,149,25,221,40,217,147,112,202,232,213,78,181,88,116,214,144,75,226,33,137,163,158,149,150,112,188,177,195,110,147,196,190,146,18,74,79,2,100,173,96,94,67,78,100,232,128,204,66,98,126,65,237,182,36,121,36,109,127,110,85,5,85,224,150,49,88,67,161,27,243,219,29,5,239,183,85,73,198,34,57,133,222,174,28,69,71,253,151,193,190,87,53,76,67,31,189,146,239,40,106,24,64,162,219,0,135,227,254,129,231,215,10,109,8,59,187,13,191,116,138,186,158,252,253,107,170,205,75,11,155,88,142,242,189,136,37,202,239,225,223,240,236,40,252,208,83,241,143,32,62,218,3,200,116,25,213,23,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("581d1ca8-4c25-474e-9e2b-79fe22e7b14e"));
		}

		#endregion

	}

	#endregion

}

