namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastObjectValueAddFromSelectOperationSchema

	/// <exclude/>
	public class IForecastObjectValueAddFromSelectOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastObjectValueAddFromSelectOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastObjectValueAddFromSelectOperationSchema(IForecastObjectValueAddFromSelectOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856");
			Name = "IForecastObjectValueAddFromSelectOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,145,77,75,195,64,16,134,207,13,228,63,12,57,41,148,4,188,90,11,86,45,244,84,48,210,251,118,119,210,174,238,71,220,143,106,145,254,119,247,163,41,41,226,37,48,51,121,159,121,38,81,68,162,237,9,69,120,67,99,136,213,157,171,159,180,234,248,206,27,226,184,86,245,82,27,164,196,186,205,93,89,252,148,197,196,91,174,118,208,30,173,67,121,127,169,199,105,131,245,243,34,140,194,176,105,26,152,89,47,37,49,199,249,185,94,41,135,166,139,43,59,109,128,48,22,243,221,121,11,232,237,59,82,7,7,34,60,66,232,105,195,108,61,144,154,17,170,247,91,193,41,240,11,109,53,152,174,19,98,19,9,143,140,45,141,150,45,138,208,89,247,152,111,10,233,112,73,120,254,241,155,196,6,188,124,35,245,14,163,219,160,0,78,195,136,159,224,175,105,20,229,82,236,202,46,119,122,98,136,4,21,190,241,67,101,247,136,174,154,15,16,72,117,61,107,210,59,255,68,146,118,53,207,250,83,248,226,110,15,68,136,32,245,233,185,65,6,84,11,47,149,189,194,28,52,103,176,240,226,35,28,159,21,237,77,27,151,229,149,83,200,56,200,244,219,248,15,79,101,113,250,5,70,234,142,162,10,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("215656b7-d84b-1549-3dd0-2a8672dc7856"));
		}

		#endregion

	}

	#endregion

}

