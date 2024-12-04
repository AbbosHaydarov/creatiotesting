namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFragmentSynchronizableSchema

	/// <exclude/>
	public class IFragmentSynchronizableSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFragmentSynchronizableSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFragmentSynchronizableSchema(IFragmentSynchronizableSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d438be3-42dd-4256-9b99-40dbca5fc709");
			Name = "IFragmentSynchronizable";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,145,193,78,195,48,12,134,207,171,212,119,176,198,5,46,237,125,140,94,134,64,61,76,66,192,11,184,153,211,70,106,157,202,73,15,3,241,238,164,77,11,133,9,46,145,126,199,254,243,253,14,99,71,174,71,69,240,74,34,232,172,246,217,193,178,54,245,32,232,141,229,52,121,79,147,52,217,92,9,213,65,66,201,158,68,135,129,29,148,15,130,117,71,236,95,206,172,26,177,108,222,176,106,105,106,207,243,28,246,110,232,58,148,115,49,235,123,114,74,76,69,14,92,79,202,104,163,160,181,117,56,181,21,80,216,245,104,106,134,30,197,27,101,122,100,31,26,191,157,71,152,108,113,206,87,214,253,80,181,193,196,44,96,127,115,109,98,148,175,44,71,242,141,61,185,29,60,77,22,241,242,55,249,84,120,38,63,8,95,240,64,135,140,53,9,248,6,61,152,85,176,41,210,32,18,40,128,90,26,105,70,248,75,250,88,145,232,95,148,236,60,114,200,96,117,128,32,2,37,164,239,182,229,97,222,206,58,217,49,190,189,45,178,125,190,204,143,134,255,53,195,35,173,229,245,205,237,188,17,226,83,92,202,164,63,226,151,255,40,134,218,39,244,171,79,220,45,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d438be3-42dd-4256-9b99-40dbca5fc709"));
		}

		#endregion

	}

	#endregion

}

