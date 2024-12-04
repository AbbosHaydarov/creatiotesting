namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationBatchActualizerSchema

	/// <exclude/>
	public class TranslationBatchActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationBatchActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationBatchActualizerSchema(TranslationBatchActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8fccbdb7-dc23-4a94-a151-19c141114606");
			Name = "TranslationBatchActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,93,75,195,48,20,125,206,96,255,33,176,151,14,70,127,192,134,12,157,8,5,133,161,3,31,37,107,239,186,64,155,140,155,219,130,138,255,221,180,169,181,93,155,233,131,15,190,148,228,126,156,115,207,201,165,74,228,96,78,34,6,190,3,68,97,244,129,194,141,86,7,153,22,40,72,106,21,238,80,40,147,213,231,233,228,125,58,97,133,145,42,229,79,175,134,32,95,181,247,110,59,66,183,203,214,216,170,25,66,106,47,124,147,9,99,150,188,147,191,17,20,31,175,99,42,68,38,223,0,235,234,83,177,207,100,204,227,170,248,66,45,239,1,117,49,152,157,212,126,191,105,181,50,132,69,76,26,45,251,182,134,119,21,13,149,159,36,136,58,185,45,234,82,38,150,153,134,177,69,5,199,88,100,173,217,20,25,21,8,145,58,232,182,195,140,134,23,188,11,127,175,211,180,15,238,34,115,7,189,228,123,97,32,24,227,246,194,15,177,120,245,138,236,227,215,242,31,193,232,2,99,104,149,224,89,160,175,225,95,88,52,28,241,47,77,155,129,74,220,98,245,183,204,2,156,0,73,66,181,99,168,9,98,130,164,241,25,101,41,8,6,70,183,218,95,200,147,89,185,246,6,205,15,224,77,212,147,179,20,168,57,49,4,171,88,249,25,249,122,237,10,89,224,175,185,226,129,143,113,62,178,13,243,90,70,101,224,143,46,62,0,29,117,50,102,225,151,7,186,180,127,27,139,202,75,45,19,30,41,2,84,34,107,119,182,67,31,220,90,211,119,50,7,187,180,34,185,67,157,55,47,201,170,53,9,47,182,182,29,110,116,159,218,240,25,165,229,56,203,130,9,92,223,184,88,23,237,7,109,236,19,210,224,248,226,143,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8fccbdb7-dc23-4a94-a151-19c141114606"));
		}

		#endregion

	}

	#endregion

}

