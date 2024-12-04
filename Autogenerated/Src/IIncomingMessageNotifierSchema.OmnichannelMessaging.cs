namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncomingMessageNotifierSchema

	/// <exclude/>
	public class IIncomingMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncomingMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncomingMessageNotifierSchema(IIncomingMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce1c4ef7-b936-4dd7-987d-b5980c9beea9");
			Name = "IIncomingMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,147,193,78,195,48,12,134,207,173,212,119,176,186,203,184,180,247,49,42,33,78,149,24,160,137,23,200,90,183,139,212,56,85,156,14,77,104,239,78,151,54,221,160,2,113,128,99,236,223,191,63,39,14,9,133,220,138,2,225,21,141,17,172,43,155,60,104,170,100,221,25,97,165,166,228,89,145,44,246,130,8,155,100,131,204,162,150,84,71,225,123,20,70,97,176,48,88,247,34,200,201,162,169,122,155,21,228,57,21,90,245,154,65,140,79,218,202,74,162,113,250,52,77,97,205,157,82,194,28,179,241,188,197,214,32,35,89,6,233,109,160,210,6,200,85,82,13,141,100,139,132,134,65,236,116,103,129,240,13,212,224,158,120,211,244,202,181,237,118,141,44,174,220,190,103,10,250,57,130,105,140,13,218,189,46,121,5,47,206,193,33,207,152,93,224,190,44,217,113,120,182,51,200,156,100,136,180,194,8,5,212,95,245,93,236,245,113,54,178,92,28,214,169,19,186,186,131,150,229,185,201,227,152,92,126,29,193,39,166,242,155,219,31,112,183,168,244,1,249,95,105,135,30,127,4,60,190,208,133,152,127,139,60,46,70,156,249,254,211,170,204,136,93,147,163,7,227,229,180,222,126,216,177,210,147,46,144,202,97,83,220,249,52,124,129,79,193,211,7,149,156,60,35,81,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce1c4ef7-b936-4dd7-987d-b5980c9beea9"));
		}

		#endregion

	}

	#endregion

}

