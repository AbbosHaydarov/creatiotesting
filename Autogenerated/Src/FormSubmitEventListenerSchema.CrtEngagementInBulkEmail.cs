﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormSubmitEventListenerSchema

	/// <exclude/>
	public class FormSubmitEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormSubmitEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormSubmitEventListenerSchema(FormSubmitEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2fb6988-fe08-435e-9093-741348929bb6");
			Name = "FormSubmitEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1d561c9f-c9ca-4727-b788-d69dbba5c4dc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,84,223,111,218,48,16,126,166,210,254,135,91,246,18,164,42,121,167,133,106,84,108,67,162,45,26,116,123,152,166,201,36,151,224,53,177,145,237,48,161,105,255,251,206,78,2,166,132,177,151,252,184,251,238,238,187,207,190,19,172,68,189,97,9,194,18,149,98,90,102,38,186,151,34,227,121,165,152,225,82,188,185,250,253,230,170,87,105,46,242,35,72,89,74,113,211,233,81,24,77,132,225,134,163,190,8,136,38,91,20,198,226,8,249,78,97,78,21,225,190,96,90,15,224,131,84,229,162,90,149,220,56,208,140,107,131,2,149,131,198,113,12,183,186,42,75,166,118,163,230,191,5,64,38,21,57,17,33,81,152,13,131,67,158,32,30,1,101,226,102,7,232,234,70,109,170,248,85,46,27,206,10,45,155,20,99,166,209,81,222,29,81,9,32,182,1,223,58,92,225,34,89,99,201,30,73,94,24,130,160,151,204,194,3,147,126,255,59,5,110,170,85,193,19,72,108,191,231,218,133,1,156,169,78,9,232,104,232,185,23,110,174,228,6,149,213,117,0,115,151,187,246,191,86,203,25,166,66,27,38,232,224,101,230,171,245,192,212,11,26,58,178,103,83,206,153,210,212,37,169,102,36,100,92,164,80,112,241,130,105,45,34,149,129,213,14,42,83,194,134,41,86,58,53,79,229,236,109,20,223,50,131,112,154,25,126,84,237,167,189,41,173,30,29,192,195,151,189,141,189,94,142,6,134,35,47,30,238,238,32,244,126,73,115,252,213,145,41,236,247,93,169,158,62,201,48,132,45,43,42,116,238,63,141,176,40,210,90,219,99,161,31,208,172,101,106,85,174,123,171,189,109,163,91,201,83,24,147,92,51,167,86,123,215,189,227,111,110,97,191,233,134,103,16,190,173,77,209,84,223,203,162,42,197,23,203,101,38,89,138,105,24,204,152,72,169,139,57,203,241,249,243,44,232,183,129,61,133,166,82,110,14,29,103,122,110,153,130,194,131,171,130,26,107,114,127,68,179,220,109,48,245,42,220,106,163,8,58,58,173,113,179,167,86,67,136,217,99,85,20,79,234,235,154,27,92,216,157,17,30,23,186,68,107,85,21,47,147,146,241,98,154,18,167,253,145,88,90,227,214,53,222,145,61,108,248,62,147,151,150,145,192,196,110,162,235,87,125,121,12,189,204,150,166,52,147,114,99,118,225,129,80,147,112,129,198,235,61,12,246,101,167,105,112,237,243,235,123,220,255,251,46,92,154,184,79,68,191,160,161,185,180,155,60,255,147,160,49,181,35,45,114,7,176,243,127,102,204,156,197,13,162,91,55,195,64,19,97,154,222,145,91,26,80,255,69,183,177,131,116,71,96,48,90,174,209,175,191,28,156,93,220,142,235,24,105,217,162,171,240,94,229,218,46,68,224,237,98,73,164,48,140,11,187,254,205,154,102,164,174,232,122,128,148,25,118,68,166,153,125,185,165,122,60,109,134,200,107,63,148,171,159,116,15,154,62,174,161,179,62,96,123,226,43,218,153,145,31,222,198,97,115,180,246,66,54,122,15,193,223,204,53,176,6,117,12,113,51,185,255,216,18,181,245,216,72,182,191,235,77,35,160,106,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2fb6988-fe08-435e-9093-741348929bb6"));
		}

		#endregion

	}

	#endregion

}

