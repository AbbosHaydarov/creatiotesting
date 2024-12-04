namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using Terrasoft.Core.Entities;

	/// <summary>
	/// Represent the interface for the saving web analytics accounts.
	/// </summary>
	public interface IWebAnalyticsAccountRepositoty
	{

		#region Methods: Public

		/// <summary>
		/// Retutns collection of the unique connected web analytics accounts.
		/// </summary>
		EntityCollection GetConnectedAccounts();

		/// <summary>
		/// Saves the web analytics accounts.
		/// </summary>
		/// <param name="accountsList">The web analitycs accounts.</param>
		/// <param name="platformUserId">The platform.user id</param>
		void SaveAccounts(IEnumerable<IWebAnalyticsAccount> accountsList, string platformUserId);

		#endregion

	}
}

