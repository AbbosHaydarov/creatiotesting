namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using CoreCampaignSchema = Core.Campaign.CampaignSchema;

	#region Class: BaseWebPageConditionalTransitionElement

	/// <summary>
	/// Schema element for base web page conditional transition.
	/// </summary>
	public class BaseWebPageConditionalTransitionElement : ConditionalSequenceFlowElement
	{

		#region Constructors: Public

		/// <summary>
		/// Default consructor.
		/// </summary>
		public BaseWebPageConditionalTransitionElement() {
		}

		/// <summary>
		/// Constructor of the clone.
		/// </summary>
		/// <param name="source">Instance of <see cref="BaseWebPageConditionalTransitionElement"/>.</param>
		public BaseWebPageConditionalTransitionElement(BaseWebPageConditionalTransitionElement source)
			: this(source, null, null) {
		}

		/// <summary>
		/// Constructor of the copy.
		/// </summary>
		/// <param name="source">Instance of <see cref="BaseWebPageConditionalTransitionElement"/>.</param>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		public BaseWebPageConditionalTransitionElement(BaseWebPageConditionalTransitionElement source,
				Dictionary<Guid, Guid> dictToRebind, CoreCampaignSchema parentSchema)
					: base(source, dictToRebind, parentSchema) {
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates a new instance that is a copy of the current instance.
		/// </summary>
		/// <returns>Cloned instance of the <see cref="BaseWebPageConditionalTransitionElement"/>.</returns>
		public override object Clone() {
			return new BaseWebPageConditionalTransitionElement(this);
		}

		/// <summary>
		/// Creates a new instance that is a copy of the current instance.
		/// </summary>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		/// <returns>Copied instance of the <see cref="BaseWebPageConditionalTransitionElement"/>.</returns>
		public override object Copy(Dictionary<Guid, Guid> dictToRebind, CoreCampaignSchema parentSchema) {
			return new BaseWebPageConditionalTransitionElement(this, dictToRebind, parentSchema);
		}

		#endregion

	}

	#endregion

}

