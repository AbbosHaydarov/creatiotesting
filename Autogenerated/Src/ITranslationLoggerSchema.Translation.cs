namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationLoggerSchema

	/// <exclude/>
	public class ITranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationLoggerSchema(ITranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d");
			Name = "ITranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,80,65,10,194,48,16,60,91,232,31,22,188,232,197,7,216,147,136,135,130,130,104,63,16,211,77,140,180,217,178,73,69,17,255,110,76,177,164,224,37,155,217,153,217,157,196,138,22,93,39,36,66,133,204,194,145,242,171,45,89,101,116,207,194,27,178,171,138,133,117,77,188,231,217,43,207,102,189,51,86,195,249,233,60,182,197,136,83,59,99,234,42,242,44,168,230,140,58,0,40,173,71,86,97,225,26,202,68,180,39,173,145,163,178,235,47,141,145,96,126,194,191,186,89,72,18,206,113,236,1,253,149,106,183,134,99,116,15,228,157,76,13,59,102,226,197,238,33,177,251,14,0,92,134,64,19,174,220,200,47,115,66,215,55,30,56,150,68,84,90,69,11,186,220,80,122,8,159,229,132,142,35,226,118,180,245,16,32,226,247,240,210,73,51,244,62,69,103,9,128,100,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d"));
		}

		#endregion

	}

	#endregion

}

