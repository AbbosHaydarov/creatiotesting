namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICustomTypeWebhookHandlerSchema

	/// <exclude/>
	public class ICustomTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICustomTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICustomTypeWebhookHandlerSchema(ICustomTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87741c9c-aa61-4ad0-b909-e56eff97f745");
			Name = "ICustomTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,193,78,2,49,16,61,67,194,63,76,224,162,23,246,46,43,23,46,122,208,144,72,226,185,236,206,238,86,217,182,153,78,49,132,240,239,78,187,11,10,138,241,210,180,51,243,222,188,247,82,163,90,244,78,21,8,43,36,82,222,86,60,93,88,83,233,58,144,98,109,205,104,184,31,13,7,193,107,83,195,203,206,51,182,179,209,80,42,89,150,65,238,67,219,42,218,205,251,247,43,174,27,107,223,161,8,158,109,11,188,115,8,141,50,229,6,105,122,132,100,223,48,46,172,55,186,0,109,24,169,138,26,30,23,9,185,18,96,207,245,208,193,101,88,100,200,57,152,16,214,34,11,150,100,29,18,107,244,119,176,76,60,93,255,82,87,42,200,240,86,151,72,96,196,110,148,242,83,203,192,51,69,143,199,209,103,153,132,61,212,200,51,56,252,65,157,4,70,96,116,123,133,58,250,129,116,156,19,78,208,148,157,157,115,111,79,200,141,45,255,99,236,180,253,163,143,222,41,18,225,146,39,108,213,38,92,19,148,42,105,52,37,114,63,214,198,5,30,207,251,12,18,20,108,245,11,107,101,233,180,116,154,103,169,241,69,73,200,129,140,159,231,217,241,22,91,118,253,134,5,119,48,188,233,119,164,141,183,221,95,186,12,66,226,57,124,2,142,62,255,79,153,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87741c9c-aa61-4ad0-b909-e56eff97f745"));
		}

		#endregion

	}

	#endregion

}

