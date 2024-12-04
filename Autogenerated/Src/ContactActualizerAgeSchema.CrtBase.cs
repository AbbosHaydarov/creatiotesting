namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactActualizerAgeSchema

	/// <exclude/>
	public class ContactActualizerAgeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactActualizerAgeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactActualizerAgeSchema(ContactActualizerAgeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6997510-8ca5-4b43-92fb-c0f6cd54daae");
			Name = "ContactActualizerAge";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,165,83,205,110,194,48,12,62,131,212,119,176,224,194,164,9,237,204,4,18,148,29,183,33,109,60,64,72,221,18,45,164,85,226,76,99,136,119,159,75,75,161,165,21,135,93,80,99,127,63,118,242,97,196,14,93,38,36,194,39,90,43,92,26,211,56,76,77,172,18,111,5,169,212,4,253,67,208,239,121,167,76,82,131,88,124,14,250,220,25,90,76,24,6,16,106,225,220,4,152,76,66,210,92,146,23,90,253,226,60,193,19,46,243,27,173,36,200,28,117,3,178,140,130,9,44,132,195,90,141,121,236,206,191,149,13,51,29,89,47,41,181,19,88,157,52,11,64,169,223,166,60,90,59,180,220,48,40,243,141,192,215,142,15,108,188,97,227,81,179,124,128,227,63,165,31,65,25,130,112,235,205,215,7,19,138,227,171,248,89,98,98,17,223,227,149,176,66,107,212,202,237,174,160,43,155,74,116,249,133,47,81,139,125,247,124,249,108,61,21,195,168,114,128,25,60,157,27,61,218,42,55,190,180,166,151,65,248,229,184,127,172,248,237,35,221,138,117,224,166,29,59,53,109,218,182,235,152,184,137,42,135,111,148,175,12,202,167,26,162,137,138,164,4,181,216,48,49,67,75,10,57,161,252,77,124,135,24,21,144,236,124,132,244,155,243,173,34,4,78,88,30,247,23,67,138,246,111,252,15,129,233,12,6,229,251,15,78,174,221,172,117,22,9,194,130,27,166,218,239,76,165,192,129,185,199,46,120,75,86,104,112,23,202,210,54,175,231,10,45,171,22,23,80,47,30,255,0,163,255,39,212,222,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6997510-8ca5-4b43-92fb-c0f6cd54daae"));
		}

		#endregion

	}

	#endregion

}

