namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessagePublisherSchema

	/// <exclude/>
	public class PortalMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessagePublisherSchema(PortalMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6244c208-b197-4059-8d43-d8de62679b3c");
			Name = "PortalMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b8eb560-035d-46d4-af40-51e85d9668c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,80,203,106,195,48,16,60,203,224,127,88,210,75,10,33,31,224,62,14,77,218,158,90,2,105,63,96,163,108,28,129,44,135,93,233,96,74,254,189,43,57,80,220,180,32,36,205,106,118,70,59,73,92,104,97,59,72,164,110,185,234,189,39,27,93,31,100,249,74,129,216,217,187,186,74,133,242,65,204,40,253,33,42,139,73,203,117,21,176,35,57,161,165,201,99,56,184,54,49,102,149,186,250,170,43,163,235,134,169,85,12,43,143,34,13,108,122,142,232,223,72,4,91,218,164,157,119,114,36,206,146,230,148,145,5,155,137,255,240,160,129,39,20,186,110,55,234,166,251,143,155,206,17,57,217,216,179,122,22,225,145,112,49,249,91,126,254,41,196,218,26,198,36,32,77,224,2,214,174,92,144,135,123,85,215,104,22,48,158,143,64,33,186,56,188,56,242,123,89,99,196,219,108,102,26,216,233,119,231,191,117,174,200,144,195,50,230,185,212,183,246,72,29,190,107,194,240,0,179,201,79,103,26,190,49,231,203,172,20,246,227,184,5,143,213,105,241,252,13,247,153,241,37,228,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6244c208-b197-4059-8d43-d8de62679b3c"));
		}

		#endregion

	}

	#endregion

}

