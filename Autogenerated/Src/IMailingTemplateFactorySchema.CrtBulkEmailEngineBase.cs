namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingTemplateFactorySchema

	/// <exclude/>
	public class IMailingTemplateFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingTemplateFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingTemplateFactorySchema(IMailingTemplateFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("097b8032-3d21-4484-aa49-cf8ba99707c8");
			Name = "IMailingTemplateFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,145,77,106,195,48,16,133,215,49,248,14,67,186,105,54,209,62,77,189,9,4,188,8,132,146,11,168,242,200,17,88,35,51,146,3,161,228,238,145,45,165,180,46,133,118,37,230,239,189,239,33,146,22,125,47,21,194,9,153,165,119,58,172,119,142,180,105,7,150,193,56,42,139,143,178,40,139,197,19,99,27,75,168,41,32,235,120,176,129,250,32,77,103,168,61,161,237,59,25,112,47,85,112,124,157,214,133,16,176,245,131,181,146,175,85,174,143,236,46,166,65,15,22,195,217,53,30,180,99,80,140,209,135,90,48,228,131,36,101,226,220,105,8,103,140,247,136,227,92,191,46,231,86,75,81,173,31,46,226,139,77,63,188,119,70,69,173,12,249,59,227,34,197,250,204,117,72,76,27,56,78,18,105,40,102,41,166,198,110,36,142,148,25,24,255,142,251,147,55,117,24,195,192,228,171,183,244,254,87,121,43,30,2,163,226,124,35,243,214,89,243,121,245,146,131,35,53,41,251,84,223,210,47,127,107,198,222,29,226,110,78,158,32,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("097b8032-3d21-4484-aa49-cf8ba99707c8"));
		}

		#endregion

	}

	#endregion

}

