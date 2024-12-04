namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatLanguageIteratorSchema

	/// <exclude/>
	public class ChatLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatLanguageIteratorSchema(ChatLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfb32ab4-18f2-0b7b-7c32-952642edc498");
			Name = "ChatLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,10,149,82,77,107,194,64,16,61,71,240,63,12,241,162,80,146,187,85,15,181,23,161,208,82,234,169,244,48,174,147,184,176,217,200,126,80,108,241,191,119,178,107,108,162,30,218,67,22,230,205,155,55,111,102,162,177,34,187,71,65,240,70,198,160,173,11,151,45,107,93,200,210,27,116,178,214,195,193,247,112,144,120,43,117,217,163,24,186,31,14,56,51,50,84,50,13,150,10,173,157,194,114,135,238,9,117,233,177,164,149,35,214,168,77,224,229,121,14,51,235,171,10,205,97,113,138,91,2,20,252,41,105,93,211,100,115,128,231,74,203,70,8,212,73,201,102,173,66,222,145,216,251,141,146,2,68,211,249,102,99,152,194,3,90,186,246,147,52,51,253,90,175,181,117,198,11,78,241,4,47,65,53,120,190,50,29,93,107,233,36,42,249,69,22,52,125,130,228,106,212,188,193,186,96,50,17,8,67,197,60,189,101,40,205,23,25,156,133,187,179,68,100,143,6,43,208,124,147,121,234,45,25,118,166,73,52,103,72,23,107,142,65,156,129,108,150,7,118,40,62,109,226,86,203,241,186,167,3,125,217,73,83,157,76,97,195,107,26,95,164,146,184,165,164,85,124,245,138,39,158,135,153,87,93,240,253,3,34,51,105,82,172,224,80,184,149,110,175,216,165,94,184,153,220,117,234,118,200,176,250,119,221,35,21,232,213,31,216,71,254,97,249,141,151,29,145,222,198,243,135,56,162,125,240,248,3,82,180,95,187,28,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfb32ab4-18f2-0b7b-7c32-952642edc498"));
		}

		#endregion

	}

	#endregion

}

