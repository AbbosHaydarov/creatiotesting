namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWorkplaceInfoNavigationPanelProviderSchema

	/// <exclude/>
	public class IWorkplaceInfoNavigationPanelProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWorkplaceInfoNavigationPanelProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWorkplaceInfoNavigationPanelProviderSchema(IWorkplaceInfoNavigationPanelProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("161e712a-6f4f-41c5-b81a-63cb2bfef4ba");
			Name = "IWorkplaceInfoNavigationPanelProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d699061b-815e-49b9-8730-21a5e5db2044");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,193,74,196,48,16,134,207,22,250,14,3,94,244,210,222,117,89,16,15,203,130,43,5,5,207,177,157,116,131,233,76,152,36,43,139,248,238,38,233,218,85,193,91,38,249,243,205,55,19,189,161,17,158,142,62,224,212,220,179,181,216,7,195,228,155,13,18,138,233,111,235,42,150,200,51,138,40,207,58,164,20,105,51,70,81,57,216,60,170,131,25,203,113,135,20,151,248,11,203,155,179,170,199,59,103,210,101,93,181,109,11,43,31,167,73,201,113,61,151,75,6,12,105,134,65,5,5,78,248,96,6,20,208,44,64,11,27,156,34,180,205,9,211,158,57,46,190,90,211,39,64,64,209,25,181,93,168,91,210,124,182,235,50,160,59,209,235,234,35,59,93,92,10,142,153,190,195,176,231,193,223,64,87,112,229,237,143,112,169,31,88,13,30,222,83,7,239,82,7,63,139,255,163,58,19,126,184,206,23,130,33,10,249,117,246,44,20,24,133,163,243,208,47,219,95,181,223,161,244,233,247,130,55,37,155,71,43,50,249,112,117,93,22,156,199,65,26,230,137,114,249,249,5,183,47,184,195,220,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("161e712a-6f4f-41c5-b81a-63cb2bfef4ba"));
		}

		#endregion

	}

	#endregion

}

