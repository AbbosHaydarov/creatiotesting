namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Process;

	#region Class: CampaignStartFacebookFormElement

	/// <summary>
	/// Add from Facebook form schema element.
	/// </summary>
	public class CampaignStartFacebookFormElement : CampaignStartLandingElement
	{

		#region Constructors: Public

		public CampaignStartFacebookFormElement() : base() {}

		public CampaignStartFacebookFormElement(CampaignStartFacebookFormElement source) : this(source, null, null) {}

		public CampaignStartFacebookFormElement(CampaignStartFacebookFormElement source, Dictionary<Guid, Guid> dictToRebind,
				Core.Campaign.CampaignSchema parentSchema) : base(source, dictToRebind, parentSchema) {}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Identifier of element action.
		/// </summary>
		protected override Guid Action => CampaignConsts.CampaignLogTypeAddFacebookFormAudience;

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates a new instance that is a clone of the current instance.
		/// </summary>
		/// <returns>Cloned instance of the CampaignStartFacebookFormElement.</returns>
		public override object Clone() {
			return new CampaignStartFacebookFormElement(this);
		}

		/// <summary>
		/// Creates a new instance that is a copy of the current instance.
		/// </summary>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		/// <returns>Copied instance of the CampaignStartFacebookFormElement.</returns>
		public override object Copy(Dictionary<Guid, Guid> dictToRebind, Core.Campaign.CampaignSchema parentSchema) {
			return new CampaignStartFacebookFormElement(this, dictToRebind, parentSchema);
		}

		#endregion

	}

	#endregion

}
