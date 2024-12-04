namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationEntityQueryExecutorSchema

	/// <exclude/>
	public class ApplicationEntityQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationEntityQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationEntityQueryExecutorSchema(ApplicationEntityQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("afadda41-08ff-4cac-864b-dc9f22b7ea37");
			Name = "ApplicationEntityQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,83,203,110,194,48,16,60,131,196,63,172,232,37,145,16,185,83,138,4,148,86,28,168,250,60,85,61,152,100,19,44,129,29,249,81,53,170,250,239,221,216,70,36,8,232,165,7,16,94,207,140,199,51,6,4,219,161,46,89,138,240,138,74,49,45,115,51,156,75,145,243,194,42,102,184,20,189,238,119,175,219,177,154,139,162,5,81,120,125,102,62,156,150,229,150,167,142,173,135,211,181,54,138,165,110,113,150,177,16,134,27,142,231,1,119,164,32,149,71,16,230,74,97,65,130,48,223,50,173,71,208,56,208,41,85,79,22,85,181,248,194,212,18,203,49,146,36,129,177,182,187,29,83,213,36,172,29,10,48,192,32,167,15,58,58,232,116,131,59,166,65,230,192,14,218,195,189,78,210,16,122,191,197,156,217,173,153,113,145,145,241,200,84,37,202,60,90,158,48,18,15,224,129,226,134,27,232,95,118,220,143,63,72,185,180,107,194,64,90,223,241,143,43,194,8,102,76,99,3,244,226,110,208,2,141,61,209,239,212,214,169,88,250,62,132,73,13,25,101,235,160,41,211,71,119,186,71,4,39,151,61,68,111,26,21,105,8,116,101,131,109,45,7,176,36,250,138,9,86,160,170,67,13,63,227,90,191,51,130,53,217,143,142,41,13,24,212,175,176,243,19,28,163,200,188,233,246,13,86,104,54,50,171,205,43,105,72,4,51,191,127,92,190,31,112,177,65,197,77,38,83,72,14,211,102,183,157,114,175,3,242,147,30,36,207,16,40,34,78,239,243,25,53,149,222,76,212,87,59,57,209,109,223,63,218,127,181,225,207,12,233,180,155,133,123,52,173,237,40,174,125,181,235,241,127,185,64,9,184,96,243,40,93,159,121,123,72,179,95,75,192,127,123,58,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("afadda41-08ff-4cac-864b-dc9f22b7ea37"));
		}

		#endregion

	}

	#endregion

}

