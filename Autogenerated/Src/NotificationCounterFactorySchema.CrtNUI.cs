namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationCounterFactorySchema

	/// <exclude/>
	public class NotificationCounterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationCounterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationCounterFactorySchema(NotificationCounterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b249d9e1-6ca1-4cdb-b5cf-9f2e4cc638b6");
			Name = "NotificationCounterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,84,77,139,219,48,16,61,59,144,255,48,184,23,47,44,246,125,155,24,150,208,13,57,116,89,250,113,46,138,51,118,68,101,41,140,164,20,179,236,127,175,36,219,137,99,156,236,182,224,139,70,51,111,222,123,51,178,100,53,234,3,43,16,126,32,17,211,170,52,233,74,201,146,87,150,152,225,74,206,103,175,243,89,100,53,151,21,124,111,180,193,218,221,11,129,133,191,212,233,26,37,18,47,62,159,114,134,48,117,173,228,244,13,225,181,120,250,196,10,163,136,163,246,25,238,251,68,88,185,86,176,18,76,235,7,120,86,134,151,188,8,220,86,202,74,131,212,86,52,243,153,203,206,178,12,22,218,214,53,163,38,239,206,47,164,142,124,135,26,24,212,104,246,106,7,70,1,43,10,212,26,204,30,161,240,200,238,186,84,4,21,26,227,73,133,120,11,175,211,30,55,27,0,31,236,86,240,162,173,189,65,10,30,96,115,139,114,244,26,121,145,39,149,79,28,197,206,201,124,33,126,100,6,131,166,232,208,30,128,144,237,148,20,13,252,212,72,110,74,178,157,2,252,178,23,103,103,92,128,68,185,107,81,187,115,111,164,155,155,33,235,9,248,70,65,71,215,167,213,116,157,111,50,106,124,217,247,14,252,170,68,209,101,52,93,237,177,248,253,72,149,173,81,154,103,43,68,34,221,210,169,50,25,85,223,249,129,71,209,72,12,44,71,93,66,214,219,109,137,95,195,152,175,217,184,249,34,29,23,98,91,129,139,169,225,228,176,70,51,17,215,27,103,28,147,110,111,18,103,160,223,146,138,148,61,244,178,143,140,128,247,25,142,118,88,216,206,56,247,78,204,163,16,211,237,146,0,115,31,64,34,137,127,134,19,234,125,75,226,75,23,226,251,241,212,123,255,8,141,37,121,102,242,111,126,13,182,97,252,148,66,224,91,64,215,3,161,170,116,89,232,94,11,97,185,140,167,4,198,89,14,219,102,152,53,76,90,123,241,46,229,212,114,248,202,218,200,129,17,171,193,111,205,50,14,94,197,249,59,96,139,44,212,156,33,90,87,116,126,254,119,125,140,248,34,235,43,7,15,228,191,23,104,114,111,186,129,189,187,115,109,209,181,113,118,177,97,232,237,47,85,46,185,52,221,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b249d9e1-6ca1-4cdb-b5cf-9f2e4cc638b6"));
		}

		#endregion

	}

	#endregion

}

