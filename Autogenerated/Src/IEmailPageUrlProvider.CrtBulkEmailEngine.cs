namespace Terrasoft.Configuration
{
	/// <summary>
	/// Provides the bulk email designer URL.
	/// </summary>
	public interface IEmailPageUrlProvider
	{
		/// <summary>
		/// Email designer type.
		/// </summary>
		string DesignerTypeId { get; }

		/// <summary>
		/// Returns email page URL.
		/// </summary>
		/// <returns>Email page URL</returns>
		string GetEmailPageUrl(GetEmailPageUrlRequest request);
	}
}

