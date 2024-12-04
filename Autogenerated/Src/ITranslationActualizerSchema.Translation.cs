namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationActualizerSchema

	/// <exclude/>
	public class ITranslationActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationActualizerSchema(ITranslationActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2bd260d-8139-4e57-b269-fae5dc20c315");
			Name = "ITranslationActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,82,193,106,131,64,16,61,39,144,127,24,146,75,122,209,123,146,6,66,154,210,64,11,133,72,123,158,234,104,22,116,55,204,142,66,90,250,239,93,21,141,218,166,228,34,58,243,230,189,55,207,209,152,145,61,97,72,16,16,51,90,19,139,183,53,58,86,73,206,40,202,104,47,96,212,54,173,222,39,227,175,201,120,148,91,165,19,56,156,173,80,182,108,191,187,227,76,222,78,139,18,69,214,1,28,100,198,148,184,121,216,107,33,142,157,218,2,246,29,222,77,40,57,166,234,147,184,66,159,242,143,84,133,160,26,240,85,236,200,217,113,207,150,126,87,144,22,187,128,215,138,160,238,81,89,171,59,79,168,163,148,120,245,206,74,232,217,132,37,13,126,164,244,134,105,78,21,98,195,137,93,195,223,125,102,195,245,54,163,25,233,168,150,236,235,191,144,28,77,52,48,224,251,62,172,108,158,101,200,231,117,83,104,183,176,32,151,221,188,22,239,15,7,86,39,100,204,64,187,223,117,63,197,102,250,145,77,54,93,7,71,130,8,133,64,12,88,65,22,104,0,21,43,196,14,229,173,252,138,161,34,44,140,138,46,22,58,225,206,31,28,77,160,50,130,158,196,221,242,182,85,210,75,102,80,148,161,217,43,27,21,61,3,195,168,237,252,95,193,3,73,47,181,114,103,161,91,179,235,12,186,228,58,217,255,10,200,233,236,109,7,177,61,162,78,40,154,87,167,125,238,58,104,236,14,238,226,187,190,253,94,209,213,126,0,189,94,250,73,115,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2bd260d-8139-4e57-b269-fae5dc20c315"));
		}

		#endregion

	}

	#endregion

}

