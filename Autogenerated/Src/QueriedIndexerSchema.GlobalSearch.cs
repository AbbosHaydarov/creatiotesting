namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueriedIndexerSchema

	/// <exclude/>
	public class QueriedIndexerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueriedIndexerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueriedIndexerSchema(QueriedIndexerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5329f48a-37fa-49fb-9285-1a0aa78ae731");
			Name = "QueriedIndexer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,219,110,194,48,12,125,6,105,255,16,105,47,69,66,249,0,166,189,192,46,218,195,52,198,229,3,66,99,32,82,72,186,196,65,67,136,127,159,155,180,165,221,202,94,106,213,62,62,62,199,142,17,7,240,133,200,129,173,192,57,225,237,22,249,204,154,173,218,5,39,80,89,195,95,181,221,8,189,4,225,242,253,221,240,124,55,28,4,175,204,174,131,119,192,159,13,42,84,224,31,122,1,183,8,103,86,135,131,89,163,210,189,141,109,40,127,51,18,190,169,78,64,130,222,59,216,17,27,155,105,225,253,132,125,6,112,10,100,196,128,139,136,34,108,180,202,89,94,2,126,213,217,132,77,133,135,6,61,32,91,244,189,146,90,227,209,133,28,173,35,238,121,36,74,136,138,180,75,151,213,210,22,240,21,192,227,147,64,49,13,74,75,154,164,110,150,198,37,223,160,110,141,251,59,45,193,180,155,218,201,81,132,79,216,134,132,103,255,176,246,55,179,51,187,84,30,41,145,108,118,61,191,3,238,173,44,237,58,139,144,35,200,202,113,253,203,236,145,14,163,36,176,163,85,146,149,196,93,241,89,10,12,98,24,179,186,250,81,64,58,253,234,84,64,35,175,147,37,125,209,222,81,92,205,151,166,216,99,195,242,215,42,143,177,58,69,171,156,37,1,124,237,193,209,37,13,169,167,49,105,221,131,222,241,227,70,243,141,199,73,143,207,163,48,57,240,5,232,216,150,138,254,69,129,150,115,129,8,206,140,202,39,220,127,81,222,179,173,182,207,212,218,127,161,148,237,38,47,63,207,28,201,6,184,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5329f48a-37fa-49fb-9285-1a0aa78ae731"));
		}

		#endregion

	}

	#endregion

}

