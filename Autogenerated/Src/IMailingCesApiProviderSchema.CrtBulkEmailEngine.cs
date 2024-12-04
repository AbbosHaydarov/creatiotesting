namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingCesApiProviderSchema

	/// <exclude/>
	public class IMailingCesApiProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingCesApiProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingCesApiProviderSchema(IMailingCesApiProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f92e69c-eee5-45ac-b699-e41c1b0f5a69");
			Name = "IMailingCesApiProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,193,110,219,48,12,61,167,64,255,129,72,47,27,80,196,247,38,13,176,102,65,97,96,5,138,164,216,101,232,65,181,105,87,152,45,121,162,148,45,8,242,239,163,108,57,113,107,199,135,56,54,245,200,247,30,41,42,81,34,85,34,65,120,65,99,4,233,204,206,86,90,101,50,119,70,88,169,213,245,213,225,250,106,226,72,170,28,182,123,178,88,206,79,223,23,82,102,171,245,150,65,12,187,49,152,115,0,98,101,209,100,204,114,7,241,147,144,5,39,175,144,190,85,242,217,232,157,76,209,212,232,40,138,96,65,174,44,133,217,47,195,119,0,16,200,182,4,88,13,186,66,166,66,248,43,237,59,196,76,199,165,24,65,86,168,4,103,109,169,168,83,171,114,111,133,76,58,85,134,117,156,245,157,149,77,184,1,252,60,153,225,19,166,183,18,233,14,158,235,178,254,212,255,62,27,168,3,113,144,5,58,227,67,68,72,12,102,247,211,7,87,252,94,151,204,181,222,161,178,63,116,158,163,153,70,203,91,168,90,199,5,199,124,151,217,111,15,12,86,188,21,200,118,224,251,131,247,219,55,60,25,34,232,23,242,193,3,228,104,231,112,108,108,14,154,120,68,75,160,13,144,255,151,195,142,194,28,216,196,176,160,118,78,91,52,59,153,160,127,109,152,143,109,255,110,80,165,77,147,107,41,141,160,254,228,214,255,44,3,49,125,66,34,145,227,79,81,200,84,88,61,48,60,56,140,120,10,121,220,233,178,41,116,161,145,117,164,18,70,148,160,120,91,238,167,187,38,145,101,110,240,143,67,178,211,101,168,229,175,135,105,98,139,168,78,57,87,48,104,157,81,244,17,74,174,176,179,69,212,158,121,112,176,112,134,109,120,65,181,34,60,9,14,190,219,54,124,233,66,107,110,232,41,252,58,63,245,115,104,203,250,242,71,118,40,41,4,17,244,73,199,122,29,36,3,15,69,89,153,201,122,175,6,122,29,40,30,157,76,127,189,182,89,113,74,237,29,229,251,55,126,81,55,152,200,74,50,9,65,162,157,242,62,46,211,240,157,234,36,172,60,190,75,52,198,179,229,214,215,203,185,175,112,148,35,0,95,24,247,225,253,147,161,48,156,238,6,28,255,3,186,157,33,173,156,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f92e69c-eee5-45ac-b699-e41c1b0f5a69"));
		}

		#endregion

	}

	#endregion

}

