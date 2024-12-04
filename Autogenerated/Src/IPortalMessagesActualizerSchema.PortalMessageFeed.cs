namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPortalMessagesActualizerSchema

	/// <exclude/>
	public class IPortalMessagesActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPortalMessagesActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPortalMessagesActualizerSchema(IPortalMessagesActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33d6d3a2-74fe-4824-b31f-88dc01a91284");
			Name = "IPortalMessagesActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("32031062-b6bd-4fa4-a14f-d8d66f99305f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,193,106,195,48,12,134,207,13,228,29,68,119,217,96,36,247,173,43,148,109,133,30,6,133,246,5,188,90,73,205,98,43,200,74,67,55,246,238,179,147,166,164,221,152,111,254,45,125,124,178,192,41,139,190,86,59,132,45,50,43,79,133,100,207,228,10,83,54,172,196,144,203,214,196,162,170,55,244,94,149,184,68,212,105,242,149,38,147,198,27,87,194,230,232,5,237,99,154,132,228,134,177,12,13,0,43,39,200,69,96,62,192,234,162,219,47,118,210,168,202,124,34,119,29,121,158,195,204,55,214,42,62,206,79,247,53,211,193,104,244,96,81,246,164,61,20,196,208,18,127,64,107,100,15,117,199,11,143,61,16,212,153,152,13,192,124,68,172,155,247,202,236,192,12,70,255,9,77,226,88,215,78,112,58,49,94,232,160,67,149,254,37,33,4,14,91,16,99,177,50,14,163,73,207,169,21,43,11,241,143,159,166,90,9,46,153,236,116,190,17,197,2,241,158,205,242,174,36,170,254,221,177,165,233,252,213,233,235,234,177,214,120,224,33,63,144,209,112,30,238,114,230,219,151,200,13,174,29,52,42,221,195,69,180,165,187,176,209,136,249,238,23,139,78,247,187,77,147,144,252,0,103,91,182,95,52,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33d6d3a2-74fe-4824-b31f-88dc01a91284"));
		}

		#endregion

	}

	#endregion

}

