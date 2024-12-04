namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityActivitiesOwnerInfoSchema

	/// <exclude/>
	public class EntityActivitiesOwnerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityActivitiesOwnerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityActivitiesOwnerInfoSchema(EntityActivitiesOwnerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f495a412-7027-454b-a334-1948a1100b0a");
			Name = "EntityActivitiesOwnerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,207,106,195,48,12,198,207,13,228,29,4,189,55,247,118,12,70,25,35,151,182,144,189,128,103,203,169,33,182,131,229,44,132,210,119,159,255,180,93,217,70,183,238,98,108,73,254,190,159,100,27,166,145,122,198,17,94,209,57,70,86,250,197,218,26,169,218,193,49,175,172,41,139,67,89,204,6,82,166,133,102,34,143,122,85,22,33,50,119,216,134,52,172,59,70,180,132,103,227,149,159,158,184,87,239,202,43,164,237,104,208,213,70,218,84,92,85,21,60,208,160,53,115,211,227,233,220,120,235,144,64,133,26,167,147,21,24,228,72,20,106,192,91,224,123,102,90,4,27,133,192,74,96,89,123,90,156,245,170,43,193,126,120,235,20,7,30,97,110,177,204,66,51,97,189,208,239,156,237,209,197,162,37,236,146,70,206,127,5,78,129,90,96,80,150,42,243,196,125,166,249,142,115,230,121,25,148,56,225,212,2,14,208,162,95,1,197,229,248,139,143,140,228,201,199,118,226,210,123,158,198,31,60,183,157,200,93,255,215,213,224,120,191,235,6,199,123,93,55,225,255,125,78,19,136,239,81,179,219,86,228,93,252,140,121,172,77,186,144,84,126,176,156,163,17,249,165,211,57,71,175,131,179,178,56,126,0,237,44,141,72,3,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f495a412-7027-454b-a334-1948a1100b0a"));
		}

		#endregion

	}

	#endregion

}

