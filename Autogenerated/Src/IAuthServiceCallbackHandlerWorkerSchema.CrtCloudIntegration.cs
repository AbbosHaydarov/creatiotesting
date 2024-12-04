namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAuthServiceCallbackHandlerWorkerSchema

	/// <exclude/>
	public class IAuthServiceCallbackHandlerWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAuthServiceCallbackHandlerWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAuthServiceCallbackHandlerWorkerSchema(IAuthServiceCallbackHandlerWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57e78de3-15fe-432d-8438-0ba6c8daa811");
			Name = "IAuthServiceCallbackHandlerWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f3e00ac6-0422-4cac-8e36-b64e7b099372");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,141,146,65,107,195,48,12,133,207,13,228,63,136,246,178,193,104,238,93,87,24,189,172,135,193,88,55,118,118,99,181,49,77,28,79,178,11,101,244,191,207,177,147,44,109,161,236,18,240,139,222,231,39,75,90,84,200,70,228,8,75,178,203,178,118,114,165,45,238,72,88,85,235,233,26,233,160,114,228,52,249,73,147,145,99,165,119,176,62,178,197,234,49,77,188,50,33,220,249,58,104,60,180,245,148,25,172,158,157,45,90,223,82,148,229,70,228,251,23,161,101,137,244,85,211,30,41,24,179,44,131,57,187,170,18,116,92,180,231,119,52,132,140,218,50,216,2,65,117,76,216,214,20,148,162,193,52,17,242,150,11,132,223,14,217,78,161,67,102,3,166,113,155,82,229,3,206,63,162,141,124,159,254,219,55,246,138,182,168,37,207,224,45,192,226,207,203,240,65,136,32,190,202,214,167,103,131,185,218,42,148,96,74,97,189,90,77,123,216,48,118,84,140,32,81,129,246,211,121,26,119,245,227,197,135,231,244,238,121,22,138,110,123,62,25,105,37,207,157,224,188,8,74,250,167,110,2,209,109,146,48,198,119,30,246,33,98,6,194,153,243,80,43,217,62,195,29,91,106,6,213,221,248,0,23,66,140,213,203,3,228,125,220,172,209,4,181,140,67,8,231,83,220,183,63,49,77,78,191,84,145,9,5,188,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57e78de3-15fe-432d-8438-0ba6c8daa811"));
		}

		#endregion

	}

	#endregion

}

