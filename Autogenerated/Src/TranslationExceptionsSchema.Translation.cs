namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationExceptionsSchema

	/// <exclude/>
	public class TranslationExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationExceptionsSchema(TranslationExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd34e1f4-8c12-45a5-b98a-235cdfe34c22");
			Name = "TranslationExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,133,80,61,79,195,64,12,157,19,41,255,193,18,75,89,146,189,32,150,138,173,3,18,81,153,157,195,73,78,186,248,162,243,93,75,65,252,119,156,143,66,89,96,57,159,159,237,247,158,205,56,144,140,104,8,106,10,1,197,183,177,220,121,110,109,151,2,70,235,185,172,3,178,184,249,95,228,31,69,158,37,177,220,193,243,89,34,13,119,69,174,200,77,160,78,203,176,115,40,178,133,151,96,35,237,189,65,103,223,177,113,116,64,151,232,241,205,208,184,144,232,68,85,85,112,47,105,24,48,156,31,214,188,238,9,232,210,5,177,199,8,86,52,6,127,98,56,245,196,32,120,36,240,35,45,206,64,171,236,35,72,50,134,68,218,228,202,11,115,117,69,61,166,198,89,3,102,242,246,143,53,216,194,149,205,76,151,213,247,103,59,207,18,67,50,209,7,93,242,105,166,93,58,86,137,191,201,55,58,60,29,78,239,45,216,209,173,138,53,40,180,249,206,167,219,102,159,171,38,241,235,34,59,231,11,250,27,84,236,11,123,17,51,162,189,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd34e1f4-8c12-45a5-b98a-235cdfe34c22"));
		}

		#endregion

	}

	#endregion

}

