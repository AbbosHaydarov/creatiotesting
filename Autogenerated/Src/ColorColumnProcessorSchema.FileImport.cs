namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColorColumnProcessorSchema

	/// <exclude/>
	public class ColorColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColorColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColorColumnProcessorSchema(ColorColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ece3bf3e-1c9f-4ab6-ae57-035b0707f269");
			Name = "ColorColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,147,65,79,227,48,16,133,207,32,241,31,70,229,210,74,40,185,3,173,180,20,129,122,89,33,109,187,151,213,30,220,100,82,44,37,118,118,108,163,173,16,255,157,23,187,93,72,8,43,113,73,226,209,155,55,51,95,198,70,53,236,90,85,48,173,89,68,57,91,249,108,105,77,165,119,65,148,215,214,100,119,186,230,85,211,90,241,103,167,207,103,167,39,193,105,179,163,31,123,231,185,185,250,119,126,159,45,252,89,60,187,83,133,183,162,217,65,1,205,185,240,14,53,104,89,43,231,46,105,105,107,43,120,132,198,60,136,45,216,57,43,81,151,231,57,93,107,243,200,162,125,105,11,42,132,171,249,100,205,127,253,64,61,201,23,71,185,11,77,163,100,127,60,127,51,164,141,243,202,96,84,91,145,127,212,142,138,174,44,225,67,192,192,26,167,183,53,83,101,133,218,228,215,13,16,123,162,34,150,161,39,85,7,118,217,177,68,254,174,198,175,91,174,84,168,253,141,54,37,242,166,126,223,178,173,166,171,65,131,179,11,250,14,228,52,39,131,23,4,99,51,207,102,191,225,216,134,109,173,139,67,147,99,50,186,164,17,4,200,196,111,194,243,141,46,70,243,18,58,242,128,252,16,109,147,226,139,92,63,128,141,129,165,176,242,236,250,120,49,61,148,204,7,203,177,246,225,217,145,252,136,50,69,90,37,170,137,148,230,147,224,24,217,198,112,209,173,228,100,177,193,25,255,228,24,200,174,243,168,142,201,7,108,99,21,167,155,158,15,245,109,103,224,185,85,142,167,195,112,183,245,39,47,7,166,108,202,132,181,207,24,53,90,22,143,205,6,97,177,30,185,92,254,15,242,13,42,125,1,242,173,242,42,173,95,98,27,140,254,131,111,93,178,241,186,210,44,159,160,196,38,167,94,200,62,225,42,66,79,247,65,151,209,239,103,103,183,134,219,102,85,210,124,209,143,225,190,2,224,80,150,174,237,144,66,98,211,15,190,188,2,168,94,36,28,90,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ece3bf3e-1c9f-4ab6-ae57-035b0707f269"));
		}

		#endregion

	}

	#endregion

}

