namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookPermissionSchema

	/// <exclude/>
	public class FacebookPermissionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookPermissionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookPermissionSchema(FacebookPermissionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9463608-7170-4f90-8842-6c14ece0a0d4");
			Name = "FacebookPermission";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,117,144,65,110,194,64,12,69,215,137,148,59,88,98,211,74,85,14,0,98,83,42,150,85,36,184,192,48,152,212,106,152,137,108,103,133,184,59,206,36,133,32,210,205,140,244,253,109,191,239,224,206,40,173,243,8,123,100,118,18,79,90,110,98,56,81,221,177,83,138,161,220,69,79,174,41,242,75,145,23,121,182,96,172,77,133,77,227,68,150,176,181,206,67,140,191,21,242,153,68,172,146,92,109,119,104,200,131,239,77,51,30,88,194,167,19,156,8,195,240,251,244,138,99,139,172,132,182,162,74,179,134,250,56,87,148,41,212,240,109,236,112,169,81,87,32,246,92,231,60,95,40,158,169,237,147,252,107,173,238,28,59,117,218,9,140,223,139,127,129,225,56,16,62,227,218,193,108,93,231,53,242,60,240,235,9,222,70,190,96,25,62,254,96,143,15,216,247,254,36,89,150,233,15,73,153,130,174,147,119,245,80,167,209,214,211,222,228,153,71,30,212,103,241,122,3,218,221,222,146,4,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9463608-7170-4f90-8842-6c14ece0a0d4"));
		}

		#endregion

	}

	#endregion

}

