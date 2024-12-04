﻿namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using global::Common.Logging;
	using Terrasoft.Core.DB;

	#region Class: MarketingEventQueueManager

	/// <summary>
	/// Contains methods to work with <see cref="MarketingEventQueue"/> queue.
	/// Operates with <see cref="EventQueueMessage"/>.
	/// </summary>
	public class MarketingEventQueueManager : BaseAudienceQueueManager<EventQueueMessage>
	{

		#region Constructors: Public

		public MarketingEventQueueManager(UserConnection userConnection) : base(userConnection) { }

		#endregion

		#region Properties: Protected

		/// <inheritdoc />
		protected override string QueueSchemaName => nameof(MarketingEventQueue);

		/// <inheritdoc />
		protected override string QueueOpSchemaName => nameof(MarketingEventQueueOp);

		/// <inheritdoc />
		protected override string RecordColumnName => EventQueueMessage.RecordName;

		#endregion

		#region Properties: Public

		/// <summary>
		/// Logger.
		/// </summary>
		private ILog _logger;
		public override ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger("MarketingEventLogger"));
			set => _logger = value;
		}

		#endregion


		#region Methods: Protected

		/// <inheritdoc />
		protected override EventQueueMessage CreateMessage(Guid id, string json, int retries) {
			var baseMessage = EventQueueMessage.Create(id, json, retries);
			switch (baseMessage.Type) {
				case EventQueueMessageType.AddAudienceByList:
					return EventQueueMessage.Create<AddEventAudienceByListQueueMessage>(id, json, retries);
				case EventQueueMessageType.AddAudienceByFilter:
					return EventQueueMessage.Create<AddEventAudienceByFilterQueueMessage>(id, json, retries);
				case EventQueueMessageType.AddAudienceByFolderId:
					return EventQueueMessage.Create<AddEventAudienceByFolderQueueMessage>(id, json, retries);
				case EventQueueMessageType.RemoveAudienceByList:
					return EventQueueMessage.Create<RemoveEventAudienceByListQueueMessage>(id, json, retries);
				case EventQueueMessageType.RemoveAudienceByFilter:
					return EventQueueMessage.Create<RemoveEventAudienceByFilterQueueMessage>(id, json, retries);
				case EventQueueMessageType.RemoveAllAudience:
					return EventQueueMessage.Create<RemoveAllEventAudienceQueueMessage>(id, json, retries);
				default:
					return baseMessage;
			}
		}
			

		/// <inheritdoc />
		protected override Insert GetInsertMessageQueryTemplate(bool isOperationalQuery) {
			var insert = base.GetInsertMessageQueryTemplate(isOperationalQuery);
			return insert.Set("EventId", new QueryParameter("EventId", null, "Guid"));
		}

		/// <inheritdoc />
		protected override void SetQueryParameters(ref Insert insert, EventQueueMessage message) {
			base.SetQueryParameters(ref insert, message);
			var parameters = insert.Parameters;
			parameters.GetByName("EventId").Value = message.EventId;
		}

		#endregion

	}

	#endregion

}

