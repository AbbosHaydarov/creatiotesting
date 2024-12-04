namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISynchronizationUCManagerSchema

	/// <exclude/>
	public class ISynchronizationUCManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISynchronizationUCManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISynchronizationUCManagerSchema(ISynchronizationUCManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e35281b7-8278-4872-974a-551e3823b083");
			Name = "ISynchronizationUCManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,84,193,106,219,64,16,61,59,144,127,24,156,75,11,65,186,215,138,160,4,99,124,104,41,77,211,251,70,30,201,11,210,200,157,157,45,184,33,255,222,217,221,218,145,148,216,228,16,122,17,236,206,155,55,111,222,204,138,76,135,110,103,42,132,31,200,108,92,95,75,118,219,83,109,27,207,70,108,79,151,23,143,151,23,51,239,44,53,112,183,119,130,221,98,114,86,124,219,98,21,192,46,91,33,33,219,234,25,51,164,101,60,117,159,45,73,172,88,116,175,1,238,246,20,8,53,114,197,216,104,25,88,147,32,215,170,250,19,172,67,116,203,61,217,63,81,239,253,237,23,67,166,65,142,9,59,255,208,218,10,236,1,127,14,62,211,70,245,59,203,243,28,10,231,187,206,240,190,60,92,124,199,214,8,110,52,128,8,21,99,125,51,159,82,169,109,194,193,10,158,231,37,216,110,215,98,135,36,49,6,164,62,103,71,246,124,72,239,132,147,153,39,216,190,106,42,60,66,131,178,128,167,179,18,197,51,57,240,14,217,129,108,141,192,214,56,40,118,134,77,167,138,163,134,155,185,74,178,178,15,18,221,184,34,84,90,210,84,2,118,227,160,181,78,78,232,141,55,145,116,204,88,14,188,89,30,139,88,114,98,168,194,172,200,99,206,235,20,90,86,21,204,203,137,9,144,238,161,238,249,116,31,231,153,131,27,234,37,165,5,29,137,188,31,135,206,138,229,100,110,25,114,14,70,169,213,100,127,121,84,195,130,152,218,6,223,163,113,69,126,192,7,130,245,146,124,135,108,30,90,44,86,222,110,74,88,161,76,247,48,12,237,67,178,13,82,107,215,113,37,62,87,3,35,174,97,172,57,206,250,249,248,113,241,134,245,224,127,155,156,138,104,47,173,239,8,126,155,214,227,127,28,184,127,223,177,188,80,162,255,36,109,235,103,232,106,194,48,156,204,11,108,152,204,55,195,218,96,124,240,241,29,30,131,211,241,188,101,22,233,193,94,33,109,210,175,43,28,159,254,2,229,7,134,54,117,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e35281b7-8278-4872-974a-551e3823b083"));
		}

		#endregion

	}

	#endregion

}

