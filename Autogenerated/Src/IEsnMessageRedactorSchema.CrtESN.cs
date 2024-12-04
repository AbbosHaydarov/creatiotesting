namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnMessageRedactorSchema

	/// <exclude/>
	public class IEsnMessageRedactorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnMessageRedactorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnMessageRedactorSchema(IEsnMessageRedactorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95f9fa02-7c86-4d9f-a8c2-7614daa3758a");
			Name = "IEsnMessageRedactor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,213,86,193,142,218,48,20,60,131,196,63,60,209,67,23,9,37,247,118,151,11,160,21,135,109,171,178,82,207,38,126,33,214,198,54,178,157,34,84,237,191,215,177,157,144,44,20,148,5,164,238,209,246,243,188,153,241,155,40,130,112,212,27,146,32,60,163,82,68,203,212,68,83,41,82,182,46,20,49,76,138,104,190,252,54,232,255,25,244,123,133,102,98,13,203,157,54,200,191,214,235,169,84,24,205,133,97,134,161,182,219,246,224,147,194,181,189,9,176,16,6,85,106,193,191,192,98,174,197,19,106,77,214,248,19,41,73,140,84,174,54,142,99,184,215,5,231,68,237,38,97,253,67,201,223,140,162,6,142,38,147,84,67,42,21,104,153,48,146,131,64,179,149,234,5,148,3,41,9,112,143,170,163,10,45,110,192,109,138,85,206,18,96,21,145,227,60,122,165,188,3,42,158,139,212,6,176,148,183,251,92,18,114,55,203,86,135,189,252,206,134,40,194,65,88,91,31,134,161,124,70,12,25,78,66,87,160,118,21,221,199,174,174,190,182,101,38,3,147,33,100,152,111,64,166,150,8,34,36,10,211,135,161,101,252,75,49,131,1,96,246,252,125,24,79,28,133,199,130,81,199,48,28,221,29,150,66,131,195,200,63,207,9,161,161,216,42,77,36,231,86,118,71,165,11,186,215,185,160,7,42,91,87,66,7,111,206,212,47,110,98,78,192,190,115,27,53,209,49,28,49,171,193,233,164,89,115,202,46,158,138,189,83,219,76,106,88,33,160,69,197,51,174,181,70,106,105,84,35,1,221,124,115,228,43,175,86,82,230,78,84,61,72,238,184,66,30,131,110,117,250,40,254,52,35,119,126,104,110,104,223,5,185,116,86,190,59,151,161,124,31,176,46,94,182,18,26,102,173,234,255,246,226,123,220,170,130,25,220,10,208,245,176,117,10,227,127,224,80,243,27,214,125,218,174,105,224,5,95,182,25,230,104,240,250,217,165,14,151,94,44,219,243,59,158,179,209,13,133,253,115,76,174,43,236,248,139,150,194,122,175,254,223,10,5,245,191,87,131,254,235,95,143,8,229,160,189,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95f9fa02-7c86-4d9f-a8c2-7614daa3758a"));
		}

		#endregion

	}

	#endregion

}

