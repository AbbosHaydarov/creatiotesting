namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: ClassicEmailPageUrlProvider

	/// <summary>
	/// Classic email page URL provider.
	/// </summary>
	[DefaultBinding(typeof(IEmailPageUrlProvider), Name = "ClassicEmailPageUrlProvider")]
	public class ClassicEmailPageUrlProvider : EmailPageUrlProviderBase
	{

		#region Constructors: Public

		/// <summary>
		/// Creates instance of <see cref="ClassicEmailPageUrlProvider"/>.
		/// </summary>
		/// <param name="userConnection">User connection</param>
		public ClassicEmailPageUrlProvider(UserConnection userConnection)
			: base(userConnection) { }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Designer type.
		/// </summary>
		public override string DesignerTypeId => "e8fff45c-1226-4c34-b26f-1e5ad88815b0";

		/// <summary>
		/// Email page URL template.
		/// </summary>
		public override string EmailPageUrlTemplate => "{0}#CardModuleV2/{1}/edit/{2}";

		/// <summary>
		/// Bulk email page name.
		/// </summary>
		public override string BulkEmailPageName => "BulkEmailPageV2";

		/// <summary>
		/// Trigger email page name.
		/// </summary>
		public override string TriggerEmailPageName => "TriggerEmailPageV2";

		#endregion

	}

	#endregion

}

