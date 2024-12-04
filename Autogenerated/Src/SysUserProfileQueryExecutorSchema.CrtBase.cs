namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysUserProfileQueryExecutorSchema

	/// <exclude/>
	public class SysUserProfileQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysUserProfileQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysUserProfileQueryExecutorSchema(SysUserProfileQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2874e500-f502-47f6-9bab-e93d028d1b70");
			Name = "SysUserProfileQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("400566f7-77a1-4986-aa86-a353b8b6c452");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,125,83,77,143,155,48,16,61,179,210,254,135,41,123,33,82,4,247,109,136,180,77,55,85,15,173,182,251,113,170,170,202,133,33,107,201,24,58,182,211,162,170,255,189,99,76,54,129,116,185,32,24,63,191,247,230,205,0,90,212,104,90,81,32,60,34,145,48,77,101,211,77,163,43,185,115,36,172,108,244,229,197,159,203,139,200,25,169,119,35,8,225,219,87,234,233,173,182,210,74,52,175,2,182,162,176,13,5,4,99,174,8,119,172,4,27,37,140,185,134,135,206,60,25,164,59,106,42,169,240,139,67,234,110,127,99,225,248,74,15,255,250,30,43,225,148,125,39,117,201,228,137,237,90,108,170,228,99,47,219,141,240,139,37,124,230,6,33,135,120,134,53,94,124,99,218,214,253,80,178,128,194,155,152,243,0,215,240,63,41,102,224,160,248,249,210,206,86,162,42,185,159,59,146,123,97,49,28,182,225,3,8,69,217,104,213,129,151,225,192,53,22,62,109,248,238,70,223,33,160,232,10,117,25,88,199,18,12,52,150,156,79,211,11,245,29,12,58,161,155,153,62,146,137,242,88,120,1,126,236,81,52,241,195,73,158,25,140,162,191,243,46,63,161,125,110,202,137,193,44,203,96,101,92,93,11,234,214,135,194,61,90,71,218,244,26,208,6,211,233,11,58,155,194,87,173,32,81,131,223,225,60,102,172,69,50,241,122,27,94,210,85,214,31,31,209,20,216,215,227,80,192,132,78,252,133,3,226,36,193,48,234,77,163,212,144,192,7,180,211,90,18,10,15,197,51,214,162,15,25,208,252,60,68,184,23,4,216,3,238,209,52,106,207,173,229,97,215,195,127,208,165,76,185,218,56,34,70,141,189,29,46,172,19,141,191,78,167,125,67,59,87,51,60,233,21,162,120,60,148,120,57,221,163,197,162,31,84,20,140,246,249,14,18,67,37,159,88,244,158,6,75,79,71,112,50,208,248,150,138,99,36,57,120,123,103,169,76,60,44,167,18,167,169,13,196,178,130,228,220,220,27,22,112,74,29,2,141,142,210,233,77,89,158,95,24,200,120,45,249,25,102,122,98,119,102,101,67,117,92,228,218,63,122,53,159,204,38,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2874e500-f502-47f6-9bab-e93d028d1b70"));
		}

		#endregion

	}

	#endregion

}

