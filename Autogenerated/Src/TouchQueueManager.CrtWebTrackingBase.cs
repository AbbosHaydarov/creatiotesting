namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Creatio.FeatureToggling;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;
	using global::Common.Logging;

	#region Class: TouchQueueManager

	/// <summary>
	/// Contains methods to work with <see cref="TouchQueue"/> queue.
	/// Operates with <see cref="TouchQueueMessage"/>.
	/// </summary>
	public class TouchQueueManager : BaseTaskQueueManager<TouchQueueMessage>
	{

		#region Constructors: Public

		/// <inheritdoc />
		public TouchQueueManager(UserConnection userConnection) : base(userConnection) { }

		#endregion

		#region Properties: Protected

		/// <inheritdoc />
		protected override string QueueSchemaName => nameof(TouchQueue);

		/// <inheritdoc />
		protected override string QueueOpSchemaName => nameof(TouchQueueOp);

		#endregion

		#region Properties: Public

		/// <summary>
		/// Logger.
		/// </summary>
		private ILog _logger;
		public override ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger("TouchPoints"));
			set => _logger = value;
		}

		/// <summary>
		/// Instance of <see cref="TouchEventLogger"/> to log events for touches.
		/// </summary>
		private TouchEventLogger _eventLogger;
		protected TouchEventLogger EventLogger {
			get => _eventLogger ?? (_eventLogger =
				ClassFactory.Get<TouchEventLogger>(new ConstructorArgument("userConnection", UserConnection)));
			set => _eventLogger = value;
		}

		/// <summary>
		/// Creates instances of <see cref="TouchQueueMessage"/>.
		/// </summary>
		private TouchQueueMessageFactory _messageFactory;
		public TouchQueueMessageFactory MessageFactory {
			get => _messageFactory ?? (_messageFactory = ClassFactory.Get<TouchQueueMessageFactory>());
			set => _messageFactory = value;
		}

		#endregion

		#region Methods: Private

		private Select GetDuplicatesSelect(string hash) {
			var select = new Select(UserConnection)
				.Column("Id")
				.From(GetSchemaName(true))
				.Where(nameof(TouchQueue.HashCode)).IsEqual(Column.Parameter(hash))
				.Union(new Select(UserConnection).Top(1)
				.Column("Id")
				.From(GetSchemaName(false))
				.Where(nameof(TouchQueue.HashCode)).IsEqual(Column.Parameter(hash))) as Select;
			select.SpecifyNoLockHints();
			return select;
		}

		private bool CheckIsDuplicate(TouchQueueMessage message) {
			var hash = message.GetHash();
			var duplicatesSelect = GetDuplicatesSelect(hash);
			var select = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From(duplicatesSelect).As("Duplicates");
			select.SpecifyNoLockHints();
			return select.ExecuteScalar<int>() > 0;
		}

		private IEnumerable<TouchQueueMessage> DeduplicateMessages(IEnumerable<TouchQueueMessage> messages) {
			var actualMessages = messages.Where(m => !m.RequiresDeduplication).ToList();
			messages.Where(m => m.RequiresDeduplication)
				.ForEach(x => {
					if (!CheckIsDuplicate(x)) {
						actualMessages.Add(x);
					}
				});
			return actualMessages;
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override TouchQueueMessage CreateMessage(Guid id, string json, int retries) {
			var baseMessage = TouchQueueMessage.Create(id, json, retries);
			if (Features.GetIsEnabled("AllowUsingJsonTypeNameHandlingParameter")) {
				return baseMessage;
			}
			return MessageFactory.Create(baseMessage, json);
		}

		/// <inheritdoc />
		protected override void ExecuteMessage(TouchQueueMessage message) {
			message.CheckArgumentNull(nameof(message));
			try {
				message.Execute(UserConnection);
			} catch (NotImplementedException exception) {
				base.ExecuteMessage(message);
				return;
			} catch (Exception ex) {
				LogExecuteError(message, ex);
				return;
			}
			LogExecute(message);
		}

		/// <inheritdoc />
		protected override void FireOnMessageDequeuedEvent(TouchQueueMessage message) {
			try {
				base.FireOnMessageDequeuedEvent(message);
			} catch (Exception ex) {
				var text = UserConnection.GetLocalizableString(nameof(TouchQueueManager),
					"MessageProcessingErrorText");
				Logger.Error(string.Format(text, message.ToString()), ex);
				throw;
			}
		}

		/// <inheritdoc />
		protected override void LogEnqueue(TouchQueueMessage message) {
			base.LogEnqueue(message);
			var eventName = UserConnection.GetLocalizableString(nameof(TouchQueueManager), "EnqueueLogActionName");
			EventLogger.Info(eventName, DateTime.UtcNow, message.GetTracking(), GetType().FullName, 1,
				message.GetDescription());
		}

		/// <summary>
		/// Logs successful message execution.
		/// </summary>
		/// <param name="message">Instance of the <see cref="TouchQueueMessage"/>.</param>
		protected virtual void LogExecute(TouchQueueMessage message) {
			var eventName = UserConnection.GetLocalizableString(nameof(TouchQueueManager), "ExecuteLogActionName");
			EventLogger.Info(eventName, DateTime.UtcNow, message.GetTracking(), GetType().FullName, 1,
				message.GetDescription());
		}

		/// <summary>
		/// Logs unsuccessful message execution.
		/// </summary>
		/// <param name="message">Instance of the <see cref="TouchQueueMessage"/>.</param>
		/// <param name="ex">Exception that was thrown.</param>
		protected virtual void LogExecuteError(TouchQueueMessage message, Exception ex) {
			var eventName = UserConnection.GetLocalizableString(nameof(TouchQueueManager), "ExecuteLogActionName");
			Logger.Error($"TouchQueueMessage: {message}", ex);
			EventLogger.Error(eventName, DateTime.UtcNow, ex, message);
		}

		/// <inheritdoc/>
		protected override Insert GetInsertMessageQueryTemplate(bool isOperationalQuery) {
			var insert = base.GetInsertMessageQueryTemplate(isOperationalQuery);
			return insert
				.Set("HashCode", new QueryParameter("HashCode", null, "MediumText"));
		}

		/// <inheritdoc/>
		protected override void SetQueryParameters(ref Insert insert, TouchQueueMessage message) {
			base.SetQueryParameters(ref insert, message);
			var parameters = insert.Parameters;
			parameters.GetByName("HashCode").Value = message.GetHash();
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc/>
		public override int Enqueue(IEnumerable<TouchQueueMessage> messages) {
			if (messages.IsNullOrEmpty()) {
				return 0;
			}
			var actualMessages = DeduplicateMessages(messages.ToList());
			return base.Enqueue(actualMessages);
		}

		#endregion

	}

	#endregion

}

