namespace Terrasoft.Configuration.Timeline
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using DCEntityCollection = Nui.ServiceModel.DataContract.EntityCollection;

	#region EmailTimelineDataLoader

	/// <summary>
	/// Timeline data loader for email entities.
	/// </summary>
	[DefaultBinding(typeof(ITimelineDataLoader), Name = "Email")]
	public class EmailTimelineDataLoader : EsqTimelineDataLoader
	{

		#region Constants: Private

		private const string _emailMetadataColumn = "[EmailMetadata:Activity:Id].Preview";
		private const string _emailBodyColumn = "Body";
		private const string _emailIsReadMoreColumn = "IsReadMoreVisible";
		private int _maxSizeColumnValue;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="EmailTimelineDataLoader"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public EmailTimelineDataLoader(UserConnection userConnection) : base(userConnection) {
			_maxSizeColumnValue = TimelineUtilities.GetEmailMaxSizeColumnValue(userConnection);
		}

		public EmailTimelineDataLoader(UserConnection userConnection, IEmailTimelinePreviewCreator timelinePreviewCreator,
			IEmailContentProcessor emailContentProcesso) : this(userConnection) {
			_emailTimelinePreviewCreator = timelinePreviewCreator;
			_emailContentProcessor = emailContentProcesso;
		}

		#endregion

		#region Properties: Protected

		private IEmailContentProcessor _emailContentProcessor;
		protected IEmailContentProcessor EmailContentProcessor =>
			_emailContentProcessor ?? (_emailContentProcessor = ClassFactory.Get<IEmailContentProcessor>());

		private IEmailTimelinePreviewCreator _emailTimelinePreviewCreator;
		protected IEmailTimelinePreviewCreator EmailTimelinePreviewCreator =>
			_emailTimelinePreviewCreator ?? (_emailTimelinePreviewCreator =
				ClassFactory.Get<IEmailTimelinePreviewCreator>(new ConstructorArgument("userConnection", UserConnection)));

		#endregion

		#region Methods: Protected

		protected override DCEntityCollection ModifyMappedItems(Dictionary<string, string> columnAliases,
			DCEntityCollection mappedItems, TimelineRequestConfig config) {
				var baseCollection = base.ModifyMappedItems(columnAliases, mappedItems, config);
				foreach (var record in baseCollection) {
					var emailMetadataColumnValue = record.GetValue<string>(_emailMetadataColumn, string.Empty);
					if (string.IsNullOrEmpty(emailMetadataColumnValue))  {
						var bodyColumnValue = record.GetValue<string>(_emailBodyColumn, string.Empty);
						var sizeValue = ASCIIEncoding.ASCII.GetByteCount(bodyColumnValue);
						if (sizeValue >= _maxSizeColumnValue) {
							record.Add(_emailIsReadMoreColumn, true);
							var substrBody = bodyColumnValue.Substring(0, _maxSizeColumnValue);
							var largeEmailsInTimelineFeature = UserConnection.GetIsFeatureEnabled("LargeEmailsInTimeline.GetLastEmailSynchronously");
							record[_emailBodyColumn] = largeEmailsInTimelineFeature ?
								EmailContentProcessor.GetPreview(substrBody) : string.Empty;
							var previewForCreator = largeEmailsInTimelineFeature ?
								record[_emailBodyColumn].ToString() : substrBody;
							EmailTimelinePreviewCreator.GetAndSavePreview(record[_idColumnName].ToString(), config.MasterRecordId, previewForCreator);
						}
					} else if (record.ContainsKey(_emailBodyColumn)) {
						record.Add(_emailIsReadMoreColumn, true);
						record[_emailBodyColumn] = emailMetadataColumnValue;
					}
					record.Remove(_emailMetadataColumn);
				}
				return baseCollection;				
			}


		protected override void AddQueryColumns(TimelineBoundEntity entity, TimelineRequestConfig config, EntitySchemaQuery esq,
			Dictionary<string, string> columnAliases) {
			base.AddQueryColumns(entity, config, esq, columnAliases);
			var esqColumn = esq.AddColumn(_emailMetadataColumn);
			columnAliases.Add(esqColumn.Name, _emailMetadataColumn);
		}

		#endregion

	}

	#endregion

} 
