namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: StartBulkEmailUserTask

	[DesignModeProperty(Name = "CrtBulkEmailIdentifier", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "175a5ea64079484cb6f71af15d6e8353", CaptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", DescriptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSuccess", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "175a5ea64079484cb6f71af15d6e8353", CaptionResourceItem = "Parameters.IsSuccess.Caption", DescriptionResourceItem = "Parameters.IsSuccess.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ValidationCodes", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "175a5ea64079484cb6f71af15d6e8353", CaptionResourceItem = "Parameters.ValidationCodes.Caption", DescriptionResourceItem = "Parameters.ValidationCodes.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class StartBulkEmailUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public StartBulkEmailUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("175a5ea6-4079-484c-b6f7-1af15d6e8353");
		}

		#endregion

		#region Properties: Public

		public virtual Guid CrtBulkEmailIdentifier {
			get;
			set;
		}

		public virtual bool IsSuccess {
			get;
			set;
		}

		public virtual string ValidationCodes {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("CrtBulkEmailIdentifier")) {
					writer.WriteValue("CrtBulkEmailIdentifier", CrtBulkEmailIdentifier, Guid.Empty);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("IsSuccess")) {
					writer.WriteValue("IsSuccess", IsSuccess, false);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("ValidationCodes")) {
					writer.WriteValue("ValidationCodes", ValidationCodes, null);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "CrtBulkEmailIdentifier":
					if (!UseFlowEngineMode) {
						break;
					}
					CrtBulkEmailIdentifier = reader.GetGuidValue();
				break;
				case "IsSuccess":
					if (!UseFlowEngineMode) {
						break;
					}
					IsSuccess = reader.GetBoolValue();
				break;
				case "ValidationCodes":
					if (!UseFlowEngineMode) {
						break;
					}
					ValidationCodes = reader.GetStringValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

