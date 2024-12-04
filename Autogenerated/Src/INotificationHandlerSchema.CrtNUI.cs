namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationHandlerSchema

	/// <exclude/>
	public class INotificationHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationHandlerSchema(INotificationHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9c66d6e-bd4a-4fc2-8d6b-edbb5e21ba56");
			Name = "INotificationHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,101,144,77,106,195,48,16,133,215,49,248,14,67,86,233,198,58,64,93,111,74,73,189,41,129,246,2,138,50,74,5,210,200,140,164,64,40,185,123,101,185,77,226,120,57,63,239,125,111,134,164,195,48,72,133,240,133,204,50,120,29,155,87,79,218,28,19,203,104,60,213,213,79,93,173,82,48,116,132,207,115,136,232,242,220,90,84,227,48,52,91,36,100,163,158,235,42,111,9,33,160,13,201,57,201,231,238,175,238,41,34,235,17,160,61,195,192,94,97,40,102,228,163,209,70,21,72,104,254,213,226,78,62,164,189,53,10,204,213,161,255,184,211,188,75,58,88,228,188,55,6,92,176,75,99,55,225,48,44,105,75,220,212,25,36,75,7,148,223,242,178,158,137,214,221,237,110,240,26,226,55,62,184,182,162,136,139,215,201,155,3,76,17,55,253,27,37,135,44,247,22,219,217,9,61,105,223,205,77,158,242,39,87,151,186,186,252,2,212,221,233,35,153,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9c66d6e-bd4a-4fc2-8d6b-edbb5e21ba56"));
		}

		#endregion

	}

	#endregion

}

