namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: TrackingWebhookEventHandlerLoader

	/// <summary>
	/// Class to loads all available tracking webhook event handlers.
	/// </summary>
	public class TrackingWebhookEventHandlerLoader
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes new instance of the class.
		/// </summary>
		/// <param name="userConnection">User connection instance.</param>
		public TrackingWebhookEventHandlerLoader() {
			InitHandlers();
		}

		#endregion

		#region Fields: Private

		private static readonly object _lockObject = new object();

		private static IEnumerable<Type> _handlers;

		#endregion

		#region Methods: Private

		private bool HasTrackingAttribute(Type type) {
			return type.GetCustomAttributes(typeof(TrackingWebhookEventHandlerAttribute), true)
				.OfType<TrackingWebhookEventHandlerAttribute>().Any();
		}

		private IEnumerable<Type> GetHandlerTypes() { 
			var workspaceTypeProvider = ClassFactory.Get<IWorkspaceTypeProvider>();
			var assemblyTypes = workspaceTypeProvider.GetTypes();
			return assemblyTypes.Where(type =>
				type.IsSubclassOf(typeof(BaseTrackingWebhookEventHandler))
					&& HasTrackingAttribute(type));
		}

		private void InitHandlers() {
			if (_handlers != null) {
				return;
			}
			lock (_lockObject) {
				if (_handlers != null) {
					return;
				}
				var processorTypes = GetHandlerTypes();
				_handlers = processorTypes.ToList();
			}
		}

		private BaseTrackingWebhookEventHandler CreateHandlerInstance(Type type) {
			return Activator.CreateInstance(type) as BaseTrackingWebhookEventHandler;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns all available tracking webhook event handlers for current assembly.
		/// </summary>
		/// <returns>List of <see cref="BaseTouchQueueMessageProcessor"/> instances.</returns>
		public virtual IEnumerable<BaseTrackingWebhookEventHandler> GetHandlers() {
			var handlers = new List<BaseTrackingWebhookEventHandler>();
			_handlers.ForEach(type => {
				var instance = CreateHandlerInstance(type);
				handlers.AddIfNotExists(instance);
			});
			return handlers;
		}

		#endregion

	}

	#endregion

}

