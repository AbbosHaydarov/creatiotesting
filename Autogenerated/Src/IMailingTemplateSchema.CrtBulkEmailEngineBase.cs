﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingTemplateSchema

	/// <exclude/>
	public class IMailingTemplateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingTemplateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingTemplateSchema(IMailingTemplateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4d0de17-99ee-4de2-a094-c795028cdebf");
			Name = "IMailingTemplate";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,205,84,61,111,219,48,16,157,29,32,255,225,128,44,237,98,47,69,7,219,240,144,34,112,5,212,69,80,167,232,76,75,39,251,26,137,20,120,148,131,52,232,127,239,145,146,108,199,182,34,165,200,144,69,18,169,119,239,61,222,7,181,202,145,11,21,35,220,161,181,138,77,234,134,95,140,78,105,93,90,229,200,232,203,139,167,203,139,65,201,164,215,176,124,100,135,249,100,183,110,9,25,254,116,148,113,55,108,161,40,147,255,147,35,126,65,101,25,198,30,194,195,57,106,180,20,11,70,80,87,22,215,178,11,145,118,104,83,49,61,134,168,38,185,195,188,200,148,195,128,27,141,70,48,229,50,207,149,125,156,213,235,91,107,182,148,32,67,142,110,99,18,6,103,224,193,216,123,120,32,183,129,188,98,1,87,211,12,27,150,209,1,77,81,174,50,138,129,26,245,51,226,3,159,172,157,79,209,44,208,58,66,30,195,109,8,14,246,78,252,133,141,239,82,9,48,41,184,13,62,179,113,234,99,192,206,122,179,33,226,9,214,232,38,240,247,5,230,198,30,112,185,250,45,137,125,153,181,65,47,43,112,31,1,41,171,67,237,94,231,190,9,234,193,255,141,56,144,147,150,108,35,80,174,214,200,45,236,209,141,46,115,180,106,149,225,244,90,49,126,254,20,121,248,76,154,198,7,135,5,191,70,52,87,177,53,44,218,113,86,38,152,200,71,215,1,125,228,116,17,194,34,157,154,25,84,223,251,182,62,146,191,66,157,84,29,83,175,235,246,89,84,157,218,163,119,34,77,142,84,70,127,228,104,197,174,233,188,251,184,180,214,103,153,52,59,165,227,54,203,91,67,73,96,249,240,113,114,214,84,101,245,104,179,199,60,254,192,66,172,171,55,26,75,176,21,221,255,141,103,237,5,198,45,131,219,61,64,181,60,196,27,140,239,5,213,209,225,53,170,79,183,205,209,73,189,44,176,127,251,33,106,164,36,57,218,81,74,104,91,196,230,165,148,174,62,90,148,52,90,188,23,148,231,224,29,100,255,151,80,126,69,149,160,229,51,21,216,245,73,117,131,6,250,173,202,74,220,23,65,146,162,15,238,72,150,94,124,150,148,61,188,206,255,50,32,218,110,201,83,246,138,17,208,159,187,155,247,198,195,14,136,207,142,136,236,255,3,66,93,20,65,98,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4d0de17-99ee-4de2-a094-c795028cdebf"));
		}

		#endregion

	}

	#endregion

}

