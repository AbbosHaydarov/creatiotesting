namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationServiceSchema

	/// <exclude/>
	public class ITranslationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationServiceSchema(ITranslationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8368303c-f5ee-4bf3-920a-9f76b46f2286");
			Name = "ITranslationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,221,83,77,139,194,48,20,60,87,240,63,132,122,169,80,250,3,148,61,184,194,66,23,186,138,45,120,40,123,136,233,107,13,182,73,54,73,11,221,101,255,251,190,182,42,138,226,221,189,132,100,50,243,230,77,62,4,173,192,40,202,128,36,160,53,53,50,183,193,82,138,156,23,181,166,150,75,17,36,154,10,83,246,243,241,232,103,60,114,106,195,69,65,226,214,88,168,130,24,116,195,25,68,50,131,114,254,104,51,216,194,14,9,72,153,104,40,176,24,9,133,5,157,163,245,140,132,23,38,71,81,79,77,143,11,236,200,106,202,172,247,129,237,146,23,226,222,242,221,233,39,10,84,189,43,57,35,252,84,250,126,101,7,99,224,120,238,36,2,187,151,153,153,145,117,47,31,54,211,149,130,225,8,78,238,157,129,147,98,142,80,52,242,0,222,32,235,218,89,175,226,196,245,201,6,190,106,48,246,77,234,138,90,196,145,26,129,49,180,128,1,10,222,141,20,62,121,149,89,27,219,182,132,43,202,25,13,182,154,42,5,153,223,217,57,27,188,30,41,12,60,46,218,135,119,26,201,51,178,96,182,166,37,255,134,139,228,222,116,254,180,161,110,47,240,164,38,11,165,202,246,255,199,92,238,129,29,238,197,156,128,200,134,39,220,175,127,135,239,117,5,34,246,7,8,245,149,191,227,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8368303c-f5ee-4bf3-920a-9f76b46f2286"));
		}

		#endregion

	}

	#endregion

}

