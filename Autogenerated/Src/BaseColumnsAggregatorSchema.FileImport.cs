﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseColumnsAggregatorSchema

	/// <exclude/>
	public class BaseColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseColumnsAggregatorSchema(BaseColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d216f6f8-6004-4467-9e7f-3679e44d223b");
			Name = "BaseColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,181,87,205,110,219,56,16,62,171,64,223,97,214,189,56,128,97,223,27,91,69,155,117,186,1,186,216,162,113,122,45,24,121,108,115,43,147,90,146,114,54,8,242,238,29,145,146,77,82,146,237,6,237,37,17,135,243,63,223,12,199,130,109,81,23,44,67,88,160,82,76,203,149,25,95,73,177,226,235,82,49,195,165,24,95,243,28,111,182,133,84,230,245,171,167,215,175,146,82,115,177,134,219,71,109,112,123,25,157,73,52,207,49,171,228,244,248,35,10,84,60,107,241,124,226,226,191,3,209,55,171,176,143,62,158,11,195,13,71,77,12,196,242,70,225,154,108,192,85,206,180,126,11,31,152,70,178,92,110,133,126,191,94,211,29,51,82,89,198,162,188,207,121,6,236,94,27,197,50,3,89,37,208,205,63,93,164,240,22,110,122,116,37,73,242,176,65,69,105,10,153,62,43,153,161,214,150,133,178,83,49,54,206,93,115,204,151,228,221,103,197,119,204,160,187,44,220,1,62,113,109,42,139,223,178,80,77,29,96,242,6,197,210,233,9,149,82,109,40,148,50,35,167,172,106,105,40,221,184,116,76,147,201,4,166,186,220,110,153,122,76,27,194,149,66,50,168,129,147,32,19,84,104,185,2,243,88,32,113,34,66,166,112,53,27,116,6,253,180,120,30,76,210,241,94,241,36,214,60,45,152,98,91,16,4,161,217,160,212,168,200,57,225,170,63,72,239,232,12,217,158,48,158,78,44,183,21,46,26,183,187,43,49,188,11,116,65,168,250,2,102,41,68,28,179,136,231,68,18,41,109,5,170,10,78,103,166,208,122,8,197,190,72,61,73,57,196,213,148,55,2,137,134,170,131,146,100,141,166,254,74,248,10,134,45,16,192,31,51,16,101,158,95,52,92,137,66,83,42,209,9,151,234,250,217,253,107,43,154,193,71,52,177,23,195,139,90,236,184,86,171,244,249,72,94,226,26,159,202,74,84,181,232,248,4,148,150,75,120,62,94,187,249,14,133,169,234,102,59,155,110,172,9,215,230,88,221,57,142,191,152,88,230,168,166,65,232,115,165,164,178,215,239,213,90,167,224,147,79,64,230,111,52,27,217,234,230,206,172,80,194,53,101,37,132,12,152,13,163,241,195,4,60,72,245,29,30,184,217,192,154,147,43,64,222,112,243,8,58,219,224,150,213,114,231,54,157,147,189,181,162,46,210,65,58,239,210,231,119,159,213,226,42,175,211,24,218,196,217,92,249,227,106,209,1,163,225,188,101,189,14,198,39,53,16,174,161,22,67,145,158,23,165,205,48,2,96,213,226,17,105,124,197,154,195,176,195,138,67,116,141,157,198,235,157,228,75,248,39,168,254,240,8,32,28,126,170,175,198,105,159,237,221,248,70,236,228,119,28,154,13,215,35,143,215,183,124,6,124,78,143,155,159,4,208,18,181,225,194,61,214,103,226,198,19,25,164,238,113,111,12,250,218,94,142,154,166,227,59,113,227,12,58,234,159,7,115,190,233,223,129,26,95,125,80,180,206,34,124,113,241,64,78,147,188,122,50,157,98,237,61,2,71,114,221,36,163,47,45,251,125,164,121,39,250,134,116,175,123,110,190,117,192,132,214,38,10,251,76,28,104,130,43,170,65,218,42,116,48,100,26,164,15,14,247,135,213,225,72,63,209,246,112,240,163,235,245,183,253,233,34,9,122,84,222,255,75,12,224,188,27,193,79,181,108,212,238,47,109,211,250,117,217,251,207,5,109,127,220,44,101,86,199,221,189,40,214,33,215,239,209,142,43,83,178,28,124,192,215,251,152,59,4,35,20,148,148,198,125,142,224,172,217,58,114,175,184,175,254,43,203,75,42,205,225,187,201,75,181,103,180,53,192,44,90,52,154,134,243,157,244,181,121,155,65,178,136,187,173,115,219,232,154,214,78,75,109,171,213,178,190,109,63,39,29,9,8,34,109,245,244,139,138,214,95,172,19,121,166,233,35,240,33,148,175,179,122,67,64,254,159,178,227,241,87,63,149,232,219,222,212,117,188,149,165,162,253,60,100,179,127,109,96,151,191,10,142,117,123,93,115,177,180,218,175,165,186,101,59,60,103,46,143,130,240,122,193,118,38,50,252,137,124,20,18,45,87,3,151,250,48,16,117,185,163,250,68,162,252,0,162,143,243,243,0,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d216f6f8-6004-4467-9e7f-3679e44d223b"));
		}

		#endregion

	}

	#endregion

}

