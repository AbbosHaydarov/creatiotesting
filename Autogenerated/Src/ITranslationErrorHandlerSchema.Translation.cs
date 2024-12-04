namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationErrorHandlerSchema

	/// <exclude/>
	public class ITranslationErrorHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationErrorHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationErrorHandlerSchema(ITranslationErrorHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("89e47229-db11-45c3-8172-96402d1727d6");
			Name = "ITranslationErrorHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,203,110,194,48,16,60,23,137,127,88,193,165,149,170,228,78,83,46,109,213,114,168,132,128,31,48,246,38,88,117,236,104,215,65,138,42,254,189,126,148,71,145,232,201,246,122,60,51,59,235,158,181,109,96,61,176,199,182,120,113,198,160,244,218,89,46,222,209,34,105,249,52,30,141,71,86,180,200,157,144,8,27,36,18,236,106,31,176,182,214,77,79,34,194,139,13,9,203,38,237,199,163,239,248,230,110,74,216,132,35,44,172,71,170,195,227,25,44,46,96,111,68,142,62,132,85,6,41,225,187,126,107,180,4,125,132,255,131,190,203,10,39,137,79,244,59,167,120,6,203,196,145,47,203,178,132,138,251,182,21,52,204,143,133,37,18,107,246,12,161,15,71,12,78,202,158,80,129,234,41,230,32,186,206,12,113,227,207,210,92,156,216,202,107,186,170,19,36,90,136,249,60,79,34,165,117,61,175,80,58,82,60,153,39,211,16,162,99,209,32,131,204,233,6,181,58,148,3,134,66,168,206,170,43,61,248,194,129,139,170,76,212,73,105,239,180,130,181,216,99,34,228,251,87,157,102,20,140,84,236,163,239,71,200,235,60,181,117,225,225,33,141,239,70,22,43,108,221,62,248,18,198,228,56,206,86,107,114,45,248,93,152,247,133,47,47,182,6,111,132,145,44,174,144,209,255,122,60,42,79,209,170,60,165,116,62,228,175,241,167,120,128,31,84,94,232,17,133,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("89e47229-db11-45c3-8172-96402d1727d6"));
		}

		#endregion

	}

	#endregion

}

