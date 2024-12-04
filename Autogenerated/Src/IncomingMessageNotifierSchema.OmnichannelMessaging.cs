namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IncomingMessageNotifierSchema

	/// <exclude/>
	public class IncomingMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IncomingMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IncomingMessageNotifierSchema(IncomingMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc6fbb0e-f49b-4d6a-b97a-206ce6b2a400");
			Name = "IncomingMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,201,106,195,48,16,61,59,208,127,24,146,139,115,168,124,239,18,232,66,74,160,27,93,78,165,7,69,30,39,2,91,50,146,156,18,74,255,189,35,203,10,105,90,23,10,165,244,102,121,102,222,188,247,102,36,197,43,180,53,23,8,15,104,12,183,186,112,236,76,171,66,46,26,195,157,212,138,221,84,74,138,37,87,10,75,118,133,214,242,133,84,139,189,193,235,222,32,105,44,125,194,253,218,58,172,168,170,44,81,248,18,203,46,80,161,145,226,112,147,179,13,110,144,77,185,112,218,72,180,148,65,57,35,131,11,170,131,179,146,91,123,0,51,37,116,69,85,161,27,94,107,39,11,137,166,77,205,178,12,142,108,83,85,220,172,39,221,249,14,107,131,22,149,179,32,60,194,190,234,42,160,208,6,194,129,56,148,146,120,18,47,11,124,174,27,7,10,95,160,10,45,88,68,206,182,160,159,206,177,224,77,233,78,165,202,169,62,117,235,26,117,145,206,122,232,141,199,207,84,84,55,243,82,138,192,163,79,8,144,196,94,141,137,55,118,227,200,84,98,153,147,37,183,70,174,184,195,214,130,164,14,7,176,142,38,36,224,146,116,29,237,2,94,118,98,39,81,98,252,209,89,158,140,80,229,161,73,119,142,51,160,249,57,211,248,249,80,223,251,182,133,143,119,205,122,120,167,99,104,121,39,187,221,224,184,245,249,123,142,233,216,111,74,242,246,61,179,43,116,75,221,154,209,122,28,130,237,212,164,90,210,186,185,92,147,241,6,139,227,225,143,118,153,245,13,99,8,153,223,131,56,211,149,150,57,156,228,121,164,253,105,19,98,96,215,242,62,111,24,129,165,187,185,219,78,252,181,184,59,172,244,10,127,79,95,192,251,87,18,175,125,108,189,161,152,110,80,186,218,168,45,106,162,23,4,185,88,66,191,25,241,89,1,169,62,221,181,136,146,196,36,246,88,231,116,117,163,37,193,10,239,197,151,219,223,253,251,120,33,222,222,1,7,117,179,65,179,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc6fbb0e-f49b-4d6a-b97a-206ce6b2a400"));
		}

		#endregion

	}

	#endregion

}

