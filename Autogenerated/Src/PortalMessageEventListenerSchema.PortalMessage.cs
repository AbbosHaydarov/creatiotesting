namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageEventListenerSchema

	/// <exclude/>
	public class PortalMessageEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageEventListenerSchema(PortalMessageEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7651591f-a66d-4dfa-8f74-cd990454a314");
			Name = "PortalMessageEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,84,193,110,155,64,16,61,19,41,255,48,162,135,128,20,193,221,181,45,37,110,212,84,170,211,74,118,123,169,114,24,195,0,91,193,174,181,187,80,161,170,255,222,97,23,172,146,216,233,5,105,103,222,204,123,251,102,22,137,13,153,35,102,4,123,210,26,141,42,108,178,81,178,16,101,171,209,10,37,175,175,126,95,95,5,173,17,178,132,93,111,44,53,239,79,231,127,75,52,37,31,238,47,166,30,164,21,86,144,249,47,32,121,232,72,218,1,199,200,119,154,74,150,0,155,26,141,89,192,87,165,45,214,91,50,6,75,114,184,207,130,5,73,210,14,157,166,41,44,77,219,52,168,251,245,120,158,0,80,40,13,55,179,6,55,192,13,132,237,129,28,99,50,117,72,95,180,88,26,34,172,141,130,76,83,177,10,223,214,157,220,163,33,23,235,103,2,67,72,135,126,63,206,164,162,93,86,81,131,79,60,8,88,65,56,211,24,198,207,92,117,108,15,181,200,32,27,92,120,195,4,88,192,5,118,238,193,67,228,239,201,209,45,217,74,229,131,167,90,116,104,105,204,146,204,61,224,18,218,41,241,201,151,118,187,192,35,202,188,38,51,89,187,195,142,114,111,240,224,239,107,131,125,228,136,26,27,144,236,192,42,52,172,129,253,90,187,11,128,63,37,203,212,65,206,87,80,184,222,87,228,230,52,205,104,113,113,74,78,215,93,97,73,59,130,59,93,154,97,54,32,164,177,40,249,25,100,74,90,20,114,88,81,91,209,68,232,174,0,57,90,156,105,25,39,163,58,166,19,57,65,167,68,14,95,164,187,118,164,14,63,41,155,174,112,11,231,168,129,98,24,158,87,16,28,120,114,201,84,57,149,80,60,188,151,32,240,165,208,248,161,243,150,68,62,18,123,160,7,137,34,26,1,201,71,178,251,254,72,249,70,213,109,35,191,99,221,210,242,160,84,189,142,194,79,230,73,89,55,70,83,81,30,198,177,167,15,52,217,86,75,223,233,143,251,118,168,65,42,43,10,193,171,181,2,73,191,230,187,199,125,92,110,98,29,181,14,101,13,74,14,76,85,35,254,145,151,81,233,126,235,115,39,173,223,12,105,254,225,72,182,138,87,237,246,68,57,182,27,91,37,142,173,143,124,148,5,158,89,87,31,157,7,57,6,127,1,243,41,82,32,227,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7651591f-a66d-4dfa-8f74-cd990454a314"));
		}

		#endregion

	}

	#endregion

}

