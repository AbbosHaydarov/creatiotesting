namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IChildImportEntitiesGetterSchema

	/// <exclude/>
	public class IChildImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IChildImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IChildImportEntitiesGetterSchema(IChildImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080");
			Name = "IChildImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,93,144,193,78,195,48,12,64,207,171,212,127,136,118,130,75,242,1,132,94,166,49,245,134,4,63,144,21,119,88,74,220,202,78,14,21,218,191,147,180,180,157,184,37,246,179,159,109,114,1,100,116,29,168,79,96,118,50,244,81,159,6,234,241,150,216,69,28,72,191,161,135,54,140,3,199,186,250,169,171,67,18,164,155,250,152,36,66,200,168,247,208,21,78,244,5,8,24,187,151,141,121,236,200,160,207,20,49,34,72,6,50,50,166,171,199,78,33,69,224,190,248,219,211,55,250,175,197,180,162,23,136,57,157,233,34,62,24,99,148,149,20,130,227,169,89,3,25,17,213,149,82,5,127,85,122,131,205,127,218,142,142,93,80,148,183,126,61,206,111,200,2,57,54,139,87,237,33,109,205,252,217,75,25,98,98,146,102,158,115,151,89,179,38,10,217,158,41,5,96,119,245,96,231,45,166,166,140,248,180,244,127,223,218,63,152,158,203,197,238,117,117,255,5,67,5,57,140,140,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080"));
		}

		#endregion

	}

	#endregion

}

