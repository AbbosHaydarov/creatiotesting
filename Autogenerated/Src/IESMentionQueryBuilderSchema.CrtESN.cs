namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESMentionQueryBuilderSchema

	/// <exclude/>
	public class IESMentionQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESMentionQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESMentionQueryBuilderSchema(IESMentionQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a92e121-7675-4439-bb61-e6af58efe391");
			Name = "IESMentionQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,146,193,110,131,48,12,134,207,173,212,119,176,232,101,187,192,189,107,57,108,66,83,15,149,182,117,47,96,192,208,72,144,48,39,57,84,83,223,125,33,129,14,182,110,199,152,255,243,255,219,70,98,75,186,195,130,224,157,152,81,171,202,196,79,74,86,162,182,140,70,40,25,63,55,42,199,230,72,200,197,105,181,252,92,45,23,86,11,89,207,244,76,113,38,141,48,130,244,195,13,193,180,69,188,151,134,184,114,142,189,212,137,215,76,181,243,129,107,125,3,251,236,120,32,215,79,201,87,75,124,126,180,162,41,137,189,58,73,18,216,106,219,182,200,231,116,120,103,13,106,35,10,208,222,0,218,128,194,71,207,66,30,224,120,100,147,9,220,217,188,113,156,24,157,255,48,6,55,180,83,95,147,30,200,156,84,169,55,240,226,249,240,241,103,48,95,240,13,92,153,8,10,166,106,23,77,187,71,73,10,149,226,33,118,191,177,18,13,106,23,7,104,54,81,159,253,119,248,80,233,144,177,5,233,174,184,139,252,192,81,250,143,157,144,218,160,44,40,222,38,30,252,238,195,100,44,75,61,133,135,181,222,130,71,117,143,135,179,190,145,115,215,38,76,236,145,187,169,121,56,198,125,184,248,98,77,178,12,187,236,223,174,114,9,127,194,172,124,249,2,90,228,185,65,155,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a92e121-7675-4439-bb61-e6af58efe391"));
		}

		#endregion

	}

	#endregion

}

