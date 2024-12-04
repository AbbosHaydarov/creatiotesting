namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OperatorLogoutEventHandlerSchema

	/// <exclude/>
	public class OperatorLogoutEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OperatorLogoutEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OperatorLogoutEventHandlerSchema(OperatorLogoutEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c46064d2-8bfb-8ae3-a732-e51330addf7c");
			Name = "OperatorLogoutEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,82,77,79,195,48,12,61,15,137,255,96,141,75,39,77,233,29,216,14,140,33,38,49,64,26,156,16,7,147,184,93,164,54,169,242,49,152,16,255,29,167,235,6,3,198,37,141,157,247,236,250,249,25,172,201,55,40,9,30,200,57,244,182,8,98,98,77,161,203,232,48,104,107,196,93,109,180,92,162,49,84,137,57,121,143,165,54,229,241,209,251,241,81,47,122,190,194,98,237,3,213,103,187,248,123,33,71,135,242,226,10,101,176,78,147,103,4,99,78,28,149,220,14,38,21,122,127,10,119,13,113,127,235,110,108,105,99,152,174,200,132,107,52,170,34,215,162,243,60,135,115,31,235,26,221,122,220,197,11,10,96,59,26,248,128,129,128,235,69,79,14,170,182,138,216,18,243,31,204,115,79,132,149,183,32,29,21,163,254,236,119,211,126,62,78,236,167,75,42,48,86,225,66,27,197,35,101,97,221,144,45,178,63,8,131,33,220,178,180,48,130,254,225,81,250,131,103,46,218,196,151,74,75,144,105,240,127,230,134,83,248,163,15,243,121,19,124,238,4,156,83,88,90,197,18,222,183,117,55,143,237,148,218,44,201,233,160,172,60,60,168,216,124,219,84,246,200,218,177,25,12,201,228,132,1,139,144,106,117,255,187,178,90,193,97,52,68,57,128,100,146,94,47,184,117,119,235,173,208,129,140,206,49,62,193,103,138,5,138,82,76,190,82,98,166,146,101,58,236,118,159,115,52,88,178,6,35,48,244,186,19,169,203,102,220,170,227,252,192,139,9,27,183,164,45,126,145,76,145,237,245,31,194,55,127,239,236,205,99,248,224,197,30,79,204,12,59,86,175,136,237,171,168,107,248,1,18,131,92,66,54,125,147,212,180,42,193,59,124,164,55,62,218,181,144,81,155,205,180,241,38,187,159,228,220,39,203,86,127,12,135,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c46064d2-8bfb-8ae3-a732-e51330addf7c"));
		}

		#endregion

	}

	#endregion

}

