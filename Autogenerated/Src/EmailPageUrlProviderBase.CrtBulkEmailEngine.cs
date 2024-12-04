namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;

	#region Class: EmailPageUrlProviderBase

	/// <summary>
	/// Base class for email page URL providers.
	/// </summary>
	public abstract class EmailPageUrlProviderBase : IEmailPageUrlProvider
	{

		#region Fields: Private

		private readonly UserConnection _userConnection;
		private bool? _useNewShell;

		#endregion

		#region Constructors: Protected

		/// <summary>
		/// Creates instance of <see cref="EmailPageUrlProviderBase"/>.
		/// </summary>
		/// <param name="userConnection">User connection</param>
		protected EmailPageUrlProviderBase(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private bool UseNewShell =>
			_useNewShell ?? (_useNewShell = CoreSysSettings.GetValue(_userConnection, "UseNewShell", false)).Value;

		#endregion

		#region Properties: Public

		/// <summary>
		/// Email designer type.
		/// </summary>
		public abstract string DesignerTypeId { get; }

		/// <summary>
		/// Email page URL template.
		/// </summary>
		public abstract string EmailPageUrlTemplate { get; }

		/// <summary>
		/// Bulk email page name.
		/// </summary>
		public abstract string BulkEmailPageName { get; }

		/// <summary>
		/// Trigger email page name.
		/// </summary>
		public abstract string TriggerEmailPageName { get; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets email page URL.
		/// </summary>
		/// <param name="request">Request to get url</param>
		/// <returns>Email page url</returns>
		public string GetEmailPageUrl(GetEmailPageUrlRequest request) {
			string module = UseNewShell ? "Shell" : "Nui/ViewModule.aspx";
			string emailType = request.IsBulkEmail ? BulkEmailPageName : TriggerEmailPageName;
			string designerUrl = string.Format(EmailPageUrlTemplate, module, emailType, request.BulkEmailId);
			return designerUrl;
		}

		#endregion

	}

	#endregion

}

