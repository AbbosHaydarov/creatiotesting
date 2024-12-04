namespace Terrasoft.Configuration
{
	using System;

	#region Class: WebAnalyticsVisitorModel

	/// <summary>
	/// Class to represent web analytics visitor model.
	/// </summary>
	public class WebAnalyticsVisitorModel
	{

		#region Properties: Public

		/// <summary>
		/// Contact unique identifier.
		/// </summary>
		public Guid ContactId { get; set; }

		/// <summary>
		/// Web analytics visitor identifier.
		/// </summary>
		public string VisitorId { get; set; }

		/// <summary>
		/// Web analytics stream unique identifier.
		/// </summary>
		public Guid StreamId { get; set; }

		#endregion

	}

	#endregion

}
