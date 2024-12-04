namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFacebookServiceSchema

	/// <exclude/>
	public class IFacebookServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFacebookServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFacebookServiceSchema(IFacebookServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("653008e5-9c4b-409b-9e2f-8dcc34086cdd");
			Name = "IFacebookService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("42c3ed99-d529-4b29-9a2a-6514376125eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,229,88,77,79,227,48,16,61,23,137,255,96,149,75,145,80,126,0,136,3,109,41,234,74,45,136,84,226,80,113,112,157,105,106,53,177,179,246,184,187,21,226,191,51,137,155,170,1,148,213,30,137,47,177,60,126,51,153,247,226,241,71,20,207,193,22,92,0,91,128,49,220,234,53,70,35,173,214,50,117,134,163,212,42,138,181,144,60,59,63,123,59,63,235,57,43,85,202,226,189,69,200,163,24,204,78,10,152,233,4,178,155,182,193,232,78,160,220,85,209,218,113,47,176,34,0,65,46,12,164,132,102,83,133,96,214,148,221,53,155,78,168,89,105,189,61,120,84,184,229,161,67,25,163,225,2,7,115,162,195,110,89,255,19,184,127,249,74,232,194,173,50,41,152,172,131,126,19,179,71,44,233,121,76,96,6,184,209,137,189,102,79,149,175,31,92,62,22,224,197,169,223,91,70,239,45,41,253,169,218,233,45,12,188,91,153,200,211,99,188,232,95,177,103,248,237,192,226,68,155,156,35,217,9,58,3,107,121,10,222,20,253,178,90,93,177,161,78,246,49,238,51,104,64,142,214,232,197,240,162,128,164,140,103,11,173,44,180,7,172,88,247,26,159,243,192,180,246,103,49,224,157,16,228,185,160,188,213,192,127,236,57,224,31,109,106,85,14,185,51,227,219,203,155,31,169,194,9,203,35,249,135,144,201,79,164,74,194,96,223,90,0,35,3,28,193,147,39,57,180,83,216,97,41,26,60,167,106,173,79,107,225,203,96,144,66,148,117,17,146,18,173,213,49,134,12,194,169,142,246,133,98,3,98,27,138,18,67,110,233,80,149,231,92,37,228,230,50,36,239,50,203,145,51,6,84,32,187,230,87,17,238,255,130,112,88,27,59,76,61,6,110,196,166,201,218,219,58,76,186,190,13,220,43,148,40,193,158,238,141,115,186,160,216,49,71,30,226,124,31,114,20,155,238,79,250,49,172,92,250,221,81,185,26,8,106,233,107,151,34,12,13,254,125,26,24,113,229,41,65,183,101,176,46,7,243,249,182,112,106,255,31,250,23,160,18,255,119,165,234,191,251,31,62,13,227,251,7,238,140,124,224,150,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("653008e5-9c4b-409b-9e2f-8dcc34086cdd"));
		}

		#endregion

	}

	#endregion

}

