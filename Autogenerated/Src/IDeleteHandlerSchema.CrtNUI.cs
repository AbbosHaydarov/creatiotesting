namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeleteHandlerSchema

	/// <exclude/>
	public class IDeleteHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeleteHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeleteHandlerSchema(IDeleteHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("20195bd2-50b1-4e93-a074-7128a08c449a");
			Name = "IDeleteHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,77,78,195,48,16,133,215,69,226,14,163,118,3,155,102,79,67,55,165,130,44,216,20,46,224,198,147,200,82,108,71,227,177,68,84,113,119,252,147,180,17,21,162,187,204,248,189,124,126,227,49,66,163,235,69,141,240,137,68,194,217,134,215,59,107,26,213,122,18,172,172,129,211,253,221,194,59,101,90,248,24,28,163,222,156,235,185,131,112,189,55,172,88,161,11,130,32,89,17,182,209,94,25,70,106,2,224,9,170,23,236,144,241,77,24,217,33,37,85,81,20,80,58,175,181,160,97,59,214,149,238,59,212,104,24,100,210,3,97,109,73,130,109,32,52,21,15,235,201,88,204,156,189,63,118,170,6,53,225,126,209,98,140,160,186,2,166,198,1,217,147,113,128,95,53,246,41,116,96,101,120,100,93,195,22,251,179,242,242,117,130,22,121,3,223,183,128,136,44,65,152,188,19,45,254,11,115,76,113,220,251,104,122,31,61,55,192,114,254,0,75,67,131,227,48,13,82,201,216,106,20,210,31,192,212,233,5,9,13,38,236,199,243,50,27,43,185,220,166,71,30,230,191,40,139,164,188,24,41,135,220,30,208,249,142,103,233,202,98,58,138,218,163,181,221,120,199,135,87,175,228,120,187,74,62,230,5,202,209,86,104,100,222,164,88,134,222,15,247,52,133,157,177,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("20195bd2-50b1-4e93-a074-7128a08c449a"));
		}

		#endregion

	}

	#endregion

}

