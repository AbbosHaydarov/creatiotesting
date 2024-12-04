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

	#region Class: SendTestEmailUserTask

	[DesignModeProperty(Name = "IsSuccess", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "646ea8694f2349c7a63af9ec3fd79ba4", CaptionResourceItem = "Parameters.IsSuccess.Caption", DescriptionResourceItem = "Parameters.IsSuccess.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ValidationCodes", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "646ea8694f2349c7a63af9ec3fd79ba4", CaptionResourceItem = "Parameters.ValidationCodes.Caption", DescriptionResourceItem = "Parameters.ValidationCodes.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SendTestEmailTo", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "646ea8694f2349c7a63af9ec3fd79ba4", CaptionResourceItem = "Parameters.SendTestEmailTo.Caption", DescriptionResourceItem = "Parameters.SendTestEmailTo.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "ContactToTestPersonalizations", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "646ea8694f2349c7a63af9ec3fd79ba4", CaptionResourceItem = "Parameters.ContactToTestPersonalizations.Caption", DescriptionResourceItem = "Parameters.ContactToTestPersonalizations.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "CrtBulkEmailIdentifier", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "646ea8694f2349c7a63af9ec3fd79ba4", CaptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", DescriptionResourceItem = "Parameters.CrtBulkEmailIdentifier.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public partial class SendTestEmailUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SendTestEmailUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("646ea869-4f23-49c7-a63a-f9ec3fd79ba4");
		}

		#endregion

		#region Properties: Public

		public virtual bool IsSuccess {
			get;
			set;
		}

		public virtual string ValidationCodes {
			get;
			set;
		}

		public virtual string SendTestEmailTo {
			get;
			set;
		}

		public virtual Guid ContactToTestPersonalizations {
			get;
			set;
		}

		public virtual Guid CrtBulkEmailIdentifier {
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
				if (!HasMapping("IsSuccess")) {
					writer.WriteValue("IsSuccess", IsSuccess, false);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("ValidationCodes")) {
					writer.WriteValue("ValidationCodes", ValidationCodes, null);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("SendTestEmailTo")) {
					writer.WriteValue("SendTestEmailTo", SendTestEmailTo, null);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("ContactToTestPersonalizations")) {
					writer.WriteValue("ContactToTestPersonalizations", ContactToTestPersonalizations, Guid.Empty);
				}
			}
			if (UseFlowEngineMode) {
				if (!HasMapping("CrtBulkEmailIdentifier")) {
					writer.WriteValue("CrtBulkEmailIdentifier", CrtBulkEmailIdentifier, Guid.Empty);
				}
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
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
				case "SendTestEmailTo":
					if (!UseFlowEngineMode) {
						break;
					}
					SendTestEmailTo = reader.GetStringValue();
				break;
				case "ContactToTestPersonalizations":
					if (!UseFlowEngineMode) {
						break;
					}
					ContactToTestPersonalizations = reader.GetGuidValue();
				break;
				case "CrtBulkEmailIdentifier":
					if (!UseFlowEngineMode) {
						break;
					}
					CrtBulkEmailIdentifier = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

