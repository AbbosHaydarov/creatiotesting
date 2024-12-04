namespace Terrasoft.Configuration
{
	using Newtonsoft.Json;
	using System;
	using Terrasoft.Common.Json;

	#region Class: TouchModel

	/// <summary>
	/// Class to represent base serializable touch model to process.
	/// </summary>
	public class TouchModel: IEquatable<TouchModel>
	{

		#region Properties: Public

		[JsonIgnore]
		public Guid Id { get; set; }

		[JsonIgnore]
		public int Duration { get; set; }

		[JsonIgnore]
		public DateTime LastActionDateTime { get; set; }

		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string VisitorId { get; set; }

		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Guid ContactId { get; set; }

		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Guid WebAnalyticsVisitorId { get; set; }

		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Guid StreamId { get; set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Compares current instance with another one specified.
		/// </summary>
		/// <param name="other">Instance of the other <see cref="TouchModel"/> to compare.</param>
		/// <returns>Comparison result.</returns>
		public virtual bool Equals(TouchModel other) => Id.Equals(other.Id)
			&& Duration.Equals(other.Duration)
			&& LastActionDateTime.Equals(other.LastActionDateTime)
			&& (ContactId.Equals(other.ContactId) || WebAnalyticsVisitorId.Equals(other.WebAnalyticsVisitorId))
			&& StreamId.Equals(other.StreamId)
			&& (VisitorId == null
				? other.VisitorId == null
				: VisitorId.Equals(other.VisitorId));

		/// <inheritdoc/>
		public override string ToString() {
			return Json.Serialize(this, true);
		}

		#endregion

	}

	#endregion

}
