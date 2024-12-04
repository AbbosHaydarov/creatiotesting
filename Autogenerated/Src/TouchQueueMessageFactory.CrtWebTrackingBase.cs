namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: TouchQueueMessageFactory

	/// <summary>
	/// Class to create the touch queue message instances of the type specified.
	/// </summary>
	public class TouchQueueMessageFactory
	{

		#region Fields: Private

		private static IDictionary<string, Type> _messageTypes;

		private static readonly object _lockObject = new object();

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor for the <see cref="TouchQueueMessageFactory"/>.
		/// </summary>
		public TouchQueueMessageFactory() {
			InitMessageTypes();
		}

		#endregion

		#region Properties: Public

		private IWorkspaceTypeProvider _workspaceTypeProvider;
		internal IWorkspaceTypeProvider WorkspaceTypeProvider {
			get {
				return _workspaceTypeProvider ?? (_workspaceTypeProvider = ClassFactory.Get<IWorkspaceTypeProvider>());
			}
			set => _workspaceTypeProvider = value;
		}

		#endregion

		#region Methods: Private

		private void InitMessageTypes() {
			if (_messageTypes != null) {
				return;
			}
			lock (_lockObject) {
				if (_messageTypes != null) {
					return;
				}
				_messageTypes = GetTypesFromAssemblies(typeof(TouchQueueMessage))
					.ToDictionary(x => x.Name, x => x);
			}
		}

		private IEnumerable<Type> GetTypesFromAssemblies(Type baseType) {
			return WorkspaceTypeProvider.GetTypes()
				.Where(t => t.IsSubclassOf(baseType) && !t.IsAbstract && !t.IsGenericType 
					&& HasTouchQueueMessageAttribute(t));
		}

		private bool HasTouchQueueMessageAttribute(Type messageType)  =>
			messageType.GetCustomAttributes(typeof(TouchQueueMessageAttribute), false).Any();

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns new instance of the serialized message with expected type.
		/// </summary>
		/// <param name="baseMessage">Instance of the source <see cref="TouchQueueMessage"/>.</param>
		/// <param name="json">Serialized message.</param>
		/// <returns>Instance of <see cref="TouchQueueMessage"/> with expected type.</returns>
		public virtual TouchQueueMessage Create(TouchQueueMessage baseMessage, string json) {
			if (!_messageTypes.ContainsKey(baseMessage.TypeName)) {
				return baseMessage;
			}
			var type = _messageTypes[baseMessage.TypeName];
			var result = Json.Deserialize(json, type) as TouchQueueMessage;
			result.Id = baseMessage.Id;
			result.MaxRetryCount = baseMessage.MaxRetryCount;
			return result;
		}

		#endregion

	}

	#endregion

}
