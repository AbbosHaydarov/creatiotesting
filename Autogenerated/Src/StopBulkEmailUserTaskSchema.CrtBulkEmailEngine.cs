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

	#region Class: StopBulkEmailUserTask

	[DesignModeProperty(Name = "CrtBulkEmailIdentifier", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d6cf84c370774ff3810e147ce8f36464", CaptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", DescriptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSuccess", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d6cf84c370774ff3810e147ce8f36464", CaptionResourceItem = "Parameters.IsSuccess.Caption", DescriptionResourceItem = "Parameters.IsSuccess.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ValidationCodes", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "d6cf84c370774ff3810e147ce8f36464", CaptionResourceItem = "Parameters.ValidationCodes.Caption", DescriptionResourceItem = "Parameters.ValidationCodes.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class StopBulkEmailUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public StopBulkEmailUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("d6cf84c3-7077-4ff3-810e-147ce8f36464");
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

