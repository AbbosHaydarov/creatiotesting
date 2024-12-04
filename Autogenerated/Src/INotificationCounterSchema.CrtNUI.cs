namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCounterSchema

	/// <exclude/>
	public class INotificationCounterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCounterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCounterSchema(INotificationCounterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b7d7230-b757-4090-bbb0-2b97d1bc90cb");
			Name = "INotificationCounter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,146,193,106,195,48,12,134,207,45,244,29,68,119,217,160,36,247,173,203,165,131,146,203,24,219,94,192,181,149,196,44,182,131,44,119,132,209,119,159,237,52,180,172,236,22,203,191,191,95,250,21,43,12,250,65,72,132,79,36,18,222,53,92,236,156,109,116,27,72,176,118,118,181,252,89,45,23,193,107,219,194,199,232,25,205,211,159,115,212,247,61,202,36,246,197,30,45,146,150,81,19,85,119,132,109,172,66,109,25,169,137,38,143,80,191,58,214,141,150,153,189,115,33,221,100,109,89,150,176,245,193,24,65,99,117,62,191,145,59,106,133,30,4,24,228,206,41,96,7,45,50,112,135,96,131,57,32,129,107,192,94,33,61,28,70,104,201,133,161,152,161,229,21,117,8,135,94,75,208,115,67,255,244,179,72,51,223,180,148,11,239,200,129,162,205,181,41,200,233,97,54,151,206,178,144,156,236,111,253,167,202,32,72,24,176,49,250,231,245,89,94,171,117,21,115,79,159,16,71,182,9,142,84,108,203,172,189,60,165,201,190,122,209,57,240,136,221,192,119,135,132,240,133,35,104,63,205,158,82,201,61,129,176,10,142,162,15,152,238,114,41,50,103,72,162,214,23,210,214,51,197,181,110,82,60,21,236,145,111,178,185,223,7,173,230,9,107,245,144,126,133,211,180,106,180,106,218,246,106,121,250,5,7,170,26,251,85,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7d7230-b757-4090-bbb0-2b97d1bc90cb"));
		}

		#endregion

	}

	#endregion

}

