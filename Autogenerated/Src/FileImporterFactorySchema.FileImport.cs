namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImporterFactorySchema

	/// <exclude/>
	public class FileImporterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImporterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImporterFactorySchema(FileImporterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a32b6e83-4c3b-c886-59ec-834898926b24");
			Name = "FileImporterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,107,195,48,12,61,167,208,255,32,114,74,160,36,247,173,45,172,221,58,114,25,59,108,167,177,131,155,202,157,33,113,130,100,111,148,209,255,62,185,107,104,83,82,216,14,249,144,252,244,222,147,100,171,106,228,86,149,8,47,72,164,184,209,46,91,54,86,155,173,39,229,76,99,179,149,169,176,168,219,134,220,120,244,61,30,69,158,141,221,246,208,132,183,87,242,217,74,149,174,33,131,44,8,193,228,121,14,83,99,63,144,140,219,52,37,148,132,122,22,23,39,9,164,223,138,93,156,207,59,60,251,186,86,180,235,98,1,86,88,163,117,12,198,74,129,14,230,117,67,129,76,57,249,21,50,48,71,182,142,35,63,35,121,187,71,173,124,229,22,198,110,196,114,226,118,45,54,58,25,114,145,78,224,73,6,4,51,176,242,17,208,16,38,125,23,210,214,175,43,35,13,85,138,25,6,80,112,3,67,2,82,25,102,250,239,193,116,122,197,66,49,158,163,224,17,221,121,156,188,50,146,44,212,98,25,182,9,190,23,166,112,80,143,62,21,93,156,220,209,150,67,219,248,5,146,100,71,62,168,75,214,135,209,39,113,31,29,79,46,137,195,141,136,34,163,33,233,31,100,226,175,224,149,108,202,19,62,88,181,174,112,147,196,98,242,25,137,13,59,33,63,217,143,211,206,96,68,40,5,22,150,97,190,199,73,4,170,105,49,84,135,52,191,144,13,237,28,61,237,15,239,171,124,127,99,9,36,242,236,127,0,183,183,9,33,63,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a32b6e83-4c3b-c886-59ec-834898926b24"));
		}

		#endregion

	}

	#endregion

}

