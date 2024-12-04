namespace Terrasoft.Configuration
{
	using System;

	/// <summary>
	/// Represent the interface for the methods to log touch actions.
	/// </summary>
	public interface ITouchEventLogger
	{

		#region Methods: Public

		/// <summary>
		/// Logs error to <see cref="TouchEventLog"/> for tracking system specified.
		/// </summary>
		/// <param name="eventName">Touch event name.</param>
		/// <param name="startDate">Event start date.</param>
		/// <param name="exception">Exception.</param>
		/// <param name="trackingId">Id of tracking system.</param>
		/// <param name="eventType">Event log type.</param>
		/// <param name="description">Event description.</param>
		void Error(string eventName, DateTime startDate, Exception exception, Guid trackingId,
				string eventType = "", string description = "");


		/// <summary>
		/// Logs success actions to <see cref="TouchEventLog"/> for tracking system specified.
		/// </summary>
		/// <param name="eventName">Touch event name.</param>
		/// <param name="startDate">Event start date.</param>
		/// <param name="trackingId">Id of tracking system.</param>
		/// <param name="eventType">Event log type.</param>
		/// <param name="amount">Message process result count.</param>
		/// <param name="description">Event description.</param>
		void Info(string eventName, DateTime startDate, Guid trackingId, string eventType = "", int amount = 0,
				string description = "");

		#endregion

	}
}

