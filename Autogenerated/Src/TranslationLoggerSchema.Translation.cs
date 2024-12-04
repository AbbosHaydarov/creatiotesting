namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationLoggerSchema

	/// <exclude/>
	public class TranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationLoggerSchema(TranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3f11c0-05c4-491f-b69b-c36875a97219");
			Name = "TranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,83,219,106,194,64,16,125,142,224,63,12,246,37,66,201,7,68,68,138,72,9,84,144,214,62,151,53,142,105,74,178,27,102,55,82,41,254,123,39,187,137,154,139,165,47,201,92,206,156,153,57,147,72,145,163,46,68,140,176,69,34,161,213,193,4,75,37,15,105,82,146,48,169,146,193,150,132,212,153,181,199,163,159,241,200,43,117,42,19,120,59,105,131,249,236,226,39,153,218,137,44,12,151,42,207,185,234,69,37,9,135,175,249,91,122,194,123,241,219,110,140,97,212,3,97,194,14,44,51,161,117,8,55,249,170,5,146,5,21,229,46,75,99,136,43,76,31,2,33,68,3,117,30,47,195,207,107,7,37,181,161,50,54,138,184,209,198,82,58,68,77,223,227,240,223,53,18,151,73,140,171,32,148,45,119,10,149,90,158,215,1,205,59,176,74,10,239,92,143,130,114,239,166,105,143,182,33,85,32,153,20,171,193,40,61,10,131,245,100,206,129,78,143,142,235,230,72,208,216,94,158,174,141,115,155,35,226,165,224,35,179,155,205,122,137,90,202,11,85,109,121,132,166,36,217,212,193,98,1,126,99,207,171,162,181,144,130,157,224,25,77,45,218,164,167,227,100,58,117,147,157,255,161,197,26,205,167,218,15,95,232,168,210,61,172,136,20,249,171,239,24,11,187,61,54,135,112,205,2,151,231,83,243,231,23,172,242,194,156,30,25,211,82,164,199,22,61,89,37,95,81,151,153,1,178,175,65,90,151,10,214,168,53,175,125,151,53,146,7,229,171,221,23,31,8,248,7,180,216,54,157,69,52,169,63,190,17,23,109,7,57,246,11,230,148,98,173,216,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3f11c0-05c4-491f-b69b-c36875a97219"));
		}

		#endregion

	}

	#endregion

}

