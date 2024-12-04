﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignQueueManagerSchema

	/// <exclude/>
	public class ICampaignQueueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignQueueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignQueueManagerSchema(ICampaignQueueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("05d861e3-ff21-4bce-b8e3-c7b0ba8a4fa6");
			Name = "ICampaignQueueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,189,150,81,79,219,48,16,199,159,65,226,59,156,194,11,147,80,243,14,37,18,20,134,42,13,137,13,190,128,155,92,26,107,137,29,206,206,74,53,241,221,119,142,227,180,73,71,203,38,109,47,109,19,251,254,190,251,253,47,151,42,81,161,169,69,138,240,140,68,194,232,220,78,102,90,229,114,217,144,176,82,171,147,227,159,39,199,71,141,145,106,9,79,107,99,177,186,28,93,243,254,178,196,212,109,54,147,123,84,72,50,221,236,217,150,37,156,220,222,240,18,47,158,18,46,57,0,230,202,34,229,124,254,5,204,103,162,170,133,92,170,175,13,54,248,32,148,88,34,181,155,227,56,134,169,105,170,74,208,58,233,174,191,97,77,104,80,89,3,21,218,66,103,6,114,77,96,11,132,23,23,15,58,135,180,19,228,29,198,176,26,16,166,154,50,51,9,154,241,150,104,221,44,74,153,130,12,9,189,151,207,17,243,224,207,190,130,7,127,250,5,60,182,2,126,113,156,113,123,227,153,36,26,176,26,240,213,146,72,109,151,14,228,164,43,159,180,75,108,55,51,127,135,208,54,164,76,114,13,165,52,214,149,151,97,27,148,245,101,77,227,176,201,69,205,239,84,83,33,137,69,137,211,65,41,115,54,45,129,91,31,125,246,233,114,79,202,215,25,115,117,62,150,1,158,203,255,96,174,181,32,81,129,226,222,186,138,94,194,145,81,114,173,24,175,177,66,49,93,206,127,106,16,33,37,204,175,162,157,252,162,56,105,73,41,127,214,52,110,37,127,71,131,139,92,32,57,61,201,113,204,183,16,22,10,97,96,129,168,130,64,54,98,195,46,195,157,95,58,219,57,219,215,231,126,29,102,147,227,42,224,255,123,50,38,218,114,245,16,149,64,208,252,47,62,7,250,104,83,197,97,90,162,44,33,213,202,114,243,27,223,246,30,8,87,219,49,9,171,79,232,70,74,215,5,239,33,225,229,143,178,30,233,38,254,219,37,79,107,88,21,50,45,124,98,76,119,147,33,31,45,178,172,63,226,51,207,23,118,154,237,182,221,204,129,149,166,239,31,168,65,33,63,165,91,250,101,83,41,8,178,43,105,11,38,35,217,146,104,230,67,231,89,180,107,233,160,156,14,131,227,206,155,147,128,5,120,32,215,32,51,158,139,50,151,72,251,85,240,181,150,126,202,63,242,208,214,172,115,215,223,105,167,169,243,43,116,183,135,180,146,206,66,66,97,185,162,32,250,49,39,255,105,147,118,126,14,15,61,135,251,70,50,248,1,172,115,55,226,97,92,250,222,222,157,149,40,200,28,124,50,61,134,247,123,181,231,181,88,239,213,154,204,134,238,198,73,7,191,18,182,181,128,251,101,135,246,32,196,252,201,147,49,138,76,190,116,131,200,189,74,251,55,168,179,101,171,175,220,187,102,99,230,15,205,148,91,72,55,235,237,220,205,153,211,154,58,19,146,145,11,253,176,56,69,149,249,55,105,123,253,230,255,29,12,110,190,253,2,180,196,245,233,165,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("05d861e3-ff21-4bce-b8e3-c7b0ba8a4fa6"));
		}

		#endregion

	}

	#endregion

}

