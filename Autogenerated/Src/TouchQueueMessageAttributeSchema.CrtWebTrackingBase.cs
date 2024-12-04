namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageAttributeSchema

	/// <exclude/>
	public class TouchQueueMessageAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageAttributeSchema(TouchQueueMessageAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce8a50f0-f46f-4767-8fe8-1b07a8ff7714");
			Name = "TouchQueueMessageAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b315c071-acc2-4708-bf79-a948344c26bd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,143,49,107,195,48,16,133,231,24,252,31,142,116,73,32,88,123,218,4,66,230,64,75,221,169,116,80,212,147,34,144,37,163,59,81,66,200,127,175,98,187,174,59,164,139,224,189,123,122,247,157,151,13,82,43,21,66,141,49,74,10,154,171,125,240,218,154,20,37,219,224,203,226,82,22,179,68,214,27,120,61,19,99,243,88,22,217,121,136,104,242,24,246,78,18,173,161,14,73,157,94,18,38,60,32,145,52,184,99,142,246,152,24,187,244,251,40,223,110,195,197,40,107,25,13,50,85,93,205,10,118,206,133,175,67,114,108,91,135,176,1,45,29,225,242,35,55,180,233,232,172,2,117,203,253,179,13,214,3,101,53,1,152,229,19,242,251,203,28,60,113,76,138,67,204,232,207,93,115,159,16,66,192,19,165,166,145,241,188,253,49,38,113,208,129,129,79,152,67,136,160,34,234,205,252,62,204,92,108,171,177,85,76,107,135,107,238,127,93,44,225,2,215,1,27,253,103,79,222,233,222,253,107,94,203,226,27,118,118,27,107,202,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce8a50f0-f46f-4767-8fe8-1b07a8ff7714"));
		}

		#endregion

	}

	#endregion

}

