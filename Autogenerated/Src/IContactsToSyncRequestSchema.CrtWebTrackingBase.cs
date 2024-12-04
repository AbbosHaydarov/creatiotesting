namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactsToSyncRequestSchema

	/// <exclude/>
	public class IContactsToSyncRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactsToSyncRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactsToSyncRequestSchema(IContactsToSyncRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe2401fc-4445-4ccb-8923-5d73436003de");
			Name = "IContactsToSyncRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,193,78,194,64,16,134,207,144,240,14,19,184,104,98,232,29,161,23,53,132,68,19,3,248,0,75,59,133,77,232,44,206,204,30,208,248,238,78,91,64,10,154,120,105,118,103,254,254,243,253,187,75,174,68,217,185,12,97,137,204,78,66,161,195,135,64,133,95,71,118,234,3,245,186,159,189,110,39,138,167,53,44,246,162,88,222,95,236,77,191,221,98,86,137,101,56,69,66,246,217,143,230,220,150,209,234,214,25,48,174,77,13,51,82,228,194,134,143,96,102,67,213,101,42,203,176,216,83,54,199,247,136,162,181,58,73,18,24,75,44,75,199,251,244,176,159,227,142,81,144,84,160,68,221,132,92,64,3,172,81,33,59,248,64,17,24,114,167,14,196,252,54,28,200,127,212,129,134,71,203,228,204,115,23,87,91,159,129,63,2,253,201,211,177,211,176,239,41,194,75,51,125,4,175,181,67,211,188,36,62,32,107,100,18,136,228,205,11,124,110,244,190,240,200,2,161,248,31,246,53,119,83,217,57,118,37,144,93,229,164,31,5,217,216,169,185,144,126,58,35,81,71,150,200,134,140,5,17,50,198,98,210,127,107,203,146,116,56,78,106,155,223,93,205,131,245,209,41,246,211,69,181,172,16,241,250,23,110,50,166,207,94,244,44,149,133,21,19,31,187,149,124,246,68,177,68,118,171,45,142,167,209,231,41,76,81,219,103,126,211,102,132,118,178,59,168,112,150,190,68,56,193,221,54,207,171,51,64,202,155,251,169,247,95,205,163,107,21,173,246,13,29,159,190,110,251,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe2401fc-4445-4ccb-8923-5d73436003de"));
		}

		#endregion

	}

	#endregion

}

