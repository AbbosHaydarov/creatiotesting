namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ObjectFilesCopySettingsSchema

	/// <exclude/>
	public class ObjectFilesCopySettingsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ObjectFilesCopySettingsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ObjectFilesCopySettingsSchema(ObjectFilesCopySettingsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c876db7-b521-4b78-af16-6a8f941e5884");
			Name = "ObjectFilesCopySettings";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8b1c57bf-1ff6-4af0-890b-4cc1ace5ccaa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,146,193,110,194,48,12,134,207,32,241,14,150,184,211,59,76,187,84,12,237,52,88,217,3,132,212,109,51,181,73,23,39,154,42,180,119,159,147,2,130,173,76,140,75,85,255,245,31,127,249,93,45,26,164,86,72,132,45,90,43,200,20,110,150,26,93,168,210,91,225,148,209,147,241,126,50,30,121,82,186,132,172,35,135,205,226,84,159,91,44,206,150,218,41,167,144,184,129,91,166,22,75,246,67,90,11,162,57,188,236,222,81,186,39,85,35,165,166,237,50,116,142,143,160,216,154,36,9,60,144,111,26,97,187,199,67,253,138,173,69,66,237,8,76,180,66,17,188,32,217,12,116,112,207,142,230,228,204,221,250,93,173,36,200,48,247,250,216,17,95,139,159,39,204,181,53,45,218,128,63,135,117,60,161,255,254,147,45,10,43,12,88,54,112,16,44,179,13,56,195,239,117,160,252,172,148,172,34,107,16,3,109,128,252,77,121,196,140,161,117,153,172,176,17,27,143,182,27,80,246,80,162,91,132,105,11,248,186,21,203,107,245,225,17,84,206,25,170,66,161,5,83,64,142,196,247,143,139,133,160,59,206,50,14,250,27,114,229,85,14,91,97,25,227,156,238,237,57,191,143,237,18,202,85,200,65,105,205,241,97,126,216,246,13,60,233,209,210,239,248,94,150,193,156,134,144,88,168,125,163,255,79,150,70,223,149,176,166,168,243,254,23,140,117,175,94,138,172,125,3,231,134,208,249,167,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c876db7-b521-4b78-af16-6a8f941e5884"));
		}

		#endregion

	}

	#endregion

}

