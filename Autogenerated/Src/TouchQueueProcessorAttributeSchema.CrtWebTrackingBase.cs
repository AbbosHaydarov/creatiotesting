namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueProcessorAttributeSchema

	/// <exclude/>
	public class TouchQueueProcessorAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueProcessorAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueProcessorAttributeSchema(TouchQueueProcessorAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9dc9ea7-5170-4749-8f69-4d60ffecdb57");
			Name = "TouchQueueProcessorAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,80,49,142,194,48,16,172,47,82,254,176,130,230,174,137,123,14,144,16,31,56,116,161,66,87,44,102,99,44,37,118,216,181,11,116,226,239,216,4,130,68,65,231,153,29,207,236,142,195,142,164,71,77,80,19,51,138,111,66,181,246,174,177,38,50,6,235,93,89,252,151,197,71,20,235,12,252,158,37,80,247,93,22,137,153,50,153,52,134,117,139,34,51,168,125,212,199,77,164,72,63,236,53,137,120,94,133,192,118,31,3,221,244,74,41,152,75,236,58,228,243,242,142,71,5,4,15,7,106,172,203,175,100,4,167,236,4,105,53,65,67,208,63,44,65,231,180,234,97,167,94,252,230,66,132,173,120,208,76,205,98,50,172,91,141,41,19,80,89,185,27,137,109,118,255,28,97,141,108,40,72,117,59,233,235,47,73,251,184,111,173,30,82,223,158,8,179,123,57,207,180,244,61,55,119,25,218,34,119,24,10,203,48,113,87,185,156,196,129,120,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9dc9ea7-5170-4749-8f69-4d60ffecdb57"));
		}

		#endregion

	}

	#endregion

}

