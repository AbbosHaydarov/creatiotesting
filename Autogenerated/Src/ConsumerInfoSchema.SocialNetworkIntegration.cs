namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConsumerInfoSchema

	/// <exclude/>
	public class ConsumerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConsumerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConsumerInfoSchema(ConsumerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("12a01026-e84b-495c-b275-01c91bdee21b");
			Name = "ConsumerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,157,144,65,75,196,48,16,133,207,45,244,63,132,221,139,94,250,3,20,79,235,69,22,101,177,226,69,60,100,227,107,9,54,73,153,153,10,85,246,191,59,77,85,80,86,4,47,97,102,222,203,55,121,137,54,128,7,235,96,238,64,100,57,181,82,111,82,108,125,55,146,21,159,98,221,36,231,109,95,149,111,85,89,140,236,99,103,154,137,5,161,190,29,163,248,128,186,1,169,193,191,102,251,121,85,170,111,77,232,180,49,155,222,50,159,25,5,242,24,64,87,177,77,89,127,184,180,98,117,42,100,157,60,234,96,24,247,189,119,198,205,254,31,246,66,23,235,249,197,220,81,26,64,226,161,224,93,190,182,232,153,121,141,176,7,157,220,104,42,115,97,86,207,152,86,167,51,255,115,1,11,205,9,182,152,204,156,167,40,58,136,62,89,11,254,40,14,191,211,24,142,32,71,129,77,150,254,193,124,1,177,166,58,10,189,95,180,63,168,107,196,167,229,107,114,191,76,191,15,15,239,195,42,56,60,230,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12a01026-e84b-495c-b275-01c91bdee21b"));
		}

		#endregion

	}

	#endregion

}

