namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationProviderSchema

	/// <exclude/>
	public class ITranslationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationProviderSchema(ITranslationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd13a96a-b434-42c3-9a58-2582a3d879ed");
			Name = "ITranslationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,173,148,223,107,219,48,16,199,159,83,232,255,32,210,23,15,140,253,222,122,134,145,133,97,216,70,105,194,246,172,218,151,84,204,150,194,157,20,22,198,254,247,157,164,252,112,82,39,77,97,47,193,58,125,117,250,222,231,46,210,178,3,90,201,26,196,28,16,37,153,133,205,38,70,47,212,210,161,180,202,232,108,142,82,83,27,190,111,111,254,220,222,140,28,41,189,20,179,13,89,232,30,78,214,124,182,109,161,246,98,202,190,128,6,84,245,65,211,191,2,33,155,106,171,172,2,98,1,75,238,16,150,124,76,84,218,2,46,216,209,189,168,122,119,63,162,89,171,6,48,104,87,238,185,85,181,80,59,233,25,229,136,237,242,239,62,245,55,176,47,166,161,123,241,24,206,199,205,60,207,69,65,174,235,36,110,202,93,224,39,42,11,36,236,33,107,182,215,230,167,226,98,37,81,118,66,51,202,143,227,95,176,25,151,79,64,198,33,251,226,85,86,228,97,127,88,222,187,129,209,185,78,127,231,240,184,236,149,35,234,16,15,250,119,230,250,33,91,55,156,108,237,119,142,178,173,141,106,98,217,61,121,66,22,125,227,184,140,84,108,191,7,29,159,223,13,30,62,60,92,96,61,3,63,49,36,234,23,169,151,208,244,83,108,237,82,244,75,215,246,0,252,96,113,27,194,128,189,209,0,4,217,196,185,56,15,74,172,208,212,64,97,134,187,160,125,141,238,137,243,76,98,5,243,83,6,20,32,80,18,253,136,104,47,21,159,194,255,164,136,228,118,4,83,63,213,169,248,44,185,17,170,131,82,28,12,94,164,232,239,31,100,216,163,214,175,155,54,52,113,173,117,8,84,233,133,121,63,172,115,250,163,214,92,64,67,201,87,69,182,168,102,123,35,222,71,41,78,140,165,62,205,232,63,163,34,24,158,55,226,204,156,237,74,98,241,201,19,245,54,200,110,22,6,187,248,90,92,133,133,109,12,112,153,121,11,73,53,213,174,3,148,207,45,188,201,232,98,181,211,223,80,59,255,152,201,192,144,93,198,138,227,114,184,212,184,55,46,35,246,107,138,9,5,196,99,73,60,181,189,111,231,237,14,116,19,159,225,176,254,27,223,252,163,32,199,254,1,88,33,14,59,143,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd13a96a-b434-42c3-9a58-2582a3d879ed"));
		}

		#endregion

	}

	#endregion

}

