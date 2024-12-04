namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeColumnProcessorSchema

	/// <exclude/>
	public class TimeColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeColumnProcessorSchema(TimeColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("761b0013-5b74-46b7-87d9-cd9671c4ab75");
			Name = "TimeColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,147,193,78,227,48,16,134,207,69,226,29,70,221,75,43,161,228,206,210,74,80,4,234,5,33,209,238,101,181,7,215,153,148,145,18,59,140,109,164,10,241,238,59,182,219,93,82,2,18,92,18,123,244,207,63,158,207,99,163,90,116,157,210,8,43,100,86,206,214,190,88,88,83,211,54,176,242,100,77,113,67,13,46,219,206,178,63,61,121,57,61,25,5,71,102,11,15,59,231,177,253,249,111,255,54,155,241,163,120,113,163,180,183,76,232,68,33,154,31,140,91,169,1,139,70,57,119,14,43,106,113,97,155,208,154,123,182,26,157,179,156,100,101,89,194,5,153,71,100,242,149,213,160,25,235,217,248,90,121,28,200,24,151,243,67,138,11,109,171,120,119,216,95,26,32,227,188,50,210,173,173,193,63,146,3,29,43,131,44,88,48,88,227,104,211,32,212,150,161,203,126,177,135,88,8,116,170,2,207,170,9,232,138,67,133,242,77,137,223,215,88,171,208,248,43,50,149,164,77,252,174,67,91,79,150,71,231,155,158,193,157,64,135,25,24,249,137,96,160,135,233,244,143,24,118,97,211,144,222,31,113,64,5,231,233,104,131,212,70,114,85,242,253,79,88,122,243,28,34,125,1,125,159,156,179,226,27,112,223,209,77,129,5,163,36,185,62,99,97,32,74,196,189,237,176,101,196,249,158,103,142,116,138,85,155,80,205,198,193,33,75,35,6,117,156,204,241,124,45,123,185,152,67,160,184,40,147,58,37,239,225,13,20,156,172,123,54,208,119,157,10,213,141,114,56,57,14,199,217,31,189,238,169,162,169,50,216,62,101,169,209,33,123,153,111,97,204,214,75,46,86,159,97,190,146,74,95,64,44,183,162,242,8,102,178,193,208,147,172,169,66,227,169,38,228,15,72,202,48,231,179,128,125,150,7,41,122,184,13,84,37,191,95,209,110,37,110,235,101,5,179,121,63,86,68,126,199,170,252,118,143,33,100,52,253,224,235,95,177,177,202,58,95,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("761b0013-5b74-46b7-87d9-cd9671c4ab75"));
		}

		#endregion

	}

	#endregion

}

