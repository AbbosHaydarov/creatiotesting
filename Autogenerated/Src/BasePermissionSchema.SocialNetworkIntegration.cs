namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BasePermissionSchema

	/// <exclude/>
	public class BasePermissionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BasePermissionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BasePermissionSchema(BasePermissionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61e6f54e-7847-49e3-aff5-86a7ed440807");
			Name = "BasePermission";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,109,144,193,78,195,48,12,134,207,157,212,119,176,196,21,85,112,221,196,133,13,237,130,80,69,121,129,144,121,149,165,212,45,118,114,128,105,239,142,211,50,1,93,47,137,108,127,254,127,219,236,58,212,193,121,132,55,20,113,218,31,99,181,237,249,72,109,18,23,169,231,170,233,61,185,80,174,78,229,170,92,21,73,137,91,104,62,53,98,103,96,8,232,51,165,213,30,25,133,252,102,206,60,19,127,92,37,95,19,71,234,176,106,172,197,5,250,26,157,140,50,238,70,176,181,0,158,56,117,107,168,81,58,82,181,68,19,93,76,58,34,67,122,15,228,1,141,88,0,10,27,180,40,118,232,3,49,30,224,1,238,110,115,98,47,142,227,24,223,91,120,158,188,144,15,147,221,63,235,109,112,170,107,120,116,138,191,242,127,157,125,6,174,234,217,56,59,93,100,106,233,7,148,72,104,90,245,216,56,213,53,74,62,197,139,93,30,78,208,98,220,128,230,103,154,233,82,222,161,122,161,33,31,102,137,154,239,13,63,223,2,58,219,114,105,245,243,55,108,219,28,20,7,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61e6f54e-7847-49e3-aff5-86a7ed440807"));
		}

		#endregion

	}

	#endregion

}

